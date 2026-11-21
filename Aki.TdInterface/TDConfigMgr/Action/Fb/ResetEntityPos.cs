using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002780 RID: 10112
	public class ResetEntityPos : ActionParams
	{
		// Token: 0x0600E003 RID: 57347 RVA: 0x0020F910 File Offset: 0x0020DB10
		public static ResetEntityPos Create(IResetEntityPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntityPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x0020F92F File Offset: 0x0020DB2F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040079DC RID: 31196
		private IResetEntityPos Instance;
	}
}
