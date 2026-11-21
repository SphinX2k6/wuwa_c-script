using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002940 RID: 10560
	public class ClientChangeTeamPosition : ActionParams
	{
		// Token: 0x0600EA9B RID: 60059 RVA: 0x00229C40 File Offset: 0x00227E40
		public static ClientChangeTeamPosition Create(IClientChangeTeamPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientChangeTeamPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x0600EA9C RID: 60060 RVA: 0x00229C5F File Offset: 0x00227E5F
		public virtual int PositionId
		{
			get
			{
				return this.Instance.PositionId;
			}
		}

		// Token: 0x0400814A RID: 33098
		private IClientChangeTeamPosition Instance;
	}
}
