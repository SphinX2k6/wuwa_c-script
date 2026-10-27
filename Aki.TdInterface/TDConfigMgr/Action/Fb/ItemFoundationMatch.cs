using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D5 RID: 9941
	public class ItemFoundationMatch : ActionParams
	{
		// Token: 0x0600DE31 RID: 56881 RVA: 0x0020F9CF File Offset: 0x0020DBCF
		[NullableContext(1)]
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

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x0600DE32 RID: 56882 RVA: 0x0020F9EE File Offset: 0x0020DBEE
		public virtual int MatchEntityId
		{
			get
			{
				return this.Instance.MatchEntityId;
			}
		}

		// Token: 0x04007B5D RID: 31581
		private IItemFoundationMatch Instance;
	}
}
