using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F6 RID: 30454
	public class TInfrastructureItemDeliveryOptionUnion
	{
		// Token: 0x1700E63D RID: 58941
		// (get) Token: 0x060375B8 RID: 226744 RVA: 0x0077F742 File Offset: 0x0077D942
		// (set) Token: 0x060375B9 RID: 226745 RVA: 0x0077F74A File Offset: 0x0077D94A
		public TInfrastructureItemDeliveryOption Type { get; set; }

		// Token: 0x1700E63E RID: 58942
		// (get) Token: 0x060375BA RID: 226746 RVA: 0x0077F753 File Offset: 0x0077D953
		// (set) Token: 0x060375BB RID: 226747 RVA: 0x0077F75B File Offset: 0x0077D95B
		public object Value { get; set; }

		// Token: 0x060375BC RID: 226748 RVA: 0x0077F764 File Offset: 0x0077D964
		public TInfrastructureItemDeliveryOptionUnion()
		{
			this.Type = TInfrastructureItemDeliveryOption.NONE;
			this.Value = null;
		}

		// Token: 0x060375BD RID: 226749 RVA: 0x0077F77A File Offset: 0x0077D97A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375BE RID: 226750 RVA: 0x0077F78C File Offset: 0x0077D98C
		public IInfrastructureItemDeliveryObservatoryT AsIInfrastructureItemDeliveryObservatory()
		{
			return this.As<IInfrastructureItemDeliveryObservatoryT>();
		}

		// Token: 0x060375BF RID: 226751 RVA: 0x0077F794 File Offset: 0x0077D994
		public static TInfrastructureItemDeliveryOptionUnion FromIInfrastructureItemDeliveryObservatory(IInfrastructureItemDeliveryObservatoryT _iinfrastructureitemdeliveryobservatory)
		{
			return new TInfrastructureItemDeliveryOptionUnion
			{
				Type = TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryObservatory,
				Value = _iinfrastructureitemdeliveryobservatory
			};
		}

		// Token: 0x060375C0 RID: 226752 RVA: 0x0077F7A9 File Offset: 0x0077D9A9
		public IInfrastructureItemDeliveryRoadBuildT AsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.As<IInfrastructureItemDeliveryRoadBuildT>();
		}

		// Token: 0x060375C1 RID: 226753 RVA: 0x0077F7B1 File Offset: 0x0077D9B1
		public static TInfrastructureItemDeliveryOptionUnion FromIInfrastructureItemDeliveryRoadBuild(IInfrastructureItemDeliveryRoadBuildT _iinfrastructureitemdeliveryroadbuild)
		{
			return new TInfrastructureItemDeliveryOptionUnion
			{
				Type = TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryRoadBuild,
				Value = _iinfrastructureitemdeliveryroadbuild
			};
		}

		// Token: 0x060375C2 RID: 226754 RVA: 0x0077F7C8 File Offset: 0x0077D9C8
		public static int Pack(FlatBufferBuilder builder, TInfrastructureItemDeliveryOptionUnion _o)
		{
			TInfrastructureItemDeliveryOption type = _o.Type;
			if (type == TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryObservatory)
			{
				return IInfrastructureItemDeliveryObservatory.Pack(builder, _o.AsIInfrastructureItemDeliveryObservatory()).Value;
			}
			if (type != TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryRoadBuild)
			{
				return 0;
			}
			return IInfrastructureItemDeliveryRoadBuild.Pack(builder, _o.AsIInfrastructureItemDeliveryRoadBuild()).Value;
		}
	}
}
