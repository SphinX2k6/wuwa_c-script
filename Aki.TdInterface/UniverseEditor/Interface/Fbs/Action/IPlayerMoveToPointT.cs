using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D03 RID: 27907
	public class IPlayerMoveToPointT
	{
		// Token: 0x1700CFD5 RID: 53205
		// (get) Token: 0x06031368 RID: 201576 RVA: 0x006AD1D3 File Offset: 0x006AB3D3
		// (set) Token: 0x06031369 RID: 201577 RVA: 0x006AD1DB File Offset: 0x006AB3DB
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CFD6 RID: 53206
		// (get) Token: 0x0603136A RID: 201578 RVA: 0x006AD1E4 File Offset: 0x006AB3E4
		// (set) Token: 0x0603136B RID: 201579 RVA: 0x006AD1EC File Offset: 0x006AB3EC
		public EMoveToPointType MoveType { get; set; }

		// Token: 0x1700CFD7 RID: 53207
		// (get) Token: 0x0603136C RID: 201580 RVA: 0x006AD1F5 File Offset: 0x006AB3F5
		// (set) Token: 0x0603136D RID: 201581 RVA: 0x006AD1FD File Offset: 0x006AB3FD
		public bool IsExact { get; set; }

		// Token: 0x1700CFD8 RID: 53208
		// (get) Token: 0x0603136E RID: 201582 RVA: 0x006AD206 File Offset: 0x006AB406
		// (set) Token: 0x0603136F RID: 201583 RVA: 0x006AD20E File Offset: 0x006AB40E
		public byte NullMask { get; set; }

		// Token: 0x06031370 RID: 201584 RVA: 0x006AD217 File Offset: 0x006AB417
		public IPlayerMoveToPointT()
		{
			this.Pos = null;
			this.MoveType = EMoveToPointType.Straight;
			this.IsExact = false;
			this.NullMask = 0;
		}
	}
}
