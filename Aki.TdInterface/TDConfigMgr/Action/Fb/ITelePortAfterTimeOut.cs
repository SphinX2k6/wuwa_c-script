using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297E RID: 10622
	public class ITelePortAfterTimeOut : ITeammateTeleportConfig
	{
		// Token: 0x0600EBA1 RID: 60321 RVA: 0x0022B596 File Offset: 0x00229796
		public static ITelePortAfterTimeOut Create(ITelePortAfterTimeOut? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITelePortAfterTimeOut
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x0600EBA2 RID: 60322 RVA: 0x0022B5B5 File Offset: 0x002297B5
		public override ETeammateTeleportType Type
		{
			get
			{
				return (ETeammateTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x0600EBA3 RID: 60323 RVA: 0x0022B5C2 File Offset: 0x002297C2
		public virtual int TimeOut
		{
			get
			{
				return this.Instance.TimeOut;
			}
		}

		// Token: 0x040081BE RID: 33214
		private ITelePortAfterTimeOut Instance;
	}
}
