using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B7 RID: 17335
	public class IOccupationTypeT
	{
		// Token: 0x17007A9C RID: 31388
		// (get) Token: 0x06019D74 RID: 105844 RVA: 0x003B2FA6 File Offset: 0x003B11A6
		// (set) Token: 0x06019D75 RID: 105845 RVA: 0x003B2FAE File Offset: 0x003B11AE
		public EOccupationType Type { get; set; }

		// Token: 0x06019D76 RID: 105846 RVA: 0x003B2FB7 File Offset: 0x003B11B7
		public IOccupationTypeT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
