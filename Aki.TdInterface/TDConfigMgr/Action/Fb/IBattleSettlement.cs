using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6A RID: 11370
	public class IBattleSettlement : IDynamicSettlementConfig
	{
		// Token: 0x0600F9E5 RID: 63973 RVA: 0x002446E8 File Offset: 0x002428E8
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

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x0600F9E6 RID: 63974 RVA: 0x00244707 File Offset: 0x00242907
		public override EDynamicSettlementType Type
		{
			get
			{
				return (EDynamicSettlementType)this.Instance.Type;
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x0600F9E7 RID: 63975 RVA: 0x00244714 File Offset: 0x00242914
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

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x0600F9E8 RID: 63976 RVA: 0x0024474C File Offset: 0x0024294C
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

		// Token: 0x0400888C RID: 34956
		private IBattleSettlement Instance;
	}
}
