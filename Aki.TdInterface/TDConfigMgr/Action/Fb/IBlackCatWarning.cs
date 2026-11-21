using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1C RID: 10780
	public class IBlackCatWarning : ICommonTipType
	{
		// Token: 0x0600EE39 RID: 60985 RVA: 0x0022F86B File Offset: 0x0022DA6B
		public static IBlackCatWarning Create(IBlackCatWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlackCatWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x0022F88A File Offset: 0x0022DA8A
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x0600EE3B RID: 60987 RVA: 0x0022F897 File Offset: 0x0022DA97
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x040082FC RID: 33532
		private IBlackCatWarning Instance;
	}
}
