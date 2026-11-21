using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0E RID: 10766
	public class ICommonTipChallengeSuccess : ICommonTipType
	{
		// Token: 0x0600EDF5 RID: 60917 RVA: 0x0022F4A5 File Offset: 0x0022D6A5
		public static ICommonTipChallengeSuccess Create(ICommonTipChallengeSuccess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeSuccess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x0022F4C4 File Offset: 0x0022D6C4
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x0600EDF7 RID: 60919 RVA: 0x0022F4D1 File Offset: 0x0022D6D1
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x0600EDF8 RID: 60920 RVA: 0x0022F4DE File Offset: 0x0022D6DE
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082EE RID: 33518
		private ICommonTipChallengeSuccess Instance;
	}
}
