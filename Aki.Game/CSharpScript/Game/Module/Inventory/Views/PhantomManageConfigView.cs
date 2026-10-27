using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005838 RID: 22584
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomManageConfigView : UiTabViewBase
	{
		// Token: 0x06039646 RID: 235078 RVA: 0x00D9E50C File Offset: 0x00D9C70C
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

		// Token: 0x06039647 RID: 235079 RVA: 0x00D9E6E4 File Offset: 0x00D9C8E4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomManageConfigView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManageConfigView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039648 RID: 235080 RVA: 0x00D9E728 File Offset: 0x00D9C928
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

		// Token: 0x06039649 RID: 235081 RVA: 0x00D9E884 File Offset: 0x00D9CA84
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

		// Token: 0x0603964A RID: 235082 RVA: 0x00D9E8B5 File Offset: 0x00D9CAB5
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x0603964B RID: 235083 RVA: 0x00D9E8D0 File Offset: 0x00D9CAD0
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

		// Token: 0x0603964C RID: 235084 RVA: 0x00D9E974 File Offset: 0x00D9CB74
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
			this.LayoutType.RefreshByData(list.ToList<InventoryDefine.IManageConfigTypeItemData>(), null, false);
		}

		// Token: 0x0603964D RID: 235085 RVA: 0x00D9E9D8 File Offset: 0x00D9CBD8
		private UniTask RefreshConfig()
		{
			PhantomManageConfigView.<RefreshConfig>d__19 <RefreshConfig>d__;
			<RefreshConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshConfig>d__.<>4__this = this;
			<RefreshConfig>d__.<>1__state = -1;
			<RefreshConfig>d__.<>t__builder.Start<PhantomManageConfigView.<RefreshConfig>d__19>(ref <RefreshConfig>d__);
			return <RefreshConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0603964E RID: 235086 RVA: 0x00D9EA1C File Offset: 0x00D9CC1C
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

		// Token: 0x0603964F RID: 235087 RVA: 0x00D9EAAC File Offset: 0x00D9CCAC
		private void RefreshSetting()
		{
			List<InventoryDefine.IManageConfigTitleItemData> settingTitleItemDataList = InventoryModel.Instance.GetSettingTitleItemDataList();
			this.ScrollSetting.RefreshByDataAsync(settingTitleItemDataList.ToList<InventoryDefine.IManageConfigTitleItemData>(), false);
		}

		// Token: 0x06039650 RID: 235088 RVA: 0x00D9EAD8 File Offset: 0x00D9CCD8
		private void RefreshButtons()
		{
			string textId = this.ViewModel.GetEditState() ? "PhantomProject_SaveButton02" : "PhantomProject_EditButton";
			this.BtnEdit.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x06039651 RID: 235089 RVA: 0x00D9EB10 File Offset: 0x00D9CD10
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

		// Token: 0x06039652 RID: 235090 RVA: 0x00D9EB70 File Offset: 0x00D9CD70
		private void RefreshRecommendBtnState()
		{
			bool editState = this.ViewModel.GetEditState();
			base.SetButtonUiActive(14, !editState);
		}

		// Token: 0x06039653 RID: 235091 RVA: 0x00D9EB98 File Offset: 0x00D9CD98
		private void RefreshEditData()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			if (this.ViewModel.GetEditState())
			{
				this.ViewModel.InitEditDataSwitch(selectConfig, false);
			}
		}

		// Token: 0x06039654 RID: 235092 RVA: 0x00D9EBCC File Offset: 0x00D9CDCC
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

		// Token: 0x06039655 RID: 235093 RVA: 0x00D9EC40 File Offset: 0x00D9CE40
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

		// Token: 0x06039656 RID: 235094 RVA: 0x00D9EC88 File Offset: 0x00D9CE88
		private void OnClickedBtnRename()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			CommonInputViewController.Instance.OpenSetPhantomManageConfigName(selectConfig.GetName(), new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.OnConfirmRename), "");
		}

		// Token: 0x06039657 RID: 235095 RVA: 0x00D9ECC2 File Offset: 0x00D9CEC2
		private void OnClickedBtnDelete()
		{
			if (this.ViewModel.GetEditState())
			{
				this.OnEditDelete();
				return;
			}
			this.OnDelete();
		}

		// Token: 0x06039658 RID: 235096 RVA: 0x00D9ECE0 File Offset: 0x00D9CEE0
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

		// Token: 0x06039659 RID: 235097 RVA: 0x00D9ED3C File Offset: 0x00D9CF3C
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

		// Token: 0x0603965A RID: 235098 RVA: 0x00D9EDA8 File Offset: 0x00D9CFA8
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

		// Token: 0x0603965B RID: 235099 RVA: 0x00D9EE08 File Offset: 0x00D9D008
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

		// Token: 0x0603965C RID: 235100 RVA: 0x00D9EE7C File Offset: 0x00D9D07C
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

		// Token: 0x0603965D RID: 235101 RVA: 0x00D9EEC7 File Offset: 0x00D9D0C7
		private void OnClickedBtnEdit(int _)
		{
			if (this.ViewModel.GetEditState())
			{
				this.TrySaveEditData();
				return;
			}
			this.ViewModel.SetEditState(true, false);
		}

		// Token: 0x0603965E RID: 235102 RVA: 0x00D9EEEC File Offset: 0x00D9D0EC
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

		// Token: 0x0603965F RID: 235103 RVA: 0x00D9F030 File Offset: 0x00D9D230
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

		// Token: 0x06039660 RID: 235104 RVA: 0x00D9F08C File Offset: 0x00D9D28C
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

		// Token: 0x06039661 RID: 235105 RVA: 0x00D9F0C4 File Offset: 0x00D9D2C4
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

		// Token: 0x06039662 RID: 235106 RVA: 0x00D9F11C File Offset: 0x00D9D31C
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
				dictionary.Add((FilterDefine.EFilterType)filterType, keyValuePair.Value.ToList<int>());
			}
			return dictionary;
		}

		// Token: 0x06039663 RID: 235107 RVA: 0x00D9F1D0 File Offset: 0x00D9D3D0
		private void OnClickedBtnPreview(int _)
		{
			if (this.ViewModel.GetEditState())
			{
				this.OnEditPreview();
				return;
			}
			this.OnPreview();
		}

		// Token: 0x06039664 RID: 235108 RVA: 0x00D9F1EC File Offset: 0x00D9D3EC
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

		// Token: 0x06039665 RID: 235109 RVA: 0x00D9F230 File Offset: 0x00D9D430
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

		// Token: 0x06039666 RID: 235110 RVA: 0x00D9F278 File Offset: 0x00D9D478
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

		// Token: 0x06039667 RID: 235111 RVA: 0x00D9F2BC File Offset: 0x00D9D4BC
		private void QuitEditState()
		{
			PhantomManageConfigData selectConfig = this.ViewModel.GetSelectConfig();
			this.ViewModel.InitEditDataSwitch(selectConfig, true);
			this.ViewModel.SetEditState(false, false);
		}

		// Token: 0x06039668 RID: 235112 RVA: 0x00D9F2F0 File Offset: 0x00D9D4F0
		private void OpenManageView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageView) || UiManager.Instance.IsViewHide(EUiViewName.PhantomManageView))
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomManageView, new Action<bool>(this.OnCloseManageView));
				return;
			}
			this.OnCloseManageView(true);
		}

		// Token: 0x06039669 RID: 235113 RVA: 0x00D9F342 File Offset: 0x00D9D542
		private void OnCloseManageView(bool success)
		{
			if (success)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomManageView, null, null);
			}
		}

		// Token: 0x0603966A RID: 235114 RVA: 0x00D9F358 File Offset: 0x00D9D558
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

		// Token: 0x0603966B RID: 235115 RVA: 0x00D9F3D0 File Offset: 0x00D9D5D0
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

		// Token: 0x0603966C RID: 235116 RVA: 0x00D9F40C File Offset: 0x00D9D60C
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

		// Token: 0x0603966D RID: 235117 RVA: 0x00D9F458 File Offset: 0x00D9D658
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

		// Token: 0x0603966E RID: 235118 RVA: 0x00D9F4A3 File Offset: 0x00D9D6A3
		private PhantomManageConfigTypeItem CreateTypeItem()
		{
			return new PhantomManageConfigTypeItem();
		}

		// Token: 0x0603966F RID: 235119 RVA: 0x00D9F4AA File Offset: 0x00D9D6AA
		private PhantomManageConfigItem CreateConfigItem()
		{
			return new PhantomManageConfigItem();
		}

		// Token: 0x06039670 RID: 235120 RVA: 0x00D9F4B1 File Offset: 0x00D9D6B1
		private PhantomManageSettingTitleItem CreateSettingTitleItem()
		{
			return new PhantomManageSettingTitleItem();
		}

		// Token: 0x0401E041 RID: 122945
		[Nullable(2)]
		private PhantomManageConfigViewModel ViewModel;

		// Token: 0x0401E042 RID: 122946
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PhantomManageConfigTypeItem, InventoryDefine.IManageConfigTypeItemData> LayoutType;

		// Token: 0x0401E043 RID: 122947
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomManageConfigItem, PhantomManageConfigData> ScrollConfig;

		// Token: 0x0401E044 RID: 122948
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PhantomManageSettingTitleItem, InventoryDefine.IManageConfigTitleItemData> ScrollSetting;

		// Token: 0x0401E045 RID: 122949
		[Nullable(2)]
		private UUIInturnAnimController InturnAniConfig;

		// Token: 0x0401E046 RID: 122950
		[Nullable(2)]
		private UUIInturnAnimController InturnAniSetting;

		// Token: 0x0401E047 RID: 122951
		[Nullable(2)]
		private ButtonItem BtnEdit;

		// Token: 0x0401E048 RID: 122952
		[Nullable(2)]
		private ButtonItem BtnPreview;

		// Token: 0x0401E049 RID: 122953
		[Nullable(2)]
		private ToggleSwitch BtnSwitch;

		// Token: 0x0401E04A RID: 122954
		private bool IsChangeByClick;

		// Token: 0x0401E04B RID: 122955
		private bool EnableConfigScroll = true;

		// Token: 0x0200BA4E RID: 47694
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403853B RID: 230715
			public const int LayoutType = 0;

			// Token: 0x0403853C RID: 230716
			public const int ScrollConfig = 1;

			// Token: 0x0403853D RID: 230717
			public const int ItemConfig = 2;

			// Token: 0x0403853E RID: 230718
			public const int PanelMask = 3;

			// Token: 0x0403853F RID: 230719
			public const int TextName = 4;

			// Token: 0x04038540 RID: 230720
			public const int BtnRename = 5;

			// Token: 0x04038541 RID: 230721
			public const int ItemSwitch = 6;

			// Token: 0x04038542 RID: 230722
			public const int ScrollSetting = 7;

			// Token: 0x04038543 RID: 230723
			public const int ItemSetting = 8;

			// Token: 0x04038544 RID: 230724
			public const int BtnDelete = 9;

			// Token: 0x04038545 RID: 230725
			public const int BtnPreview = 10;

			// Token: 0x04038546 RID: 230726
			public const int BtnEdit = 11;

			// Token: 0x04038547 RID: 230727
			public const int TextureSwitch = 12;

			// Token: 0x04038548 RID: 230728
			public const int BtnQuitEdit = 13;

			// Token: 0x04038549 RID: 230729
			public const int BtnRecommend = 14;
		}
	}
}
