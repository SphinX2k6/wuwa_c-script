using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E1 RID: 5089
	public class ISurvivorsRougeConditionStepEnd : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007408 RID: 29704 RVA: 0x00115FCA File Offset: 0x001141CA
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepEnd Create(ISurvivorsRougeConditionStepEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007409 RID: 29705 RVA: 0x00115FE9 File Offset: 0x001141E9
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004329 RID: 17193
		private ISurvivorsRougeConditionStepEnd Instance;
	}
}
