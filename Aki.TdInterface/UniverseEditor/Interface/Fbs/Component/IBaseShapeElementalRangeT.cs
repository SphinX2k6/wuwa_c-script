using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF0 RID: 20208
	public class IBaseShapeElementalRangeT
	{
		// Token: 0x17009152 RID: 37202
		// (get) Token: 0x0601FE7A RID: 130682 RVA: 0x00470C33 File Offset: 0x0046EE33
		// (set) Token: 0x0601FE7B RID: 130683 RVA: 0x00470C3B File Offset: 0x0046EE3B
		public EElementalRangeType Type { get; set; }

		// Token: 0x17009153 RID: 37203
		// (get) Token: 0x0601FE7C RID: 130684 RVA: 0x00470C44 File Offset: 0x0046EE44
		// (set) Token: 0x0601FE7D RID: 130685 RVA: 0x00470C4C File Offset: 0x0046EE4C
		public TTriggerShapeUnion Shape { get; set; }

		// Token: 0x0601FE7E RID: 130686 RVA: 0x00470C55 File Offset: 0x0046EE55
		public IBaseShapeElementalRangeT()
		{
			this.Type = EElementalRangeType.BaseShape;
			this.Shape = null;
		}
	}
}
