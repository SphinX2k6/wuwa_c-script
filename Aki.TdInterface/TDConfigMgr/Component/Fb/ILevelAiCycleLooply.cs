using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D26 RID: 3366
	public class ILevelAiCycleLooply : ILevelAiCycleModeType
	{
		// Token: 0x06004C9A RID: 19610 RVA: 0x000BFA71 File Offset: 0x000BDC71
		public static ILevelAiCycleLooply Create(ILevelAiCycleLooply? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAiCycleLooply
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004C9B RID: 19611 RVA: 0x000BFA90 File Offset: 0x000BDC90
		public override ELevelAiCycleMode Type
		{
			get
			{
				return (ELevelAiCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x000BFA9D File Offset: 0x000BDC9D
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x04002B69 RID: 11113
		private ILevelAiCycleLooply Instance;
	}
}
