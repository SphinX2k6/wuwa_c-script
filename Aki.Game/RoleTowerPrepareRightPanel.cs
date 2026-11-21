using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CE4 RID: 7396
public class RoleTowerPrepareRightPanel : UiPanelBase
{
	// Token: 0x060124F9 RID: 75001 RVA: 0x00566784 File Offset: 0x00564984
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickMonsterBuffLook))
		};
	}

	// Token: 0x060124FA RID: 75002 RVA: 0x005669B0 File Offset: 0x00564BB0
	protected override void OnStart()
	{
		this.FeatureList = new GenericScrollViewNew<RoleTowerFeatureItem, RoleTowerFeatureData>(base.GetScrollViewWithScrollbar(3), () => new RoleTowerFeatureItem(), null, false, null);
		this.RewardList = new GenericScrollViewNew<RoleTowerRewardPreviewItem, RoleTowerRewardPreviewData>(base.GetScrollViewWithScrollbar(10), () => new RoleTowerRewardPreviewItem(), null, false, null);
		this.TeamAvatarLayout = new GenericLayout<RoleTowerTeamAvatarItem, RoleTowerTeamAvatarData>(base.GetHorizontalLayout(13), () => new RoleTowerTeamAvatarItem(), null, false, true);
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(6);
		bool flag;
		if (horizontalLayout == null)
		{
			flag = (null != null);
		}
		else
		{
			UUIItem uuiitem = horizontalLayout.RootUIComp.Get();
			flag = (((uuiitem != null) ? uuiitem.GetAttachUIChild(0) : null) != null);
		}
		if (flag)
		{
			this.StarNowLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(horizontalLayout, () => new RoleTowerPauseStarItem(), null, false, true);
		}
		UUIHorizontalLayout horizontalLayout2 = base.GetHorizontalLayout(8);
		bool flag2;
		if (horizontalLayout2 == null)
		{
			flag2 = (null != null);
		}
		else
		{
			UUIItem uuiitem2 = horizontalLayout2.RootUIComp.Get();
			flag2 = (((uuiitem2 != null) ? uuiitem2.GetAttachUIChild(0) : null) != null);
		}
		if (flag2)
		{
			this.StarNextLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(horizontalLayout2, () => new RoleTowerPauseStarItem(), null, false, true);
		}
	}

	// Token: 0x060124FB RID: 75003 RVA: 0x00566B10 File Offset: 0x00564D10
	public void Refresh(int stageId)
	{
		RoleTowerStage? stageCfg = RoleTowerModel.Instance.GetStageCfg(stageId);
		if (stageCfg == null)
		{
			return;
		}
		this.RefreshTitle(stageCfg.Value);
		this.RefreshFeatureList(stageCfg.Value);
		bool hasReward = this.RefreshReward(stageCfg.Value);
		this.RefreshFinishedTeam(stageId, hasReward);
	}

	// Token: 0x060124FC RID: 75004 RVA: 0x00566B63 File Offset: 0x00564D63
	private void RefreshTitle(RoleTowerStage cfg)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(cfg.RoleTowerStageName);
		}
		this.RefreshFloorRange(cfg);
	}

	// Token: 0x060124FD RID: 75005 RVA: 0x00566B88 File Offset: 0x00564D88
	private void RefreshFloorRange(RoleTowerStage cfg)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		IReadOnlyList<RoleTowerFloor> floorCfgListByStage = RoleTowerModel.Instance.GetFloorCfgListByStage(RoleTowerModel.Instance.CurSelectLevel, cfg.Stage);
		if (floorCfgListByStage.Count == 0)
		{
			text.SetUIActive(false);
			return;
		}
		int num = int.MaxValue;
		int num2 = int.MinValue;
		foreach (RoleTowerFloor roleTowerFloor in floorCfgListByStage)
		{
			num = Math.Min(num, roleTowerFloor.FloorIndex);
			num2 = Math.Max(num2, roleTowerFloor.FloorIndex);
		}
		text.SetUIActive(true);
		if (num == num2)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerStageShortTitle_OneFloor", new <>z__ReadOnlySingleElementList<object>(num));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerStageShortTitle", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			num2
		}));
	}

	// Token: 0x060124FE RID: 75006 RVA: 0x00566C84 File Offset: 0x00564E84
	private void RefreshFeatureList(RoleTowerStage cfg)
	{
		List<RoleTowerFeatureData> list = new List<RoleTowerFeatureData>();
		if (!string.IsNullOrEmpty(cfg.RoleTowerStageDesc))
		{
			list.Add(new RoleTowerFeatureData
			{
				Desc = cfg.RoleTowerStageDesc,
				DescParams = cfg.RoleTowerStageDescParam()
			});
		}
		GenericScrollViewNew<RoleTowerFeatureItem, RoleTowerFeatureData> featureList = this.FeatureList;
		if (featureList == null)
		{
			return;
		}
		featureList.RefreshByData(list, null, false);
	}

	// Token: 0x060124FF RID: 75007 RVA: 0x00566CE0 File Offset: 0x00564EE0
	private bool RefreshReward(RoleTowerStage stageCfg)
	{
		bool flag = this.RefreshStarUpPreview(stageCfg);
		bool flag2 = this.RefreshRewardPreview(stageCfg);
		return flag || flag2;
	}

	// Token: 0x06012500 RID: 75008 RVA: 0x00566D00 File Offset: 0x00564F00
	private bool RefreshStarUpPreview(RoleTowerStage cfg)
	{
		bool flag = cfg.StarUpPreviewLength >= 2;
		int nextStarDes = cfg.NextStarDes;
		bool flag2 = !flag && nextStarDes > 0;
		UUIItem item = base.GetItem(15);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		UUIItem item4 = base.GetItem(16);
		if (item4 != null)
		{
			item4.SetUIActive(flag2);
		}
		UUIItem item5 = base.GetItem(18);
		if (item5 != null)
		{
			item5.SetUIActive(flag || flag2);
		}
		if (flag)
		{
			int num = cfg.StarUpPreview(0);
			int num2 = cfg.StarUpPreview(1);
			int limit = Math.Max(RoleTowerPrepareRightPanel.GetStarLimit(), Math.Max(num, num2));
			GenericLayout<RoleTowerPauseStarItem, bool> starNowLayout = this.StarNowLayout;
			if (starNowLayout != null)
			{
				starNowLayout.RefreshByData(RoleTowerPrepareRightPanel.BuildStars(limit, num), null, false);
			}
			GenericLayout<RoleTowerPauseStarItem, bool> starNextLayout = this.StarNextLayout;
			if (starNextLayout != null)
			{
				starNextLayout.RefreshByData(RoleTowerPrepareRightPanel.BuildStars(limit, num2), null, false);
			}
		}
		else if (flag2)
		{
			RoleTowerStage? stageCfgInLevel = RoleTowerModel.Instance.GetStageCfgInLevel(RoleTowerModel.Instance.CurSelectLevel, nextStarDes);
			string text = (stageCfgInLevel != null) ? stageCfgInLevel.GetValueOrDefault().RoleTowerStageName : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "RoleToweNextStarDes", new <>z__ReadOnlySingleElementList<object>(string.IsNullOrEmpty(text) ? nextStarDes.ToString() : new TableTextArgNew(text, Array.Empty<object>())));
		}
		return flag || flag2;
	}

	// Token: 0x06012501 RID: 75009 RVA: 0x00566E70 File Offset: 0x00565070
	private static int GetStarLimit()
	{
		int num = 0;
		foreach (RoleTowerStar roleTowerStar in RoleTowerModel.Instance.GetStarCfgListByRole(0))
		{
			num = Math.Max(num, roleTowerStar.StarIndex);
		}
		return num;
	}

	// Token: 0x06012502 RID: 75010 RVA: 0x00566ECC File Offset: 0x005650CC
	[NullableContext(1)]
	private static List<bool> BuildStars(int limit, int activeCount)
	{
		List<bool> list = new List<bool>();
		for (int i = 0; i < limit; i++)
		{
			list.Add(i < activeCount);
		}
		return list;
	}

	// Token: 0x06012503 RID: 75011 RVA: 0x00566EF8 File Offset: 0x005650F8
	private bool RefreshRewardPreview(RoleTowerStage stageCfg)
	{
		List<RoleTowerRewardPreviewData> list = new List<RoleTowerRewardPreviewData>();
		for (int i = 0; i < stageCfg.TokenPreviewLength; i++)
		{
			DicIntInt? dicIntInt = stageCfg.TokenPreview(i);
			if (dicIntInt != null)
			{
				RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(dicIntInt.Value.Key);
				int itemId = (tokenCfg != null) ? tokenCfg.Value.ItemId : 0;
				list.Add(new RoleTowerRewardPreviewData
				{
					ItemId = itemId,
					Count = dicIntInt.Value.Value
				});
			}
		}
		bool flag = list.Count > 0;
		int nextTokenDes = stageCfg.NextTokenDes;
		bool flag2 = !flag && nextTokenDes > 0;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(10);
		if (scrollViewWithScrollbar != null)
		{
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(flag2);
		}
		UUIItem item2 = base.GetItem(19);
		if (item2 != null)
		{
			item2.SetUIActive(flag || flag2);
		}
		if (flag)
		{
			GenericScrollViewNew<RoleTowerRewardPreviewItem, RoleTowerRewardPreviewData> rewardList = this.RewardList;
			if (rewardList != null)
			{
				rewardList.RefreshByData(list, null, false);
			}
		}
		else if (flag2)
		{
			RoleTowerStage? stageCfgInLevel = RoleTowerModel.Instance.GetStageCfgInLevel(RoleTowerModel.Instance.CurSelectLevel, nextTokenDes);
			string text = (stageCfgInLevel != null) ? stageCfgInLevel.GetValueOrDefault().RoleTowerStageName : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "RoleToweNextTokenDes", new <>z__ReadOnlySingleElementList<object>(string.IsNullOrEmpty(text) ? nextTokenDes.ToString() : new TableTextArgNew(text, Array.Empty<object>())));
		}
		return flag || flag2;
	}

	// Token: 0x06012504 RID: 75012 RVA: 0x00567098 File Offset: 0x00565298
	private void RefreshFinishedTeam(int stageId, bool hasReward)
	{
		RoleTowerStageData stageState = RoleTowerModel.Instance.GetStageState(stageId);
		List<int> list = (stageState != null) ? stageState.PassTeamRoleIds : null;
		bool flag = stageState != null && stageState.IsPassed && list != null && list.Count > 0;
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(!flag && hasReward);
		}
		if (!flag)
		{
			return;
		}
		List<RoleTowerTeamAvatarData> list2 = new List<RoleTowerTeamAvatarData>();
		foreach (int roleId in list)
		{
			list2.Add(new RoleTowerTeamAvatarData
			{
				RoleId = roleId
			});
		}
		GenericLayout<RoleTowerTeamAvatarItem, RoleTowerTeamAvatarData> teamAvatarLayout = this.TeamAvatarLayout;
		if (teamAvatarLayout == null)
		{
			return;
		}
		teamAvatarLayout.RefreshByData(list2, null, false);
	}

	// Token: 0x06012505 RID: 75013 RVA: 0x00567174 File Offset: 0x00565374
	private void OnClickMonsterBuffLook()
	{
		RoleTowerModel.Instance.OpenMonsterDetailView(RoleTowerModel.Instance.CurSelectStage);
	}

	// Token: 0x04009FB5 RID: 40885
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerFeatureItem, RoleTowerFeatureData> FeatureList;

	// Token: 0x04009FB6 RID: 40886
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerRewardPreviewItem, RoleTowerRewardPreviewData> RewardList;

	// Token: 0x04009FB7 RID: 40887
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerTeamAvatarItem, RoleTowerTeamAvatarData> TeamAvatarLayout;

	// Token: 0x04009FB8 RID: 40888
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarNowLayout;

	// Token: 0x04009FB9 RID: 40889
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarNextLayout;

	// Token: 0x02007FEB RID: 32747
	private static class EChildType
	{
		// Token: 0x0402961F RID: 169503
		public const int TxtLevelName = 0;

		// Token: 0x04029620 RID: 169504
		public const int TxtLevelValue = 1;

		// Token: 0x04029621 RID: 169505
		public const int BtnMonsterBuffLook = 2;

		// Token: 0x04029622 RID: 169506
		public const int LevelBuffItemScroll = 3;

		// Token: 0x04029623 RID: 169507
		public const int PnlDescItem = 4;

		// Token: 0x04029624 RID: 169508
		public const int PnlReward = 5;

		// Token: 0x04029625 RID: 169509
		public const int PnlStarNow = 6;

		// Token: 0x04029626 RID: 169510
		public const int UiItem_StarNow = 7;

		// Token: 0x04029627 RID: 169511
		public const int PnlStarNext = 8;

		// Token: 0x04029628 RID: 169512
		public const int UiItem_StarNext = 9;

		// Token: 0x04029629 RID: 169513
		public const int ItemScroll = 10;

		// Token: 0x0402962A RID: 169514
		public const int UiItem_ItemBaseB = 11;

		// Token: 0x0402962B RID: 169515
		public const int PnlFinishedTeam = 12;

		// Token: 0x0402962C RID: 169516
		public const int PnlRole = 13;

		// Token: 0x0402962D RID: 169517
		public const int UiItem_RoleAvatar2 = 14;

		// Token: 0x0402962E RID: 169518
		public const int PnlStarThis = 15;

		// Token: 0x0402962F RID: 169519
		public const int PnlStarNextDes = 16;

		// Token: 0x04029630 RID: 169520
		public const int PnlTokenNextDes = 17;

		// Token: 0x04029631 RID: 169521
		public const int PnlStarRoot = 18;

		// Token: 0x04029632 RID: 169522
		public const int PnlTokenRoot = 19;

		// Token: 0x04029633 RID: 169523
		public const int TxtStarNextDes = 20;

		// Token: 0x04029634 RID: 169524
		public const int TxtTokenNextDes = 21;
	}
}
