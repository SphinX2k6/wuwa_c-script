using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002897 RID: 10391
	public class ITeleportToLatestResetPointType
	{
		// Token: 0x0600E61A RID: 58906 RVA: 0x0021D139 File Offset: 0x0021B339
		[NullableContext(1)]
		public static ITeleportToLatestResetPointType Create(ITeleportToLatestResetPointType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x0600E61B RID: 58907 RVA: 0x0021D158 File Offset: 0x0021B358
		public virtual ETeleportToLatestResetPointType Type
		{
			get
			{
				return (ETeleportToLatestResetPointType)this.Instance.Type;
			}
		}

		// Token: 0x04007F37 RID: 32567
		private ITeleportToLatestResetPointType Instance;
	}
}
