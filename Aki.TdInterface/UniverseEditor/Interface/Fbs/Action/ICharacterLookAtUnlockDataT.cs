using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C1 RID: 27073
	public class ICharacterLookAtUnlockDataT
	{
		// Token: 0x1700C737 RID: 50999
		// (get) Token: 0x0602E70E RID: 190222 RVA: 0x006562EE File Offset: 0x006544EE
		// (set) Token: 0x0602E70F RID: 190223 RVA: 0x006562F6 File Offset: 0x006544F6
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602E710 RID: 190224 RVA: 0x006562FF File Offset: 0x006544FF
		public ICharacterLookAtUnlockDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
