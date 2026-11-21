using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200640B RID: 25611
	public class IGiantSpecialAnimDataT
	{
		// Token: 0x1700BD2C RID: 48428
		// (get) Token: 0x0602B830 RID: 178224 RVA: 0x005ED183 File Offset: 0x005EB383
		// (set) Token: 0x0602B831 RID: 178225 RVA: 0x005ED18B File Offset: 0x005EB38B
		public EGiantAnimationType Type { get; set; }

		// Token: 0x1700BD2D RID: 48429
		// (get) Token: 0x0602B832 RID: 178226 RVA: 0x005ED194 File Offset: 0x005EB394
		// (set) Token: 0x0602B833 RID: 178227 RVA: 0x005ED19C File Offset: 0x005EB39C
		public string MontagePath { get; set; }

		// Token: 0x1700BD2E RID: 48430
		// (get) Token: 0x0602B834 RID: 178228 RVA: 0x005ED1A5 File Offset: 0x005EB3A5
		// (set) Token: 0x0602B835 RID: 178229 RVA: 0x005ED1AD File Offset: 0x005EB3AD
		public bool IsCanBeInterrupt { get; set; }

		// Token: 0x1700BD2F RID: 48431
		// (get) Token: 0x0602B836 RID: 178230 RVA: 0x005ED1B6 File Offset: 0x005EB3B6
		// (set) Token: 0x0602B837 RID: 178231 RVA: 0x005ED1BE File Offset: 0x005EB3BE
		public byte NullMask { get; set; }

		// Token: 0x0602B838 RID: 178232 RVA: 0x005ED1C7 File Offset: 0x005EB3C7
		public IGiantSpecialAnimDataT()
		{
			this.Type = EGiantAnimationType.Idle;
			this.MontagePath = null;
			this.IsCanBeInterrupt = false;
			this.NullMask = 0;
		}
	}
}
