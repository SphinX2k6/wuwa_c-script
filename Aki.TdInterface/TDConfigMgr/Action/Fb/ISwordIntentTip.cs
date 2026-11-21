using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2C RID: 10796
	public class ISwordIntentTip : ICommonTipType
	{
		// Token: 0x0600EE95 RID: 61077 RVA: 0x0022FDD2 File Offset: 0x0022DFD2
		public static ISwordIntentTip Create(ISwordIntentTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordIntentTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x0600EE96 RID: 61078 RVA: 0x0022FDF1 File Offset: 0x0022DFF1
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x0400830E RID: 33550
		private ISwordIntentTip Instance;
	}
}
