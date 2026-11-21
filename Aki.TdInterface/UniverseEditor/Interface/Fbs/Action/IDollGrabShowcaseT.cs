using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C75 RID: 27765
	public class IDollGrabShowcaseT
	{
		// Token: 0x1700CBA8 RID: 52136
		// (get) Token: 0x0602FD56 RID: 195926 RVA: 0x00683AE4 File Offset: 0x00681CE4
		// (set) Token: 0x0602FD57 RID: 195927 RVA: 0x00683AEC File Offset: 0x00681CEC
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CBA9 RID: 52137
		// (get) Token: 0x0602FD58 RID: 195928 RVA: 0x00683AF5 File Offset: 0x00681CF5
		// (set) Token: 0x0602FD59 RID: 195929 RVA: 0x00683AFD File Offset: 0x00681CFD
		public int ShowcaseEntityId { get; set; }

		// Token: 0x0602FD5A RID: 195930 RVA: 0x00683B06 File Offset: 0x00681D06
		public IDollGrabShowcaseT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ShowcaseEntityId = 0;
		}
	}
}
