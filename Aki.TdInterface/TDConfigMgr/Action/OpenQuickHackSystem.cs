using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EC RID: 8428
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem : ActionParams
	{
		// Token: 0x0600B93A RID: 47418 RVA: 0x001AC400 File Offset: 0x001AA600
		[NullableContext(1)]
		private OpenQuickHackSystem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenQuickHackSystem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenQuickHackSystem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenQuickHackSystem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x001AC438 File Offset: 0x001AA638
		[NullableContext(1)]
		public static OpenQuickHackSystem Create([Nullable(2)] OpenQuickHackSystem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenQuickHackSystem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x001AC44B File Offset: 0x001AA64B
		[NullableContext(1)]
		public static OpenQuickHackSystem CreateFromSetValue([Nullable(2)] OpenQuickHackSystem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenQuickHackSystem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x001AC45E File Offset: 0x001AA65E
		[NullableContext(1)]
		public OpenQuickHackSystem_SetValue ToSetValue()
		{
			return new OpenQuickHackSystem_SetValue
			{
				DeviceId = this.DeviceId,
				Entities = this.Entities,
				CameraConfig = this.CameraConfig
			};
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B93E RID: 47422 RVA: 0x001AC489 File Offset: 0x001AA689
		// (set) Token: 0x0600B93F RID: 47423 RVA: 0x001AC4B4 File Offset: 0x001AA6B4
		public virtual int DeviceId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeviceId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DeviceId;
			}
			set
			{
				this.GetOrCreatePoco().DeviceId = value;
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B940 RID: 47424 RVA: 0x001AC4C2 File Offset: 0x001AA6C2
		// (set) Token: 0x0600B941 RID: 47425 RVA: 0x001AC4E9 File Offset: 0x001AA6E9
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				OpenQuickHackSystem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x001AC4F8 File Offset: 0x001AA6F8
		// (set) Token: 0x0600B943 RID: 47427 RVA: 0x001AC559 File Offset: 0x001AA759
		public virtual IOpenQuickHackCameraConfig CameraConfig
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
					this._CameraConfigCache = IOpenQuickHackCameraConfig.Create(this.FbInstance.CameraConfig);
				}
				else
				{
					OpenQuickHackSystem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006EEC RID: 28396
		protected new OpenQuickHackSystem FbInstance;

		// Token: 0x04006EED RID: 28397
		protected OpenQuickHackSystem_SetValue PocoInterface;

		// Token: 0x04006EEE RID: 28398
		[Nullable(1)]
		private IOpenQuickHackCameraConfig _CameraConfigCache;

		// Token: 0x04006EEF RID: 28399
		private bool _CameraConfigInited;
	}
}
