using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E5 RID: 25317
	public class IChangeEntityPrefabPerformanceT
	{
		// Token: 0x1700BCF1 RID: 48369
		// (get) Token: 0x0602BC2B RID: 179243 RVA: 0x006052B6 File Offset: 0x006034B6
		// (set) Token: 0x0602BC2C RID: 179244 RVA: 0x006052BE File Offset: 0x006034BE
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x0602BC2D RID: 179245 RVA: 0x006052C7 File Offset: 0x006034C7
		public IChangeEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
		}
	}
}
