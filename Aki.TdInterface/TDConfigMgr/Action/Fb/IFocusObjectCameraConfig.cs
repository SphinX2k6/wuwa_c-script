using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002849 RID: 10313
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusObjectCameraConfig
	{
		// Token: 0x0600E49C RID: 58524 RVA: 0x0021A444 File Offset: 0x00218644
		public static IFocusObjectCameraConfig Create(IFocusObjectCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusObjectCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x0600E49D RID: 58525 RVA: 0x0021A463 File Offset: 0x00218663
		public virtual ICameraParams CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = ICameraParams.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x0021A498 File Offset: 0x00218698
		public virtual float? BlendInTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlendInTime);
			}
		}

		// Token: 0x04007E77 RID: 32375
		private IFocusObjectCameraConfig Instance;

		// Token: 0x04007E78 RID: 32376
		[Nullable(2)]
		private ICameraParams _CameraConfigCache;

		// Token: 0x04007E79 RID: 32377
		private bool _CameraConfigInited;
	}
}
