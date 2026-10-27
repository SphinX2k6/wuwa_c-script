using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E3 RID: 5091
	public class ISurvivorsRougeConditionStepChooseWeapon : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x0600740E RID: 29710 RVA: 0x00116032 File Offset: 0x00114232
		[NullableContext(1)]
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

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600740F RID: 29711 RVA: 0x00116051 File Offset: 0x00114251
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400432B RID: 17195
		private ISurvivorsRougeConditionStepChooseWeapon Instance;
	}
}
