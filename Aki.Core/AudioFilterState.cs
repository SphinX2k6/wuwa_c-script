using System;
using System.Runtime.CompilerServices;

// Token: 0x02000017 RID: 23
[NullableContext(1)]
[Nullable(0)]
public class AudioFilterState : IFilterState
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000096 RID: 150 RVA: 0x00005D43 File Offset: 0x00003F43
	// (set) Token: 0x06000097 RID: 151 RVA: 0x00005D4B File Offset: 0x00003F4B
	public string State { get; set; } = "none";

	// Token: 0x06000098 RID: 152 RVA: 0x00005D54 File Offset: 0x00003F54
	public AudioFilterState(int uid, string state, int? priority = null)
	{
		this.Uid = uid;
		this.State = state;
		this.Priority = priority.GetValueOrDefault();
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00005D84 File Offset: 0x00003F84
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
