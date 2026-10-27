using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C7 RID: 711
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabShowcaseDollCameraConfig
	{
		// Token: 0x06000D63 RID: 3427 RVA: 0x00032080 File Offset: 0x00030280
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

		// Token: 0x06000D64 RID: 3428 RVA: 0x000320B8 File Offset: 0x000302B8
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

		// Token: 0x06000D65 RID: 3429 RVA: 0x000320CB File Offset: 0x000302CB
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

		// Token: 0x06000D66 RID: 3430 RVA: 0x000320DE File Offset: 0x000302DE
		public IDollGrabShowcaseDollCameraConfig_SetValue ToSetValue()
		{
			return new IDollGrabShowcaseDollCameraConfig_SetValue
			{
				FullViewCamera = this.FullViewCamera,
				DollCamera = this.DollCamera
			};
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00032100 File Offset: 0x00030300
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00032161 File Offset: 0x00030361
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00032178 File Offset: 0x00030378
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x000321D9 File Offset: 0x000303D9
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

		// Token: 0x04000C27 RID: 3111
		[Nullable(2)]
		protected IDollGrabShowcaseDollCameraConfig FbInstance;

		// Token: 0x04000C28 RID: 3112
		[Nullable(2)]
		protected IDollGrabShowcaseDollCameraConfig_SetValue PocoInterface;

		// Token: 0x04000C29 RID: 3113
		private IShowcaseFullViewCameraConfig _FullViewCameraCache;

		// Token: 0x04000C2A RID: 3114
		private bool _FullViewCameraInited;

		// Token: 0x04000C2B RID: 3115
		private IDollComboCamera _DollCameraCache;

		// Token: 0x04000C2C RID: 3116
		private bool _DollCameraInited;
	}
}
