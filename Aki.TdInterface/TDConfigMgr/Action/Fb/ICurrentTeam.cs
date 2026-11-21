using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293C RID: 10556
	public class ICurrentTeam : ITeamType
	{
		// Token: 0x0600EA8E RID: 60046 RVA: 0x00229B41 File Offset: 0x00227D41
		public static ICurrentTeam Create(ICurrentTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurrentTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x00229B60 File Offset: 0x00227D60
		public override ETeamType Type
		{
			get
			{
				return (ETeamType)this.Instance.Type;
			}
		}

		// Token: 0x04008144 RID: 33092
		private ICurrentTeam Instance;
	}
}
