using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B1C RID: 11036
	public class IFocusObjectCameraConfig
	{
		// Token: 0x0600F2C1 RID: 62145 RVA: 0x002372A8 File Offset: 0x002354A8
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

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x0600F2C2 RID: 62146 RVA: 0x002372C7 File Offset: 0x002354C7
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

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x0600F2C3 RID: 62147 RVA: 0x002372FC File Offset: 0x002354FC
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

		// Token: 0x04008534 RID: 34100
		private IFocusObjectCameraConfig Instance;

		// Token: 0x04008535 RID: 34101
		[Nullable(2)]
		private ICameraParams _CameraConfigCache;

		// Token: 0x04008536 RID: 34102
		private bool _CameraConfigInited;
	}
}
