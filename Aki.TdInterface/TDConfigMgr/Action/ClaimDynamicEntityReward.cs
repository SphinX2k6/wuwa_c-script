using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F3 RID: 5363
	[NullableContext(1)]
	[Nullable(0)]
	public class ClaimDynamicEntityReward : ActionParams
	{
		// Token: 0x060079FE RID: 31230 RVA: 0x00123968 File Offset: 0x00121B68
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

		// Token: 0x060079FF RID: 31231 RVA: 0x001239A0 File Offset: 0x00121BA0
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

		// Token: 0x06007A00 RID: 31232 RVA: 0x001239B3 File Offset: 0x00121BB3
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

		// Token: 0x06007A01 RID: 31233 RVA: 0x001239C6 File Offset: 0x00121BC6
		public ClaimDynamicEntityReward_SetValue ToSetValue()
		{
			return new ClaimDynamicEntityReward_SetValue
			{
				RewardType = this.RewardType
			};
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x001239DC File Offset: 0x00121BDC
		// (set) Token: 0x06007A03 RID: 31235 RVA: 0x00123A3D File Offset: 0x00121C3D
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

		// Token: 0x040046B7 RID: 18103
		[Nullable(2)]
		protected new ClaimDynamicEntityReward FbInstance;

		// Token: 0x040046B8 RID: 18104
		[Nullable(2)]
		protected ClaimDynamicEntityReward_SetValue PocoInterface;

		// Token: 0x040046B9 RID: 18105
		private IClaimDynamicTrafficReward _RewardTypeCache;

		// Token: 0x040046BA RID: 18106
		private bool _RewardTypeInited;
	}
}
