using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002784 RID: 10116
	public class FixFoundationRelation : ActionParams
	{
		// Token: 0x0600E00E RID: 57358 RVA: 0x0020F9FA File Offset: 0x0020DBFA
		public static FixFoundationRelation Create(IFixFoundationRelation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixFoundationRelation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079E2 RID: 31202
		private IFixFoundationRelation Instance;
	}
}
