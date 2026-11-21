using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076D RID: 1901
	public class IShowcaseFullViewCameraConfig
	{
		// Token: 0x06002882 RID: 10370 RVA: 0x0006BB64 File Offset: 0x00069D64
		private IShowcaseFullViewCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowcaseFullViewCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowcaseFullViewCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowcaseFullViewCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0006BB9C File Offset: 0x00069D9C
		public static IShowcaseFullViewCameraConfig Create([Nullable(2)] IShowcaseFullViewCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowcaseFullViewCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0006BBAF File Offset: 0x00069DAF
		public static IShowcaseFullViewCameraConfig CreateFromSetValue([Nullable(2)] IShowcaseFullViewCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowcaseFullViewCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0006BBC2 File Offset: 0x00069DC2
		public IShowcaseFullViewCameraConfig_SetValue ToSetValue()
		{
			return new IShowcaseFullViewCameraConfig_SetValue
			{
				Fov = this.Fov,
				PosAndRot = this.PosAndRot
			};
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x0006BBE1 File Offset: 0x00069DE1
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x0006BC10 File Offset: 0x00069E10
		public virtual float Fov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fov;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Fov;
			}
			set
			{
				this.GetOrCreatePoco().Fov = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x0006BC20 File Offset: 0x00069E20
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0006BC81 File Offset: 0x00069E81
		public virtual PosAndRot PosAndRot
		{
			get
			{
				if (this._PosAndRotInited)
				{
					return this._PosAndRotCache;
				}
				this._PosAndRotInited = true;
				if (this.FbInstance != null)
				{
					this._PosAndRotCache = PosAndRot.Create(this.FbInstance.PosAndRot);
				}
				else
				{
					IShowcaseFullViewCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._PosAndRotCache = ((pocoInterface != null) ? pocoInterface.PosAndRot : null);
				}
				return this._PosAndRotCache;
			}
			set
			{
				this.GetOrCreatePoco().PosAndRot = value;
				this._PosAndRotInited = false;
			}
		}

		// Token: 0x04001B85 RID: 7045
		[Nullable(2)]
		protected IShowcaseFullViewCameraConfig FbInstance;

		// Token: 0x04001B86 RID: 7046
		[Nullable(2)]
		protected IShowcaseFullViewCameraConfig_SetValue PocoInterface;

		// Token: 0x04001B87 RID: 7047
		private PosAndRot _PosAndRotCache;

		// Token: 0x04001B88 RID: 7048
		private bool _PosAndRotInited;
	}
}
