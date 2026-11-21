using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6D RID: 11117
	public class ITeleportToLatestResetPointDirectly : ITeleportToLatestResetPointType
	{
		// Token: 0x0600F44C RID: 62540 RVA: 0x0023A0ED File Offset: 0x002382ED
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

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x0600F44D RID: 62541 RVA: 0x0023A10C File Offset: 0x0023830C
		public override ETeleportToLatestResetPointType Type
		{
			get
			{
				return (ETeleportToLatestResetPointType)this.Instance.Type;
			}
		}

		// Token: 0x040085F7 RID: 34295
		private ITeleportToLatestResetPointDirectly Instance;
	}
}
