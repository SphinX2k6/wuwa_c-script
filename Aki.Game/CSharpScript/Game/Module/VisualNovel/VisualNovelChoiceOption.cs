using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A5 RID: 14245
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelChoiceOption
	{
		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x060250EC RID: 151788 RVA: 0x00A76694 File Offset: 0x00A74894
		public int SourceIndex { get; }

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x060250ED RID: 151789 RVA: 0x00A7669C File Offset: 0x00A7489C
		public int? PlotOptionId { get; }

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x060250EE RID: 151790 RVA: 0x00A766A4 File Offset: 0x00A748A4
		public EVisualNovelChoiceState State { get; }

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x060250EF RID: 151791 RVA: 0x00A766AC File Offset: 0x00A748AC
		public string TextKey { get; }

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x060250F0 RID: 151792 RVA: 0x00A766B4 File Offset: 0x00A748B4
		public string ConditionText { get; }

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x060250F1 RID: 151793 RVA: 0x00A766BC File Offset: 0x00A748BC
		public int? ConfirmBoxId { get; }

		// Token: 0x060250F2 RID: 151794 RVA: 0x00A766C4 File Offset: 0x00A748C4
		public VisualNovelChoiceOption(int sourceIndex, int? plotOptionId, EVisualNovelChoiceState state, string textKey, string conditionText, int? confirmBoxId)
		{
			this.SourceIndex = sourceIndex;
			this.PlotOptionId = plotOptionId;
			this.State = state;
			this.TextKey = textKey;
			this.ConditionText = conditionText;
			this.ConfirmBoxId = confirmBoxId;
		}
	}
}
