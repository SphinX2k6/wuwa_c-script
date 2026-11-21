using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C25 RID: 11301
	public class IEnableSkillOperation : ISkillOperationType
	{
		// Token: 0x0600F8AE RID: 63662 RVA: 0x00242403 File Offset: 0x00240603
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

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x0600F8AF RID: 63663 RVA: 0x00242422 File Offset: 0x00240622
		public override ESkillOperationType Type
		{
			get
			{
				return (ESkillOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008807 RID: 34823
		private IEnableSkillOperation Instance;
	}
}
