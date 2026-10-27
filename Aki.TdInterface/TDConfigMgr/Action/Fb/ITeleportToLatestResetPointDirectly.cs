using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002898 RID: 10392
	public class ITeleportToLatestResetPointDirectly : ITeleportToLatestResetPointType
	{
		// Token: 0x0600E61D RID: 58909 RVA: 0x0021D16D File Offset: 0x0021B36D
		[NullableContext(1)]
		public static ITeleportToLatestResetPointDirectly Create(ITeleportToLatestResetPointDirectly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointDirectly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x0600E61E RID: 58910 RVA: 0x0021D18C File Offset: 0x0021B38C
		public override ETeleportToLatestResetPointType Type
		{
			get
			{
				return (ETeleportToLatestResetPointType)this.Instance.Type;
			}
		}

		// Token: 0x04007F38 RID: 32568
		private ITeleportToLatestResetPointDirectly Instance;
	}
}
