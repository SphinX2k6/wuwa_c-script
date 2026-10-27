using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E3B RID: 24123
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlFlightView : UiViewBase
	{
		// Token: 0x0603D55A RID: 251226 RVA: 0x00EC9182 File Offset: 0x00EC7382
		[NullableContext(1)]
		public SwordControlFlightView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603D55B RID: 251227 RVA: 0x00EC918C File Offset: 0x00EC738C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D55C RID: 251228 RVA: 0x00EC9218 File Offset: 0x00EC7418
		protected override UniTask OnBeforeStartAsync()
		{
			SwordControlFlightView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SwordControlFlightView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D55D RID: 251229 RVA: 0x00EC925C File Offset: 0x00EC745C
		protected override void OnStart()
		{
			this.BtnLeftButton.OnPressCallback = new Action(this.UpdateMoveRightAxis);
			this.BtnLeftButton.OnReleaseCallback = new Action(this.UpdateMoveRightAxis);
			this.BtnRightButton.OnPressCallback = new Action(this.UpdateMoveRightAxis);
			this.BtnRightButton.OnReleaseCallback = new Action(this.UpdateMoveRightAxis);
			SwordControlGroundAttackButton flightAttackButton = this.FlightAttackButton;
			if (flightAttackButton != null)
			{
				flightAttackButton.SetInteractive(true, false);
			}
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x0603D55E RID: 251230 RVA: 0x00EC92FC File Offset: 0x00EC74FC
		protected override void OnBeforeDestroy()
		{
			SwordControlFlightDirectionButton btnLeftButton = this.BtnLeftButton;
			if (btnLeftButton != null)
			{
				btnLeftButton.Destroy(null);
			}
			this.BtnLeftButton = null;
			SwordControlFlightDirectionButton btnRightButton = this.BtnRightButton;
			if (btnRightButton != null)
			{
				btnRightButton.Destroy(null);
			}
			this.BtnRightButton = null;
			SwordControlGroundAttackButton flightAttackButton = this.FlightAttackButton;
			if (flightAttackButton != null)
			{
				flightAttackButton.Destroy(null);
			}
			this.FlightAttackButton = null;
			this.RemoveListenHideAttackBtnTagChanged();
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
			this.RoleData = null;
		}

		// Token: 0x0603D55F RID: 251231 RVA: 0x00EC937D File Offset: 0x00EC757D
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlFlightView.HideBattleUiChildernList, false, true, 0);
		}

		// Token: 0x0603D560 RID: 251232 RVA: 0x00EC9397 File Offset: 0x00EC7597
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlFlightView.HideBattleUiChildernList, true, true, 0);
		}

		// Token: 0x0603D561 RID: 251233 RVA: 0x00EC93B1 File Offset: 0x00EC75B1
		private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
		{
			this.RefreshRoleData();
		}

		// Token: 0x0603D562 RID: 251234 RVA: 0x00EC93BC File Offset: 0x00EC75BC
		private void RefreshRoleData()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (this.RoleData == curRoleData)
			{
				this.RefreshAttackBtnVisible();
				return;
			}
			this.RemoveListenHideAttackBtnTagChanged();
			this.RoleData = curRoleData;
			this.ListenForHideAttackBtnTagChanged();
			this.RefreshAttackBtnVisible();
		}

		// Token: 0x0603D563 RID: 251235 RVA: 0x00EC9400 File Offset: 0x00EC7600
		private void ListenForHideAttackBtnTagChanged()
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				return;
			}
			this.HideSkillNorTagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(SwordControlFlightView.HideAttackBtnTagId), new BaseTagComponent.TTagSwitchedCallback(this.OnHideAttackBtnTagChanged), null);
		}

		// Token: 0x0603D564 RID: 251236 RVA: 0x00EC9447 File Offset: 0x00EC7647
		private void RemoveListenHideAttackBtnTagChanged()
		{
			ITagTask hideSkillNorTagTask = this.HideSkillNorTagTask;
			if (hideSkillNorTagTask != null)
			{
				hideSkillNorTagTask.EndTask();
			}
			this.HideSkillNorTagTask = null;
		}

		// Token: 0x0603D565 RID: 251237 RVA: 0x00EC9461 File Offset: 0x00EC7661
		private void OnHideAttackBtnTagChanged(int tagId, bool tagExists)
		{
			this.SetAttackBtnVisible(!tagExists);
		}

		// Token: 0x0603D566 RID: 251238 RVA: 0x00EC9470 File Offset: 0x00EC7670
		private void RefreshAttackBtnVisible()
		{
			BattleUiRoleData roleData = this.RoleData;
			bool? flag;
			if (roleData == null)
			{
				flag = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				flag = ((gameplayTagComponent != null) ? new bool?(gameplayTagComponent.HasTag(SwordControlFlightView.HideAttackBtnTagId)) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			this.SetAttackBtnVisible(!valueOrDefault);
		}

		// Token: 0x0603D567 RID: 251239 RVA: 0x00EC94C8 File Offset: 0x00EC76C8
		private void SetAttackBtnVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0603D568 RID: 251240 RVA: 0x00EC94DC File Offset: 0x00EC76DC
		private void UpdateMoveRightAxis()
		{
			SwordControlFlightDirectionButton btnLeftButton = this.BtnLeftButton;
			bool flag = btnLeftButton != null && btnLeftButton.IsPressed;
			SwordControlFlightDirectionButton btnRightButton = this.BtnRightButton;
			bool flag2 = btnRightButton != null && btnRightButton.IsPressed;
			float value = 0f;
			if (flag && !flag2)
			{
				value = -1f;
			}
			else if (flag2 && !flag)
			{
				value = 1f;
			}
			InputController.Instance.InputAxis(EInputAxis.MoveRight, value, false);
		}

		// Token: 0x0401FFE6 RID: 131046
		private static readonly int HideAttackBtnTagId = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏普攻按键"];

		// Token: 0x0401FFE7 RID: 131047
		[Nullable(1)]
		private static readonly IReadOnlyList<EBattleUiChild> HideBattleUiChildernList = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.SkillButton,
			EBattleUiChild.GamepadSkillButton,
			EBattleUiChild.Joystick
		});

		// Token: 0x0401FFE8 RID: 131048
		private SwordControlFlightDirectionButton BtnLeftButton;

		// Token: 0x0401FFE9 RID: 131049
		private SwordControlFlightDirectionButton BtnRightButton;

		// Token: 0x0401FFEA RID: 131050
		private SwordControlGroundAttackButton FlightAttackButton;

		// Token: 0x0401FFEB RID: 131051
		private BattleUiRoleData RoleData;

		// Token: 0x0401FFEC RID: 131052
		private ITagTask HideSkillNorTagTask;

		// Token: 0x0200C1B9 RID: 49593
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A8A6 RID: 239782
			BtnLeft,
			// Token: 0x0403A8A7 RID: 239783
			BtnRight,
			// Token: 0x0403A8A8 RID: 239784
			BtnSkillNor
		}
	}
}
