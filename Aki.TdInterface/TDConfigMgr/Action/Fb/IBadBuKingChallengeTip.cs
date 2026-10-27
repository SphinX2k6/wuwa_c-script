using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002752 RID: 10066
	[NullableContext(1)]
	[Nullable(0)]
	public class IBadBuKingChallengeTip : ICommonTipType
	{
		// Token: 0x0600E041 RID: 57409 RVA: 0x00212DB5 File Offset: 0x00210FB5
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

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x0600E042 RID: 57410 RVA: 0x00212DD4 File Offset: 0x00210FD4
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x0600E043 RID: 57411 RVA: 0x00212DE1 File Offset: 0x00210FE1
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C50 RID: 31824
		private IBadBuKingChallengeTip Instance;
	}
}
