using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C32 RID: 11314
	public class IUiOperationType
	{
		// Token: 0x0600F8EE RID: 63726 RVA: 0x00242CEA File Offset: 0x00240EEA
		public static IUiOperationType Create(IUiOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x0600F8EF RID: 63727 RVA: 0x00242D09 File Offset: 0x00240F09
		public virtual EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400881C RID: 34844
		private IUiOperationType Instance;
	}
}
