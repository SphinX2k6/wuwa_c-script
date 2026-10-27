using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006637 RID: 26167
	public class IElementalBoxTargetPrefabPosT
	{
		// Token: 0x1700C264 RID: 49764
		// (get) Token: 0x0602D711 RID: 186129 RVA: 0x0063983F File Offset: 0x00637A3F
		// (set) Token: 0x0602D712 RID: 186130 RVA: 0x00639847 File Offset: 0x00637A47
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700C265 RID: 49765
		// (get) Token: 0x0602D713 RID: 186131 RVA: 0x00639850 File Offset: 0x00637A50
		// (set) Token: 0x0602D714 RID: 186132 RVA: 0x00639858 File Offset: 0x00637A58
		public string TargetKey { get; set; }

		// Token: 0x0602D715 RID: 186133 RVA: 0x00639861 File Offset: 0x00637A61
		public IElementalBoxTargetPrefabPosT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			this.TargetKey = null;
		}
	}
}
