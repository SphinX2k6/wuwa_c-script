using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006456 RID: 25686
	public class IOutAreaBorderEffectTypeT
	{
		// Token: 0x1700BDA2 RID: 48546
		// (get) Token: 0x0602BA76 RID: 178806 RVA: 0x005F126E File Offset: 0x005EF46E
		// (set) Token: 0x0602BA77 RID: 178807 RVA: 0x005F1276 File Offset: 0x005EF476
		public EOutAreaBorderEffectType Type { get; set; }

		// Token: 0x0602BA78 RID: 178808 RVA: 0x005F127F File Offset: 0x005EF47F
		public IOutAreaBorderEffectTypeT()
		{
			this.Type = EOutAreaBorderEffectType.BuffId;
		}
	}
}
