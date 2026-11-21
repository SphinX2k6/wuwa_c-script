using System;
using System.Runtime.CompilerServices;

// Token: 0x02000017 RID: 23
[NullableContext(1)]
[Nullable(0)]
public class AudioFilterState : IFilterState
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000096 RID: 150 RVA: 0x00005A3F File Offset: 0x00003C3F
	// (set) Token: 0x06000097 RID: 151 RVA: 0x00005A47 File Offset: 0x00003C47
	public string State { get; set; } = "none";

	// Token: 0x06000098 RID: 152 RVA: 0x00005A50 File Offset: 0x00003C50
	public AudioFilterState(int uid, string state, int? priority = null)
	{
		this.Uid = uid;
		this.State = state;
		this.Priority = priority.GetValueOrDefault();
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00005A80 File Offset: 0x00003C80
	public static int Compare(AudioFilterState a, AudioFilterState b)
	{
		int num = b.Priority - a.Priority;
		if (num != 0)
		{
			return num;
		}
		return b.Uid - a.Uid;
	}

	// Token: 0x04000081 RID: 129
	public int Priority;

	// Token: 0x04000082 RID: 130
	public int Uid;
}
