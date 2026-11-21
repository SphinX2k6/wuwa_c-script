using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D25 RID: 3365
	public class ILevelAiCycleModeType
	{
		// Token: 0x06004C97 RID: 19607 RVA: 0x000BFA3D File Offset: 0x000BDC3D
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

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x000BFA5C File Offset: 0x000BDC5C
		public virtual ELevelAiCycleMode Type
		{
			get
			{
				return (ELevelAiCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x04002B68 RID: 11112
		private ILevelAiCycleModeType Instance;
	}
}
