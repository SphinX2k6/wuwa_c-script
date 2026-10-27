using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003453 RID: 13395
public class RedDotWeaponResonanceTab : RedDotBase
{
	// Token: 0x0601CE69 RID: 118377 RVA: 0x0080E344 File Offset: 0x0080C544
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CE6A RID: 118378 RVA: 0x0080E347 File Offset: 0x0080C547
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601CE6B RID: 118379 RVA: 0x0080E381 File Offset: 0x0080C581
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601CE6C RID: 118380 RVA: 0x0080E3BB File Offset: 0x0080C5BB
	protected override bool OnCheck(int uId = 0)
	{
		return WeaponModel.Instance.RedDotWeaponResonanceCondition(uId);
	}

	// Token: 0x0601CE6D RID: 118381 RVA: 0x0080E3C8 File Offset: 0x0080C5C8
	private void OnWeaponResonanceSuccess(int roleId, int weaponId)
	{
		base.EventCheckWithUid(roleId);
	}
}
