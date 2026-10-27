using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4D RID: 3149
	public class ILevelAiCycleLooply : ILevelAiCycleModeType
	{
		// Token: 0x06004815 RID: 18453 RVA: 0x000B547D File Offset: 0x000B367D
		[NullableContext(1)]
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

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x000B549C File Offset: 0x000B369C
		public override ELevelAiCycleMode Type
		{
			get
			{
				return (ELevelAiCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x000B54A9 File Offset: 0x000B36A9
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x04002908 RID: 10504
		private ILevelAiCycleLooply Instance;
	}
}
