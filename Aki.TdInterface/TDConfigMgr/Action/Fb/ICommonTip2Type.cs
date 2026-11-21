using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A34 RID: 10804
	public class ICommonTip2Type
	{
		// Token: 0x0600EEBB RID: 61115 RVA: 0x002300FB File Offset: 0x0022E2FB
		public static ICommonTip2Type Create(ICommonTip2Type? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x0600EEBC RID: 61116 RVA: 0x0023011A File Offset: 0x0022E31A
		public virtual ECommonTip2Type Type
		{
			get
			{
				return (ECommonTip2Type)this.Instance.Type;
			}
		}

		// Token: 0x0400831A RID: 33562
		private ICommonTip2Type Instance;
	}
}
