using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF5 RID: 7925
	public class IPhotographCameraParams
	{
		// Token: 0x0600A8A7 RID: 43175 RVA: 0x0017F1D0 File Offset: 0x0017D3D0
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

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x0017F208 File Offset: 0x0017D408
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

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x0017F21B File Offset: 0x0017D41B
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

		// Token: 0x0600A8AA RID: 43178 RVA: 0x0017F22E File Offset: 0x0017D42E
		public IPhotographCameraParams_SetValue ToSetValue()
		{
			return new IPhotographCameraParams_SetValue
			{
				CameraTransform = this.CameraTransform,
				Fov = this.Fov
			};
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x0017F250 File Offset: 0x0017D450
		// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x0017F2B1 File Offset: 0x0017D4B1
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

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x0017F2C8 File Offset: 0x0017D4C8
		// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x0017F302 File Offset: 0x0017D502
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

		// Token: 0x04006559 RID: 25945
		[Nullable(2)]
		protected IPhotographCameraParams FbInstance;

		// Token: 0x0400655A RID: 25946
		[Nullable(2)]
		protected IPhotographCameraParams_SetValue PocoInterface;

		// Token: 0x0400655B RID: 25947
		private IPhotographCameraTransformAbsolute _CameraTransformCache;

		// Token: 0x0400655C RID: 25948
		private bool _CameraTransformInited;
	}
}
