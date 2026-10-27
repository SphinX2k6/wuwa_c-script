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
	// Token: 0x0200482B RID: 18475
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomMarkPanel : WorldMapSecondaryUiLayoutB
	{
		// Token: 0x060305B4 RID: 198068 RVA: 0x00B39BDD File Offset: 0x00B37DDD
		public override string GetResourceId()
		{
			return "UiItem_CustomMarkPanel_Prefab";
		}

		// Token: 0x060305B5 RID: 198069 RVA: 0x00B39BE4 File Offset: 0x00B37DE4
		protected override void OnStart()
		{
			base.OnStart();
			this.MarkIconOptions = new List<MarkIconOption>();
			this.CreateMarkIconOptions();
		}

		// Token: 0x060305B6 RID: 198070 RVA: 0x00B39C00 File Offset: 0x00B37E00
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

		// Token: 0x060305B7 RID: 198071 RVA: 0x00B39D9C File Offset: 0x00B37F9C
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

		// Token: 0x060305B8 RID: 198072 RVA: 0x00B39E50 File Offset: 0x00B38050
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

		// Token: 0x060305B9 RID: 198073 RVA: 0x00B39F40 File Offset: 0x00B38140
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

		// Token: 0x060305BA RID: 198074 RVA: 0x00B39FD4 File Offset: 0x00B381D4
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

		// Token: 0x060305BB RID: 198075 RVA: 0x00B3A070 File Offset: 0x00B38270
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

		// Token: 0x060305BC RID: 198076 RVA: 0x00B3A0D0 File Offset: 0x00B382D0
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

		// Token: 0x060305BD RID: 198077 RVA: 0x00B3A11C File Offset: 0x00B3831C
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

		// Token: 0x060305BE RID: 198078 RVA: 0x00B3A180 File Offset: 0x00B38380
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

		// Token: 0x060305BF RID: 198079 RVA: 0x00B3A2A8 File Offset: 0x00B384A8
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			base.OnAfterShowWorldMapSecondaryUi();
			EventSystem.Instance.Emit(EEventName.OnMapCustomMarkPanelShow);
		}

		// Token: 0x060305C0 RID: 198080 RVA: 0x00B3A2C0 File Offset: 0x00B384C0
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

		// Token: 0x0401A023 RID: 106531
		private const int CUSTOM_MARK_PANEL_WIDTH = 778;

		// Token: 0x0401A024 RID: 106532
		private const int CUSTOM_MARK_PANEL_HEIGHT = 592;

		// Token: 0x0401A025 RID: 106533
		public static readonly FVector2D PanelSize = new FVector2D(778f, 592f);

		// Token: 0x0401A026 RID: 106534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MarkIconOption> MarkIconOptions;

		// Token: 0x0401A027 RID: 106535
		[Nullable(2)]
		private CustomMarkItem SelectedMarkItem;

		// Token: 0x0401A028 RID: 106536
		private bool TrackState;

		// Token: 0x0401A029 RID: 106537
		private ECustomMarkPanelMode CustomMarkMode;

		// Token: 0x0200AB03 RID: 43779
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033FB1 RID: 212913
			public const int CustomMarkPanel = 0;
		}
	}
}
