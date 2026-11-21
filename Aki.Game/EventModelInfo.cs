using System;
using System.Runtime.CompilerServices;

// Token: 0x02000264 RID: 612
[NullableContext(1)]
[Nullable(0)]
public class EventModelInfo : IAudioInfo
{
	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x06002603 RID: 9731 RVA: 0x000E72D0 File Offset: 0x000E54D0
	// (set) Token: 0x06002604 RID: 9732 RVA: 0x000E72D8 File Offset: 0x000E54D8
	public bool Start { get; set; }

	// Token: 0x06002605 RID: 9733 RVA: 0x000E72E1 File Offset: 0x000E54E1
	public EventModelInfo(string @event)
	{
		this.Event = @event;
		this.Start = false;
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x000E7302 File Offset: 0x000E5502
	[NullableContext(2)]
	public string GetName()
	{
		return this.Event;
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x000E730A File Offset: 0x000E550A
	[NullableContext(2)]
	public string GetAudioEvent()
	{
		return this.Event;
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x000E7312 File Offset: 0x000E5512
	public bool IsValid()
	{
		return this.Event != "";
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x000E7324 File Offset: 0x000E5524
	public bool IsAudioEventValid()
	{
		return this.Event != "";
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x000E7336 File Offset: 0x000E5536
	public object GetCompare()
	{
		return this.Event;
	}

	// Token: 0x040024AE RID: 9390
	public string Event = "";
}
