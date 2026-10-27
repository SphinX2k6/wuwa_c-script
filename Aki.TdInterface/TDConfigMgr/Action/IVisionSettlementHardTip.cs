using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002051 RID: 8273
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementHardTip : ICommonTipType
	{
		// Token: 0x0600B5C6 RID: 46534 RVA: 0x001A5DA4 File Offset: 0x001A3FA4
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

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x001A5DDC File Offset: 0x001A3FDC
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

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x001A5DEF File Offset: 0x001A3FEF
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

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x001A5E04 File Offset: 0x001A4004
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

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x001A5E52 File Offset: 0x001A4052
		// (set) Token: 0x0600B5CB RID: 46539 RVA: 0x001A5E7D File Offset: 0x001A407D
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

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x001A5E8B File Offset: 0x001A408B
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x001A5EB6 File Offset: 0x001A40B6
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

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x001A5EC4 File Offset: 0x001A40C4
		// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x001A5EEF File Offset: 0x001A40EF
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

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x001A5EFD File Offset: 0x001A40FD
		// (set) Token: 0x0600B5D1 RID: 46545 RVA: 0x001A5F14 File Offset: 0x001A4114
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

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x001A5F22 File Offset: 0x001A4122
		// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x001A5F39 File Offset: 0x001A4139
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

		// Token: 0x04006D4F RID: 27983
		[Nullable(2)]
		protected new IVisionSettlementHardTip FbInstance;

		// Token: 0x04006D50 RID: 27984
		[Nullable(2)]
		protected new IVisionSettlementHardTip_SetValue PocoInterface;
	}
}
