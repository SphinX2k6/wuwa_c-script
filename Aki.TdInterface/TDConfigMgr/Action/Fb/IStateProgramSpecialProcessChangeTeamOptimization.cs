using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E5 RID: 9445
	public class IStateProgramSpecialProcessChangeTeamOptimization : IStateProgramSpecialProcessBase
	{
		// Token: 0x0600D2CA RID: 53962 RVA: 0x001F43D9 File Offset: 0x001F25D9
		[NullableContext(1)]
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

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600D2CB RID: 53963 RVA: 0x001F43F8 File Offset: 0x001F25F8
		public override ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x001F4408 File Offset: 0x001F2608
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

		// Token: 0x040073A1 RID: 29601
		private IStateProgramSpecialProcessChangeTeamOptimization Instance;
	}
}
