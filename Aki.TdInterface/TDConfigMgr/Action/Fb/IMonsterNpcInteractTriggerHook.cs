using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C1 RID: 10689
	public class IMonsterNpcInteractTriggerHook : IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600ECB0 RID: 60592 RVA: 0x0022D3E6 File Offset: 0x0022B5E6
		public static IMonsterNpcInteractTriggerHook Create(IMonsterNpcInteractTriggerHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractTriggerHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x0022D405 File Offset: 0x0022B605
		public override EMonsterNpcInteractType Type
		{
			get
			{
				return (EMonsterNpcInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x0600ECB2 RID: 60594 RVA: 0x0022D412 File Offset: 0x0022B612
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x0400824B RID: 33355
		private IMonsterNpcInteractTriggerHook Instance;
	}
}
