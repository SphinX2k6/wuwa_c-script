using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013F3 RID: 5107
	public class IRoleTowerConditionStepBattle : IRoleTowerConditionStepBase
	{
		// Token: 0x06007444 RID: 29764 RVA: 0x00116496 File Offset: 0x00114696
		[NullableContext(1)]
		public static IRoleTowerConditionStepBattle Create(IRoleTowerConditionStepBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007445 RID: 29765 RVA: 0x001164B5 File Offset: 0x001146B5
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004347 RID: 17223
		private IRoleTowerConditionStepBattle Instance;
	}
}
