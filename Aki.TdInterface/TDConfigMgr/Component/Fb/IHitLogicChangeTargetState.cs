using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8C RID: 2956
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeTargetState : IHitLogicType
	{
		// Token: 0x060043F7 RID: 17399 RVA: 0x000ACD85 File Offset: 0x000AAF85
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000ACDA4 File Offset: 0x000AAFA4
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
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

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x000ACE20 File Offset: 0x000AB020
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

		// Token: 0x04002653 RID: 9811
		private IHitLogicChangeTargetState Instance;

		// Token: 0x04002654 RID: 9812
		private List<IConditionHitConfigWithBullet> _TargetBulletHitConfigsCache;

		// Token: 0x04002655 RID: 9813
		private bool _TargetBulletHitConfigsInited;

		// Token: 0x04002656 RID: 9814
		private List<IConditionHitConfig> _OtherBulletsHitConfigCache;

		// Token: 0x04002657 RID: 9815
		private bool _OtherBulletsHitConfigInited;
	}
}
