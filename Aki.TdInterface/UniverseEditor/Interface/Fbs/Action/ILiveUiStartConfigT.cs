using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714F RID: 29007
	public class ILiveUiStartConfigT
	{
		// Token: 0x1700D44B RID: 54347
		// (get) Token: 0x06032642 RID: 206402 RVA: 0x006CFC2A File Offset: 0x006CDE2A
		// (set) Token: 0x06032643 RID: 206403 RVA: 0x006CFC32 File Offset: 0x006CDE32
		public ELiveUiType Type { get; set; }

		// Token: 0x06032644 RID: 206404 RVA: 0x006CFC3B File Offset: 0x006CDE3B
		public ILiveUiStartConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
