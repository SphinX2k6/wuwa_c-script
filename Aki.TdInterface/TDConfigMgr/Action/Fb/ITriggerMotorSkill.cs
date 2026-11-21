using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B9 RID: 10681
	public class ITriggerMotorSkill : IExecClientBattleActionType
	{
		// Token: 0x0600EC8F RID: 60559 RVA: 0x0022D0AA File Offset: 0x0022B2AA
		public static ITriggerMotorSkill Create(ITriggerMotorSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerMotorSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x0022D0C9 File Offset: 0x0022B2C9
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x0022D0D6 File Offset: 0x0022B2D6
		public virtual int MotorSkillId
		{
			get
			{
				return this.Instance.MotorSkillId;
			}
		}

		// Token: 0x0400823B RID: 33339
		private ITriggerMotorSkill Instance;
	}
}
