using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000483 RID: 1155
	public class IHitLogicChangeTargetState : IHitLogicType
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x00047144 File Offset: 0x00045344
		private IHitLogicChangeTargetState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeTargetState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeTargetState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeTargetState_SetValue());
			}
			return result;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0004717C File Offset: 0x0004537C
		public static IHitLogicChangeTargetState Create([Nullable(2)] IHitLogicChangeTargetState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeTargetState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0004718F File Offset: 0x0004538F
		public static IHitLogicChangeTargetState CreateFromSetValue([Nullable(2)] IHitLogicChangeTargetState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeTargetState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000471A2 File Offset: 0x000453A2
		public new IHitLogicChangeTargetState_SetValue ToSetValue()
		{
			return new IHitLogicChangeTargetState_SetValue
			{
				Type = this.Type,
				TargetBulletHitConfigs = this.TargetBulletHitConfigs,
				OtherBulletsHitConfig = this.OtherBulletsHitConfig
			};
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x000471CD File Offset: 0x000453CD
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x000471F8 File Offset: 0x000453F8
		public override EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00047208 File Offset: 0x00045408
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0004729B File Offset: 0x0004549B
		public virtual List<IConditionHitConfigWithBullet> TargetBulletHitConfigs
		{
			get
			{
				if (this._TargetBulletHitConfigsInited)
				{
					return this._TargetBulletHitConfigsCache;
				}
				this._TargetBulletHitConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionHitConfigWithBullet> targetBulletHitConfigs = this.FbInstance.TargetBulletHitConfigs;
					if (targetBulletHitConfigs != null)
					{
						this._TargetBulletHitConfigsCache = new List<IConditionHitConfigWithBullet>(targetBulletHitConfigs.Count);
						for (int i = 0; i < targetBulletHitConfigs.Count; i++)
						{
							this._TargetBulletHitConfigsCache.Add(IConditionHitConfigWithBullet.Create(targetBulletHitConfigs[i]));
						}
					}
				}
				else
				{
					IHitLogicChangeTargetState_SetValue pocoInterface = this.PocoInterface;
					this._TargetBulletHitConfigsCache = ((pocoInterface != null) ? pocoInterface.TargetBulletHitConfigs : null);
				}
				return this._TargetBulletHitConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetBulletHitConfigs = value;
				this._TargetBulletHitConfigsInited = false;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x000472B0 File Offset: 0x000454B0
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x00047343 File Offset: 0x00045543
		public virtual List<IConditionHitConfig> OtherBulletsHitConfig
		{
			get
			{
				if (this._OtherBulletsHitConfigInited)
				{
					return this._OtherBulletsHitConfigCache;
				}
				this._OtherBulletsHitConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionHitConfig> otherBulletsHitConfig = this.FbInstance.OtherBulletsHitConfig;
					if (otherBulletsHitConfig != null)
					{
						this._OtherBulletsHitConfigCache = new List<IConditionHitConfig>(otherBulletsHitConfig.Count);
						for (int i = 0; i < otherBulletsHitConfig.Count; i++)
						{
							this._OtherBulletsHitConfigCache.Add(IConditionHitConfig.Create(otherBulletsHitConfig[i]));
						}
					}
				}
				else
				{
					IHitLogicChangeTargetState_SetValue pocoInterface = this.PocoInterface;
					this._OtherBulletsHitConfigCache = ((pocoInterface != null) ? pocoInterface.OtherBulletsHitConfig : null);
				}
				return this._OtherBulletsHitConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().OtherBulletsHitConfig = value;
				this._OtherBulletsHitConfigInited = false;
			}
		}

		// Token: 0x040011B9 RID: 4537
		[Nullable(2)]
		protected new IHitLogicChangeTargetState FbInstance;

		// Token: 0x040011BA RID: 4538
		[Nullable(2)]
		protected new IHitLogicChangeTargetState_SetValue PocoInterface;

		// Token: 0x040011BB RID: 4539
		private List<IConditionHitConfigWithBullet> _TargetBulletHitConfigsCache;

		// Token: 0x040011BC RID: 4540
		private bool _TargetBulletHitConfigsInited;

		// Token: 0x040011BD RID: 4541
		private List<IConditionHitConfig> _OtherBulletsHitConfigCache;

		// Token: 0x040011BE RID: 4542
		private bool _OtherBulletsHitConfigInited;
	}
}
