using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293D RID: 10557
	public class IBattleTeam : ITeamType
	{
		// Token: 0x0600EA91 RID: 60049 RVA: 0x00229B75 File Offset: 0x00227D75
		public static IBattleTeam Create(IBattleTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x0600EA92 RID: 60050 RVA: 0x00229B94 File Offset: 0x00227D94
		public override ETeamType Type
		{
			get
			{
				return (ETeamType)this.Instance.Type;
			}
		}

		// Token: 0x04008145 RID: 33093
		private IBattleTeam Instance;
	}
}
