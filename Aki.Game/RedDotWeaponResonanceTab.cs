using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C7 RID: 10695
public class RedDotWeaponResonanceTab : RedDotBase
{
	// Token: 0x0601AB69 RID: 109417 RVA: 0x00834A2C File Offset: 0x00832C2C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AB6A RID: 109418 RVA: 0x00834A2F File Offset: 0x00832C2F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601AB6B RID: 109419 RVA: 0x00834A69 File Offset: 0x00832C69
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnWeaponResonanceSuccess));
	}

	// Token: 0x0601AB6C RID: 109420 RVA: 0x00834AA3 File Offset: 0x00832CA3
	protected override bool OnCheck(int uId = 0)
	{
		return WeaponModel.Instance.RedDotWeaponResonanceCondition(uId);
	}

	// Token: 0x0601AB6D RID: 109421 RVA: 0x00834AB0 File Offset: 0x00832CB0
	private void OnWeaponResonanceSuccess(int roleId, int weaponId)
	{
		base.EventCheckWithUid(roleId);
	}
}
