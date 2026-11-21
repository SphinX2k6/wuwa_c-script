using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark.Misc;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel
{
	// Token: 0x0200375C RID: 14172
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomMarkPanel : WorldMapSecondaryUiLayoutB
	{
		// Token: 0x06024D84 RID: 150916 RVA: 0x00A69CA9 File Offset: 0x00A67EA9
		public override string GetResourceId()
		{
			return "UiItem_CustomMarkPanel_Prefab";
		}

		// Token: 0x06024D85 RID: 150917 RVA: 0x00A69CB0 File Offset: 0x00A67EB0
		protected override void OnStart()
		{
			base.OnStart();
			this.MarkIconOptions = new List<MarkIconOption>();
			this.CreateMarkIconOptions();
		}

		// Token: 0x06024D86 RID: 150918 RVA: 0x00A69CCC File Offset: 0x00A67ECC
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length >= 2)
			{
				CustomMarkItem customMarkItem = param[0] as CustomMarkItem;
				if (customMarkItem != null)
				{
					object obj = param[1];
					ECustomMarkPanelMode ecustomMarkPanelMode2;
					if (obj is ECustomMarkPanelMode)
					{
						ECustomMarkPanelMode ecustomMarkPanelMode = (ECustomMarkPanelMode)obj;
						ecustomMarkPanelMode2 = ecustomMarkPanelMode;
					}
					else if (obj is int)
					{
						int num = (int)obj;
						ecustomMarkPanelMode2 = (ECustomMarkPanelMode)num;
					}
					else
					{
						ecustomMarkPanelMode2 = ECustomMarkPanelMode.Create;
					}
					ECustomMarkPanelMode ecustomMarkPanelMode3 = ecustomMarkPanelMode2;
					if (this.LayoutContext != null)
					{
						this.LayoutContext.MarkItem = customMarkItem;
					}
					this.CustomMarkMode = ecustomMarkPanelMode3;
					customMarkItem.IsCreated = (ecustomMarkPanelMode3 == ECustomMarkPanelMode.Modify);
					this.SelectedMarkItem = customMarkItem;
					this.LayoutContext.TakeAction = false;
					this.UpdatePanel();
					this.SetSpriteByPath(this.SelectedMarkItem.IconPath, base.GetSprite(0), false, null, null);
					int markCountByType = MapModel.Instance.GetMarkCountByType(EMarkType.Custom);
					UUIText text = base.GetText(3);
					if (text != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(markCountByType);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted<int>(WorldMapModel.Instance.CustomMarkSize);
						text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					}
					UUIItem rootItem = this.RootItem;
					if (rootItem != null)
					{
						rootItem.SetUIActive(true);
					}
					ButtonItem rightConfirmBtn = this.RightConfirmBtn;
					if (rightConfirmBtn != null)
					{
						rightConfirmBtn.SetUiActive(true);
					}
					ButtonItem leftConfirmBtn = this.LeftConfirmBtn;
					if (leftConfirmBtn != null)
					{
						leftConfirmBtn.SetUiActive(true);
					}
					ButtonItem middleCenterBtn = this.MiddleCenterBtn;
					if (middleCenterBtn != null)
					{
						middleCenterBtn.SetUiActive(false);
					}
					this.SelectOptionChecked(customMarkItem);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "CustomeMark", Array.Empty<object>());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "CustomeMarkTip", Array.Empty<object>());
					return;
				}
			}
		}

		// Token: 0x06024D87 RID: 150919 RVA: 0x00A69E68 File Offset: 0x00A68068
		public void SelectOptionChecked(CustomMarkItem selectedMarkItem)
		{
			if (this.MarkIconOptions == null || this.MarkIconOptions.Count == 0)
			{
				return;
			}
			if (this.CustomMarkMode == ECustomMarkPanelMode.Modify)
			{
				foreach (MarkIconOption markIconOption in this.MarkIconOptions)
				{
					CustomMark? customMark;
					if (((markIconOption.Config != null) ? customMark.GetValueOrDefault().MarkPic : null) == selectedMarkItem.IconPath)
					{
						markIconOption.SetToggleChecked();
						return;
					}
				}
			}
			this.MarkIconOptions[0].SetToggleChecked();
		}

		// Token: 0x06024D88 RID: 150920 RVA: 0x00A69F1C File Offset: 0x00A6811C
		private void UpdatePanel()
		{
			ECustomMarkPanelMode customMarkMode = this.CustomMarkMode;
			if (customMarkMode != ECustomMarkPanelMode.Create)
			{
				if (customMarkMode == ECustomMarkPanelMode.Modify)
				{
					MarkItem markItem = MarkUiUtils.FindNearbyValidGotoMark(this.Map, this.SelectedMarkItem);
					ButtonItem rightConfirmBtn = this.RightConfirmBtn;
					if (rightConfirmBtn != null)
					{
						rightConfirmBtn.SetEnableClick(TeleportModel.Instance.AllowTeleportByUi && markItem != null);
					}
					ButtonItem rightConfirmBtn2 = this.RightConfirmBtn;
					if (rightConfirmBtn2 != null)
					{
						rightConfirmBtn2.TrySetLocalTextNew("MapMarkQuickTransfer_Text", Array.Empty<object>());
					}
				}
			}
			else
			{
				string text = ConfigMultiTextLang.GetLocalTextNew("Text_Add_Text", null) ?? "";
				ButtonItem rightConfirmBtn3 = this.RightConfirmBtn;
				if (rightConfirmBtn3 != null)
				{
					rightConfirmBtn3.SetText(text);
				}
				ButtonItem rightConfirmBtn4 = this.RightConfirmBtn;
				if (rightConfirmBtn4 != null)
				{
					rightConfirmBtn4.SetEnableClick(true);
				}
			}
			bool flag = this.CustomMarkMode == ECustomMarkPanelMode.Create;
			base.SetDelBtnActive(!flag);
			ButtonItem leftConfirmBtn = this.LeftConfirmBtn;
			if (leftConfirmBtn != null)
			{
				leftConfirmBtn.SetEnableClick(!flag);
			}
			CustomMarkItem selectedMarkItem = this.SelectedMarkItem;
			this.UpdateTrackButton(selectedMarkItem != null && selectedMarkItem.IsTracked);
		}

		// Token: 0x06024D89 RID: 150921 RVA: 0x00A6A00C File Offset: 0x00A6820C
		protected override void OnRightConfirmBtnClick(int index)
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null && layoutContext.TakeAction)
			{
				return;
			}
			ECustomMarkPanelMode customMarkMode = this.CustomMarkMode;
			if (customMarkMode == ECustomMarkPanelMode.Create)
			{
				MapController.Instance.RequestCreateCustomMark(this.SelectedMarkItem.TrackPosition, this.SelectedMarkItem.ConfigId, null);
				this.LayoutContext.TakeAction = true;
				base.Close();
				return;
			}
			if (customMarkMode != ECustomMarkPanelMode.Modify)
			{
				return;
			}
			MarkItem markItem = MarkUiUtils.FindNearbyValidGotoMark(this.Map, this.SelectedMarkItem);
			if (markItem != null)
			{
				MarkUiUtils.QuickGotoTeleport(this.SelectedMarkItem, markItem, new TOnTelSuccessCallBack(base.Close));
			}
		}

		// Token: 0x06024D8A RID: 150922 RVA: 0x00A6A0A0 File Offset: 0x00A682A0
		protected override void OnLeftConfirmBtnClick(int index)
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null && layoutContext.TakeAction)
			{
				return;
			}
			base.CheckAndShowCrossMapTips(this.SelectedMarkItem);
			MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
			{
				MarkType = this.SelectedMarkItem.MarkType,
				MarkId = this.SelectedMarkItem.MarkId,
				Track = !this.TrackState,
				TrackMode = new ETrackMapMarkMode?(ETrackMapMarkMode.Remote)
			}, null);
			this.LayoutContext.TakeAction = true;
			this.TrackState = !this.TrackState;
			base.Close();
		}

		// Token: 0x06024D8B RID: 150923 RVA: 0x00A6A13C File Offset: 0x00A6833C
		protected override void OnDelBtnClick()
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null && layoutContext.TakeAction)
			{
				return;
			}
			if (this.CustomMarkMode == ECustomMarkPanelMode.Modify)
			{
				MapController.Instance.RequestRemoveMapMarks(EMarkType.Custom, new List<int>
				{
					this.SelectedMarkItem.MarkId
				});
			}
			this.LayoutContext.TakeAction = true;
			base.Close();
		}

		// Token: 0x06024D8C RID: 150924 RVA: 0x00A6A19C File Offset: 0x00A6839C
		private void UpdateTrackButton(bool isTracked)
		{
			this.TrackState = isTracked;
			string text = ConfigMultiTextLang.GetLocalTextNew(this.TrackState ? "Text_InstanceDungeonEntranceCancelTrack_Text" : "Text_InstanceDungeonEntranceTrack_Text", null) ?? "";
			ButtonItem leftConfirmBtn = this.LeftConfirmBtn;
			if (leftConfirmBtn == null)
			{
				return;
			}
			leftConfirmBtn.SetText(text);
		}

		// Token: 0x06024D8D RID: 150925 RVA: 0x00A6A1E8 File Offset: 0x00A683E8
		private void SetConfigId(int configId, EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (!this.SelectedMarkItem.IsNewCustomMarkItem)
			{
				MapController.Instance.RequestMapMarkReplace(this.SelectedMarkItem.MarkId, configId);
			}
			this.SelectedMarkItem.SetConfigId(configId);
			this.SetSpriteByPath(this.SelectedMarkItem.IconPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06024D8E RID: 150926 RVA: 0x00A6A24C File Offset: 0x00A6844C
		private void CreateMarkIconOptions()
		{
			WorldMapConfig instance = WorldMapConfig.Instance;
			IReadOnlyList<CustomMark> readOnlyList = (instance != null) ? instance.GetCustomMarks() : null;
			if (readOnlyList == null)
			{
				return;
			}
			using (IEnumerator<CustomMark> enumerator = readOnlyList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CustomMark configMark = enumerator.Current;
					UUIItem item = LguiUtil.Instance.CopyItem(base.GetItem(6), base.GetItem(4));
					MarkIconOption markIconOption = new MarkIconOption();
					markIconOption.Initialize(item, base.GetItem(4), configMark);
					if (this.CustomMarkMode == ECustomMarkPanelMode.Create && this.MarkIconOptions.Count == 0)
					{
						markIconOption.SetToggleChecked();
					}
					if (this.CustomMarkMode == ECustomMarkPanelMode.Modify)
					{
						CustomMarkItem selectedMarkItem = this.SelectedMarkItem;
						if (((selectedMarkItem != null) ? selectedMarkItem.IconPath : null) == configMark.MarkPic)
						{
							markIconOption.SetToggleChecked();
						}
					}
					markIconOption.SetOnclick(delegate(EToggleState state)
					{
						this.SetConfigId(configMark.MarkId, state);
					});
					this.MarkIconOptions.Add(markIconOption);
				}
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06024D8F RID: 150927 RVA: 0x00A6A374 File Offset: 0x00A68574
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			base.OnAfterShowWorldMapSecondaryUi();
			EventSystem.Instance.Emit(EEventName.OnMapCustomMarkPanelShow);
		}

		// Token: 0x06024D90 RID: 150928 RVA: 0x00A6A38C File Offset: 0x00A6858C
		[NullableContext(2)]
		protected override void OnRefreshPanel(MarkItem param)
		{
			CustomMarkItem customMarkItem = param as CustomMarkItem;
			if (customMarkItem != null)
			{
				this.SelectedMarkItem = customMarkItem;
				if (this.SelectedMarkItem != null)
				{
					this.LayoutContext.MarkItem = this.SelectedMarkItem;
				}
				CustomMarkItem selectedMarkItem = this.SelectedMarkItem;
				this.CustomMarkMode = ((selectedMarkItem != null && selectedMarkItem.IsCreated) ? ECustomMarkPanelMode.Modify : ECustomMarkPanelMode.Create);
				this.UpdatePanel();
			}
		}

		// Token: 0x040146D7 RID: 83671
		private const int CUSTOM_MARK_PANEL_WIDTH = 778;

		// Token: 0x040146D8 RID: 83672
		private const int CUSTOM_MARK_PANEL_HEIGHT = 592;

		// Token: 0x040146D9 RID: 83673
		public static readonly FVector2D PanelSize = new FVector2D(778f, 592f);

		// Token: 0x040146DA RID: 83674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MarkIconOption> MarkIconOptions;

		// Token: 0x040146DB RID: 83675
		[Nullable(2)]
		private CustomMarkItem SelectedMarkItem;

		// Token: 0x040146DC RID: 83676
		private bool TrackState;

		// Token: 0x040146DD RID: 83677
		private ECustomMarkPanelMode CustomMarkMode;

		// Token: 0x020094B2 RID: 38066
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E731 RID: 190257
			public const int CustomMarkPanel = 0;
		}
	}
}
