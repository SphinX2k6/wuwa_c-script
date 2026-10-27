using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F3 RID: 9971
	public class ITriggerMotorSkill : IExecClientBattleActionType
	{
		// Token: 0x0600DEA7 RID: 56999 RVA: 0x00210742 File Offset: 0x0020E942
		[NullableContext(1)]
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

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x0600DEA8 RID: 57000 RVA: 0x00210761 File Offset: 0x0020E961
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x0021076E File Offset: 0x0020E96E
		public virtual int MotorSkillId
		{
			get
			{
				return this.Instance.MotorSkillId;
			}
		}

		// Token: 0x04007B97 RID: 31639
		private ITriggerMotorSkill Instance;
	}
}
