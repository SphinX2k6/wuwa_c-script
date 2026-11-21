using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CB RID: 6603
	public class ICameraLockConfig
	{
		// Token: 0x06008C63 RID: 35939 RVA: 0x0014C760 File Offset: 0x0014A960
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

		// Token: 0x06008C64 RID: 35940 RVA: 0x0014C798 File Offset: 0x0014A998
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

		// Token: 0x06008C65 RID: 35941 RVA: 0x0014C7AB File Offset: 0x0014A9AB
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

		// Token: 0x06008C66 RID: 35942 RVA: 0x0014C7BE File Offset: 0x0014A9BE
		public ICameraLockConfig_SetValue ToSetValue()
		{
			return new ICameraLockConfig_SetValue
			{
				LockTarget = this.LockTarget,
				CameraParams = this.CameraParams
			};
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x06008C67 RID: 35943 RVA: 0x0014C7E0 File Offset: 0x0014A9E0
		// (set) Token: 0x06008C68 RID: 35944 RVA: 0x0014C841 File Offset: 0x0014AA41
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

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x06008C69 RID: 35945 RVA: 0x0014C858 File Offset: 0x0014AA58
		// (set) Token: 0x06008C6A RID: 35946 RVA: 0x0014C8B9 File Offset: 0x0014AAB9
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

		// Token: 0x0400587A RID: 22650
		[Nullable(2)]
		protected ICameraLockConfig FbInstance;

		// Token: 0x0400587B RID: 22651
		[Nullable(2)]
		protected ICameraLockConfig_SetValue PocoInterface;

		// Token: 0x0400587C RID: 22652
		private ICameraLockTargetPosition _LockTargetCache;

		// Token: 0x0400587D RID: 22653
		private bool _LockTargetInited;

		// Token: 0x0400587E RID: 22654
		private ICameraLockParams _CameraParamsCache;

		// Token: 0x0400587F RID: 22655
		private bool _CameraParamsInited;
	}
}
