using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002651 RID: 9809
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographCameraParams
	{
		// Token: 0x0600DBF6 RID: 56310 RVA: 0x0020BD16 File Offset: 0x00209F16
		[NullableContext(1)]
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

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x0600DBF7 RID: 56311 RVA: 0x0020BD35 File Offset: 0x00209F35
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

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x0020BD6C File Offset: 0x00209F6C
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

		// Token: 0x04007A45 RID: 31301
		private IPhotographCameraParams Instance;

		// Token: 0x04007A46 RID: 31302
		private IPhotographCameraTransformAbsolute _CameraTransformCache;

		// Token: 0x04007A47 RID: 31303
		private bool _CameraTransformInited;
	}
}
