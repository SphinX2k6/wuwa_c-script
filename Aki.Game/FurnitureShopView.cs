using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020004A0 RID: 1184
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopView : UiViewBase
{
	// Token: 0x06003C2F RID: 15407 RVA: 0x00155247 File Offset: 0x00153447
	public FurnitureShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x0015525C File Offset: 0x0015345C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x001552F8 File Offset: 0x001534F8
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C32 RID: 15410 RVA: 0x0015533B File Offset: 0x0015353B
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		this.HideCharacter();
		this.PlayNpcPerformance();
		this.EnableSpareShopNpcEntity();
	}

	// Token: 0x06003C33 RID: 15411 RVA: 0x00155358 File Offset: 0x00153558
	protected override void OnAfterShow()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData.GoodsId > 0)
		{
			FurnitureShopExchangePopViewProxy furnitureShopExchangePopViewProxy = new FurnitureShopExchangePopViewProxy();
			PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(furnitureShopViewOpenData.GoodsId);
			if (payShopGoods != null)
			{
				furnitureShopExchangePopViewProxy.UpdateFromPayShopGoods(payShopGoods);
				UiManager.Instance.OpenView(EUiViewName.GameplayExchangePopView, furnitureShopExchangePopViewProxy, null);
			}
		}
	}

	// Token: 0x06003C34 RID: 15412 RVA: 0x001553AC File Offset: 0x001535AC
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
		this.ShowCharacter();
		this.DisableSpareShopNpcEntity();
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x001553C0 File Offset: 0x001535C0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnRefreshShop));
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x001553DE File Offset: 0x001535DE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnRefreshShop));
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x001553FC File Offset: 0x001535FC
	protected virtual void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("FurnitureShopView");
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x0015540D File Offset: 0x0015360D
	protected virtual void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FurnitureShopView");
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x00155420 File Offset: 0x00153620
	private void HideCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "FurnitureShopView", false);
		}
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x00155454 File Offset: 0x00153654
	private void ShowCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "FurnitureShopView", false);
		}
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x00155488 File Offset: 0x00153688
	private void EnableSpareShopNpcEntity()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData == null || !furnitureShopViewOpenData.UseSpareShopNpc)
		{
			return;
		}
		FurnitureModel.Instance.FurnitureEntityVisibleManager.EnableSpareShopNpcEntity();
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x001554BC File Offset: 0x001536BC
	private void DisableSpareShopNpcEntity()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData == null || !furnitureShopViewOpenData.UseSpareShopNpc)
		{
			return;
		}
		FurnitureModel.Instance.FurnitureEntityVisibleManager.DisableSpareShopNpcEntity();
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x001554F0 File Offset: 0x001536F0
	private void PlayNpcPerformance()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData != null)
		{
			int npcEntityId = furnitureShopViewOpenData.NpcEntityId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), furnitureShopViewOpenData.NpcName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), furnitureShopViewOpenData.NpcDesc, Array.Empty<object>());
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(furnitureShopViewOpenData.NpcEntityId);
			if (entityByPbDataId != null)
			{
				NpcPerformComponent component = entityByPbDataId.Entity.GetComponent<NpcPerformComponent>();
				BaseAnimationComponent component2 = entityByPbDataId.Entity.GetComponent<BaseAnimationComponent>();
				if (component != null)
				{
					component.PlayPerformMontage(EPerformMode.Action, new IPlayMontageParam
					{
						MontagePath = ((component2 != null) ? component2.GetMontageResPathByName(furnitureShopViewOpenData.NpcStartMontagePath) : null)
					}, null, null, false);
				}
			}
			return;
		}
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x001555A5 File Offset: 0x001537A5
	private void OnRefreshShop(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
	{
		this.RefreshShop();
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x001555B0 File Offset: 0x001537B0
	private void RefreshShop()
	{
		UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x001555E4 File Offset: 0x001537E4
	private UniTask RefreshShopAsync()
	{
		FurnitureShopView.<RefreshShopAsync>d__23 <RefreshShopAsync>d__;
		<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshShopAsync>d__.<>4__this = this;
		<RefreshShopAsync>d__.<>1__state = -1;
		<RefreshShopAsync>d__.<>t__builder.Start<FurnitureShopView.<RefreshShopAsync>d__23>(ref <RefreshShopAsync>d__);
		return <RefreshShopAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x00155627 File Offset: 0x00153827
	private void OnDropDownSelect(int index, FurnitureFilterConfig data)
	{
		this.CurrentFilterConfig = new FurnitureFilterConfig?(this.FilterConfigList[index]);
		this.RefreshShop();
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x00155646 File Offset: 0x00153846
	private void OnClickBack()
	{
		FurnitureController.Instance.SetAllFurnitureShopItemRedDotAsRead();
		base.CloseMe(null);
	}

	// Token: 0x04003080 RID: 12416
	private int ShopId;

	// Token: 0x04003081 RID: 12417
	private FurnitureFilterConfig? CurrentFilterConfig;

	// Token: 0x04003082 RID: 12418
	private IReadOnlyList<FurnitureFilterConfig> FilterConfigList = new List<FurnitureFilterConfig>();

	// Token: 0x04003083 RID: 12419
	public PopupCaptionItem PopupCaption;

	// Token: 0x04003084 RID: 12420
	[Nullable(2)]
	private FurnitureShopScrollItem ShopScrollItem;

	// Token: 0x04003085 RID: 12421
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, FurnitureFilterConfig> FilterDropDownList;
}
