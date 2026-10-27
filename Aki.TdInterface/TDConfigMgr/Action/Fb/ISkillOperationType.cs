using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002942 RID: 10562
	public class ISkillOperationType
	{
		// Token: 0x0600EA40 RID: 59968 RVA: 0x00224DEF File Offset: 0x00222FEF
		[NullableContext(1)]
		public static ISkillOperationType Create(ISkillOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x00224E0E File Offset: 0x0022300E
		public virtual ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400812A RID: 33066
		private ISkillOperationType Instance;
	}
}
