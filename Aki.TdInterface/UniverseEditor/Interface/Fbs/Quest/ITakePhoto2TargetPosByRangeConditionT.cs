using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A0 RID: 16800
	public class ITakePhoto2TargetPosByRangeConditionT
	{
		// Token: 0x17007727 RID: 30503
		// (get) Token: 0x06018BA6 RID: 101286 RVA: 0x0038F8B5 File Offset: 0x0038DAB5
		// (set) Token: 0x06018BA7 RID: 101287 RVA: 0x0038F8BD File Offset: 0x0038DABD
		public TRangeUnion Range { get; set; }

		// Token: 0x06018BA8 RID: 101288 RVA: 0x0038F8C6 File Offset: 0x0038DAC6
		public ITakePhoto2TargetPosByRangeConditionT()
		{
			this.Range = null;
		}
	}
}
