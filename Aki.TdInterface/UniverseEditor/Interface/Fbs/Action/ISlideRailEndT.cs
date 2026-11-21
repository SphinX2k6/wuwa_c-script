using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007912 RID: 30994
	public class ISlideRailEndT
	{
		// Token: 0x1700E35C RID: 58204
		// (get) Token: 0x06036938 RID: 223544 RVA: 0x0074E089 File Offset: 0x0074C289
		// (set) Token: 0x06036939 RID: 223545 RVA: 0x0074E091 File Offset: 0x0074C291
		public TSlideRailEndUnion EndTarget { get; set; }

		// Token: 0x0603693A RID: 223546 RVA: 0x0074E09A File Offset: 0x0074C29A
		public ISlideRailEndT()
		{
			this.EndTarget = null;
		}
	}
}
