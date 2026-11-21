using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200030E RID: 782
	public class IDollGrabShowcaseDollCameraConfig
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x00034FB4 File Offset: 0x000331B4
		private IDollGrabShowcaseDollCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabShowcaseDollCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabShowcaseDollCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabShowcaseDollCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00034FEC File Offset: 0x000331EC
		public static IDollGrabShowcaseDollCameraConfig Create([Nullable(2)] IDollGrabShowcaseDollCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcaseDollCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00034FFF File Offset: 0x000331FF
		public static IDollGrabShowcaseDollCameraConfig CreateFromSetValue([Nullable(2)] IDollGrabShowcaseDollCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabShowcaseDollCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00035012 File Offset: 0x00033212
		public IDollGrabShowcaseDollCameraConfig_SetValue ToSetValue()
		{
			return new IDollGrabShowcaseDollCameraConfig_SetValue
			{
				FullViewCamera = this.FullViewCamera,
				DollCamera = this.DollCamera
			};
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00035034 File Offset: 0x00033234
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00035095 File Offset: 0x00033295
		public virtual IShowcaseFullViewCameraConfig FullViewCamera
		{
			get
			{
				if (this._FullViewCameraInited)
				{
					return this._FullViewCameraCache;
				}
				this._FullViewCameraInited = true;
				if (this.FbInstance != null)
				{
					this._FullViewCameraCache = IShowcaseFullViewCameraConfig.Create(this.FbInstance.FullViewCamera);
				}
				else
				{
					IDollGrabShowcaseDollCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._FullViewCameraCache = ((pocoInterface != null) ? pocoInterface.FullViewCamera : null);
				}
				return this._FullViewCameraCache;
			}
			set
			{
				this.GetOrCreatePoco().FullViewCamera = value;
				this._FullViewCameraInited = false;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000350AC File Offset: 0x000332AC
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0003510D File Offset: 0x0003330D
		public virtual IDollComboCamera DollCamera
		{
			get
			{
				if (this._DollCameraInited)
				{
					return this._DollCameraCache;
				}
				this._DollCameraInited = true;
				if (this.FbInstance != null)
				{
					this._DollCameraCache = IDollComboCamera.Create(this.FbInstance.DollCamera);
				}
				else
				{
					IDollGrabShowcaseDollCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._DollCameraCache = ((pocoInterface != null) ? pocoInterface.DollCamera : null);
				}
				return this._DollCameraCache;
			}
			set
			{
				this.GetOrCreatePoco().DollCamera = value;
				this._DollCameraInited = false;
			}
		}

		// Token: 0x04000D11 RID: 3345
		[Nullable(2)]
		protected IDollGrabShowcaseDollCameraConfig FbInstance;

		// Token: 0x04000D12 RID: 3346
		[Nullable(2)]
		protected IDollGrabShowcaseDollCameraConfig_SetValue PocoInterface;

		// Token: 0x04000D13 RID: 3347
		private IShowcaseFullViewCameraConfig _FullViewCameraCache;

		// Token: 0x04000D14 RID: 3348
		private bool _FullViewCameraInited;

		// Token: 0x04000D15 RID: 3349
		private IDollComboCamera _DollCameraCache;

		// Token: 0x04000D16 RID: 3350
		private bool _DollCameraInited;
	}
}
