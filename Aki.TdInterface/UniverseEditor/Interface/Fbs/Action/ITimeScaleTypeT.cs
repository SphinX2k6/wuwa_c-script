using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD0 RID: 31696
	public class ITimeScaleTypeT
	{
		// Token: 0x1700ED75 RID: 60789
		// (get) Token: 0x06039218 RID: 234008 RVA: 0x007B85CE File Offset: 0x007B67CE
		// (set) Token: 0x06039219 RID: 234009 RVA: 0x007B85D6 File Offset: 0x007B67D6
		public ETimeScaleType Type { get; set; }

		// Token: 0x0603921A RID: 234010 RVA: 0x007B85DF File Offset: 0x007B67DF
		public ITimeScaleTypeT()
		{
			this.Type = ETimeScaleType.Global;
		}
	}
}
