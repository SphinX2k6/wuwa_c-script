using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A37 RID: 10807
	public class EndCommonTip : ActionParams
	{
		// Token: 0x0600EEC9 RID: 61129 RVA: 0x00230249 File Offset: 0x0022E449
		public static EndCommonTip Create(IEndCommonTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x0600EECA RID: 61130 RVA: 0x00230268 File Offset: 0x0022E468
		public virtual string Token
		{
			get
			{
				return this.Instance.Token;
			}
		}

		// Token: 0x0400831F RID: 33567
		private IEndCommonTip Instance;
	}
}
