using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E4 RID: 5092
	public class ISurvivorsRougeConditionStepChooseItem : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007411 RID: 29713 RVA: 0x00116066 File Offset: 0x00114266
		[NullableContext(1)]
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

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x00116085 File Offset: 0x00114285
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400432C RID: 17196
		private ISurvivorsRougeConditionStepChooseItem Instance;
	}
}
