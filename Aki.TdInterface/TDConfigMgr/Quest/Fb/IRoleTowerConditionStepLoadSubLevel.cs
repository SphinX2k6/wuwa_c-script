using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F6 RID: 5110
	public class IRoleTowerConditionStepLoadSubLevel : IRoleTowerConditionStepBase
	{
		// Token: 0x0600744D RID: 29773 RVA: 0x00116532 File Offset: 0x00114732
		[NullableContext(1)]
		public static IRoleTowerConditionStepLoadSubLevel Create(IRoleTowerConditionStepLoadSubLevel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepLoadSubLevel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x00116551 File Offset: 0x00114751
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400434A RID: 17226
		private IRoleTowerConditionStepLoadSubLevel Instance;
	}
}
