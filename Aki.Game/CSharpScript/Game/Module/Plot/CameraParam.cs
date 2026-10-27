using System;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD4 RID: 20436
	public class CameraParam
	{
		// Token: 0x17007FB7 RID: 32695
		// (get) Token: 0x060344BA RID: 214202 RVA: 0x00C47BD2 File Offset: 0x00C45DD2
		public bool ApertureEnable
		{
			get
			{
				return this.Aperture != null;
			}
		}

		// Token: 0x17007FB8 RID: 32696
		// (get) Token: 0x060344BB RID: 214203 RVA: 0x00C47BE0 File Offset: 0x00C45DE0
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

		// Token: 0x17007FB9 RID: 32697
		// (get) Token: 0x060344BC RID: 214204 RVA: 0x00C47C22 File Offset: 0x00C45E22
		public bool FocusDistanceEnable
		{
			get
			{
				return this.FocusDistance != null;
			}
		}

		// Token: 0x17007FBA RID: 32698
		// (get) Token: 0x060344BD RID: 214205 RVA: 0x00C47C2F File Offset: 0x00C45E2F
		public bool FocalRegionEnable
		{
			get
			{
				return this.FocalRegion != null;
			}
		}

		// Token: 0x0401BD03 RID: 113923
		public double? Aperture;

		// Token: 0x0401BD04 RID: 113924
		public double? FocalLength = new double?(0.0);

		// Token: 0x0401BD05 RID: 113925
		public double? FocusDistance = new double?(0.0);

		// Token: 0x0401BD06 RID: 113926
		public double? FocalRegion = new double?(0.0);
	}
}
