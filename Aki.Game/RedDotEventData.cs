using System;
using System.Runtime.CompilerServices;

// Token: 0x0200332F RID: 13103
[NullableContext(1)]
[Nullable(0)]
public class RedDotEventData
{
	// Token: 0x170027A2 RID: 10146
	// (get) Token: 0x0601C918 RID: 117016 RVA: 0x008038B5 File Offset: 0x00801AB5
	// (set) Token: 0x0601C919 RID: 117017 RVA: 0x008038BD File Offset: 0x00801ABD
	public TRedDotCheckEvent Event { get; set; }

	// Token: 0x170027A3 RID: 10147
	// (get) Token: 0x0601C91A RID: 117018 RVA: 0x008038C6 File Offset: 0x00801AC6
	// (set) Token: 0x0601C91B RID: 117019 RVA: 0x008038CE File Offset: 0x00801ACE
	public int Id { get; set; }

	// Token: 0x170027A4 RID: 10148
	// (get) Token: 0x0601C91C RID: 117020 RVA: 0x008038D7 File Offset: 0x00801AD7
	// (set) Token: 0x0601C91D RID: 117021 RVA: 0x008038DF File Offset: 0x00801ADF
	public string RedDotName { get; set; }

	// Token: 0x0601C91E RID: 117022 RVA: 0x008038E8 File Offset: 0x00801AE8
	public RedDotEventData(TRedDotCheckEvent @event, int id, string redDotName)
	{
		this.Event = @event;
		this.Id = id;
		this.RedDotName = redDotName;
	}

	// Token: 0x0601C91F RID: 117023 RVA: 0x00803905 File Offset: 0x00801B05
	public void HandleEvent()
	{
		this.Event(this.Id);
	}
}
