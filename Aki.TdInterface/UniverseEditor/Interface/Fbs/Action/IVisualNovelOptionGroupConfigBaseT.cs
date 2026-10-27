using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758D RID: 30093
	public class IVisualNovelOptionGroupConfigBaseT
	{
		// Token: 0x1700E430 RID: 58416
		// (get) Token: 0x06036BE4 RID: 224228 RVA: 0x0076E782 File Offset: 0x0076C982
		// (set) Token: 0x06036BE5 RID: 224229 RVA: 0x0076E78A File Offset: 0x0076C98A
		public EVisualNovelOptionGroupType Type { get; set; }

		// Token: 0x06036BE6 RID: 224230 RVA: 0x0076E793 File Offset: 0x0076C993
		public IVisualNovelOptionGroupConfigBaseT()
		{
			this.Type = EVisualNovelOptionGroupType.SolarSchoolExam;
		}
	}
}
