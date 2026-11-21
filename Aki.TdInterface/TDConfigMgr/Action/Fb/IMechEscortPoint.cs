using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE6 RID: 10982
	public class IMechEscortPoint
	{
		// Token: 0x0600F1BA RID: 61882 RVA: 0x002357B2 File Offset: 0x002339B2
		public static IMechEscortPoint Create(IMechEscortPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechEscortPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x0600F1BB RID: 61883 RVA: 0x002357D1 File Offset: 0x002339D1
		public virtual int SplinePointIndex
		{
			get
			{
				return this.Instance.SplinePointIndex;
			}
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x0600F1BC RID: 61884 RVA: 0x002357DE File Offset: 0x002339DE
		public virtual float ForwardOffset
		{
			get
			{
				return this.Instance.ForwardOffset;
			}
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x0600F1BD RID: 61885 RVA: 0x002357EB File Offset: 0x002339EB
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x0600F1BE RID: 61886 RVA: 0x002357F8 File Offset: 0x002339F8
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x0600F1BF RID: 61887 RVA: 0x00235805 File Offset: 0x00233A05
		public virtual IEnterMovieCameraType MovieCamera
		{
			get
			{
				if (this._MovieCameraInited)
				{
					return this._MovieCameraCache;
				}
				this._MovieCameraInited = true;
				this._MovieCameraCache = ActionReadHelper.ReadIMechEscortPoint_MovieCamera(this.Instance);
				return this._MovieCameraCache;
			}
		}

		// Token: 0x040084BE RID: 33982
		private IMechEscortPoint Instance;

		// Token: 0x040084BF RID: 33983
		private IEnterMovieCameraType _MovieCameraCache;

		// Token: 0x040084C0 RID: 33984
		private bool _MovieCameraInited;
	}
}
