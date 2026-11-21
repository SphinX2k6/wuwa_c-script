using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200197F RID: 6527
	public class IBadBuKingChallengeTip : ICommonTipType
	{
		// Token: 0x06008AD9 RID: 35545 RVA: 0x00149CB0 File Offset: 0x00147EB0
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

		// Token: 0x06008ADA RID: 35546 RVA: 0x00149CE8 File Offset: 0x00147EE8
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

		// Token: 0x06008ADB RID: 35547 RVA: 0x00149CFB File Offset: 0x00147EFB
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

		// Token: 0x06008ADC RID: 35548 RVA: 0x00149D0E File Offset: 0x00147F0E
		public new IBadBuKingChallengeTip_SetValue ToSetValue()
		{
			return new IBadBuKingChallengeTip_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x06008ADD RID: 35549 RVA: 0x00149D2D File Offset: 0x00147F2D
		// (set) Token: 0x06008ADE RID: 35550 RVA: 0x00149D58 File Offset: 0x00147F58
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

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x00149D66 File Offset: 0x00147F66
		// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x00149D91 File Offset: 0x00147F91
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

		// Token: 0x040057CF RID: 22479
		[Nullable(2)]
		protected new IBadBuKingChallengeTip FbInstance;

		// Token: 0x040057D0 RID: 22480
		[Nullable(2)]
		protected new IBadBuKingChallengeTip_SetValue PocoInterface;
	}
}
