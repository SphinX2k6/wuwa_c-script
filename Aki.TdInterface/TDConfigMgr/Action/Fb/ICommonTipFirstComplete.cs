using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A18 RID: 10776
	public class ICommonTipFirstComplete : ICommonTipType
	{
		// Token: 0x0600EE28 RID: 60968 RVA: 0x0022F764 File Offset: 0x0022D964
		public static ICommonTipFirstComplete Create(ICommonTipFirstComplete? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipFirstComplete
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x0600EE29 RID: 60969 RVA: 0x0022F783 File Offset: 0x0022D983
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x0600EE2A RID: 60970 RVA: 0x0022F790 File Offset: 0x0022D990
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x0600EE2B RID: 60971 RVA: 0x0022F79D File Offset: 0x0022D99D
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F8 RID: 33528
		private ICommonTipFirstComplete Instance;
	}
}
