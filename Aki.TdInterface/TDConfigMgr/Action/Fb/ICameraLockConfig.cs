using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B7F RID: 11135
	public class ICameraLockConfig
	{
		// Token: 0x0600F4B9 RID: 62649 RVA: 0x0023ACCA File Offset: 0x00238ECA
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

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x0600F4BA RID: 62650 RVA: 0x0023ACE9 File Offset: 0x00238EE9
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

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x0600F4BB RID: 62651 RVA: 0x0023AD1D File Offset: 0x00238F1D
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

		// Token: 0x0400862B RID: 34347
		private ICameraLockConfig Instance;

		// Token: 0x0400862C RID: 34348
		[Nullable(2)]
		private ICameraLockTargetPosition _LockTargetCache;

		// Token: 0x0400862D RID: 34349
		private bool _LockTargetInited;

		// Token: 0x0400862E RID: 34350
		[Nullable(2)]
		private ICameraLockParams _CameraParamsCache;

		// Token: 0x0400862F RID: 34351
		private bool _CameraParamsInited;
	}
}
