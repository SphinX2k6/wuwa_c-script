using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F7 RID: 18679
	public class IDartSkillResultTypeT
	{
		// Token: 0x17008216 RID: 33302
		// (get) Token: 0x0601BAAD RID: 113325 RVA: 0x003E95FA File Offset: 0x003E77FA
		// (set) Token: 0x0601BAAE RID: 113326 RVA: 0x003E9602 File Offset: 0x003E7802
		public EDartSkillResultType Type { get; set; }

		// Token: 0x0601BAAF RID: 113327 RVA: 0x003E960B File Offset: 0x003E780B
		public IDartSkillResultTypeT()
		{
			this.Type = EDartSkillResultType.NoBust;
		}
	}
}
