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
	// Token: 0x0200540D RID: 21517
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingContainerItem : UiPanelBase, IDynamicScrollItem<MenuScrollItemData>
	{
		// Token: 0x06036FC6 RID: 225222 RVA: 0x00D07228 File Offset: 0x00D05428
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

		// Token: 0x06036FC7 RID: 225223 RVA: 0x00D07274 File Offset: 0x00D05474
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

		// Token: 0x06036FC8 RID: 225224 RVA: 0x00D0738B File Offset: 0x00D0558B
		protected override void OnStart()
		{
			if (this.LevelSequencePlayer == null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
			this.AddEventListener();
		}

		// Token: 0x06036FC9 RID: 225225 RVA: 0x00D073AC File Offset: 0x00D055AC
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x06036FCA RID: 225226 RVA: 0x00D0740F File Offset: 0x00D0560F
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
			base.GetExtendToggle(0).OnUndeterminedClicked.Clear();
			base.GetExtendToggle(0).OnStateChange.Clear();
		}

		// Token: 0x06036FCB RID: 225227 RVA: 0x00D07450 File Offset: 0x00D05650
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

		// Token: 0x06036FCC RID: 225228 RVA: 0x00D0749C File Offset: 0x00D0569C
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

		// Token: 0x06036FCD RID: 225229 RVA: 0x00D07503 File Offset: 0x00D05703
		public void BindOnToggleStateChangedCallback(Action<MenuScrollSettingContainerItem, EToggleState> onToggleReleasedCallback)
		{
			this.OnToggleStateChangedCallback = onToggleReleasedCallback;
		}

		// Token: 0x06036FCE RID: 225230 RVA: 0x00D0750C File Offset: 0x00D0570C
		public void BindOnDetailPopOpenCallback(Action<MenuScrollSettingContainerItem> onDetailPopOpenCallback)
		{
			this.OnDetailPopOpenCallback = onDetailPopOpenCallback;
		}

		// Token: 0x06036FCF RID: 225231 RVA: 0x00D07518 File Offset: 0x00D05718
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

		// Token: 0x06036FD0 RID: 225232 RVA: 0x00D075E8 File Offset: 0x00D057E8
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

		// Token: 0x06036FD1 RID: 225233 RVA: 0x00D0763F File Offset: 0x00D0583F
		public void ClearItem()
		{
			this.ClearData();
		}

		// Token: 0x06036FD2 RID: 225234 RVA: 0x00D07647 File Offset: 0x00D05847
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

		// Token: 0x06036FD3 RID: 225235 RVA: 0x00D07688 File Offset: 0x00D05888
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

		// Token: 0x06036FD4 RID: 225236 RVA: 0x00D077BB File Offset: 0x00D059BB
		public void Update(MenuScrollItemData itemData, int index)
		{
			this.Type = new EMenuScrollItemType?(itemData.Type);
			this.Data = itemData.Data;
			this.MenuScrollItemData = itemData;
			this.ResetItemActive();
			this.HandleCurrentItem(itemData).Forget();
		}

		// Token: 0x06036FD5 RID: 225237 RVA: 0x00D077F4 File Offset: 0x00D059F4
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

		// Token: 0x06036FD6 RID: 225238 RVA: 0x00D07840 File Offset: 0x00D05A40
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

		// Token: 0x06036FD7 RID: 225239 RVA: 0x00D078C8 File Offset: 0x00D05AC8
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

		// Token: 0x06036FD8 RID: 225240 RVA: 0x00D07A2C File Offset: 0x00D05C2C
		private TItem CreateScrollItem<[Nullable(0)] TItem>(int name, Func<TItem> alloc) where TItem : MenuScrollSettingBaseItem
		{
			TItem titem = alloc();
			titem.Initialize(base.GetItem(name), new Action<float>(this.FireSaveMenuChange), new Action<string>(this.PlayLevelSequenceByName));
			return titem;
		}

		// Token: 0x06036FD9 RID: 225241 RVA: 0x00D07A60 File Offset: 0x00D05C60
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

		// Token: 0x06036FDA RID: 225242 RVA: 0x00D07AB8 File Offset: 0x00D05CB8
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

		// Token: 0x06036FDB RID: 225243 RVA: 0x00D07B3C File Offset: 0x00D05D3C
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

		// Token: 0x06036FDC RID: 225244 RVA: 0x00D07B5C File Offset: 0x00D05D5C
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

		// Token: 0x06036FDD RID: 225245 RVA: 0x00D07C30 File Offset: 0x00D05E30
		private void PlayLevelSequenceByName(string val)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName(val, false, null, false);
		}

		// Token: 0x06036FDE RID: 225246 RVA: 0x00D07C54 File Offset: 0x00D05E54
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

		// Token: 0x06036FDF RID: 225247 RVA: 0x00D07D0C File Offset: 0x00D05F0C
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

		// Token: 0x06036FE0 RID: 225248 RVA: 0x00D07D70 File Offset: 0x00D05F70
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

		// Token: 0x06036FE1 RID: 225249 RVA: 0x00D07EA4 File Offset: 0x00D060A4
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

		// Token: 0x06036FE2 RID: 225250 RVA: 0x00D07F2D File Offset: 0x00D0612D
		private void TryPlayConfirmBoxForHdr(int targetValue)
		{
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x06036FE3 RID: 225251 RVA: 0x00D07F44 File Offset: 0x00D06144
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

		// Token: 0x06036FE4 RID: 225252 RVA: 0x00D07F98 File Offset: 0x00D06198
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

		// Token: 0x06036FE5 RID: 225253 RVA: 0x00D07FEC File Offset: 0x00D061EC
		private void TryPlayConfirmBoxForHighestFps(int targetValue)
		{
			if (MenuController.Instance.NeedRedMagicFpsConfirmBox(targetValue))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RedMagic90Fps);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
			MenuController.Instance.HandleFireSaveMenuChange(this.Data, (float)targetValue);
		}

		// Token: 0x06036FE6 RID: 225254 RVA: 0x00D0802F File Offset: 0x00D0622F
		public void SetDetailVisible(bool bVisible)
		{
			if (this.CurrentItem == null)
			{
				return;
			}
			this.CurrentItem.SetDetailVisible(bVisible);
		}

		// Token: 0x06036FE7 RID: 225255 RVA: 0x00D08046 File Offset: 0x00D06246
		[NullableContext(2)]
		public MenuData GetMenuData()
		{
			return this.Data;
		}

		// Token: 0x06036FE8 RID: 225256 RVA: 0x00D0804E File Offset: 0x00D0624E
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

		// Token: 0x0401D038 RID: 118840
		public EMenuScrollItemType? Type;

		// Token: 0x0401D039 RID: 118841
		[Nullable(2)]
		private MenuData Data;

		// Token: 0x0401D03A RID: 118842
		[Nullable(2)]
		public MenuScrollItemData MenuScrollItemData;

		// Token: 0x0401D03B RID: 118843
		[Nullable(2)]
		private Vector2D VectorValue;

		// Token: 0x0401D03C RID: 118844
		[Nullable(2)]
		private MenuScrollSettingBaseItem CurrentItem;

		// Token: 0x0401D03D RID: 118845
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D03E RID: 118846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MenuScrollSettingContainerItem, EToggleState> OnToggleStateChangedCallback;

		// Token: 0x0401D03F RID: 118847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MenuScrollSettingContainerItem> OnDetailPopOpenCallback;
	}
}
