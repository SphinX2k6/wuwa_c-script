using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007520 RID: 29984
	public class IPreprocessOperationConfigT
	{
		// Token: 0x1700DCA4 RID: 56484
		// (get) Token: 0x06034965 RID: 215397 RVA: 0x00713CD6 File Offset: 0x00711ED6
		// (set) Token: 0x06034966 RID: 215398 RVA: 0x00713CDE File Offset: 0x00711EDE
		public EPreprocessOperation Type { get; set; }

		// Token: 0x06034967 RID: 215399 RVA: 0x00713CE7 File Offset: 0x00711EE7
		public IPreprocessOperationConfigT()
		{
			this.Type = EPreprocessOperation.FloatingSubtitleLanguageDiff;
		}
	}
}
