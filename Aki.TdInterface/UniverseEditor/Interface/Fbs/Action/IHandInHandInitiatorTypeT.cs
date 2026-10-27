using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C2 RID: 26818
	public class IHandInHandInitiatorTypeT
	{
		// Token: 0x1700C709 RID: 50953
		// (get) Token: 0x0602EC7A RID: 191610 RVA: 0x006627AE File Offset: 0x006609AE
		// (set) Token: 0x0602EC7B RID: 191611 RVA: 0x006627B6 File Offset: 0x006609B6
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x0602EC7C RID: 191612 RVA: 0x006627BF File Offset: 0x006609BF
		public IHandInHandInitiatorTypeT()
		{
			this.Type = EHandInHandInitiatorType.Player;
		}
	}
}
