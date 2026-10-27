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

// Token: 0x02001EF1 RID: 7921
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopView : UiViewBase
{
	// Token: 0x0600F3C1 RID: 62401 RVA: 0x003AC482 File Offset: 0x003AA682
	public HonamiStoryShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3C2 RID: 62402 RVA: 0x003AC498 File Offset: 0x003AA698
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

	// Token: 0x0600F3C3 RID: 62403 RVA: 0x003AC5C2 File Offset: 0x003AA7C2
	public override bool GetLoopAudioEventSwitch()
	{
		return !HonamiStoryUtil.CheckInHonamiStoryDungeon();
	}

	// Token: 0x0600F3C4 RID: 62404 RVA: 0x003AC5CC File Offset: 0x003AA7CC
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F3C5 RID: 62405 RVA: 0x003AC610 File Offset: 0x003AA810
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

	// Token: 0x0600F3C6 RID: 62406 RVA: 0x003AC667 File Offset: 0x003AA867
	protected override void OnBeforeHide()
	{
		this.ShowCharacter();
	}

	// Token: 0x0600F3C7 RID: 62407 RVA: 0x003AC66F File Offset: 0x003AA86F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshShop));
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
	}

	// Token: 0x0600F3C8 RID: 62408 RVA: 0x003AC6A9 File Offset: 0x003AA8A9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshShop));
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.HandleBuyItem));
	}

	// Token: 0x0600F3C9 RID: 62409 RVA: 0x003AC6E4 File Offset: 0x003AA8E4
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

	// Token: 0x0600F3CA RID: 62410 RVA: 0x003AC788 File Offset: 0x003AA988
	private void PlayPlot(HonamiStoryOutDialog outDialog)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), outDialog.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), outDialog.Desc, Array.Empty<object>());
	}

	// Token: 0x0600F3CB RID: 62411 RVA: 0x003AC7C4 File Offset: 0x003AA9C4
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

	// Token: 0x0600F3CC RID: 62412 RVA: 0x003AC84B File Offset: 0x003AAA4B
	private void PlayAudio(HonamiStoryOutDialog outDialog)
	{
		if (outDialog.AudioEvent != "")
		{
			AudioSystem.Instance.PostEvent(outDialog.AudioEvent);
		}
	}

	// Token: 0x0600F3CD RID: 62413 RVA: 0x003AC874 File Offset: 0x003AAA74
	private void HideCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "HonamiStoryShopView", false);
		}
	}

	// Token: 0x0600F3CE RID: 62414 RVA: 0x003AC8A8 File Offset: 0x003AAAA8
	private void ShowCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "HonamiStoryShopView", false);
		}
	}

	// Token: 0x0600F3CF RID: 62415 RVA: 0x003AC8DC File Offset: 0x003AAADC
	private void RefreshShop(int _1, bool _2)
	{
		int shopId = this.ActivityData.ShopId;
		this.ActivityShopScrollItem.Refresh(shopId);
	}

	// Token: 0x0600F3D0 RID: 62416 RVA: 0x003AC902 File Offset: 0x003AAB02
	private void HandleBuyItem()
	{
		this.CheckPlayPerformance(EHonamiStoryOutDialogType.BuyGoodsInShop);
	}

	// Token: 0x0600F3D1 RID: 62417 RVA: 0x003AC90C File Offset: 0x003AAB0C
	private void OnClickBack()
	{
		PayShopModel.Instance.ReadShopItemCheckFlag((PayShopDefine.EPayShopTabType)this.ActivityData.ShopId, 1);
		base.CloseMe(null);
	}

	// Token: 0x0600F3D2 RID: 62418 RVA: 0x003AC92C File Offset: 0x003AAB2C
	private void OnClickBagButton()
	{
		HonamiStoryController.Instance.OpenHonamiStoryBag();
	}

	// Token: 0x040070DE RID: 28894
	private HonamiStoryActivityData ActivityData;

	// Token: 0x040070DF RID: 28895
	public PopupCaptionItem PopupCaption;

	// Token: 0x040070E0 RID: 28896
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HonamiStoryShopScrollItem<HonamiStoryShopGridItem> ActivityShopScrollItem;

	// Token: 0x040070E1 RID: 28897
	private Dictionary<EHonamiStoryOutDialogType, double> LastTimeMap = new Dictionary<EHonamiStoryOutDialogType, double>();

	// Token: 0x020084E7 RID: 34023
	[NullableContext(0)]
	private enum EHonamiStoryShopComponent
	{
		// Token: 0x0402B3FD RID: 177149
		ItemCaption,
		// Token: 0x0402B3FE RID: 177150
		NameText,
		// Token: 0x0402B3FF RID: 177151
		DescText,
		// Token: 0x0402B400 RID: 177152
		ItemScroller,
		// Token: 0x0402B401 RID: 177153
		Item,
		// Token: 0x0402B402 RID: 177154
		BagButton
	}
}
