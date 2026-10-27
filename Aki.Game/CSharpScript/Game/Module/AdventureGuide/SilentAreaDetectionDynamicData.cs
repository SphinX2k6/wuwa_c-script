using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EC4 RID: 24260
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaDetectionDynamicData : ISilentAreaDetectionDynamicData
	{
		// Token: 0x17008ED4 RID: 36564
		// (get) Token: 0x0603DB26 RID: 252710 RVA: 0x00EE5DB5 File Offset: 0x00EE3FB5
		// (set) Token: 0x0603DB27 RID: 252711 RVA: 0x00EE5DBD File Offset: 0x00EE3FBD
		public bool IsShow { get; set; }

		// Token: 0x17008ED5 RID: 36565
		// (get) Token: 0x0603DB28 RID: 252712 RVA: 0x00EE5DC6 File Offset: 0x00EE3FC6
		// (set) Token: 0x0603DB29 RID: 252713 RVA: 0x00EE5DCE File Offset: 0x00EE3FCE
		public int DangerType { get; set; }

		// Token: 0x17008ED6 RID: 36566
		// (get) Token: 0x0603DB2A RID: 252714 RVA: 0x00EE5DD7 File Offset: 0x00EE3FD7
		// (set) Token: 0x0603DB2B RID: 252715 RVA: 0x00EE5DDF File Offset: 0x00EE3FDF
		public SilentAreaDetectionRecord SilentAreaDetectionData { get; set; }

		// Token: 0x17008ED7 RID: 36567
		// (get) Token: 0x0603DB2C RID: 252716 RVA: 0x00EE5DE8 File Offset: 0x00EE3FE8
		// (set) Token: 0x0603DB2D RID: 252717 RVA: 0x00EE5DF0 File Offset: 0x00EE3FF0
		[Nullable(2)]
		public ISilentAreaTitleData SilentAreaTitleData { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
