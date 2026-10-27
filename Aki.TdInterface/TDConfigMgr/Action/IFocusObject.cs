using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA7 RID: 6823
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusObject
	{
		// Token: 0x06009258 RID: 37464 RVA: 0x001543F0 File Offset: 0x001525F0
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

		// Token: 0x06009259 RID: 37465 RVA: 0x00154428 File Offset: 0x00152628
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

		// Token: 0x0600925A RID: 37466 RVA: 0x0015443B File Offset: 0x0015263B
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

		// Token: 0x0600925B RID: 37467 RVA: 0x0015444E File Offset: 0x0015264E
		public IFocusObject_SetValue ToSetValue()
		{
			return new IFocusObject_SetValue
			{
				RotationConfig = this.RotationConfig,
				CameraConfig = this.CameraConfig,
				LeaveIndex = this.LeaveIndex
			};
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x0015447C File Offset: 0x0015267C
		// (set) Token: 0x0600925D RID: 37469 RVA: 0x001544DD File Offset: 0x001526DD
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

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x001544F4 File Offset: 0x001526F4
		// (set) Token: 0x0600925F RID: 37471 RVA: 0x00154555 File Offset: 0x00152755
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

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x06009260 RID: 37472 RVA: 0x0015456C File Offset: 0x0015276C
		// (set) Token: 0x06009261 RID: 37473 RVA: 0x001545A6 File Offset: 0x001527A6
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

		// Token: 0x04005A1C RID: 23068
		[Nullable(2)]
		protected IFocusObject FbInstance;

		// Token: 0x04005A1D RID: 23069
		[Nullable(2)]
		protected IFocusObject_SetValue PocoInterface;

		// Token: 0x04005A1E RID: 23070
		private IFocusObjectRotationConfig _RotationConfigCache;

		// Token: 0x04005A1F RID: 23071
		private bool _RotationConfigInited;

		// Token: 0x04005A20 RID: 23072
		private IFocusObjectCameraConfig _CameraConfigCache;

		// Token: 0x04005A21 RID: 23073
		private bool _CameraConfigInited;
	}
}
