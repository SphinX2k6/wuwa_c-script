using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F18 RID: 16152
	public class ILogicProgramSpecialProcessOperationT
	{
		// Token: 0x17007057 RID: 28759
		// (get) Token: 0x06016EE8 RID: 93928 RVA: 0x0034F37E File Offset: 0x0034D57E
		// (set) Token: 0x06016EE9 RID: 93929 RVA: 0x0034F386 File Offset: 0x0034D586
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x06016EEA RID: 93930 RVA: 0x0034F38F File Offset: 0x0034D58F
		public ILogicProgramSpecialProcessOperationT()
		{
			this.Type = ELogicProgramSpecialProcess.DisableURO;
		}
	}
}
