using System;
using System.Runtime.CompilerServices;

// Token: 0x020034AE RID: 13486
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptUnit
{
	// Token: 0x0601D609 RID: 120329 RVA: 0x00831D8E File Offset: 0x0082FF8E
	public CombatScriptUnit(string cmd, string body, string viewName, string introduction)
	{
		this.Cmd = cmd;
		this.Body = body;
		this.ViewName = viewName;
		this.Introduction = introduction;
	}

	// Token: 0x0601D60A RID: 120330 RVA: 0x00831DB4 File Offset: 0x0082FFB4
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"-------------------------------------------------------------------------\n        -指令名称： ",
			this.ViewName,
			"\n        -指令介绍： ",
			this.Introduction,
			"\n        -指令详情： ",
			this.Cmd,
			"\n        -指令具体内容： ",
			this.Body,
			"\n"
		});
	}

	// Token: 0x0400E763 RID: 59235
	public string Cmd;

	// Token: 0x0400E764 RID: 59236
	public string Body;

	// Token: 0x0400E765 RID: 59237
	public string ViewName;

	// Token: 0x0400E766 RID: 59238
	public string Introduction;
}
