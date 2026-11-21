using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF0 RID: 16112
	public class ITimeDisplayMaterialParamsT
	{
		// Token: 0x17006D13 RID: 27923
		// (get) Token: 0x06015D92 RID: 89490 RVA: 0x00324757 File Offset: 0x00322957
		// (set) Token: 0x06015D93 RID: 89491 RVA: 0x0032475F File Offset: 0x0032295F
		public EParamsPreset Type { get; set; }

		// Token: 0x17006D14 RID: 27924
		// (get) Token: 0x06015D94 RID: 89492 RVA: 0x00324768 File Offset: 0x00322968
		// (set) Token: 0x06015D95 RID: 89493 RVA: 0x00324770 File Offset: 0x00322970
		public TTimeDisplayParamsUnion TimeDisplayParams { get; set; }

		// Token: 0x06015D96 RID: 89494 RVA: 0x00324779 File Offset: 0x00322979
		public ITimeDisplayMaterialParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.TimeDisplayParams = null;
		}
	}
}
