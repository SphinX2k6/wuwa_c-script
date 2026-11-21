using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C0 RID: 10432
	public class SyncVarToActorState : ActionParams
	{
		// Token: 0x0600E853 RID: 59475 RVA: 0x002256CB File Offset: 0x002238CB
		public static SyncVarToActorState Create(ISyncVarToActorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SyncVarToActorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x0600E854 RID: 59476 RVA: 0x002256EA File Offset: 0x002238EA
		public virtual string VarName
		{
			get
			{
				return this.Instance.VarName;
			}
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x0600E855 RID: 59477 RVA: 0x002256F7 File Offset: 0x002238F7
		public virtual string StateKey
		{
			get
			{
				return this.Instance.StateKey;
			}
		}

		// Token: 0x04007FF4 RID: 32756
		private ISyncVarToActorState Instance;
	}
}
