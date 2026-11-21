using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006935 RID: 26933
	public class IChangeActorMPCT
	{
		// Token: 0x1700C64A RID: 50762
		// (get) Token: 0x0602E29C RID: 189084 RVA: 0x0064EADB File Offset: 0x0064CCDB
		// (set) Token: 0x0602E29D RID: 189085 RVA: 0x0064EAE3 File Offset: 0x0064CCE3
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x1700C64B RID: 50763
		// (get) Token: 0x0602E29E RID: 189086 RVA: 0x0064EAEC File Offset: 0x0064CCEC
		// (set) Token: 0x0602E29F RID: 189087 RVA: 0x0064EAF4 File Offset: 0x0064CCF4
		public string MpcData { get; set; }

		// Token: 0x0602E2A0 RID: 189088 RVA: 0x0064EAFD File Offset: 0x0064CCFD
		public IChangeActorMPCT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
			this.MpcData = null;
		}
	}
}
