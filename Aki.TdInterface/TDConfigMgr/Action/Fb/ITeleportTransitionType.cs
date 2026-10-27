using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268D RID: 9869
	public class ITeleportTransitionType
	{
		// Token: 0x0600DCFA RID: 56570 RVA: 0x0020D971 File Offset: 0x0020BB71
		[NullableContext(1)]
		public static ITeleportTransitionType Create(ITeleportTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x0600DCFB RID: 56571 RVA: 0x0020D990 File Offset: 0x0020BB90
		public virtual ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04007AC3 RID: 31427
		private ITeleportTransitionType Instance;
	}
}
