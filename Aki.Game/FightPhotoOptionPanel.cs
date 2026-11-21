using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA6 RID: 6822
[NullableContext(2)]
[Nullable(0)]
public class FightPhotoOptionPanel : UiPanelBase
{
	// Token: 0x06010E2E RID: 69166 RVA: 0x004F3D54 File Offset: 0x004F1F54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnHideMonsterToggleClick))
		};
	}

	// Token: 0x06010E2F RID: 69167 RVA: 0x004F3EF8 File Offset: 0x004F20F8
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoOptionPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoOptionPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E30 RID: 69168 RVA: 0x004F3F3C File Offset: 0x004F213C
	public UniTask RefreshTabLayout()
	{
		FightPhotoOptionPanel.<RefreshTabLayout>d__15 <RefreshTabLayout>d__;
		<RefreshTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabLayout>d__.<>4__this = this;
		<RefreshTabLayout>d__.<>1__state = -1;
		<RefreshTabLayout>d__.<>t__builder.Start<FightPhotoOptionPanel.<RefreshTabLayout>d__15>(ref <RefreshTabLayout>d__);
		return <RefreshTabLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06010E31 RID: 69169 RVA: 0x004F3F80 File Offset: 0x004F2180
	private void RefreshTabContent(EFightPhotoTab tab)
	{
		FightPhotoModel.Instance.SelectedTab = new EFightPhotoTab?(tab);
		FightPhotoMissionPanel missionPanel = this.MissionPanel;
		if (missionPanel != null)
		{
			missionPanel.SetUiActive(tab == EFightPhotoTab.Mission);
		}
		FightPhotoFilterPanel filterPanel = this.FilterPanel;
		if (filterPanel != null)
		{
			filterPanel.SetUiActive(tab == EFightPhotoTab.Filter);
		}
		FightPhotoSettingPanel settingPanel = this.SettingPanel;
		if (settingPanel != null)
		{
			settingPanel.SetUiActive(tab == EFightPhotoTab.Setting);
		}
		FightPhotoFramePanel framePanel = this.FramePanel;
		if (framePanel != null)
		{
			framePanel.SetUiActive(tab == EFightPhotoTab.Frame);
		}
		this.CurrentTabPanel = this.GetTabPanel(tab);
		FightPhotoTabPanelBase currentTabPanel = this.CurrentTabPanel;
		if (currentTabPanel == null)
		{
			return;
		}
		currentTabPanel.PlaySwitchAnim();
	}

	// Token: 0x06010E32 RID: 69170 RVA: 0x004F400E File Offset: 0x004F220E
	private FightPhotoTabPanelBase GetTabPanel(EFightPhotoTab tab)
	{
		switch (tab)
		{
		case EFightPhotoTab.Mission:
			return this.MissionPanel;
		case EFightPhotoTab.Filter:
			return this.FilterPanel;
		case EFightPhotoTab.Setting:
			return this.SettingPanel;
		case EFightPhotoTab.Frame:
			return this.FramePanel;
		default:
			return null;
		}
	}

	// Token: 0x06010E33 RID: 69171 RVA: 0x004F4047 File Offset: 0x004F2247
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnChangeFightPhotoOption, new Action(this.OnFrameOptionChanged));
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06010E34 RID: 69172 RVA: 0x004F4080 File Offset: 0x004F2280
	public void RefreshMissionState()
	{
		TakePicturesWithTimeScaleChildQuestNode currentBtNode = PhotographController.Instance.CurrentBtNode;
		if (currentBtNode == null)
		{
			UUISprite sprite = base.GetSprite(15);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			if (!this.IsShowingNoMission)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "FightPhoto_NoMission", Array.Empty<object>());
				this.IsShowingNoMission = true;
				this.LastFinishedCount = -1;
				this.LastTotalCount = -1;
			}
			return;
		}
		this.IsShowingNoMission = false;
		FightPhotoModel instance = FightPhotoModel.Instance;
		IPhotographCondition photographCondition = currentBtNode.PhotographCondition;
		bool flag = instance.CheckRoleInCamera(photographCondition);
		bool flag2 = instance.CheckPhotographCondition(photographCondition);
		if (currentBtNode.InProgress)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(flag2 && this.IsDefaultFrame());
			}
		}
		int num = 0;
		int num2 = 0;
		if (photographCondition != null)
		{
			num++;
			if (flag && flag2)
			{
				num2++;
			}
		}
		ICameraCondition cameraCondition = currentBtNode.CameraCondition;
		if (cameraCondition != null)
		{
			num++;
			if (instance.CheckCameraCondition(cameraCondition))
			{
				num2++;
			}
		}
		if (num2 == this.LastFinishedCount && num == this.LastTotalCount)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "FightPhoto_Mission_Progress", new <>z__ReadOnlyArray<object>(new object[]
		{
			num2,
			num
		}));
		if (this.LastFinishedCount != -1 && num2 > this.LastFinishedCount)
		{
			this.PlaySequence("Sweep");
		}
		this.LastFinishedCount = num2;
		this.LastTotalCount = num;
	}

	// Token: 0x06010E35 RID: 69173 RVA: 0x004F4204 File Offset: 0x004F2404
	[NullableContext(1)]
	private void PlaySequence(string sequenceName)
	{
		if (this.SequencePlayer == null)
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.SequencePlayer.StopCurrentSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06010E36 RID: 69174 RVA: 0x004F4250 File Offset: 0x004F2450
	protected override void OnBeforeHide()
	{
		this.SetAllMonsterVisible(true);
		this.LastFinishedCount = -1;
		this.LastTotalCount = -1;
		this.IsShowingNoMission = false;
		EventSystem.Instance.Remove(EEventName.OnChangeFightPhotoOption, new Action(this.OnFrameOptionChanged));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06010E37 RID: 69175 RVA: 0x004F42AE File Offset: 0x004F24AE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x06010E38 RID: 69176 RVA: 0x004F42C8 File Offset: 0x004F24C8
	private void SetAllMonsterVisible(bool isVisible)
	{
		if (this.MonsterEntityHandleList.Count == 0)
		{
			int value = ConfigCommonParamById.GetIntConfig("FightPhotoHideMonsterDistance").Value;
			CreatureModel.Instance.GetEntitiesInRange((float)value, EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss, this.MonsterEntityHandleList, true, false);
		}
		foreach (EntityHandle entityHandle in this.MonsterEntityHandleList)
		{
			if (entityHandle != null && entityHandle.Valid && entityHandle.Entity != null && entityHandle.Entity.Valid && entityHandle.Entity.Active != isVisible)
			{
				if (isVisible)
				{
					int handle;
					if (this.HandleToDisableIdMap.TryGetValue(entityHandle, out handle))
					{
						entityHandle.Entity.Enable(handle, "FightPhotoOptionPanel.OnHideMonsterToggleClick");
						this.HandleToDisableIdMap.Remove(entityHandle);
					}
				}
				else
				{
					int value2 = entityHandle.Entity.Disable("[FightPhotoOptionPanel.OnHideMonsterToggleClick] state为false");
					this.HandleToDisableIdMap.Add(entityHandle, value2);
				}
			}
		}
	}

	// Token: 0x06010E39 RID: 69177 RVA: 0x004F43DC File Offset: 0x004F25DC
	public void RefreshCondition()
	{
		TakePicturesWithTimeScaleChildQuestNode currentBtNode = PhotographController.Instance.CurrentBtNode;
		if (currentBtNode == null || !currentBtNode.InProgress)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		FightPhotoMissionPanel missionPanel = this.MissionPanel;
		if (missionPanel != null)
		{
			missionPanel.RefreshCondition().Forget();
		}
		this.RefreshMissionState();
	}

	// Token: 0x06010E3A RID: 69178 RVA: 0x004F4444 File Offset: 0x004F2644
	public void RefreshTip()
	{
		bool uiactive = PhotographController.Instance.IsFinishCurrentBtNode();
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		string textStringId = PhotographController.Instance.IsFightPhotoCanSettle() ? "PrefabTextItem_4294734977_Text" : "FightPhotoFinishTips";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
	}

	// Token: 0x06010E3B RID: 69179 RVA: 0x004F449F File Offset: 0x004F269F
	public void SetTipVisible(bool isVisible)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isVisible);
	}

	// Token: 0x06010E3C RID: 69180 RVA: 0x004F44B3 File Offset: 0x004F26B3
	[NullableContext(1)]
	private FightPhotoTabItem CreateTabItem()
	{
		return new FightPhotoTabItem
		{
			OnToggleClick = new Action<EFightPhotoTab>(this.OnTabClick)
		};
	}

	// Token: 0x06010E3D RID: 69181 RVA: 0x004F44CC File Offset: 0x004F26CC
	private void OnTabClick(EFightPhotoTab tab)
	{
		this.TabLayout.SelectGridProxyByKey(tab, false);
		this.RefreshTabContent(tab);
	}

	// Token: 0x06010E3E RID: 69182 RVA: 0x004F44E7 File Offset: 0x004F26E7
	private void OnHideMonsterToggleClick(EToggleState toggleState)
	{
		this.SetAllMonsterVisible(toggleState == EToggleState.ETT_UnChecked);
	}

	// Token: 0x06010E3F RID: 69183 RVA: 0x004F44F3 File Offset: 0x004F26F3
	private void OnFrameSwitched()
	{
		this.PlaySequence("FrameIn");
	}

	// Token: 0x06010E40 RID: 69184 RVA: 0x004F4500 File Offset: 0x004F2700
	public void SetHideAreaActive(bool bVisible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06010E41 RID: 69185 RVA: 0x004F4518 File Offset: 0x004F2718
	public void ApplyFrameStyle(FightPhotoFrameStyle config)
	{
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(config.ShowDecoration);
		}
		bool flag = config.Mode == 2;
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		ValueTuple<float, float, float, float> valueTuple = FightPhotoModel.Instance.CalcFrameRect(config.AspectRatio, config.ScreenRatio);
		UUIItem item4 = base.GetItem(11);
		if (item4 != null)
		{
			item4.SetWidth(valueTuple.Item1);
			item4.SetHeight(valueTuple.Item2);
			UUIItem uuiitem = item4;
			FRotator frotator = new FRotator(0f, config.RotationAngle * 360f, 0f);
			uuiitem.SetUIRelativeRotation(frotator);
		}
		BP_CameraShot_C cameraShotActor = FightPhotoController.Instance.GetCameraShotActor();
		UUIItem item5 = base.GetItem(13);
		UUIItem item6 = base.GetItem(14);
		if (cameraShotActor != null && (item5 != null || item6 != null))
		{
			FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
			float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
			float num = viewportSize.X / viewportScale;
			float num2 = viewportSize.Y / viewportScale;
			if (item5 != null)
			{
				cameraShotActor.Line1X = Math.Abs(item5.RelativeLocation.X) / num;
				cameraShotActor.Line1Y = Math.Abs(item5.RelativeLocation.Y) / num2;
			}
			if (item6 != null)
			{
				cameraShotActor.Line2X = -Math.Abs(item6.RelativeLocation.X) / num;
				cameraShotActor.Line2Y = Math.Abs(item6.RelativeLocation.Y) / num2;
			}
			cameraShotActor.SetParameter();
		}
	}

	// Token: 0x06010E42 RID: 69186 RVA: 0x004F46B0 File Offset: 0x004F28B0
	private void OnFrameOptionChanged()
	{
		int? fightPhotoExtraOption = FightPhotoModel.Instance.GetFightPhotoExtraOption(EFightPhotoExtraOptionType.Frame);
		if (fightPhotoExtraOption != null)
		{
			int? num = fightPhotoExtraOption;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				FightPhotoFrameStyle? fightPhotoFrameStyleConfigById = PhotographConfig.Instance.GetFightPhotoFrameStyleConfigById(fightPhotoExtraOption.Value);
				if (fightPhotoFrameStyleConfigById == null)
				{
					return;
				}
				this.ApplyFrameStyle(fightPhotoFrameStyleConfigById.Value);
				if (!this.IsDefaultFrame())
				{
					UUIItem item = base.GetItem(5);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(false);
				}
				return;
			}
		}
	}

	// Token: 0x06010E43 RID: 69187 RVA: 0x004F472E File Offset: 0x004F292E
	private void OnViewPortSizeChanged()
	{
		PhotographController.Instance.ReapplyCurrentFrame();
		this.OnFrameOptionChanged();
	}

	// Token: 0x06010E44 RID: 69188 RVA: 0x004F4740 File Offset: 0x004F2940
	private bool IsDefaultFrame()
	{
		int? fightPhotoExtraOption = FightPhotoModel.Instance.GetFightPhotoExtraOption(EFightPhotoExtraOptionType.Frame);
		if (fightPhotoExtraOption != null)
		{
			int? num = fightPhotoExtraOption;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				FightPhotoFrameStyle? fightPhotoFrameStyleConfigById = PhotographConfig.Instance.GetFightPhotoFrameStyleConfigById(fightPhotoExtraOption.Value);
				return fightPhotoFrameStyleConfigById == null || fightPhotoFrameStyleConfigById.Value.Mode == 0;
			}
		}
		return true;
	}

	// Token: 0x06010E45 RID: 69189 RVA: 0x004F47AC File Offset: 0x004F29AC
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (configParams[0] == "HideEnemy")
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
			UUIItem guideUiItem = base.GetGuideUiItem("2");
			if (uuiitem != null && guideUiItem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					guideUiItem
				};
			}
		}
		if (!(configParams[0] == "FightPhotoTab"))
		{
			return null;
		}
		int num = int.Parse(configParams[1]);
		GenericLayout<FightPhotoTabItem, EFightPhotoTab> tabLayout = this.TabLayout;
		UUIItem uuiitem2 = (tabLayout != null) ? tabLayout.GetItemByIndex(num - 1) : null;
		if (uuiitem2 == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem2,
			uuiitem2
		};
	}

	// Token: 0x0400951D RID: 38173
	[Nullable(1)]
	private readonly List<EntityHandle> MonsterEntityHandleList = new List<EntityHandle>();

	// Token: 0x0400951E RID: 38174
	[Nullable(1)]
	private readonly Dictionary<EntityHandle, int> HandleToDisableIdMap = new Dictionary<EntityHandle, int>();

	// Token: 0x0400951F RID: 38175
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FightPhotoTabItem, EFightPhotoTab> TabLayout;

	// Token: 0x04009520 RID: 38176
	private FightPhotoMissionPanel MissionPanel;

	// Token: 0x04009521 RID: 38177
	private FightPhotoFilterPanel FilterPanel;

	// Token: 0x04009522 RID: 38178
	private FightPhotoSettingPanel SettingPanel;

	// Token: 0x04009523 RID: 38179
	private FightPhotoFramePanel FramePanel;

	// Token: 0x04009524 RID: 38180
	private FightPhotoTabPanelBase CurrentTabPanel;

	// Token: 0x04009525 RID: 38181
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009526 RID: 38182
	private int LastFinishedCount = -1;

	// Token: 0x04009527 RID: 38183
	private int LastTotalCount = -1;

	// Token: 0x04009528 RID: 38184
	private bool IsShowingNoMission;

	// Token: 0x02007D4F RID: 32079
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040288F1 RID: 166129
		LayoutTab,
		// Token: 0x040288F2 RID: 166130
		ItemTab,
		// Token: 0x040288F3 RID: 166131
		ItemContent,
		// Token: 0x040288F4 RID: 166132
		ItemTip,
		// Token: 0x040288F5 RID: 166133
		TextTip,
		// Token: 0x040288F6 RID: 166134
		ItemFrame,
		// Token: 0x040288F7 RID: 166135
		ItemFrameTip,
		// Token: 0x040288F8 RID: 166136
		ToggleHideMonster,
		// Token: 0x040288F9 RID: 166137
		ItemPhotoFrame,
		// Token: 0x040288FA RID: 166138
		TextTitle,
		// Token: 0x040288FB RID: 166139
		ItemDeco,
		// Token: 0x040288FC RID: 166140
		ItemPhotoFrameParent,
		// Token: 0x040288FD RID: 166141
		ItemHidePanel,
		// Token: 0x040288FE RID: 166142
		ItemPointLeft,
		// Token: 0x040288FF RID: 166143
		ItemPointTop,
		// Token: 0x04028900 RID: 166144
		SpriteMissionLine
	}
}
