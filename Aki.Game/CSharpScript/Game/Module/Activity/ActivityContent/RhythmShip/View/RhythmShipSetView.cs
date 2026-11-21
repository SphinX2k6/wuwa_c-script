using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051D4 RID: 20948
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSetView : UiViewBase
	{
		// Token: 0x0603432F RID: 213807 RVA: 0x00E9AC83 File Offset: 0x00E98E83
		public RhythmShipSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034330 RID: 213808 RVA: 0x00E9AC9E File Offset: 0x00E98E9E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06034331 RID: 213809 RVA: 0x00E9ACD8 File Offset: 0x00E98ED8
		protected override void OnStart()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(1), data, delegate()
			{
				base.CloseMe(null);
			}, false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.SetMultiTemplateScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(0));
			this.TabComponent.RefreshTabItemByLength(1, delegate
			{
				TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
				if (tabComponent == null)
				{
					return;
				}
				tabComponent.SelectToggleByIndex(0, false);
			});
		}

		// Token: 0x06034332 RID: 213810 RVA: 0x00E9AD65 File Offset: 0x00E98F65
		protected override void OnBeforeShow()
		{
			if (this.HaveFirstShow)
			{
				this.HaveFirstShow = false;
				return;
			}
			this.RefreshSliderItem();
		}

		// Token: 0x06034333 RID: 213811 RVA: 0x00E9AD80 File Offset: 0x00E98F80
		private void RefreshScrollView()
		{
			this.InitScrollViewData();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			MultiTemplateScrollView setMultiTemplateScrollView = this.SetMultiTemplateScrollView;
			if (setMultiTemplateScrollView == null)
			{
				return;
			}
			setMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x06034334 RID: 213812 RVA: 0x00E9ADB8 File Offset: 0x00E98FB8
		private void RefreshSliderItem()
		{
			int num = this.ScrollDataList.FindIndex((IMultiTemplateGridData data) => (data.Data as RhythmShipSetData).Type == ERhythmShipSetDataType.ItemBar);
			MultiTemplateScrollView setMultiTemplateScrollView = this.SetMultiTemplateScrollView;
			if (setMultiTemplateScrollView == null)
			{
				return;
			}
			ISyncGridProxy proxyByGridIndex = setMultiTemplateScrollView.GetProxyByGridIndex(num);
			if (proxyByGridIndex == null)
			{
				return;
			}
			proxyByGridIndex.Refresh(this.ScrollDataList[num].Data);
		}

		// Token: 0x06034335 RID: 213813 RVA: 0x00E9AE1C File Offset: 0x00E9901C
		private void InitScrollViewData()
		{
			this.ScrollDataList = new List<IMultiTemplateGridData>();
			this.AddTitleData("RhythmShipSetTitle_1", ERhythmShipSetDataType.OnlyTitle);
			this.AddItemBtnData("RhythmShipSetItem_1", ERhythmShipSetDataType.ItemBtn, new Action(this.OnSetKeyItemBtnClickCallBack));
			this.AddTitleData("RhythmShipSetTitle_2", ERhythmShipSetDataType.OnlyTitle);
			this.AddItemBtnData("RhythmShipSetItem_2", ERhythmShipSetDataType.ItemBtn, new Action(this.OnSetCalibrationItemBtnClickCallBack));
			this.AddItemSliderData("RhythmShipSetItem_3", ERhythmShipSetDataType.ItemBar, new Action<int>(this.OnCalibrationValueChange));
		}

		// Token: 0x06034336 RID: 213814 RVA: 0x00E9AE94 File Offset: 0x00E99094
		private void AddTitleData(string titleText, ERhythmShipSetDataType type)
		{
			RhythmShipSetTitleData item = new RhythmShipSetTitleData(new RhythmShipSetData
			{
				Text = titleText,
				Type = type
			});
			this.ScrollDataList.Add(item);
		}

		// Token: 0x06034337 RID: 213815 RVA: 0x00E9AEC8 File Offset: 0x00E990C8
		private void AddItemBtnData(string text, ERhythmShipSetDataType type, Action callBack)
		{
			RhythmShipSetItemBtnData item = new RhythmShipSetItemBtnData(new RhythmShipSetData
			{
				Text = text,
				Type = type,
				BtnCallBack = callBack
			});
			this.ScrollDataList.Add(item);
		}

		// Token: 0x06034338 RID: 213816 RVA: 0x00E9AF04 File Offset: 0x00E99104
		private void AddItemSliderData(string text, ERhythmShipSetDataType type, Action<int> barValueChange)
		{
			RhythmShipSetItemSliderData rhythmShipSetItemSliderData = new RhythmShipSetItemSliderData(new RhythmShipSetData
			{
				Text = text,
				Type = type
			});
			rhythmShipSetItemSliderData.OnSliderValueChangeCallBack = barValueChange;
			this.ScrollDataList.Add(rhythmShipSetItemSliderData);
		}

		// Token: 0x06034339 RID: 213817 RVA: 0x00E9AF3D File Offset: 0x00E9913D
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0603433A RID: 213818 RVA: 0x00E9AF44 File Offset: 0x00E99144
		private void ToggleCallBack(int index)
		{
			this.RefreshScrollView();
		}

		// Token: 0x0603433B RID: 213819 RVA: 0x00E9AF4C File Offset: 0x00E9914C
		private CommonTabData GetCommonData(int index)
		{
			CommonTabTitleData titleData = new CommonTabTitleData("RhythmRole_SetView_Title", Array.Empty<object>());
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath("SP_SETanjian"), titleData, null);
		}

		// Token: 0x0603433C RID: 213820 RVA: 0x00E9AF7F File Offset: 0x00E9917F
		private void OnCalibrationValueChange(int currentCalibrationValue)
		{
			this.CurrentCalibrationValue = currentCalibrationValue;
		}

		// Token: 0x0603433D RID: 213821 RVA: 0x00E9AF88 File Offset: 0x00E99188
		private void OnSetCalibrationItemBtnClickCallBack()
		{
			this.SaveCurrentCalibration();
			UiManager.Instance.OpenView(EUiViewName.RhythmShipCalibrationView, null, null);
		}

		// Token: 0x0603433E RID: 213822 RVA: 0x00E9AFA4 File Offset: 0x00E991A4
		private void OnSetKeyItemBtnClickCallBack()
		{
			if (Info.Instance.IsInTouch())
			{
				TouchUiEditController.Instance.OpenCommonTouchUiEditView(4);
				return;
			}
			CommonKeySettingViewOpenData param = new CommonKeySettingViewOpenData
			{
				ViewType = EKeySettingExclusiveType.RhythmShip,
				BgSourceId = "T_RhythmShipLevelBg"
			};
			UiManager.Instance.OpenView(EUiViewName.CommonKeySettingView, param, null);
		}

		// Token: 0x0603433F RID: 213823 RVA: 0x00E9AFF2 File Offset: 0x00E991F2
		protected override void OnBeforeHide()
		{
			this.SaveCurrentCalibration();
		}

		// Token: 0x06034340 RID: 213824 RVA: 0x00E9AFFA File Offset: 0x00E991FA
		private void SaveCurrentCalibration()
		{
			RhythmShipModel.Instance.SetLocalCalibrationValue(this.CurrentCalibrationValue);
		}

		// Token: 0x06034341 RID: 213825 RVA: 0x00E9B00C File Offset: 0x00E9920C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			string text = configParams[0];
			if (text == "Tab")
			{
				int index = int.Parse(configParams[1]);
				TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
				UUIItem uuiitem;
				if (tabComponent == null)
				{
					uuiitem = null;
				}
				else
				{
					CommonTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(index);
					uuiitem = ((tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null);
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
				if (!text.Contains("Btn"))
				{
					return null;
				}
				int gridIndex = int.Parse(configParams[1]);
				RhythmShipSetItemBtn rhythmShipSetItemBtn = this.SetMultiTemplateScrollView.GetProxyByGridIndex(gridIndex) as RhythmShipSetItemBtn;
				if (rhythmShipSetItemBtn == null)
				{
					return null;
				}
				UUIItem btnItem = rhythmShipSetItemBtn.GetBtnItem();
				if (text == "Btn")
				{
					if (btnItem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						btnItem,
						btnItem
					};
				}
				else
				{
					UUIItem navigationItem = rhythmShipSetItemBtn.GetNavigationItem();
					if (btnItem == null || navigationItem == null)
					{
						return null;
					}
					return new UUIItem[]
					{
						btnItem,
						navigationItem
					};
				}
			}
		}

		// Token: 0x0401BB0C RID: 113420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401BB0D RID: 113421
		[Nullable(2)]
		private MultiTemplateScrollView SetMultiTemplateScrollView;

		// Token: 0x0401BB0E RID: 113422
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BB0F RID: 113423
		private int CurrentCalibrationValue;

		// Token: 0x0401BB10 RID: 113424
		private bool HaveFirstShow = true;
	}
}
