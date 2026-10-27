using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001840 RID: 6208
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraLockConfig
	{
		// Token: 0x0600853D RID: 34109 RVA: 0x0013CF6C File Offset: 0x0013B16C
		private ICameraLockConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraLockConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraLockConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraLockConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x0013CFA4 File Offset: 0x0013B1A4
		public static ICameraLockConfig Create([Nullable(2)] ICameraLockConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x0013CFB7 File Offset: 0x0013B1B7
		public static ICameraLockConfig CreateFromSetValue([Nullable(2)] ICameraLockConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraLockConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x0013CFCA File Offset: 0x0013B1CA
		public ICameraLockConfig_SetValue ToSetValue()
		{
			return new ICameraLockConfig_SetValue
			{
				LockTarget = this.LockTarget,
				CameraParams = this.CameraParams
			};
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x0013CFEC File Offset: 0x0013B1EC
		// (set) Token: 0x06008542 RID: 34114 RVA: 0x0013D04D File Offset: 0x0013B24D
		public virtual ICameraLockTargetPosition LockTarget
		{
			get
			{
				if (this._LockTargetInited)
				{
					return this._LockTargetCache;
				}
				this._LockTargetInited = true;
				if (this.FbInstance != null)
				{
					this._LockTargetCache = ICameraLockTargetPosition.Create(this.FbInstance.LockTarget);
				}
				else
				{
					ICameraLockConfig_SetValue pocoInterface = this.PocoInterface;
					this._LockTargetCache = ((pocoInterface != null) ? pocoInterface.LockTarget : null);
				}
				return this._LockTargetCache;
			}
			set
			{
				this.GetOrCreatePoco().LockTarget = value;
				this._LockTargetInited = false;
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x0013D064 File Offset: 0x0013B264
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x0013D0C5 File Offset: 0x0013B2C5
		public virtual ICameraLockParams CameraParams
		{
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				if (this.FbInstance != null)
				{
					this._CameraParamsCache = ICameraLockParams.Create(this.FbInstance.CameraParams);
				}
				else
				{
					ICameraLockConfig_SetValue pocoInterface = this.PocoInterface;
					this._CameraParamsCache = ((pocoInterface != null) ? pocoInterface.CameraParams : null);
				}
				return this._CameraParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().CameraParams = value;
				this._CameraParamsInited = false;
			}
		}

		// Token: 0x0400542E RID: 21550
		[Nullable(2)]
		protected ICameraLockConfig FbInstance;

		// Token: 0x0400542F RID: 21551
		[Nullable(2)]
		protected ICameraLockConfig_SetValue PocoInterface;

		// Token: 0x04005430 RID: 21552
		private ICameraLockTargetPosition _LockTargetCache;

		// Token: 0x04005431 RID: 21553
		private bool _LockTargetInited;

		// Token: 0x04005432 RID: 21554
		private ICameraLockParams _CameraParamsCache;

		// Token: 0x04005433 RID: 21555
		private bool _CameraParamsInited;
	}
}
