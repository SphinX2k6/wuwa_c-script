using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200154D RID: 5453
	public class IRoleTowerConditionStepLoadSubLevel : IRoleTowerConditionStepBase
	{
		// Token: 0x06007B0E RID: 31502 RVA: 0x00124F16 File Offset: 0x00123116
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

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x06007B0F RID: 31503 RVA: 0x00124F35 File Offset: 0x00123135
		public override ERoleTowerConditionStep Type
		{
			get
			{
				return (ERoleTowerConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046DB RID: 18139
		private IRoleTowerConditionStepLoadSubLevel Instance;
	}
}
