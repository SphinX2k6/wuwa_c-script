using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6C RID: 11116
	public class ITeleportToLatestResetPointType
	{
		// Token: 0x0600F449 RID: 62537 RVA: 0x0023A0B9 File Offset: 0x002382B9
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

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x0600F44A RID: 62538 RVA: 0x0023A0D8 File Offset: 0x002382D8
		public virtual ETeleportToLatestResetPointType Type
		{
			get
			{
				return (ETeleportToLatestResetPointType)this.Instance.Type;
			}
		}

		// Token: 0x040085F6 RID: 34294
		private ITeleportToLatestResetPointType Instance;
	}
}
