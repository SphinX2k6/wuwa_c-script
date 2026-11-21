using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002084 RID: 8324
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTabMainView : UiViewBase
{
	// Token: 0x06014894 RID: 84116 RVA: 0x005FC0D2 File Offset: 0x005FA2D2
	[NullableContext(1)]
	public SurvivorsTabMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014895 RID: 84117 RVA: 0x005FC0F0 File Offset: 0x005FA2F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.GoRight)),
			new ValueTuple<int, Delegate>(7, new Action(this.GoLeft))
		};
	}

	// Token: 0x06014896 RID: 84118 RVA: 0x005FC1F4 File Offset: 0x005FA3F4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTabMainView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTabMainView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014897 RID: 84119 RVA: 0x005FC237 File Offset: 0x005FA437
	protected override void OnStart()
	{
		this.RefreshCaption();
		this.RefreshTabs();
		this.RefreshDefaultSelectedTab();
	}

	// Token: 0x06014898 RID: 84120 RVA: 0x005FC24C File Offset: 0x005FA44C
	protected override void OnBeforeDestroy()
	{
		if (this.LevelSequencePlayerList != null)
		{
			foreach (LevelSequencePlayer levelSequencePlayer in this.LevelSequencePlayerList)
			{
				levelSequencePlayer.Clear();
			}
		}
		this.LevelSequencePlayerList = null;
	}

	// Token: 0x06014899 RID: 84121 RVA: 0x005FC2AC File Offset: 0x005FA4AC
	private void RefreshDefaultSelectedTab()
	{
		SurvivorsTabMainViewData survivorsTabMainViewData = this.OpenParam as SurvivorsTabMainViewData;
		if (survivorsTabMainViewData == null)
		{
			SurvivorsTabMainTabItem roleTab = this.RoleTab;
			if (roleTab == null)
			{
				return;
			}
			roleTab.SetForceSwitch(EToggleState.ETT_Checked, true);
			return;
		}
		else
		{
			ETabType? skipTabType = survivorsTabMainViewData.SkipTabType;
			if (skipTabType != null)
			{
				ETabType valueOrDefault = skipTabType.GetValueOrDefault();
				if (valueOrDefault != ETabType.Weapon)
				{
					if (valueOrDefault == ETabType.Item)
					{
						SurvivorsTabMainTabItem itemTab = this.ItemTab;
						if (itemTab == null)
						{
							return;
						}
						itemTab.SetForceSwitch(EToggleState.ETT_Checked, true);
						return;
					}
				}
				else
				{
					int? num = null;
					if (survivorsTabMainViewData.SkipWeaponId != null)
					{
						int num2 = 0;
						for (;;)
						{
							int num3 = num2;
							List<ISurvivorsWeaponGridData> cachedWeaponGridDataList = this.CachedWeaponGridDataList;
							int? num4 = (cachedWeaponGridDataList != null) ? new int?(cachedWeaponGridDataList.Count) : null;
							if (!(num3 < num4.GetValueOrDefault() & num4 != null))
							{
								goto IL_105;
							}
							SurvivorsWeaponGainData weaponData = this.CachedWeaponGridDataList[num2].WeaponData;
							num4 = ((weaponData != null) ? new int?(weaponData.ConfigId) : null);
							int value = survivorsTabMainViewData.SkipWeaponId.Value;
							if (num4.GetValueOrDefault() == value & num4 != null)
							{
								break;
							}
							num2++;
						}
						num = new int?(num2);
					}
					IL_105:
					if (num == null || num.GetValueOrDefault() == -1)
					{
						num = survivorsTabMainViewData.SkipTabIndex;
					}
					TabComponent<SurvivorsTabMainTabItem> weaponTabComponent = this.WeaponTabComponent;
					if (weaponTabComponent == null)
					{
						return;
					}
					SurvivorsTabMainTabItem tabItemByIndex = weaponTabComponent.GetTabItemByIndex(num.GetValueOrDefault());
					if (tabItemByIndex == null)
					{
						return;
					}
					tabItemByIndex.SetForceSwitch(EToggleState.ETT_Checked, true);
					return;
				}
			}
			SurvivorsTabMainTabItem roleTab2 = this.RoleTab;
			if (roleTab2 == null)
			{
				return;
			}
			roleTab2.SetForceSwitch(EToggleState.ETT_Checked, true);
			return;
		}
	}

	// Token: 0x0601489A RID: 84122 RVA: 0x005FC424 File Offset: 0x005FA624
	private UniTask CreatePages()
	{
		SurvivorsTabMainView.<CreatePages>d__20 <CreatePages>d__;
		<CreatePages>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePages>d__.<>4__this = this;
		<CreatePages>d__.<>1__state = -1;
		<CreatePages>d__.<>t__builder.Start<SurvivorsTabMainView.<CreatePages>d__20>(ref <CreatePages>d__);
		return <CreatePages>d__.<>t__builder.Task;
	}

	// Token: 0x0601489B RID: 84123 RVA: 0x005FC468 File Offset: 0x005FA668
	private UniTask CreateTabs()
	{
		SurvivorsTabMainView.<CreateTabs>d__21 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<SurvivorsTabMainView.<CreateTabs>d__21>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0601489C RID: 84124 RVA: 0x005FC4AC File Offset: 0x005FA6AC
	public void RefreshTabs()
	{
		Dictionary<int, SurvivorsTabMainTabItem> tabItemMap = this.WeaponTabComponent.GetTabItemMap();
		if (this.CachedWeaponGridDataList != null)
		{
			for (int i = 0; i < this.CachedWeaponGridDataList.Count; i++)
			{
				ISurvivorsWeaponGridData survivorsWeaponGridData = this.CachedWeaponGridDataList[i];
				SurvivorsTabMainTabItem survivorsTabMainTabItem = tabItemMap.ContainsKey(i) ? tabItemMap[i] : null;
				if (survivorsWeaponGridData.IsDisable)
				{
					if (survivorsTabMainTabItem != null)
					{
						survivorsTabMainTabItem.RefreshTabState(ETabState.None);
					}
				}
				else if (survivorsWeaponGridData.IsLock)
				{
					if (survivorsTabMainTabItem != null)
					{
						survivorsTabMainTabItem.RefreshTabState(ETabState.Lock);
					}
					if (survivorsTabMainTabItem != null)
					{
						survivorsTabMainTabItem.RefreshUnlockWave(survivorsWeaponGridData.UnlockBatch.GetValueOrDefault());
					}
				}
				else
				{
					SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(survivorsWeaponGridData.WeaponData.ConfigId);
					if (survivorsTabMainTabItem != null)
					{
						survivorsTabMainTabItem.RefreshInfo(survivorsWeapon.Value.Icon, survivorsWeaponGridData.WeaponData.Data.Level);
					}
					if (survivorsTabMainTabItem != null)
					{
						survivorsTabMainTabItem.RefreshTabState(ETabState.Normal);
					}
				}
			}
		}
		SurvivorsTabMainTabItem roleTab = this.RoleTab;
		if (roleTab != null)
		{
			roleTab.SetTextById("SurvivorCharacterAttributeInterface_Name");
		}
		SurvivorsTabMainTabItem roleTab2 = this.RoleTab;
		if (roleTab2 != null)
		{
			roleTab2.RefreshTabState(ETabState.Normal);
		}
		SurvivorsTabMainTabItem itemTab = this.ItemTab;
		if (itemTab != null)
		{
			itemTab.SetTextById("Text_Prop_Text");
		}
		SurvivorsTabMainTabItem itemTab2 = this.ItemTab;
		if (itemTab2 == null)
		{
			return;
		}
		itemTab2.RefreshTabState(ETabState.Normal);
	}

	// Token: 0x0601489D RID: 84125 RVA: 0x005FC5E6 File Offset: 0x005FA7E6
	[NullableContext(1)]
	private SurvivorsTabMainTabItem CreateWeaponCommonTab([Nullable(2)] UUIItem item, int? index)
	{
		return new SurvivorsTabMainTabItem();
	}

	// Token: 0x0601489E RID: 84126 RVA: 0x005FC5F0 File Offset: 0x005FA7F0
	private void RefreshCaption()
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

	// Token: 0x0601489F RID: 84127 RVA: 0x005FC694 File Offset: 0x005FA894
	private void RefreshSelectedPage(int index)
	{
		if (index == this.CurrentShowPageIndex)
		{
			return;
		}
		int currentShowPageIndex = this.CurrentShowPageIndex;
		if (currentShowPageIndex >= 0)
		{
			this.PageList[currentShowPageIndex].SetUiActive(false);
		}
		this.CurrentShowPageIndex = index;
		this.PageList[index].SetUiActive(true);
		List<LevelSequencePlayer> levelSequencePlayerList = this.LevelSequencePlayerList;
		LevelSequencePlayer levelSequencePlayer = (levelSequencePlayerList != null) ? levelSequencePlayerList[index] : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060148A0 RID: 84128 RVA: 0x005FC71C File Offset: 0x005FA91C
	private void RefreshSelectedTab(ETabType type)
	{
		if (this.CurrentSelectTab != null)
		{
			ETabType? currentSelectTab = this.CurrentSelectTab;
			if (!(currentSelectTab.GetValueOrDefault() == type & currentSelectTab != null))
			{
				currentSelectTab = this.CurrentSelectTab;
				if (currentSelectTab != null)
				{
					switch (currentSelectTab.GetValueOrDefault())
					{
					case ETabType.Role:
					{
						SurvivorsTabMainTabItem roleTab = this.RoleTab;
						if (roleTab != null)
						{
							roleTab.SetForceSwitch(EToggleState.ETT_UnChecked, false);
						}
						break;
					}
					case ETabType.Weapon:
					{
						TabComponent<SurvivorsTabMainTabItem> weaponTabComponent = this.WeaponTabComponent;
						if (weaponTabComponent != null)
						{
							weaponTabComponent.ResetSelectIndex();
						}
						break;
					}
					case ETabType.Item:
					{
						SurvivorsTabMainTabItem itemTab = this.ItemTab;
						if (itemTab != null)
						{
							itemTab.SetForceSwitch(EToggleState.ETT_UnChecked, false);
						}
						break;
					}
					}
				}
			}
		}
		this.CurrentSelectTab = new ETabType?(type);
	}

	// Token: 0x060148A1 RID: 84129 RVA: 0x005FC7C9 File Offset: 0x005FA9C9
	private void GoLeft()
	{
		this.OnClickChangeBtn(-1);
	}

	// Token: 0x060148A2 RID: 84130 RVA: 0x005FC7D2 File Offset: 0x005FA9D2
	private void GoRight()
	{
		this.OnClickChangeBtn(1);
	}

	// Token: 0x060148A3 RID: 84131 RVA: 0x005FC7DC File Offset: 0x005FA9DC
	private void OnClickChangeBtn(int step)
	{
		ETabType? currentSelectTab = this.CurrentSelectTab;
		ETabType? etabType = currentSelectTab;
		ETabType etabType2 = ETabType.Role;
		if (etabType.GetValueOrDefault() == etabType2 & etabType != null)
		{
			this.HandleRoleSwitch(step);
			return;
		}
		if (currentSelectTab.GetValueOrDefault() == ETabType.Item)
		{
			this.HandleItemSwitch(step);
			return;
		}
		this.HandleWeaponSwitch(step);
	}

	// Token: 0x060148A4 RID: 84132 RVA: 0x005FC82C File Offset: 0x005FAA2C
	private void HandleRoleSwitch(int step)
	{
		if (step != -1)
		{
			if (step == 1)
			{
				if (this.GetLastUnlockWeaponTabIndex() == -1)
				{
					SurvivorsTabMainTabItem itemTab = this.ItemTab;
					if (itemTab == null)
					{
						return;
					}
					itemTab.SetForceSwitch(EToggleState.ETT_Checked, true);
					return;
				}
				else
				{
					TabComponent<SurvivorsTabMainTabItem> weaponTabComponent = this.WeaponTabComponent;
					if (weaponTabComponent == null)
					{
						return;
					}
					weaponTabComponent.SelectToggleByIndex(0, false, true);
				}
			}
			return;
		}
		SurvivorsTabMainTabItem itemTab2 = this.ItemTab;
		if (itemTab2 == null)
		{
			return;
		}
		itemTab2.SetForceSwitch(EToggleState.ETT_Checked, true);
	}

	// Token: 0x060148A5 RID: 84133 RVA: 0x005FC884 File Offset: 0x005FAA84
	private void HandleItemSwitch(int step)
	{
		if (step != 1)
		{
			if (step == -1)
			{
				int lastUnlockWeaponTabIndex = this.GetLastUnlockWeaponTabIndex();
				if (lastUnlockWeaponTabIndex == -1)
				{
					SurvivorsTabMainTabItem roleTab = this.RoleTab;
					if (roleTab == null)
					{
						return;
					}
					roleTab.SetForceSwitch(EToggleState.ETT_Checked, true);
					return;
				}
				else
				{
					TabComponent<SurvivorsTabMainTabItem> weaponTabComponent = this.WeaponTabComponent;
					if (weaponTabComponent == null)
					{
						return;
					}
					weaponTabComponent.SelectToggleByIndex(lastUnlockWeaponTabIndex, false, true);
				}
			}
			return;
		}
		SurvivorsTabMainTabItem roleTab2 = this.RoleTab;
		if (roleTab2 == null)
		{
			return;
		}
		roleTab2.SetForceSwitch(EToggleState.ETT_Checked, true);
	}

	// Token: 0x060148A6 RID: 84134 RVA: 0x005FC8E0 File Offset: 0x005FAAE0
	private void HandleWeaponSwitch(int step)
	{
		int selectedIndex = this.WeaponTabComponent.GetSelectedIndex();
		int lastUnlockWeaponTabIndex = this.GetLastUnlockWeaponTabIndex();
		if (selectedIndex == 0 && step == -1)
		{
			TabComponent<SurvivorsTabMainTabItem> weaponTabComponent = this.WeaponTabComponent;
			if (weaponTabComponent != null)
			{
				weaponTabComponent.ResetSelectIndex();
			}
			SurvivorsTabMainTabItem roleTab = this.RoleTab;
			if (roleTab == null)
			{
				return;
			}
			roleTab.SetForceSwitch(EToggleState.ETT_Checked, true);
			return;
		}
		else if (selectedIndex >= lastUnlockWeaponTabIndex && step == 1)
		{
			TabComponent<SurvivorsTabMainTabItem> weaponTabComponent2 = this.WeaponTabComponent;
			if (weaponTabComponent2 != null)
			{
				weaponTabComponent2.ResetSelectIndex();
			}
			SurvivorsTabMainTabItem itemTab = this.ItemTab;
			if (itemTab == null)
			{
				return;
			}
			itemTab.SetForceSwitch(EToggleState.ETT_Checked, true);
			return;
		}
		else
		{
			TabComponent<SurvivorsTabMainTabItem> weaponTabComponent3 = this.WeaponTabComponent;
			if (weaponTabComponent3 == null)
			{
				return;
			}
			weaponTabComponent3.SelectToggleByIndex(selectedIndex + step, false, true);
			return;
		}
	}

	// Token: 0x060148A7 RID: 84135 RVA: 0x005FC96C File Offset: 0x005FAB6C
	private int GetLastUnlockWeaponTabIndex()
	{
		int result = -1;
		if (this.CachedWeaponGridDataList != null)
		{
			for (int i = 0; i < this.CachedWeaponGridDataList.Count; i++)
			{
				ISurvivorsWeaponGridData survivorsWeaponGridData = this.CachedWeaponGridDataList[i];
				if (!survivorsWeaponGridData.IsLock && !survivorsWeaponGridData.IsDisable)
				{
					result = i;
				}
			}
		}
		return result;
	}

	// Token: 0x060148A8 RID: 84136 RVA: 0x005FC9B9 File Offset: 0x005FABB9
	private void OnClickRoleTab(int gridIndex)
	{
		this.RefreshSelectedTab(ETabType.Role);
		this.RefreshSelectedPage(0);
	}

	// Token: 0x060148A9 RID: 84137 RVA: 0x005FC9C9 File Offset: 0x005FABC9
	private void OnClickItemTab(int gridIndex)
	{
		this.RefreshSelectedTab(ETabType.Item);
		this.RefreshSelectedPage(2);
	}

	// Token: 0x060148AA RID: 84138 RVA: 0x005FC9D9 File Offset: 0x005FABD9
	private void OnClickWeaponTab(int index)
	{
		this.RefreshSelectedTab(ETabType.Weapon);
		this.RefreshSelectedPage(1);
		SurvivorsWeaponDetailTabView weaponPage = this.WeaponPage;
		if (weaponPage == null)
		{
			return;
		}
		weaponPage.RefreshByData(this.CachedWeaponGridDataList[index].WeaponData);
	}

	// Token: 0x060148AB RID: 84139 RVA: 0x005FCA0A File Offset: 0x005FAC0A
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x060148AC RID: 84140 RVA: 0x005FCA14 File Offset: 0x005FAC14
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length <= 1)
		{
			return null;
		}
		string a = configParams[0];
		string name = configParams[1];
		if (a == "WeaponPage")
		{
			SurvivorsWeaponDetailTabView weaponPage = this.WeaponPage;
			UUIItem uuiitem = (weaponPage != null) ? weaponPage.GetGuideUiItem(name) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else if (a == "RolePage")
		{
			SurvivorsRoleDetailTabView rolePage = this.RolePage;
			UUIItem uuiitem2 = (rolePage != null) ? rolePage.GetGuideUiItem(name) : null;
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
		else
		{
			if (!(a == "ItemPage"))
			{
				return null;
			}
			SurvivorsItemDetailTabView itemPage = this.ItemPage;
			UUIItem uuiitem3 = (itemPage != null) ? itemPage.GetGuideUiItem(name) : null;
			if (uuiitem3 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem3,
				uuiitem3
			};
		}
	}

	// Token: 0x0400AE27 RID: 44583
	private const int TAB_STEP_LEFT = -1;

	// Token: 0x0400AE28 RID: 44584
	private const int TAB_STEP_RIGHT = 1;

	// Token: 0x0400AE29 RID: 44585
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISurvivorsWeaponGridData> CachedWeaponGridDataList;

	// Token: 0x0400AE2A RID: 44586
	[Nullable(1)]
	private readonly List<UiPanelBase> PageList = new List<UiPanelBase>();

	// Token: 0x0400AE2B RID: 44587
	private int CurrentShowPageIndex = -1;

	// Token: 0x0400AE2C RID: 44588
	private PopupCaptionItem CaptionComp;

	// Token: 0x0400AE2D RID: 44589
	private SurvivorsRoleDetailTabView RolePage;

	// Token: 0x0400AE2E RID: 44590
	private SurvivorsWeaponDetailTabView WeaponPage;

	// Token: 0x0400AE2F RID: 44591
	private SurvivorsItemDetailTabView ItemPage;

	// Token: 0x0400AE30 RID: 44592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LevelSequencePlayer> LevelSequencePlayerList;

	// Token: 0x0400AE31 RID: 44593
	private ETabType? CurrentSelectTab;

	// Token: 0x0400AE32 RID: 44594
	private SurvivorsTabMainTabItem RoleTab;

	// Token: 0x0400AE33 RID: 44595
	private SurvivorsTabMainTabItem ItemTab;

	// Token: 0x0400AE34 RID: 44596
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<SurvivorsTabMainTabItem> WeaponTabComponent;
}
