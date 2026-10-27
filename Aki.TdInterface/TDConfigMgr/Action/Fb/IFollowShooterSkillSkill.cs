using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F4 RID: 9972
	public class IFollowShooterSkillSkill : IExecClientBattleActionType
	{
		// Token: 0x0600DEAB RID: 57003 RVA: 0x00210783 File Offset: 0x0020E983
		[NullableContext(1)]
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

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x0600DEAC RID: 57004 RVA: 0x002107A2 File Offset: 0x0020E9A2
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x0600DEAD RID: 57005 RVA: 0x002107AF File Offset: 0x0020E9AF
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x04007B98 RID: 31640
		private IFollowShooterSkillSkill Instance;
	}
}
