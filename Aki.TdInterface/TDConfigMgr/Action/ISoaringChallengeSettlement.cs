using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CA RID: 8394
	public class ISoaringChallengeSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600B23A RID: 45626 RVA: 0x001905DC File Offset: 0x0018E7DC
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

		// Token: 0x0600B23B RID: 45627 RVA: 0x00190614 File Offset: 0x0018E814
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

		// Token: 0x0600B23C RID: 45628 RVA: 0x00190627 File Offset: 0x0018E827
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

		// Token: 0x0600B23D RID: 45629 RVA: 0x0019063A File Offset: 0x0018E83A
		public new ISoaringChallengeSettlement_SetValue ToSetValue()
		{
			return new ISoaringChallengeSettlement_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600B23E RID: 45630 RVA: 0x0019064D File Offset: 0x0018E84D
		// (set) Token: 0x0600B23F RID: 45631 RVA: 0x00190678 File Offset: 0x0018E878
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

		// Token: 0x040069CA RID: 27082
		[Nullable(2)]
		protected new ISoaringChallengeSettlement FbInstance;

		// Token: 0x040069CB RID: 27083
		[Nullable(2)]
		protected new ISoaringChallengeSettlement_SetValue PocoInterface;
	}
}
