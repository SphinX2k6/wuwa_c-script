using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A5 RID: 24741
	public class IActorFaceExpressionTypeT
	{
		// Token: 0x1700B652 RID: 46674
		// (get) Token: 0x0602A3C2 RID: 172994 RVA: 0x005D288E File Offset: 0x005D0A8E
		// (set) Token: 0x0602A3C3 RID: 172995 RVA: 0x005D2896 File Offset: 0x005D0A96
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x0602A3C4 RID: 172996 RVA: 0x005D289F File Offset: 0x005D0A9F
		public IActorFaceExpressionTypeT()
		{
			this.Type = EActorFaceExpressionType.Play;
		}
	}
}
