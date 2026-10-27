using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A45 RID: 10821
	public class IClientEventFlyingFlowerEvent
	{
		// Token: 0x0600EE39 RID: 60985 RVA: 0x0022B109 File Offset: 0x00229309
		[NullableContext(1)]
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

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x0022B128 File Offset: 0x00229328
		public virtual EClientEventFlyingFlowerEventType Type
		{
			get
			{
				return (EClientEventFlyingFlowerEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008317 RID: 33559
		private IClientEventFlyingFlowerEvent Instance;
	}
}
