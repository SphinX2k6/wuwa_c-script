using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FA RID: 9466
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAreaTimeState : ActionParams
	{
		// Token: 0x0600D354 RID: 54100 RVA: 0x001F55A0 File Offset: 0x001F37A0
		public static SetAreaTimeState Create(ISetAreaTimeState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAreaTimeState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600D355 RID: 54101 RVA: 0x001F55BF File Offset: 0x001F37BF
		public virtual ISetAreaTimeBase SetAreaTimeConfig
		{
			get
			{
				if (this._SetAreaTimeConfigInited)
				{
					return this._SetAreaTimeConfigCache;
				}
				this._SetAreaTimeConfigInited = true;
				this._SetAreaTimeConfigCache = ActionReadHelper.ReadSetAreaTimeState_SetAreaTimeConfig(this.Instance);
				return this._SetAreaTimeConfigCache;
			}
		}

		// Token: 0x040073DE RID: 29662
		private ISetAreaTimeState Instance;

		// Token: 0x040073DF RID: 29663
		private ISetAreaTimeBase _SetAreaTimeConfigCache;

		// Token: 0x040073E0 RID: 29664
		private bool _SetAreaTimeConfigInited;
	}
}
