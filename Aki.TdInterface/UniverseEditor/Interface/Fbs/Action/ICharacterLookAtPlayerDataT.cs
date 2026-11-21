using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BB RID: 27067
	public class ICharacterLookAtPlayerDataT
	{
		// Token: 0x1700C72F RID: 50991
		// (get) Token: 0x0602E6E6 RID: 190182 RVA: 0x00655EEA File Offset: 0x006540EA
		// (set) Token: 0x0602E6E7 RID: 190183 RVA: 0x00655EF2 File Offset: 0x006540F2
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602E6E8 RID: 190184 RVA: 0x00655EFB File Offset: 0x006540FB
		public ICharacterLookAtPlayerDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
