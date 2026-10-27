using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000013 RID: 19
[NullableContext(2)]
[Nullable(0)]
public class AudioEventPoolItem
{
	// Token: 0x0600008C RID: 140 RVA: 0x00005A78 File Offset: 0x00003C78
	[NullableContext(1)]
	public AudioEventPoolItem(UAkAudioEvent @event, long? time = null)
	{
		this.AudioEvent = @event;
		long? num = time;
		this.LastActiveTime = ((num != null) ? ((double)num.GetValueOrDefault()) : Time.Instance.Now);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00005AB7 File Offset: 0x00003CB7
	public void UpdateEvent(UAkAudioEvent @event)
	{
		if (@event != null)
		{
			this.AudioEvent = @event;
		}
		this.LastActiveTime = Time.Instance.Now;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00005AD3 File Offset: 0x00003CD3
	public void Destroy()
	{
		if (this.AudioEvent != null)
		{
			this.AudioEvent = null;
		}
	}

	// Token: 0x04000075 RID: 117
	public UAkAudioEvent AudioEvent;

	// Token: 0x04000076 RID: 118
	public double LastActiveTime;
}
