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
	// Token: 0x02006256 RID: 25174
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSetView : UiViewBase
	{
		// Token: 0x0603F66E RID: 259694 RVA: 0x00F53D27 File Offset: 0x00F51F27
		public RhythmShipSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F66F RID: 259695 RVA: 0x00F53D42 File Offset: 0x00F51F42
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F670 RID: 259696 RVA: 0x00F53D7C File Offset: 0x00F51F7C
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

		// Token: 0x0603F671 RID: 259697 RVA: 0x00F53E09 File Offset: 0x00F52009
		protected override void OnBeforeShow()
		{
			if (this.HaveFirstShow)
			{
				this.HaveFirstShow = false;
				return;
			}
			this.RefreshSliderItem();
		}

		// Token: 0x0603F672 RID: 259698 RVA: 0x00F53E24 File Offset: 0x00F52024
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

		// Token: 0x0603F673 RID: 259699 RVA: 0x00F53E5C File Offset: 0x00F5205C
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

		// Token: 0x0603F674 RID: 259700 RVA: 0x00F53EC0 File Offset: 0x00F520C0
		private void InitScrollViewData()
		{
			this.ScrollDataList = new List<IMultiTemplateGridData>();
			this.AddTitleData("RhythmShipSetTitle_1", ERhythmShipSetDataType.OnlyTitle);
			this.AddItemBtnData("RhythmShipSetItem_1", ERhythmShipSetDataType.ItemBtn, new Action(this.OnSetKeyItemBtnClickCallBack));
			this.AddTitleData("RhythmShipSetTitle_2", ERhythmShipSetDataType.OnlyTitle);
			this.AddItemBtnData("RhythmShipSetItem_2", ERhythmShipSetDataType.ItemBtn, new Action(this.OnSetCalibrationItemBtnClickCallBack));
			this.AddItemSliderData("RhythmShipSetItem_3", ERhythmShipSetDataType.ItemBar, new Action<int>(this.OnCalibrationValueChange));
		}

		// Token: 0x0603F675 RID: 259701 RVA: 0x00F53F38 File Offset: 0x00F52138
		private void AddTitleData(string titleText, ERhythmShipSetDataType type)
		{
			RhythmShipSetTitleData item = new RhythmShipSetTitleData(new RhythmShipSetData
			{
				Text = titleText,
				Type = type
			});
			this.ScrollDataList.Add(item);
		}

		// Token: 0x0603F676 RID: 259702 RVA: 0x00F53F6C File Offset: 0x00F5216C
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

		// Token: 0x0603F677 RID: 259703 RVA: 0x00F53FA8 File Offset: 0x00F521A8
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

		// Token: 0x0603F678 RID: 259704 RVA: 0x00F53FE1 File Offset: 0x00F521E1
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0603F679 RID: 259705 RVA: 0x00F53FE8 File Offset: 0x00F521E8
		private void ToggleCallBack(int index)
		{
			this.RefreshScrollView();
		}

		// Token: 0x0603F67A RID: 259706 RVA: 0x00F53FF0 File Offset: 0x00F521F0
		private CommonTabData GetCommonData(int index)
		{
			CommonTabTitleData titleData = new CommonTabTitleData("RhythmRole_SetView_Title", Array.Empty<object>());
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath("SP_SETanjian"), titleData, null);
		}

		// Token: 0x0603F67B RID: 259707 RVA: 0x00F54023 File Offset: 0x00F52223
		private void OnCalibrationValueChange(int currentCalibrationValue)
		{
			this.CurrentCalibrationValue = currentCalibrationValue;
		}

		// Token: 0x0603F67C RID: 259708 RVA: 0x00F5402C File Offset: 0x00F5222C
		private void OnSetCalibrationItemBtnClickCallBack()
		{
			this.SaveCurrentCalibration();
			UiManager.Instance.OpenView(EUiViewName.RhythmShipCalibrationView, null, null);
		}

		// Token: 0x0603F67D RID: 259709 RVA: 0x00F54048 File Offset: 0x00F52248
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

		// Token: 0x0603F67E RID: 259710 RVA: 0x00F54096 File Offset: 0x00F52296
		protected override void OnBeforeHide()
		{
			this.SaveCurrentCalibration();
		}

		// Token: 0x0603F67F RID: 259711 RVA: 0x00F5409E File Offset: 0x00F5229E
		private void SaveCurrentCalibration()
		{
			RhythmShipModel.Instance.SetLocalCalibrationValue(this.CurrentCalibrationValue);
		}

		// Token: 0x0603F680 RID: 259712 RVA: 0x00F540B0 File Offset: 0x00F522B0
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

		// Token: 0x040211DD RID: 135645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x040211DE RID: 135646
		[Nullable(2)]
		private MultiTemplateScrollView SetMultiTemplateScrollView;

		// Token: 0x040211DF RID: 135647
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x040211E0 RID: 135648
		private int CurrentCalibrationValue;

		// Token: 0x040211E1 RID: 135649
		private bool HaveFirstShow = true;
	}
}
