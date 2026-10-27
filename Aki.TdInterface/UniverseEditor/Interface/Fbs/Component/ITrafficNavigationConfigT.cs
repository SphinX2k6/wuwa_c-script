using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC7 RID: 23239
	public class ITrafficNavigationConfigT
	{
		// Token: 0x1700AF0D RID: 44813
		// (get) Token: 0x060279CB RID: 162251 RVA: 0x00572BEC File Offset: 0x00570DEC
		// (set) Token: 0x060279CC RID: 162252 RVA: 0x00572BF4 File Offset: 0x00570DF4
		public ERoadNetworkNavigationType Type { get; set; }

		// Token: 0x1700AF0E RID: 44814
		// (get) Token: 0x060279CD RID: 162253 RVA: 0x00572BFD File Offset: 0x00570DFD
		// (set) Token: 0x060279CE RID: 162254 RVA: 0x00572C05 File Offset: 0x00570E05
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700AF0F RID: 44815
		// (get) Token: 0x060279CF RID: 162255 RVA: 0x00572C0E File Offset: 0x00570E0E
		// (set) Token: 0x060279D0 RID: 162256 RVA: 0x00572C16 File Offset: 0x00570E16
		public TTriggerShapeUnion BoundingVolume { get; set; }

		// Token: 0x1700AF10 RID: 44816
		// (get) Token: 0x060279D1 RID: 162257 RVA: 0x00572C1F File Offset: 0x00570E1F
		// (set) Token: 0x060279D2 RID: 162258 RVA: 0x00572C27 File Offset: 0x00570E27
		public float MaxSpeed { get; set; }

		// Token: 0x1700AF11 RID: 44817
		// (get) Token: 0x060279D3 RID: 162259 RVA: 0x00572C30 File Offset: 0x00570E30
		// (set) Token: 0x060279D4 RID: 162260 RVA: 0x00572C38 File Offset: 0x00570E38
		public float Acceleration { get; set; }

		// Token: 0x1700AF12 RID: 44818
		// (get) Token: 0x060279D5 RID: 162261 RVA: 0x00572C41 File Offset: 0x00570E41
		// (set) Token: 0x060279D6 RID: 162262 RVA: 0x00572C49 File Offset: 0x00570E49
		public string MaxSpeedCurve { get; set; }

		// Token: 0x1700AF13 RID: 44819
		// (get) Token: 0x060279D7 RID: 162263 RVA: 0x00572C52 File Offset: 0x00570E52
		// (set) Token: 0x060279D8 RID: 162264 RVA: 0x00572C5A File Offset: 0x00570E5A
		public string HitEffect { get; set; }

		// Token: 0x060279D9 RID: 162265 RVA: 0x00572C64 File Offset: 0x00570E64
		public ITrafficNavigationConfigT()
		{
			this.Type = ERoadNetworkNavigationType.Traffic;
			this.Size = null;
			this.BoundingVolume = null;
			this.MaxSpeed = 0f;
			this.Acceleration = 0f;
			this.MaxSpeedCurve = null;
			this.HitEffect = null;
		}
	}
}
