using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293E RID: 10558
	public class IFlowTeam : ITeamType
	{
		// Token: 0x0600EA94 RID: 60052 RVA: 0x00229BA9 File Offset: 0x00227DA9
		public static IFlowTeam Create(IFlowTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x00229BC8 File Offset: 0x00227DC8
		public override ETeamType Type
		{
			get
			{
				return (ETeamType)this.Instance.Type;
			}
		}

		// Token: 0x04008146 RID: 33094
		private IFlowTeam Instance;
	}
}
