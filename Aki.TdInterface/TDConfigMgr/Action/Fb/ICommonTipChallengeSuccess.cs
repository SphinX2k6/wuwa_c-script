using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002742 RID: 10050
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeSuccess : ICommonTipType
	{
		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0021296D File Offset: 0x00210B6D
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

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0600DFF6 RID: 57334 RVA: 0x0021298C File Offset: 0x00210B8C
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x00212999 File Offset: 0x00210B99
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x002129A6 File Offset: 0x00210BA6
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C40 RID: 31808
		private ICommonTipChallengeSuccess Instance;
	}
}
