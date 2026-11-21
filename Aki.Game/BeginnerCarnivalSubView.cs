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

// Token: 0x02000656 RID: 1622
[NullableContext(2)]
[Nullable(0)]
public class BeginnerCarnivalSubView : ActivitySubViewBase
{
	// Token: 0x06004B16 RID: 19222 RVA: 0x001981F0 File Offset: 0x001963F0
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

	// Token: 0x06004B17 RID: 19223 RVA: 0x001983DB File Offset: 0x001965DB
	protected override void OnSetData()
	{
		this.BeginnerCarnivalData = (this.ActivityBaseData as BeginnerCarnivalData);
	}

	// Token: 0x06004B18 RID: 19224 RVA: 0x001983F0 File Offset: 0x001965F0
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004B19 RID: 19225 RVA: 0x00198434 File Offset: 0x00196634
	protected override void OnStart()
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		base.GetItem(15).SetUIActive(playerGender == EPlayerGender.Male);
		base.GetItem(16).SetUIActive(playerGender == EPlayerGender.Female);
		this.RefreshDesc();
	}

	// Token: 0x06004B1A RID: 19226 RVA: 0x00198474 File Offset: 0x00196674
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

	// Token: 0x06004B1B RID: 19227 RVA: 0x001984F0 File Offset: 0x001966F0
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

	// Token: 0x06004B1C RID: 19228 RVA: 0x00198554 File Offset: 0x00196754
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

	// Token: 0x06004B1D RID: 19229 RVA: 0x00198820 File Offset: 0x00196A20
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

	// Token: 0x06004B1E RID: 19230 RVA: 0x00198840 File Offset: 0x00196A40
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

	// Token: 0x06004B1F RID: 19231 RVA: 0x00198890 File Offset: 0x00196A90
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

	// Token: 0x06004B20 RID: 19232 RVA: 0x001988E8 File Offset: 0x00196AE8
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

	// Token: 0x04003792 RID: 14226
	private const int ROLE_TAB_INDEX = 5;

	// Token: 0x04003793 RID: 14227
	private const int CARNIVAL_SHOP_TAB_ID = 5;

	// Token: 0x04003794 RID: 14228
	private BeginnerCarnivalData BeginnerCarnivalData;

	// Token: 0x04003795 RID: 14229
	private ActivityFunctionalTypeA BottomComponent;

	// Token: 0x04003796 RID: 14230
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003797 RID: 14231
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;
}
