using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAE RID: 23214
	public class IMatchTargetChargingDeviceT
	{
		// Token: 0x1700A931 RID: 43313
		// (get) Token: 0x06026105 RID: 155909 RVA: 0x00537457 File Offset: 0x00535657
		// (set) Token: 0x06026106 RID: 155910 RVA: 0x0053745F File Offset: 0x0053565F
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700A932 RID: 43314
		// (get) Token: 0x06026107 RID: 155911 RVA: 0x00537468 File Offset: 0x00535668
		// (set) Token: 0x06026108 RID: 155912 RVA: 0x00537470 File Offset: 0x00535670
		public int MaxValue { get; set; }

		// Token: 0x1700A933 RID: 43315
		// (get) Token: 0x06026109 RID: 155913 RVA: 0x00537479 File Offset: 0x00535679
		// (set) Token: 0x0602610A RID: 155914 RVA: 0x00537481 File Offset: 0x00535681
		public int InitValue { get; set; }

		// Token: 0x1700A934 RID: 43316
		// (get) Token: 0x0602610B RID: 155915 RVA: 0x0053748A File Offset: 0x0053568A
		// (set) Token: 0x0602610C RID: 155916 RVA: 0x00537492 File Offset: 0x00535692
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700A935 RID: 43317
		// (get) Token: 0x0602610D RID: 155917 RVA: 0x0053749B File Offset: 0x0053569B
		// (set) Token: 0x0602610E RID: 155918 RVA: 0x005374A3 File Offset: 0x005356A3
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700A936 RID: 43318
		// (get) Token: 0x0602610F RID: 155919 RVA: 0x005374AC File Offset: 0x005356AC
		// (set) Token: 0x06026110 RID: 155920 RVA: 0x005374B4 File Offset: 0x005356B4
		public int IncreaseSpeed { get; set; }

		// Token: 0x1700A937 RID: 43319
		// (get) Token: 0x06026111 RID: 155921 RVA: 0x005374BD File Offset: 0x005356BD
		// (set) Token: 0x06026112 RID: 155922 RVA: 0x005374C5 File Offset: 0x005356C5
		public int DecreaseSpeed { get; set; }

		// Token: 0x1700A938 RID: 43320
		// (get) Token: 0x06026113 RID: 155923 RVA: 0x005374CE File Offset: 0x005356CE
		// (set) Token: 0x06026114 RID: 155924 RVA: 0x005374D6 File Offset: 0x005356D6
		public bool RayCastCheck { get; set; }

		// Token: 0x1700A939 RID: 43321
		// (get) Token: 0x06026115 RID: 155925 RVA: 0x005374DF File Offset: 0x005356DF
		// (set) Token: 0x06026116 RID: 155926 RVA: 0x005374E7 File Offset: 0x005356E7
		public IVectorInfoT RayCastCenter { get; set; }

		// Token: 0x1700A93A RID: 43322
		// (get) Token: 0x06026117 RID: 155927 RVA: 0x005374F0 File Offset: 0x005356F0
		// (set) Token: 0x06026118 RID: 155928 RVA: 0x005374F8 File Offset: 0x005356F8
		public byte NullMask { get; set; }

		// Token: 0x06026119 RID: 155929 RVA: 0x00537504 File Offset: 0x00535704
		public IMatchTargetChargingDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.Match = null;
			this.IncreaseSpeed = 0;
			this.DecreaseSpeed = 0;
			this.RayCastCheck = false;
			this.RayCastCenter = null;
			this.NullMask = 0;
		}
	}
}
