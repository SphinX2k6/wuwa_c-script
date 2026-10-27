using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA9 RID: 6825
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusObjectCameraConfig
	{
		// Token: 0x06009264 RID: 37476 RVA: 0x001545C4 File Offset: 0x001527C4
		private IFocusObjectCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusObjectCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusObjectCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusObjectCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x001545FC File Offset: 0x001527FC
		public static IFocusObjectCameraConfig Create([Nullable(2)] IFocusObjectCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusObjectCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x0015460F File Offset: 0x0015280F
		public static IFocusObjectCameraConfig CreateFromSetValue([Nullable(2)] IFocusObjectCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusObjectCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00154622 File Offset: 0x00152822
		public IFocusObjectCameraConfig_SetValue ToSetValue()
		{
			return new IFocusObjectCameraConfig_SetValue
			{
				CameraConfig = this.CameraConfig,
				BlendInTime = this.BlendInTime
			};
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x06009268 RID: 37480 RVA: 0x00154644 File Offset: 0x00152844
		// (set) Token: 0x06009269 RID: 37481 RVA: 0x001546A5 File Offset: 0x001528A5
		public virtual ICameraParams CameraConfig
		{
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CameraConfigCache = ICameraParams.Create(this.FbInstance.CameraConfig);
				}
				else
				{
					IFocusObjectCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._CameraConfigCache = ((pocoInterface != null) ? pocoInterface.CameraConfig : null);
				}
				return this._CameraConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
				this._CameraConfigInited = false;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600926A RID: 37482 RVA: 0x001546BC File Offset: 0x001528BC
		// (set) Token: 0x0600926B RID: 37483 RVA: 0x001546F6 File Offset: 0x001528F6
		public virtual float? BlendInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendInTime;
				}
				IFocusObjectCameraConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlendInTime;
			}
			set
			{
				this.GetOrCreatePoco().BlendInTime = value;
			}
		}

		// Token: 0x04005A25 RID: 23077
		[Nullable(2)]
		protected IFocusObjectCameraConfig FbInstance;

		// Token: 0x04005A26 RID: 23078
		[Nullable(2)]
		protected IFocusObjectCameraConfig_SetValue PocoInterface;

		// Token: 0x04005A27 RID: 23079
		private ICameraParams _CameraConfigCache;

		// Token: 0x04005A28 RID: 23080
		private bool _CameraConfigInited;
	}
}
