using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E67 RID: 28263
	public class IFloatingSubtitleLanguageDiffT
	{
		// Token: 0x1700CF1F RID: 53023
		// (get) Token: 0x06030D31 RID: 199985 RVA: 0x0069FE76 File Offset: 0x0069E076
		// (set) Token: 0x06030D32 RID: 199986 RVA: 0x0069FE7E File Offset: 0x0069E07E
		public EPreprocessOperation Type { get; set; }

		// Token: 0x06030D33 RID: 199987 RVA: 0x0069FE87 File Offset: 0x0069E087
		public IFloatingSubtitleLanguageDiffT()
		{
			this.Type = EPreprocessOperation.FloatingSubtitleLanguageDiff;
		}
	}
}
