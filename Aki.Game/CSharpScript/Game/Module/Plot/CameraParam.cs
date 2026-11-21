using System;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003F9E RID: 16286
	public class CameraParam
	{
		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x0602933F RID: 168767 RVA: 0x00B9192F File Offset: 0x00B8FB2F
		public bool ApertureEnable
		{
			get
			{
				return this.Aperture != null;
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x06029340 RID: 168768 RVA: 0x00B9193C File Offset: 0x00B8FB3C
		public bool FocalLengthEnable
		{
			get
			{
				if (this.FocalLength != null)
				{
					double? focalLength = this.FocalLength;
					double num = 0.0;
					return !(focalLength.GetValueOrDefault() == num & focalLength != null);
				}
				return false;
			}
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x06029341 RID: 168769 RVA: 0x00B9197E File Offset: 0x00B8FB7E
		public bool FocusDistanceEnable
		{
			get
			{
				return this.FocusDistance != null;
			}
		}

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x06029342 RID: 168770 RVA: 0x00B9198B File Offset: 0x00B8FB8B
		public bool FocalRegionEnable
		{
			get
			{
				return this.FocalRegion != null;
			}
		}

		// Token: 0x040166DE RID: 91870
		public double? Aperture;

		// Token: 0x040166DF RID: 91871
		public double? FocalLength = new double?(0.0);

		// Token: 0x040166E0 RID: 91872
		public double? FocusDistance = new double?(0.0);

		// Token: 0x040166E1 RID: 91873
		public double? FocalRegion = new double?(0.0);
	}
}
