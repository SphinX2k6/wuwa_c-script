using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B8 RID: 10680
	public class ITriggerHookPointSkill : IExecClientBattleActionType
	{
		// Token: 0x0600EC89 RID: 60553 RVA: 0x0022CFFC File Offset: 0x0022B1FC
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

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x0600EC8A RID: 60554 RVA: 0x0022D01B File Offset: 0x0022B21B
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x0600EC8B RID: 60555 RVA: 0x0022D028 File Offset: 0x0022B228
		public virtual int? AssistCharacterId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AssistCharacterId);
			}
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x0600EC8C RID: 60556 RVA: 0x0022D05E File Offset: 0x0022B25E
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x0022D06C File Offset: 0x0022B26C
		public virtual EHookTriggerType? SpecTriggerType
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EHookTriggerType?((EHookTriggerType)this.Instance.SpecTriggerType);
			}
		}

		// Token: 0x0400823A RID: 33338
		private ITriggerHookPointSkill Instance;
	}
}
