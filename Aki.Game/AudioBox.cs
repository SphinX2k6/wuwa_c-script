using System;
using System.Runtime.CompilerServices;

// Token: 0x020001EC RID: 492
public class AudioBox
{
	// Token: 0x06001E91 RID: 7825 RVA: 0x000989B8 File Offset: 0x00096BB8
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

	// Token: 0x06001E92 RID: 7826 RVA: 0x000989DB File Offset: 0x00096BDB
	public AudioBox(int priority, int pbDataId, EAudioBoxType boxType)
	{
		this.Priority = priority;
		this.PbDataId = pbDataId;
		this.BoxType = boxType;
	}

	// Token: 0x040012D7 RID: 4823
	public int Priority;

	// Token: 0x040012D8 RID: 4824
	public int PbDataId;

	// Token: 0x040012D9 RID: 4825
	public EAudioBoxType BoxType;
}
