using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298F RID: 10639
	public class ChangeSelfEntityState : ActionParams
	{
		// Token: 0x0600EBE7 RID: 60391 RVA: 0x0022BD72 File Offset: 0x00229F72
		public static ChangeSelfEntityState Create(IChangeSelfEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x0600EBE8 RID: 60392 RVA: 0x0022BD91 File Offset: 0x00229F91
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x040081E9 RID: 33257
		private IChangeSelfEntityState Instance;
	}
}
