using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FD RID: 9981
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteract : IExecClientBattleActionType
	{
		// Token: 0x0600DED0 RID: 57040 RVA: 0x00210B27 File Offset: 0x0020ED27
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

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x0600DED1 RID: 57041 RVA: 0x00210B46 File Offset: 0x0020ED46
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x0600DED2 RID: 57042 RVA: 0x00210B53 File Offset: 0x0020ED53
		public virtual int MonsterNpcEntityId
		{
			get
			{
				return this.Instance.MonsterNpcEntityId;
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0600DED3 RID: 57043 RVA: 0x00210B60 File Offset: 0x0020ED60
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

		// Token: 0x04007BAB RID: 31659
		private IMonsterNpcInteract Instance;

		// Token: 0x04007BAC RID: 31660
		[Nullable(2)]
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04007BAD RID: 31661
		private bool _ConfigInited;
	}
}
