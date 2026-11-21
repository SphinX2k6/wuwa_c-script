using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007463 RID: 29795
	public class IPlayerAiControlBaseT
	{
		// Token: 0x1700DAF2 RID: 56050
		// (get) Token: 0x0603429D RID: 213661 RVA: 0x0070728E File Offset: 0x0070548E
		// (set) Token: 0x0603429E RID: 213662 RVA: 0x00707296 File Offset: 0x00705496
		public EPlayerAiControlType Type { get; set; }

		// Token: 0x0603429F RID: 213663 RVA: 0x0070729F File Offset: 0x0070549F
		public IPlayerAiControlBaseT()
		{
			this.Type = EPlayerAiControlType.Enable;
		}
	}
}
