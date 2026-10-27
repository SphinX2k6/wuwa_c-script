using System;
using System.Runtime.CompilerServices;

// Token: 0x02001420 RID: 5152
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleTipsParam : IPinballBattleTipsBaseParam
{
	// Token: 0x17000C7D RID: 3197
	// (get) Token: 0x0600913D RID: 37181 RVA: 0x001F2C68 File Offset: 0x001F0E68
	// (set) Token: 0x0600913E RID: 37182 RVA: 0x001F2C70 File Offset: 0x001F0E70
	public Action CloseCallback { get; set; }

	// Token: 0x17000C7E RID: 3198
	// (get) Token: 0x0600913F RID: 37183 RVA: 0x001F2C79 File Offset: 0x001F0E79
	// (set) Token: 0x06009140 RID: 37184 RVA: 0x001F2C81 File Offset: 0x001F0E81
	public bool? AddMask { get; set; }

	// Token: 0x17000C7F RID: 3199
	// (get) Token: 0x06009141 RID: 37185 RVA: 0x001F2C8A File Offset: 0x001F0E8A
	// (set) Token: 0x06009142 RID: 37186 RVA: 0x001F2C92 File Offset: 0x001F0E92
	public int? CloseTime { get; set; }

	// Token: 0x17000C80 RID: 3200
	// (get) Token: 0x06009143 RID: 37187 RVA: 0x001F2C9B File Offset: 0x001F0E9B
	// (set) Token: 0x06009144 RID: 37188 RVA: 0x001F2CA3 File Offset: 0x001F0EA3
	public bool? MoveToBehind { get; set; }
}
