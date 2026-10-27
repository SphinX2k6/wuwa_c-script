using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D7 RID: 26071
	public class IDisableBattleSkillOptionsT
	{
		// Token: 0x1700C17D RID: 49533
		// (get) Token: 0x0602D37C RID: 185212 RVA: 0x00632A9F File Offset: 0x00630C9F
		// (set) Token: 0x0602D37D RID: 185213 RVA: 0x00632AA7 File Offset: 0x00630CA7
		public bool IsDisablePhantomSkill { get; set; }

		// Token: 0x1700C17E RID: 49534
		// (get) Token: 0x0602D37E RID: 185214 RVA: 0x00632AB0 File Offset: 0x00630CB0
		// (set) Token: 0x0602D37F RID: 185215 RVA: 0x00632AB8 File Offset: 0x00630CB8
		public bool IsDisableCharacterSkill { get; set; }

		// Token: 0x1700C17F RID: 49535
		// (get) Token: 0x0602D380 RID: 185216 RVA: 0x00632AC1 File Offset: 0x00630CC1
		// (set) Token: 0x0602D381 RID: 185217 RVA: 0x00632AC9 File Offset: 0x00630CC9
		public IDisableCharacterSectionalSkillOptionT IsDisableCharacterSectionalSkill { get; set; }

		// Token: 0x1700C180 RID: 49536
		// (get) Token: 0x0602D382 RID: 185218 RVA: 0x00632AD2 File Offset: 0x00630CD2
		// (set) Token: 0x0602D383 RID: 185219 RVA: 0x00632ADA File Offset: 0x00630CDA
		public byte NullMask { get; set; }

		// Token: 0x0602D384 RID: 185220 RVA: 0x00632AE3 File Offset: 0x00630CE3
		public IDisableBattleSkillOptionsT()
		{
			this.IsDisablePhantomSkill = false;
			this.IsDisableCharacterSkill = false;
			this.IsDisableCharacterSectionalSkill = null;
			this.NullMask = 0;
		}
	}
}
