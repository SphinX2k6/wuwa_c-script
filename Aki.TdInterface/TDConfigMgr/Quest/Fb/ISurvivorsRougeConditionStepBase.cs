using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013DE RID: 5086
	public class ISurvivorsRougeConditionStepBase
	{
		// Token: 0x060073FF RID: 29695 RVA: 0x00115F2E File Offset: 0x0011412E
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepBase Create(ISurvivorsRougeConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x00115F4D File Offset: 0x0011414D
		public virtual ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004326 RID: 17190
		private ISurvivorsRougeConditionStepBase Instance;
	}
}
