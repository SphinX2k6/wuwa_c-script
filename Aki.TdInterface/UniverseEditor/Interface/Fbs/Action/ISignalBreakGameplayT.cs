using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D6 RID: 30934
	public class ISignalBreakGameplayT
	{
		// Token: 0x1700E300 RID: 58112
		// (get) Token: 0x06036779 RID: 223097 RVA: 0x0074AED7 File Offset: 0x007490D7
		// (set) Token: 0x0603677A RID: 223098 RVA: 0x0074AEDF File Offset: 0x007490DF
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E301 RID: 58113
		// (get) Token: 0x0603677B RID: 223099 RVA: 0x0074AEE8 File Offset: 0x007490E8
		// (set) Token: 0x0603677C RID: 223100 RVA: 0x0074AEF0 File Offset: 0x007490F0
		public string SignalBreakId { get; set; }

		// Token: 0x0603677D RID: 223101 RVA: 0x0074AEF9 File Offset: 0x007490F9
		public ISignalBreakGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SignalBreakId = null;
		}
	}
}
