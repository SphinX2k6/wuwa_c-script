using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7E RID: 28542
	public class IHeadStyleMonsterDisplayT
	{
		// Token: 0x1700D10F RID: 53519
		// (get) Token: 0x06031672 RID: 202354 RVA: 0x006B2F08 File Offset: 0x006B1108
		// (set) Token: 0x06031673 RID: 202355 RVA: 0x006B2F10 File Offset: 0x006B1110
		public EHeadStyle Type { get; set; }

		// Token: 0x1700D110 RID: 53520
		// (get) Token: 0x06031674 RID: 202356 RVA: 0x006B2F19 File Offset: 0x006B1119
		// (set) Token: 0x06031675 RID: 202357 RVA: 0x006B2F21 File Offset: 0x006B1121
		public int MonsterDisplayId { get; set; }

		// Token: 0x06031676 RID: 202358 RVA: 0x006B2F2A File Offset: 0x006B112A
		public IHeadStyleMonsterDisplayT()
		{
			this.Type = EHeadStyle.Normal;
			this.MonsterDisplayId = 0;
		}
	}
}
