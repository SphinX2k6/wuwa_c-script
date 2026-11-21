using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0F RID: 10767
	public class ICommonTipChallengeFail : ICommonTipType
	{
		// Token: 0x0600EDFA RID: 60922 RVA: 0x0022F4E9 File Offset: 0x0022D6E9
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

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x0600EDFB RID: 60923 RVA: 0x0022F508 File Offset: 0x0022D708
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x0022F515 File Offset: 0x0022D715
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x0600EDFD RID: 60925 RVA: 0x0022F522 File Offset: 0x0022D722
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082EF RID: 33519
		private ICommonTipChallengeFail Instance;
	}
}
