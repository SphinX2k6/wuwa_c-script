using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C7C RID: 11388
public class UiCalabashAnsContext : UiAnsContextBase
{
	// Token: 0x17001FF5 RID: 8181
	// (get) Token: 0x06017CA7 RID: 97447 RVA: 0x0060D44D File Offset: 0x0060B64D
	public FName Socket { get; }

	// Token: 0x17001FF6 RID: 8182
	// (get) Token: 0x06017CA8 RID: 97448 RVA: 0x0060D455 File Offset: 0x0060B655
	public bool IsRotate { get; }

	// Token: 0x06017CA9 RID: 97449 RVA: 0x0060D45D File Offset: 0x0060B65D
	public UiCalabashAnsContext(FName socket, bool isRotate)
	{
		this.Socket = socket;
		this.IsRotate = isRotate;
	}

	// Token: 0x06017CAA RID: 97450 RVA: 0x0060D474 File Offset: 0x0060B674
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiCalabashAnsContext uiCalabashAnsContext = inAnsContext as UiCalabashAnsContext;
		return uiCalabashAnsContext != null && this.Socket == uiCalabashAnsContext.Socket;
	}
}
