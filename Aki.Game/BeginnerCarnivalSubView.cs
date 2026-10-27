using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011A2 RID: 4514
[NullableContext(2)]
[Nullable(0)]
public class BeginnerCarnivalSubView : ActivitySubViewBase
{
	// Token: 0x0600777F RID: 30591 RVA: 0x0018F60C File Offset: 0x0018D80C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickSelectRoleBtn)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickGachaBtn)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickShopBtn))
		};
	}

	// Token: 0x06007780 RID: 30592 RVA: 0x0018F7F7 File Offset: 0x0018D9F7
	protected override void OnSetData()
	{
		this.BeginnerCarnivalData = (this.ActivityBaseData as BeginnerCarnivalData);
	}

	// Token: 0x06007781 RID: 30593 RVA: 0x0018F80C File Offset: 0x0018DA0C
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007782 RID: 30594 RVA: 0x0018F850 File Offset: 0x0018DA50
	protected override void OnStart()
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		base.GetItem(15).SetUIActive(playerGender == EPlayerGender.Male);
		base.GetItem(16).SetUIActive(playerGender == EPlayerGender.Female);
		this.RefreshDesc();
	}

	// Token: 0x06007783 RID: 30595 RVA: 0x0018F890 File Offset: 0x0018DA90
	private void RefreshDesc()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		string descTheme = localConfig.Value.DescTheme;
		string desc = localConfig.Value.Desc;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), desc, Array.Empty<object>());
	}

	// Token: 0x06007784 RID: 30596 RVA: 0x0018F90C File Offset: 0x0018DB0C
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06007785 RID: 30597 RVA: 0x0018F970 File Offset: 0x0018DB70
	protected override void OnRefreshView()
	{
		this.RefreshTitle();
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		ActivityTask taskDataById = beginnerCarnivalData.GetTaskDataById(beginnerCarnivalData.GetRoleTaskId);
		if (taskDataById == null)
		{
			return;
		}
		bool uiactive = taskDataById.Status == ActivityTaskState.ActivityTaskTaken;
		base.GetItem(7).SetUIActive(uiactive);
		base.GetTexture(6).SetUIActive(uiactive);
		int choseRoleId = beginnerCarnivalData.ChoseRoleId;
		bool flag = choseRoleId > 0;
		base.GetItem(8).SetUIActive(!flag);
		base.GetTexture(5).SetUIActive(flag);
		if (flag)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(choseRoleId);
			base.SetTextureByPath(roleConfig.Value.RoleHeadIcon, base.GetTexture(5), null, null);
			base.SetTextureByPath(roleConfig.Value.RoleHeadIcon, base.GetTexture(6), null, null);
		}
		NewbieCarnivalParam? newbieCarnivalParam = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalParam(BeginnerCarnivalController.Instance.ActivityId);
		base.GetText(9).SetText("<color=#f5cf47>" + beginnerCarnivalData.GetCurrentItemCount().ToString() + "</color>/" + ((newbieCarnivalParam != null) ? new int?(newbieCarnivalParam.GetValueOrDefault().AllCount) : null).ToString(), true);
		base.GetItem(14).SetUIActive(beginnerCarnivalData.GetRoleGetTaskTabRedDotShow(5));
		if (FunctionModel.Instance.IsOpen(10009))
		{
			ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(beginnerCarnivalData.GachaId[0]);
			ProtoGachaInfo gachaInfo2 = GachaModel.Instance.GetGachaInfo(beginnerCarnivalData.GachaId[1]);
			base.GetButton(12).RootUIComp.Get().SetUIActive(gachaInfo != null || gachaInfo2 != null);
		}
		else
		{
			base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		}
		bool flag2 = false;
		foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.GiftBag, 5, true))
		{
			IRemainingData remainingData = payShopGoods.GetRemainingData();
			if (remainingData != null && remainingData.Count > 0)
			{
				flag2 = true;
				break;
			}
		}
		bool flag3 = FunctionModel.Instance.IsOpen(10010);
		base.GetButton(10).RootUIComp.Get().SetUIActive(flag2 && flag3);
		base.GetItem(11).SetUIActive(!beginnerCarnivalData.GetHaveShopEnter());
		base.GetItem(13).SetUIActive(!beginnerCarnivalData.GetHaveGachaEnter());
		ActivityFunctionalTypeA bottomComponent = this.BottomComponent;
		if (bottomComponent == null)
		{
			return;
		}
		bottomComponent.SetFunctionRedDotVisible(beginnerCarnivalData.GetAnyTaskRedDotShow());
	}

	// Token: 0x06007786 RID: 30598 RVA: 0x0018FC3C File Offset: 0x0018DE3C
	private void OnClickTaskBtn()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalMainView, null, null);
		});
	}

	// Token: 0x06007787 RID: 30599 RVA: 0x0018FC5C File Offset: 0x0018DE5C
	private void OnClickSelectRoleBtn()
	{
		if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalRoleTaskView, null, null);
	}

	// Token: 0x06007788 RID: 30600 RVA: 0x0018FCAC File Offset: 0x0018DEAC
	private void OnClickShopBtn()
	{
		if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			return;
		}
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.GiftBag, 5);
		beginnerCarnivalData.SetShopEnter();
	}

	// Token: 0x06007789 RID: 30601 RVA: 0x0018FD04 File Offset: 0x0018DF04
	private void OnClickGachaBtn()
	{
		if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			return;
		}
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(beginnerCarnivalData.GachaId[0]);
		ProtoGachaInfo gachaInfo2 = GachaModel.Instance.GetGachaInfo(beginnerCarnivalData.GachaId[1]);
		if (gachaInfo != null || gachaInfo2 != null)
		{
			GachaController.Instance.OpenGachaView((gachaInfo != null) ? beginnerCarnivalData.GachaId[0] : beginnerCarnivalData.GachaId[1]);
		}
		else
		{
			GachaController.Instance.OpenGachaView(0);
		}
		beginnerCarnivalData.SetGachaEnter();
	}

	// Token: 0x040036F9 RID: 14073
	private const int ROLE_TAB_INDEX = 5;

	// Token: 0x040036FA RID: 14074
	private const int CARNIVAL_SHOP_TAB_ID = 5;

	// Token: 0x040036FB RID: 14075
	private BeginnerCarnivalData BeginnerCarnivalData;

	// Token: 0x040036FC RID: 14076
	private ActivityFunctionalTypeA BottomComponent;

	// Token: 0x040036FD RID: 14077
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040036FE RID: 14078
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;
}
