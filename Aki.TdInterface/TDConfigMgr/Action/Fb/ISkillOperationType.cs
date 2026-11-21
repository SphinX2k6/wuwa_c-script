using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C24 RID: 11300
	public class ISkillOperationType
	{
		// Token: 0x0600F8AB RID: 63659 RVA: 0x002423CF File Offset: 0x002405CF
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

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x0600F8AC RID: 63660 RVA: 0x002423EE File Offset: 0x002405EE
		public virtual ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008806 RID: 34822
		private ISkillOperationType Instance;
	}
}
