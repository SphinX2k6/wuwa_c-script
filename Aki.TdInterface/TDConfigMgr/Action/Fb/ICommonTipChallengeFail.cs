using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002743 RID: 10051
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeFail : ICommonTipType
	{
		// Token: 0x0600DFFA RID: 57338 RVA: 0x002129B1 File Offset: 0x00210BB1
		public static ICommonTipChallengeFail Create(ICommonTipChallengeFail? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeFail
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0600DFFB RID: 57339 RVA: 0x002129D0 File Offset: 0x00210BD0
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x002129DD File Offset: 0x00210BDD
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x002129EA File Offset: 0x00210BEA
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C41 RID: 31809
		private ICommonTipChallengeFail Instance;
	}
}
