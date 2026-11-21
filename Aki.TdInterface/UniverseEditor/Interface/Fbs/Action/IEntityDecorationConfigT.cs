using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D56 RID: 27990
	public class IEntityDecorationConfigT
	{
		// Token: 0x1700CD4F RID: 52559
		// (get) Token: 0x0603048C RID: 197772 RVA: 0x0068FE8A File Offset: 0x0068E08A
		// (set) Token: 0x0603048D RID: 197773 RVA: 0x0068FE92 File Offset: 0x0068E092
		public EEntityDecorationType Type { get; set; }

		// Token: 0x0603048E RID: 197774 RVA: 0x0068FE9B File Offset: 0x0068E09B
		public IEntityDecorationConfigT()
		{
			this.Type = EEntityDecorationType.Add;
		}
	}
}
