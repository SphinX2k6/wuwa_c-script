using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EDC RID: 3804
	public class ITimeScheduleGenerateParams
	{
		// Token: 0x060055AD RID: 21933 RVA: 0x000D26B1 File Offset: 0x000D08B1
		public static ITimeScheduleGenerateParams Create(ITimeScheduleGenerateParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGenerateParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x000D26D0 File Offset: 0x000D08D0
		public virtual ETimeScheduleGenerateType Type
		{
			get
			{
				return (ETimeScheduleGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x04003103 RID: 12547
		private ITimeScheduleGenerateParams Instance;
	}
}
