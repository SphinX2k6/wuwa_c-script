using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4C RID: 3148
	public class ILevelAiCycleModeType
	{
		// Token: 0x06004812 RID: 18450 RVA: 0x000B5449 File Offset: 0x000B3649
		[NullableContext(1)]
		public static ILevelAiCycleModeType Create(ILevelAiCycleModeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAiCycleModeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x000B5468 File Offset: 0x000B3668
		public virtual ELevelAiCycleMode Type
		{
			get
			{
				return (ELevelAiCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x04002907 RID: 10503
		private ILevelAiCycleModeType Instance;
	}
}
