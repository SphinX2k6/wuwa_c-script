using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE6 RID: 7398
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographCameraParams
	{
		// Token: 0x06009EC7 RID: 40647 RVA: 0x0016AF70 File Offset: 0x00169170
		private IPhotographCameraParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographCameraParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographCameraParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographCameraParams_SetValue());
			}
			return result;
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x0016AFA8 File Offset: 0x001691A8
		public static IPhotographCameraParams Create([Nullable(2)] IPhotographCameraParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCameraParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x0016AFBB File Offset: 0x001691BB
		public static IPhotographCameraParams CreateFromSetValue([Nullable(2)] IPhotographCameraParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographCameraParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x0016AFCE File Offset: 0x001691CE
		public IPhotographCameraParams_SetValue ToSetValue()
		{
			return new IPhotographCameraParams_SetValue
			{
				CameraTransform = this.CameraTransform,
				Fov = this.Fov
			};
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x0016AFF0 File Offset: 0x001691F0
		// (set) Token: 0x06009ECC RID: 40652 RVA: 0x0016B051 File Offset: 0x00169251
		[Nullable(2)]
		public virtual IPhotographCameraTransformAbsolute CameraTransform
		{
			[NullableContext(2)]
			get
			{
				if (this._CameraTransformInited)
				{
					return this._CameraTransformCache;
				}
				this._CameraTransformInited = true;
				if (this.FbInstance != null)
				{
					this._CameraTransformCache = IPhotographCameraTransformAbsolute.Create(this.FbInstance.CameraTransform);
				}
				else
				{
					IPhotographCameraParams_SetValue pocoInterface = this.PocoInterface;
					this._CameraTransformCache = ((pocoInterface != null) ? pocoInterface.CameraTransform : null);
				}
				return this._CameraTransformCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CameraTransform = value;
				this._CameraTransformInited = false;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x0016B068 File Offset: 0x00169268
		// (set) Token: 0x06009ECE RID: 40654 RVA: 0x0016B0A2 File Offset: 0x001692A2
		public virtual float? Fov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fov;
				}
				IPhotographCameraParams_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Fov;
			}
			set
			{
				this.GetOrCreatePoco().Fov = value;
			}
		}

		// Token: 0x04005FE6 RID: 24550
		[Nullable(2)]
		protected IPhotographCameraParams FbInstance;

		// Token: 0x04005FE7 RID: 24551
		[Nullable(2)]
		protected IPhotographCameraParams_SetValue PocoInterface;

		// Token: 0x04005FE8 RID: 24552
		private IPhotographCameraTransformAbsolute _CameraTransformCache;

		// Token: 0x04005FE9 RID: 24553
		private bool _CameraTransformInited;
	}
}
