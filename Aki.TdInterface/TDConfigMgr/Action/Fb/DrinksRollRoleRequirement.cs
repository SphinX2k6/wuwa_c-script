using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDD RID: 11741
	public class DrinksRollRoleRequirement : ActionParams
	{
		// Token: 0x0600FF77 RID: 65399 RVA: 0x0024CF0E File Offset: 0x0024B10E
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

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x0600FF78 RID: 65400 RVA: 0x0024CF2D File Offset: 0x0024B12D
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x0600FF79 RID: 65401 RVA: 0x0024CF3C File Offset: 0x0024B13C
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

		// Token: 0x04008B79 RID: 35705
		private IDrinksRollRoleRequirement Instance;
	}
}
