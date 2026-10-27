using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002AB RID: 683
	[NullableContext(2)]
	[Nullable(0)]
	public class IDarkTideIndependentSystemReward : IIndependentSystemRewardType
	{
		// Token: 0x06000CC5 RID: 3269 RVA: 0x00030C38 File Offset: 0x0002EE38
		[NullableContext(1)]
		private IDarkTideIndependentSystemReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideIndependentSystemReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideIndependentSystemReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideIndependentSystemReward_SetValue());
			}
			return result;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00030C70 File Offset: 0x0002EE70
		[NullableContext(1)]
		public static IDarkTideIndependentSystemReward Create([Nullable(2)] IDarkTideIndependentSystemReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideIndependentSystemReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00030C83 File Offset: 0x0002EE83
		[NullableContext(1)]
		public static IDarkTideIndependentSystemReward CreateFromSetValue([Nullable(2)] IDarkTideIndependentSystemReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideIndependentSystemReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00030C96 File Offset: 0x0002EE96
		[NullableContext(1)]
		public new IDarkTideIndependentSystemReward_SetValue ToSetValue()
		{
			return new IDarkTideIndependentSystemReward_SetValue
			{
				Type = this.Type,
				RewardId = this.RewardId,
				RewardIdList = this.RewardIdList
			};
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00030CC1 File Offset: 0x0002EEC1
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00030CEC File Offset: 0x0002EEEC
		public override EIndependentSystemRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EIndependentSystemRewardType.DarkTide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00030CFA File Offset: 0x0002EEFA
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00030D25 File Offset: 0x0002EF25
		public virtual int RewardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardId;
			}
			set
			{
				this.GetOrCreatePoco().RewardId = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00030D33 File Offset: 0x0002EF33
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00030D5A File Offset: 0x0002EF5A
		public virtual List<int> RewardIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardIdList;
				}
				IDarkTideIndependentSystemReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RewardIdList;
			}
			set
			{
				this.GetOrCreatePoco().RewardIdList = value;
			}
		}

		// Token: 0x04000BD2 RID: 3026
		protected new IDarkTideIndependentSystemReward FbInstance;

		// Token: 0x04000BD3 RID: 3027
		protected new IDarkTideIndependentSystemReward_SetValue PocoInterface;
	}
}
