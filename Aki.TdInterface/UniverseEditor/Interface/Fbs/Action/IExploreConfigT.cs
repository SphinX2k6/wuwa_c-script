using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673F RID: 26431
	public class IExploreConfigT
	{
		// Token: 0x1700C440 RID: 50240
		// (get) Token: 0x0602DF9D RID: 188317 RVA: 0x00648AD2 File Offset: 0x00646CD2
		// (set) Token: 0x0602DF9E RID: 188318 RVA: 0x00648ADA File Offset: 0x00646CDA
		public EExploreStateType Type { get; set; }

		// Token: 0x0602DF9F RID: 188319 RVA: 0x00648AE3 File Offset: 0x00646CE3
		public IExploreConfigT()
		{
			this.Type = EExploreStateType.TeleControl;
		}
	}
}
