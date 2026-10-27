using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02001F3B RID: 7995
public class SlowTimeHandle : HudUnitHandleBase
{
	// Token: 0x0600F6E1 RID: 63201 RVA: 0x003BA777 File Offset: 0x003B8977
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.IsSlowTimeState = BattleUiModel.Instance.GetRoleSpecialState(ERoleSpecialState.SlowTimeWorld);
	}

	// Token: 0x0600F6E2 RID: 63202 RVA: 0x003BA790 File Offset: 0x003B8990
	protected override void OnDestroyed()
	{
		this.DestroyUnit();
	}

	// Token: 0x0600F6E3 RID: 63203 RVA: 0x003BA798 File Offset: 0x003B8998
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
		EventSystem.Instance.Add<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnRoleSpecialStateChanged));
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged), null);
		FormationAttributeController.Instance.AddMaxListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged), null);
	}

	// Token: 0x0600F6E4 RID: 63204 RVA: 0x003BA810 File Offset: 0x003B8A10
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
		EventSystem.Instance.Remove<ERoleSpecialState, bool>(EEventName.BattleUiRoleSpecialStateChanged, new Action<ERoleSpecialState, bool>(this.OnRoleSpecialStateChanged));
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged));
		FormationAttributeController.Instance.RemoveMaxListener(EFormationAttributeId.TimeScaleStrength, new TValueListener(this.OnStrengthChanged));
	}

	// Token: 0x0600F6E5 RID: 63205 RVA: 0x003BA885 File Offset: 0x003B8A85
	private void OnSwitchSelfCenteredMode(ESelfCenteredMode selfCenteredMode, float globalTimeDilation)
	{
		this.IsInSelfCenteredMode = (selfCenteredMode == ESelfCenteredMode.Skill);
		this.RefreshUnitVisible();
	}

	// Token: 0x0600F6E6 RID: 63206 RVA: 0x003BA897 File Offset: 0x003B8A97
	private void OnRoleSpecialStateChanged(ERoleSpecialState state, bool enable)
	{
		if (state != ERoleSpecialState.SlowTimeWorld)
		{
			return;
		}
		this.IsSlowTimeState = enable;
		this.RefreshUnitVisible();
	}

	// Token: 0x0600F6E7 RID: 63207 RVA: 0x003BA8AC File Offset: 0x003B8AAC
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

	// Token: 0x0600F6E8 RID: 63208 RVA: 0x003BA907 File Offset: 0x003B8B07
	private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
	{
		this.UpdateStrength();
	}

	// Token: 0x0600F6E9 RID: 63209 RVA: 0x003BA910 File Offset: 0x003B8B10
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

	// Token: 0x0600F6EA RID: 63210 RVA: 0x003BA960 File Offset: 0x003B8B60
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

	// Token: 0x0600F6EB RID: 63211 RVA: 0x003BA9B0 File Offset: 0x003B8BB0
	private void CheckDestroyUnit()
	{
		if (!this.NeedShow && this.IsFull)
		{
			this.DestroyUnit();
		}
	}

	// Token: 0x0600F6EC RID: 63212 RVA: 0x003BA9C8 File Offset: 0x003B8BC8
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

	// Token: 0x04007250 RID: 29264
	[Nullable(2)]
	private SlowTimeUnit Unit;

	// Token: 0x04007251 RID: 29265
	private bool IsInSelfCenteredMode;

	// Token: 0x04007252 RID: 29266
	private bool IsSlowTimeState;

	// Token: 0x04007253 RID: 29267
	private bool NeedShow;

	// Token: 0x04007254 RID: 29268
	private bool IsFull;
}
