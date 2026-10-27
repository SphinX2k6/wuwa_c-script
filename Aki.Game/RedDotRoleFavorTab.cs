using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200341B RID: 13339
public class RedDotRoleFavorTab : RedDotBase
{
	// Token: 0x0601CD63 RID: 118115 RVA: 0x0080BDE8 File Offset: 0x00809FE8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleLangCustomFuncClicked, new Action<int>(this.OnRoleLangCustomFuncClicked));
	}

	// Token: 0x0601CD64 RID: 118116 RVA: 0x0080BE06 File Offset: 0x0080A006
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleLangCustomFuncClicked, new Action<int>(this.OnRoleLangCustomFuncClicked));
	}

	// Token: 0x0601CD65 RID: 118117 RVA: 0x0080BE24 File Offset: 0x0080A024
	private void OnRoleLangCustomFuncClicked(int roleId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CD66 RID: 118118 RVA: 0x0080BE2C File Offset: 0x0080A02C
	protected override bool OnCheck(int roleId = 0)
	{
		ServerStorageBoolean serverStorageBoolean = (ServerStorageBoolean)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomFuncClicked);
		return !serverStorageBoolean.Get().GetValueOrDefault() || !serverStorageBoolean.Get().Value;
	}
}
