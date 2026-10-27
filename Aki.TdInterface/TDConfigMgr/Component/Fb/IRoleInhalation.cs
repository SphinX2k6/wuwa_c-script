using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5F RID: 3423
	public class IRoleInhalation : IInhalationPerformanceType
	{
		// Token: 0x06004DFB RID: 19963 RVA: 0x000C1C19 File Offset: 0x000BFE19
		[NullableContext(1)]
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

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x000C1C38 File Offset: 0x000BFE38
		public override EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002CB4 RID: 11444
		private IRoleInhalation Instance;
	}
}
