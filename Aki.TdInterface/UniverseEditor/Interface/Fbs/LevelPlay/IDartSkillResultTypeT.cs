using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448F RID: 17551
	public class IDartSkillResultTypeT
	{
		// Token: 0x17007BD7 RID: 31703
		// (get) Token: 0x0601A2DC RID: 107228 RVA: 0x003BD3EE File Offset: 0x003BB5EE
		// (set) Token: 0x0601A2DD RID: 107229 RVA: 0x003BD3F6 File Offset: 0x003BB5F6
		public EDartSkillResultType Type { get; set; }

		// Token: 0x0601A2DE RID: 107230 RVA: 0x003BD3FF File Offset: 0x003BB5FF
		public IDartSkillResultTypeT()
		{
			this.Type = EDartSkillResultType.NoBust;
		}
	}
}
