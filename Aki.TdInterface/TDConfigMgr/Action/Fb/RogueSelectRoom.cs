using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C8 RID: 9928
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueSelectRoom : ActionParams
	{
		// Token: 0x0600DE03 RID: 56835 RVA: 0x0020F451 File Offset: 0x0020D651
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

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x0600DE04 RID: 56836 RVA: 0x0020F470 File Offset: 0x0020D670
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

		// Token: 0x04007B44 RID: 31556
		private IRogueSelectRoom Instance;

		// Token: 0x04007B45 RID: 31557
		[Nullable(2)]
		private IRogueRoleSelectRoom _ConfigCache;

		// Token: 0x04007B46 RID: 31558
		private bool _ConfigInited;
	}
}
