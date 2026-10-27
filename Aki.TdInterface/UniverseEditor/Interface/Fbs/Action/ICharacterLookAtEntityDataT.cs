using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006347 RID: 25415
	public class ICharacterLookAtEntityDataT
	{
		// Token: 0x1700BDA3 RID: 48547
		// (get) Token: 0x0602BF68 RID: 180072 RVA: 0x0060ABF8 File Offset: 0x00608DF8
		// (set) Token: 0x0602BF69 RID: 180073 RVA: 0x0060AC00 File Offset: 0x00608E00
		public ECharacterLookAt Type { get; set; }

		// Token: 0x1700BDA4 RID: 48548
		// (get) Token: 0x0602BF6A RID: 180074 RVA: 0x0060AC09 File Offset: 0x00608E09
		// (set) Token: 0x0602BF6B RID: 180075 RVA: 0x0060AC11 File Offset: 0x00608E11
		public int EntityId { get; set; }

		// Token: 0x0602BF6C RID: 180076 RVA: 0x0060AC1A File Offset: 0x00608E1A
		public ICharacterLookAtEntityDataT()
		{
			this.Type = ECharacterLookAt.Empty;
			this.EntityId = 0;
		}
	}
}
