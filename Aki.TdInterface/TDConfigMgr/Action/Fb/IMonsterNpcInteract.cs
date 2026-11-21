using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C3 RID: 10691
	public class IMonsterNpcInteract : IExecClientBattleActionType
	{
		// Token: 0x0600ECB8 RID: 60600 RVA: 0x0022D48F File Offset: 0x0022B68F
		public static IMonsterNpcInteract Create(IMonsterNpcInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x0600ECB9 RID: 60601 RVA: 0x0022D4AE File Offset: 0x0022B6AE
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x0600ECBA RID: 60602 RVA: 0x0022D4BB File Offset: 0x0022B6BB
		public virtual int MonsterNpcEntityId
		{
			get
			{
				return this.Instance.MonsterNpcEntityId;
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x0022D4C8 File Offset: 0x0022B6C8
		public virtual IMonsterNpcInteractTriggerHook Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IMonsterNpcInteractTriggerHook.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400824F RID: 33359
		private IMonsterNpcInteract Instance;

		// Token: 0x04008250 RID: 33360
		[Nullable(2)]
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04008251 RID: 33361
		private bool _ConfigInited;
	}
}
