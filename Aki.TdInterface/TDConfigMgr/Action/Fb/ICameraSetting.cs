using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EA RID: 10218
	public class ICameraSetting
	{
		// Token: 0x0600E209 RID: 57865 RVA: 0x00213837 File Offset: 0x00211A37
		public static ICameraSetting Create(ICameraSetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0600E20A RID: 57866 RVA: 0x00213856 File Offset: 0x00211A56
		public virtual float Aperture
		{
			get
			{
				return this.Instance.Aperture;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0600E20B RID: 57867 RVA: 0x00213863 File Offset: 0x00211A63
		public virtual float FocalLength
		{
			get
			{
				return this.Instance.FocalLength;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0600E20C RID: 57868 RVA: 0x00213870 File Offset: 0x00211A70
		public virtual float FocusDistance
		{
			get
			{
				return this.Instance.FocusDistance;
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x0600E20D RID: 57869 RVA: 0x0021387D File Offset: 0x00211A7D
		public virtual float FocalRegion
		{
			get
			{
				return this.Instance.FocalRegion;
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x0600E20E RID: 57870 RVA: 0x0021388C File Offset: 0x00211A8C
		public virtual float? Fov
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Fov);
			}
		}

		// Token: 0x04007AE6 RID: 31462
		private ICameraSetting Instance;
	}
}
