using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001910 RID: 6416
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeCondition : ICommonTipType
	{
		// Token: 0x0600897F RID: 35199 RVA: 0x001448D0 File Offset: 0x00142AD0
		private ICommonTipChallengeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipChallengeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipChallengeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipChallengeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x00144908 File Offset: 0x00142B08
		public static ICommonTipChallengeCondition Create([Nullable(2)] ICommonTipChallengeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x0014491B File Offset: 0x00142B1B
		public static ICommonTipChallengeCondition CreateFromSetValue([Nullable(2)] ICommonTipChallengeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00144930 File Offset: 0x00142B30
		public new ICommonTipChallengeCondition_SetValue ToSetValue()
		{
			return new ICommonTipChallengeCondition_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x0014497E File Offset: 0x00142B7E
		// (set) Token: 0x06008984 RID: 35204 RVA: 0x001449A9 File Offset: 0x00142BA9
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

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06008985 RID: 35205 RVA: 0x001449B7 File Offset: 0x00142BB7
		// (set) Token: 0x06008986 RID: 35206 RVA: 0x001449E2 File Offset: 0x00142BE2
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

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x001449F0 File Offset: 0x00142BF0
		// (set) Token: 0x06008988 RID: 35208 RVA: 0x00144A1B File Offset: 0x00142C1B
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

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06008989 RID: 35209 RVA: 0x00144A29 File Offset: 0x00142C29
		// (set) Token: 0x0600898A RID: 35210 RVA: 0x00144A40 File Offset: 0x00142C40
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

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600898B RID: 35211 RVA: 0x00144A4E File Offset: 0x00142C4E
		// (set) Token: 0x0600898C RID: 35212 RVA: 0x00144A65 File Offset: 0x00142C65
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

		// Token: 0x04005623 RID: 22051
		[Nullable(2)]
		protected new ICommonTipChallengeCondition FbInstance;

		// Token: 0x04005624 RID: 22052
		[Nullable(2)]
		protected new ICommonTipChallengeCondition_SetValue PocoInterface;
	}
}
