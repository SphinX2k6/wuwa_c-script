using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AA RID: 10410
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraLockConfig
	{
		// Token: 0x0600E68A RID: 59018 RVA: 0x0021DD4A File Offset: 0x0021BF4A
		public static ICameraLockConfig Create(ICameraLockConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x0600E68B RID: 59019 RVA: 0x0021DD69 File Offset: 0x0021BF69
		public virtual ICameraLockTargetPosition LockTarget
		{
			get
			{
				if (this._LockTargetInited)
				{
					return this._LockTargetCache;
				}
				this._LockTargetInited = true;
				this._LockTargetCache = ICameraLockTargetPosition.Create(this.Instance.LockTarget);
				return this._LockTargetCache;
			}
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x0600E68C RID: 59020 RVA: 0x0021DD9D File Offset: 0x0021BF9D
		public virtual ICameraLockParams CameraParams
		{
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				this._CameraParamsCache = ICameraLockParams.Create(this.Instance.CameraParams);
				return this._CameraParamsCache;
			}
		}

		// Token: 0x04007F6C RID: 32620
		private ICameraLockConfig Instance;

		// Token: 0x04007F6D RID: 32621
		[Nullable(2)]
		private ICameraLockTargetPosition _LockTargetCache;

		// Token: 0x04007F6E RID: 32622
		private bool _LockTargetInited;

		// Token: 0x04007F6F RID: 32623
		[Nullable(2)]
		private ICameraLockParams _CameraParamsCache;

		// Token: 0x04007F70 RID: 32624
		private bool _CameraParamsInited;
	}
}
