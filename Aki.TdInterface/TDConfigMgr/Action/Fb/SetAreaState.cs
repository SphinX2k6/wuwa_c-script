using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002932 RID: 10546
	public class SetAreaState : ActionParams
	{
		// Token: 0x0600EA69 RID: 60009 RVA: 0x00229715 File Offset: 0x00227915
		public static SetAreaState Create(ISetAreaState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAreaState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x0600EA6A RID: 60010 RVA: 0x00229734 File Offset: 0x00227934
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x00229741 File Offset: 0x00227941
		public virtual int State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04008134 RID: 33076
		private ISetAreaState Instance;
	}
}
