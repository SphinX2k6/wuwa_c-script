using System;
using System.Runtime.CompilerServices;

// Token: 0x020001F0 RID: 496
public class AudioBox
{
	// Token: 0x06001F2E RID: 7982 RVA: 0x0009FB34 File Offset: 0x0009DD34
	[NullableContext(1)]
	public static int Compare(AudioBox a, AudioBox b)
	{
		int num = b.Priority - a.Priority;
		if (num == 0)
		{
			num--;
		}
		return num;
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x0009FB57 File Offset: 0x0009DD57
	public AudioBox(int priority, int pbDataId, EAudioBoxType boxType)
	{
		this.Priority = priority;
		this.PbDataId = pbDataId;
		this.BoxType = boxType;
	}

	// Token: 0x0400131A RID: 4890
	public int Priority;

	// Token: 0x0400131B RID: 4891
	public int PbDataId;

	// Token: 0x0400131C RID: 4892
	public EAudioBoxType BoxType;
}
