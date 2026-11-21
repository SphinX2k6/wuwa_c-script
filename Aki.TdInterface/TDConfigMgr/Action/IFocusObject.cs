using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C40 RID: 7232
	public class IFocusObject
	{
		// Token: 0x060099D8 RID: 39384 RVA: 0x001645DC File Offset: 0x001627DC
		private IFocusObject_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusObject 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusObject_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusObject_SetValue());
			}
			return result;
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00164614 File Offset: 0x00162814
		public static IFocusObject Create([Nullable(2)] IFocusObject instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusObject
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x00164627 File Offset: 0x00162827
		public static IFocusObject CreateFromSetValue([Nullable(2)] IFocusObject_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusObject
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x0016463A File Offset: 0x0016283A
		public IFocusObject_SetValue ToSetValue()
		{
			return new IFocusObject_SetValue
			{
				RotationConfig = this.RotationConfig,
				CameraConfig = this.CameraConfig,
				LeaveIndex = this.LeaveIndex
			};
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x00164668 File Offset: 0x00162868
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x001646C9 File Offset: 0x001628C9
		public virtual IFocusObjectRotationConfig RotationConfig
		{
			get
			{
				if (this._RotationConfigInited)
				{
					return this._RotationConfigCache;
				}
				this._RotationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RotationConfigCache = IFocusObjectRotationConfig.Create(this.FbInstance.RotationConfig);
				}
				else
				{
					IFocusObject_SetValue pocoInterface = this.PocoInterface;
					this._RotationConfigCache = ((pocoInterface != null) ? pocoInterface.RotationConfig : null);
				}
				return this._RotationConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RotationConfig = value;
				this._RotationConfigInited = false;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x060099DE RID: 39390 RVA: 0x001646E0 File Offset: 0x001628E0
		// (set) Token: 0x060099DF RID: 39391 RVA: 0x00164741 File Offset: 0x00162941
		public virtual IFocusObjectCameraConfig CameraConfig
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
					this._CameraConfigCache = IFocusObjectCameraConfig.Create(this.FbInstance.CameraConfig);
				}
				else
				{
					IFocusObject_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x060099E0 RID: 39392 RVA: 0x00164758 File Offset: 0x00162958
		// (set) Token: 0x060099E1 RID: 39393 RVA: 0x00164792 File Offset: 0x00162992
		public virtual int? LeaveIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveIndex;
				}
				IFocusObject_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeaveIndex;
			}
			set
			{
				this.GetOrCreatePoco().LeaveIndex = value;
			}
		}

		// Token: 0x04005E8C RID: 24204
		[Nullable(2)]
		protected IFocusObject FbInstance;

		// Token: 0x04005E8D RID: 24205
		[Nullable(2)]
		protected IFocusObject_SetValue PocoInterface;

		// Token: 0x04005E8E RID: 24206
		private IFocusObjectRotationConfig _RotationConfigCache;

		// Token: 0x04005E8F RID: 24207
		private bool _RotationConfigInited;

		// Token: 0x04005E90 RID: 24208
		private IFocusObjectCameraConfig _CameraConfigCache;

		// Token: 0x04005E91 RID: 24209
		private bool _CameraConfigInited;
	}
}
