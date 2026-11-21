using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D1 RID: 29649
	public class IPathLineFacingTypeT
	{
		// Token: 0x1700D9CA RID: 55754
		// (get) Token: 0x06033DC6 RID: 212422 RVA: 0x006FE656 File Offset: 0x006FC856
		// (set) Token: 0x06033DC7 RID: 212423 RVA: 0x006FE65E File Offset: 0x006FC85E
		public EPathLineFacingType Type { get; set; }

		// Token: 0x06033DC8 RID: 212424 RVA: 0x006FE667 File Offset: 0x006FC867
		public IPathLineFacingTypeT()
		{
			this.Type = EPathLineFacingType.Current;
		}
	}
}
