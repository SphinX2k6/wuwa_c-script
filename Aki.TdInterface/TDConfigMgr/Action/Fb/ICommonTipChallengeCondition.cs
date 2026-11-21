using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0D RID: 10765
	public class ICommonTipChallengeCondition : ICommonTipType
	{
		// Token: 0x0600EDEE RID: 60910 RVA: 0x0022F451 File Offset: 0x0022D651
		public static ICommonTipChallengeCondition Create(ICommonTipChallengeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x0600EDEF RID: 60911 RVA: 0x0022F470 File Offset: 0x0022D670
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x0600EDF0 RID: 60912 RVA: 0x0022F47D File Offset: 0x0022D67D
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x0600EDF1 RID: 60913 RVA: 0x0022F48A File Offset: 0x0022D68A
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x0022F497 File Offset: 0x0022D697
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x0600EDF3 RID: 60915 RVA: 0x0022F49A File Offset: 0x0022D69A
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082ED RID: 33517
		private ICommonTipChallengeCondition Instance;
	}
}
