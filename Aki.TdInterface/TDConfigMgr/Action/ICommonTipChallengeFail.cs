using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9B RID: 6811
	public class ICommonTipChallengeFail : ICommonTipType
	{
		// Token: 0x060090BB RID: 37051 RVA: 0x001543C4 File Offset: 0x001525C4
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

		// Token: 0x060090BC RID: 37052 RVA: 0x001543FC File Offset: 0x001525FC
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

		// Token: 0x060090BD RID: 37053 RVA: 0x0015440F File Offset: 0x0015260F
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

		// Token: 0x060090BE RID: 37054 RVA: 0x00154422 File Offset: 0x00152622
		public new ICommonTipChallengeFail_SetValue ToSetValue()
		{
			return new ICommonTipChallengeFail_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x060090BF RID: 37055 RVA: 0x0015444D File Offset: 0x0015264D
		// (set) Token: 0x060090C0 RID: 37056 RVA: 0x00154478 File Offset: 0x00152678
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

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x060090C1 RID: 37057 RVA: 0x00154486 File Offset: 0x00152686
		// (set) Token: 0x060090C2 RID: 37058 RVA: 0x001544B1 File Offset: 0x001526B1
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

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x060090C3 RID: 37059 RVA: 0x001544BF File Offset: 0x001526BF
		// (set) Token: 0x060090C4 RID: 37060 RVA: 0x001544D6 File Offset: 0x001526D6
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

		// Token: 0x04005A7A RID: 23162
		[Nullable(2)]
		protected new ICommonTipChallengeFail FbInstance;

		// Token: 0x04005A7B RID: 23163
		[Nullable(2)]
		protected new ICommonTipChallengeFail_SetValue PocoInterface;
	}
}
