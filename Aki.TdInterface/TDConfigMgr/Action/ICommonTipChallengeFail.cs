using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001912 RID: 6418
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeFail : ICommonTipType
	{
		// Token: 0x0600898F RID: 35215 RVA: 0x00144A84 File Offset: 0x00142C84
		private ICommonTipChallengeFail_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipChallengeFail 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipChallengeFail_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipChallengeFail_SetValue());
			}
			return result;
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x00144ABC File Offset: 0x00142CBC
		public static ICommonTipChallengeFail Create([Nullable(2)] ICommonTipChallengeFail instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeFail
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x00144ACF File Offset: 0x00142CCF
		public static ICommonTipChallengeFail CreateFromSetValue([Nullable(2)] ICommonTipChallengeFail_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipChallengeFail
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x00144AE2 File Offset: 0x00142CE2
		public new ICommonTipChallengeFail_SetValue ToSetValue()
		{
			return new ICommonTipChallengeFail_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06008993 RID: 35219 RVA: 0x00144B0D File Offset: 0x00142D0D
		// (set) Token: 0x06008994 RID: 35220 RVA: 0x00144B38 File Offset: 0x00142D38
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

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x00144B46 File Offset: 0x00142D46
		// (set) Token: 0x06008996 RID: 35222 RVA: 0x00144B71 File Offset: 0x00142D71
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

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06008997 RID: 35223 RVA: 0x00144B7F File Offset: 0x00142D7F
		// (set) Token: 0x06008998 RID: 35224 RVA: 0x00144B96 File Offset: 0x00142D96
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

		// Token: 0x0400562A RID: 22058
		[Nullable(2)]
		protected new ICommonTipChallengeFail FbInstance;

		// Token: 0x0400562B RID: 22059
		[Nullable(2)]
		protected new ICommonTipChallengeFail_SetValue PocoInterface;
	}
}
