using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FC RID: 9980
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecClientMonsterNpcInteract : ActionParams
	{
		// Token: 0x0600DECC RID: 57036 RVA: 0x00210ABF File Offset: 0x0020ECBF
		public static IExecClientMonsterNpcInteract Create(IExecClientMonsterNpcInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecClientMonsterNpcInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0600DECD RID: 57037 RVA: 0x00210ADE File Offset: 0x0020ECDE
		public virtual int MonsterNpcEntityId
		{
			get
			{
				return this.Instance.MonsterNpcEntityId;
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x0600DECE RID: 57038 RVA: 0x00210AEB File Offset: 0x0020ECEB
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

		// Token: 0x04007BA8 RID: 31656
		private IExecClientMonsterNpcInteract Instance;

		// Token: 0x04007BA9 RID: 31657
		[Nullable(2)]
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04007BAA RID: 31658
		private bool _ConfigInited;
	}
}
