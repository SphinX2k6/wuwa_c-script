using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229C RID: 8860
	public class IVisionSettlementTip : ICommonTipType
	{
		// Token: 0x0600C0FC RID: 49404 RVA: 0x001BC6C4 File Offset: 0x001BA8C4
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

		// Token: 0x0600C0FD RID: 49405 RVA: 0x001BC6FC File Offset: 0x001BA8FC
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

		// Token: 0x0600C0FE RID: 49406 RVA: 0x001BC70F File Offset: 0x001BA90F
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

		// Token: 0x0600C0FF RID: 49407 RVA: 0x001BC724 File Offset: 0x001BA924
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

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600C100 RID: 49408 RVA: 0x001BC772 File Offset: 0x001BA972
		// (set) Token: 0x0600C101 RID: 49409 RVA: 0x001BC79D File Offset: 0x001BA99D
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

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600C102 RID: 49410 RVA: 0x001BC7AB File Offset: 0x001BA9AB
		// (set) Token: 0x0600C103 RID: 49411 RVA: 0x001BC7D6 File Offset: 0x001BA9D6
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

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600C104 RID: 49412 RVA: 0x001BC7E4 File Offset: 0x001BA9E4
		// (set) Token: 0x0600C105 RID: 49413 RVA: 0x001BC80F File Offset: 0x001BAA0F
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

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600C106 RID: 49414 RVA: 0x001BC81D File Offset: 0x001BAA1D
		// (set) Token: 0x0600C107 RID: 49415 RVA: 0x001BC834 File Offset: 0x001BAA34
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

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600C108 RID: 49416 RVA: 0x001BC842 File Offset: 0x001BAA42
		// (set) Token: 0x0600C109 RID: 49417 RVA: 0x001BC859 File Offset: 0x001BAA59
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

		// Token: 0x0400735F RID: 29535
		[Nullable(2)]
		protected new IVisionSettlementTip FbInstance;

		// Token: 0x04007360 RID: 29536
		[Nullable(2)]
		protected new IVisionSettlementTip_SetValue PocoInterface;
	}
}
