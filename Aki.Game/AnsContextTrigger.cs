using System;
using System.Runtime.CompilerServices;

// Token: 0x020021DA RID: 8666
[NullableContext(1)]
[Nullable(0)]
public class AnsContextTrigger
{
	// Token: 0x1700205B RID: 8283
	// (get) Token: 0x0601553D RID: 87357 RVA: 0x006332DD File Offset: 0x006314DD
	public Action<UiAnsContextBase> OnBegin { get; }

	// Token: 0x1700205C RID: 8284
	// (get) Token: 0x0601553E RID: 87358 RVA: 0x006332E5 File Offset: 0x006314E5
	public Action<UiAnsContextBase> OnEnd { get; }

	// Token: 0x1700205D RID: 8285
	// (get) Token: 0x0601553F RID: 87359 RVA: 0x006332ED File Offset: 0x006314ED
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UiAnsContextBase> OnEffectPreHide { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x1700205E RID: 8286
	// (get) Token: 0x06015540 RID: 87360 RVA: 0x006332F5 File Offset: 0x006314F5
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UiAnsContextBase> OnEffectPreHideRevert { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; }

	// Token: 0x06015541 RID: 87361 RVA: 0x006332FD File Offset: 0x006314FD
	public AnsContextTrigger(Action<UiAnsContextBase> onBegin, Action<UiAnsContextBase> onEnd, [Nullable(new byte[]
	{
		2,
		1
	})] Action<UiAnsContextBase> onEffectPreHide = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<UiAnsContextBase> onEffectPreHideRevert = null)
	{
		this.OnBegin = onBegin;
		this.OnEnd = onEnd;
		this.OnEffectPreHide = onEffectPreHide;
		this.OnEffectPreHideRevert = onEffectPreHideRevert;
	}
}
