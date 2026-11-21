using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C4 RID: 10692
	public class IRoboSoldierSpecialTriggerHookSkill : IExecClientBattleActionType
	{
		// Token: 0x0600ECBD RID: 60605 RVA: 0x0022D504 File Offset: 0x0022B704
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

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x0600ECBE RID: 60606 RVA: 0x0022D523 File Offset: 0x0022B723
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x0600ECBF RID: 60607 RVA: 0x0022D530 File Offset: 0x0022B730
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x04008252 RID: 33362
		private IRoboSoldierSpecialTriggerHookSkill Instance;
	}
}
