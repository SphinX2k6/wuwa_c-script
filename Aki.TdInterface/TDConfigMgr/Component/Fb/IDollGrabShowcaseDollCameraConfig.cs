using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFD RID: 3581
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabShowcaseDollCameraConfig
	{
		// Token: 0x0600511A RID: 20762 RVA: 0x000C82A1 File Offset: 0x000C64A1
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

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600511B RID: 20763 RVA: 0x000C82C0 File Offset: 0x000C64C0
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

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x000C82F4 File Offset: 0x000C64F4
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

		// Token: 0x04002EA2 RID: 11938
		private IDollGrabShowcaseDollCameraConfig Instance;

		// Token: 0x04002EA3 RID: 11939
		[Nullable(2)]
		private IShowcaseFullViewCameraConfig _FullViewCameraCache;

		// Token: 0x04002EA4 RID: 11940
		private bool _FullViewCameraInited;

		// Token: 0x04002EA5 RID: 11941
		[Nullable(2)]
		private IDollComboCamera _DollCameraCache;

		// Token: 0x04002EA6 RID: 11942
		private bool _DollCameraInited;
	}
}
