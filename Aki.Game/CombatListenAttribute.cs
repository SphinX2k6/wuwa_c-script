using System;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x020017B6 RID: 6070
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CombatListenAttribute : DecoratorDefineAttribute
{
	// Token: 0x0600B153 RID: 45395 RVA: 0x002823C3 File Offset: 0x002805C3
	public CombatListenAttribute(ENotifyMessageId notifyKey, bool needSync, bool needCache = false)
	{
	}
}
