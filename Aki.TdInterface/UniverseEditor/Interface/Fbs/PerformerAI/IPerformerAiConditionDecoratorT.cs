using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435E RID: 17246
	public class IPerformerAiConditionDecoratorT
	{
		// Token: 0x170079B8 RID: 31160
		// (get) Token: 0x0601993A RID: 104762 RVA: 0x003A94E9 File Offset: 0x003A76E9
		// (set) Token: 0x0601993B RID: 104763 RVA: 0x003A94F1 File Offset: 0x003A76F1
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x170079B9 RID: 31161
		// (get) Token: 0x0601993C RID: 104764 RVA: 0x003A94FA File Offset: 0x003A76FA
		// (set) Token: 0x0601993D RID: 104765 RVA: 0x003A9502 File Offset: 0x003A7702
		public IConditionGroupT Condition { get; set; }

		// Token: 0x170079BA RID: 31162
		// (get) Token: 0x0601993E RID: 104766 RVA: 0x003A950B File Offset: 0x003A770B
		// (set) Token: 0x0601993F RID: 104767 RVA: 0x003A9513 File Offset: 0x003A7713
		public bool Reverse { get; set; }

		// Token: 0x170079BB RID: 31163
		// (get) Token: 0x06019940 RID: 104768 RVA: 0x003A951C File Offset: 0x003A771C
		// (set) Token: 0x06019941 RID: 104769 RVA: 0x003A9524 File Offset: 0x003A7724
		public EPerformerAiAbortType AbortType { get; set; }

		// Token: 0x170079BC RID: 31164
		// (get) Token: 0x06019942 RID: 104770 RVA: 0x003A952D File Offset: 0x003A772D
		// (set) Token: 0x06019943 RID: 104771 RVA: 0x003A9535 File Offset: 0x003A7735
		public byte NullMask { get; set; }

		// Token: 0x06019944 RID: 104772 RVA: 0x003A953E File Offset: 0x003A773E
		public IPerformerAiConditionDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
			this.Condition = null;
			this.Reverse = false;
			this.AbortType = EPerformerAiAbortType.None;
			this.NullMask = 0;
		}
	}
}
