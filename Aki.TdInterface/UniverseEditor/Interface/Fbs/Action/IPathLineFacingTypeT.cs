using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6A RID: 27754
	public class IPathLineFacingTypeT
	{
		// Token: 0x1700CEAF RID: 52911
		// (get) Token: 0x06030E6B RID: 200299 RVA: 0x006A4156 File Offset: 0x006A2356
		// (set) Token: 0x06030E6C RID: 200300 RVA: 0x006A415E File Offset: 0x006A235E
		public EPathLineFacingType Type { get; set; }

		// Token: 0x06030E6D RID: 200301 RVA: 0x006A4167 File Offset: 0x006A2367
		public IPathLineFacingTypeT()
		{
			this.Type = EPathLineFacingType.Current;
		}
	}
}
