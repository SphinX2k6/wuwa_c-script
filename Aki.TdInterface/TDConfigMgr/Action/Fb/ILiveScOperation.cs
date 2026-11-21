using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2A RID: 11818
	public class ILiveScOperation
	{
		// Token: 0x0601009E RID: 65694 RVA: 0x0024E835 File Offset: 0x0024CA35
		public static ILiveScOperation Create(ILiveScOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveScOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x0601009F RID: 65695 RVA: 0x0024E854 File Offset: 0x0024CA54
		public virtual ELiveScOperationType Type
		{
			get
			{
				return (ELiveScOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008BFA RID: 35834
		private ILiveScOperation Instance;
	}
}
