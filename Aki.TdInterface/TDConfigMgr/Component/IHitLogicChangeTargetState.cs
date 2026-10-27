using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042A RID: 1066
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeTargetState : IHitLogicType
	{
		// Token: 0x0600157B RID: 5499 RVA: 0x000433FC File Offset: 0x000415FC
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

		// Token: 0x0600157C RID: 5500 RVA: 0x00043434 File Offset: 0x00041634
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

		// Token: 0x0600157D RID: 5501 RVA: 0x00043447 File Offset: 0x00041647
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

		// Token: 0x0600157E RID: 5502 RVA: 0x0004345A File Offset: 0x0004165A
		public new IHitLogicChangeTargetState_SetValue ToSetValue()
		{
			return new IHitLogicChangeTargetState_SetValue
			{
				Type = this.Type,
				TargetBulletHitConfigs = this.TargetBulletHitConfigs,
				OtherBulletsHitConfig = this.OtherBulletsHitConfig
			};
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00043485 File Offset: 0x00041685
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x000434B0 File Offset: 0x000416B0
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000434C0 File Offset: 0x000416C0
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00043553 File Offset: 0x00041753
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00043568 File Offset: 0x00041768
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x000435FB File Offset: 0x000417FB
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

		// Token: 0x04001097 RID: 4247
		[Nullable(2)]
		protected new IHitLogicChangeTargetState FbInstance;

		// Token: 0x04001098 RID: 4248
		[Nullable(2)]
		protected new IHitLogicChangeTargetState_SetValue PocoInterface;

		// Token: 0x04001099 RID: 4249
		private List<IConditionHitConfigWithBullet> _TargetBulletHitConfigsCache;

		// Token: 0x0400109A RID: 4250
		private bool _TargetBulletHitConfigsInited;

		// Token: 0x0400109B RID: 4251
		private List<IConditionHitConfig> _OtherBulletsHitConfigCache;

		// Token: 0x0400109C RID: 4252
		private bool _OtherBulletsHitConfigInited;
	}
}
