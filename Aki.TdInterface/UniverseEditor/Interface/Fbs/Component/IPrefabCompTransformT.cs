using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005776 RID: 22390
	public class IPrefabCompTransformT
	{
		// Token: 0x1700A703 RID: 42755
		// (get) Token: 0x06025883 RID: 153731 RVA: 0x0052D975 File Offset: 0x0052BB75
		// (set) Token: 0x06025884 RID: 153732 RVA: 0x0052D97D File Offset: 0x0052BB7D
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700A704 RID: 42756
		// (get) Token: 0x06025885 RID: 153733 RVA: 0x0052D986 File Offset: 0x0052BB86
		// (set) Token: 0x06025886 RID: 153734 RVA: 0x0052D98E File Offset: 0x0052BB8E
		public IPrefabCompTransformItemT Location { get; set; }

		// Token: 0x1700A705 RID: 42757
		// (get) Token: 0x06025887 RID: 153735 RVA: 0x0052D997 File Offset: 0x0052BB97
		// (set) Token: 0x06025888 RID: 153736 RVA: 0x0052D99F File Offset: 0x0052BB9F
		public IPrefabCompTransformItemT Rotation { get; set; }

		// Token: 0x1700A706 RID: 42758
		// (get) Token: 0x06025889 RID: 153737 RVA: 0x0052D9A8 File Offset: 0x0052BBA8
		// (set) Token: 0x0602588A RID: 153738 RVA: 0x0052D9B0 File Offset: 0x0052BBB0
		public IPrefabCompTransformItemT Scale { get; set; }

		// Token: 0x0602588B RID: 153739 RVA: 0x0052D9B9 File Offset: 0x0052BBB9
		public IPrefabCompTransformT()
		{
			this.ReferenceActorKey = null;
			this.Location = null;
			this.Rotation = null;
			this.Scale = null;
		}
	}
}
