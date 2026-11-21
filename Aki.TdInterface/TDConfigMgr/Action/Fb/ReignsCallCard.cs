using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3F RID: 11583
	public class ReignsCallCard : ActionParams
	{
		// Token: 0x0600FD01 RID: 64769 RVA: 0x00248E8F File Offset: 0x0024708F
		public static ReignsCallCard Create(IReignsCallCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCallCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x0600FD02 RID: 64770 RVA: 0x00248EAE File Offset: 0x002470AE
		public virtual int CardId
		{
			get
			{
				return this.Instance.CardId;
			}
		}

		// Token: 0x04008A21 RID: 35361
		private IReignsCallCard Instance;
	}
}
