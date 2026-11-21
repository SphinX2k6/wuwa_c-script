using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A29 RID: 6697
	public class IClaimDynamicTrafficReward : IClaimDynamicEntityRewardType
	{
		// Token: 0x06008E75 RID: 36469 RVA: 0x001505BC File Offset: 0x0014E7BC
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

		// Token: 0x06008E76 RID: 36470 RVA: 0x001505F4 File Offset: 0x0014E7F4
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

		// Token: 0x06008E77 RID: 36471 RVA: 0x00150607 File Offset: 0x0014E807
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

		// Token: 0x06008E78 RID: 36472 RVA: 0x0015061A File Offset: 0x0014E81A
		public new IClaimDynamicTrafficReward_SetValue ToSetValue()
		{
			return new IClaimDynamicTrafficReward_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x0015062D File Offset: 0x0014E82D
		// (set) Token: 0x06008E7A RID: 36474 RVA: 0x00150658 File Offset: 0x0014E858
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

		// Token: 0x0400597C RID: 22908
		[Nullable(2)]
		protected new IClaimDynamicTrafficReward FbInstance;

		// Token: 0x0400597D RID: 22909
		[Nullable(2)]
		protected new IClaimDynamicTrafficReward_SetValue PocoInterface;
	}
}
