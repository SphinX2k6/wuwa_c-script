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

// Token: 0x020021A3 RID: 8611
[NullableContext(1)]
[Nullable(0)]
public class LordGymEntranceView : UiViewBase
{
	// Token: 0x06010BE8 RID: 68584 RVA: 0x00411745 File Offset: 0x0040F945
	public LordGymEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010BE9 RID: 68585 RVA: 0x00411750 File Offset: 0x0040F950
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

	// Token: 0x06010BEA RID: 68586 RVA: 0x00411A3C File Offset: 0x0040FC3C
	private UniTask InitScroll()
	{
		LordGymEntranceView.<InitScroll>d__11 <InitScroll>d__;
		<InitScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitScroll>d__.<>4__this = this;
		<InitScroll>d__.<>1__state = -1;
		<InitScroll>d__.<>t__builder.Start<LordGymEntranceView.<InitScroll>d__11>(ref <InitScroll>d__);
		return <InitScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06010BEB RID: 68587 RVA: 0x00411A80 File Offset: 0x0040FC80
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymEntranceView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymEntranceView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010BEC RID: 68588 RVA: 0x00411AC3 File Offset: 0x0040FCC3
	protected override void OnAfterShow()
	{
		if (!LordGymController.Instance.IsInEntranceEntity())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06010BED RID: 68589 RVA: 0x00411AD8 File Offset: 0x0040FCD8
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

	// Token: 0x06010BEE RID: 68590 RVA: 0x00411BAC File Offset: 0x0040FDAC
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

	// Token: 0x06010BEF RID: 68591 RVA: 0x00411C80 File Offset: 0x0040FE80
	protected override void OnBeforeDestroy()
	{
		this.LordScroll = null;
		this.RewardScroll = null;
	}

	// Token: 0x06010BF0 RID: 68592 RVA: 0x00411C90 File Offset: 0x0040FE90
	private LordGymItem CreateLordItem()
	{
		return new LordGymItem(new Action<int>(this.OnRefreshView), new Func<int, bool>(this.CanChangeLoreToggleState));
	}

	// Token: 0x06010BF1 RID: 68593 RVA: 0x00411CAF File Offset: 0x0040FEAF
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06010BF2 RID: 68594 RVA: 0x00411CB6 File Offset: 0x0040FEB6
	private void OnClickBtnClose()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x06010BF3 RID: 68595 RVA: 0x00411CCE File Offset: 0x0040FECE
	private void OnClickBtnLord()
	{
		if (this.HelpId > 0)
		{
			HelpController.Instance.OpenHelpById(this.HelpId);
		}
	}

	// Token: 0x06010BF4 RID: 68596 RVA: 0x00411CE9 File Offset: 0x0040FEE9
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

	// Token: 0x06010BF5 RID: 68597 RVA: 0x00411D1A File Offset: 0x0040FF1A
	private void OnClickRecord()
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeRecordView, this.LordEntranceId, null);
	}

	// Token: 0x06010BF6 RID: 68598 RVA: 0x00411D37 File Offset: 0x0040FF37
	private void OnClickShop()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 2);
	}

	// Token: 0x06010BF7 RID: 68599 RVA: 0x00411D48 File Offset: 0x0040FF48
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

	// Token: 0x06010BF8 RID: 68600 RVA: 0x004120D5 File Offset: 0x004102D5
	private bool CanChangeLoreToggleState(int lordId)
	{
		return this.SelectLordId != lordId;
	}

	// Token: 0x04007F7A RID: 32634
	private int LordEntranceId;

	// Token: 0x04007F7B RID: 32635
	[Nullable(2)]
	private List<int> LordList;

	// Token: 0x04007F7C RID: 32636
	private int SelectLordId;

	// Token: 0x04007F7D RID: 32637
	private int HelpId;

	// Token: 0x04007F7E RID: 32638
	private bool RewardReceived;

	// Token: 0x04007F7F RID: 32639
	private int DefaultLord;

	// Token: 0x04007F80 RID: 32640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymItem, int> LordScroll;

	// Token: 0x04007F81 RID: 32641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

	// Token: 0x020086D0 RID: 34512
	[NullableContext(0)]
	private class EChildCom
	{
		// Token: 0x0402BDD7 RID: 179671
		public const int TextEntranceName = 0;

		// Token: 0x0402BDD8 RID: 179672
		public const int BtnBack = 1;

		// Token: 0x0402BDD9 RID: 179673
		public const int ScrollLord = 2;

		// Token: 0x0402BDDA RID: 179674
		public const int ScrollLordItem = 3;

		// Token: 0x0402BDDB RID: 179675
		public const int PnlShopEntrance = 4;

		// Token: 0x0402BDDC RID: 179676
		public const int TextLordName = 5;

		// Token: 0x0402BDDD RID: 179677
		public const int TextLordLevel = 6;

		// Token: 0x0402BDDE RID: 179678
		public const int TexBossBg = 7;

		// Token: 0x0402BDDF RID: 179679
		public const int TexBossElement = 8;

		// Token: 0x0402BDE0 RID: 179680
		public const int TexBoss = 9;

		// Token: 0x0402BDE1 RID: 179681
		public const int BtnLord = 10;

		// Token: 0x0402BDE2 RID: 179682
		public const int PnlContent = 11;

		// Token: 0x0402BDE3 RID: 179683
		public const int PnlBuff = 12;

		// Token: 0x0402BDE4 RID: 179684
		public const int TextHelpTitle = 13;

		// Token: 0x0402BDE5 RID: 179685
		public const int TextRewardTitle = 14;

		// Token: 0x0402BDE6 RID: 179686
		public const int TextDesc = 15;

		// Token: 0x0402BDE7 RID: 179687
		public const int ScrollReward = 16;

		// Token: 0x0402BDE8 RID: 179688
		public const int ItemReward = 17;

		// Token: 0x0402BDE9 RID: 179689
		public const int BtnChallengeRecord = 18;

		// Token: 0x0402BDEA RID: 179690
		public const int BtnBegin = 19;

		// Token: 0x0402BDEB RID: 179691
		public const int ItemLock = 20;

		// Token: 0x0402BDEC RID: 179692
		public const int TextLock = 21;

		// Token: 0x0402BDED RID: 179693
		public const int TextBegin = 22;

		// Token: 0x0402BDEE RID: 179694
		public const int BtnShop = 23;

		// Token: 0x0402BDEF RID: 179695
		public const int TxtRecord = 24;

		// Token: 0x0402BDF0 RID: 179696
		public const int PnlLevelTips = 25;
	}
}
