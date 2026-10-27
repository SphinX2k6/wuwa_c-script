using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CC RID: 1740
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowcaseFullViewCameraConfig
	{
		// Token: 0x06002562 RID: 9570 RVA: 0x00064AF4 File Offset: 0x00062CF4
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

		// Token: 0x06002563 RID: 9571 RVA: 0x00064B2C File Offset: 0x00062D2C
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

		// Token: 0x06002564 RID: 9572 RVA: 0x00064B3F File Offset: 0x00062D3F
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

		// Token: 0x06002565 RID: 9573 RVA: 0x00064B52 File Offset: 0x00062D52
		public IShowcaseFullViewCameraConfig_SetValue ToSetValue()
		{
			return new IShowcaseFullViewCameraConfig_SetValue
			{
				Fov = this.Fov,
				PosAndRot = this.PosAndRot
			};
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x00064B71 File Offset: 0x00062D71
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00064BA0 File Offset: 0x00062DA0
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x00064BB0 File Offset: 0x00062DB0
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x00064C11 File Offset: 0x00062E11
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

		// Token: 0x04001986 RID: 6534
		[Nullable(2)]
		protected IShowcaseFullViewCameraConfig FbInstance;

		// Token: 0x04001987 RID: 6535
		[Nullable(2)]
		protected IShowcaseFullViewCameraConfig_SetValue PocoInterface;

		// Token: 0x04001988 RID: 6536
		private PosAndRot _PosAndRotCache;

		// Token: 0x04001989 RID: 6537
		private bool _PosAndRotInited;
	}
}
