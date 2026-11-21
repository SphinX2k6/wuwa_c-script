using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063AB RID: 25515
	public class ICommonTargetT
	{
		// Token: 0x1700BC8F RID: 48271
		// (get) Token: 0x0602B53E RID: 177470 RVA: 0x005E7CA6 File Offset: 0x005E5EA6
		// (set) Token: 0x0602B53F RID: 177471 RVA: 0x005E7CAE File Offset: 0x005E5EAE
		public ECommonTargetType Type { get; set; }

		// Token: 0x0602B540 RID: 177472 RVA: 0x005E7CB7 File Offset: 0x005E5EB7
		public ICommonTargetT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
