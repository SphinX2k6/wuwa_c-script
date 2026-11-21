using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5A RID: 3162
	public class IHitLogicChangeTargetState : IHitLogicType
	{
		// Token: 0x06004850 RID: 18512 RVA: 0x000B6E49 File Offset: 0x000B5049
		public static IHitLogicChangeTargetState Create(IHitLogicChangeTargetState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeTargetState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x000B6E68 File Offset: 0x000B5068
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x000B6E78 File Offset: 0x000B5078
		public virtual List<IConditionHitConfigWithBullet> TargetBulletHitConfigs
		{
			get
			{
				if (this._TargetBulletHitConfigsInited)
				{
					return this._TargetBulletHitConfigsCache;
				}
				this._TargetBulletHitConfigsInited = true;
				int targetBulletHitConfigsLength = this.Instance.TargetBulletHitConfigsLength;
				this._TargetBulletHitConfigsCache = new List<IConditionHitConfigWithBullet>(targetBulletHitConfigsLength);
				for (int i = 0; i < targetBulletHitConfigsLength; i++)
				{
					this._TargetBulletHitConfigsCache.Add(IConditionHitConfigWithBullet.Create(this.Instance.TargetBulletHitConfigs(i)));
				}
				return this._TargetBulletHitConfigsCache;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x000B6EE4 File Offset: 0x000B50E4
		public virtual List<IConditionHitConfig> OtherBulletsHitConfig
		{
			get
			{
				if (this._OtherBulletsHitConfigInited)
				{
					return this._OtherBulletsHitConfigCache;
				}
				this._OtherBulletsHitConfigInited = true;
				int otherBulletsHitConfigLength = this.Instance.OtherBulletsHitConfigLength;
				this._OtherBulletsHitConfigCache = new List<IConditionHitConfig>(otherBulletsHitConfigLength);
				for (int i = 0; i < otherBulletsHitConfigLength; i++)
				{
					this._OtherBulletsHitConfigCache.Add(IConditionHitConfig.Create(this.Instance.OtherBulletsHitConfig(i)));
				}
				return this._OtherBulletsHitConfigCache;
			}
		}

		// Token: 0x0400289B RID: 10395
		private IHitLogicChangeTargetState Instance;

		// Token: 0x0400289C RID: 10396
		private List<IConditionHitConfigWithBullet> _TargetBulletHitConfigsCache;

		// Token: 0x0400289D RID: 10397
		private bool _TargetBulletHitConfigsInited;

		// Token: 0x0400289E RID: 10398
		private List<IConditionHitConfig> _OtherBulletsHitConfigCache;

		// Token: 0x0400289F RID: 10399
		private bool _OtherBulletsHitConfigInited;
	}
}
