using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004356 RID: 17238
	public class ILogicProgramSpecialProcessOperationT
	{
		// Token: 0x17007646 RID: 30278
		// (get) Token: 0x06018540 RID: 99648 RVA: 0x003785A6 File Offset: 0x003767A6
		// (set) Token: 0x06018541 RID: 99649 RVA: 0x003785AE File Offset: 0x003767AE
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x06018542 RID: 99650 RVA: 0x003785B7 File Offset: 0x003767B7
		public ILogicProgramSpecialProcessOperationT()
		{
			this.Type = ELogicProgramSpecialProcess.DisableURO;
		}
	}
}
