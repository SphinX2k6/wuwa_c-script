using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E95 RID: 7829
	[NullableContext(1)]
	[Nullable(0)]
	public class ISoaringChallengeSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600A782 RID: 42882 RVA: 0x0017A8DC File Offset: 0x00178ADC
		private ISoaringChallengeSettlement_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISoaringChallengeSettlement 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISoaringChallengeSettlement_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISoaringChallengeSettlement_SetValue());
			}
			return result;
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x0017A914 File Offset: 0x00178B14
		public static ISoaringChallengeSettlement Create([Nullable(2)] ISoaringChallengeSettlement instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISoaringChallengeSettlement
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x0017A927 File Offset: 0x00178B27
		public static ISoaringChallengeSettlement CreateFromSetValue([Nullable(2)] ISoaringChallengeSettlement_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISoaringChallengeSettlement
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0017A93A File Offset: 0x00178B3A
		public new ISoaringChallengeSettlement_SetValue ToSetValue()
		{
			return new ISoaringChallengeSettlement_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A786 RID: 42886 RVA: 0x0017A94D File Offset: 0x00178B4D
		// (set) Token: 0x0600A787 RID: 42887 RVA: 0x0017A978 File Offset: 0x00178B78
		public override EDynamicSettlementType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicSettlementType.Battle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063E6 RID: 25574
		[Nullable(2)]
		protected new ISoaringChallengeSettlement FbInstance;

		// Token: 0x040063E7 RID: 25575
		[Nullable(2)]
		protected new ISoaringChallengeSettlement_SetValue PocoInterface;
	}
}
