using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634A RID: 25418
	public class ICharacterLookAtPlayerDataT
	{
		// Token: 0x1700BDA7 RID: 48551
		// (get) Token: 0x0602BF7C RID: 180092 RVA: 0x0060AD96 File Offset: 0x00608F96
		// (set) Token: 0x0602BF7D RID: 180093 RVA: 0x0060AD9E File Offset: 0x00608F9E
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602BF7E RID: 180094 RVA: 0x0060ADA7 File Offset: 0x00608FA7
		public ICharacterLookAtPlayerDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
