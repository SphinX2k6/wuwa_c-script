using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002943 RID: 10563
	public class IEnableSkillOperation : ISkillOperationType
	{
		// Token: 0x0600EA43 RID: 59971 RVA: 0x00224E23 File Offset: 0x00223023
		[NullableContext(1)]
		public static IEnableSkillOperation Create(IEnableSkillOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSkillOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x0600EA44 RID: 59972 RVA: 0x00224E42 File Offset: 0x00223042
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400812B RID: 33067
		private IEnableSkillOperation Instance;
	}
}
