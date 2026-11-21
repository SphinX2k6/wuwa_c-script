using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BE9 RID: 3049
[NullableContext(2)]
[Nullable(0)]
public class VisionRecoveryTabViewParam
{
	// Token: 0x17000E67 RID: 3687
	// (get) Token: 0x06007F79 RID: 32633 RVA: 0x002721B1 File Offset: 0x002703B1
	// (set) Token: 0x06007F7A RID: 32634 RVA: 0x002721B9 File Offset: 0x002703B9
	public EVisionRecoveryMode? RecoveryMode { get; set; }

	// Token: 0x17000E68 RID: 3688
	// (get) Token: 0x06007F7B RID: 32635 RVA: 0x002721C2 File Offset: 0x002703C2
	// (set) Token: 0x06007F7C RID: 32636 RVA: 0x002721CA File Offset: 0x002703CA
	public Action OnQuitInternalView { get; set; }
}
