using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200582E RID: 22574
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopLevelToggleItem : UiPanelBase
	{
		// Token: 0x06037B0E RID: 228110 RVA: 0x00F9211C File Offset: 0x00F9031C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTogSelf))
			};
		}

		// Token: 0x06037B0F RID: 228111 RVA: 0x00F9224B File Offset: 0x00F9044B
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			EventSystem.Instance.Add<int>(EEventName.OnCoopLevelToggleClick, new Action<int>(this.HandleSelected));
		}

		// Token: 0x06037B10 RID: 228112 RVA: 0x00F92286 File Offset: 0x00F90486
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelToggleClick, new Action<int>(this.HandleSelected));
		}

		// Token: 0x06037B11 RID: 228113 RVA: 0x00F922A4 File Offset: 0x00F904A4
		public void SetClickCallBack(Action<CoopLevelData> func)
		{
			this.OnClickTogCallBack = func;
		}

		// Token: 0x06037B12 RID: 228114 RVA: 0x00F922AD File Offset: 0x00F904AD
		public void SetCanExecuteChangeFunc(Func<int, bool> func)
		{
			this.CanExecuteChangeFuncField = func;
		}

		// Token: 0x06037B13 RID: 228115 RVA: 0x00F922B6 File Offset: 0x00F904B6
		private void OnClickTogSelf(EToggleState _)
		{
			if (this.OnClickTogCallBack != null)
			{
				this.OnClickTogCallBack(this.Data);
			}
		}

		// Token: 0x06037B14 RID: 228116 RVA: 0x00F922D1 File Offset: 0x00F904D1
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeFuncField != null && this.CanExecuteChangeFuncField(this.Data.Level);
		}

		// Token: 0x06037B15 RID: 228117 RVA: 0x00F922F4 File Offset: 0x00F904F4
		public void Refresh(CoopLevelData data)
		{
			this.Data = data;
			CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(data.LevelId);
			this.UpdateStatus(data.State);
			base.GetItem(6).SetUIActive(data.State == ECoopLevelStatus.Reward);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), (coopConfigById != null) ? coopConfigById.GetValueOrDefault().EventTitle : null, Array.Empty<object>());
		}

		// Token: 0x06037B16 RID: 228118 RVA: 0x00F9236C File Offset: 0x00F9056C
		public void UpdateStatus(ECoopLevelStatus state)
		{
			base.GetItem(10).SetUIActive(false);
			switch (state)
			{
			case ECoopLevelStatus.Lock:
				base.GetItem(3).SetUIActive(true);
				base.GetItem(4).SetUIActive(false);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
				base.GetText(5).SetFontOutlineColor(FColor.FromHex("4836a0"));
				return;
			case ECoopLevelStatus.Doing:
				base.GetItem(3).SetUIActive(true);
				base.GetItem(4).SetUIActive(false);
				base.GetItem(7).SetUIActive(true);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(false);
				base.GetItem(10).SetUIActive(this.Data.IsShowDoingNew);
				base.GetText(5).SetFontOutlineColor(FColor.FromHex("4836a0"));
				return;
			case ECoopLevelStatus.Reward:
				base.GetItem(3).SetUIActive(false);
				base.GetItem(4).SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(true);
				base.GetText(5).SetFontOutlineColor(FColor.FromHex("52402c"));
				return;
			case ECoopLevelStatus.Done:
				base.GetItem(3).SetUIActive(false);
				base.GetItem(4).SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(true);
				base.GetText(5).SetFontOutlineColor(FColor.FromHex("52402c"));
				return;
			default:
				return;
			}
		}

		// Token: 0x06037B17 RID: 228119 RVA: 0x00F92519 File Offset: 0x00F90719
		public void UnSelected()
		{
			this.SetToggleState(false);
		}

		// Token: 0x06037B18 RID: 228120 RVA: 0x00F92522 File Offset: 0x00F90722
		private void HandleSelected(int id)
		{
			CoopLevelData data = this.Data;
			if (data == null || data.LevelId != id)
			{
				this.OnDeselected();
				return;
			}
			this.OnSelected();
			UiNavigationNewController instance = UiNavigationNewController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetNavigationFocusForView(this.RootItem, true, true, false);
		}

		// Token: 0x06037B19 RID: 228121 RVA: 0x00F92561 File Offset: 0x00F90761
		public void SetRightPanelShow(bool isShow)
		{
			base.GetItem(1).SetUIActive(isShow);
			base.GetItem(2).SetUIActive(isShow);
		}

		// Token: 0x06037B1A RID: 228122 RVA: 0x00F92580 File Offset: 0x00F90780
		private void OnSelected()
		{
			if (this.Data.IsShowDoingNew)
			{
				ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.CoopRoleNewLevelRedDot) as ServerStorageSet;
				base.GetItem(10).SetUIActive(false);
				serverStorageSet.Add(this.Data.LevelId);
				CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(this.Data.LevelId);
				if (coopConfigById != null)
				{
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, coopConfigById.Value.ActivityId);
				}
			}
			this.SetToggleState(true);
		}

		// Token: 0x06037B1B RID: 228123 RVA: 0x00F9260E File Offset: 0x00F9080E
		private void OnDeselected()
		{
			this.SetToggleState(false);
		}

		// Token: 0x06037B1C RID: 228124 RVA: 0x00F92618 File Offset: 0x00F90818
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x0401D637 RID: 120375
		[Nullable(2)]
		public CoopLevelData Data;

		// Token: 0x0401D638 RID: 120376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<CoopLevelData> OnClickTogCallBack;

		// Token: 0x0401D639 RID: 120377
		[Nullable(2)]
		private Func<int, bool> CanExecuteChangeFuncField;
	}
}
