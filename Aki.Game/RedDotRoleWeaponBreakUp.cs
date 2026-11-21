using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002996 RID: 10646
public class RedDotRoleWeaponBreakUp : RedDotBase
{
	// Token: 0x0601AA8C RID: 109196 RVA: 0x00832EF2 File Offset: 0x008310F2
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA8D RID: 109197 RVA: 0x00832EF8 File Offset: 0x008310F8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WeaponLevelUp, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeaponBreakUp, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601AA8E RID: 109198 RVA: 0x00832F5C File Offset: 0x0083115C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WeaponLevelUp, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeaponBreakUp, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601AA8F RID: 109199 RVA: 0x00832FBD File Offset: 0x008311BD
	protected override bool OnCheck(int uId = 0)
	{
		return WeaponModel.Instance.RedDotWeaponBreachCondition(uId) || WeaponModel.Instance.RedDotWeaponResonanceConditionByRole(uId) || WeaponSkinModel.Instance.RedDotWeaponSkinCondition(uId);
	}

	// Token: 0x0601AA90 RID: 109200 RVA: 0x00832FE8 File Offset: 0x008311E8
	private void OnWeaponResonanceSuccess(int roleId, int weaponId)
	{
		base.EventCheckWithUid(roleId);
	}
}
