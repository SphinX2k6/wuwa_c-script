using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F0 RID: 17392
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingContainerItem : UiPanelBase, IDynamicScrollItem<MenuScrollItemData>
	{
		// Token: 0x0602BF0F RID: 179983 RVA: 0x00C56644 File Offset: 0x00C54844
		public UniTask Init(UUIItem actor)
		{
			MenuScrollSettingContainerItem.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MenuScrollSettingContainerItem.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF10 RID: 179984 RVA: 0x00C56690 File Offset: 0x00C54890
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602BF11 RID: 179985 RVA: 0x00C567A7 File Offset: 0x00C549A7
		protected override void OnStart()
		{
			if (this.LevelSequencePlayer == null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
			this.AddEventListener();
		}

		// Token: 0x0602BF12 RID: 179986 RVA: 0x00C567C8 File Offset: 0x00C549C8
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x0602BF13 RID: 179987 RVA: 0x00C5682B File Offset: 0x00C54A2B
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			base.GetExtendToggle(0).OnUndeterminedClicked.Clear();
			base.GetExtendToggle(0).OnStateChange.Clear();
		}

		// Token: 0x0602BF14 RID: 179988 RVA: 0x00C5686C File Offset: 0x00C54A6C
		private void OnUndeterminedClicked()
		{
			if (this.Data == null || !this.Data.CanClickWhenDisable || this.Data.GetEnable())
			{
				return;
			}
			if (!this.Data.GetIsDetailTextVisible())
			{
				this.SetDetailVisible(true);
				return;
			}
			this.SetDetailVisible(false);
		}

		// Token: 0x0602BF15 RID: 179989 RVA: 0x00C568B8 File Offset: 0x00C54AB8
		private void OnToggleStateChange(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.GetDetailPopId() > 0)
			{
				Action<MenuScrollSettingContainerItem> onDetailPopOpenCallback = this.OnDetailPopOpenCallback;
				if (onDetailPopOpenCallback != null)
				{
					onDetailPopOpenCallback(this);
				}
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				this.TryShowClickedTips();
			}
			if (this.OnToggleStateChangedCallback != null)
			{
				this.OnToggleStateChangedCallback(this, state);
			}
		}

		// Token: 0x0602BF16 RID: 179990 RVA: 0x00C5691F File Offset: 0x00C54B1F
		public void BindOnToggleStateChangedCallback(Action<MenuScrollSettingContainerItem, EToggleState> onToggleReleasedCallback)
		{
			this.OnToggleStateChangedCallback = onToggleReleasedCallback;
		}

		// Token: 0x0602BF17 RID: 179991 RVA: 0x00C56928 File Offset: 0x00C54B28
		public void BindOnDetailPopOpenCallback(Action<MenuScrollSettingContainerItem> onDetailPopOpenCallback)
		{
			this.OnDetailPopOpenCallback = onDetailPopOpenCallback;
		}

		// Token: 0x0602BF18 RID: 179992 RVA: 0x00C56934 File Offset: 0x00C54B34
		private void TryShowClickedTips()
		{
			if (this.Data == null)
			{
				return;
			}
			string clickedTips = this.Data.ClickedTips;
			if (string.IsNullOrEmpty(clickedTips))
			{
				return;
			}
			MenuModel instance = MenuModel.Instance;
			foreach (KeyValuePair<int, int> keyValuePair in this.Data.ClickedTipsMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (instance.IsInMenuDataByFunctionId((EFunction)key))
				{
					float? currentValueFloat = GameSettingsManager.Instance.GetCurrentValueFloat((EFunction)key, true, true);
					float num = (float)value;
					if (currentValueFloat.GetValueOrDefault() == num & currentValueFloat != null)
					{
						GenericPromptController.Instance.ShowPromptByCode(clickedTips, Array.Empty<object>());
						break;
					}
				}
			}
		}

		// Token: 0x0602BF19 RID: 179993 RVA: 0x00C56A04 File Offset: 0x00C54C04
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			MenuScrollSettingBaseItem currentItem = this.CurrentItem;
			if (currentItem != null)
			{
				currentItem.ClearItem();
			}
			this.CurrentItem = null;
			this.OnToggleStateChangedCallback = null;
			this.OnDetailPopOpenCallback = null;
			this.ClearData();
		}

		// Token: 0x0602BF1A RID: 179994 RVA: 0x00C56A5B File Offset: 0x00C54C5B
		public void ClearItem()
		{
			this.ClearData();
		}

		// Token: 0x0602BF1B RID: 179995 RVA: 0x00C56A63 File Offset: 0x00C54C63
		private void ClearData()
		{
			if (this.VectorValue != null)
			{
				this.VectorValue = null;
			}
			if (this.Type != null)
			{
				this.Type = null;
			}
			if (this.Data != null)
			{
				this.Data = null;
			}
			this.MenuScrollItemData = null;
		}

		// Token: 0x0602BF1C RID: 179996 RVA: 0x00C56AA4 File Offset: 0x00C54CA4
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(MenuScrollItemData itemData)
		{
			UUIItem uuiitem = null;
			if (itemData.Type == EMenuScrollItemType.TitleItem)
			{
				uuiitem = base.GetItem(1);
				if (uuiitem == null)
				{
					return null;
				}
				return uuiitem.GetOwner() as AUIBaseActor;
			}
			else
			{
				switch (itemData.Data.SetType)
				{
				case ESetType.SLIDER:
				{
					MenuData data = itemData.Data;
					uuiitem = ((data != null && data.NeedScale) ? base.GetItem(9) : base.GetItem(4));
					break;
				}
				case ESetType.OPTIONS:
				{
					MenuData data2 = itemData.Data;
					uuiitem = ((data2 != null && data2.NeedScale) ? base.GetItem(8) : base.GetItem(3));
					break;
				}
				case ESetType.KEYMAP:
				{
					MenuData data3 = itemData.Data;
					uuiitem = ((data3 != null && data3.NeedScale) ? base.GetItem(7) : base.GetItem(2));
					break;
				}
				case ESetType.BUTTON:
				{
					MenuData data4 = itemData.Data;
					uuiitem = ((data4 != null && data4.NeedScale) ? base.GetItem(7) : base.GetItem(2));
					break;
				}
				case ESetType.DROPDOWN:
				{
					MenuData data5 = itemData.Data;
					uuiitem = ((data5 != null && data5.NeedScale) ? base.GetItem(10) : base.GetItem(5));
					break;
				}
				}
				if (uuiitem == null)
				{
					return null;
				}
				return uuiitem.GetOwner() as AUIBaseActor;
			}
		}

		// Token: 0x0602BF1D RID: 179997 RVA: 0x00C56BD7 File Offset: 0x00C54DD7
		public void Update(MenuScrollItemData itemData, int index)
		{
			this.Type = new EMenuScrollItemType?(itemData.Type);
			this.Data = itemData.Data;
			this.MenuScrollItemData = itemData;
			this.ResetItemActive();
			this.HandleCurrentItem(itemData).Forget();
		}

		// Token: 0x0602BF1E RID: 179998 RVA: 0x00C56C10 File Offset: 0x00C54E10
		private UniTask HandleCurrentItem(MenuScrollItemData itemData)
		{
			MenuScrollSettingContainerItem.<HandleCurrentItem>d__23 <HandleCurrentItem>d__;
			<HandleCurrentItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleCurrentItem>d__.<>4__this = this;
			<HandleCurrentItem>d__.itemData = itemData;
			<HandleCurrentItem>d__.<>1__state = -1;
			<HandleCurrentItem>d__.<>t__builder.Start<MenuScrollSettingContainerItem.<HandleCurrentItem>d__23>(ref <HandleCurrentItem>d__);
			return <HandleCurrentItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF1F RID: 179999 RVA: 0x00C56C5C File Offset: 0x00C54E5C
		private void RefreshItem(MenuScrollSettingBaseItem item, MenuScrollItemData itemData)
		{
			if (item == null)
			{
				return;
			}
			MenuData data = itemData.Data;
			item.SetActive(true);
			item.ExecuteUpdate(data, false);
			if (itemData.Type != EMenuScrollItemType.TitleItem)
			{
				this.SetItemInteractionActive(data.GetEnable());
			}
			else
			{
				this.SetItemInteractionActive(false);
			}
			if ((data.HasDetailText() || data.GetDetailPopId() > 0) && data.GetEnable())
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState((data != null && data.GetIsDetailTextVisible()) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0602BF20 RID: 180000 RVA: 0x00C56CE4 File Offset: 0x00C54EE4
		[return: Nullable(2)]
		private MenuScrollSettingBaseItem GetCreateScrollItem(MenuScrollItemData itemData)
		{
			if (itemData.Type == EMenuScrollItemType.TitleItem)
			{
				return this.CreateScrollItem<MenuScrollSettingTitleItem>(1, () => new MenuScrollSettingTitleItem());
			}
			switch (itemData.Data.SetType)
			{
			case ESetType.SLIDER:
			{
				MenuData data = itemData.Data;
				return this.CreateScrollItem<MenuScrollSettingSliderItem>((data != null && data.NeedScale) ? 9 : 4, () => new MenuScrollSettingSliderItem());
			}
			case ESetType.OPTIONS:
			{
				MenuData data2 = itemData.Data;
				return this.CreateScrollItem<MenuScrollSettingSwitchItem>((data2 != null && data2.NeedScale) ? 8 : 3, () => new MenuScrollSettingSwitchItem());
			}
			case ESetType.BUTTON:
			{
				MenuData data3 = itemData.Data;
				return this.CreateScrollItem<MenuScrollSettingButtonItem>((data3 != null && data3.NeedScale) ? 7 : 2, () => new MenuScrollSettingButtonItem());
			}
			case ESetType.DROPDOWN:
			{
				MenuData data4 = itemData.Data;
				return this.CreateScrollItem<MenuScrollSettingDropDown>((data4 != null && data4.NeedScale) ? 10 : 5, () => new MenuScrollSettingDropDown());
			}
			}
			return null;
		}

		// Token: 0x0602BF21 RID: 180001 RVA: 0x00C56E48 File Offset: 0x00C55048
		private TItem CreateScrollItem<[Nullable(0)] TItem>(int name, Func<TItem> alloc) where TItem : MenuScrollSettingBaseItem
		{
			TItem titem = alloc();
			titem.Initialize(base.GetItem(name), new Action<float>(this.FireSaveMenuChange), new Action<string>(this.PlayLevelSequenceByName));
			return titem;
		}

		// Token: 0x0602BF22 RID: 180002 RVA: 0x00C56E7C File Offset: 0x00C5507C
		private void RefreshData()
		{
			if (this.CurrentItem != null)
			{
				this.CurrentItem.ExecuteUpdate(this.Data, true);
				MenuScrollItemData menuScrollItemData = this.MenuScrollItemData;
				if (menuScrollItemData == null || menuScrollItemData.Type > EMenuScrollItemType.TitleItem)
				{
					this.SetItemInteractionActive(this.Data.GetEnable());
					return;
				}
				this.SetItemInteractionActive(false);
			}
		}

		// Token: 0x0602BF23 RID: 180003 RVA: 0x00C56ED4 File Offset: 0x00C550D4
		private void ResetItemActive()
		{
			base.GetItem(1).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x0602BF24 RID: 180004 RVA: 0x00C56F58 File Offset: 0x00C55158
		private void OnRefreshMenuSetting(EFunction functionId)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.FunctionId == functionId)
			{
				this.RefreshData();
			}
		}

		// Token: 0x0602BF25 RID: 180005 RVA: 0x00C56F78 File Offset: 0x00C55178
		private void SetItemInteractionActive(bool isActive)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (isActive)
			{
				if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
				{
					extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				}
				else
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				extendToggle.SetSelfInteractive(true);
			}
			else
			{
				MenuScrollItemData menuScrollItemData = this.MenuScrollItemData;
				bool selfInteractive = menuScrollItemData == null || menuScrollItemData.Type > EMenuScrollItemType.TitleItem;
				extendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				extendToggle.SetSelfInteractive(selfInteractive);
			}
			EMenuScrollItemType? type = this.Type;
			EMenuScrollItemType emenuScrollItemType = EMenuScrollItemType.TitleItem;
			if (type.GetValueOrDefault() == emenuScrollItemType & type != null)
			{
				return;
			}
			if (this.CurrentItem != null)
			{
				this.CurrentItem.SetInteractionActive(isActive);
				if (!isActive)
				{
					MenuData data = this.Data;
					if (data != null && data.CanClickWhenDisable)
					{
						this.SetDetailVisible(this.Data.GetIsDetailTextVisible());
						return;
					}
				}
				if (!isActive)
				{
					this.CurrentItem.SetDetailVisible(false);
				}
			}
		}

		// Token: 0x0602BF26 RID: 180006 RVA: 0x00C5704C File Offset: 0x00C5524C
		private void PlayLevelSequenceByName(string val)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName(val, false, null, false);
		}

		// Token: 0x0602BF27 RID: 180007 RVA: 0x00C57070 File Offset: 0x00C55270
		private void FireSaveMenuChange(float val)
		{
			int targetValue = (int)val;
			if (this.Data.FunctionId == EFunction.RayTracing)
			{
				this.TryPlayConfirmBoxForRayTracing(targetValue);
				return;
			}
			if (this.Data.FunctionId == EFunction.NVIDIADLSSFG)
			{
				this.TryPlayConfirmBoxForDlssFg(targetValue);
				return;
			}
			if (this.Data.FunctionId == EFunction.Vulkan)
			{
				this.TryPlayConfirmBoxForVulkan(targetValue);
				return;
			}
			if (this.Data.FunctionId == EFunction.HIGHESTFPS)
			{
				this.TryPlayConfirmBoxForHighestFps(targetValue);
				return;
			}
			if (this.Data.FunctionId == EFunction.HDR)
			{
				this.TryPlayConfirmBoxForHdr(targetValue);
				return;
			}
			if (this.Data.FunctionId == EFunction.AnisoLevel)
			{
				this.TryPlayConfirmBoxForAnisoLevel(targetValue);
				return;
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, val);
		}

		// Token: 0x0602BF28 RID: 180008 RVA: 0x00C57128 File Offset: 0x00C55328
		private void BuildThenShowConfirmBoxForRayTracing(EConfirmBoxConfigId confirmBoxId)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(confirmBoxId);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
			});
			confirmBoxDataNew.SetCloseFunction(delegate
			{
				MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602BF29 RID: 180009 RVA: 0x00C5718C File Offset: 0x00C5538C
		private void TryPlayConfirmBoxForRayTracing(int targetValue)
		{
			if (GameSettingsDeviceRender.Instance.IsDxr1_1NotSupported() && targetValue > 0)
			{
				this.BuildThenShowConfirmBoxForRayTracing(EConfirmBoxConfigId.Dxr1_1NotSupported);
				return;
			}
			if (GameSettingsDeviceRender.Instance.IsDriverNeedUpdateForRayTracing() && targetValue > 0)
			{
				this.BuildThenShowConfirmBoxForRayTracing(EConfirmBoxConfigId.GpuDriverVersionLowForRayTracing);
				return;
			}
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(this.Data.FunctionId);
			MenuModel.Instance.NeedRayTracingSubChange = ((dataCacheOrCurValue + targetValue).GetValueOrDefault() == 1);
			int? num = dataCacheOrCurValue;
			int num2 = 0;
			if ((num.GetValueOrDefault() == num2 & num != null) && targetValue == 1 && !MenuModel.Instance.IsRayTracingOpenChecked)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RayTracingOn);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					MenuModel.Instance.IsRayTracingOpenChecked = true;
					MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2A RID: 180010 RVA: 0x00C572C0 File Offset: 0x00C554C0
		private void TryPlayConfirmBoxForDlssFg(int targetValue)
		{
			if (targetValue > 0 && GameSettingsDeviceRender.Instance.IsDlss3HardwareSchedulingDisabled())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DlssFrameGenerateInvalid);
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
					MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
				});
				confirmBoxDataNew.SetCloseFunction(delegate
				{
					MenuController.Instance.HandleFireSaveMenuChange(this.Data, 0f);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2B RID: 180011 RVA: 0x00C57349 File Offset: 0x00C55549
		private void TryPlayConfirmBoxForHdr(int targetValue)
		{
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2C RID: 180012 RVA: 0x00C57360 File Offset: 0x00C55560
		private void TryPlayConfirmBoxForAnisoLevel(int targetValue)
		{
			if (targetValue > 0 && !MenuModel.Instance.IsAnisoLevelOpenChecked)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RayTracingOn);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				MenuModel.Instance.IsAnisoLevelOpenChecked = true;
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2D RID: 180013 RVA: 0x00C573B4 File Offset: 0x00C555B4
		private void TryPlayConfirmBoxForVulkan(int targetValue)
		{
			if (targetValue > 0 && !MenuModel.Instance.IsVulkanOpenChecked)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VulkanOn);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				MenuModel.Instance.IsVulkanOpenChecked = true;
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2E RID: 180014 RVA: 0x00C57408 File Offset: 0x00C55608
		private void TryPlayConfirmBoxForHighestFps(int targetValue)
		{
			if (MenuController.Instance.NeedRedMagicFpsConfirmBox(targetValue))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RedMagic90Fps);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x0602BF2F RID: 180015 RVA: 0x00C5744B File Offset: 0x00C5564B
		public void SetDetailVisible(bool bVisible)
		{
			if (this.CurrentItem == null)
			{
				return;
			}
			this.CurrentItem.SetDetailVisible(bVisible);
		}

		// Token: 0x0602BF30 RID: 180016 RVA: 0x00C57462 File Offset: 0x00C55662
		[NullableContext(2)]
		public MenuData GetMenuData()
		{
			return this.Data;
		}

		// Token: 0x0602BF31 RID: 180017 RVA: 0x00C5746A File Offset: 0x00C5566A
		public void SetSelected(bool bSelected)
		{
			if (bSelected)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x04017AD1 RID: 96977
		public EMenuScrollItemType? Type;

		// Token: 0x04017AD2 RID: 96978
		[Nullable(2)]
		private MenuData Data;

		// Token: 0x04017AD3 RID: 96979
		[Nullable(2)]
		public MenuScrollItemData MenuScrollItemData;

		// Token: 0x04017AD4 RID: 96980
		[Nullable(2)]
		private Vector2D VectorValue;

		// Token: 0x04017AD5 RID: 96981
		[Nullable(2)]
		private MenuScrollSettingBaseItem CurrentItem;

		// Token: 0x04017AD6 RID: 96982
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04017AD7 RID: 96983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MenuScrollSettingContainerItem, EToggleState> OnToggleStateChangedCallback;

		// Token: 0x04017AD8 RID: 96984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MenuScrollSettingContainerItem> OnDetailPopOpenCallback;
	}
}
