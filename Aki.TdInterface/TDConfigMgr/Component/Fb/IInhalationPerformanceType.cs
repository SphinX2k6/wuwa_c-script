using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E58 RID: 3672
	public class IInhalationPerformanceType
	{
		// Token: 0x06005314 RID: 21268 RVA: 0x000CD329 File Offset: 0x000CB529
		public static IInhalationPerformanceType Create(IInhalationPerformanceType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhalationPerformanceType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x000CD348 File Offset: 0x000CB548
		public virtual EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002F73 RID: 12147
		private IInhalationPerformanceType Instance;
	}
}
