using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B7 RID: 22199
	public class IParkourSplinePointT
	{
		// Token: 0x1700A52D RID: 42285
		// (get) Token: 0x06025126 RID: 151846 RVA: 0x0051E6BF File Offset: 0x0051C8BF
		// (set) Token: 0x06025127 RID: 151847 RVA: 0x0051E6C7 File Offset: 0x0051C8C7
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A52E RID: 42286
		// (get) Token: 0x06025128 RID: 151848 RVA: 0x0051E6D0 File Offset: 0x0051C8D0
		// (set) Token: 0x06025129 RID: 151849 RVA: 0x0051E6D8 File Offset: 0x0051C8D8
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700A52F RID: 42287
		// (get) Token: 0x0602512A RID: 151850 RVA: 0x0051E6E1 File Offset: 0x0051C8E1
		// (set) Token: 0x0602512B RID: 151851 RVA: 0x0051E6E9 File Offset: 0x0051C8E9
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700A530 RID: 42288
		// (get) Token: 0x0602512C RID: 151852 RVA: 0x0051E6F2 File Offset: 0x0051C8F2
		// (set) Token: 0x0602512D RID: 151853 RVA: 0x0051E6FA File Offset: 0x0051C8FA
		public ESplineLine LineType { get; set; }

		// Token: 0x1700A531 RID: 42289
		// (get) Token: 0x0602512E RID: 151854 RVA: 0x0051E703 File Offset: 0x0051C903
		// (set) Token: 0x0602512F RID: 151855 RVA: 0x0051E70B File Offset: 0x0051C90B
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700A532 RID: 42290
		// (get) Token: 0x06025130 RID: 151856 RVA: 0x0051E714 File Offset: 0x0051C914
		// (set) Token: 0x06025131 RID: 151857 RVA: 0x0051E71C File Offset: 0x0051C91C
		public int Radius { get; set; }

		// Token: 0x1700A533 RID: 42291
		// (get) Token: 0x06025132 RID: 151858 RVA: 0x0051E725 File Offset: 0x0051C925
		// (set) Token: 0x06025133 RID: 151859 RVA: 0x0051E72D File Offset: 0x0051C92D
		public float ModifiedTime { get; set; }

		// Token: 0x1700A534 RID: 42292
		// (get) Token: 0x06025134 RID: 151860 RVA: 0x0051E736 File Offset: 0x0051C936
		// (set) Token: 0x06025135 RID: 151861 RVA: 0x0051E73E File Offset: 0x0051C93E
		public long BuffId { get; set; }

		// Token: 0x1700A535 RID: 42293
		// (get) Token: 0x06025136 RID: 151862 RVA: 0x0051E747 File Offset: 0x0051C947
		// (set) Token: 0x06025137 RID: 151863 RVA: 0x0051E74F File Offset: 0x0051C94F
		public IPointGroupT PointGroup { get; set; }

		// Token: 0x1700A536 RID: 42294
		// (get) Token: 0x06025138 RID: 151864 RVA: 0x0051E758 File Offset: 0x0051C958
		// (set) Token: 0x06025139 RID: 151865 RVA: 0x0051E760 File Offset: 0x0051C960
		public string PlayerTag { get; set; }

		// Token: 0x1700A537 RID: 42295
		// (get) Token: 0x0602513A RID: 151866 RVA: 0x0051E769 File Offset: 0x0051C969
		// (set) Token: 0x0602513B RID: 151867 RVA: 0x0051E771 File Offset: 0x0051C971
		public byte NullMask { get; set; }

		// Token: 0x0602513C RID: 151868 RVA: 0x0051E77C File Offset: 0x0051C97C
		public IParkourSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Radius = 0;
			this.ModifiedTime = 0f;
			this.BuffId = 0L;
			this.PointGroup = null;
			this.PlayerTag = null;
			this.NullMask = 0;
		}
	}
}
