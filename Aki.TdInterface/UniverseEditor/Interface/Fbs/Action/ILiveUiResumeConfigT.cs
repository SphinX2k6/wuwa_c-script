using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007149 RID: 29001
	public class ILiveUiResumeConfigT
	{
		// Token: 0x1700D445 RID: 54341
		// (get) Token: 0x0603261E RID: 206366 RVA: 0x006CF93A File Offset: 0x006CDB3A
		// (set) Token: 0x0603261F RID: 206367 RVA: 0x006CF942 File Offset: 0x006CDB42
		public ELiveUiType Type { get; set; }

		// Token: 0x06032620 RID: 206368 RVA: 0x006CF94B File Offset: 0x006CDB4B
		public ILiveUiResumeConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
