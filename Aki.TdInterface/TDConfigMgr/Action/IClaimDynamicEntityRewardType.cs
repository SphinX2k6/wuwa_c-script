using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189C RID: 6300
	[NullableContext(1)]
	[Nullable(0)]
	public class IClaimDynamicEntityRewardType
	{
		// Token: 0x06008745 RID: 34629 RVA: 0x00140CCC File Offset: 0x0013EECC
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

		// Token: 0x06008746 RID: 34630 RVA: 0x00140D04 File Offset: 0x0013EF04
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

		// Token: 0x06008747 RID: 34631 RVA: 0x00140D17 File Offset: 0x0013EF17
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

		// Token: 0x06008748 RID: 34632 RVA: 0x00140D2A File Offset: 0x0013EF2A
		public IClaimDynamicEntityRewardType_SetValue ToSetValue()
		{
			return new IClaimDynamicEntityRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x00140D3D File Offset: 0x0013EF3D
		// (set) Token: 0x0600874A RID: 34634 RVA: 0x00140D68 File Offset: 0x0013EF68
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

		// Token: 0x0400552C RID: 21804
		[Nullable(2)]
		protected IClaimDynamicEntityRewardType FbInstance;

		// Token: 0x0400552D RID: 21805
		[Nullable(2)]
		protected IClaimDynamicEntityRewardType_SetValue PocoInterface;
	}
}
