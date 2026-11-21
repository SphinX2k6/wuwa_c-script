using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A27 RID: 6695
	public class IClaimDynamicEntityRewardType
	{
		// Token: 0x06008E6D RID: 36461 RVA: 0x00150500 File Offset: 0x0014E700
		private IClaimDynamicEntityRewardType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClaimDynamicEntityRewardType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClaimDynamicEntityRewardType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClaimDynamicEntityRewardType_SetValue());
			}
			return result;
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x00150538 File Offset: 0x0014E738
		public static IClaimDynamicEntityRewardType Create([Nullable(2)] IClaimDynamicEntityRewardType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClaimDynamicEntityRewardType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x0015054B File Offset: 0x0014E74B
		public static IClaimDynamicEntityRewardType CreateFromSetValue([Nullable(2)] IClaimDynamicEntityRewardType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClaimDynamicEntityRewardType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x0015055E File Offset: 0x0014E75E
		public IClaimDynamicEntityRewardType_SetValue ToSetValue()
		{
			return new IClaimDynamicEntityRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x00150571 File Offset: 0x0014E771
		// (set) Token: 0x06008E72 RID: 36466 RVA: 0x0015059C File Offset: 0x0014E79C
		public virtual EDynamicEntityRewardType Type
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

		// Token: 0x04005979 RID: 22905
		[Nullable(2)]
		protected IClaimDynamicEntityRewardType FbInstance;

		// Token: 0x0400597A RID: 22906
		[Nullable(2)]
		protected IClaimDynamicEntityRewardType_SetValue PocoInterface;
	}
}
