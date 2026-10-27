using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F2 RID: 9970
	public class ITriggerHookPointSkill : IExecClientBattleActionType
	{
		// Token: 0x0600DEA2 RID: 56994 RVA: 0x002106C8 File Offset: 0x0020E8C8
		[NullableContext(1)]
		public static ITriggerHookPointSkill Create(ITriggerHookPointSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerHookPointSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0600DEA3 RID: 56995 RVA: 0x002106E7 File Offset: 0x0020E8E7
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0600DEA4 RID: 56996 RVA: 0x002106F4 File Offset: 0x0020E8F4
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0600DEA5 RID: 56997 RVA: 0x00210704 File Offset: 0x0020E904
		public virtual EHookTriggerType? SpecTriggerType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EHookTriggerType?((EHookTriggerType)this.Instance.SpecTriggerType);
			}
		}

		// Token: 0x04007B96 RID: 31638
		private ITriggerHookPointSkill Instance;
	}
}
