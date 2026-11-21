using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.VisualNovel;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A51 RID: 23121
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelChoiceViewParam
	{
		// Token: 0x17006C98 RID: 27800
		// (get) Token: 0x06038F95 RID: 233365 RVA: 0x00FF6197 File Offset: 0x00FF4397
		public VisualNovelChoiceData ChoiceData { get; }

		// Token: 0x17006C99 RID: 27801
		// (get) Token: 0x06038F96 RID: 233366 RVA: 0x00FF619F File Offset: 0x00FF439F
		public VisualNovelContext Context { get; }

		// Token: 0x17006C9A RID: 27802
		// (get) Token: 0x06038F97 RID: 233367 RVA: 0x00FF61A7 File Offset: 0x00FF43A7
		public Action<int> OnChoiceSelected { get; }

		// Token: 0x17006C9B RID: 27803
		// (get) Token: 0x06038F98 RID: 233368 RVA: 0x00FF61AF File Offset: 0x00FF43AF
		public Func<bool> CanSelect { get; }

		// Token: 0x06038F99 RID: 233369 RVA: 0x00FF61B7 File Offset: 0x00FF43B7
		public SolarSchoolVisualNovelChoiceViewParam(VisualNovelChoiceData choiceData, VisualNovelContext context, Action<int> onChoiceSelected, Func<bool> canSelect)
		{
			this.ChoiceData = choiceData;
			this.Context = context;
			this.OnChoiceSelected = onChoiceSelected;
			this.CanSelect = canSelect;
		}
	}
}
