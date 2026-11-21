using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3F RID: 27711
	public class IDisableBattleSkillOptionsT
	{
		// Token: 0x1700CB0C RID: 51980
		// (get) Token: 0x0602FB00 RID: 195328 RVA: 0x0067EC63 File Offset: 0x0067CE63
		// (set) Token: 0x0602FB01 RID: 195329 RVA: 0x0067EC6B File Offset: 0x0067CE6B
		public bool IsDisablePhantomSkill { get; set; }

		// Token: 0x1700CB0D RID: 51981
		// (get) Token: 0x0602FB02 RID: 195330 RVA: 0x0067EC74 File Offset: 0x0067CE74
		// (set) Token: 0x0602FB03 RID: 195331 RVA: 0x0067EC7C File Offset: 0x0067CE7C
		public bool IsDisableCharacterSkill { get; set; }

		// Token: 0x1700CB0E RID: 51982
		// (get) Token: 0x0602FB04 RID: 195332 RVA: 0x0067EC85 File Offset: 0x0067CE85
		// (set) Token: 0x0602FB05 RID: 195333 RVA: 0x0067EC8D File Offset: 0x0067CE8D
		public IDisableCharacterSectionalSkillOptionT IsDisableCharacterSectionalSkill { get; set; }

		// Token: 0x1700CB0F RID: 51983
		// (get) Token: 0x0602FB06 RID: 195334 RVA: 0x0067EC96 File Offset: 0x0067CE96
		// (set) Token: 0x0602FB07 RID: 195335 RVA: 0x0067EC9E File Offset: 0x0067CE9E
		public byte NullMask { get; set; }

		// Token: 0x0602FB08 RID: 195336 RVA: 0x0067ECA7 File Offset: 0x0067CEA7
		public IDisableBattleSkillOptionsT()
		{
			this.IsDisablePhantomSkill = false;
			this.IsDisableCharacterSkill = false;
			this.IsDisableCharacterSectionalSkill = null;
			this.NullMask = 0;
		}
	}
}
