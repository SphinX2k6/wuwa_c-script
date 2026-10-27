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
	// Token: 0x020068DE RID: 26846
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopLevelToggleItem : UiPanelBase
	{
		// Token: 0x06042FB6 RID: 274358 RVA: 0x01050AF4 File Offset: 0x0104ECF4
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

		// Token: 0x06042FB7 RID: 274359 RVA: 0x01050C23 File Offset: 0x0104EE23
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			EventSystem.Instance.Add<int>(EEventName.OnCoopLevelToggleClick, new Action<int>(this.HandleSelected));
		}

		// Token: 0x06042FB8 RID: 274360 RVA: 0x01050C5E File Offset: 0x0104EE5E
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelToggleClick, new Action<int>(this.HandleSelected));
		}

		// Token: 0x06042FB9 RID: 274361 RVA: 0x01050C7C File Offset: 0x0104EE7C
		public void SetClickCallBack(Action<CoopLevelData> func)
		{
			this.OnClickTogCallBack = func;
		}

		// Token: 0x06042FBA RID: 274362 RVA: 0x01050C85 File Offset: 0x0104EE85
		public void SetCanExecuteChangeFunc(Func<int, bool> func)
		{
			this.CanExecuteChangeFuncField = func;
		}

		// Token: 0x06042FBB RID: 274363 RVA: 0x01050C8E File Offset: 0x0104EE8E
		private void OnClickTogSelf(EToggleState _)
		{
			if (this.OnClickTogCallBack != null)
			{
				this.OnClickTogCallBack(this.Data);
			}
		}

		// Token: 0x06042FBC RID: 274364 RVA: 0x01050CA9 File Offset: 0x0104EEA9
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeFuncField != null && this.CanExecuteChangeFuncField(this.Data.Level);
		}

		// Token: 0x06042FBD RID: 274365 RVA: 0x01050CCC File Offset: 0x0104EECC
		public void Refresh(CoopLevelData data)
		{
			this.Data = data;
			CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(data.LevelId);
			this.UpdateStatus(data.State);
			base.GetItem(6).SetUIActive(data.State == ECoopLevelStatus.Reward);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), (coopConfigById != null) ? coopConfigById.GetValueOrDefault().EventTitle : null, Array.Empty<object>());
		}

		// Token: 0x06042FBE RID: 274366 RVA: 0x01050D44 File Offset: 0x0104EF44
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

		// Token: 0x06042FBF RID: 274367 RVA: 0x01050EF1 File Offset: 0x0104F0F1
		public void UnSelected()
		{
			this.SetToggleState(false);
		}

		// Token: 0x06042FC0 RID: 274368 RVA: 0x01050EFA File Offset: 0x0104F0FA
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

		// Token: 0x06042FC1 RID: 274369 RVA: 0x01050F39 File Offset: 0x0104F139
		public void SetRightPanelShow(bool isShow)
		{
			base.GetItem(1).SetUIActive(isShow);
			base.GetItem(2).SetUIActive(isShow);
		}

		// Token: 0x06042FC2 RID: 274370 RVA: 0x01050F58 File Offset: 0x0104F158
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

		// Token: 0x06042FC3 RID: 274371 RVA: 0x01050FE6 File Offset: 0x0104F1E6
		private void OnDeselected()
		{
			this.SetToggleState(false);
		}

		// Token: 0x06042FC4 RID: 274372 RVA: 0x01050FF0 File Offset: 0x0104F1F0
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x04022DDB RID: 142811
		[Nullable(2)]
		public CoopLevelData Data;

		// Token: 0x04022DDC RID: 142812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<CoopLevelData> OnClickTogCallBack;

		// Token: 0x04022DDD RID: 142813
		[Nullable(2)]
		private Func<int, bool> CanExecuteChangeFuncField;
	}
}
