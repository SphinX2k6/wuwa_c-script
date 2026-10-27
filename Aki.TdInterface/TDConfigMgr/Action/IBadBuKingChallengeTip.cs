using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017F6 RID: 6134
	[NullableContext(1)]
	[Nullable(0)]
	public class IBadBuKingChallengeTip : ICommonTipType
	{
		// Token: 0x060083BD RID: 33725 RVA: 0x0013A5C8 File Offset: 0x001387C8
		private IBadBuKingChallengeTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBadBuKingChallengeTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBadBuKingChallengeTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBadBuKingChallengeTip_SetValue());
			}
			return result;
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x0013A600 File Offset: 0x00138800
		public static IBadBuKingChallengeTip Create([Nullable(2)] IBadBuKingChallengeTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBadBuKingChallengeTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x0013A613 File Offset: 0x00138813
		public static IBadBuKingChallengeTip CreateFromSetValue([Nullable(2)] IBadBuKingChallengeTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBadBuKingChallengeTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0013A626 File Offset: 0x00138826
		public new IBadBuKingChallengeTip_SetValue ToSetValue()
		{
			return new IBadBuKingChallengeTip_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x060083C1 RID: 33729 RVA: 0x0013A645 File Offset: 0x00138845
		// (set) Token: 0x060083C2 RID: 33730 RVA: 0x0013A670 File Offset: 0x00138870
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

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x0013A67E File Offset: 0x0013887E
		// (set) Token: 0x060083C4 RID: 33732 RVA: 0x0013A6A9 File Offset: 0x001388A9
		public virtual string WarningText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningText;
			}
			set
			{
				this.GetOrCreatePoco().WarningText = value;
			}
		}

		// Token: 0x04005387 RID: 21383
		[Nullable(2)]
		protected new IBadBuKingChallengeTip FbInstance;

		// Token: 0x04005388 RID: 21384
		[Nullable(2)]
		protected new IBadBuKingChallengeTip_SetValue PocoInterface;
	}
}
