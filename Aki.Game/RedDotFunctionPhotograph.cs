using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033A0 RID: 13216
public class RedDotFunctionPhotograph : RedDotBase
{
	// Token: 0x0601CB1A RID: 117530 RVA: 0x00807694 File Offset: 0x00805894
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotFilter, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(base.EventCheck));
	}

	// Token: 0x0601CB1B RID: 117531 RVA: 0x008076CE File Offset: 0x008058CE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotFilter, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(base.EventCheck));
	}

	// Token: 0x0601CB1C RID: 117532 RVA: 0x00807708 File Offset: 0x00805908
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}
