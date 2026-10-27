using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C4 RID: 25284
	public class IChangeActorMPCT
	{
		// Token: 0x1700BCC0 RID: 48320
		// (get) Token: 0x0602BB33 RID: 178995 RVA: 0x00603ACF File Offset: 0x00601CCF
		// (set) Token: 0x0602BB34 RID: 178996 RVA: 0x00603AD7 File Offset: 0x00601CD7
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x1700BCC1 RID: 48321
		// (get) Token: 0x0602BB35 RID: 178997 RVA: 0x00603AE0 File Offset: 0x00601CE0
		// (set) Token: 0x0602BB36 RID: 178998 RVA: 0x00603AE8 File Offset: 0x00601CE8
		public string MpcData { get; set; }

		// Token: 0x0602BB37 RID: 178999 RVA: 0x00603AF1 File Offset: 0x00601CF1
		public IChangeActorMPCT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
			this.MpcData = null;
		}
	}
}
