using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A2 RID: 10658
	public class IInfrastructureItemDeliveryRoadBuild : IInfrastructureItemDeliveryType
	{
		// Token: 0x0600EBE2 RID: 60386 RVA: 0x00227A1F File Offset: 0x00225C1F
		[NullableContext(1)]
		public static IInfrastructureItemDeliveryRoadBuild Create(IInfrastructureItemDeliveryRoadBuild? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x00227A3E File Offset: 0x00225C3E
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x0600EBE4 RID: 60388 RVA: 0x00227A4B File Offset: 0x00225C4B
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040081E4 RID: 33252
		private IInfrastructureItemDeliveryRoadBuild Instance;
	}
}
