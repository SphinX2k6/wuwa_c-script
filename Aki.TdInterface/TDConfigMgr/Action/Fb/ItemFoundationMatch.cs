using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002999 RID: 10649
	public class ItemFoundationMatch : ActionParams
	{
		// Token: 0x0600EC0D RID: 60429 RVA: 0x0022C20F File Offset: 0x0022A40F
		public static ItemFoundationMatch Create(IItemFoundationMatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundationMatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x0600EC0E RID: 60430 RVA: 0x0022C22E File Offset: 0x0022A42E
		public virtual int MatchEntityId
		{
			get
			{
				return this.Instance.MatchEntityId;
			}
		}

		// Token: 0x040081FD RID: 33277
		private IItemFoundationMatch Instance;
	}
}
