using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BB RID: 9915
	public class ITelePortAfterTimeOut : ITeammateTeleportConfig
	{
		// Token: 0x0600DDCA RID: 56778 RVA: 0x0020EDF6 File Offset: 0x0020CFF6
		[NullableContext(1)]
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

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x0600DDCB RID: 56779 RVA: 0x0020EE15 File Offset: 0x0020D015
		public override ETeammateTeleportType Type
		{
			get
			{
				return (ETeammateTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x0600DDCC RID: 56780 RVA: 0x0020EE22 File Offset: 0x0020D022
		public virtual int TimeOut
		{
			get
			{
				return this.Instance.TimeOut;
			}
		}

		// Token: 0x04007B21 RID: 31521
		private ITelePortAfterTimeOut Instance;
	}
}
