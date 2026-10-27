using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D8 RID: 30168
	public class IVisualNovelRoleIntroductionConfigBaseT
	{
		// Token: 0x1700E535 RID: 58677
		// (get) Token: 0x06036F50 RID: 225104 RVA: 0x007755B6 File Offset: 0x007737B6
		// (set) Token: 0x06036F51 RID: 225105 RVA: 0x007755BE File Offset: 0x007737BE
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x06036F52 RID: 225106 RVA: 0x007755C7 File Offset: 0x007737C7
		public IVisualNovelRoleIntroductionConfigBaseT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
		}
	}
}
