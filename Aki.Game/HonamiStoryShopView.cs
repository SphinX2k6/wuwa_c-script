using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013B3 RID: 5043
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopView : UiViewBase
{
	// Token: 0x0600C7E0 RID: 51168 RVA: 0x003B7F7E File Offset: 0x003B617E
	public HonamiStoryShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7E1 RID: 51169 RVA: 0x003B7F94 File Offset: 0x003B6194
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBagButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C7E2 RID: 51170 RVA: 0x003B80BE File Offset: 0x003B62BE
	public override bool GetBgmSwitch()
	{
		return !HonamiStoryUtil.CheckInHonamiStoryDungeon();
	}

	// Token: 0x0600C7E3 RID: 51171 RVA: 0x003B80C8 File Offset: 0x003B62C8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7E4 RID: 51172 RVA: 0x003B810C File Offset: 0x003B630C
	protected override void OnBeforeShow()
	{
		int shopId = this.ActivityData.ShopId;
		if (shopId > 0)
		{
			PayShop payShopConfig = PayShopConfig.Instance.GetPayShopConfig(shopId);
			this.PopupCaption.SetCurrencyItemList(payShopConfig.Money());
			PayShopController.Instance.SendRequestPayShopUpdate((PayShopDefine.EPayShopTabType)shopId, false, null);
		}
		this.CheckPlayPerformance(EHonamiStoryOutDialogType.OpenShop);
		this.HideCharacter();
	}

	// Token: 0x0600C7E5 RID: 51173 RVA: 0x003B8163 File Offset: 0x003B6363
	protected override void OnBeforeHide()
	{
		this.ShowCharacter();
	}

	// Token: 0x0600C7E6 RID: 51174 RVA: 0x003B816B File Offset: 0x003B636B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshShop));
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
	}

	// Token: 0x0600C7E7 RID: 51175 RVA: 0x003B81A5 File Offset: 0x003B63A5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshShop));
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
	}

	// Token: 0x0600C7E8 RID: 51176 RVA: 0x003B81E0 File Offset: 0x003B63E0
	private void CheckPlayPerformance(EHonamiStoryOutDialogType dialogType)
	{
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData((int)dialogType);
		if (randomDialogData == null)
		{
			return;
		}
		double num;
		if (!this.LastTimeMap.TryGetValue(dialogType, out num))
		{
			num = 0.0;
		}
		if (Math.Abs(Time.Instance.ServerTimeStamp - num) < (double)(randomDialogData.Value.Interval * 1000))
		{
			return;
		}
		this.LastTimeMap[dialogType] = Time.Instance.ServerTimeStamp;
		this.PlayPlot(randomDialogData.Value);
		this.PlayNpcMontage(randomDialogData.Value);
		this.PlayAudio(randomDialogData.Value);
	}

	// Token: 0x0600C7E9 RID: 51177 RVA: 0x003B8284 File Offset: 0x003B6484
	private void PlayPlot(HonamiStoryOutDialog outDialog)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), outDialog.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), outDialog.Desc, Array.Empty<object>());
	}

	// Token: 0x0600C7EA RID: 51178 RVA: 0x003B82C0 File Offset: 0x003B64C0
	private void PlayNpcMontage(HonamiStoryOutDialog outDialog)
	{
		int entityId = outDialog.EntityId;
		if (entityId <= 0)
		{
			return;
		}
		int entityIdByPbDataId = CreatureModel.Instance.GetEntityIdByPbDataId(entityId);
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityIdByPbDataId);
		if (entityById != null)
		{
			WorldEntity entity = entityById.Entity;
			object obj = (entity != null) ? entity.GetComponent<NpcPerformComponent>() : null;
			WorldEntity entity2 = entityById.Entity;
			BaseAnimationComponent baseAnimationComponent = (entity2 != null) ? entity2.GetComponent<BaseAnimationComponent>() : null;
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2.PlayPerformMontage(EPerformMode.Action, new IPlayMontageParam
			{
				MontagePath = ((baseAnimationComponent != null) ? baseAnimationComponent.GetMontageResPathByName(outDialog.MontagePath) : null)
			}, null, null, false);
		}
	}

	// Token: 0x0600C7EB RID: 51179 RVA: 0x003B8347 File Offset: 0x003B6547
	private void PlayAudio(HonamiStoryOutDialog outDialog)
	{
		if (outDialog.AudioEvent != "")
		{
			AudioSystem.Instance.PostEvent(outDialog.AudioEvent);
		}
	}

	// Token: 0x0600C7EC RID: 51180 RVA: 0x003B8370 File Offset: 0x003B6570
	private void HideCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "HonamiStoryShopView", false);
		}
	}

	// Token: 0x0600C7ED RID: 51181 RVA: 0x003B83A4 File Offset: 0x003B65A4
	private void ShowCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "HonamiStoryShopView", false);
		}
	}

	// Token: 0x0600C7EE RID: 51182 RVA: 0x003B83D8 File Offset: 0x003B65D8
	private void RefreshShop(int _1, bool _2)
	{
		int shopId = this.ActivityData.ShopId;
		this.ActivityShopScrollItem.Refresh(shopId);
	}

	// Token: 0x0600C7EF RID: 51183 RVA: 0x003B83FE File Offset: 0x003B65FE
	private void HandleBuyItem()
	{
		this.CheckPlayPerformance(EHonamiStoryOutDialogType.BuyGoodsInShop);
	}

	// Token: 0x0600C7F0 RID: 51184 RVA: 0x003B8408 File Offset: 0x003B6608
	private void OnClickBack()
	{
		PayShopModel.Instance.ReadShopItemCheckFlag((PayShopDefine.EPayShopTabType)this.ActivityData.ShopId, 1);
		base.CloseMe(null);
	}

	// Token: 0x0600C7F1 RID: 51185 RVA: 0x003B8428 File Offset: 0x003B6628
	private void OnClickBagButton()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x040071BF RID: 29119
	private HonamiStoryActivityData ActivityData;

	// Token: 0x040071C0 RID: 29120
	public PopupCaptionItem PopupCaption;

	// Token: 0x040071C1 RID: 29121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HonamiStoryShopScrollItem<HonamiStoryShopGridItem> ActivityShopScrollItem;

	// Token: 0x040071C2 RID: 29122
	private Dictionary<EHonamiStoryOutDialogType, double> LastTimeMap = new Dictionary<EHonamiStoryOutDialogType, double>();

	// Token: 0x0200766C RID: 30316
	[NullableContext(0)]
	private enum EHonamiStoryShopComponent
	{
		// Token: 0x04026721 RID: 157473
		ItemCaption,
		// Token: 0x04026722 RID: 157474
		NameText,
		// Token: 0x04026723 RID: 157475
		DescText,
		// Token: 0x04026724 RID: 157476
		ItemScroller,
		// Token: 0x04026725 RID: 157477
		Item,
		// Token: 0x04026726 RID: 157478
		BagButton
	}
}
