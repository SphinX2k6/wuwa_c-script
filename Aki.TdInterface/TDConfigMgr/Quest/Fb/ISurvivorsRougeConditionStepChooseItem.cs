using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200153B RID: 5435
	public class ISurvivorsRougeConditionStepChooseItem : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007AD2 RID: 31442 RVA: 0x00124A4A File Offset: 0x00122C4A
		public static ISurvivorsRougeConditionStepChooseItem Create(ISurvivorsRougeConditionStepChooseItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06007AD3 RID: 31443 RVA: 0x00124A69 File Offset: 0x00122C69
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046BD RID: 18109
		private ISurvivorsRougeConditionStepChooseItem Instance;
	}
}
