using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFC RID: 28668
	public class IInfrActivityBuildStageOptionT
	{
		// Token: 0x1700D1F9 RID: 53753
		// (get) Token: 0x06031AD6 RID: 203478 RVA: 0x006BA782 File Offset: 0x006B8982
		// (set) Token: 0x06031AD7 RID: 203479 RVA: 0x006BA78A File Offset: 0x006B898A
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x06031AD8 RID: 203480 RVA: 0x006BA793 File Offset: 0x006B8993
		public IInfrActivityBuildStageOptionT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
		}
	}
}
