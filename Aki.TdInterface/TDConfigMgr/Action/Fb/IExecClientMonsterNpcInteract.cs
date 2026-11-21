using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C2 RID: 10690
	public class IExecClientMonsterNpcInteract : ActionParams
	{
		// Token: 0x0600ECB4 RID: 60596 RVA: 0x0022D427 File Offset: 0x0022B627
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

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x0600ECB5 RID: 60597 RVA: 0x0022D446 File Offset: 0x0022B646
		public virtual int MonsterNpcEntityId
		{
			get
			{
				return this.Instance.MonsterNpcEntityId;
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x0600ECB6 RID: 60598 RVA: 0x0022D453 File Offset: 0x0022B653
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

		// Token: 0x0400824C RID: 33356
		private IExecClientMonsterNpcInteract Instance;

		// Token: 0x0400824D RID: 33357
		[Nullable(2)]
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x0400824E RID: 33358
		private bool _ConfigInited;
	}
}
