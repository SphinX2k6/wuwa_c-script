using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
[NullableContext(1)]
[Nullable(0)]
public class PlayResult
{
	// Token: 0x06000044 RID: 68 RVA: 0x00003A6D File Offset: 0x00001C6D
	public void Reset()
	{
		this.PlayingIds.Clear();
		this.CallbackIds.Clear();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003A85 File Offset: 0x00001C85
	public void AddPlayingId(int id)
	{
		if (id != 0 && !this.PlayingIds.Contains(id))
		{
			this.PlayingIds.Add(id);
		}
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00003AA4 File Offset: 0x00001CA4
	public void AddCallbackId(int id)
	{
		if (id != 0 && !this.CallbackIds.Contains(id))
		{
			this.CallbackIds.Add(id);
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00003AC4 File Offset: 0x00001CC4
	public void RemoveCallbackId(int id)
	{
		int num = this.CallbackIds.IndexOf(id);
		if (num > -1)
		{
			this.CallbackIds.RemoveAt(num);
		}
	}

	// Token: 0x04000047 RID: 71
	public string EventPath = "";

	// Token: 0x04000048 RID: 72
	public List<int> PlayingIds = new List<int>();

	// Token: 0x04000049 RID: 73
	public List<int> CallbackIds = new List<int>();
}
