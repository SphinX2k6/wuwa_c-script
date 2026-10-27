using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189E RID: 6302
	[NullableContext(1)]
	[Nullable(0)]
	public class IClaimDynamicTrafficReward : IClaimDynamicEntityRewardType
	{
		// Token: 0x0600874D RID: 34637 RVA: 0x00140D88 File Offset: 0x0013EF88
		private IClaimDynamicTrafficReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClaimDynamicTrafficReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClaimDynamicTrafficReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClaimDynamicTrafficReward_SetValue());
			}
			return result;
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x00140DC0 File Offset: 0x0013EFC0
		public static IClaimDynamicTrafficReward Create([Nullable(2)] IClaimDynamicTrafficReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClaimDynamicTrafficReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x00140DD3 File Offset: 0x0013EFD3
		public static IClaimDynamicTrafficReward CreateFromSetValue([Nullable(2)] IClaimDynamicTrafficReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClaimDynamicTrafficReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00140DE6 File Offset: 0x0013EFE6
		public new IClaimDynamicTrafficReward_SetValue ToSetValue()
		{
			return new IClaimDynamicTrafficReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06008751 RID: 34641 RVA: 0x00140DF9 File Offset: 0x0013EFF9
		// (set) Token: 0x06008752 RID: 34642 RVA: 0x00140E24 File Offset: 0x0013F024
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

		// Token: 0x0400552F RID: 21807
		[Nullable(2)]
		protected new IClaimDynamicTrafficReward FbInstance;

		// Token: 0x04005530 RID: 21808
		[Nullable(2)]
		protected new IClaimDynamicTrafficReward_SetValue PocoInterface;
	}
}
