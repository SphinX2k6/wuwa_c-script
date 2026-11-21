using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1E RID: 10782
	public class IBadBuKingChallengeTip : ICommonTipType
	{
		// Token: 0x0600EE41 RID: 60993 RVA: 0x0022F8ED File Offset: 0x0022DAED
		public static IBadBuKingChallengeTip Create(IBadBuKingChallengeTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBadBuKingChallengeTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x0600EE42 RID: 60994 RVA: 0x0022F90C File Offset: 0x0022DB0C
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x0600EE43 RID: 60995 RVA: 0x0022F919 File Offset: 0x0022DB19
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082FE RID: 33534
		private IBadBuKingChallengeTip Instance;
	}
}
