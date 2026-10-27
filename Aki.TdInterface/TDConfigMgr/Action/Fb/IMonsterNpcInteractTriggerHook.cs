using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FB RID: 9979
	public class IMonsterNpcInteractTriggerHook : IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600DEC8 RID: 57032 RVA: 0x00210A7E File Offset: 0x0020EC7E
		[NullableContext(1)]
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

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0600DEC9 RID: 57033 RVA: 0x00210A9D File Offset: 0x0020EC9D
		public override EMonsterNpcInteractType Type
		{
			get
			{
				return (EMonsterNpcInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x0600DECA RID: 57034 RVA: 0x00210AAA File Offset: 0x0020ECAA
		public virtual int HookEntityId
		{
			get
			{
				return this.Instance.HookEntityId;
			}
		}

		// Token: 0x04007BA7 RID: 31655
		private IMonsterNpcInteractTriggerHook Instance;
	}
}
