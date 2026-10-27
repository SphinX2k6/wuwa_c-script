using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.View
{
	// Token: 0x02004856 RID: 18518
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalBarItem : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17007916 RID: 30998
		// (get) Token: 0x0603074E RID: 198478 RVA: 0x00B4008A File Offset: 0x00B3E28A
		// (set) Token: 0x0603074F RID: 198479 RVA: 0x00B40092 File Offset: 0x00B3E292
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x06030750 RID: 198480 RVA: 0x00B4009C File Offset: 0x00B3E29C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickButtonFold));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickButtonUnfold));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickButtonMenu));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030751 RID: 198481 RVA: 0x00B40294 File Offset: 0x00B3E494
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinishEvent), false);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			this.LayoutGameplay = new GenericScrollViewNew<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData>(base.GetScrollViewWithScrollbar(0), new Func<RegionalTerminalBarGameplayItem>(this.CreateGameplayItem), null, false, null);
			this.RefreshGameplayList();
			base.GetItem(8).SetUIActive(!this.CanUnfold);
			IRegionalTerminalBarItemParams regionalTerminalBarItemParams = this.OpenParam as IRegionalTerminalBarItemParams;
			if (regionalTerminalBarItemParams != null && regionalTerminalBarItemParams.IsUnfold != null)
			{
				this.FoldState = (!this.CanUnfold || !regionalTerminalBarItemParams.IsUnfold.GetValueOrDefault());
			}
			else
			{
				this.FoldState = (!this.CanUnfold || RegionalTerminalModel.Instance.BarFoldState);
			}
			this.RefreshState();
		}

		// Token: 0x06030752 RID: 198482 RVA: 0x00B40388 File Offset: 0x00B3E588
		public void BeforeShow()
		{
			this.RefreshGameplayList();
			this.RefreshState();
			EventSystem.Instance.Add<int, bool>(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Add(EEventName.AreaMapGroupIdChanged, new Action(this.OnAreaMapGroupIdChanged));
		}

		// Token: 0x06030753 RID: 198483 RVA: 0x00B403D9 File Offset: 0x00B3E5D9
		public void BeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Remove(EEventName.AreaMapGroupIdChanged, new Action(this.OnAreaMapGroupIdChanged));
		}

		// Token: 0x06030754 RID: 198484 RVA: 0x00B40413 File Offset: 0x00B3E613
		private void OnGameplayPinUpdate(int i, bool b)
		{
			this.RefreshGameplayList();
			this.RefreshState();
		}

		// Token: 0x06030755 RID: 198485 RVA: 0x00B40424 File Offset: 0x00B3E624
		private void OnAreaMapGroupIdChanged()
		{
			this.RefreshGameplayList();
			this.RefreshState();
			if (!this.FoldState && this.IsGameplayListShow)
			{
				this.LevelSequencePlayer.StopSequenceByKey("Close", true, false);
				this.AnimState = true;
				this.LevelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
			}
		}

		// Token: 0x06030756 RID: 198486 RVA: 0x00B40480 File Offset: 0x00B3E680
		private void OnSequenceFinishEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.RefreshState();
			}
			this.AnimState = false;
		}

		// Token: 0x06030757 RID: 198487 RVA: 0x00B4049C File Offset: 0x00B3E69C
		private void OnEventSequence(string sequenceName, string eventName)
		{
			GenericScrollViewNew<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> layoutGameplay = this.LayoutGameplay;
			UUIInturnAnimController uuiinturnAnimController;
			if (layoutGameplay == null)
			{
				uuiinturnAnimController = null;
			}
			else
			{
				GenericLayout<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> genericLayout = layoutGameplay.GetGenericLayout();
				uuiinturnAnimController = ((genericLayout != null) ? genericLayout.GetUiAnimController() : null);
			}
			UUIInturnAnimController uuiinturnAnimController2 = uuiinturnAnimController;
			if (uuiinturnAnimController2 != null)
			{
				uuiinturnAnimController2.AnimName = eventName;
				uuiinturnAnimController2.Play("", -1, false);
			}
		}

		// Token: 0x06030758 RID: 198488 RVA: 0x00B404DF File Offset: 0x00B3E6DF
		private RegionalTerminalBarGameplayItem CreateGameplayItem()
		{
			return new RegionalTerminalBarGameplayItem();
		}

		// Token: 0x06030759 RID: 198489 RVA: 0x00B404E8 File Offset: 0x00B3E6E8
		private void OnClickButtonFold()
		{
			if (this.AnimState)
			{
				return;
			}
			AreaTerminalOpenLogEvent areaTerminalOpenLogEvent = new AreaTerminalOpenLogEvent();
			areaTerminalOpenLogEvent.i_type = 2;
			LogReportController.Instance.LogReport(areaTerminalOpenLogEvent);
			this.FoldState = true;
			RegionalTerminalModel.Instance.BarFoldState = this.FoldState;
			this.LevelSequencePlayer.StopSequenceByKey("Start", true, false);
			this.AnimState = true;
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
		}

		// Token: 0x0603075A RID: 198490 RVA: 0x00B40560 File Offset: 0x00B3E760
		private void OnClickButtonUnfold()
		{
			if (!this.CanUnfold)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Terminal_Area_UnlockTip", Array.Empty<object>());
				return;
			}
			if (this.AnimState)
			{
				return;
			}
			AreaTerminalOpenLogEvent areaTerminalOpenLogEvent = new AreaTerminalOpenLogEvent();
			areaTerminalOpenLogEvent.i_type = 1;
			LogReportController.Instance.LogReport(areaTerminalOpenLogEvent);
			this.FoldState = false;
			RegionalTerminalModel.Instance.BarFoldState = this.FoldState;
			this.RefreshState();
			this.LevelSequencePlayer.StopSequenceByKey("Close", true, false);
			this.AnimState = true;
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
			List<RegionalTerminalBarGameplayItem> scrollItemList = this.LayoutGameplay.GetScrollItemList();
			if (scrollItemList.Count > 0)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(scrollItemList[0].GetRootItem(), false, false, false);
			}
		}

		// Token: 0x0603075B RID: 198491 RVA: 0x00B4062A File Offset: 0x00B3E82A
		private void OnClickButtonMenu()
		{
			LogReportController.Instance.LogReport(new AreaTerminalOpenSettingsLogEvent());
			RegionalTerminalController.Instance.OpenTerminalOverviewView(0);
		}

		// Token: 0x0603075C RID: 198492 RVA: 0x00B40648 File Offset: 0x00B3E848
		private void RefreshGameplayList()
		{
			this.CurrentDataList = RegionalTerminalModel.Instance.GetGameplayDataList(true);
			this.IsGameplayListShow = (this.CurrentDataList.Count > 0);
			if (this.IsGameplayListShow)
			{
				this.CanUnfold = true;
				this.LayoutGameplay.RefreshByData(this.CurrentDataList, null, false);
			}
			this.HasShowGameplayRedDot = false;
			this.HasTerminalRedDot = false;
			foreach (RegionalTerminalGameplayData regionalTerminalGameplayData in RegionalTerminalModel.Instance.GameplayDataMap.Values)
			{
				if (this.CurrentDataList.Contains(regionalTerminalGameplayData))
				{
					if (regionalTerminalGameplayData.GetRedDotState())
					{
						this.HasShowGameplayRedDot = true;
					}
				}
				else if (regionalTerminalGameplayData.GetShowState())
				{
					this.CanUnfold = true;
					if (regionalTerminalGameplayData.GetRedDotState())
					{
						this.HasTerminalRedDot = true;
						break;
					}
				}
			}
			this.RefreshRedDot();
		}

		// Token: 0x0603075D RID: 198493 RVA: 0x00B40738 File Offset: 0x00B3E938
		private void RefreshState()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(!this.FoldState);
			base.GetButton(5).RootUIComp.Get().SetUIActive(!this.FoldState);
			base.GetButton(7).RootUIComp.Get().SetUIActive(this.FoldState);
			base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(this.IsGameplayListShow && !this.FoldState);
		}

		// Token: 0x0603075E RID: 198494 RVA: 0x00B407D5 File Offset: 0x00B3E9D5
		private void RefreshRedDot()
		{
			base.GetItem(6).SetUIActive(this.HasTerminalRedDot);
			base.GetItem(9).SetUIActive(this.HasShowGameplayRedDot || this.HasTerminalRedDot);
		}

		// Token: 0x0603075F RID: 198495 RVA: 0x00B40807 File Offset: 0x00B3EA07
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x06030760 RID: 198496 RVA: 0x00B40810 File Offset: 0x00B3EA10
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			base.SetUiActive(this.IsAvailableShow());
		}

		// Token: 0x06030761 RID: 198497 RVA: 0x00B4081E File Offset: 0x00B3EA1E
		public bool IsAvailableShow()
		{
			return this.ShowMode == EWorldMapShowMode.Default;
		}

		// Token: 0x06030762 RID: 198498 RVA: 0x00B4082C File Offset: 0x00B3EA2C
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
			if (configParams[0] == "BarItem")
			{
				int num = int.Parse(configParams[1]);
				int i = 0;
				while (i < this.CurrentDataList.Count)
				{
					if (this.CurrentDataList[i].Id == num)
					{
						GenericScrollViewNew<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> layoutGameplay = this.LayoutGameplay;
						UUIItem uuiitem;
						if (layoutGameplay == null)
						{
							uuiitem = null;
						}
						else
						{
							GenericLayout<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> genericLayout = layoutGameplay.GetGenericLayout();
							if (genericLayout == null)
							{
								uuiitem = null;
							}
							else
							{
								RegionalTerminalBarGameplayItem layoutItemByIndex = genericLayout.GetLayoutItemByIndex(i);
								uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetRootItem() : null);
							}
						}
						UUIItem uuiitem2 = uuiitem;
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
						i++;
					}
				}
			}
			return null;
		}

		// Token: 0x0401A091 RID: 106641
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A092 RID: 106642
		private GenericScrollViewNew<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> LayoutGameplay;

		// Token: 0x0401A093 RID: 106643
		private bool HasTerminalRedDot;

		// Token: 0x0401A094 RID: 106644
		private bool HasShowGameplayRedDot;

		// Token: 0x0401A095 RID: 106645
		private bool FoldState;

		// Token: 0x0401A096 RID: 106646
		private bool CanUnfold;

		// Token: 0x0401A097 RID: 106647
		private bool AnimState;

		// Token: 0x0401A098 RID: 106648
		private bool IsGameplayListShow;

		// Token: 0x0401A09A RID: 106650
		private List<RegionalTerminalGameplayData> CurrentDataList = new List<RegionalTerminalGameplayData>();

		// Token: 0x0200AB3A RID: 43834
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04034081 RID: 213121
			public const int ScrollView = 0;

			// Token: 0x04034082 RID: 213122
			public const int GameplayItem = 1;

			// Token: 0x04034083 RID: 213123
			public const int BtnFold = 2;

			// Token: 0x04034084 RID: 213124
			public const int ItemLockBtnFold = 3;

			// Token: 0x04034085 RID: 213125
			public const int RedDotBtnFold = 4;

			// Token: 0x04034086 RID: 213126
			public const int BtnMenu = 5;

			// Token: 0x04034087 RID: 213127
			public const int RedDotBtnMenu = 6;

			// Token: 0x04034088 RID: 213128
			public const int BtnUnfold = 7;

			// Token: 0x04034089 RID: 213129
			public const int ItemLockBtnUnfold = 8;

			// Token: 0x0403408A RID: 213130
			public const int RedDotBtnUnfold = 9;
		}

		// Token: 0x0200AB3B RID: 43835
		[Nullable(0)]
		public static class ESequenceName
		{
			// Token: 0x0403408B RID: 213131
			public const string Start = "Start";

			// Token: 0x0403408C RID: 213132
			public const string Close = "Close";
		}
	}
}
