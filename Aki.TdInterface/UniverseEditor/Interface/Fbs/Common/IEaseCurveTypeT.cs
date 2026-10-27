using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D9B RID: 23963
	public class IEaseCurveTypeT
	{
		// Token: 0x1700B378 RID: 45944
		// (get) Token: 0x06029030 RID: 167984 RVA: 0x005A1E5E File Offset: 0x005A005E
		// (set) Token: 0x06029031 RID: 167985 RVA: 0x005A1E66 File Offset: 0x005A0066
		public EEaseCurveType Type { get; set; }

		// Token: 0x06029032 RID: 167986 RVA: 0x005A1E6F File Offset: 0x005A006F
		public IEaseCurveTypeT()
		{
			this.Type = EEaseCurveType.Preset;
		}
	}
}
