using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C82 RID: 11394
	public class IClientFollowShooterPlaySkill : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA39 RID: 64057 RVA: 0x00244E67 File Offset: 0x00243067
		public static IClientFollowShooterPlaySkill Create(IClientFollowShooterPlaySkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlaySkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x0600FA3A RID: 64058 RVA: 0x00244E86 File Offset: 0x00243086
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x0600FA3B RID: 64059 RVA: 0x00244E93 File Offset: 0x00243093
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x040088B4 RID: 34996
		private IClientFollowShooterPlaySkill Instance;
	}
}
