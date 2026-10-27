using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006949 RID: 26953
	public class IInfrActivityBuildStageOptionT
	{
		// Token: 0x1700C7F6 RID: 51190
		// (get) Token: 0x0602F106 RID: 192774 RVA: 0x0066A29A File Offset: 0x0066849A
		// (set) Token: 0x0602F107 RID: 192775 RVA: 0x0066A2A2 File Offset: 0x006684A2
		public EInfrActivityBuildStageType Type { get; set; }

		// Token: 0x0602F108 RID: 192776 RVA: 0x0066A2AB File Offset: 0x006684AB
		public IInfrActivityBuildStageOptionT()
		{
			this.Type = EInfrActivityBuildStageType.Infrastructure;
		}
	}
}
