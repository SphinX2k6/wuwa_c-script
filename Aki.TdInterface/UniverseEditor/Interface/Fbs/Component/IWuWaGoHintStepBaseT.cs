using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C9 RID: 25033
	public class IWuWaGoHintStepBaseT
	{
		// Token: 0x1700BAAD RID: 47789
		// (get) Token: 0x0602A909 RID: 174345 RVA: 0x005CDF5A File Offset: 0x005CC15A
		// (set) Token: 0x0602A90A RID: 174346 RVA: 0x005CDF62 File Offset: 0x005CC162
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x0602A90B RID: 174347 RVA: 0x005CDF6B File Offset: 0x005CC16B
		public IWuWaGoHintStepBaseT()
		{
			this.Type = EWuWaGoHintStepType.Move;
		}
	}
}
