using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C94 RID: 23700
	public class IPasserbyNpcMoveBaseT
	{
		// Token: 0x1700AE15 RID: 44565
		// (get) Token: 0x06027503 RID: 161027 RVA: 0x00561FBE File Offset: 0x005601BE
		// (set) Token: 0x06027504 RID: 161028 RVA: 0x00561FC6 File Offset: 0x005601C6
		public EPasserbyNpcMoveType Type { get; set; }

		// Token: 0x06027505 RID: 161029 RVA: 0x00561FCF File Offset: 0x005601CF
		public IPasserbyNpcMoveBaseT()
		{
			this.Type = EPasserbyNpcMoveType.Spline;
		}
	}
}
