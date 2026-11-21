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
	// Token: 0x02004E20 RID: 20000
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlFlightView : UiViewBase
	{
		// Token: 0x060324EA RID: 206058 RVA: 0x00E1A6EE File Offset: 0x00E188EE
		[NullableContext(1)]
		public SwordControlFlightView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060324EB RID: 206059 RVA: 0x00E1A6F8 File Offset: 0x00E188F8
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

		// Token: 0x060324EC RID: 206060 RVA: 0x00E1A784 File Offset: 0x00E18984
		protected override UniTask OnBeforeStartAsync()
		{
			SwordControlFlightView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SwordControlFlightView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060324ED RID: 206061 RVA: 0x00E1A7C8 File Offset: 0x00E189C8
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

		// Token: 0x060324EE RID: 206062 RVA: 0x00E1A868 File Offset: 0x00E18A68
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

		// Token: 0x060324EF RID: 206063 RVA: 0x00E1A8E9 File Offset: 0x00E18AE9
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlFlightView.HideBattleUiChildernList, false, true, 0);
		}

		// Token: 0x060324F0 RID: 206064 RVA: 0x00E1A903 File Offset: 0x00E18B03
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlFlightView.HideBattleUiChildernList, true, true, 0);
		}

		// Token: 0x060324F1 RID: 206065 RVA: 0x00E1A91D File Offset: 0x00E18B1D
		private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
		{
			this.RefreshRoleData();
		}

		// Token: 0x060324F2 RID: 206066 RVA: 0x00E1A928 File Offset: 0x00E18B28
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

		// Token: 0x060324F3 RID: 206067 RVA: 0x00E1A96C File Offset: 0x00E18B6C
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

		// Token: 0x060324F4 RID: 206068 RVA: 0x00E1A9B3 File Offset: 0x00E18BB3
		private void RemoveListenHideAttackBtnTagChanged()
		{
			ITagTask hideSkillNorTagTask = this.HideSkillNorTagTask;
			if (hideSkillNorTagTask != null)
			{
				hideSkillNorTagTask.EndTask();
			}
			this.HideSkillNorTagTask = null;
		}

		// Token: 0x060324F5 RID: 206069 RVA: 0x00E1A9CD File Offset: 0x00E18BCD
		private void OnHideAttackBtnTagChanged(int tagId, bool tagExists)
		{
			this.SetAttackBtnVisible(!tagExists);
		}

		// Token: 0x060324F6 RID: 206070 RVA: 0x00E1A9DC File Offset: 0x00E18BDC
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

		// Token: 0x060324F7 RID: 206071 RVA: 0x00E1AA34 File Offset: 0x00E18C34
		private void SetAttackBtnVisible(bool visible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060324F8 RID: 206072 RVA: 0x00E1AA48 File Offset: 0x00E18C48
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

		// Token: 0x0401AAAD RID: 109229
		private static readonly int HideAttackBtnTagId = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏按钮功能.隐藏普攻按键"];

		// Token: 0x0401AAAE RID: 109230
		[Nullable(1)]
		private static readonly IReadOnlyList<EBattleUiChild> HideBattleUiChildernList = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.SkillButton,
			EBattleUiChild.GamepadSkillButton,
			EBattleUiChild.Joystick
		});

		// Token: 0x0401AAAF RID: 109231
		private SwordControlFlightDirectionButton BtnLeftButton;

		// Token: 0x0401AAB0 RID: 109232
		private SwordControlFlightDirectionButton BtnRightButton;

		// Token: 0x0401AAB1 RID: 109233
		private SwordControlGroundAttackButton FlightAttackButton;

		// Token: 0x0401AAB2 RID: 109234
		private BattleUiRoleData RoleData;

		// Token: 0x0401AAB3 RID: 109235
		private ITagTask HideSkillNorTagTask;

		// Token: 0x0200ABC8 RID: 43976
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035298 RID: 217752
			BtnLeft,
			// Token: 0x04035299 RID: 217753
			BtnRight,
			// Token: 0x0403529A RID: 217754
			BtnSkillNor
		}
	}
}
