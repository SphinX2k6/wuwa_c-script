using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D32 RID: 11570
	public class IClientEventFlyingFlowerEvent
	{
		// Token: 0x0600FCD1 RID: 64721 RVA: 0x00248ABD File Offset: 0x00246CBD
		public static IClientEventFlyingFlowerEvent Create(IClientEventFlyingFlowerEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x0600FCD2 RID: 64722 RVA: 0x00248ADC File Offset: 0x00246CDC
		public virtual EClientEventFlyingFlowerEventType Type
		{
			get
			{
				return (EClientEventFlyingFlowerEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008A0A RID: 35338
		private IClientEventFlyingFlowerEvent Instance;
	}
}
