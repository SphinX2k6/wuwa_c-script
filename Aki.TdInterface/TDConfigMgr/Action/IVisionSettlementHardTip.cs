using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229A RID: 8858
	public class IVisionSettlementHardTip : ICommonTipType
	{
		// Token: 0x0600C0EC RID: 49388 RVA: 0x001BC510 File Offset: 0x001BA710
		private IVisionSettlementHardTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSettlementHardTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSettlementHardTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSettlementHardTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0ED RID: 49389 RVA: 0x001BC548 File Offset: 0x001BA748
		public static IVisionSettlementHardTip Create([Nullable(2)] IVisionSettlementHardTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSettlementHardTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0EE RID: 49390 RVA: 0x001BC55B File Offset: 0x001BA75B
		public static IVisionSettlementHardTip CreateFromSetValue([Nullable(2)] IVisionSettlementHardTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSettlementHardTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0EF RID: 49391 RVA: 0x001BC570 File Offset: 0x001BA770
		public new IVisionSettlementHardTip_SetValue ToSetValue()
		{
			return new IVisionSettlementHardTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x001BC5BE File Offset: 0x001BA7BE
		// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x001BC5E9 File Offset: 0x001BA7E9
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x001BC5F7 File Offset: 0x001BA7F7
		// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x001BC622 File Offset: 0x001BA822
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x001BC630 File Offset: 0x001BA830
		// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x001BC65B File Offset: 0x001BA85B
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x001BC669 File Offset: 0x001BA869
		// (set) Token: 0x0600C0F7 RID: 49399 RVA: 0x001BC680 File Offset: 0x001BA880
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600C0F8 RID: 49400 RVA: 0x001BC68E File Offset: 0x001BA88E
		// (set) Token: 0x0600C0F9 RID: 49401 RVA: 0x001BC6A5 File Offset: 0x001BA8A5
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x04007358 RID: 29528
		[Nullable(2)]
		protected new IVisionSettlementHardTip FbInstance;

		// Token: 0x04007359 RID: 29529
		[Nullable(2)]
		protected new IVisionSettlementHardTip_SetValue PocoInterface;
	}
}
