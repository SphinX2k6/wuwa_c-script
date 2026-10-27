using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646C RID: 25708
	public class ICommonBtOverrideConditionInfoT
	{
		// Token: 0x1700BF51 RID: 48977
		// (get) Token: 0x0602C879 RID: 182393 RVA: 0x0061D3A7 File Offset: 0x0061B5A7
		// (set) Token: 0x0602C87A RID: 182394 RVA: 0x0061D3AF File Offset: 0x0061B5AF
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x1700BF52 RID: 48978
		// (get) Token: 0x0602C87B RID: 182395 RVA: 0x0061D3B8 File Offset: 0x0061B5B8
		// (set) Token: 0x0602C87C RID: 182396 RVA: 0x0061D3C0 File Offset: 0x0061B5C0
		public ICondition2_UnionUnion Condition { get; set; }

		// Token: 0x0602C87D RID: 182397 RVA: 0x0061D3C9 File Offset: 0x0061B5C9
		public ICommonBtOverrideConditionInfoT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
			this.Condition = null;
		}
	}
}
