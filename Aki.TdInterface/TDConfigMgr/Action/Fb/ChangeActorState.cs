using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286B RID: 10347
	public class ChangeActorState : ActionParams
	{
		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0022276C File Offset: 0x0022096C
		public static ChangeActorState Create(IChangeActorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeActorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x0022278B File Offset: 0x0022098B
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04007F19 RID: 32537
		private IChangeActorState Instance;
	}
}
