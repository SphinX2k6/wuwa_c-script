using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF2 RID: 27378
	public class IMontageConfigT
	{
		// Token: 0x1700CB1B RID: 51995
		// (get) Token: 0x0602FFDE RID: 196574 RVA: 0x00686596 File Offset: 0x00684796
		// (set) Token: 0x0602FFDF RID: 196575 RVA: 0x0068659E File Offset: 0x0068479E
		public EMontageConfigType Type { get; set; }

		// Token: 0x0602FFE0 RID: 196576 RVA: 0x006865A7 File Offset: 0x006847A7
		public IMontageConfigT()
		{
			this.Type = EMontageConfigType.Asset;
		}
	}
}
