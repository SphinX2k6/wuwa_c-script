using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEE RID: 27886
	public class IPlayerBlendAnimTargetT
	{
		// Token: 0x1700CFB3 RID: 53171
		// (get) Token: 0x060312C9 RID: 201417 RVA: 0x006AC01E File Offset: 0x006AA21E
		// (set) Token: 0x060312CA RID: 201418 RVA: 0x006AC026 File Offset: 0x006AA226
		public EBlendAnimTarget Type { get; set; }

		// Token: 0x060312CB RID: 201419 RVA: 0x006AC02F File Offset: 0x006AA22F
		public IPlayerBlendAnimTargetT()
		{
			this.Type = EBlendAnimTarget.Player;
		}
	}
}
