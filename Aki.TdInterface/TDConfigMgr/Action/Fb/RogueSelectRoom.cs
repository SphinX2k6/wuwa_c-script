using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298C RID: 10636
	public class RogueSelectRoom : ActionParams
	{
		// Token: 0x0600EBDF RID: 60383 RVA: 0x0022BC91 File Offset: 0x00229E91
		public static RogueSelectRoom Create(IRogueSelectRoom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueSelectRoom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x0600EBE0 RID: 60384 RVA: 0x0022BCB0 File Offset: 0x00229EB0
		public virtual IRogueRoleSelectRoom Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IRogueRoleSelectRoom.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x040081E4 RID: 33252
		private IRogueSelectRoom Instance;

		// Token: 0x040081E5 RID: 33253
		[Nullable(2)]
		private IRogueRoleSelectRoom _ConfigCache;

		// Token: 0x040081E6 RID: 33254
		private bool _ConfigInited;
	}
}
