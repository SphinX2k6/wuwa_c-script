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
	// Token: 0x02005264 RID: 21092
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipView : UiViewBase
	{
		// Token: 0x060347E2 RID: 215010 RVA: 0x00EAFD18 File Offset: 0x00EADF18
		public PinballWeaponEquipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060347E3 RID: 215011 RVA: 0x00EAFD54 File Offset: 0x00EADF54
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

		// Token: 0x060347E4 RID: 215012 RVA: 0x00EAFF4C File Offset: 0x00EAE14C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponEquipView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponEquipView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060347E5 RID: 215013 RVA: 0x00EAFF8F File Offset: 0x00EAE18F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x060347E6 RID: 215014 RVA: 0x00EAFFAD File Offset: 0x00EAE1AD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.OnPinballWeaponLockChanged, new Action<int, bool>(this.OnPinballWeaponLockChanged));
		}

		// Token: 0x060347E7 RID: 215015 RVA: 0x00EAFFCC File Offset: 0x00EAE1CC
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

		// Token: 0x060347E8 RID: 215016 RVA: 0x00EB0063 File Offset: 0x00EAE263
		protected override void OnAfterShow()
		{
			this.CheckToShowOverCapacityConfirm();
		}

		// Token: 0x060347E9 RID: 215017 RVA: 0x00EB006C File Offset: 0x00EAE26C
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

		// Token: 0x060347EA RID: 215018 RVA: 0x00EB0144 File Offset: 0x00EAE344
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

		// Token: 0x060347EB RID: 215019 RVA: 0x00EB02DC File Offset: 0x00EAE4DC
		protected void UpdateWeaponGridDataIsCurRoleEquip(PinballWeaponMultiTemplateGridData weaponGridData)
		{
			IPinballItemSyncWeaponGridViewData data = weaponGridData.Data;
			int roleId = data.WeaponData.RoleId;
			IPinballWeaponEquipViewData data2 = this.Data;
			int? num = (data2 != null) ? new int?(data2.RoleData.GetId()) : null;
			data.IsCurRoleEquip = (roleId == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x060347EC RID: 215020 RVA: 0x00EB0338 File Offset: 0x00EAE538
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

		// Token: 0x060347ED RID: 215021 RVA: 0x00EB03A4 File Offset: 0x00EAE5A4
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

		// Token: 0x060347EE RID: 215022 RVA: 0x00EB0438 File Offset: 0x00EAE638
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

		// Token: 0x060347EF RID: 215023 RVA: 0x00EB048C File Offset: 0x00EAE68C
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

		// Token: 0x060347F0 RID: 215024 RVA: 0x00EB04BD File Offset: 0x00EAE6BD
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

		// Token: 0x060347F1 RID: 215025 RVA: 0x00EB04DE File Offset: 0x00EAE6DE
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

		// Token: 0x060347F2 RID: 215026 RVA: 0x00EB04FF File Offset: 0x00EAE6FF
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

		// Token: 0x060347F3 RID: 215027 RVA: 0x00EB0524 File Offset: 0x00EAE724
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

		// Token: 0x060347F4 RID: 215028 RVA: 0x00EB0578 File Offset: 0x00EAE778
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

		// Token: 0x060347F5 RID: 215029 RVA: 0x00EB0608 File Offset: 0x00EAE808
		public void EquipCurSelectedWeapon()
		{
			UiAsyncTask task = new UiAsyncTask("EquipCurSelectedWeapon", new Func<UniTask>(this.EquipCurSelectedWeaponAsync), null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x060347F6 RID: 215030 RVA: 0x00EB063C File Offset: 0x00EAE83C
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

		// Token: 0x060347F7 RID: 215031 RVA: 0x00EB06D8 File Offset: 0x00EAE8D8
		public UniTask EquipCurSelectedWeaponAsync()
		{
			PinballWeaponEquipView.<EquipCurSelectedWeaponAsync>d__38 <EquipCurSelectedWeaponAsync>d__;
			<EquipCurSelectedWeaponAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EquipCurSelectedWeaponAsync>d__.<>4__this = this;
			<EquipCurSelectedWeaponAsync>d__.<>1__state = -1;
			<EquipCurSelectedWeaponAsync>d__.<>t__builder.Start<PinballWeaponEquipView.<EquipCurSelectedWeaponAsync>d__38>(ref <EquipCurSelectedWeaponAsync>d__);
			return <EquipCurSelectedWeaponAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060347F8 RID: 215032 RVA: 0x00EB071C File Offset: 0x00EAE91C
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

		// Token: 0x060347F9 RID: 215033 RVA: 0x00EB0784 File Offset: 0x00EAE984
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

		// Token: 0x060347FA RID: 215034 RVA: 0x00EB07AA File Offset: 0x00EAE9AA
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

		// Token: 0x060347FB RID: 215035 RVA: 0x00EB07C4 File Offset: 0x00EAE9C4
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

		// Token: 0x060347FC RID: 215036 RVA: 0x00EB07FC File Offset: 0x00EAE9FC
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

		// Token: 0x060347FD RID: 215037 RVA: 0x00EB0874 File Offset: 0x00EAEA74
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

		// Token: 0x060347FE RID: 215038 RVA: 0x00EB08D4 File Offset: 0x00EAEAD4
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

		// Token: 0x060347FF RID: 215039 RVA: 0x00EB0954 File Offset: 0x00EAEB54
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

		// Token: 0x06034800 RID: 215040 RVA: 0x00EB09BC File Offset: 0x00EAEBBC
		private void OnPinballWeaponLockChanged(int incId, bool bLock)
		{
			this.RefreshGridByWeaponIncId(incId);
		}

		// Token: 0x06034801 RID: 215041 RVA: 0x00EB09C8 File Offset: 0x00EAEBC8
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

		// Token: 0x06034802 RID: 215042 RVA: 0x00EB0A30 File Offset: 0x00EAEC30
		private void OnWeaponGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = callbackParameter.View as PinballItemSyncWeaponGridView;
				this.SelectGrid(pinballItemSyncWeaponGridView.GridIndex);
			}
		}

		// Token: 0x06034803 RID: 215043 RVA: 0x00EB0A60 File Offset: 0x00EAEC60
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

		// Token: 0x06034804 RID: 215044 RVA: 0x00EB0AD5 File Offset: 0x00EAECD5
		private void OnClickContrastToggle(EToggleState state)
		{
			this.IsContrastEnabled = (state == EToggleState.ETT_Checked);
			this.RefreshCurEquipWeaponTipShowState();
		}

		// Token: 0x06034805 RID: 215045 RVA: 0x00EB0AE7 File Offset: 0x00EAECE7
		private void OnClickDecomposeButton()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballWeaponDecomposeView, null, null);
		}

		// Token: 0x06034806 RID: 215046 RVA: 0x00EB0AFA File Offset: 0x00EAECFA
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034807 RID: 215047 RVA: 0x00EB0B04 File Offset: 0x00EAED04
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

		// Token: 0x0401BD84 RID: 114052
		private int SelectedIndex = -1;

		// Token: 0x0401BD85 RID: 114053
		private PinballWeaponMultiTemplateGridData SelectedGridData;

		// Token: 0x0401BD86 RID: 114054
		private IPinballWeaponEquipViewData Data;

		// Token: 0x0401BD87 RID: 114055
		private bool IsContrastEnabled;

		// Token: 0x0401BD88 RID: 114056
		private int Capacity;

		// Token: 0x0401BD89 RID: 114057
		protected List<IMultiTemplateGridData> GridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BD8A RID: 114058
		protected List<IMultiTemplateGridData> CanEquipWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BD8B RID: 114059
		protected List<IMultiTemplateGridData> CanNotEquipWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BD8C RID: 114060
		protected List<IMultiTemplateGridData> AllWeaponGridDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401BD8D RID: 114061
		protected IPinballWeaponEquipTipItemData CurSelectedWeaponTipData;

		// Token: 0x0401BD8E RID: 114062
		protected IPinballWeaponEquipTipItemData CurEquipWeaponTipData;

		// Token: 0x0401BD8F RID: 114063
		protected PinballWeaponEquipTipItem CurEquipWeaponTipItem;

		// Token: 0x0401BD90 RID: 114064
		protected PinballWeaponEquipTipItem CurSelectedWeaponTipItem;

		// Token: 0x0401BD91 RID: 114065
		protected MultiTemplateScrollView WeaponMultiTemplateScrollView;

		// Token: 0x0401BD92 RID: 114066
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401BD93 RID: 114067
		protected FilterSortEntrance<IMultiTemplateGridData> FilterSortEntrance;

		// Token: 0x0200AEB7 RID: 44727
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035FA0 RID: 221088
			CaptionItem,
			// Token: 0x04035FA1 RID: 221089
			ContrastToggle,
			// Token: 0x04035FA2 RID: 221090
			WeaponMultiTemplateScrollView,
			// Token: 0x04035FA3 RID: 221091
			WeaponCountText,
			// Token: 0x04035FA4 RID: 221092
			SortFilterItem,
			// Token: 0x04035FA5 RID: 221093
			DecomposeButton,
			// Token: 0x04035FA6 RID: 221094
			PaddingItem,
			// Token: 0x04035FA7 RID: 221095
			CurEquipWeaponTipRootItem,
			// Token: 0x04035FA8 RID: 221096
			CurEquipWeaponTipItem,
			// Token: 0x04035FA9 RID: 221097
			CurSelectedWeaponTipRootItem,
			// Token: 0x04035FAA RID: 221098
			CurSelectedWeaponTipItem
		}
	}
}
