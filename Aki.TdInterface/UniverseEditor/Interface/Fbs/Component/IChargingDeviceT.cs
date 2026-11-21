using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BE RID: 21694
	public class IChargingDeviceT
	{
		// Token: 0x17009ACE RID: 39630
		// (get) Token: 0x0602232D RID: 140077 RVA: 0x004B6D8A File Offset: 0x004B4F8A
		// (set) Token: 0x0602232E RID: 140078 RVA: 0x004B6D92 File Offset: 0x004B4F92
		public EProgressBarControlType Type { get; set; }

		// Token: 0x17009ACF RID: 39631
		// (get) Token: 0x0602232F RID: 140079 RVA: 0x004B6D9B File Offset: 0x004B4F9B
		// (set) Token: 0x06022330 RID: 140080 RVA: 0x004B6DA3 File Offset: 0x004B4FA3
		public int MaxValue { get; set; }

		// Token: 0x17009AD0 RID: 39632
		// (get) Token: 0x06022331 RID: 140081 RVA: 0x004B6DAC File Offset: 0x004B4FAC
		// (set) Token: 0x06022332 RID: 140082 RVA: 0x004B6DB4 File Offset: 0x004B4FB4
		public int InitValue { get; set; }

		// Token: 0x17009AD1 RID: 39633
		// (get) Token: 0x06022333 RID: 140083 RVA: 0x004B6DBD File Offset: 0x004B4FBD
		// (set) Token: 0x06022334 RID: 140084 RVA: 0x004B6DC5 File Offset: 0x004B4FC5
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x17009AD2 RID: 39634
		// (get) Token: 0x06022335 RID: 140085 RVA: 0x004B6DCE File Offset: 0x004B4FCE
		// (set) Token: 0x06022336 RID: 140086 RVA: 0x004B6DD6 File Offset: 0x004B4FD6
		public int IncreaseSpeed { get; set; }

		// Token: 0x17009AD3 RID: 39635
		// (get) Token: 0x06022337 RID: 140087 RVA: 0x004B6DDF File Offset: 0x004B4FDF
		// (set) Token: 0x06022338 RID: 140088 RVA: 0x004B6DE7 File Offset: 0x004B4FE7
		public int HitExtraValue { get; set; }

		// Token: 0x17009AD4 RID: 39636
		// (get) Token: 0x06022339 RID: 140089 RVA: 0x004B6DF0 File Offset: 0x004B4FF0
		// (set) Token: 0x0602233A RID: 140090 RVA: 0x004B6DF8 File Offset: 0x004B4FF8
		public byte NullMask { get; set; }

		// Token: 0x0602233B RID: 140091 RVA: 0x004B6E01 File Offset: 0x004B5001
		public IChargingDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.IncreaseSpeed = 0;
			this.HitExtraValue = 0;
			this.NullMask = 0;
		}
	}
}
