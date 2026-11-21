using System;
using System.Runtime.CompilerServices;

// Token: 0x020028A1 RID: 10401
[NullableContext(1)]
[Nullable(0)]
public class RedDotEventData
{
	// Token: 0x17002B3E RID: 11070
	// (get) Token: 0x0601A610 RID: 108048 RVA: 0x00829E79 File Offset: 0x00828079
	// (set) Token: 0x0601A611 RID: 108049 RVA: 0x00829E81 File Offset: 0x00828081
	public TRedDotCheckEvent Event { get; set; }

	// Token: 0x17002B3F RID: 11071
	// (get) Token: 0x0601A612 RID: 108050 RVA: 0x00829E8A File Offset: 0x0082808A
	// (set) Token: 0x0601A613 RID: 108051 RVA: 0x00829E92 File Offset: 0x00828092
	public int Id { get; set; }

	// Token: 0x17002B40 RID: 11072
	// (get) Token: 0x0601A614 RID: 108052 RVA: 0x00829E9B File Offset: 0x0082809B
	// (set) Token: 0x0601A615 RID: 108053 RVA: 0x00829EA3 File Offset: 0x008280A3
	public string RedDotName { get; set; }

	// Token: 0x0601A616 RID: 108054 RVA: 0x00829EAC File Offset: 0x008280AC
	public RedDotEventData(TRedDotCheckEvent @event, int id, string redDotName)
	{
		this.Event = @event;
		this.Id = id;
		this.RedDotName = redDotName;
	}

	// Token: 0x0601A617 RID: 108055 RVA: 0x00829EC9 File Offset: 0x008280C9
	public void HandleEvent()
	{
		this.Event(this.Id);
	}
}
