using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A4 RID: 14244
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelChoiceData
	{
		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x060250E8 RID: 151784 RVA: 0x00A7665F File Offset: 0x00A7485F
		public string QuestionTextKey { get; }

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x060250E9 RID: 151785 RVA: 0x00A76667 File Offset: 0x00A74867
		public IReadOnlyList<VisualNovelChoiceOption> Options { get; }

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x060250EA RID: 151786 RVA: 0x00A7666F File Offset: 0x00A7486F
		public EVisualNovelOptionGroupType OptionGroupType { get; }

		// Token: 0x060250EB RID: 151787 RVA: 0x00A76677 File Offset: 0x00A74877
		public VisualNovelChoiceData(string questionTextKey, IReadOnlyList<VisualNovelChoiceOption> options, EVisualNovelOptionGroupType optionGroupType)
		{
			this.QuestionTextKey = questionTextKey;
			this.Options = options;
			this.OptionGroupType = optionGroupType;
		}
	}
}
