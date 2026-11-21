using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B91 RID: 27537
	public class ICycleMoveToPointsT
	{
		// Token: 0x1700CA17 RID: 51735
		// (get) Token: 0x0602F651 RID: 194129 RVA: 0x006778C8 File Offset: 0x00675AC8
		// (set) Token: 0x0602F652 RID: 194130 RVA: 0x006778D0 File Offset: 0x00675AD0
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700CA18 RID: 51736
		// (get) Token: 0x0602F653 RID: 194131 RVA: 0x006778D9 File Offset: 0x00675AD9
		// (set) Token: 0x0602F654 RID: 194132 RVA: 0x006778E1 File Offset: 0x00675AE1
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x1700CA19 RID: 51737
		// (get) Token: 0x0602F655 RID: 194133 RVA: 0x006778EA File Offset: 0x00675AEA
		// (set) Token: 0x0602F656 RID: 194134 RVA: 0x006778F2 File Offset: 0x00675AF2
		public bool IsLoop { get; set; }

		// Token: 0x1700CA1A RID: 51738
		// (get) Token: 0x0602F657 RID: 194135 RVA: 0x006778FB File Offset: 0x00675AFB
		// (set) Token: 0x0602F658 RID: 194136 RVA: 0x00677903 File Offset: 0x00675B03
		public float StopTime { get; set; }

		// Token: 0x1700CA1B RID: 51739
		// (get) Token: 0x0602F659 RID: 194137 RVA: 0x0067790C File Offset: 0x00675B0C
		// (set) Token: 0x0602F65A RID: 194138 RVA: 0x00677914 File Offset: 0x00675B14
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x1700CA1C RID: 51740
		// (get) Token: 0x0602F65B RID: 194139 RVA: 0x0067791D File Offset: 0x00675B1D
		// (set) Token: 0x0602F65C RID: 194140 RVA: 0x00677925 File Offset: 0x00675B25
		public byte NullMask { get; set; }

		// Token: 0x0602F65D RID: 194141 RVA: 0x0067792E File Offset: 0x00675B2E
		public ICycleMoveToPointsT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.Points = null;
			this.IsLoop = false;
			this.StopTime = 0f;
			this.MoveMotion = null;
			this.NullMask = 0;
		}
	}
}
