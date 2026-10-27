using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E5 RID: 5093
	public class ISurvivorsRougeConditionStepShopping : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007414 RID: 29716 RVA: 0x0011609A File Offset: 0x0011429A
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepShopping Create(ISurvivorsRougeConditionStepShopping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepShopping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06007415 RID: 29717 RVA: 0x001160B9 File Offset: 0x001142B9
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400432D RID: 17197
		private ISurvivorsRougeConditionStepShopping Instance;
	}
}
