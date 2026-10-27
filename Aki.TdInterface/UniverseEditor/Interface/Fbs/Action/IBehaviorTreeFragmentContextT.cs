using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006201 RID: 25089
	public class IBehaviorTreeFragmentContextT
	{
		// Token: 0x1700BB09 RID: 47881
		// (get) Token: 0x0602B407 RID: 177159 RVA: 0x005F5794 File Offset: 0x005F3994
		// (set) Token: 0x0602B408 RID: 177160 RVA: 0x005F579C File Offset: 0x005F399C
		public EVarContext Type { get; set; }

		// Token: 0x1700BB0A RID: 47882
		// (get) Token: 0x0602B409 RID: 177161 RVA: 0x005F57A5 File Offset: 0x005F39A5
		// (set) Token: 0x0602B40A RID: 177162 RVA: 0x005F57AD File Offset: 0x005F39AD
		public int Id { get; set; }

		// Token: 0x0602B40B RID: 177163 RVA: 0x005F57B6 File Offset: 0x005F39B6
		public IBehaviorTreeFragmentContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
