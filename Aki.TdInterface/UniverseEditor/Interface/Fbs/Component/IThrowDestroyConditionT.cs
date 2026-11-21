using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200606F RID: 24687
	public class IThrowDestroyConditionT
	{
		// Token: 0x1700B752 RID: 46930
		// (get) Token: 0x06029B5B RID: 170843 RVA: 0x005B1DD4 File Offset: 0x005AFFD4
		// (set) Token: 0x06029B5C RID: 170844 RVA: 0x005B1DDC File Offset: 0x005AFFDC
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x1700B753 RID: 46931
		// (get) Token: 0x06029B5D RID: 170845 RVA: 0x005B1DE5 File Offset: 0x005AFFE5
		// (set) Token: 0x06029B5E RID: 170846 RVA: 0x005B1DED File Offset: 0x005AFFED
		public float DelayTime { get; set; }

		// Token: 0x06029B5F RID: 170847 RVA: 0x005B1DF6 File Offset: 0x005AFFF6
		public IThrowDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
			this.DelayTime = 0f;
		}
	}
}
