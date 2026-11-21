using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200153A RID: 5434
	public class ISurvivorsRougeConditionStepChooseWeapon : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007ACF RID: 31439 RVA: 0x00124A16 File Offset: 0x00122C16
		public static ISurvivorsRougeConditionStepChooseWeapon Create(ISurvivorsRougeConditionStepChooseWeapon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepChooseWeapon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x06007AD0 RID: 31440 RVA: 0x00124A35 File Offset: 0x00122C35
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046BC RID: 18108
		private ISurvivorsRougeConditionStepChooseWeapon Instance;
	}
}
