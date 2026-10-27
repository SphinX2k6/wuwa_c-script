using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EF RID: 751
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicTrafficReward : IDynamicEntityRewardType
	{
		// Token: 0x06000E7D RID: 3709 RVA: 0x0003474C File Offset: 0x0003294C
		private IDynamicTrafficReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicTrafficReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicTrafficReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicTrafficReward_SetValue());
			}
			return result;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00034784 File Offset: 0x00032984
		public static IDynamicTrafficReward Create([Nullable(2)] IDynamicTrafficReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00034797 File Offset: 0x00032997
		public static IDynamicTrafficReward CreateFromSetValue([Nullable(2)] IDynamicTrafficReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000347AA File Offset: 0x000329AA
		public new IDynamicTrafficReward_SetValue ToSetValue()
		{
			return new IDynamicTrafficReward_SetValue
			{
				Type = this.Type,
				RewardId = this.RewardId
			};
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000347C9 File Offset: 0x000329C9
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000347F4 File Offset: 0x000329F4
		public override EDynamicEntityRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00034802 File Offset: 0x00032A02
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x0003482D File Offset: 0x00032A2D
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

		// Token: 0x04000CD0 RID: 3280
		[Nullable(2)]
		protected new IDynamicTrafficReward FbInstance;

		// Token: 0x04000CD1 RID: 3281
		[Nullable(2)]
		protected new IDynamicTrafficReward_SetValue PocoInterface;
	}
}
