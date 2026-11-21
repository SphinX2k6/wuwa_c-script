using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020013FD RID: 5117
public class SlowTimeHandle : HudUnitHandleBase
{
	// Token: 0x0600CB00 RID: 51968 RVA: 0x003C6263 File Offset: 0x003C4463
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.IsSlowTimeState = BattleUiModel.Instance.GetRoleSpecialState(ERoleSpecialState.SlowTimeWorld);
	}

	// Token: 0x0600CB01 RID: 51969 RVA: 0x003C627C File Offset: 0x003C447C
	protected override void OnDestroyed()
	{
		this.DestroyUnit();
	}

	// Token: 0x0600CB02 RID: 51970 RVA: 0x003C6284 File Offset: 0x003C4484
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
		EventSystem.Instance.Add<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnRoleSpecialStateChanged));
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged), null);
	}

	// Token: 0x0600CB03 RID: 51971 RVA: 0x003C62FC File Offset: 0x003C44FC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
		EventSystem.Instance.Remove<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnRoleSpecialStateChanged));
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged));
	}

	// Token: 0x0600CB04 RID: 51972 RVA: 0x003C6371 File Offset: 0x003C4571
	private void OnSwitchSelfCenteredMode(ESelfCenteredMode selfCenteredMode, float globalTimeDilation)
	{
		this.IsInSelfCenteredMode = (selfCenteredMode == ESelfCenteredMode.Skill);
		this.RefreshUnitVisible();
	}

	// Token: 0x0600CB05 RID: 51973 RVA: 0x003C6383 File Offset: 0x003C4583
	private void OnRoleSpecialStateChanged(ERoleSpecialState state, bool enable)
	{
		if (state != ERoleSpecialState.SlowTimeWorld)
		{
			return;
		}
		this.IsSlowTimeState = enable;
		this.RefreshUnitVisible();
	}

	// Token: 0x0600CB06 RID: 51974 RVA: 0x003C6398 File Offset: 0x003C4598
	private void RefreshUnitVisible()
	{
		this.NeedShow = (this.IsInSelfCenteredMode || this.IsSlowTimeState);
		if (this.NeedShow)
		{
			this.NewUnit();
			SlowTimeUnit unit = this.Unit;
			if (unit == null)
			{
				return;
			}
			unit.SetTranslucence(false);
			return;
		}
		else
		{
			this.CheckDestroyUnit();
			SlowTimeUnit unit2 = this.Unit;
			if (unit2 == null)
			{
				return;
			}
			unit2.SetTranslucence(true);
			return;
		}
	}

	// Token: 0x0600CB07 RID: 51975 RVA: 0x003C63F3 File Offset: 0x003C45F3
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.UpdateStrength();
	}

	// Token: 0x0600CB08 RID: 51976 RVA: 0x003C63FC File Offset: 0x003C45FC
	private void UpdateStrength()
	{
		float max = FormationAttributeController.Instance.GetMax(EFormationAttributeId.TimeScaleStrength);
		float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.TimeScaleStrength);
		this.IsFull = (value >= max);
		SlowTimeUnit unit = this.Unit;
		if (unit != null)
		{
			unit.UpdateProgress(value, max);
		}
		this.CheckDestroyUnit();
	}

	// Token: 0x0600CB09 RID: 51977 RVA: 0x003C644C File Offset: 0x003C464C
	private void NewUnit()
	{
		if (this.Unit != null)
		{
			return;
		}
		base.NewHudUnitWithReturn<SlowTimeUnit>(typeof(SlowTimeUnit), "UiView_SlowMotionProgress", out this.Unit, true, delegate(SlowTimeUnit _)
		{
			this.UpdateStrength();
			if (!this.NeedShow)
			{
				SlowTimeUnit unit = this.Unit;
				if (unit == null)
				{
					return;
				}
				unit.SetTranslucence(true);
			}
		}, false);
		EventSystem.Instance.Emit<bool>(EEventName.BattleUiSlowTimeVisibleChanged, true);
	}

	// Token: 0x0600CB0A RID: 51978 RVA: 0x003C649C File Offset: 0x003C469C
	private void CheckDestroyUnit()
	{
		if (!this.NeedShow && this.IsFull)
		{
			this.DestroyUnit();
		}
	}

	// Token: 0x0600CB0B RID: 51979 RVA: 0x003C64B4 File Offset: 0x003C46B4
	private void DestroyUnit()
	{
		if (this.Unit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.Unit);
		this.Unit = null;
		EventSystem.Instance.Emit<bool>(EEventName.BattleUiSlowTimeVisibleChanged, false);
	}

	// Token: 0x04007331 RID: 29489
	[Nullable(2)]
	private SlowTimeUnit Unit;

	// Token: 0x04007332 RID: 29490
	private bool IsInSelfCenteredMode;

	// Token: 0x04007333 RID: 29491
	private bool IsSlowTimeState;

	// Token: 0x04007334 RID: 29492
	private bool NeedShow;

	// Token: 0x04007335 RID: 29493
	private bool IsFull;
}
