using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF5 RID: 7413
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerRankView : UiTickViewBase
{
	// Token: 0x0601259F RID: 75167 RVA: 0x0056ABB6 File Offset: 0x00568DB6
	public RoleTowerRankView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B72 RID: 7026
	// (get) Token: 0x060125A0 RID: 75168 RVA: 0x0056ABDD File Offset: 0x00568DDD
	[Nullable(2)]
	private new RoleTowerRankViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as RoleTowerRankViewParams;
		}
	}

	// Token: 0x060125A1 RID: 75169 RVA: 0x0056ABEC File Offset: 0x00568DEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060125A2 RID: 75170 RVA: 0x0056ACD8 File Offset: 0x00568ED8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerRankView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerRankView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125A3 RID: 75171 RVA: 0x0056AD1B File Offset: 0x00568F1B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerRankUpdate, new Action(this.OnRankUpdate));
	}

	// Token: 0x060125A4 RID: 75172 RVA: 0x0056AD39 File Offset: 0x00568F39
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerRankUpdate, new Action(this.OnRankUpdate));
	}

	// Token: 0x060125A5 RID: 75173 RVA: 0x0056AD58 File Offset: 0x00568F58
	protected override void OnBeforeShow()
	{
		RoleTowerRankView.<>c__DisplayClass19_0 CS$<>8__locals1 = new RoleTowerRankView.<>c__DisplayClass19_0();
		this.NewRecordTagLevelSet.Clear();
		this.BuildAvatarTabs();
		RoleTowerRankView.<>c__DisplayClass19_0 CS$<>8__locals2 = CS$<>8__locals1;
		RoleTowerRankViewParams openParam = this.OpenParam;
		CS$<>8__locals2.wantLevelId = ((openParam != null) ? openParam.LevelId : 0);
		if (this.AvatarList.Count > 0 && !this.AvatarList.Exists((RoleTowerRankAvatarData d) => d.LevelId == CS$<>8__locals1.wantLevelId))
		{
			CS$<>8__locals1.wantLevelId = this.AvatarList[0].LevelId;
		}
		foreach (RoleTowerRankAvatarData roleTowerRankAvatarData in this.AvatarList)
		{
			roleTowerRankAvatarData.IsSelected = (roleTowerRankAvatarData.LevelId == CS$<>8__locals1.wantLevelId);
		}
		GenericLayout<RoleTowerRankAvatarItem, RoleTowerRankAvatarData> avatarLayout = this.AvatarLayout;
		if (avatarLayout != null)
		{
			avatarLayout.RefreshByData(this.AvatarList, null, false);
		}
		this.SelectLevel(CS$<>8__locals1.wantLevelId);
		RoleTowerController.Instance.RankRequest(RoleTowerModel.Instance.ActivityId).Forget();
	}

	// Token: 0x060125A6 RID: 75174 RVA: 0x0056AE64 File Offset: 0x00569064
	private void BuildAvatarTabs()
	{
		this.AvatarList.Clear();
		List<RoleTowerLevel> list = new List<RoleTowerLevel>(RoleTowerModel.Instance.GetRankLevelCfgList());
		list.Sort(delegate(RoleTowerLevel a, RoleTowerLevel b)
		{
			if (a.SortId == b.SortId)
			{
				return b.Id.CompareTo(a.Id);
			}
			return b.SortId.CompareTo(a.SortId);
		});
		foreach (RoleTowerLevel roleTowerLevel in list)
		{
			this.AvatarList.Add(new RoleTowerRankAvatarData
			{
				LevelId = roleTowerLevel.Id,
				MainRoleId = roleTowerLevel.MainRoleId
			});
		}
	}

	// Token: 0x060125A7 RID: 75175 RVA: 0x0056AF14 File Offset: 0x00569114
	private RoleTowerRankAvatarItem CreateAvatarItem()
	{
		RoleTowerRankAvatarItem roleTowerRankAvatarItem = new RoleTowerRankAvatarItem();
		roleTowerRankAvatarItem.SetClickCallback(new Action<int>(this.SelectLevel));
		return roleTowerRankAvatarItem;
	}

	// Token: 0x060125A8 RID: 75176 RVA: 0x0056AF30 File Offset: 0x00569130
	private void SelectLevel(int levelId)
	{
		if (levelId <= 0)
		{
			return;
		}
		this.CurLevelId = levelId;
		this.ReadNewRecord(levelId);
		GenericLayout<RoleTowerRankAvatarItem, RoleTowerRankAvatarData> avatarLayout = this.AvatarLayout;
		List<RoleTowerRankAvatarItem> list = (avatarLayout != null) ? avatarLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				RoleTowerRankAvatarData roleTowerRankAvatarData = (i < this.AvatarList.Count) ? this.AvatarList[i] : null;
				list[i].RefreshSelected(roleTowerRankAvatarData != null && roleTowerRankAvatarData.LevelId == levelId);
			}
		}
		this.RefreshTopTitle(levelId);
		RoleTowerRankBottomPanel bottomPanel = this.BottomPanel;
		if (bottomPanel != null)
		{
			bottomPanel.Refresh(levelId);
		}
		if (this.RankInited)
		{
			this.OnRankUpdate();
		}
	}

	// Token: 0x060125A9 RID: 75177 RVA: 0x0056AFD8 File Offset: 0x005691D8
	private void ReadNewRecord(int levelId)
	{
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		if (data == null || !data.HasNewRecordRedDot(levelId))
		{
			return;
		}
		this.NewRecordTagLevelSet.Add(levelId);
		data.MarkNewRecordRead(levelId);
	}

	// Token: 0x060125AA RID: 75178 RVA: 0x0056B018 File Offset: 0x00569218
	private void RefreshTopTitle(int levelId)
	{
		UUIText text = base.GetText(1);
		RoleTowerLevel? levelCfg = RoleTowerModel.Instance.GetLevelCfg(levelId);
		if (text == null || levelCfg == null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(levelCfg.Value.MainRoleId);
		if (roleConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, roleConfig.Value.Name, Array.Empty<object>());
	}

	// Token: 0x060125AB RID: 75179 RVA: 0x0056B08A File Offset: 0x0056928A
	private RoleTowerRankItem CreateRankItem()
	{
		return new RoleTowerRankItem
		{
			RowMode = ERoleTowerRankRowMode.Friend,
			NewRecordTagFilter = (() => this.NewRecordTagLevelSet.Contains(this.CurLevelId))
		};
	}

	// Token: 0x060125AC RID: 75180 RVA: 0x0056B0AC File Offset: 0x005692AC
	private void OnRankUpdate()
	{
		this.ReadNewRecord(this.CurLevelId);
		this.RefreshFriendRank();
		RoleTowerRankBottomPanel bottomPanel = this.BottomPanel;
		if (bottomPanel != null)
		{
			bottomPanel.Refresh(this.CurLevelId);
		}
		this.RefreshCountDown();
		for (int i = 0; i < this.AvatarList.Count; i++)
		{
			this.AvatarList[i].IsSelected = (this.AvatarList[i].LevelId == this.CurLevelId);
		}
		GenericLayout<RoleTowerRankAvatarItem, RoleTowerRankAvatarData> avatarLayout = this.AvatarLayout;
		if (avatarLayout != null)
		{
			avatarLayout.RefreshByData(this.AvatarList, null, false);
		}
		if (!this.RankInited)
		{
			this.RankInited = true;
			UUIInturnAnimController enterAnim = this.EnterAnim;
			if (enterAnim == null)
			{
				return;
			}
			enterAnim.Play("", -1, false);
			return;
		}
		else
		{
			UUIInturnAnimController switchAnim = this.SwitchAnim;
			if (switchAnim == null)
			{
				return;
			}
			switchAnim.Play("", -1, false);
			return;
		}
	}

	// Token: 0x060125AD RID: 75181 RVA: 0x0056B180 File Offset: 0x00569380
	private void RefreshFriendRank()
	{
		IReadOnlyList<RoleTowerRankData> friendRankList = RoleTowerModel.Instance.GetFriendRankList(this.CurLevelId);
		bool flag = friendRankList.Count > 0;
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		LoopScrollView<RoleTowerRankItem, RoleTowerRankData> friendScroll = this.FriendScroll;
		if (friendScroll == null)
		{
			return;
		}
		friendScroll.RefreshByData(friendRankList, false, null, false);
	}

	// Token: 0x060125AE RID: 75182 RVA: 0x0056B1D2 File Offset: 0x005693D2
	protected override void OnTick(float delta)
	{
		this.RefreshCountDown();
	}

	// Token: 0x060125AF RID: 75183 RVA: 0x0056B1DC File Offset: 0x005693DC
	private void RefreshCountDown()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		long rankNextRefreshTime = RoleTowerModel.Instance.GetRankNextRefreshTime(this.CurLevelId);
		if (rankNextRefreshTime <= 0L)
		{
			this.SetRefreshTimeText(text, 0L);
			return;
		}
		long num = rankNextRefreshTime - (long)TimeUtil.Instance.GetServerTimeStamp();
		if (num <= 0L)
		{
			this.SetRefreshTimeText(text, 0L);
			if (this.CurLevelId > 0 && this.RequestedRefreshTime != rankNextRefreshTime)
			{
				this.RequestedRefreshTime = rankNextRefreshTime;
				RoleTowerController.Instance.RankRequest(RoleTowerModel.Instance.ActivityId).Forget();
			}
			return;
		}
		this.SetRefreshTimeText(text, num);
	}

	// Token: 0x060125B0 RID: 75184 RVA: 0x0056B26C File Offset: 0x0056946C
	private void SetRefreshTimeText(UUIText txt, long remainMs)
	{
		long num = (remainMs > 0L) ? ((remainMs + 999L) / 1000L) : 0L;
		if (num == this.LastRefreshRemainSec)
		{
			return;
		}
		this.LastRefreshRemainSec = num;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted<long>(num / 3600L, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<long>(num / 60L % 60L, "D2");
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted<long>(num % 60L, "D2");
		string item = defaultInterpolatedStringHandler.ToStringAndClear();
		LguiUtil.Instance.SetLocalTextNew(txt, "RoleTowerRankRefreshTime", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x060125B1 RID: 75185 RVA: 0x0056B31C File Offset: 0x0056951C
	private void OnClickRewardPreview()
	{
		RoleTowerLevel? levelById = RoleTowerConfig.Instance.GetLevelById(this.CurLevelId);
		int num = (levelById != null) ? levelById.GetValueOrDefault().RoleTowerRankRewardItemId : 0;
		if (num <= 0)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(levelById.Value.RoleTowerRankRewardItemDes, null);
		if (!InfoDisplayController.Instance.OpenInfoDisplayByItem(num, localTextNew))
		{
			ItemController.Instance.OpenItemTipsByItemId(num, true, null, false);
		}
	}

	// Token: 0x060125B2 RID: 75186 RVA: 0x0056B38D File Offset: 0x0056958D
	private void OnClickRecordDetail(RoleTowerRankData data)
	{
		RoleTowerModel.Instance.OpenRecordView(this.CurLevelId, false);
	}

	// Token: 0x04009FFF RID: 40959
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400A000 RID: 40960
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerRankAvatarItem, RoleTowerRankAvatarData> AvatarLayout;

	// Token: 0x0400A001 RID: 40961
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RoleTowerRankItem, RoleTowerRankData> FriendScroll;

	// Token: 0x0400A002 RID: 40962
	[Nullable(2)]
	private RoleTowerRankBottomPanel BottomPanel;

	// Token: 0x0400A003 RID: 40963
	private readonly List<RoleTowerRankAvatarData> AvatarList = new List<RoleTowerRankAvatarData>();

	// Token: 0x0400A004 RID: 40964
	private int CurLevelId;

	// Token: 0x0400A005 RID: 40965
	private readonly HashSet<int> NewRecordTagLevelSet = new HashSet<int>();

	// Token: 0x0400A006 RID: 40966
	private long RequestedRefreshTime;

	// Token: 0x0400A007 RID: 40967
	[Nullable(2)]
	private UUIInturnAnimController EnterAnim;

	// Token: 0x0400A008 RID: 40968
	[Nullable(2)]
	private UUIInturnAnimController SwitchAnim;

	// Token: 0x0400A009 RID: 40969
	private bool RankInited;

	// Token: 0x0400A00A RID: 40970
	private long LastRefreshRemainSec = -1L;

	// Token: 0x0200800D RID: 32781
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040296E7 RID: 169703
		public const int UiItemCaption = 0;

		// Token: 0x040296E8 RID: 169704
		public const int TxtTopTitle = 1;

		// Token: 0x040296E9 RID: 169705
		public const int TxtUpdateTime = 2;

		// Token: 0x040296EA RID: 169706
		public const int PnlRoleLayout = 3;

		// Token: 0x040296EB RID: 169707
		public const int UiItemRoleAvatar = 4;

		// Token: 0x040296EC RID: 169708
		public const int ListLoopScroll = 5;

		// Token: 0x040296ED RID: 169709
		public const int UiItemRankItem = 6;

		// Token: 0x040296EE RID: 169710
		public const int PnlBottomInfo = 7;

		// Token: 0x040296EF RID: 169711
		public const int PnlEmpty = 8;
	}
}
