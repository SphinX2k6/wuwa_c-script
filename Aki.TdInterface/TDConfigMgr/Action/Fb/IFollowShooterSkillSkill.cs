using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BA RID: 10682
	public class IFollowShooterSkillSkill : IExecClientBattleActionType
	{
		// Token: 0x0600EC93 RID: 60563 RVA: 0x0022D0EB File Offset: 0x0022B2EB
		public static IFollowShooterSkillSkill Create(IFollowShooterSkillSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterSkillSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x0600EC94 RID: 60564 RVA: 0x0022D10A File Offset: 0x0022B30A
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x0600EC95 RID: 60565 RVA: 0x0022D117 File Offset: 0x0022B317
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x0400823C RID: 33340
		private IFollowShooterSkillSkill Instance;
	}
}
