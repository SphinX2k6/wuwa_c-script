using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B2 RID: 14258
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct VisualNovelCharacterEnterParameters
	{
		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x0602519F RID: 151967 RVA: 0x00A77D14 File Offset: 0x00A75F14
		public VisualNovelCharacterState State { get; }

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x060251A0 RID: 151968 RVA: 0x00A77D1C File Offset: 0x00A75F1C
		public float Duration { get; }

		// Token: 0x060251A1 RID: 151969 RVA: 0x00A77D24 File Offset: 0x00A75F24
		public VisualNovelCharacterEnterParameters(VisualNovelCharacterState state, float duration)
		{
			this.State = state;
			this.Duration = duration;
		}
	}
}
