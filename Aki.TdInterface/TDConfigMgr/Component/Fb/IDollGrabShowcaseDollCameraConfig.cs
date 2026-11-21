using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF9 RID: 3833
	public class IDollGrabShowcaseDollCameraConfig
	{
		// Token: 0x06005641 RID: 22081 RVA: 0x000D3B69 File Offset: 0x000D1D69
		public static IDollGrabShowcaseDollCameraConfig Create(IDollGrabShowcaseDollCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcaseDollCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x000D3B88 File Offset: 0x000D1D88
		public virtual IShowcaseFullViewCameraConfig FullViewCamera
		{
			get
			{
				if (this._FullViewCameraInited)
				{
					return this._FullViewCameraCache;
				}
				this._FullViewCameraInited = true;
				this._FullViewCameraCache = IShowcaseFullViewCameraConfig.Create(this.Instance.FullViewCamera);
				return this._FullViewCameraCache;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005643 RID: 22083 RVA: 0x000D3BBC File Offset: 0x000D1DBC
		public virtual IDollComboCamera DollCamera
		{
			get
			{
				if (this._DollCameraInited)
				{
					return this._DollCameraCache;
				}
				this._DollCameraInited = true;
				this._DollCameraCache = IDollComboCamera.Create(this.Instance.DollCamera);
				return this._DollCameraCache;
			}
		}

		// Token: 0x0400316A RID: 12650
		private IDollGrabShowcaseDollCameraConfig Instance;

		// Token: 0x0400316B RID: 12651
		[Nullable(2)]
		private IShowcaseFullViewCameraConfig _FullViewCameraCache;

		// Token: 0x0400316C RID: 12652
		private bool _FullViewCameraInited;

		// Token: 0x0400316D RID: 12653
		[Nullable(2)]
		private IDollComboCamera _DollCameraCache;

		// Token: 0x0400316E RID: 12654
		private bool _DollCameraInited;
	}
}
