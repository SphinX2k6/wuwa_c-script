using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A7 RID: 21415
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddItemData : IMoraleBuffAddItemData
	{
		// Token: 0x170083AF RID: 33711
		// (get) Token: 0x06036B94 RID: 224148 RVA: 0x00CF3946 File Offset: 0x00CF1B46
		// (set) Token: 0x06036B95 RID: 224149 RVA: 0x00CF394E File Offset: 0x00CF1B4E
		public string IconPath { get; set; } = "";

		// Token: 0x170083B0 RID: 33712
		// (get) Token: 0x06036B96 RID: 224150 RVA: 0x00CF3957 File Offset: 0x00CF1B57
		// (set) Token: 0x06036B97 RID: 224151 RVA: 0x00CF395F File Offset: 0x00CF1B5F
		public string NameKey { get; set; } = "";

		// Token: 0x170083B1 RID: 33713
		// (get) Token: 0x06036B98 RID: 224152 RVA: 0x00CF3968 File Offset: 0x00CF1B68
		// (set) Token: 0x06036B99 RID: 224153 RVA: 0x00CF3970 File Offset: 0x00CF1B70
		public string Value { get; set; } = "";
	}
}
