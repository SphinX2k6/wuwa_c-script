using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633E RID: 25406
	public class ICharacterLookAtDataT
	{
		// Token: 0x1700BD9A RID: 48538
		// (get) Token: 0x0602BF2E RID: 180014 RVA: 0x0060A696 File Offset: 0x00608896
		// (set) Token: 0x0602BF2F RID: 180015 RVA: 0x0060A69E File Offset: 0x0060889E
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602BF30 RID: 180016 RVA: 0x0060A6A7 File Offset: 0x006088A7
		public ICharacterLookAtDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
