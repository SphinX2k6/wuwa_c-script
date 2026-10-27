using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A1 RID: 10657
	public class IInfrastructureItemDeliveryObservatory : IInfrastructureItemDeliveryType
	{
		// Token: 0x0600EBDE RID: 60382 RVA: 0x002279DE File Offset: 0x00225BDE
		[NullableContext(1)]
		public static IInfrastructureItemDeliveryObservatory Create(IInfrastructureItemDeliveryObservatory? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryObservatory
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x0600EBDF RID: 60383 RVA: 0x002279FD File Offset: 0x00225BFD
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				return (EInfrastructureItemDeliveryType)this.Instance.Type;
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x0600EBE0 RID: 60384 RVA: 0x00227A0A File Offset: 0x00225C0A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040081E3 RID: 33251
		private IInfrastructureItemDeliveryObservatory Instance;
	}
}
