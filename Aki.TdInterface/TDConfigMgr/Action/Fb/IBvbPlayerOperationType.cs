using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D0E RID: 11534
	public class IBvbPlayerOperationType
	{
		// Token: 0x0600FC4B RID: 64587 RVA: 0x00247CFD File Offset: 0x00245EFD
		public static IBvbPlayerOperationType Create(IBvbPlayerOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x0600FC4C RID: 64588 RVA: 0x00247D1C File Offset: 0x00245F1C
		public virtual EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040089CA RID: 35274
		private IBvbPlayerOperationType Instance;
	}
}
