using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFC RID: 15356
	public class ICircleRangeT
	{
		// Token: 0x17006975 RID: 26997
		// (get) Token: 0x06015231 RID: 86577 RVA: 0x0030FFF1 File Offset: 0x0030E1F1
		// (set) Token: 0x06015232 RID: 86578 RVA: 0x0030FFF9 File Offset: 0x0030E1F9
		public ERangeType Type { get; set; }

		// Token: 0x17006976 RID: 26998
		// (get) Token: 0x06015233 RID: 86579 RVA: 0x00310002 File Offset: 0x0030E202
		// (set) Token: 0x06015234 RID: 86580 RVA: 0x0031000A File Offset: 0x0030E20A
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006977 RID: 26999
		// (get) Token: 0x06015235 RID: 86581 RVA: 0x00310013 File Offset: 0x0030E213
		// (set) Token: 0x06015236 RID: 86582 RVA: 0x0031001B File Offset: 0x0030E21B
		public int Radius { get; set; }

		// Token: 0x06015237 RID: 86583 RVA: 0x00310024 File Offset: 0x0030E224
		public ICircleRangeT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Radius = 0;
		}
	}
}
