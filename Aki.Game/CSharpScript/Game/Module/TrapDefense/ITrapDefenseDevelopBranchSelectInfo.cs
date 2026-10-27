using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A51 RID: 19025
	public interface ITrapDefenseDevelopBranchSelectInfo
	{
		// Token: 0x17007A64 RID: 31332
		// (get) Token: 0x060315C3 RID: 202179
		// (set) Token: 0x060315C4 RID: 202180
		int Id { get; set; }

		// Token: 0x17007A65 RID: 31333
		// (get) Token: 0x060315C5 RID: 202181
		// (set) Token: 0x060315C6 RID: 202182
		bool IsCurLevel { get; set; }

		// Token: 0x17007A66 RID: 31334
		// (get) Token: 0x060315C7 RID: 202183
		// (set) Token: 0x060315C8 RID: 202184
		bool IsSelected { get; set; }
	}
}
