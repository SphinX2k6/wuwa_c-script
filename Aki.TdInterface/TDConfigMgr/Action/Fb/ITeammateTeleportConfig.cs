using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BA RID: 9914
	public class ITeammateTeleportConfig
	{
		// Token: 0x0600DDC7 RID: 56775 RVA: 0x0020EDC2 File Offset: 0x0020CFC2
		[NullableContext(1)]
		public static ITeammateTeleportConfig Create(ITeammateTeleportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeammateTeleportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x0600DDC8 RID: 56776 RVA: 0x0020EDE1 File Offset: 0x0020CFE1
		public virtual ETeammateTeleportType Type
		{
			get
			{
				return (ETeammateTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x04007B20 RID: 31520
		private ITeammateTeleportConfig Instance;
	}
}
