using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006586 RID: 25990
	public class IDestroyDynamicEntitiesTypeT
	{
		// Token: 0x1700C10C RID: 49420
		// (get) Token: 0x0602D157 RID: 184663 RVA: 0x0062F506 File Offset: 0x0062D706
		// (set) Token: 0x0602D158 RID: 184664 RVA: 0x0062F50E File Offset: 0x0062D70E
		public EDynamicEntityType Type { get; set; }

		// Token: 0x0602D159 RID: 184665 RVA: 0x0062F517 File Offset: 0x0062D717
		public IDestroyDynamicEntitiesTypeT()
		{
			this.Type = EDynamicEntityType.VisionDisplay;
		}
	}
}
