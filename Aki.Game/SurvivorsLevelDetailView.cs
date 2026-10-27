using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B3F RID: 11071
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsLevelDetailView : UiViewBase
{
	// Token: 0x06016F6D RID: 94061 RVA: 0x005D3FEB File Offset: 0x005D21EB
	public SurvivorsLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016F6E RID: 94062 RVA: 0x005D4020 File Offset: 0x005D2220
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUITexture)),
			new ValueTuple<int, Type>(28, typeof(UUITexture)),
			new ValueTuple<int, Type>(29, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(30, typeof(UUIText)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(32, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(15, new Action<EToggleState>(this.OnClickTogEndless))
		};
	}

	// Token: 0x06016F6F RID: 94063 RVA: 0x005D434C File Offset: 0x005D254C
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsLevelDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsLevelDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016F70 RID: 94064 RVA: 0x005D4390 File Offset: 0x005D2590
	protected override void OnStart()
	{
		SurvivorsActivityDefine.SurvivorsLevelInfo selectLevelInfo = SurvivorsRogueModel.Instance.SelectLevelInfo;
		SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(selectLevelInfo.LevelId);
		this.CachedLevelId = selectLevelInfo.LevelId;
		this.InitializeCaption();
		this.UpdateLevelName(survivorsLevel.Value.Name);
		this.InitializeNormalBgAndTag(survivorsLevel.Value.Diff);
		this.RefreshLeftBottomArea(survivorsLevel.Value.GetInitRolesArray(), survivorsLevel.Value.GetInitWeaponsArray());
		ActivityFunctionalTypeA functionArea = this.FunctionArea;
		if (((functionArea != null) ? functionArea.FunctionButton : null) != null)
		{
			this.FunctionArea.FunctionButton.SetFunction(new Action(this.OnClickFunctionButton));
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinish), false);
		this.RefreshEndlessToggle();
	}

	// Token: 0x06016F71 RID: 94065 RVA: 0x005D4478 File Offset: 0x005D2678
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06016F72 RID: 94066 RVA: 0x005D4494 File Offset: 0x005D2694
	private void InitializeNormalBgAndTag(int diff)
	{
		int[][] array = new int[][]
		{
			new int[]
			{
				0,
				5
			},
			new int[]
			{
				1,
				7
			},
			new int[]
			{
				2,
				9
			}
		};
		for (int i = 0; i < array.Length; i++)
		{
			int[] array2 = array[i];
			UUIItem item = base.GetItem(array2[0]);
			UUIItem item2 = base.GetItem(array2[1]);
			if (i == diff)
			{
				this.CachedNormalBackground = item;
				this.CachedNormalTag = item2;
			}
			if (item != null)
			{
				item.SetUIActive(i == diff);
			}
			if (item2 != null)
			{
				item2.SetUIActive(i == diff);
			}
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.bgTexturePath[diff]);
		base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(28), null);
	}

	// Token: 0x06016F73 RID: 94067 RVA: 0x005D4555 File Offset: 0x005D2755
	private CommonItemSmallItemGrid CreateRewardGrid()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06016F74 RID: 94068 RVA: 0x005D455C File Offset: 0x005D275C
	private WeaponItemComponent CreateWeaponGrid()
	{
		return new WeaponItemComponent();
	}

	// Token: 0x06016F75 RID: 94069 RVA: 0x005D4563 File Offset: 0x005D2763
	private void OnClickFunctionButton()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTeamEditView, null, null);
	}

	// Token: 0x06016F76 RID: 94070 RVA: 0x005D4578 File Offset: 0x005D2778
	private void OnClickTogEndless(EToggleState state)
	{
		if (!this.CachedEndlessEnable)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(15);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, true);
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Survivors_EndlessDisableTips", Array.Empty<object>());
			return;
		}
		if (state != EToggleState.ETT_Checked)
		{
			this.SetEndlessMode(false);
			return;
		}
		if (this.CheckIsRecordedSwitchOn())
		{
			this.SetEndlessMode(true);
			return;
		}
		UUIExtendToggle toggle = base.GetExtendToggle(15);
		UUIExtendToggle toggle3 = toggle;
		if (toggle3 != null)
		{
			toggle3.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, true);
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SurvivorsLevelFirstEndlessConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			UUIExtendToggle toggle2 = toggle;
			if (toggle2 != null)
			{
				toggle2.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			this.SetEndlessMode(true);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06016F77 RID: 94071 RVA: 0x005D4634 File Offset: 0x005D2834
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016F78 RID: 94072 RVA: 0x005D4640 File Offset: 0x005D2840
	private void InitializeCaption()
	{
		PopupCaptionItem captionComp = this.CaptionComp;
		if (captionComp != null)
		{
			captionComp.SetCloseCallBack(new Action(this.OnClickClose));
		}
		PopupCaptionItem captionComp2 = this.CaptionComp;
		if (captionComp2 != null)
		{
			captionComp2.SetHelpCallBack(delegate
			{
				SurvivorsRogueController.Instance.OpenRogueHelp();
			});
		}
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		Activity? activity = (activityData != null) ? activityData.LocalConfig : null;
		if (activity != null)
		{
			PopupCaptionItem captionComp3 = this.CaptionComp;
			if (captionComp3 == null)
			{
				return;
			}
			captionComp3.SetTitleLocalText(activity.Value.Title);
		}
	}

	// Token: 0x06016F79 RID: 94073 RVA: 0x005D46E4 File Offset: 0x005D28E4
	private void SetEndlessMode(bool isEndless)
	{
		SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(this.CachedLevelId);
		if (survivorsLevel == null)
		{
			return;
		}
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData != null)
		{
			activityData.SaveCacheState(ESurvivorsActivitySaveFlags.EndlessMode, this.CachedLevelId, 0, (isEndless > false) ? 1 : 0);
		}
		SurvivorsActivityDefine.SurvivorsLevelInfo selectLevelInfo = SurvivorsRogueModel.Instance.SelectLevelInfo;
		selectLevelInfo.IsEndless = isEndless;
		int j = (isEndless > false) ? 1 : 0;
		this.UpdateLevelDesc(survivorsLevel.Value.InstDesc(j).Value.Value);
		this.UpdateLevelTarget(survivorsLevel.Value.TargetDesc(j).Value.Value, selectLevelInfo.LevelId, isEndless);
		this.UpdateToggleTextColor(isEndless);
		this.UpdateLevelTag(isEndless);
		this.PlayEndlessSwitchAnimation(isEndless);
		this.RefreshRewardByDropPackage(survivorsLevel.Value.RewardId(j), SurvivorsRogueModel.Instance.ActivityData.GetCurrentLevelInfoByLevelId(selectLevelInfo.LevelId).Info.IsFinish);
	}

	// Token: 0x06016F7A RID: 94074 RVA: 0x005D47E8 File Offset: 0x005D29E8
	private void PlayEndlessSwitchAnimation(bool isEndless)
	{
		if (isEndless)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}
		else
		{
			UUIItem cachedNormalBackground = this.CachedNormalBackground;
			if (cachedNormalBackground != null)
			{
				cachedNormalBackground.SetUIActive(true);
			}
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName(isEndless ? "Switch1" : "Switch2", false, null, false);
	}

	// Token: 0x06016F7B RID: 94075 RVA: 0x005D485C File Offset: 0x005D2A5C
	private void SequenceFinish(string name)
	{
		if (!(name == "Switch1"))
		{
			if (name == "Switch2")
			{
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
			return;
		}
		UUIItem cachedNormalBackground = this.CachedNormalBackground;
		if (cachedNormalBackground == null)
		{
			return;
		}
		cachedNormalBackground.SetUIActive(false);
	}

	// Token: 0x06016F7C RID: 94076 RVA: 0x005D489C File Offset: 0x005D2A9C
	private void UpdateLevelName(string titleId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), titleId, Array.Empty<object>());
	}

	// Token: 0x06016F7D RID: 94077 RVA: 0x005D48B5 File Offset: 0x005D2AB5
	private void UpdateEndlessToggleEnable(bool isEnable)
	{
		this.CachedEndlessEnable = isEnable;
		UUITexture texture = base.GetTexture(27);
		if (texture != null)
		{
			texture.SetUIActive(!isEnable);
		}
		UUIItem item = base.GetItem(32);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isEnable);
	}

	// Token: 0x06016F7E RID: 94078 RVA: 0x005D48E8 File Offset: 0x005D2AE8
	private void RefreshLeftBottomArea(IReadOnlyList<int> survivorsRoleIdList, IReadOnlyList<int> survivorsWeaponIdList)
	{
		bool flag = this.RefreshRoleHead(survivorsRoleIdList);
		GenericScrollViewNew<WeaponItemComponent, int> weaponItemScroll = this.WeaponItemScroll;
		if (weaponItemScroll != null)
		{
			weaponItemScroll.RefreshByData(survivorsWeaponIdList.ToList<int>(), null, false);
		}
		bool uiactive = flag || survivorsWeaponIdList.Count > 0;
		UUIItem item = base.GetItem(31);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06016F7F RID: 94079 RVA: 0x005D4938 File Offset: 0x005D2B38
	private bool RefreshRoleHead(IReadOnlyList<int> survivorsRoleIdList)
	{
		for (int i = 0; i < survivorsRoleIdList.Count; i++)
		{
			int num = survivorsRoleIdList[i];
			SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
			if (activityData != null && activityData.IsRoleIdCanShow(num))
			{
				RoleItemComponent roleHeadComp = this.RoleHeadComp;
				if (roleHeadComp != null)
				{
					roleHeadComp.SetUiActive(true);
				}
				RoleItemComponent roleHeadComp2 = this.RoleHeadComp;
				if (roleHeadComp2 != null)
				{
					roleHeadComp2.Refresh(num);
				}
				return true;
			}
		}
		RoleItemComponent roleHeadComp3 = this.RoleHeadComp;
		if (roleHeadComp3 != null)
		{
			roleHeadComp3.SetUiActive(false);
		}
		return false;
	}

	// Token: 0x06016F80 RID: 94080 RVA: 0x005D49B0 File Offset: 0x005D2BB0
	public void RefreshRewardByDropPackage(int dropPackageId, bool isCleared)
	{
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropPackageId);
		this.RewardLoopScroll.RefreshByData(dropPackagePreviewItemList, delegate
		{
			List<CommonItemSmallItemGrid> scrollItemList = this.RewardLoopScroll.GetScrollItemList();
			for (int i = 0; i < scrollItemList.Count; i++)
			{
				scrollItemList[i].SetReceivedVisible(isCleared);
			}
		}, false);
	}

	// Token: 0x06016F81 RID: 94081 RVA: 0x005D49F8 File Offset: 0x005D2BF8
	private void RefreshEndlessToggle()
	{
		SurvivorsActivityDefine.SurvivorsLevelInfo selectLevelInfo = SurvivorsRogueModel.Instance.SelectLevelInfo;
		SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(selectLevelInfo.LevelId);
		if (!survivorsLevel.Value.EndlessMode)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(15);
			if (extendToggle != null)
			{
				extendToggle.RootUIComp.Get().SetUIActive(false);
			}
			EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueLevelDetailViewEndlessToggleRefresh, false);
		}
		else
		{
			bool levelUnlockState = SurvivorsRogueModel.Instance.ActivityData.GetLevelUnlockState(selectLevelInfo.LevelId, true);
			this.UpdateEndlessToggleEnable(levelUnlockState);
			EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueLevelDetailViewEndlessToggleRefresh, levelUnlockState);
		}
		bool flag = SurvivorsRogueModel.Instance.ActivityData.IsEndlessMode(selectLevelInfo.LevelId);
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(15);
		if (extendToggle2 != null)
		{
			extendToggle2.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, true);
		}
		this.SetEndlessMode(flag);
		if (survivorsLevel.Value.Diff >= 2 || flag)
		{
			AudioSystem.Instance.PostEvent("play_ui_xingcunzhe_leveldetail_open_difficult");
			return;
		}
		AudioSystem.Instance.PostEvent("play_ui_xingcunzhe_leveldetail_open_normal");
	}

	// Token: 0x06016F82 RID: 94082 RVA: 0x005D4B0D File Offset: 0x005D2D0D
	private void UpdateLevelDesc(string descId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), descId, Array.Empty<object>());
	}

	// Token: 0x06016F83 RID: 94083 RVA: 0x005D4B28 File Offset: 0x005D2D28
	private void UpdateLevelTarget(string targetDescId, int levelId, bool isEndless)
	{
		List<string> list = new List<string>();
		ISurvivorsLevelInfo currentLevelInfoByLevelId = SurvivorsRogueModel.Instance.ActivityData.GetCurrentLevelInfoByLevelId(levelId);
		if (isEndless)
		{
			list.Add(currentLevelInfoByLevelId.Info.KillMonsterCount.ToString());
		}
		else
		{
			int maxWaveNumByLevelId = SurvivorsRogueConfig.Instance.GetMaxWaveNumByLevelId(levelId);
			list.Add(currentLevelInfoByLevelId.Info.WaveId.ToString());
			list.Add(maxWaveNumByLevelId.ToString());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), targetDescId, list.ToArray());
	}

	// Token: 0x06016F84 RID: 94084 RVA: 0x005D4BB8 File Offset: 0x005D2DB8
	private void UpdateToggleTextColor(bool bUseChangeColor)
	{
		UUIText text = base.GetText(16);
		if (text != null)
		{
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
	}

	// Token: 0x06016F85 RID: 94085 RVA: 0x005D4BE6 File Offset: 0x005D2DE6
	private void UpdateLevelTag(bool isEndless)
	{
		UUIItem cachedNormalTag = this.CachedNormalTag;
		if (cachedNormalTag != null)
		{
			cachedNormalTag.SetUIActive(!isEndless);
		}
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isEndless);
	}

	// Token: 0x06016F86 RID: 94086 RVA: 0x005D4C10 File Offset: 0x005D2E10
	private bool CheckIsRecordedSwitchOn()
	{
		return SurvivorsRogueModel.Instance.ActivityData.SaveCacheState(ESurvivorsActivitySaveFlags.EndlessFirstCheck, 0, 0, 1);
	}

	// Token: 0x0400AB36 RID: 43830
	private readonly string[] bgTexturePath = new string[]
	{
		"UiTexture_SurvivorsLevelDetailBg1",
		"UiTexture_SurvivorsLevelDetailBg2",
		"UiTexture_SurvivorsLevelDetailBg3"
	};

	// Token: 0x0400AB37 RID: 43831
	private int CachedLevelId = -1;

	// Token: 0x0400AB38 RID: 43832
	private bool CachedEndlessEnable;

	// Token: 0x0400AB39 RID: 43833
	[Nullable(2)]
	private UUIItem CachedNormalBackground;

	// Token: 0x0400AB3A RID: 43834
	[Nullable(2)]
	private UUIItem CachedNormalTag;

	// Token: 0x0400AB3B RID: 43835
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AB3C RID: 43836
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionArea;

	// Token: 0x0400AB3D RID: 43837
	[Nullable(2)]
	private PopupCaptionItem CaptionComp;

	// Token: 0x0400AB3E RID: 43838
	[Nullable(2)]
	private RoleItemComponent RoleHeadComp;

	// Token: 0x0400AB3F RID: 43839
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WeaponItemComponent, int> WeaponItemScroll;

	// Token: 0x0400AB40 RID: 43840
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLoopScroll;
}
