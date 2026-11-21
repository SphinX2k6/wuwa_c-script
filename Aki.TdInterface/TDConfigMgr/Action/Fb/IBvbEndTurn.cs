using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D18 RID: 11544
	public class IBvbEndTurn : IBvbPlayerOperationType
	{
		// Token: 0x0600FC77 RID: 64631 RVA: 0x00248395 File Offset: 0x00246595
		public static IBvbEndTurn Create(IBvbEndTurn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x0600FC78 RID: 64632 RVA: 0x002483B4 File Offset: 0x002465B4
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040089E0 RID: 35296
		private IBvbEndTurn Instance;
	}
}
