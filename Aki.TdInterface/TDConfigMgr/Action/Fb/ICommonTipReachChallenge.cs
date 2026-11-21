using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A10 RID: 10768
	public class ICommonTipReachChallenge : ICommonTipType
	{
		// Token: 0x0600EDFF RID: 60927 RVA: 0x0022F52D File Offset: 0x0022D72D
		public static ICommonTipReachChallenge Create(ICommonTipReachChallenge? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipReachChallenge
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x0022F54C File Offset: 0x0022D74C
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0022F559 File Offset: 0x0022D759
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x0022F566 File Offset: 0x0022D766
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F0 RID: 33520
		private ICommonTipReachChallenge Instance;
	}
}
