using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B1D RID: 11037
	public class IFocusObject
	{
		// Token: 0x0600F2C5 RID: 62149 RVA: 0x0023733A File Offset: 0x0023553A
		public static IFocusObject Create(IFocusObject? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusObject
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x0600F2C6 RID: 62150 RVA: 0x00237359 File Offset: 0x00235559
		public virtual IFocusObjectRotationConfig RotationConfig
		{
			get
			{
				if (this._RotationConfigInited)
				{
					return this._RotationConfigCache;
				}
				this._RotationConfigInited = true;
				this._RotationConfigCache = IFocusObjectRotationConfig.Create(this.Instance.RotationConfig);
				return this._RotationConfigCache;
			}
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x0600F2C7 RID: 62151 RVA: 0x0023738D File Offset: 0x0023558D
		public virtual IFocusObjectCameraConfig CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				this._CameraConfigCache = IFocusObjectCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x0600F2C8 RID: 62152 RVA: 0x002373C4 File Offset: 0x002355C4
		public virtual int? LeaveIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.LeaveIndex);
			}
		}

		// Token: 0x04008537 RID: 34103
		private IFocusObject Instance;

		// Token: 0x04008538 RID: 34104
		[Nullable(2)]
		private IFocusObjectRotationConfig _RotationConfigCache;

		// Token: 0x04008539 RID: 34105
		private bool _RotationConfigInited;

		// Token: 0x0400853A RID: 34106
		[Nullable(2)]
		private IFocusObjectCameraConfig _CameraConfigCache;

		// Token: 0x0400853B RID: 34107
		private bool _CameraConfigInited;
	}
}
