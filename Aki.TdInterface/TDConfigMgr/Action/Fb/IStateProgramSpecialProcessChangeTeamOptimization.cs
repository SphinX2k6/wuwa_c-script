using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278A RID: 10122
	public class IStateProgramSpecialProcessChangeTeamOptimization : IStateProgramSpecialProcessBase
	{
		// Token: 0x0600E01F RID: 57375 RVA: 0x0020FC35 File Offset: 0x0020DE35
		public static IStateProgramSpecialProcessChangeTeamOptimization Create(IStateProgramSpecialProcessChangeTeamOptimization? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateProgramSpecialProcessChangeTeamOptimization
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600E020 RID: 57376 RVA: 0x0020FC54 File Offset: 0x0020DE54
		public override ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600E021 RID: 57377 RVA: 0x0020FC64 File Offset: 0x0020DE64
		public virtual bool? IsOpenBlackScreen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOpenBlackScreen);
			}
		}

		// Token: 0x040079EE RID: 31214
		private IStateProgramSpecialProcessChangeTeamOptimization Instance;
	}
}
