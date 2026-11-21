using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B9 RID: 20665
	public class ICompareVarT
	{
		// Token: 0x17009415 RID: 37909
		// (get) Token: 0x060205E1 RID: 132577 RVA: 0x0047B993 File Offset: 0x00479B93
		// (set) Token: 0x060205E2 RID: 132578 RVA: 0x0047B99B File Offset: 0x00479B9B
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009416 RID: 37910
		// (get) Token: 0x060205E3 RID: 132579 RVA: 0x0047B9A4 File Offset: 0x00479BA4
		// (set) Token: 0x060205E4 RID: 132580 RVA: 0x0047B9AC File Offset: 0x00479BAC
		public ECompare Compare { get; set; }

		// Token: 0x17009417 RID: 37911
		// (get) Token: 0x060205E5 RID: 132581 RVA: 0x0047B9B5 File Offset: 0x00479BB5
		// (set) Token: 0x060205E6 RID: 132582 RVA: 0x0047B9BD File Offset: 0x00479BBD
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17009418 RID: 37912
		// (get) Token: 0x060205E7 RID: 132583 RVA: 0x0047B9C6 File Offset: 0x00479BC6
		// (set) Token: 0x060205E8 RID: 132584 RVA: 0x0047B9CE File Offset: 0x00479BCE
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x060205E9 RID: 132585 RVA: 0x0047B9D7 File Offset: 0x00479BD7
		public ICompareVarT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Var1 = null;
			this.Var2 = null;
		}
	}
}
