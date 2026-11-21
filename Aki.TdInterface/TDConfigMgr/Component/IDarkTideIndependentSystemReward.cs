using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F0 RID: 752
	public class IDarkTideIndependentSystemReward : IIndependentSystemRewardType
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00033A28 File Offset: 0x00031C28
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

		// Token: 0x06000DEA RID: 3562 RVA: 0x00033A60 File Offset: 0x00031C60
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x00033A73 File Offset: 0x00031C73
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

		// Token: 0x06000DEC RID: 3564 RVA: 0x00033A86 File Offset: 0x00031C86
		public new IDarkTideIndependentSystemReward_SetValue ToSetValue()
		{
			return new IDarkTideIndependentSystemReward_SetValue
			{
				Type = this.Type,
				RewardId = this.RewardId,
				RewardIdList = this.RewardIdList
			};
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00033AB1 File Offset: 0x00031CB1
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x00033ADC File Offset: 0x00031CDC
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00033AEA File Offset: 0x00031CEA
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00033B15 File Offset: 0x00031D15
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00033B23 File Offset: 0x00031D23
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00033B4A File Offset: 0x00031D4A
		[Nullable(2)]
		public virtual List<int> RewardIdList
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RewardIdList = value;
			}
		}

		// Token: 0x04000CB7 RID: 3255
		[Nullable(2)]
		protected new IDarkTideIndependentSystemReward FbInstance;

		// Token: 0x04000CB8 RID: 3256
		[Nullable(2)]
		protected new IDarkTideIndependentSystemReward_SetValue PocoInterface;
	}
}
