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

// Token: 0x020025BB RID: 9659
[NullableContext(2)]
[Nullable(0)]
public class FightPhotoOptionPanel : UiPanelBase
{
	// Token: 0x0601394E RID: 80206 RVA: 0x004E5154 File Offset: 0x004E3354
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

	// Token: 0x0601394F RID: 80207 RVA: 0x004E52F8 File Offset: 0x004E34F8
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoOptionPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoOptionPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013950 RID: 80208 RVA: 0x004E533C File Offset: 0x004E353C
	public UniTask RefreshTabLayout()
	{
		FightPhotoOptionPanel.<RefreshTabLayout>d__15 <RefreshTabLayout>d__;
		<RefreshTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabLayout>d__.<>4__this = this;
		<RefreshTabLayout>d__.<>1__state = -1;
		<RefreshTabLayout>d__.<>t__builder.Start<FightPhotoOptionPanel.<RefreshTabLayout>d__15>(ref <RefreshTabLayout>d__);
		return <RefreshTabLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06013951 RID: 80209 RVA: 0x004E5380 File Offset: 0x004E3580
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

	// Token: 0x06013952 RID: 80210 RVA: 0x004E540E File Offset: 0x004E360E
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

	// Token: 0x06013953 RID: 80211 RVA: 0x004E5447 File Offset: 0x004E3647
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnChangeFightPhotoOption, new Action(this.OnFrameOptionChanged));
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06013954 RID: 80212 RVA: 0x004E5480 File Offset: 0x004E3680
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

	// Token: 0x06013955 RID: 80213 RVA: 0x004E5604 File Offset: 0x004E3804
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

	// Token: 0x06013956 RID: 80214 RVA: 0x004E5650 File Offset: 0x004E3850
	protected override void OnBeforeHide()
	{
		this.SetAllMonsterVisible(true);
		this.LastFinishedCount = -1;
		this.LastTotalCount = -1;
		this.IsShowingNoMission = false;
		EventSystem.Instance.Remove(EEventName.OnChangeFightPhotoOption, new Action(this.OnFrameOptionChanged));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChanged));
	}

	// Token: 0x06013957 RID: 80215 RVA: 0x004E56AE File Offset: 0x004E38AE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x06013958 RID: 80216 RVA: 0x004E56C8 File Offset: 0x004E38C8
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

	// Token: 0x06013959 RID: 80217 RVA: 0x004E57DC File Offset: 0x004E39DC
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

	// Token: 0x0601395A RID: 80218 RVA: 0x004E5844 File Offset: 0x004E3A44
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

	// Token: 0x0601395B RID: 80219 RVA: 0x004E589F File Offset: 0x004E3A9F
	public void SetTipVisible(bool isVisible)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isVisible);
	}

	// Token: 0x0601395C RID: 80220 RVA: 0x004E58B3 File Offset: 0x004E3AB3
	[NullableContext(1)]
	private FightPhotoTabItem CreateTabItem()
	{
		return new FightPhotoTabItem
		{
			OnToggleClick = new Action<EFightPhotoTab>(this.OnTabClick)
		};
	}

	// Token: 0x0601395D RID: 80221 RVA: 0x004E58CC File Offset: 0x004E3ACC
	private void OnTabClick(EFightPhotoTab tab)
	{
		this.TabLayout.SelectGridProxyByKey(tab, false);
		this.RefreshTabContent(tab);
	}

	// Token: 0x0601395E RID: 80222 RVA: 0x004E58E7 File Offset: 0x004E3AE7
	private void OnHideMonsterToggleClick(EToggleState toggleState)
	{
		this.SetAllMonsterVisible(toggleState == EToggleState.ETT_UnChecked);
	}

	// Token: 0x0601395F RID: 80223 RVA: 0x004E58F3 File Offset: 0x004E3AF3
	private void OnFrameSwitched()
	{
		this.PlaySequence("FrameIn");
	}

	// Token: 0x06013960 RID: 80224 RVA: 0x004E5900 File Offset: 0x004E3B00
	public void SetHideAreaActive(bool bVisible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06013961 RID: 80225 RVA: 0x004E5918 File Offset: 0x004E3B18
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

	// Token: 0x06013962 RID: 80226 RVA: 0x004E5AB0 File Offset: 0x004E3CB0
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

	// Token: 0x06013963 RID: 80227 RVA: 0x004E5B2E File Offset: 0x004E3D2E
	private void OnViewPortSizeChanged()
	{
		PhotographController.Instance.ReapplyCurrentFrame();
		this.OnFrameOptionChanged();
	}

	// Token: 0x06013964 RID: 80228 RVA: 0x004E5B40 File Offset: 0x004E3D40
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

	// Token: 0x06013965 RID: 80229 RVA: 0x004E5BAC File Offset: 0x004E3DAC
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

	// Token: 0x040093C7 RID: 37831
	[Nullable(1)]
	private readonly List<EntityHandle> MonsterEntityHandleList = new List<EntityHandle>();

	// Token: 0x040093C8 RID: 37832
	[Nullable(1)]
	private readonly Dictionary<EntityHandle, int> HandleToDisableIdMap = new Dictionary<EntityHandle, int>();

	// Token: 0x040093C9 RID: 37833
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FightPhotoTabItem, EFightPhotoTab> TabLayout;

	// Token: 0x040093CA RID: 37834
	private FightPhotoMissionPanel MissionPanel;

	// Token: 0x040093CB RID: 37835
	private FightPhotoFilterPanel FilterPanel;

	// Token: 0x040093CC RID: 37836
	private FightPhotoSettingPanel SettingPanel;

	// Token: 0x040093CD RID: 37837
	private FightPhotoFramePanel FramePanel;

	// Token: 0x040093CE RID: 37838
	private FightPhotoTabPanelBase CurrentTabPanel;

	// Token: 0x040093CF RID: 37839
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040093D0 RID: 37840
	private int LastFinishedCount = -1;

	// Token: 0x040093D1 RID: 37841
	private int LastTotalCount = -1;

	// Token: 0x040093D2 RID: 37842
	private bool IsShowingNoMission;

	// Token: 0x02008BC7 RID: 35783
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D5DC RID: 185820
		LayoutTab,
		// Token: 0x0402D5DD RID: 185821
		ItemTab,
		// Token: 0x0402D5DE RID: 185822
		ItemContent,
		// Token: 0x0402D5DF RID: 185823
		ItemTip,
		// Token: 0x0402D5E0 RID: 185824
		TextTip,
		// Token: 0x0402D5E1 RID: 185825
		ItemFrame,
		// Token: 0x0402D5E2 RID: 185826
		ItemFrameTip,
		// Token: 0x0402D5E3 RID: 185827
		ToggleHideMonster,
		// Token: 0x0402D5E4 RID: 185828
		ItemPhotoFrame,
		// Token: 0x0402D5E5 RID: 185829
		TextTitle,
		// Token: 0x0402D5E6 RID: 185830
		ItemDeco,
		// Token: 0x0402D5E7 RID: 185831
		ItemPhotoFrameParent,
		// Token: 0x0402D5E8 RID: 185832
		ItemHidePanel,
		// Token: 0x0402D5E9 RID: 185833
		ItemPointLeft,
		// Token: 0x0402D5EA RID: 185834
		ItemPointTop,
		// Token: 0x0402D5EB RID: 185835
		SpriteMissionLine
	}
}
