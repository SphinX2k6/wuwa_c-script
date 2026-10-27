using System;
using System.Runtime.CompilerServices;

// Token: 0x02000260 RID: 608
[NullableContext(1)]
[Nullable(0)]
public class EventModelInfo : IAudioInfo
{
	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x0600254C RID: 9548 RVA: 0x000E0F34 File Offset: 0x000DF134
	// (set) Token: 0x0600254D RID: 9549 RVA: 0x000E0F3C File Offset: 0x000DF13C
	public bool Start { get; set; }

	// Token: 0x0600254E RID: 9550 RVA: 0x000E0F45 File Offset: 0x000DF145
	public EventModelInfo(string @event)
	{
		this.Event = @event;
		this.Start = false;
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000E0F66 File Offset: 0x000DF166
	[NullableContext(2)]
	public string GetName()
	{
		return this.Event;
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000E0F6E File Offset: 0x000DF16E
	[NullableContext(2)]
	public string GetAudioEvent()
	{
		return this.Event;
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x000E0F76 File Offset: 0x000DF176
	public bool IsValid()
	{
		return this.Event != "";
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000E0F88 File Offset: 0x000DF188
	public bool IsAudioEventValid()
	{
		return this.Event != "";
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000E0F9A File Offset: 0x000DF19A
	public object GetCompare()
	{
		return this.Event;
	}

	// Token: 0x04002430 RID: 9264
	public string Event = "";
}
