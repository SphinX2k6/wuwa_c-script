using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E70 RID: 15984
	public class IForceClosedRestrictionT
	{
		// Token: 0x17006ED9 RID: 28377
		// (get) Token: 0x06016845 RID: 92229 RVA: 0x003412B1 File Offset: 0x0033F4B1
		// (set) Token: 0x06016846 RID: 92230 RVA: 0x003412B9 File Offset: 0x0033F4B9
		public IVectorInfoT RangeCenter { get; set; }

		// Token: 0x17006EDA RID: 28378
		// (get) Token: 0x06016847 RID: 92231 RVA: 0x003412C2 File Offset: 0x0033F4C2
		// (set) Token: 0x06016848 RID: 92232 RVA: 0x003412CA File Offset: 0x0033F4CA
		public int RangeRadius { get; set; }

		// Token: 0x17006EDB RID: 28379
		// (get) Token: 0x06016849 RID: 92233 RVA: 0x003412D3 File Offset: 0x0033F4D3
		// (set) Token: 0x0601684A RID: 92234 RVA: 0x003412DB File Offset: 0x0033F4DB
		public List<int> RangeEntities { get; set; }

		// Token: 0x17006EDC RID: 28380
		// (get) Token: 0x0601684B RID: 92235 RVA: 0x003412E4 File Offset: 0x0033F4E4
		// (set) Token: 0x0601684C RID: 92236 RVA: 0x003412EC File Offset: 0x0033F4EC
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT FailedReturnPos { get; set; }

		// Token: 0x17006EDD RID: 28381
		// (get) Token: 0x0601684D RID: 92237 RVA: 0x003412F5 File Offset: 0x0033F4F5
		// (set) Token: 0x0601684E RID: 92238 RVA: 0x003412FD File Offset: 0x0033F4FD
		public int FailedReturnPosEntityId { get; set; }

		// Token: 0x17006EDE RID: 28382
		// (get) Token: 0x0601684F RID: 92239 RVA: 0x00341306 File Offset: 0x0033F506
		// (set) Token: 0x06016850 RID: 92240 RVA: 0x0034130E File Offset: 0x0033F50E
		public byte NullMask { get; set; }

		// Token: 0x06016851 RID: 92241 RVA: 0x00341317 File Offset: 0x0033F517
		public IForceClosedRestrictionT()
		{
			this.RangeCenter = null;
			this.RangeRadius = 0;
			this.RangeEntities = null;
			this.FailedReturnPos = null;
			this.FailedReturnPosEntityId = 0;
			this.NullMask = 0;
		}
	}
}
