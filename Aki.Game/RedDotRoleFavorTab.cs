using System;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200298D RID: 10637
public class RedDotRoleFavorTab : RedDotBase
{
	// Token: 0x0601AA5B RID: 109147 RVA: 0x008323AC File Offset: 0x008305AC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleLangCustomFuncClicked, new Action<int>(this.OnRoleLangCustomFuncClicked));
	}

	// Token: 0x0601AA5C RID: 109148 RVA: 0x008323CA File Offset: 0x008305CA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleLangCustomFuncClicked, new Action<int>(this.OnRoleLangCustomFuncClicked));
	}

	// Token: 0x0601AA5D RID: 109149 RVA: 0x008323E8 File Offset: 0x008305E8
	private void OnRoleLangCustomFuncClicked(int roleId)
	{
		base.EventCheck();
	}

	// Token: 0x0601AA5E RID: 109150 RVA: 0x008323F0 File Offset: 0x008305F0
	protected override bool OnCheck(int roleId = 0)
	{
		ServerStorageBoolean serverStorageBoolean = (ServerStorageBoolean)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomFuncClicked);
		return !serverStorageBoolean.Get().GetValueOrDefault() || !serverStorageBoolean.Get().Value;
	}
}
