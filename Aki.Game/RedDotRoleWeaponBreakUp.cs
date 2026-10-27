using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003424 RID: 13348
public class RedDotRoleWeaponBreakUp : RedDotBase
{
	// Token: 0x0601CD94 RID: 118164 RVA: 0x0080C92E File Offset: 0x0080AB2E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD95 RID: 118165 RVA: 0x0080C934 File Offset: 0x0080AB34
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WeaponLevelUp, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeaponBreakUp, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601CD96 RID: 118166 RVA: 0x0080C998 File Offset: 0x0080AB98
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WeaponLevelUp, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeaponBreakUp, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601CD97 RID: 118167 RVA: 0x0080C9F9 File Offset: 0x0080ABF9
	protected override bool OnCheck(int uId = 0)
	{
		return WeaponModel.Instance.RedDotWeaponBreachCondition(uId) || WeaponModel.Instance.RedDotWeaponResonanceConditionByRole(uId) || WeaponSkinModel.Instance.RedDotWeaponSkinCondition(uId);
	}

	// Token: 0x0601CD98 RID: 118168 RVA: 0x0080CA24 File Offset: 0x0080AC24
	private void OnWeaponResonanceSuccess(int roleId, int weaponId)
	{
		base.EventCheckWithUid(roleId);
	}
}
