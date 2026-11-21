using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE1 RID: 16097
	public class ISystemVarRefT
	{
		// Token: 0x17006D00 RID: 27904
		// (get) Token: 0x06015D2E RID: 89390 RVA: 0x00323D79 File Offset: 0x00321F79
		// (set) Token: 0x06015D2F RID: 89391 RVA: 0x00323D81 File Offset: 0x00321F81
		public EVar Type { get; set; }

		// Token: 0x17006D01 RID: 27905
		// (get) Token: 0x06015D30 RID: 89392 RVA: 0x00323D8A File Offset: 0x00321F8A
		// (set) Token: 0x06015D31 RID: 89393 RVA: 0x00323D92 File Offset: 0x00321F92
		public EVarRefSource Source { get; set; }

		// Token: 0x17006D02 RID: 27906
		// (get) Token: 0x06015D32 RID: 89394 RVA: 0x00323D9B File Offset: 0x00321F9B
		// (set) Token: 0x06015D33 RID: 89395 RVA: 0x00323DA3 File Offset: 0x00321FA3
		public TSystemVarUnion Var { get; set; }

		// Token: 0x06015D34 RID: 89396 RVA: 0x00323DAC File Offset: 0x00321FAC
		public ISystemVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Var = null;
		}
	}
}
