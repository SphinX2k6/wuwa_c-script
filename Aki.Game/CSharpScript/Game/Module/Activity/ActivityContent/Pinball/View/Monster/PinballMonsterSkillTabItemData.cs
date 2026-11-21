using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x020052A9 RID: 21161
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterSkillTabItemData : IPinballMonsterSkillTabItemData
	{
		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x06034AB1 RID: 215729 RVA: 0x00EBB1C4 File Offset: 0x00EB93C4
		// (set) Token: 0x06034AB2 RID: 215730 RVA: 0x00EBB1CC File Offset: 0x00EB93CC
		public bool IsSelected { get; set; }

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x06034AB3 RID: 215731 RVA: 0x00EBB1D5 File Offset: 0x00EB93D5
		// (set) Token: 0x06034AB4 RID: 215732 RVA: 0x00EBB1DD File Offset: 0x00EB93DD
		public string Name { get; set; }

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x06034AB5 RID: 215733 RVA: 0x00EBB1E6 File Offset: 0x00EB93E6
		// (set) Token: 0x06034AB6 RID: 215734 RVA: 0x00EBB1EE File Offset: 0x00EB93EE
		public Action<int> OnSelected { get; set; }
	}
}
