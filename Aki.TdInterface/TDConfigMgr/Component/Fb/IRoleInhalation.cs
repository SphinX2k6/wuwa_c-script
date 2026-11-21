using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E59 RID: 3673
	public class IRoleInhalation : IInhalationPerformanceType
	{
		// Token: 0x06005317 RID: 21271 RVA: 0x000CD35D File Offset: 0x000CB55D
		public static IRoleInhalation Create(IRoleInhalation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleInhalation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x000CD37C File Offset: 0x000CB57C
		public override EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002F74 RID: 12148
		private IRoleInhalation Instance;
	}
}
