using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A14 RID: 10772
	public class ICommonTipGeneralFloatingTip : ICommonTipType
	{
		// Token: 0x0600EE17 RID: 60951 RVA: 0x0022F667 File Offset: 0x0022D867
		public static ICommonTipGeneralFloatingTip Create(ICommonTipGeneralFloatingTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x0600EE18 RID: 60952 RVA: 0x0022F686 File Offset: 0x0022D886
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x0600EE19 RID: 60953 RVA: 0x0022F693 File Offset: 0x0022D893
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0600EE1A RID: 60954 RVA: 0x0022F6A0 File Offset: 0x0022D8A0
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F4 RID: 33524
		private ICommonTipGeneralFloatingTip Instance;
	}
}
