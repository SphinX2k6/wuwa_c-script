using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004215 RID: 16917
	public class ITrackRuleTypeBaseT
	{
		// Token: 0x1700782C RID: 30764
		// (get) Token: 0x06019007 RID: 102407 RVA: 0x003990CA File Offset: 0x003972CA
		// (set) Token: 0x06019008 RID: 102408 RVA: 0x003990D2 File Offset: 0x003972D2
		public ETrackRuleType Type { get; set; }

		// Token: 0x06019009 RID: 102409 RVA: 0x003990DB File Offset: 0x003972DB
		public ITrackRuleTypeBaseT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
		}
	}
}
