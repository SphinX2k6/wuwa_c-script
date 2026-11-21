using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A17 RID: 10775
	public class ICommonTipEnterInRange : ICommonTipType
	{
		// Token: 0x0600EE23 RID: 60963 RVA: 0x0022F720 File Offset: 0x0022D920
		public static ICommonTipEnterInRange Create(ICommonTipEnterInRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x0600EE24 RID: 60964 RVA: 0x0022F73F File Offset: 0x0022D93F
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x0600EE25 RID: 60965 RVA: 0x0022F74C File Offset: 0x0022D94C
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x0600EE26 RID: 60966 RVA: 0x0022F759 File Offset: 0x0022D959
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F7 RID: 33527
		private ICommonTipEnterInRange Instance;
	}
}
