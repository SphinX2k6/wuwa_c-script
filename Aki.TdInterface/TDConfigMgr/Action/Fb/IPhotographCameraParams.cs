using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002915 RID: 10517
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographCameraParams
	{
		// Token: 0x0600E9D2 RID: 59858 RVA: 0x002285EE File Offset: 0x002267EE
		[NullableContext(0)]
		public static IPhotographCameraParams Create(IPhotographCameraParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCameraParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x0022860D File Offset: 0x0022680D
		public virtual IPhotographCameraTransformAbsolute CameraTransform
		{
			get
			{
				if (this._CameraTransformInited)
				{
					return this._CameraTransformCache;
				}
				this._CameraTransformInited = true;
				this._CameraTransformCache = IPhotographCameraTransformAbsolute.Create(this.Instance.CameraTransform);
				return this._CameraTransformCache;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x00228644 File Offset: 0x00226844
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

		// Token: 0x040080E7 RID: 32999
		private IPhotographCameraParams Instance;

		// Token: 0x040080E8 RID: 33000
		private IPhotographCameraTransformAbsolute _CameraTransformCache;

		// Token: 0x040080E9 RID: 33001
		private bool _CameraTransformInited;
	}
}
