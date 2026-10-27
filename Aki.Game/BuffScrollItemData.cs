using System;
using System.Runtime.CompilerServices;

// Token: 0x02001374 RID: 4980
internal class BuffScrollItemData
{
	// Token: 0x04003DD4 RID: 15828
	public int BuffId;

	// Token: 0x04003DD5 RID: 15829
	public bool ChangeAble = true;

	// Token: 0x04003DD6 RID: 15830
	public bool Selected;

	// Token: 0x04003DD7 RID: 15831
	public bool SelectedAtStart;

	// Token: 0x04003DD8 RID: 15832
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<BuffScrollItemData> OnClickToggle;

	// Token: 0x04003DD9 RID: 15833
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<BuffScrollItemData, bool> CheckClickAble;
}
