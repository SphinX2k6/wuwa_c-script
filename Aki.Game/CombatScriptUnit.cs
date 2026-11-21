using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A22 RID: 10786
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptUnit
{
	// Token: 0x0601B308 RID: 111368 RVA: 0x008591AE File Offset: 0x008573AE
	public CombatScriptUnit(string cmd, string body, string viewName, string introduction)
	{
		this.Cmd = cmd;
		this.Body = body;
		this.ViewName = viewName;
		this.Introduction = introduction;
	}

	// Token: 0x0601B309 RID: 111369 RVA: 0x008591D4 File Offset: 0x008573D4
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

	// Token: 0x0400EC17 RID: 60439
	public string Cmd;

	// Token: 0x0400EC18 RID: 60440
	public string Body;

	// Token: 0x0400EC19 RID: 60441
	public string ViewName;

	// Token: 0x0400EC1A RID: 60442
	public string Introduction;
}
