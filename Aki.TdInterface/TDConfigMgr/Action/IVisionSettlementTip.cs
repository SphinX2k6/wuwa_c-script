using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002053 RID: 8275
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementTip : ICommonTipType
	{
		// Token: 0x0600B5D6 RID: 46550 RVA: 0x001A5F58 File Offset: 0x001A4158
		private IVisionSettlementTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSettlementTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSettlementTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSettlementTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x001A5F90 File Offset: 0x001A4190
		public static IVisionSettlementTip Create([Nullable(2)] IVisionSettlementTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSettlementTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x001A5FA3 File Offset: 0x001A41A3
		public static IVisionSettlementTip CreateFromSetValue([Nullable(2)] IVisionSettlementTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSettlementTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x001A5FB8 File Offset: 0x001A41B8
		public new IVisionSettlementTip_SetValue ToSetValue()
		{
			return new IVisionSettlementTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x001A6006 File Offset: 0x001A4206
		// (set) Token: 0x0600B5DB RID: 46555 RVA: 0x001A6031 File Offset: 0x001A4231
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

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x001A603F File Offset: 0x001A423F
		// (set) Token: 0x0600B5DD RID: 46557 RVA: 0x001A606A File Offset: 0x001A426A
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

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600B5DE RID: 46558 RVA: 0x001A6078 File Offset: 0x001A4278
		// (set) Token: 0x0600B5DF RID: 46559 RVA: 0x001A60A3 File Offset: 0x001A42A3
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

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600B5E0 RID: 46560 RVA: 0x001A60B1 File Offset: 0x001A42B1
		// (set) Token: 0x0600B5E1 RID: 46561 RVA: 0x001A60C8 File Offset: 0x001A42C8
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

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600B5E2 RID: 46562 RVA: 0x001A60D6 File Offset: 0x001A42D6
		// (set) Token: 0x0600B5E3 RID: 46563 RVA: 0x001A60ED File Offset: 0x001A42ED
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

		// Token: 0x04006D56 RID: 27990
		[Nullable(2)]
		protected new IVisionSettlementTip FbInstance;

		// Token: 0x04006D57 RID: 27991
		[Nullable(2)]
		protected new IVisionSettlementTip_SetValue PocoInterface;
	}
}
