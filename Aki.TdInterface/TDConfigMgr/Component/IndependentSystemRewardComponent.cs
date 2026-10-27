using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000542 RID: 1346
	[NullableContext(1)]
	[Nullable(0)]
	public class IndependentSystemRewardComponent : IComponentBase
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x0004F860 File Offset: 0x0004DA60
		private IndependentSystemRewardComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IndependentSystemRewardComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IndependentSystemRewardComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IndependentSystemRewardComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0004F898 File Offset: 0x0004DA98
		public static IndependentSystemRewardComponent Create([Nullable(2)] IndependentSystemRewardComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IndependentSystemRewardComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0004F8AB File Offset: 0x0004DAAB
		public static IndependentSystemRewardComponent CreateFromSetValue([Nullable(2)] IndependentSystemRewardComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IndependentSystemRewardComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0004F8BE File Offset: 0x0004DABE
		public new IndependentSystemRewardComponent_SetValue ToSetValue()
		{
			return new IndependentSystemRewardComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RewardType = this.RewardType
			};
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0004F8EC File Offset: 0x0004DAEC
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0004F926 File Offset: 0x0004DB26
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IndependentSystemRewardComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0004F934 File Offset: 0x0004DB34
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x0004F95E File Offset: 0x0004DB5E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0004F96C File Offset: 0x0004DB6C
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0004F9CD File Offset: 0x0004DBCD
		public virtual IDarkTideIndependentSystemReward RewardType
		{
			get
			{
				if (this._RewardTypeInited)
				{
					return this._RewardTypeCache;
				}
				this._RewardTypeInited = true;
				if (this.FbInstance != null)
				{
					this._RewardTypeCache = IDarkTideIndependentSystemReward.Create(this.FbInstance.RewardType);
				}
				else
				{
					IndependentSystemRewardComponent_SetValue pocoInterface = this.PocoInterface;
					this._RewardTypeCache = ((pocoInterface != null) ? pocoInterface.RewardType : null);
				}
				return this._RewardTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().RewardType = value;
				this._RewardTypeInited = false;
			}
		}

		// Token: 0x040013CE RID: 5070
		[Nullable(2)]
		protected new IndependentSystemRewardComponent FbInstance;

		// Token: 0x040013CF RID: 5071
		[Nullable(2)]
		protected new IndependentSystemRewardComponent_SetValue PocoInterface;

		// Token: 0x040013D0 RID: 5072
		private IDarkTideIndependentSystemReward _RewardTypeCache;

		// Token: 0x040013D1 RID: 5073
		private bool _RewardTypeInited;
	}
}
