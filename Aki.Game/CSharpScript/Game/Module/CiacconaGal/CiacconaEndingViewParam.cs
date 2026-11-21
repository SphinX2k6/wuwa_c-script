using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD1 RID: 19409
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaEndingViewParam : ICiacconaEndingViewParam
	{
		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x0603070F RID: 198415 RVA: 0x00D8007B File Offset: 0x00D7E27B
		// (set) Token: 0x06030710 RID: 198416 RVA: 0x00D80083 File Offset: 0x00D7E283
		public CiacconaGalEndingData EndingData { get; set; }

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x06030711 RID: 198417 RVA: 0x00D8008C File Offset: 0x00D7E28C
		// (set) Token: 0x06030712 RID: 198418 RVA: 0x00D80094 File Offset: 0x00D7E294
		[Nullable(2)]
		public string LabelTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
