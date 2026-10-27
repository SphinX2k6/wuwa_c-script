using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001926 RID: 6438
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipTriggerDelegation : ICommonTipType
	{
		// Token: 0x06008A05 RID: 35333 RVA: 0x00145658 File Offset: 0x00143858
		private ICommonTipTriggerDelegation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipTriggerDelegation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipTriggerDelegation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipTriggerDelegation_SetValue());
			}
			return result;
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x00145690 File Offset: 0x00143890
		public static ICommonTipTriggerDelegation Create([Nullable(2)] ICommonTipTriggerDelegation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipTriggerDelegation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x001456A3 File Offset: 0x001438A3
		public static ICommonTipTriggerDelegation CreateFromSetValue([Nullable(2)] ICommonTipTriggerDelegation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipTriggerDelegation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A08 RID: 35336 RVA: 0x001456B8 File Offset: 0x001438B8
		public new ICommonTipTriggerDelegation_SetValue ToSetValue()
		{
			return new ICommonTipTriggerDelegation_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x00145706 File Offset: 0x00143906
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x00145731 File Offset: 0x00143931
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

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x0014573F File Offset: 0x0014393F
		// (set) Token: 0x06008A0C RID: 35340 RVA: 0x0014576A File Offset: 0x0014396A
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

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x06008A0D RID: 35341 RVA: 0x00145778 File Offset: 0x00143978
		// (set) Token: 0x06008A0E RID: 35342 RVA: 0x001457A3 File Offset: 0x001439A3
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

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x06008A0F RID: 35343 RVA: 0x001457B1 File Offset: 0x001439B1
		// (set) Token: 0x06008A10 RID: 35344 RVA: 0x001457C8 File Offset: 0x001439C8
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

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x001457D6 File Offset: 0x001439D6
		// (set) Token: 0x06008A12 RID: 35346 RVA: 0x001457ED File Offset: 0x001439ED
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

		// Token: 0x0400565B RID: 22107
		[Nullable(2)]
		protected new ICommonTipTriggerDelegation FbInstance;

		// Token: 0x0400565C RID: 22108
		[Nullable(2)]
		protected new ICommonTipTriggerDelegation_SetValue PocoInterface;
	}
}
