using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A92 RID: 10898
	public class IChangeTimerType
	{
		// Token: 0x0600F076 RID: 61558 RVA: 0x00233C09 File Offset: 0x00231E09
		public static IChangeTimerType Create(IChangeTimerType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x0600F077 RID: 61559 RVA: 0x00233C28 File Offset: 0x00231E28
		public virtual EChangeTimerType Type
		{
			get
			{
				return (EChangeTimerType)this.Instance.Type;
			}
		}

		// Token: 0x04008438 RID: 33848
		private IChangeTimerType Instance;
	}
}
