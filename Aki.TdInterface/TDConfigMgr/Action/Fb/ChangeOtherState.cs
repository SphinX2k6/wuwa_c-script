using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286C RID: 10348
	public class ChangeOtherState : ActionParams
	{
		// Token: 0x0600E6C6 RID: 59078 RVA: 0x002227A0 File Offset: 0x002209A0
		public static ChangeOtherState Create(IChangeOtherState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x0600E6C7 RID: 59079 RVA: 0x002227BF File Offset: 0x002209BF
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x002227CC File Offset: 0x002209CC
		public virtual PlayFlow State
		{
			get
			{
				if (this._StateInited)
				{
					return this._StateCache;
				}
				this._StateInited = true;
				this._StateCache = PlayFlow.Create(this.Instance.State);
				return this._StateCache;
			}
		}

		// Token: 0x04007F1A RID: 32538
		private IChangeOtherState Instance;

		// Token: 0x04007F1B RID: 32539
		[Nullable(2)]
		private PlayFlow _StateCache;

		// Token: 0x04007F1C RID: 32540
		private bool _StateInited;
	}
}
