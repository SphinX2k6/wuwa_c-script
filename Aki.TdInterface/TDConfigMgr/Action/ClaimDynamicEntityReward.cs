using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164C RID: 5708
	public class ClaimDynamicEntityReward : ActionParams
	{
		// Token: 0x060080CB RID: 32971 RVA: 0x001325A0 File Offset: 0x001307A0
		private ClaimDynamicEntityReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClaimDynamicEntityReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClaimDynamicEntityReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClaimDynamicEntityReward_SetValue());
			}
			return result;
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x001325D8 File Offset: 0x001307D8
		public static ClaimDynamicEntityReward Create([Nullable(2)] ClaimDynamicEntityReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimDynamicEntityReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x001325EB File Offset: 0x001307EB
		public static ClaimDynamicEntityReward CreateFromSetValue([Nullable(2)] ClaimDynamicEntityReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClaimDynamicEntityReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x001325FE File Offset: 0x001307FE
		public ClaimDynamicEntityReward_SetValue ToSetValue()
		{
			return new ClaimDynamicEntityReward_SetValue
			{
				RewardType = this.RewardType
			};
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x00132614 File Offset: 0x00130814
		// (set) Token: 0x060080D0 RID: 32976 RVA: 0x00132675 File Offset: 0x00130875
		public virtual IClaimDynamicTrafficReward RewardType
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
					this._RewardTypeCache = IClaimDynamicTrafficReward.Create(this.FbInstance.RewardType);
				}
				else
				{
					ClaimDynamicEntityReward_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04004A52 RID: 19026
		[Nullable(2)]
		protected new ClaimDynamicEntityReward FbInstance;

		// Token: 0x04004A53 RID: 19027
		[Nullable(2)]
		protected ClaimDynamicEntityReward_SetValue PocoInterface;

		// Token: 0x04004A54 RID: 19028
		private IClaimDynamicTrafficReward _RewardTypeCache;

		// Token: 0x04004A55 RID: 19029
		private bool _RewardTypeInited;
	}
}
