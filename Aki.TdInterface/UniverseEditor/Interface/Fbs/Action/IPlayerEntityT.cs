using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746C RID: 29804
	public class IPlayerEntityT
	{
		// Token: 0x1700DAFC RID: 56060
		// (get) Token: 0x060342D3 RID: 213715 RVA: 0x00707786 File Offset: 0x00705986
		// (set) Token: 0x060342D4 RID: 213716 RVA: 0x0070778E File Offset: 0x0070598E
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700DAFD RID: 56061
		// (get) Token: 0x060342D5 RID: 213717 RVA: 0x00707797 File Offset: 0x00705997
		// (set) Token: 0x060342D6 RID: 213718 RVA: 0x0070779F File Offset: 0x0070599F
		public EPlayerTargetType PlayerTargetType { get; set; }

		// Token: 0x1700DAFE RID: 56062
		// (get) Token: 0x060342D7 RID: 213719 RVA: 0x007077A8 File Offset: 0x007059A8
		// (set) Token: 0x060342D8 RID: 213720 RVA: 0x007077B0 File Offset: 0x007059B0
		public byte NullMask { get; set; }

		// Token: 0x060342D9 RID: 213721 RVA: 0x007077B9 File Offset: 0x007059B9
		public IPlayerEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.PlayerTargetType = EPlayerTargetType.CurrentRole;
			this.NullMask = 0;
		}
	}
}
