using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001687 RID: 5767
[NullableContext(1)]
[Nullable(0)]
public class LordGymEntranceView : UiViewBase
{
	// Token: 0x0600E079 RID: 57465 RVA: 0x0041E02D File Offset: 0x0041C22D
	public LordGymEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E07A RID: 57466 RVA: 0x0041E038 File Offset: 0x0041C238
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIText)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(24, typeof(UUIText)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnClose)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickBtnLord)),
			new ValueTuple<int, Delegate>(19, new Action(this.OnClickBtnBegin)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickRecord)),
			new ValueTuple<int, Delegate>(23, new Action(this.OnClickShop))
		};
	}

	// Token: 0x0600E07B RID: 57467 RVA: 0x0041E324 File Offset: 0x0041C524
	private UniTask InitScroll()
	{
		LordGymEntranceView.<InitScroll>d__11 <InitScroll>d__;
		<InitScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitScroll>d__.<>4__this = this;
		<InitScroll>d__.<>1__state = -1;
		<InitScroll>d__.<>t__builder.Start<LordGymEntranceView.<InitScroll>d__11>(ref <InitScroll>d__);
		return <InitScroll>d__.<>t__builder.Task;
	}

	// Token: 0x0600E07C RID: 57468 RVA: 0x0041E368 File Offset: 0x0041C568
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymEntranceView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymEntranceView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E07D RID: 57469 RVA: 0x0041E3AB File Offset: 0x0041C5AB
	protected override void OnAfterShow()
	{
		if (!LordGymController.Instance.IsInEntranceEntity())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600E07E RID: 57470 RVA: 0x0041E3C0 File Offset: 0x0041C5C0
	protected override void OnStart()
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(this.LordList[0]);
		if (lordGymConfig == null)
		{
			return;
		}
		int monsterId = lordGymConfig.Value.MonsterList(0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LordGymConfig.Instance.GetLordGymEntranceName(this.LordEntranceId) ?? "", Array.Empty<object>());
		string monsterBigIcon = MonsterInfoConfig.Instance.GetMonsterBigIcon(monsterId);
		base.SetTextureByPath(monsterBigIcon, base.GetTexture(9), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "SpecialRule", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "FirstPassReward", Array.Empty<object>());
		this.SetDefaultSelect();
	}

	// Token: 0x0600E07F RID: 57471 RVA: 0x0041E494 File Offset: 0x0041C694
	private void SetDefaultSelect()
	{
		this.DefaultLord = this.LordList[0];
		foreach (int num in this.LordList)
		{
			if (LordGymModel.Instance.GetLordGymIsUnLock(num) && LordGymModel.Instance.GetLastGymFinish(num) && num >= this.DefaultLord)
			{
				this.DefaultLord = num;
			}
		}
		GenericScrollViewNew<LordGymItem, int> lordScroll = this.LordScroll;
		GenericLayout<LordGymItem, int> genericLayout = (lordScroll != null) ? lordScroll.GetGenericLayout() : null;
		LordGymItem lordGymItem = (genericLayout != null) ? genericLayout.GetLayoutItemByKey(this.DefaultLord) : null;
		if (genericLayout != null)
		{
			genericLayout.SelectGridProxy(lordGymItem.GridIndex, false);
		}
		this.OnRefreshView(this.DefaultLord);
	}

	// Token: 0x0600E080 RID: 57472 RVA: 0x0041E568 File Offset: 0x0041C768
	protected override void OnBeforeDestroy()
	{
		this.LordScroll = null;
		this.RewardScroll = null;
	}

	// Token: 0x0600E081 RID: 57473 RVA: 0x0041E578 File Offset: 0x0041C778
	private LordGymItem CreateLordItem()
	{
		return new LordGymItem(new Action<int>(this.OnRefreshView), new Func<int, bool>(this.CanChangeLoreToggleState));
	}

	// Token: 0x0600E082 RID: 57474 RVA: 0x0041E597 File Offset: 0x0041C797
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600E083 RID: 57475 RVA: 0x0041E59E File Offset: 0x0041C79E
	private void OnClickBtnClose()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600E084 RID: 57476 RVA: 0x0041E5B6 File Offset: 0x0041C7B6
	private void OnClickBtnLord()
	{
		if (this.HelpId > 0)
		{
			HelpController.Instance.OpenHelpById(this.HelpId);
		}
	}

	// Token: 0x0600E085 RID: 57477 RVA: 0x0041E5D1 File Offset: 0x0041C7D1
	private void OnClickBtnBegin()
	{
		if (!LordGymController.Instance.IsInEntranceEntity())
		{
			return;
		}
		LordGymController.Instance.LordGymBeginRequest(this.SelectLordId).ContinueWith(delegate(bool isSuccess)
		{
			if (isSuccess)
			{
				base.CloseMe(null);
			}
		});
	}

	// Token: 0x0600E086 RID: 57478 RVA: 0x0041E602 File Offset: 0x0041C802
	private void OnClickRecord()
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeRecordView, this.LordEntranceId, null);
	}

	// Token: 0x0600E087 RID: 57479 RVA: 0x0041E61F File Offset: 0x0041C81F
	private void OnClickShop()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 2);
	}

	// Token: 0x0600E088 RID: 57480 RVA: 0x0041E630 File Offset: 0x0041C830
	private void OnRefreshView(int lordId)
	{
		this.SelectLordId = lordId;
		GenericScrollViewNew<LordGymItem, int> lordScroll = this.LordScroll;
		GenericLayout<LordGymItem, int> genericLayout = (lordScroll != null) ? lordScroll.GetGenericLayout() : null;
		LordGymItem lordGymItem = (genericLayout != null) ? genericLayout.GetLayoutItemByKey(this.SelectLordId) : null;
		if (genericLayout != null)
		{
			genericLayout.SelectGridProxy(lordGymItem.GridIndex, false);
		}
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(value.MonsterLevel.ToString()));
		int rewardId = value.RewardId;
		this.RewardReceived = !ExchangeRewardModel.Instance.GetRewardIfCanExchange(rewardId);
		List<TItem> exchangeRewardPreviewRewardList = ExchangeRewardConfig.Instance.GetExchangeRewardPreviewRewardList(rewardId, null);
		bool isPass = LordGymModel.Instance.GetLordGymIsFinish(this.SelectLordId);
		this.RewardScroll.RefreshByDataAsync(exchangeRewardPreviewRewardList, false).Finally(delegate()
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardScroll.GetScrollItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(isPass);
			}
		});
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), value.PlayDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.GymTitle, Array.Empty<object>());
		LordGymPassRecord lordGymPassRecord;
		LordGymModel.Instance.LordGymRecord.TryGetValue(this.SelectLordId, out lordGymPassRecord);
		if (lordGymPassRecord != null && lordGymPassRecord != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(24), "BestPassTime", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetTimeString((double)lordGymPassRecord.PassTime)));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(24), "NoPassRecord", Array.Empty<object>());
		}
		if (value.HelpId != 0)
		{
			UUIItem uuiitem = base.GetButton(10).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
			this.HelpId = value.HelpId;
		}
		else
		{
			UUIItem uuiitem2 = base.GetButton(10).RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(false);
			}
		}
		bool flag = !LordGymModel.Instance.GetLordGymIsUnLock(this.SelectLordId);
		bool lastGymFinish = LordGymModel.Instance.GetLastGymFinish(this.SelectLordId);
		bool flag2 = (float)value.MonsterLevel > FormationModel.Instance.GetFormationAverageLevel();
		base.GetItem(20).SetUIActive(flag || !lastGymFinish);
		base.GetItem(25).SetUIActive(flag2 && !flag && lastGymFinish);
		UUIItem uuiitem3 = base.GetButton(19).RootUIComp.Get();
		if (uuiitem3 != null)
		{
			uuiitem3.SetUIActive(!flag && lastGymFinish);
		}
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), value.LockDescription, Array.Empty<object>());
		}
		else if (!lastGymFinish)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "LordGymLockTips", Array.Empty<object>());
		}
		else if (flag2)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "LordGymLowLevel", Array.Empty<object>());
		}
		if (this.RewardReceived)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(22), "Text_ButtonTextChallengeOneMore_Text", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(22), "Text_StartBattle_Text", Array.Empty<object>());
		}
		if (!LordGymModel.Instance.GetLordGymHasRead(lordId) && !flag && lastGymFinish)
		{
			LordGymController.Instance.ReadLordGym(lordId);
			if (lordGymItem != null)
			{
				lordGymItem.RefreshByLordId(lordId);
			}
		}
	}

	// Token: 0x0600E089 RID: 57481 RVA: 0x0041E9BD File Offset: 0x0041CBBD
	private bool CanChangeLoreToggleState(int lordId)
	{
		return this.SelectLordId != lordId;
	}

	// Token: 0x040080C1 RID: 32961
	private int LordEntranceId;

	// Token: 0x040080C2 RID: 32962
	[Nullable(2)]
	private List<int> LordList;

	// Token: 0x040080C3 RID: 32963
	private int SelectLordId;

	// Token: 0x040080C4 RID: 32964
	private int HelpId;

	// Token: 0x040080C5 RID: 32965
	private bool RewardReceived;

	// Token: 0x040080C6 RID: 32966
	private int DefaultLord;

	// Token: 0x040080C7 RID: 32967
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymItem, int> LordScroll;

	// Token: 0x040080C8 RID: 32968
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x0200785B RID: 30811
	[NullableContext(0)]
	private class EChildCom
	{
		// Token: 0x040270F8 RID: 159992
		public const int TextEntranceName = 0;

		// Token: 0x040270F9 RID: 159993
		public const int BtnBack = 1;

		// Token: 0x040270FA RID: 159994
		public const int ScrollLord = 2;

		// Token: 0x040270FB RID: 159995
		public const int ScrollLordItem = 3;

		// Token: 0x040270FC RID: 159996
		public const int PnlShopEntrance = 4;

		// Token: 0x040270FD RID: 159997
		public const int TextLordName = 5;

		// Token: 0x040270FE RID: 159998
		public const int TextLordLevel = 6;

		// Token: 0x040270FF RID: 159999
		public const int TexBossBg = 7;

		// Token: 0x04027100 RID: 160000
		public const int TexBossElement = 8;

		// Token: 0x04027101 RID: 160001
		public const int TexBoss = 9;

		// Token: 0x04027102 RID: 160002
		public const int BtnLord = 10;

		// Token: 0x04027103 RID: 160003
		public const int PnlContent = 11;

		// Token: 0x04027104 RID: 160004
		public const int PnlBuff = 12;

		// Token: 0x04027105 RID: 160005
		public const int TextHelpTitle = 13;

		// Token: 0x04027106 RID: 160006
		public const int TextRewardTitle = 14;

		// Token: 0x04027107 RID: 160007
		public const int TextDesc = 15;

		// Token: 0x04027108 RID: 160008
		public const int ScrollReward = 16;

		// Token: 0x04027109 RID: 160009
		public const int ItemReward = 17;

		// Token: 0x0402710A RID: 160010
		public const int BtnChallengeRecord = 18;

		// Token: 0x0402710B RID: 160011
		public const int BtnBegin = 19;

		// Token: 0x0402710C RID: 160012
		public const int ItemLock = 20;

		// Token: 0x0402710D RID: 160013
		public const int TextLock = 21;

		// Token: 0x0402710E RID: 160014
		public const int TextBegin = 22;

		// Token: 0x0402710F RID: 160015
		public const int BtnShop = 23;

		// Token: 0x04027110 RID: 160016
		public const int TxtRecord = 24;

		// Token: 0x04027111 RID: 160017
		public const int PnlLevelTips = 25;
	}
}
