using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004584 RID: 17796
	public class ISpecificMonsterDeadPositionT
	{
		// Token: 0x17007C56 RID: 31830
		// (get) Token: 0x06019EBE RID: 106174 RVA: 0x003B24DB File Offset: 0x003B06DB
		// (set) Token: 0x06019EBF RID: 106175 RVA: 0x003B24E3 File Offset: 0x003B06E3
		public ESpecificDeadMonsterType MonsterType { get; set; }

		// Token: 0x17007C57 RID: 31831
		// (get) Token: 0x06019EC0 RID: 106176 RVA: 0x003B24EC File Offset: 0x003B06EC
		// (set) Token: 0x06019EC1 RID: 106177 RVA: 0x003B24F4 File Offset: 0x003B06F4
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007C58 RID: 31832
		// (get) Token: 0x06019EC2 RID: 106178 RVA: 0x003B24FD File Offset: 0x003B06FD
		// (set) Token: 0x06019EC3 RID: 106179 RVA: 0x003B2505 File Offset: 0x003B0705
		public bool IsIgnoreRot { get; set; }

		// Token: 0x17007C59 RID: 31833
		// (get) Token: 0x06019EC4 RID: 106180 RVA: 0x003B250E File Offset: 0x003B070E
		// (set) Token: 0x06019EC5 RID: 106181 RVA: 0x003B2516 File Offset: 0x003B0716
		public byte NullMask { get; set; }

		// Token: 0x06019EC6 RID: 106182 RVA: 0x003B251F File Offset: 0x003B071F
		public ISpecificMonsterDeadPositionT()
		{
			this.MonsterType = ESpecificDeadMonsterType.LastDead;
			this.Var = null;
			this.IsIgnoreRot = false;
			this.NullMask = 0;
		}
	}
}
