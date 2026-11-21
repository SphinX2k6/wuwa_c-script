using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234D RID: 9037
	[NullableContext(2)]
	[Nullable(0)]
	public class OpenQuickHackSystem : ActionParams
	{
		// Token: 0x0600C4C6 RID: 50374 RVA: 0x001C3560 File Offset: 0x001C1760
		[NullableContext(0)]
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

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x001C3598 File Offset: 0x001C1798
		[NullableContext(0)]
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

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x001C35AB File Offset: 0x001C17AB
		[NullableContext(0)]
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

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x001C35BE File Offset: 0x001C17BE
		[NullableContext(0)]
		public OpenQuickHackSystem_SetValue ToSetValue()
		{
			return new OpenQuickHackSystem_SetValue
			{
				DeviceId = this.DeviceId,
				Entities = this.Entities,
				CameraConfig = this.CameraConfig
			};
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600C4CA RID: 50378 RVA: 0x001C35E9 File Offset: 0x001C17E9
		// (set) Token: 0x0600C4CB RID: 50379 RVA: 0x001C3614 File Offset: 0x001C1814
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

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600C4CC RID: 50380 RVA: 0x001C3622 File Offset: 0x001C1822
		// (set) Token: 0x0600C4CD RID: 50381 RVA: 0x001C3649 File Offset: 0x001C1849
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

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600C4CE RID: 50382 RVA: 0x001C3658 File Offset: 0x001C1858
		// (set) Token: 0x0600C4CF RID: 50383 RVA: 0x001C36B9 File Offset: 0x001C18B9
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

		// Token: 0x04007520 RID: 29984
		protected new OpenQuickHackSystem FbInstance;

		// Token: 0x04007521 RID: 29985
		protected OpenQuickHackSystem_SetValue PocoInterface;

		// Token: 0x04007522 RID: 29986
		[Nullable(0)]
		private IOpenQuickHackCameraConfig _CameraConfigCache;

		// Token: 0x04007523 RID: 29987
		private bool _CameraConfigInited;
	}
}
