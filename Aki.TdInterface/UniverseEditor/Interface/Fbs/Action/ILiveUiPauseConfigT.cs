using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007146 RID: 28998
	public class ILiveUiPauseConfigT
	{
		// Token: 0x1700D442 RID: 54338
		// (get) Token: 0x0603260C RID: 206348 RVA: 0x006CF7C2 File Offset: 0x006CD9C2
		// (set) Token: 0x0603260D RID: 206349 RVA: 0x006CF7CA File Offset: 0x006CD9CA
		public ELiveUiType Type { get; set; }

		// Token: 0x0603260E RID: 206350 RVA: 0x006CF7D3 File Offset: 0x006CD9D3
		public ILiveUiPauseConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
