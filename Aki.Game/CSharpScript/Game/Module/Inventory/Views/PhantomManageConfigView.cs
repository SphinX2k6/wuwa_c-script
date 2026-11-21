using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Inventory.Views
{
	// Token: 0x0200480F RID: 18447
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigView : UiTabViewBase
	{
		// Token: 0x0602E559 RID: 189785 RVA: 0x00CED3A8 File Offset: 0x00CEB5A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUITexture)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickedBtnRename)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickedBtnDelete)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickedBtnQuitEdit)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnClickedBtnRecommend))
			};
		}

		// Token: 0x0602E55A RID: 189786 RVA: 0x00CED580 File Offset: 0x00CEB780
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomManageConfigView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManageConfigView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E55B RID: 189787 RVA: 0x00CED5C4 File Offset: 0x00CEB7C4
		protected override void OnStart()
		{
			this.ViewModel = new PhantomManageConfigViewModel();
			this.ViewModel.Bind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
			this.LayoutType = new GenericLayout<PhantomManageConfigTypeItem, InventoryDefine.IManageConfigTypeItemData>(base.GetHorizontalLayout(0), new Func<PhantomManageConfigTypeItem>(this.CreateTypeItem), null, false, true);
			PhantomManageConfigTypeItem.ViewModel = this.ViewModel;
			this.ScrollConfig = new LoopScrollView<PhantomManageConfigItem, PhantomManageConfigData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PhantomManageConfigItem>(this.CreateConfigItem), false);
			PhantomManageConfigItem.CallbackBtnSelect = new Action<PhantomManageConfigData>(this.OnClickedBtnConfig);
			PhantomManageConfigItem.ViewModel = this.ViewModel;
			this.ScrollSetting = new GenericScrollViewNew<PhantomManageSettingTitleItem, InventoryDefine.IManageConfigTitleItemData>(base.GetScrollViewWithScrollbar(7), new Func<PhantomManageSettingTitleItem>(this.CreateSettingTitleItem), null, true, null);
			PhantomManageSettingTitleItem.ViewModel = this.ViewModel;
			this.InturnAniConfig = this.ScrollConfig.GetUiAnimController();
			this.InturnAniSetting = (base.GetScrollViewWithScrollbar(7).GetContent().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
			this.ViewModel.SetSelectType(PhantomSettingType.AutoLock, false);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnPlayingStartSequenceAsync), false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.AddSequenceFinishEvent("UnSelect", delegate(string _)
			{
				if (!this.ViewModel.GetEditState())
				{
					base.GetItem(3).SetUIActive(false);
				}
			}, false);
		}

		// Token: 0x0602E55C RID: 189788 RVA: 0x00CED720 File Offset: 0x00CEB920
		protected void OnPlayingStartSequenceAsync(string _)
		{
			UUIInturnAnimController inturnAniConfig = this.InturnAniConfig;
			if (inturnAniConfig != null)
			{
				inturnAniConfig.Play("", -1, false);
			}
			UUIInturnAnimController inturnAniSetting = this.InturnAniSetting;
			if (inturnAniSetting == null)
			{
				return;
			}
			inturnAniSetting.Play("", -1, false);
		}

		// Token: 0x0602E55D RID: 189789 RVA: 0x00CED751 File Offset: 0x00CEB951
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x0602E55E RID: 189790 RVA: 0x00CED76C File Offset: 0x00CEB96C
		private void OnViewModelUpdate(EPhantomManageConfigViewData data)
		{
			if (data == EPhantomManageConfigViewData.SelectType)
			{
				this.RefreshType();
				PhantomSettingType selectType = this.ViewModel.GetSelectType();
				int selectIndex = this.ViewModel.GetSelectIndex(selectType);
				PhantomManageConfigData phantomManageConfigByTypeAndIndex = InventoryModel.Instance.GetPhantomManageConfigByTypeAndIndex(selectType, selectIndex);
				this.SelectConfig(true, phantomManageConfigByTypeAndIndex);
				return;
			}
			if (data == EPhantomManageConfigViewData.SelectConfig)
			{
				this.RefreshConfig();
				this.RefreshTitle();
				this.RefreshSetting();
				return;
			}
			if (data == EPhantomManageConfigViewData.EditState)
			{
				this.RefreshMask();
				this.RefreshRecommendBtnState();
				this.RefreshButtons();
				this.RefreshEditData();
				this.RefreshSetting();
				this.RefreshConfig();
				if (!this.ViewModel.GetEditState())
				{
					this.RefreshTitle();
					return;
				}
			}
			else if (data == EPhantomManageConfigViewData.EditSwitch)
			{
				this.RefreshTitle();
			}
		}

		// Token: 0x0602E55F RID: 189791 RVA: 0x00CED810 File Offset: 0x00CEBA10
		private void RefreshType()
		{
			List<InventoryDefine.IManageConfigTypeItemData> list = new List<InventoryDefine.IManageConfigTypeItemData>();
			InventoryDefine.ManageConfigTypeItemData item = new InventoryDefine.ManageConfigTypeItemData
			{
				Type = PhantomSettingType.AutoLock,
				Name = "PhantomProject_LockProject"
			};
			InventoryDefine.ManageConfigTypeItemData item2 = new InventoryDefine.ManageConfigTypeItemData
			{
				Type = PhantomSettingType.AutoDisuse,
				Name = "PhantomProject_DiscardProject"
			};
			list.Add(item);
			list.Add(item2);
			this.LayoutType.RefreshByData(list, null, false);
		}

		// Token: 0x0602E560 RID: 189792 RVA: 0x00CED870 File Offset: 0x00CEBA70
		private UniTask RefreshConfig()
		{
			PhantomManageConfigView.<RefreshConfig>d__19 <RefreshConfig>d__;
			<RefreshConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshConfig>d__.<>4__this = this;
			<RefreshConfig>d__.<>1__state = -1;
			<RefreshConfig>d__.<>t__builder.Start<PhantomManageConfigView.<RefreshConfig>d__19>(ref <RefreshConfig>d__);
			return <RefreshConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0602E561 RID: 189793 RVA: 0x00CED8B4 File Offset: 0x00CEBAB4
		private void RefreshTitle()
		{
			PhantomSettingType selectType = this.ViewModel.GetSelectType();
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			this.BtnSwitch.SetConfigType(selectType);
			bool flag = this.ViewModel.GetEditState() ? this.ViewModel.GetEditSwitch() : selectConfig.GetIsOn();
			this.BtnSwitch.SetConfigState(flag);
			UUITexture texture = base.GetTexture(12);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetText(4).SetText(selectConfig.GetName(), true);
		}

		// Token: 0x0602E562 RID: 189794 RVA: 0x00CED944 File Offset: 0x00CEBB44
		private void RefreshSetting()
		{
			List<InventoryDefine.IManageConfigTitleItemData> settingTitleItemDataList = InventoryModel.Instance.GetSettingTitleItemDataList();
			this.ScrollSetting.RefreshByDataAsync(settingTitleItemDataList, false);
		}

		// Token: 0x0602E563 RID: 189795 RVA: 0x00CED96C File Offset: 0x00CEBB6C
		private void RefreshButtons()
		{
			string textId = this.ViewModel.GetEditState() ? "PhantomProject_SaveButton02" : "PhantomProject_EditButton";
			this.BtnEdit.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x0602E564 RID: 189796 RVA: 0x00CED9A4 File Offset: 0x00CEBBA4
		private void RefreshMask()
		{
			bool editState = this.ViewModel.GetEditState();
			if (editState)
			{
				base.GetItem(3).SetUIActive(true);
			}
			base.SetButtonUiActive(13, editState);
			string sequenceName = editState ? "Select" : "UnSelect";
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence(sequenceName, false, null);
		}

		// Token: 0x0602E565 RID: 189797 RVA: 0x00CEDA04 File Offset: 0x00CEBC04
		private void RefreshRecommendBtnState()
		{
			bool editState = this.ViewModel.GetEditState();
			base.SetButtonUiActive(14, !editState);
		}

		// Token: 0x0602E566 RID: 189798 RVA: 0x00CEDA2C File Offset: 0x00CEBC2C
		private void RefreshEditData()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			if (this.ViewModel.GetEditState())
			{
				this.ViewModel.InitEditDataSwitch(selectConfig, false);
			}
		}

		// Token: 0x0602E567 RID: 189799 RVA: 0x00CEDA60 File Offset: 0x00CEBC60
		[NullableContext(2)]
		private void SelectConfig(bool enableScroll, PhantomManageConfigData data = null)
		{
			PhantomSettingType selectType = this.ViewModel.GetSelectType();
			if (data != null)
			{
				this.ViewModel.SetSelectConfig(data, false);
				this.ViewModel.SetSelectIndex(selectType, data.GetIndex(), false);
			}
			else
			{
				List<PhantomManageConfigData> phantomManageConfigByType = InventoryModel.Instance.GetPhantomManageConfigByType(selectType);
				this.ViewModel.SetSelectConfig(phantomManageConfigByType[0], false);
				this.ViewModel.SetSelectIndex(selectType, 0, false);
			}
			this.EnableConfigScroll = enableScroll;
		}

		// Token: 0x0602E568 RID: 189800 RVA: 0x00CEDAD4 File Offset: 0x00CEBCD4
		private void OnClickedBtnConfig(PhantomManageConfigData data)
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			if (selectConfig.GetIndex() == data.GetIndex() && data.GetType() == selectConfig.GetType())
			{
				return;
			}
			this.IsChangeByClick = true;
			this.SelectConfig(false, data);
		}

		// Token: 0x0602E569 RID: 189801 RVA: 0x00CEDB1C File Offset: 0x00CEBD1C
		private void OnClickedBtnRename()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			CommonInputViewController.Instance.OpenSetPhantomManageConfigName(selectConfig.GetName(), new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRename), "");
		}

		// Token: 0x0602E56A RID: 189802 RVA: 0x00CEDB56 File Offset: 0x00CEBD56
		private void OnClickedBtnDelete()
		{
			if (this.ViewModel.GetEditState())
			{
				this.OnEditDelete();
				return;
			}
			this.OnDelete();
		}

		// Token: 0x0602E56B RID: 189803 RVA: 0x00CEDB74 File Offset: 0x00CEBD74
		private void OnEditDelete()
		{
			PhantomManageConfigData config = this.ViewModel.GetSelectConfig();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomManageConfigEditReset);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				config.Reset(false, false);
				this.ViewModel.InitEditDataSwitch(config, false);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E56C RID: 189804 RVA: 0x00CEDBD0 File Offset: 0x00CEBDD0
		private void OnDelete()
		{
			PhantomSettingType type = this.ViewModel.GetSelectType();
			PhantomManageConfigData config = this.ViewModel.GetSelectConfig();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomManageConfigReset);
			Action<bool> <>9__1;
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				PhantomManageConfigData config;
				config.Reset(false, true);
				PhantomManageConfigView <>4__this = this;
				PhantomSettingType type = type;
				config = config;
				bool? forceOn = new bool?(false);
				Action<bool> callback;
				if ((callback = <>9__1) == null)
				{
					callback = (<>9__1 = delegate(bool result)
					{
						this.OnSaveSuccess(result, null);
					});
				}
				<>4__this.RequestSaveDataAsync(type, config, forceOn, callback);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E56D RID: 189805 RVA: 0x00CEDC3C File Offset: 0x00CEBE3C
		private bool OnCheckToggleCanChange(EToggleState state)
		{
			bool editState = this.ViewModel.GetEditState();
			bool flag = this.ViewModel.GetSelectConfig().IsEmpty();
			if (editState)
			{
				Dictionary<int, int[]> editData = this.ViewModel.GetEditData();
				flag = this.CheckIsEmptyData(editData);
			}
			if (state == EToggleState.ETT_UnChecked && flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Tips02", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0602E56E RID: 189806 RVA: 0x00CEDC9C File Offset: 0x00CEBE9C
		private void OnClickedToggleSwitch(EToggleState state)
		{
			if (this.ViewModel.GetEditState())
			{
				Dictionary<int, int[]> editData = this.ViewModel.GetEditData();
				if (state == EToggleState.ETT_Checked && this.CheckIsEmptyData(editData))
				{
					this.SetToggleSwitchEmpty();
					return;
				}
				bool isOn = state == EToggleState.ETT_Checked;
				this.ViewModel.SetEditSwitch(isOn, false);
				return;
			}
			else
			{
				PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
				if (state == EToggleState.ETT_Checked && selectConfig.IsEmpty())
				{
					this.SetToggleSwitchEmpty();
					return;
				}
				this.OnConfirmSwitch(state);
				return;
			}
		}

		// Token: 0x0602E56F RID: 189807 RVA: 0x00CEDD10 File Offset: 0x00CEBF10
		private void SetToggleSwitchEmpty()
		{
			this.BtnSwitch.SetConfigState(false);
			UUITexture texture = base.GetTexture(12);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = false;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Tips02", Array.Empty<object>());
		}

		// Token: 0x0602E570 RID: 189808 RVA: 0x00CEDD5B File Offset: 0x00CEBF5B
		private void OnClickedBtnEdit(int _)
		{
			if (this.ViewModel.GetEditState())
			{
				this.TrySaveEditData();
				return;
			}
			this.ViewModel.SetEditState(true, false);
		}

		// Token: 0x0602E571 RID: 189809 RVA: 0x00CEDD80 File Offset: 0x00CEBF80
		private void TrySaveEditData()
		{
			bool editIsOn = this.ViewModel.GetEditSwitch();
			Dictionary<int, int[]> editData = this.ViewModel.GetEditData();
			PhantomSettingType type = this.ViewModel.GetSelectType();
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			bool flag = this.CheckIsEmptyData(editData);
			<>f__AnonymousDelegate6<bool, bool?> callbackSave = new <>f__AnonymousDelegate6<bool, bool?>(this.OnSaveSuccess);
			PhantomManageConfigData newConfig = selectConfig.Clone();
			newConfig.SetRuleIdMapValueList(editData);
			if (flag)
			{
				this.RequestSaveDataAsync(type, newConfig, new bool?(false), delegate(bool result)
				{
					callbackSave(result, null);
				});
				return;
			}
			if (!flag & editIsOn)
			{
				this.RequestSaveDataAsync(type, newConfig, new bool?(editIsOn), delegate(bool result)
				{
					callbackSave(result, null);
				});
			}
			if (!flag && !editIsOn)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomManageConfigSaveOn);
				Action<bool> <>9__4;
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					PhantomManageConfigView <>4__this = this;
					PhantomSettingType type = type;
					PhantomManageConfigData newConfig = newConfig;
					bool? forceOn = new bool?(true);
					Action<bool> callback;
					if ((callback = <>9__4) == null)
					{
						callback = (<>9__4 = delegate(bool result)
						{
							callbackSave(result, null);
						});
					}
					<>4__this.RequestSaveDataAsync(type, newConfig, forceOn, callback);
				});
				Action<bool> <>9__5;
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
					PhantomManageConfigView <>4__this = this;
					PhantomSettingType type = type;
					PhantomManageConfigData newConfig = newConfig;
					bool? forceOn = new bool?(editIsOn);
					Action<bool> callback;
					if ((callback = <>9__5) == null)
					{
						callback = (<>9__5 = delegate(bool result)
						{
							callbackSave(result, null);
						});
					}
					<>4__this.RequestSaveDataAsync(type, newConfig, forceOn, callback);
				});
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x0602E572 RID: 189810 RVA: 0x00CEDEC4 File Offset: 0x00CEC0C4
		private UniTask RequestSaveDataAsync(PhantomSettingType type, PhantomManageConfigData config, bool? forceOn = null, [Nullable(2)] Action<bool> callback = null)
		{
			PhantomManageConfigView.<RequestSaveDataAsync>d__37 <RequestSaveDataAsync>d__;
			<RequestSaveDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestSaveDataAsync>d__.type = type;
			<RequestSaveDataAsync>d__.config = config;
			<RequestSaveDataAsync>d__.forceOn = forceOn;
			<RequestSaveDataAsync>d__.callback = callback;
			<RequestSaveDataAsync>d__.<>1__state = -1;
			<RequestSaveDataAsync>d__.<>t__builder.Start<PhantomManageConfigView.<RequestSaveDataAsync>d__37>(ref <RequestSaveDataAsync>d__);
			return <RequestSaveDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E573 RID: 189811 RVA: 0x00CEDF20 File Offset: 0x00CEC120
		private void OnSaveSuccess(bool success, bool? goCheck = null)
		{
			if (success)
			{
				this.ViewModel.SetEditState(false, false);
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Warning11", Array.Empty<object>());
				if (goCheck.GetValueOrDefault())
				{
					this.OpenManageView();
				}
			}
		}

		// Token: 0x0602E574 RID: 189812 RVA: 0x00CEDF58 File Offset: 0x00CEC158
		private bool CheckIsEmptyData(Dictionary<int, int[]> dataList)
		{
			using (Dictionary<int, int[]>.ValueCollection.Enumerator enumerator = dataList.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Length != 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0602E575 RID: 189813 RVA: 0x00CEDFB0 File Offset: 0x00CEC1B0
		private Dictionary<FilterDefine.EFilterType, List<int>> ConvertFilterConfigForSave()
		{
			bool editState = this.ViewModel.GetEditState();
			Dictionary<FilterDefine.EFilterType, List<int>> dictionary = new Dictionary<FilterDefine.EFilterType, List<int>>();
			Dictionary<int, int[]> dictionary2 = this.ViewModel.GetSelectConfig().GetRuleIdMapValueList();
			if (editState)
			{
				dictionary2 = this.ViewModel.GetEditData();
			}
			foreach (KeyValuePair<int, int[]> keyValuePair in dictionary2)
			{
				int filterType = FilterConfig.Instance.GetFilterRuleConfig(keyValuePair.Key).Value.FilterType;
				dictionary.Add((FilterDefine.EFilterType)filterType, new List<int>(keyValuePair.Value));
			}
			return dictionary;
		}

		// Token: 0x0602E576 RID: 189814 RVA: 0x00CEE064 File Offset: 0x00CEC264
		private void OnClickedBtnPreview(int _)
		{
			if (this.ViewModel.GetEditState())
			{
				this.OnEditPreview();
				return;
			}
			this.OnPreview();
		}

		// Token: 0x0602E577 RID: 189815 RVA: 0x00CEE080 File Offset: 0x00CEC280
		private void OnEditPreview()
		{
			Dictionary<int, int[]> editData = this.ViewModel.GetEditData();
			if (this.CheckIsEmptyData(editData))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Tips02", Array.Empty<object>());
				return;
			}
			this.SaveFilterConfigData();
			this.OpenManageView();
		}

		// Token: 0x0602E578 RID: 189816 RVA: 0x00CEE0C4 File Offset: 0x00CEC2C4
		private void OnPreview()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			if (this.CheckIsEmptyData(selectConfig.GetRuleIdMapValueList()))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Tips02", Array.Empty<object>());
				return;
			}
			this.SaveFilterConfigData();
			this.OpenManageView();
		}

		// Token: 0x0602E579 RID: 189817 RVA: 0x00CEE10C File Offset: 0x00CEC30C
		private void SaveFilterConfigData()
		{
			int filterIdConst = InventoryModel.Instance.GetFilterIdConst();
			FilterStorageData data = new FilterStorageData
			{
				ConfigId = filterIdConst,
				SelectRuleMap = this.ConvertFilterConfigForSave()
			};
			FilterModel.Instance.SetFilterConfigData(EFilterSortConfigId.PhantomManage, 43, data, "");
		}

		// Token: 0x0602E57A RID: 189818 RVA: 0x00CEE150 File Offset: 0x00CEC350
		private void QuitEditState()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			this.ViewModel.InitEditDataSwitch(selectConfig, true);
			this.ViewModel.SetEditState(false, false);
		}

		// Token: 0x0602E57B RID: 189819 RVA: 0x00CEE184 File Offset: 0x00CEC384
		private void OpenManageView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageView) || UiManager.Instance.IsViewHide(EUiViewName.PhantomManageView))
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomManageView, new Action<bool>(this.OnCloseManageView));
				return;
			}
			this.OnCloseManageView(true);
		}

		// Token: 0x0602E57C RID: 189820 RVA: 0x00CEE1D6 File Offset: 0x00CEC3D6
		private void OnCloseManageView(bool success)
		{
			if (success)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomManageView, null, null);
			}
		}

		// Token: 0x0602E57D RID: 189821 RVA: 0x00CEE1EC File Offset: 0x00CEC3EC
		private void OnClickedBtnQuitEdit()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			Dictionary<int, int[]> editData = this.ViewModel.GetEditData();
			bool editSwitch = this.ViewModel.GetEditSwitch();
			if (selectConfig.IsEqual(editSwitch, editData))
			{
				this.QuitEditState();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomManageConfigQuitEdit);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.QuitEditState));
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E57E RID: 189822 RVA: 0x00CEE264 File Offset: 0x00CEC464
		private void OnClickedBtnRecommend()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.UsePhantomManagePlanConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				IEnumerable<PhantomManagePlanConfig> configList = ConfigPhantomManagePlanConfigAll.GetConfigList(true);
				List<PhantomSettingInfo> list = new List<PhantomSettingInfo>();
				foreach (PhantomManagePlanConfig phantomManagePlanConfig in configList)
				{
					PhantomSettingInfo phantomSettingInfo = PhantomSettingInfo.Create();
					phantomSettingInfo.SettingType = (PhantomSettingType)phantomManagePlanConfig.Type;
					List<OneItemFilterRule> list2 = new List<OneItemFilterRule>();
					foreach (KeyValuePair<int, IntArray> keyValuePair in phantomManagePlanConfig.RuleMap())
					{
						OneItemFilterRule oneItemFilterRule = OneItemFilterRule.Create();
						oneItemFilterRule.FilterRuleId = keyValuePair.Key;
						oneItemFilterRule.IdList.AddRange(keyValuePair.Value.GetArrayIntArray());
						list2.Add(oneItemFilterRule);
					}
					OnePhantomSetting onePhantomSetting = OnePhantomSetting.Create();
					onePhantomSetting.Index = phantomManagePlanConfig.SlotIndex;
					onePhantomSetting.On = phantomManagePlanConfig.IsEnable;
					onePhantomSetting.Name = ConfigMultiTextLang.GetLocalTextNew(phantomManagePlanConfig.Name, null);
					onePhantomSetting.RuleList.AddRange(list2);
					phantomSettingInfo.Setting = onePhantomSetting;
					list.Add(phantomSettingInfo);
				}
				InventoryController.Instance.PhantomSettingBatchUpdateRequestAsync(list.ToArray()).ContinueWith(delegate(bool result)
				{
					if (result)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Warning12", Array.Empty<object>());
						this.RefreshConfig();
						this.RefreshTitle();
						this.RefreshSetting();
						this.SelectConfig(true, null);
					}
				});
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E57F RID: 189823 RVA: 0x00CEE2A0 File Offset: 0x00CEC4A0
		[NullableContext(0)]
		private UniTask<Aki.Protocol.ErrorCode> OnConfirmRename([Nullable(1)] string input)
		{
			PhantomManageConfigView.<OnConfirmRename>d__50 <OnConfirmRename>d__;
			<OnConfirmRename>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<OnConfirmRename>d__.<>4__this = this;
			<OnConfirmRename>d__.input = input;
			<OnConfirmRename>d__.<>1__state = -1;
			<OnConfirmRename>d__.<>t__builder.Start<PhantomManageConfigView.<OnConfirmRename>d__50>(ref <OnConfirmRename>d__);
			return <OnConfirmRename>d__.<>t__builder.Task;
		}

		// Token: 0x0602E580 RID: 189824 RVA: 0x00CEE2EC File Offset: 0x00CEC4EC
		private UniTask OnConfirmSwitch(EToggleState state)
		{
			PhantomManageConfigView.<OnConfirmSwitch>d__51 <OnConfirmSwitch>d__;
			<OnConfirmSwitch>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnConfirmSwitch>d__.<>4__this = this;
			<OnConfirmSwitch>d__.state = state;
			<OnConfirmSwitch>d__.<>1__state = -1;
			<OnConfirmSwitch>d__.<>t__builder.Start<PhantomManageConfigView.<OnConfirmSwitch>d__51>(ref <OnConfirmSwitch>d__);
			return <OnConfirmSwitch>d__.<>t__builder.Task;
		}

		// Token: 0x0602E581 RID: 189825 RVA: 0x00CEE337 File Offset: 0x00CEC537
		private PhantomManageConfigTypeItem CreateTypeItem()
		{
			return new PhantomManageConfigTypeItem();
		}

		// Token: 0x0602E582 RID: 189826 RVA: 0x00CEE33E File Offset: 0x00CEC53E
		private PhantomManageConfigItem CreateConfigItem()
		{
			return new PhantomManageConfigItem();
		}

		// Token: 0x0602E583 RID: 189827 RVA: 0x00CEE345 File Offset: 0x00CEC545
		private PhantomManageSettingTitleItem CreateSettingTitleItem()
		{
			return new PhantomManageSettingTitleItem();
		}

		// Token: 0x04018ADA RID: 101082
		[Nullable(2)]
		private PhantomManageConfigViewModel ViewModel;

		// Token: 0x04018ADB RID: 101083
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PhantomManageConfigTypeItem, InventoryDefine.IManageConfigTypeItemData> LayoutType;

		// Token: 0x04018ADC RID: 101084
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomManageConfigItem, PhantomManageConfigData> ScrollConfig;

		// Token: 0x04018ADD RID: 101085
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PhantomManageSettingTitleItem, InventoryDefine.IManageConfigTitleItemData> ScrollSetting;

		// Token: 0x04018ADE RID: 101086
		[Nullable(2)]
		private UUIInturnAnimController InturnAniConfig;

		// Token: 0x04018ADF RID: 101087
		[Nullable(2)]
		private UUIInturnAnimController InturnAniSetting;

		// Token: 0x04018AE0 RID: 101088
		[Nullable(2)]
		private ButtonItem BtnEdit;

		// Token: 0x04018AE1 RID: 101089
		[Nullable(2)]
		private ButtonItem BtnPreview;

		// Token: 0x04018AE2 RID: 101090
		[Nullable(2)]
		private ToggleSwitch BtnSwitch;

		// Token: 0x04018AE3 RID: 101091
		private bool IsChangeByClick;

		// Token: 0x04018AE4 RID: 101092
		private bool EnableConfigScroll = true;

		// Token: 0x0200A464 RID: 42084
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04032F28 RID: 208680
			public const int LayoutType = 0;

			// Token: 0x04032F29 RID: 208681
			public const int ScrollConfig = 1;

			// Token: 0x04032F2A RID: 208682
			public const int ItemConfig = 2;

			// Token: 0x04032F2B RID: 208683
			public const int PanelMask = 3;

			// Token: 0x04032F2C RID: 208684
			public const int TextName = 4;

			// Token: 0x04032F2D RID: 208685
			public const int BtnRename = 5;

			// Token: 0x04032F2E RID: 208686
			public const int ItemSwitch = 6;

			// Token: 0x04032F2F RID: 208687
			public const int ScrollSetting = 7;

			// Token: 0x04032F30 RID: 208688
			public const int ItemSetting = 8;

			// Token: 0x04032F31 RID: 208689
			public const int BtnDelete = 9;

			// Token: 0x04032F32 RID: 208690
			public const int BtnPreview = 10;

			// Token: 0x04032F33 RID: 208691
			public const int BtnEdit = 11;

			// Token: 0x04032F34 RID: 208692
			public const int TextureSwitch = 12;

			// Token: 0x04032F35 RID: 208693
			public const int BtnQuitEdit = 13;

			// Token: 0x04032F36 RID: 208694
			public const int BtnRecommend = 14;
		}
	}
}
