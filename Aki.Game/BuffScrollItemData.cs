using System;
using System.Runtime.CompilerServices;

// Token: 0x02000828 RID: 2088
internal class BuffScrollItemData
{
	// Token: 0x04003E6C RID: 15980
	public int BuffId;

	// Token: 0x04003E6D RID: 15981
	public bool ChangeAble = true;

	// Token: 0x04003E6E RID: 15982
	public bool Selected;

	// Token: 0x04003E6F RID: 15983
	public bool SelectedAtStart;

	// Token: 0x04003E70 RID: 15984
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<BuffScrollItemData> OnClickToggle;

	// Token: 0x04003E71 RID: 15985
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<BuffScrollItemData, bool> CheckClickAble;
}
