using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C42 RID: 7234
	public class IFocusObjectCameraConfig
	{
		// Token: 0x060099E4 RID: 39396 RVA: 0x001647B0 File Offset: 0x001629B0
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

		// Token: 0x060099E5 RID: 39397 RVA: 0x001647E8 File Offset: 0x001629E8
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

		// Token: 0x060099E6 RID: 39398 RVA: 0x001647FB File Offset: 0x001629FB
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

		// Token: 0x060099E7 RID: 39399 RVA: 0x0016480E File Offset: 0x00162A0E
		public IFocusObjectCameraConfig_SetValue ToSetValue()
		{
			return new IFocusObjectCameraConfig_SetValue
			{
				CameraConfig = this.CameraConfig,
				BlendInTime = this.BlendInTime
			};
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00164830 File Offset: 0x00162A30
		// (set) Token: 0x060099E9 RID: 39401 RVA: 0x00164891 File Offset: 0x00162A91
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

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x060099EA RID: 39402 RVA: 0x001648A8 File Offset: 0x00162AA8
		// (set) Token: 0x060099EB RID: 39403 RVA: 0x001648E2 File Offset: 0x00162AE2
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

		// Token: 0x04005E95 RID: 24213
		[Nullable(2)]
		protected IFocusObjectCameraConfig FbInstance;

		// Token: 0x04005E96 RID: 24214
		[Nullable(2)]
		protected IFocusObjectCameraConfig_SetValue PocoInterface;

		// Token: 0x04005E97 RID: 24215
		private ICameraParams _CameraConfigCache;

		// Token: 0x04005E98 RID: 24216
		private bool _CameraConfigInited;
	}
}
