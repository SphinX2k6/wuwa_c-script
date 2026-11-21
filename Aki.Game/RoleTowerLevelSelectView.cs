using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD4 RID: 7380
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerLevelSelectView : UiViewBase
{
	// Token: 0x0601245A RID: 74842 RVA: 0x005631E7 File Offset: 0x005613E7
	[NullableContext(1)]
	public RoleTowerLevelSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B6E RID: 7022
	// (get) Token: 0x0601245B RID: 74843 RVA: 0x005631F0 File Offset: 0x005613F0
	private new RoleTowerLevelSelectViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerLevelSelectViewParams;
		}
	}

	// Token: 0x0601245C RID: 74844 RVA: 0x00563200 File Offset: 0x00561400
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x0601245D RID: 74845 RVA: 0x005632E0 File Offset: 0x005614E0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerLevelSelectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerLevelSelectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601245E RID: 74846 RVA: 0x00563324 File Offset: 0x00561524
	protected override void OnStart()
	{
		this.RoleList = new LoopScrollView<RoleTowerRoleCardItem, RoleTowerRoleCardData>(base.GetLoopScrollViewComponent(2), (AUIBaseActor)base.GetItem(3).GetOwner(), () => new RoleTowerRoleCardItem(), false);
	}

	// Token: 0x0601245F RID: 74847 RVA: 0x00563374 File Offset: 0x00561574
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerLevelSelectUpdate, new Action<int>(this.OnLevelSelectChanged));
		EventSystem.Instance.Add(EEventName.RoleTowerInfoUpdate, new Action(this.OnInfoUpdate));
	}

	// Token: 0x06012460 RID: 74848 RVA: 0x005633AE File Offset: 0x005615AE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerLevelSelectUpdate, new Action<int>(this.OnLevelSelectChanged));
		EventSystem.Instance.Remove(EEventName.RoleTowerInfoUpdate, new Action(this.OnInfoUpdate));
	}

	// Token: 0x06012461 RID: 74849 RVA: 0x005633E8 File Offset: 0x005615E8
	protected override void OnBeforeShow()
	{
		this.InitSelectLevel();
		this.SelectInited = false;
		this.RefreshRoleList();
		this.RefreshRightPanel();
	}

	// Token: 0x06012462 RID: 74850 RVA: 0x00563403 File Offset: 0x00561603
	[NullableContext(1)]
	private static List<RoleTowerLevel> GetSortedLevelList(int groupId)
	{
		List<RoleTowerLevel> list = new List<RoleTowerLevel>(RoleTowerModel.Instance.GetLevelCfgListByGroup(groupId));
		list.Sort(delegate(RoleTowerLevel a, RoleTowerLevel b)
		{
			RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(a.Id);
			bool flag = levelState != null && levelState.IsUnlock;
			RoleTowerLevelData levelState2 = RoleTowerModel.Instance.GetLevelState(b.Id);
			int num = (levelState2 != null && levelState2.IsUnlock) ? 1 : 0;
			int num2 = (!flag) ? 1 : 0;
			int num3 = (num == 0) ? 1 : 0;
			if (num2 != num3)
			{
				return num2 - num3;
			}
			if (a.SortId != b.SortId)
			{
				return b.SortId - a.SortId;
			}
			return b.Id - a.Id;
		});
		return list;
	}

	// Token: 0x06012463 RID: 74851 RVA: 0x0056343C File Offset: 0x0056163C
	private void InitSelectLevel()
	{
		RoleTowerLevelSelectViewParams openParam = this.OpenParam;
		List<RoleTowerLevel> sortedLevelList = RoleTowerLevelSelectView.GetSortedLevelList((openParam != null) ? openParam.GroupId : 0);
		if (sortedLevelList.Count > 0)
		{
			RoleTowerModel.Instance.CurSelectLevel = sortedLevelList[0].Id;
		}
	}

	// Token: 0x06012464 RID: 74852 RVA: 0x00563484 File Offset: 0x00561684
	private void RefreshRoleList()
	{
		RoleTowerLevelSelectViewParams openParam = this.OpenParam;
		List<RoleTowerLevel> sortedLevelList = RoleTowerLevelSelectView.GetSortedLevelList((openParam != null) ? openParam.GroupId : 0);
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		List<RoleTowerRoleCardData> dataList = new List<RoleTowerRoleCardData>();
		int selectIndex = 0;
		for (int i = 0; i < sortedLevelList.Count; i++)
		{
			dataList.Add(new RoleTowerRoleCardData
			{
				LevelId = sortedLevelList[i].Id
			});
			if (sortedLevelList[i].Id == curSelectLevel)
			{
				selectIndex = i;
			}
		}
		LoopScrollView<RoleTowerRoleCardItem, RoleTowerRoleCardData> roleList = this.RoleList;
		if (roleList == null)
		{
			return;
		}
		roleList.RefreshByData(dataList, false, delegate
		{
			if (dataList.Count > 0)
			{
				LoopScrollView<RoleTowerRoleCardItem, RoleTowerRoleCardData> roleList2 = this.RoleList;
				if (roleList2 == null)
				{
					return;
				}
				roleList2.SelectGridProxy(selectIndex, false);
			}
		}, false);
	}

	// Token: 0x06012465 RID: 74853 RVA: 0x00563548 File Offset: 0x00561748
	private void OnLevelSelectChanged(int levelId)
	{
		this.RefreshRightPanel();
		if (this.SelectInited && levelId != this.LastSelectLevel)
		{
			base.PlaySequence("Switch", null, false);
		}
		this.SelectInited = true;
		this.LastSelectLevel = levelId;
	}

	// Token: 0x06012466 RID: 74854 RVA: 0x0056357C File Offset: 0x0056177C
	private void OnInfoUpdate()
	{
		this.RefreshRoleList();
		this.RefreshRightPanel();
	}

	// Token: 0x06012467 RID: 74855 RVA: 0x0056358C File Offset: 0x0056178C
	private void RefreshRightPanel()
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		RoleTowerLevel? levelCfg = RoleTowerModel.Instance.GetLevelCfg(curSelectLevel);
		if (levelCfg == null)
		{
			return;
		}
		RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(curSelectLevel);
		bool flag = levelState != null && levelState.IsUnlock;
		bool uiactive = levelState != null && levelState.IsAllPass;
		this.RefreshRolePixAndName(levelCfg.Value);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		RoleTowerLevelUnlockPanel unlockPanel = this.UnlockPanel;
		if (unlockPanel != null)
		{
			unlockPanel.Refresh(curSelectLevel, flag);
		}
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(!flag);
		}
		if (!flag)
		{
			this.RefreshLockState(levelState);
		}
	}

	// Token: 0x06012468 RID: 74856 RVA: 0x00563648 File Offset: 0x00561848
	private void RefreshRolePixAndName(RoleTowerLevel levelCfg)
	{
		int mainRoleId = levelCfg.MainRoleId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(mainRoleId);
		if (roleConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.LevelSelect 角色配置缺失";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", mainRoleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleConfig.Value.Name, Array.Empty<object>());
		this.RefreshRolePix(mainRoleId, roleConfig.Value.SkinId);
	}

	// Token: 0x06012469 RID: 74857 RVA: 0x005636D8 File Offset: 0x005618D8
	private void RefreshRolePix(int roleId, int originSkinId)
	{
		RoleTowerLevelSelectView.<>c__DisplayClass24_0 CS$<>8__locals1 = new RoleTowerLevelSelectView.<>c__DisplayClass24_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.spine = base.GetSpine(1);
		RoleTowerLevelSelectView.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
		USpineSkeletonAnimationComponent spine = CS$<>8__locals1.spine;
		object obj;
		if (spine == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = spine.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
		}
		CS$<>8__locals2.roleItem = (obj as UUIItem);
		if (CS$<>8__locals1.spine == null || CS$<>8__locals1.roleItem == null)
		{
			return;
		}
		if (roleId == this.RolePixRoleId)
		{
			return;
		}
		this.RolePixRoleId = roleId;
		RoleTowerLevelSelectView.<>c__DisplayClass24_0 CS$<>8__locals3 = CS$<>8__locals1;
		int num = this.RolePixRefreshToken + 1;
		this.RolePixRefreshToken = num;
		CS$<>8__locals3.refreshToken = num;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(originSkinId);
		if (roleSkinConfig == null || string.IsNullOrEmpty(roleSkinConfig.Value.FormationSpineAtlas) || string.IsNullOrEmpty(roleSkinConfig.Value.FormationSpineSkeletonData))
		{
			CS$<>8__locals1.roleItem.SetUIActive(false);
			return;
		}
		CS$<>8__locals1.param = roleSkinConfig.Value.GetSpineParamArray();
		CS$<>8__locals1.roleItem.SetUIActive(false);
		base.SetSpineAssetByPath(roleSkinConfig.Value.FormationSpineAtlas, roleSkinConfig.Value.FormationSpineSkeletonData, CS$<>8__locals1.spine).ContinueWith(delegate()
		{
			if (CS$<>8__locals1.refreshToken != CS$<>8__locals1.<>4__this.RolePixRefreshToken)
			{
				return;
			}
			if (CS$<>8__locals1.param.Length >= 3)
			{
				CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
				CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
				CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
			}
			CS$<>8__locals1.roleItem.SetUIActive(true);
			CS$<>8__locals1.spine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
		});
	}

	// Token: 0x0601246A RID: 74858 RVA: 0x00563818 File Offset: 0x00561A18
	private void RefreshLockState(RoleTowerLevelData state)
	{
		UUIText text = base.GetText(8);
		if (text == null)
		{
			return;
		}
		long num = (state != null) ? state.UnlockTime : 0L;
		if (num <= 0L)
		{
			text.SetUIActive(false);
			return;
		}
		long num2 = num - (long)TimeUtil.Instance.GetServerTime();
		long num3 = (num2 <= 0L) ? 0L : ((num2 + 3600L - 1L) / 3600L);
		text.SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerLevelLockDes", new <>z__ReadOnlyArray<object>(new object[]
		{
			num3 / 24L,
			num3 % 24L
		}));
	}

	// Token: 0x04009F87 RID: 40839
	private PopupCaptionItem Caption;

	// Token: 0x04009F88 RID: 40840
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RoleTowerRoleCardItem, RoleTowerRoleCardData> RoleList;

	// Token: 0x04009F89 RID: 40841
	private RoleTowerLevelUnlockPanel UnlockPanel;

	// Token: 0x04009F8A RID: 40842
	private bool SelectInited;

	// Token: 0x04009F8B RID: 40843
	private int LastSelectLevel;

	// Token: 0x04009F8C RID: 40844
	private int RolePixRefreshToken;

	// Token: 0x04009F8D RID: 40845
	private int RolePixRoleId;

	// Token: 0x04009F8E RID: 40846
	private const long HourSec = 3600L;

	// Token: 0x02007FC9 RID: 32713
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029569 RID: 169321
		public const int UiItemCaption = 0;

		// Token: 0x0402956A RID: 169322
		public const int SpineRolePix = 1;

		// Token: 0x0402956B RID: 169323
		public const int ItemScroll = 2;

		// Token: 0x0402956C RID: 169324
		public const int UiItemRoleCard = 3;

		// Token: 0x0402956D RID: 169325
		public const int TxtRoleName = 4;

		// Token: 0x0402956E RID: 169326
		public const int PnlPassing = 5;

		// Token: 0x0402956F RID: 169327
		public const int PnlUnlockContent = 6;

		// Token: 0x04029570 RID: 169328
		public const int PnlLockState = 7;

		// Token: 0x04029571 RID: 169329
		public const int TxtLockState = 8;
	}
}
