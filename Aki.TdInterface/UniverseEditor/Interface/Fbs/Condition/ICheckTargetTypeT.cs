using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200503B RID: 20539
	public class ICheckTargetTypeT
	{
		// Token: 0x170092F9 RID: 37625
		// (get) Token: 0x06020185 RID: 131461 RVA: 0x00473E0E File Offset: 0x0047200E
		// (set) Token: 0x06020186 RID: 131462 RVA: 0x00473E16 File Offset: 0x00472016
		public ECheckTargetType Type { get; set; }

		// Token: 0x06020187 RID: 131463 RVA: 0x00473E1F File Offset: 0x0047201F
		public ICheckTargetTypeT()
		{
			this.Type = ECheckTargetType.AllPlayer;
		}
	}
}
