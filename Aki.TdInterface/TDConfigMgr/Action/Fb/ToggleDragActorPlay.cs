using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AB RID: 10155
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleDragActorPlay : ActionParams
	{
		// Token: 0x0600E1F2 RID: 57842 RVA: 0x00215FBF File Offset: 0x002141BF
		public static ToggleDragActorPlay Create(IToggleDragActorPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleDragActorPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x0600E1F3 RID: 57843 RVA: 0x00215FDE File Offset: 0x002141DE
		public virtual IToggleDragActorPlayType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadToggleDragActorPlay_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04007D49 RID: 32073
		private IToggleDragActorPlay Instance;

		// Token: 0x04007D4A RID: 32074
		private IToggleDragActorPlayType _ConfigCache;

		// Token: 0x04007D4B RID: 32075
		private bool _ConfigInited;
	}
}
