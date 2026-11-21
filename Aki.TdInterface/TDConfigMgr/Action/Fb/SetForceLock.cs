using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002931 RID: 10545
	public class SetForceLock : ActionParams
	{
		// Token: 0x0600EA65 RID: 60005 RVA: 0x002296D4 File Offset: 0x002278D4
		public static SetForceLock Create(ISetForceLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetForceLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x002296F3 File Offset: 0x002278F3
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x00229700 File Offset: 0x00227900
		public virtual bool IsLocked
		{
			get
			{
				return this.Instance.IsLocked;
			}
		}

		// Token: 0x04008133 RID: 33075
		private ISetForceLock Instance;
	}
}
