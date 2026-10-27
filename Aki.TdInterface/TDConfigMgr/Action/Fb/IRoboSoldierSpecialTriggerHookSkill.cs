using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FE RID: 9982
	public class IRoboSoldierSpecialTriggerHookSkill : IExecClientBattleActionType
	{
		// Token: 0x0600DED5 RID: 57045 RVA: 0x00210B9C File Offset: 0x0020ED9C
		[NullableContext(1)]
		public static IRoboSoldierSpecialTriggerHookSkill Create(IRoboSoldierSpecialTriggerHookSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoboSoldierSpecialTriggerHookSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x00210BBB File Offset: 0x0020EDBB
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x00210BC8 File Offset: 0x0020EDC8
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x04007BAE RID: 31662
		private IRoboSoldierSpecialTriggerHookSkill Instance;
	}
}
