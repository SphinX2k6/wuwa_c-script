using System;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x02000C6F RID: 3183
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CombatListenAttribute : DecoratorDefineAttribute
{
	// Token: 0x0600853B RID: 34107 RVA: 0x0028C95B File Offset: 0x0028AB5B
	public CombatListenAttribute(ENotifyMessageId notifyKey, bool needSync, bool needCache = false)
	{
	}
}
