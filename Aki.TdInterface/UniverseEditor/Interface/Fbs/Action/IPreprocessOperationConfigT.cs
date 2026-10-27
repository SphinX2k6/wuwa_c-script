using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA5 RID: 28069
	public class IPreprocessOperationConfigT
	{
		// Token: 0x1700D15C RID: 53596
		// (get) Token: 0x06031969 RID: 203113 RVA: 0x006B85EE File Offset: 0x006B67EE
		// (set) Token: 0x0603196A RID: 203114 RVA: 0x006B85F6 File Offset: 0x006B67F6
		public EPreprocessOperation Type { get; set; }

		// Token: 0x0603196B RID: 203115 RVA: 0x006B85FF File Offset: 0x006B67FF
		public IPreprocessOperationConfigT()
		{
			this.Type = EPreprocessOperation.FloatingSubtitleLanguageDiff;
		}
	}
}
