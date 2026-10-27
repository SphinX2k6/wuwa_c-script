using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002984 RID: 10628
	public class IBattleSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600EB6A RID: 60266 RVA: 0x00226F90 File Offset: 0x00225190
		[NullableContext(1)]
		public static IBattleSettlement Create(IBattleSettlement? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleSettlement
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x0600EB6B RID: 60267 RVA: 0x00226FAF File Offset: 0x002251AF
		public override EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x0600EB6C RID: 60268 RVA: 0x00226FBC File Offset: 0x002251BC
		public virtual int? GamePlayCue
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.GamePlayCue);
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x0600EB6D RID: 60269 RVA: 0x00226FF4 File Offset: 0x002251F4
		public virtual EBattleSettlementBgmType? BgmType
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EBattleSettlementBgmType?((EBattleSettlementBgmType)this.Instance.BgmType);
			}
		}

		// Token: 0x040081A8 RID: 33192
		private IBattleSettlement Instance;
	}
}
