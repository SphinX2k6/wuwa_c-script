using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061CF RID: 25039
	public class IWuWaGoHintStepInteractT
	{
		// Token: 0x1700BAB2 RID: 47794
		// (get) Token: 0x0602A929 RID: 174377 RVA: 0x005CE21A File Offset: 0x005CC41A
		// (set) Token: 0x0602A92A RID: 174378 RVA: 0x005CE222 File Offset: 0x005CC422
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x0602A92B RID: 174379 RVA: 0x005CE22B File Offset: 0x005CC42B
		public IWuWaGoHintStepInteractT()
		{
			this.Type = EWuWaGoHintStepType.Move;
		}
	}
}
