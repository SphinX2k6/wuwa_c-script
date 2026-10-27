using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE9 RID: 10985
	public class DrinksRollRoleRequirement : ActionParams
	{
		// Token: 0x0600F0C1 RID: 61633 RVA: 0x0022F202 File Offset: 0x0022D402
		[NullableContext(1)]
		public static DrinksRollRoleRequirement Create(IDrinksRollRoleRequirement? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DrinksRollRoleRequirement
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x0600F0C2 RID: 61634 RVA: 0x0022F221 File Offset: 0x0022D421
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x0600F0C3 RID: 61635 RVA: 0x0022F230 File Offset: 0x0022D430
		public virtual int? RequirementId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RequirementId);
			}
		}

		// Token: 0x04008475 RID: 33909
		private IDrinksRollRoleRequirement Instance;
	}
}
