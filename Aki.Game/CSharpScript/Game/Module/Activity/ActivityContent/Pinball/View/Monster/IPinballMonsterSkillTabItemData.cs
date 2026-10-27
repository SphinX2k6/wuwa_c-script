using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x0200632A RID: 25386
	[NullableContext(1)]
	public interface IPinballMonsterSkillTabItemData
	{
		// Token: 0x170092F4 RID: 37620
		// (get) Token: 0x0603FDEA RID: 261610
		// (set) Token: 0x0603FDEB RID: 261611
		bool IsSelected { get; set; }

		// Token: 0x170092F5 RID: 37621
		// (get) Token: 0x0603FDEC RID: 261612
		// (set) Token: 0x0603FDED RID: 261613
		string Name { get; set; }

		// Token: 0x170092F6 RID: 37622
		// (get) Token: 0x0603FDEE RID: 261614
		// (set) Token: 0x0603FDEF RID: 261615
		Action<int> OnSelected { get; set; }
	}
}
