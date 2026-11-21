using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9D RID: 6813
	public class ICommonTipChallengeSuccess : ICommonTipType
	{
		// Token: 0x060090C7 RID: 37063 RVA: 0x001544F4 File Offset: 0x001526F4
		private ICommonTipChallengeSuccess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipChallengeSuccess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipChallengeSuccess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipChallengeSuccess_SetValue());
			}
			return result;
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x0015452C File Offset: 0x0015272C
		public static ICommonTipChallengeSuccess Create([Nullable(2)] ICommonTipChallengeSuccess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeSuccess
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x0015453F File Offset: 0x0015273F
		public static ICommonTipChallengeSuccess CreateFromSetValue([Nullable(2)] ICommonTipChallengeSuccess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipChallengeSuccess
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x00154552 File Offset: 0x00152752
		public new ICommonTipChallengeSuccess_SetValue ToSetValue()
		{
			return new ICommonTipChallengeSuccess_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x060090CB RID: 37067 RVA: 0x0015457D File Offset: 0x0015277D
		// (set) Token: 0x060090CC RID: 37068 RVA: 0x001545A8 File Offset: 0x001527A8
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

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x060090CD RID: 37069 RVA: 0x001545B6 File Offset: 0x001527B6
		// (set) Token: 0x060090CE RID: 37070 RVA: 0x001545E1 File Offset: 0x001527E1
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

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x060090CF RID: 37071 RVA: 0x001545EF File Offset: 0x001527EF
		// (set) Token: 0x060090D0 RID: 37072 RVA: 0x00154606 File Offset: 0x00152806
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

		// Token: 0x04005A7F RID: 23167
		[Nullable(2)]
		protected new ICommonTipChallengeSuccess FbInstance;

		// Token: 0x04005A80 RID: 23168
		[Nullable(2)]
		protected new ICommonTipChallengeSuccess_SetValue PocoInterface;
	}
}
