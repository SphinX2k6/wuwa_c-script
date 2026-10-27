using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002813 RID: 10259
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechEscortPoint
	{
		// Token: 0x0600E395 RID: 58261 RVA: 0x0021894E File Offset: 0x00216B4E
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

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x0600E396 RID: 58262 RVA: 0x0021896D File Offset: 0x00216B6D
		public virtual int SplinePointIndex
		{
			get
			{
				return this.Instance.SplinePointIndex;
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x0600E397 RID: 58263 RVA: 0x0021897A File Offset: 0x00216B7A
		public virtual float ForwardOffset
		{
			get
			{
				return this.Instance.ForwardOffset;
			}
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x0600E398 RID: 58264 RVA: 0x00218987 File Offset: 0x00216B87
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x0600E399 RID: 58265 RVA: 0x00218994 File Offset: 0x00216B94
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x0600E39A RID: 58266 RVA: 0x002189A1 File Offset: 0x00216BA1
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

		// Token: 0x04007E01 RID: 32257
		private IMechEscortPoint Instance;

		// Token: 0x04007E02 RID: 32258
		private IEnterMovieCameraType _MovieCameraCache;

		// Token: 0x04007E03 RID: 32259
		private bool _MovieCameraInited;
	}
}
