using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A0 RID: 10144
	public class SetAreaTimeState : ActionParams
	{
		// Token: 0x0600E0B0 RID: 57520 RVA: 0x00210F98 File Offset: 0x0020F198
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

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600E0B1 RID: 57521 RVA: 0x00210FB7 File Offset: 0x0020F1B7
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

		// Token: 0x04007A30 RID: 31280
		private ISetAreaTimeState Instance;

		// Token: 0x04007A31 RID: 31281
		private ISetAreaTimeBase _SetAreaTimeConfigCache;

		// Token: 0x04007A32 RID: 31282
		private bool _SetAreaTimeConfigInited;
	}
}
