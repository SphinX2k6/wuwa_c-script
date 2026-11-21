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
	// Token: 0x02003787 RID: 14215
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalBarItem : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x06024F1D RID: 151325 RVA: 0x00A702CE File Offset: 0x00A6E4CE
		// (set) Token: 0x06024F1E RID: 151326 RVA: 0x00A702D6 File Offset: 0x00A6E4D6
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x06024F1F RID: 151327 RVA: 0x00A702E0 File Offset: 0x00A6E4E0
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

		// Token: 0x06024F20 RID: 151328 RVA: 0x00A704D8 File Offset: 0x00A6E6D8
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

		// Token: 0x06024F21 RID: 151329 RVA: 0x00A705CC File Offset: 0x00A6E7CC
		public void BeforeShow()
		{
			this.RefreshGameplayList();
			this.RefreshState();
			EventSystem.Instance.Add<int, bool>(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Add(EEventName.AreaMapGroupIdChanged, new Action(this.OnAreaMapGroupIdChanged));
		}

		// Token: 0x06024F22 RID: 151330 RVA: 0x00A7061D File Offset: 0x00A6E81D
		public void BeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Remove(EEventName.AreaMapGroupIdChanged, new Action(this.OnAreaMapGroupIdChanged));
		}

		// Token: 0x06024F23 RID: 151331 RVA: 0x00A70657 File Offset: 0x00A6E857
		private void OnGameplayPinUpdate(int i, bool b)
		{
			this.RefreshGameplayList();
			this.RefreshState();
		}

		// Token: 0x06024F24 RID: 151332 RVA: 0x00A70668 File Offset: 0x00A6E868
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

		// Token: 0x06024F25 RID: 151333 RVA: 0x00A706C4 File Offset: 0x00A6E8C4
		private void OnSequenceFinishEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.RefreshState();
			}
			this.AnimState = false;
		}

		// Token: 0x06024F26 RID: 151334 RVA: 0x00A706E0 File Offset: 0x00A6E8E0
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

		// Token: 0x06024F27 RID: 151335 RVA: 0x00A70723 File Offset: 0x00A6E923
		private RegionalTerminalBarGameplayItem CreateGameplayItem()
		{
			return new RegionalTerminalBarGameplayItem();
		}

		// Token: 0x06024F28 RID: 151336 RVA: 0x00A7072C File Offset: 0x00A6E92C
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

		// Token: 0x06024F29 RID: 151337 RVA: 0x00A707A4 File Offset: 0x00A6E9A4
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

		// Token: 0x06024F2A RID: 151338 RVA: 0x00A7086E File Offset: 0x00A6EA6E
		private void OnClickButtonMenu()
		{
			LogReportController.Instance.LogReport(new AreaTerminalOpenSettingsLogEvent());
			RegionalTerminalController.Instance.OpenTerminalOverviewView(0);
		}

		// Token: 0x06024F2B RID: 151339 RVA: 0x00A7088C File Offset: 0x00A6EA8C
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

		// Token: 0x06024F2C RID: 151340 RVA: 0x00A7097C File Offset: 0x00A6EB7C
		private void RefreshState()
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(!this.FoldState);
			base.GetButton(5).RootUIComp.Get().SetUIActive(!this.FoldState);
			base.GetButton(7).RootUIComp.Get().SetUIActive(this.FoldState);
			base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(this.IsGameplayListShow && !this.FoldState);
		}

		// Token: 0x06024F2D RID: 151341 RVA: 0x00A70A19 File Offset: 0x00A6EC19
		private void RefreshRedDot()
		{
			base.GetItem(6).SetUIActive(this.HasTerminalRedDot);
			base.GetItem(9).SetUIActive(this.HasShowGameplayRedDot || this.HasTerminalRedDot);
		}

		// Token: 0x06024F2E RID: 151342 RVA: 0x00A70A4B File Offset: 0x00A6EC4B
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x06024F2F RID: 151343 RVA: 0x00A70A54 File Offset: 0x00A6EC54
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			base.SetUiActive(this.IsAvailableShow());
		}

		// Token: 0x06024F30 RID: 151344 RVA: 0x00A70A62 File Offset: 0x00A6EC62
		public bool IsAvailableShow()
		{
			return this.ShowMode == EWorldMapShowMode.Default;
		}

		// Token: 0x06024F31 RID: 151345 RVA: 0x00A70A70 File Offset: 0x00A6EC70
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

		// Token: 0x04014745 RID: 83781
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04014746 RID: 83782
		private GenericScrollViewNew<RegionalTerminalBarGameplayItem, RegionalTerminalGameplayData> LayoutGameplay;

		// Token: 0x04014747 RID: 83783
		private bool HasTerminalRedDot;

		// Token: 0x04014748 RID: 83784
		private bool HasShowGameplayRedDot;

		// Token: 0x04014749 RID: 83785
		private bool FoldState;

		// Token: 0x0401474A RID: 83786
		private bool CanUnfold;

		// Token: 0x0401474B RID: 83787
		private bool AnimState;

		// Token: 0x0401474C RID: 83788
		private bool IsGameplayListShow;

		// Token: 0x0401474E RID: 83790
		private List<RegionalTerminalGameplayData> CurrentDataList = new List<RegionalTerminalGameplayData>();

		// Token: 0x020094E8 RID: 38120
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E7F9 RID: 190457
			public const int ScrollView = 0;

			// Token: 0x0402E7FA RID: 190458
			public const int GameplayItem = 1;

			// Token: 0x0402E7FB RID: 190459
			public const int BtnFold = 2;

			// Token: 0x0402E7FC RID: 190460
			public const int ItemLockBtnFold = 3;

			// Token: 0x0402E7FD RID: 190461
			public const int RedDotBtnFold = 4;

			// Token: 0x0402E7FE RID: 190462
			public const int BtnMenu = 5;

			// Token: 0x0402E7FF RID: 190463
			public const int RedDotBtnMenu = 6;

			// Token: 0x0402E800 RID: 190464
			public const int BtnUnfold = 7;

			// Token: 0x0402E801 RID: 190465
			public const int ItemLockBtnUnfold = 8;

			// Token: 0x0402E802 RID: 190466
			public const int RedDotBtnUnfold = 9;
		}

		// Token: 0x020094E9 RID: 38121
		[Nullable(0)]
		public static class ESequenceName
		{
			// Token: 0x0402E803 RID: 190467
			public const string Start = "Start";

			// Token: 0x0402E804 RID: 190468
			public const string Close = "Close";
		}
	}
}
