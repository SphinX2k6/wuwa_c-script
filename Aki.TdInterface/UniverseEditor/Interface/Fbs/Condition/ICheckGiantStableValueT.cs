using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3A RID: 19002
	public class ICheckGiantStableValueT
	{
		// Token: 0x17008993 RID: 35219
		// (get) Token: 0x0601DC06 RID: 121862 RVA: 0x0042F203 File Offset: 0x0042D403
		// (set) Token: 0x0601DC07 RID: 121863 RVA: 0x0042F20B File Offset: 0x0042D40B
		public ECondition Type { get; set; }

		// Token: 0x17008994 RID: 35220
		// (get) Token: 0x0601DC08 RID: 121864 RVA: 0x0042F214 File Offset: 0x0042D414
		// (set) Token: 0x0601DC09 RID: 121865 RVA: 0x0042F21C File Offset: 0x0042D41C
		public TGiantStableValueUnion StableValueOption { get; set; }

		// Token: 0x0601DC0A RID: 121866 RVA: 0x0042F225 File Offset: 0x0042D425
		public ICheckGiantStableValueT()
		{
			this.Type = ECondition.CompareVar;
			this.StableValueOption = null;
		}
	}
}
