using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D2 RID: 21970
	public class IDamageTextOptimizationConfigT
	{
		// Token: 0x17009D4A RID: 40266
		// (get) Token: 0x06022F53 RID: 143187 RVA: 0x004CFC36 File Offset: 0x004CDE36
		// (set) Token: 0x06022F54 RID: 143188 RVA: 0x004CFC3E File Offset: 0x004CDE3E
		public EPerformanceOptimizationType Type { get; set; }

		// Token: 0x17009D4B RID: 40267
		// (get) Token: 0x06022F55 RID: 143189 RVA: 0x004CFC47 File Offset: 0x004CDE47
		// (set) Token: 0x06022F56 RID: 143190 RVA: 0x004CFC4F File Offset: 0x004CDE4F
		public bool UseRange { get; set; }

		// Token: 0x17009D4C RID: 40268
		// (get) Token: 0x06022F57 RID: 143191 RVA: 0x004CFC58 File Offset: 0x004CDE58
		// (set) Token: 0x06022F58 RID: 143192 RVA: 0x004CFC60 File Offset: 0x004CDE60
		public byte NullMask { get; set; }

		// Token: 0x06022F59 RID: 143193 RVA: 0x004CFC69 File Offset: 0x004CDE69
		public IDamageTextOptimizationConfigT()
		{
			this.Type = EPerformanceOptimizationType.PlaneMovementOptimization;
			this.UseRange = false;
			this.NullMask = 0;
		}
	}
}
