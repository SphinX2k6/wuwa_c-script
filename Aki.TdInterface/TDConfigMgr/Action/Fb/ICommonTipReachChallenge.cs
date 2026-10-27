using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002744 RID: 10052
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipReachChallenge : ICommonTipType
	{
		// Token: 0x0600DFFF RID: 57343 RVA: 0x002129F5 File Offset: 0x00210BF5
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

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x00212A14 File Offset: 0x00210C14
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x0600E001 RID: 57345 RVA: 0x00212A21 File Offset: 0x00210C21
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x00212A2E File Offset: 0x00210C2E
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C42 RID: 31810
		private ICommonTipReachChallenge Instance;
	}
}
