using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293B RID: 10555
	public class ITeamType
	{
		// Token: 0x0600EA8B RID: 60043 RVA: 0x00229B0D File Offset: 0x00227D0D
		public static ITeamType Create(ITeamType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeamType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x0600EA8C RID: 60044 RVA: 0x00229B2C File Offset: 0x00227D2C
		public virtual ETeamType Type
		{
			get
			{
				return (ETeamType)this.Instance.Type;
			}
		}

		// Token: 0x04008143 RID: 33091
		private ITeamType Instance;
	}
}
