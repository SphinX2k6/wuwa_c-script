using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBC RID: 23484
	public class IWuWaGoHintStepMoveT
	{
		// Token: 0x1700B16E RID: 45422
		// (get) Token: 0x06028379 RID: 164729 RVA: 0x005869CF File Offset: 0x00584BCF
		// (set) Token: 0x0602837A RID: 164730 RVA: 0x005869D7 File Offset: 0x00584BD7
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x1700B16F RID: 45423
		// (get) Token: 0x0602837B RID: 164731 RVA: 0x005869E0 File Offset: 0x00584BE0
		// (set) Token: 0x0602837C RID: 164732 RVA: 0x005869E8 File Offset: 0x00584BE8
		public IVectorInfoT Position { get; set; }

		// Token: 0x0602837D RID: 164733 RVA: 0x005869F1 File Offset: 0x00584BF1
		public IWuWaGoHintStepMoveT()
		{
			this.Type = EWuWaGoHintStepType.Move;
			this.Position = null;
		}
	}
}
