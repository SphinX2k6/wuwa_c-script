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

// Token: 0x02000FEB RID: 4075
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopView : UiViewBase
{
	// Token: 0x06006897 RID: 26775 RVA: 0x0014C983 File Offset: 0x0014AB83
	public FurnitureShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006898 RID: 26776 RVA: 0x0014C998 File Offset: 0x0014AB98
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

	// Token: 0x06006899 RID: 26777 RVA: 0x0014CA34 File Offset: 0x0014AC34
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureShopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureShopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600689A RID: 26778 RVA: 0x0014CA77 File Offset: 0x0014AC77
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		this.HideCharacter();
		this.PlayNpcPerformance();
		this.EnableSpareShopNpcEntity();
	}

	// Token: 0x0600689B RID: 26779 RVA: 0x0014CA94 File Offset: 0x0014AC94
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

	// Token: 0x0600689C RID: 26780 RVA: 0x0014CAE8 File Offset: 0x0014ACE8
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
		this.ShowCharacter();
		this.DisableSpareShopNpcEntity();
	}

	// Token: 0x0600689D RID: 26781 RVA: 0x0014CAFC File Offset: 0x0014ACFC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnRefreshShop));
	}

	// Token: 0x0600689E RID: 26782 RVA: 0x0014CB1A File Offset: 0x0014AD1A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ActivityPayShopGoodsBuy, new Action<int, IReadOnlyList<ActivityBuyItem>, string>(this.OnRefreshShop));
	}

	// Token: 0x0600689F RID: 26783 RVA: 0x0014CB38 File Offset: 0x0014AD38
	protected virtual void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("FurnitureShopView");
	}

	// Token: 0x060068A0 RID: 26784 RVA: 0x0014CB49 File Offset: 0x0014AD49
	protected virtual void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FurnitureShopView");
	}

	// Token: 0x060068A1 RID: 26785 RVA: 0x0014CB5C File Offset: 0x0014AD5C
	private void HideCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, false, true, true, "FurnitureShopView", false);
		}
	}

	// Token: 0x060068A2 RID: 26786 RVA: 0x0014CB90 File Offset: 0x0014AD90
	private void ShowCharacter()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			CreatureController.Instance.SetActorVisible(getCurrentEntity.Entity, true, true, true, "FurnitureShopView", false);
		}
	}

	// Token: 0x060068A3 RID: 26787 RVA: 0x0014CBC4 File Offset: 0x0014ADC4
	private void EnableSpareShopNpcEntity()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData == null || !furnitureShopViewOpenData.UseSpareShopNpc)
		{
			return;
		}
		FurnitureModel.Instance.FurnitureEntityVisibleManager.EnableSpareShopNpcEntity();
	}

	// Token: 0x060068A4 RID: 26788 RVA: 0x0014CBF8 File Offset: 0x0014ADF8
	private void DisableSpareShopNpcEntity()
	{
		IFurnitureShopViewOpenData furnitureShopViewOpenData = this.OpenParam as IFurnitureShopViewOpenData;
		if (furnitureShopViewOpenData == null || !furnitureShopViewOpenData.UseSpareShopNpc)
		{
			return;
		}
		FurnitureModel.Instance.FurnitureEntityVisibleManager.DisableSpareShopNpcEntity();
	}

	// Token: 0x060068A5 RID: 26789 RVA: 0x0014CC2C File Offset: 0x0014AE2C
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

	// Token: 0x060068A6 RID: 26790 RVA: 0x0014CCE1 File Offset: 0x0014AEE1
	private void OnRefreshShop(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version)
	{
		this.RefreshShop();
	}

	// Token: 0x060068A7 RID: 26791 RVA: 0x0014CCEC File Offset: 0x0014AEEC
	private void RefreshShop()
	{
		UiAsyncTask task = new UiAsyncTask("RefreshShop", new Func<UniTask>(this.RefreshShopAsync), null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x060068A8 RID: 26792 RVA: 0x0014CD20 File Offset: 0x0014AF20
	private UniTask RefreshShopAsync()
	{
		FurnitureShopView.<RefreshShopAsync>d__23 <RefreshShopAsync>d__;
		<RefreshShopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshShopAsync>d__.<>4__this = this;
		<RefreshShopAsync>d__.<>1__state = -1;
		<RefreshShopAsync>d__.<>t__builder.Start<FurnitureShopView.<RefreshShopAsync>d__23>(ref <RefreshShopAsync>d__);
		return <RefreshShopAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068A9 RID: 26793 RVA: 0x0014CD63 File Offset: 0x0014AF63
	private void OnDropDownSelect(int index, FurnitureFilterConfig data)
	{
		this.CurrentFilterConfig = new FurnitureFilterConfig?(this.FilterConfigList[index]);
		this.RefreshShop();
	}

	// Token: 0x060068AA RID: 26794 RVA: 0x0014CD82 File Offset: 0x0014AF82
	private void OnClickBack()
	{
		FurnitureController.Instance.SetAllFurnitureShopItemRedDotAsRead();
		base.CloseMe(null);
	}

	// Token: 0x04002FE7 RID: 12263
	private int ShopId;

	// Token: 0x04002FE8 RID: 12264
	private FurnitureFilterConfig? CurrentFilterConfig;

	// Token: 0x04002FE9 RID: 12265
	private IReadOnlyList<FurnitureFilterConfig> FilterConfigList = new List<FurnitureFilterConfig>();

	// Token: 0x04002FEA RID: 12266
	public PopupCaptionItem PopupCaption;

	// Token: 0x04002FEB RID: 12267
	[Nullable(2)]
	private FurnitureShopScrollItem ShopScrollItem;

	// Token: 0x04002FEC RID: 12268
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, FurnitureFilterConfig> FilterDropDownList;
}
