using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C81 RID: 11393
[NullableContext(1)]
[Nullable(0)]
public class AnsContextTrigger
{
	// Token: 0x1700200A RID: 8202
	// (get) Token: 0x06017CCA RID: 97482 RVA: 0x0060D7F9 File Offset: 0x0060B9F9
	public Action<UiAnsContextBase> OnBegin { get; }

	// Token: 0x1700200B RID: 8203
	// (get) Token: 0x06017CCB RID: 97483 RVA: 0x0060D801 File Offset: 0x0060BA01
	public Action<UiAnsContextBase> OnEnd { get; }

	// Token: 0x1700200C RID: 8204
	// (get) Token: 0x06017CCC RID: 97484 RVA: 0x0060D809 File Offset: 0x0060BA09
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

	// Token: 0x1700200D RID: 8205
	// (get) Token: 0x06017CCD RID: 97485 RVA: 0x0060D811 File Offset: 0x0060BA11
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

	// Token: 0x06017CCE RID: 97486 RVA: 0x0060D819 File Offset: 0x0060BA19
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
