using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E6 RID: 25318
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipView : UiViewBase
	{
		// Token: 0x0603FB21 RID: 260897 RVA: 0x00F68DBC File Offset: 0x00F66FBC
		public PinballWeaponEquipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FB22 RID: 260898 RVA: 0x00F68DF8 File Offset: 0x00F66FF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickContrastToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickDecomposeButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FB23 RID: 260899 RVA: 0x00F68FF0 File Offset: 0x00F671F0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponEquipView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponEquipView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB24 RID: 260900 RVA: 0x00F69033 File Offset: 0x00F67233
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x0603FB25 RID: 260901 RVA: 0x00F69051 File Offset: 0x00F67251
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x0603FB26 RID: 260902 RVA: 0x00F69070 File Offset: 0x00F67270
		protected override void OnBeforeShow()
		{
			int num = 0;
			if (this.SelectedGridData != null)
			{
				num = this.SelectedGridData.Data.WeaponData.IncId;
				this.SelectedGridData = null;
			}
			this.UpdateWeaponGridDataList();
			this.FilterSortEntrance.UpdateData(EFilterSortGroupId.PinballWeaponEquip, this.AllWeaponGridDataList, Array.Empty<object>());
			int num2 = -1;
			if (num > 0)
			{
				num2 = this.GetGridIndexByWeaponIncId(num);
			}
			if (num2 < 0)
			{
				num2 = 1;
			}
			this.SetSelectedGridData(num2);
			this.UpdateCurSelectedWeaponTipData();
			this.UpdateCurEquipWeaponTipData();
			this.RefreshGrids();
			this.RefreshCurSelectedWeaponTip();
			this.RefreshCurEquipWeaponTip();
			this.RefreshCurEquipWeaponTipShowState();
			this.RefreshWeaponCountText();
		}

		// Token: 0x0603FB27 RID: 260903 RVA: 0x00F69107 File Offset: 0x00F67307
		protected override void OnAfterShow()
		{
			this.CheckToShowOverCapacityConfirm();
		}

		// Token: 0x0603FB28 RID: 260904 RVA: 0x00F69110 File Offset: 0x00F67310
		private void UpdateWeaponGridDataList()
		{
			if (this.Data == null)
			{
				return;
			}
			this.AllWeaponGridDataList.Clear();
			List<PinballWeaponData> weaponDataAll = this.Data.ActivityData.GetWeaponDataAll();
			PinballRoleConfig config = this.Data.RoleData.GetConfig();
			int id = config.Id;
			int personWeaponType = config.PersonWeaponType;
			int weaponType = config.WeaponType;
			PinballModel instance = PinballModel.Instance;
			foreach (PinballWeaponData pinballWeaponData in weaponDataAll)
			{
				bool canEquip = instance.CheckWeaponCanEquip(pinballWeaponData, weaponType, personWeaponType);
				bool isCurRoleEquip = pinballWeaponData.RoleId == id;
				PinballWeaponMultiTemplateGridData item = new PinballWeaponMultiTemplateGridData(this.BuildWeaponGridData(pinballWeaponData, canEquip, isCurRoleEquip));
				this.AllWeaponGridDataList.Add(item);
			}
		}

		// Token: 0x0603FB29 RID: 260905 RVA: 0x00F691E8 File Offset: 0x00F673E8
		protected void UpdateGridData(List<IMultiTemplateGridData> sortDataList)
		{
			if (this.Data == null)
			{
				return;
			}
			this.GridDataList.Clear();
			this.CanEquipWeaponGridDataList.Clear();
			this.CanNotEquipWeaponGridDataList.Clear();
			foreach (IMultiTemplateGridData multiTemplateGridData in sortDataList)
			{
				if ((multiTemplateGridData.Data as IPinballItemSyncWeaponGridViewData).CanEquip)
				{
					this.CanEquipWeaponGridDataList.Add(multiTemplateGridData);
				}
				else
				{
					this.CanNotEquipWeaponGridDataList.Add(multiTemplateGridData);
				}
			}
			int weaponType = this.Data.RoleData.GetConfig().WeaponType;
			PinballWeaponType? pinballWeaponTypeConfigById = PinballConfig.Instance.GetPinballWeaponTypeConfigById(weaponType);
			PinballWeaponEquipTitleGridData item = new PinballWeaponEquipTitleGridData(new PinballWeaponEquipTitleItemData
			{
				TypeIconPath = pinballWeaponTypeConfigById.Value.Icon,
				DescTextData = new TableTextArgNew("Pinball_Weapon_SelectInfo01", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(pinballWeaponTypeConfigById.Value.Name, null))),
				CanEquip = true
			});
			this.GridDataList.Add(item);
			this.GridDataList.AddRange(this.CanEquipWeaponGridDataList);
			if (this.CanNotEquipWeaponGridDataList.Count == 0)
			{
				return;
			}
			PinballWeaponEquipTitleGridData item2 = new PinballWeaponEquipTitleGridData(new PinballWeaponEquipTitleItemData
			{
				TypeIconPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/OutSide/SP_IconTitle02.SP_IconTitle02",
				DescTextData = new TableTextArgNew("Pinball_Weapon_SelectInfo02", Array.Empty<object>()),
				CanEquip = false
			});
			this.GridDataList.Add(item2);
			this.GridDataList.AddRange(this.CanNotEquipWeaponGridDataList);
		}

		// Token: 0x0603FB2A RID: 260906 RVA: 0x00F69380 File Offset: 0x00F67580
		protected void UpdateWeaponGridDataIsCurRoleEquip(PinballWeaponMultiTemplateGridData weaponGridData)
		{
			IPinballItemSyncWeaponGridViewData data = weaponGridData.Data;
			int roleId = data.WeaponData.RoleId;
			IPinballWeaponEquipViewData data2 = this.Data;
			int? num = (data2 != null) ? new int?(data2.RoleData.GetId()) : null;
			data.IsCurRoleEquip = (roleId == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x0603FB2B RID: 260907 RVA: 0x00F693DC File Offset: 0x00F675DC
		protected void SetSelectedGridData(int index)
		{
			if (index < 0 || index >= this.GridDataList.Count)
			{
				return;
			}
			PinballWeaponMultiTemplateGridData selectedGridData = this.SelectedGridData;
			if (selectedGridData != null)
			{
				selectedGridData.Data.IsSelected = false;
			}
			this.SelectedIndex = index;
			this.SelectedGridData = (this.GridDataList[index] as PinballWeaponMultiTemplateGridData);
			this.SelectedGridData.Data.IsSelected = true;
			this.UpdateCurSelectedWeaponTipData();
		}

		// Token: 0x0603FB2C RID: 260908 RVA: 0x00F69448 File Offset: 0x00F67648
		protected void UpdateCurSelectedWeaponTipData()
		{
			if (this.SelectedGridData == null)
			{
				return;
			}
			bool canEquip = this.SelectedGridData.Data.CanEquip;
			EPinballWeaponEquipState state = EPinballWeaponEquipState.CanNotEquip;
			if (canEquip)
			{
				state = ((this.SelectedGridData.Data.WeaponData.IncId == this.GetCurEquipWeaponIncId()) ? EPinballWeaponEquipState.IsEquipped : EPinballWeaponEquipState.CanEquip);
			}
			PinballWeaponEquipTipItemData curSelectedWeaponTipData = new PinballWeaponEquipTipItemData
			{
				WeaponData = this.SelectedGridData.Data.WeaponData,
				ShowButton = true,
				State = state,
				ConfirmDelegate = new Action(this.OnClickEquipButton)
			};
			this.CurSelectedWeaponTipData = curSelectedWeaponTipData;
		}

		// Token: 0x0603FB2D RID: 260909 RVA: 0x00F694DC File Offset: 0x00F676DC
		protected void UpdateCurEquipWeaponTipData()
		{
			IPinballWeaponEquipViewData data = this.Data;
			PinballRoleDataBase pinballRoleDataBase = (data != null) ? data.RoleData : null;
			if (pinballRoleDataBase == null)
			{
				return;
			}
			PinballWeaponData weaponData = pinballRoleDataBase.GetWeaponData();
			if (weaponData == null)
			{
				return;
			}
			PinballWeaponEquipTipItemData curEquipWeaponTipData = new PinballWeaponEquipTipItemData
			{
				WeaponData = weaponData,
				ShowButton = false,
				State = EPinballWeaponEquipState.IsEquipped
			};
			this.CurEquipWeaponTipData = curEquipWeaponTipData;
		}

		// Token: 0x0603FB2E RID: 260910 RVA: 0x00F69530 File Offset: 0x00F67730
		public void RefreshGrids()
		{
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.GridDataList);
			multiTemplateScrollViewRefreshContext.PlayGridAnim = true;
			MultiTemplateScrollView weaponMultiTemplateScrollView = this.WeaponMultiTemplateScrollView;
			if (weaponMultiTemplateScrollView == null)
			{
				return;
			}
			weaponMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0603FB2F RID: 260911 RVA: 0x00F69561 File Offset: 0x00F67761
		public void RefreshCurSelectedWeaponTip()
		{
			if (this.CurSelectedWeaponTipData == null)
			{
				return;
			}
			PinballWeaponEquipTipItem curSelectedWeaponTipItem = this.CurSelectedWeaponTipItem;
			if (curSelectedWeaponTipItem == null)
			{
				return;
			}
			curSelectedWeaponTipItem.Refresh(this.CurSelectedWeaponTipData);
		}

		// Token: 0x0603FB30 RID: 260912 RVA: 0x00F69582 File Offset: 0x00F67782
		public void RefreshCurEquipWeaponTip()
		{
			if (this.CurEquipWeaponTipData == null)
			{
				return;
			}
			PinballWeaponEquipTipItem curEquipWeaponTipItem = this.CurEquipWeaponTipItem;
			if (curEquipWeaponTipItem == null)
			{
				return;
			}
			curEquipWeaponTipItem.Refresh(this.CurEquipWeaponTipData);
		}

		// Token: 0x0603FB31 RID: 260913 RVA: 0x00F695A3 File Offset: 0x00F677A3
		public void RefreshCurEquipWeaponTipShowState()
		{
			if (this.CurEquipWeaponTipData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsContrastEnabled);
		}

		// Token: 0x0603FB32 RID: 260914 RVA: 0x00F695C8 File Offset: 0x00F677C8
		public void RefreshWeaponCountText()
		{
			int count = this.AllWeaponGridDataList.Count;
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, "Pinball_Weapon_SelectInfo03", new <>z__ReadOnlyArray<object>(new object[]
			{
				count,
				this.Capacity
			}));
		}

		// Token: 0x0603FB33 RID: 260915 RVA: 0x00F6961C File Offset: 0x00F6781C
		public void SelectGrid(int index)
		{
			int selectedIndex = this.SelectedIndex;
			if (selectedIndex == index)
			{
				return;
			}
			this.SetSelectedGridData(index);
			if (selectedIndex != -1)
			{
				MultiTemplateScrollView weaponMultiTemplateScrollView = this.WeaponMultiTemplateScrollView;
				ISyncGridProxy syncGridProxy = (weaponMultiTemplateScrollView != null) ? weaponMultiTemplateScrollView.GetProxyByGridIndex(selectedIndex) : null;
				if (syncGridProxy != null)
				{
					((PinballItemSyncWeaponGridView)syncGridProxy).RefreshToggleState(false);
				}
			}
			MultiTemplateScrollView weaponMultiTemplateScrollView2 = this.WeaponMultiTemplateScrollView;
			PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = ((weaponMultiTemplateScrollView2 != null) ? weaponMultiTemplateScrollView2.GetProxyByGridIndex(index) : null) as PinballItemSyncWeaponGridView;
			if (pinballItemSyncWeaponGridView != null)
			{
				pinballItemSyncWeaponGridView.RefreshToggleState(false);
			}
			this.RefreshCurSelectedWeaponTip();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0603FB34 RID: 260916 RVA: 0x00F696AC File Offset: 0x00F678AC
		public void EquipCurSelectedWeapon()
		{
			UiAsyncTask task = new UiAsyncTask("EquipCurSelectedWeapon", new Func<UniTask>(this.EquipCurSelectedWeaponAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FB35 RID: 260917 RVA: 0x00F696E0 File Offset: 0x00F678E0
		public void OpenReplaceConfirmView()
		{
			IPinballWeaponEquipTipItemData curSelectedWeaponTipData = this.CurSelectedWeaponTipData;
			PinballWeaponData pinballWeaponData = (curSelectedWeaponTipData != null) ? curSelectedWeaponTipData.WeaponData : null;
			if (pinballWeaponData == null || pinballWeaponData.RoleId <= 0)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PinballWeaponReplaceConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.EquipCurSelectedWeapon();
			};
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(pinballWeaponData.Name, null);
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(PinballModel.Instance.GetRoleNameByPinballRoleId(pinballWeaponData.RoleId), null);
			confirmBoxDataNew.TextArgs = new string[]
			{
				localTextNew,
				localTextNew2
			};
			PinballController.Instance.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
		}

		// Token: 0x0603FB36 RID: 260918 RVA: 0x00F6977C File Offset: 0x00F6797C
		public UniTask EquipCurSelectedWeaponAsync()
		{
			PinballWeaponEquipView.<EquipCurSelectedWeaponAsync>d__38 <EquipCurSelectedWeaponAsync>d__;
			<EquipCurSelectedWeaponAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EquipCurSelectedWeaponAsync>d__.<>4__this = this;
			<EquipCurSelectedWeaponAsync>d__.<>1__state = -1;
			<EquipCurSelectedWeaponAsync>d__.<>t__builder.Start<PinballWeaponEquipView.<EquipCurSelectedWeaponAsync>d__38>(ref <EquipCurSelectedWeaponAsync>d__);
			return <EquipCurSelectedWeaponAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB37 RID: 260919 RVA: 0x00F697C0 File Offset: 0x00F679C0
		private void RefreshGridsByQuality(int quality)
		{
			if (quality <= 0)
			{
				return;
			}
			for (int i = 0; i < this.GridDataList.Count; i++)
			{
				if (this.GridDataList[i].GetTemplateIndex() == 1 && (this.GridDataList[i] as PinballWeaponMultiTemplateGridData).Data.WeaponData.Quality == quality)
				{
					this.RefreshGridByIndex(i);
				}
			}
		}

		// Token: 0x0603FB38 RID: 260920 RVA: 0x00F69828 File Offset: 0x00F67A28
		private void RefreshGridByWeaponIncId(int weaponIncId)
		{
			if (weaponIncId <= 0)
			{
				return;
			}
			int gridIndexByWeaponIncId = this.GetGridIndexByWeaponIncId(weaponIncId);
			if (gridIndexByWeaponIncId < 0)
			{
				return;
			}
			this.RefreshGridByIndex(gridIndexByWeaponIncId);
		}

		// Token: 0x0603FB39 RID: 260921 RVA: 0x00F6984E File Offset: 0x00F67A4E
		private void RefreshGridByIndex(int gridIndex)
		{
			if (gridIndex < 0)
			{
				return;
			}
			MultiTemplateScrollView weaponMultiTemplateScrollView = this.WeaponMultiTemplateScrollView;
			if (weaponMultiTemplateScrollView == null)
			{
				return;
			}
			weaponMultiTemplateScrollView.RefreshProxyDirectly(gridIndex);
		}

		// Token: 0x0603FB3A RID: 260922 RVA: 0x00F69868 File Offset: 0x00F67A68
		private int GetCurEquipWeaponIncId()
		{
			IPinballWeaponEquipViewData data = this.Data;
			PinballRoleDataBase pinballRoleDataBase = (data != null) ? data.RoleData : null;
			if (pinballRoleDataBase == null)
			{
				return 0;
			}
			PinballWeaponData weaponData = pinballRoleDataBase.GetWeaponData();
			if (weaponData == null)
			{
				return 0;
			}
			return weaponData.IncId;
		}

		// Token: 0x0603FB3B RID: 260923 RVA: 0x00F698A0 File Offset: 0x00F67AA0
		private PinballWeaponMultiTemplateGridData GetGridDataByWeaponIncId(int weaponIncId)
		{
			foreach (IMultiTemplateGridData multiTemplateGridData in this.GridDataList)
			{
				if (multiTemplateGridData.GetTemplateIndex() == 1)
				{
					PinballWeaponMultiTemplateGridData pinballWeaponMultiTemplateGridData = multiTemplateGridData as PinballWeaponMultiTemplateGridData;
					if (pinballWeaponMultiTemplateGridData.Data.WeaponData.IncId == weaponIncId)
					{
						return pinballWeaponMultiTemplateGridData;
					}
				}
			}
			return null;
		}

		// Token: 0x0603FB3C RID: 260924 RVA: 0x00F69918 File Offset: 0x00F67B18
		private int GetGridIndexByWeaponIncId(int weaponIncId)
		{
			for (int i = 0; i < this.GridDataList.Count; i++)
			{
				if (this.GridDataList[i].GetTemplateIndex() == 1 && (this.GridDataList[i] as PinballWeaponMultiTemplateGridData).Data.WeaponData.IncId == weaponIncId)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0603FB3D RID: 260925 RVA: 0x00F69978 File Offset: 0x00F67B78
		private IPinballItemSyncWeaponGridViewData BuildWeaponGridData(PinballWeaponData weaponData, bool canEquip, bool isCurRoleEquip)
		{
			int qualityId = PinballConfig.Instance.GetPinballWeaponConfigById(weaponData.Id).Value.QualityId;
			return new PinballItemSyncWeaponGridViewData
			{
				WeaponData = weaponData,
				IsSelected = false,
				CanEquip = canEquip,
				IsCurRoleEquip = isCurRoleEquip,
				QualityId = qualityId,
				OnStateChangeDelegate = new Action<IPinballItemToggleCallback>(this.OnWeaponGridStateChange),
				RoleId = this.Data.RoleData.GetId()
			};
		}

		// Token: 0x0603FB3E RID: 260926 RVA: 0x00F699F8 File Offset: 0x00F67BF8
		private void CheckToShowOverCapacityConfirm()
		{
			if (this.AllWeaponGridDataList.Count >= this.Capacity)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PinballWeaponOverCapacityConfirm);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					UiManager.Instance.OpenView(EUiViewName.PinballWeaponDecomposeView, null, null);
				};
				PinballController.Instance.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
			}
		}

		// Token: 0x0603FB3F RID: 260927 RVA: 0x00F69A60 File Offset: 0x00F67C60
		private void OnPinballWeaponLockChanged(int incId, bool bLock)
		{
			this.RefreshGridByWeaponIncId(incId);
		}

		// Token: 0x0603FB40 RID: 260928 RVA: 0x00F69A6C File Offset: 0x00F67C6C
		private void OnSortResult(List<IMultiTemplateGridData> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			this.UpdateGridData(dataList);
			if (this.SelectedGridData != null)
			{
				this.SelectedIndex = -1;
				for (int i = 0; i < this.GridDataList.Count; i++)
				{
					if (this.GridDataList[i] == this.SelectedGridData)
					{
						this.SelectedIndex = i;
						break;
					}
				}
			}
			else
			{
				this.SelectedIndex = -1;
			}
			if (!isOutSideChange)
			{
				this.RefreshGrids();
			}
		}

		// Token: 0x0603FB41 RID: 260929 RVA: 0x00F69AD4 File Offset: 0x00F67CD4
		private void OnWeaponGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = callbackParameter.View as PinballItemSyncWeaponGridView;
				this.SelectGrid(pinballItemSyncWeaponGridView.GridIndex);
			}
		}

		// Token: 0x0603FB42 RID: 260930 RVA: 0x00F69B04 File Offset: 0x00F67D04
		private void OnClickEquipButton()
		{
			IPinballWeaponEquipTipItemData curSelectedWeaponTipData = this.CurSelectedWeaponTipData;
			PinballWeaponData pinballWeaponData = (curSelectedWeaponTipData != null) ? curSelectedWeaponTipData.WeaponData : null;
			if (pinballWeaponData == null)
			{
				return;
			}
			int roleId = pinballWeaponData.RoleId;
			if (roleId > 0)
			{
				int num = roleId;
				IPinballWeaponEquipViewData data = this.Data;
				int? num2 = (data != null) ? new int?(data.RoleData.GetId()) : null;
				if (!(num == num2.GetValueOrDefault() & num2 != null))
				{
					this.OpenReplaceConfirmView();
					return;
				}
			}
			this.EquipCurSelectedWeapon();
		}

		// Token: 0x0603FB43 RID: 260931 RVA: 0x00F69B79 File Offset: 0x00F67D79
		private void OnClickContrastToggle(EToggleState state)
		{
			this.IsContrastEnabled = (state == EToggleState.ETT_Checked);
			this.RefreshCurEquipWeaponTipShowState();
		}

		// Token: 0x0603FB44 RID: 260932 RVA: 0x00F69B8B File Offset: 0x00F67D8B
		private void OnClickDecomposeButton()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballWeaponDecomposeView, null, null);
		}

		// Token: 0x0603FB45 RID: 260933 RVA: 0x00F69B9E File Offset: 0x00F67D9E
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FB46 RID: 260934 RVA: 0x00F69BA8 File Offset: 0x00F67DA8
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "WeaponGrid"))
			{
				return null;
			}
			if (configParams.Length < 2)
			{
				return null;
			}
			int num = int.Parse(configParams[1]);
			if (num < 0 || num >= this.GridDataList.Count)
			{
				return null;
			}
			MultiTemplateScrollView weaponMultiTemplateScrollView = this.WeaponMultiTemplateScrollView;
			PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = ((weaponMultiTemplateScrollView != null) ? weaponMultiTemplateScrollView.GetProxyByGridIndex(num) : null) as PinballItemSyncWeaponGridView;
			UUIItem uuiitem = (pinballItemSyncWeaponGridView != null) ? pinballItemSyncWeaponGridView.GetWeaponItemToggleRootUiItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04021455 RID: 136277
		private int SelectedIndex = -1;

		// Token: 0x04021456 RID: 136278
		private PinballWeaponMultiTemplateGridData SelectedGridData;

		// Token: 0x04021457 RID: 136279
		private IPinballWeaponEquipViewData Data;

		// Token: 0x04021458 RID: 136280
		private bool IsContrastEnabled;

		// Token: 0x04021459 RID: 136281
		private int Capacity;

		// Token: 0x0402145A RID: 136282
		protected List<IMultiTemplateGridData> GridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402145B RID: 136283
		protected List<IMultiTemplateGridData> CanEquipWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402145C RID: 136284
		protected List<IMultiTemplateGridData> CanNotEquipWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402145D RID: 136285
		protected List<IMultiTemplateGridData> AllWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402145E RID: 136286
		protected IPinballWeaponEquipTipItemData CurSelectedWeaponTipData;

		// Token: 0x0402145F RID: 136287
		protected IPinballWeaponEquipTipItemData CurEquipWeaponTipData;

		// Token: 0x04021460 RID: 136288
		protected PinballWeaponEquipTipItem CurEquipWeaponTipItem;

		// Token: 0x04021461 RID: 136289
		protected PinballWeaponEquipTipItem CurSelectedWeaponTipItem;

		// Token: 0x04021462 RID: 136290
		protected MultiTemplateScrollView WeaponMultiTemplateScrollView;

		// Token: 0x04021463 RID: 136291
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04021464 RID: 136292
		protected FilterSortEntrance<IMultiTemplateGridData> FilterSortEntrance;

		// Token: 0x0200C4D0 RID: 50384
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B63E RID: 243262
			CaptionItem,
			// Token: 0x0403B63F RID: 243263
			ContrastToggle,
			// Token: 0x0403B640 RID: 243264
			WeaponMultiTemplateScrollView,
			// Token: 0x0403B641 RID: 243265
			WeaponCountText,
			// Token: 0x0403B642 RID: 243266
			SortFilterItem,
			// Token: 0x0403B643 RID: 243267
			DecomposeButton,
			// Token: 0x0403B644 RID: 243268
			PaddingItem,
			// Token: 0x0403B645 RID: 243269
			CurEquipWeaponTipRootItem,
			// Token: 0x0403B646 RID: 243270
			CurEquipWeaponTipItem,
			// Token: 0x0403B647 RID: 243271
			CurSelectedWeaponTipRootItem,
			// Token: 0x0403B648 RID: 243272
			CurSelectedWeaponTipItem
		}
	}
}
