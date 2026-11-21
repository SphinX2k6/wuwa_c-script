using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3E RID: 11582
	public class ReignsChangePlayerName : ActionParams
	{
		// Token: 0x0600FCFE RID: 64766 RVA: 0x00248E5B File Offset: 0x0024705B
		public static ReignsChangePlayerName Create(IReignsChangePlayerName? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x0600FCFF RID: 64767 RVA: 0x00248E7A File Offset: 0x0024707A
		public virtual string PlayerNameId
		{
			get
			{
				return this.Instance.PlayerNameId;
			}
		}

		// Token: 0x04008A20 RID: 35360
		private IReignsChangePlayerName Instance;
	}
}
