using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x0200632B RID: 25387
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterSkillTabItemData : IPinballMonsterSkillTabItemData
	{
		// Token: 0x170092F7 RID: 37623
		// (get) Token: 0x0603FDF0 RID: 261616 RVA: 0x00F74268 File Offset: 0x00F72468
		// (set) Token: 0x0603FDF1 RID: 261617 RVA: 0x00F74270 File Offset: 0x00F72470
		public bool IsSelected { get; set; }

		// Token: 0x170092F8 RID: 37624
		// (get) Token: 0x0603FDF2 RID: 261618 RVA: 0x00F74279 File Offset: 0x00F72479
		// (set) Token: 0x0603FDF3 RID: 261619 RVA: 0x00F74281 File Offset: 0x00F72481
		public string Name { get; set; }

		// Token: 0x170092F9 RID: 37625
		// (get) Token: 0x0603FDF4 RID: 261620 RVA: 0x00F7428A File Offset: 0x00F7248A
		// (set) Token: 0x0603FDF5 RID: 261621 RVA: 0x00F74292 File Offset: 0x00F72492
		public Action<int> OnSelected { get; set; }
	}
}
