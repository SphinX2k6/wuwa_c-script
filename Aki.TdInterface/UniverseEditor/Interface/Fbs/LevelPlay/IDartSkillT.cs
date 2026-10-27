using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004480 RID: 17536
	public class IDartSkillT
	{
		// Token: 0x17007BC4 RID: 31684
		// (get) Token: 0x0601A25E RID: 107102 RVA: 0x003BC3AA File Offset: 0x003BA5AA
		// (set) Token: 0x0601A25F RID: 107103 RVA: 0x003BC3B2 File Offset: 0x003BA5B2
		public IDartSkillConditionGroupT ConditionGroup { get; set; }

		// Token: 0x17007BC5 RID: 31685
		// (get) Token: 0x0601A260 RID: 107104 RVA: 0x003BC3BB File Offset: 0x003BA5BB
		// (set) Token: 0x0601A261 RID: 107105 RVA: 0x003BC3C3 File Offset: 0x003BA5C3
		public TDartSkillResultUnion Result { get; set; }

		// Token: 0x17007BC6 RID: 31686
		// (get) Token: 0x0601A262 RID: 107106 RVA: 0x003BC3CC File Offset: 0x003BA5CC
		// (set) Token: 0x0601A263 RID: 107107 RVA: 0x003BC3D4 File Offset: 0x003BA5D4
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x0601A264 RID: 107108 RVA: 0x003BC3DD File Offset: 0x003BA5DD
		public IDartSkillT()
		{
			this.ConditionGroup = null;
			this.Result = null;
			this.Bubble = null;
		}
	}
}
