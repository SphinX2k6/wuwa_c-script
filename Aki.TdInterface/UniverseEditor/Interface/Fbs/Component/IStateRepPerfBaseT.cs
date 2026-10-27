using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AE RID: 22958
	public class IStateRepPerfBaseT
	{
		// Token: 0x1700AC4D RID: 44109
		// (get) Token: 0x06026E58 RID: 159320 RVA: 0x0055A23A File Offset: 0x0055843A
		// (set) Token: 0x06026E59 RID: 159321 RVA: 0x0055A242 File Offset: 0x00558442
		public EStateRepPerfType Type { get; set; }

		// Token: 0x06026E5A RID: 159322 RVA: 0x0055A24B File Offset: 0x0055844B
		public IStateRepPerfBaseT()
		{
			this.Type = EStateRepPerfType.SkillId;
		}
	}
}
