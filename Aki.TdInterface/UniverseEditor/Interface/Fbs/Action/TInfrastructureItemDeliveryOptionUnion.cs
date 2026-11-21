using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F0A RID: 32522
	public class TInfrastructureItemDeliveryOptionUnion
	{
		// Token: 0x1700F27F RID: 62079
		// (get) Token: 0x0603AA85 RID: 240261 RVA: 0x007E3C4E File Offset: 0x007E1E4E
		// (set) Token: 0x0603AA86 RID: 240262 RVA: 0x007E3C56 File Offset: 0x007E1E56
		public TInfrastructureItemDeliveryOption Type { get; set; }

		// Token: 0x1700F280 RID: 62080
		// (get) Token: 0x0603AA87 RID: 240263 RVA: 0x007E3C5F File Offset: 0x007E1E5F
		// (set) Token: 0x0603AA88 RID: 240264 RVA: 0x007E3C67 File Offset: 0x007E1E67
		public object Value { get; set; }

		// Token: 0x0603AA89 RID: 240265 RVA: 0x007E3C70 File Offset: 0x007E1E70
		public TInfrastructureItemDeliveryOptionUnion()
		{
			this.Type = TInfrastructureItemDeliveryOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA8A RID: 240266 RVA: 0x007E3C86 File Offset: 0x007E1E86
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA8B RID: 240267 RVA: 0x007E3C98 File Offset: 0x007E1E98
		public IInfrastructureItemDeliveryObservatoryT AsIInfrastructureItemDeliveryObservatory()
		{
			return this.As<IInfrastructureItemDeliveryObservatoryT>();
		}

		// Token: 0x0603AA8C RID: 240268 RVA: 0x007E3CA0 File Offset: 0x007E1EA0
		public static TInfrastructureItemDeliveryOptionUnion FromIInfrastructureItemDeliveryObservatory(IInfrastructureItemDeliveryObservatoryT _iinfrastructureitemdeliveryobservatory)
		{
			return new TInfrastructureItemDeliveryOptionUnion
			{
				Type = TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryObservatory,
				Value = _iinfrastructureitemdeliveryobservatory
			};
		}

		// Token: 0x0603AA8D RID: 240269 RVA: 0x007E3CB5 File Offset: 0x007E1EB5
		public IInfrastructureItemDeliveryRoadBuildT AsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.As<IInfrastructureItemDeliveryRoadBuildT>();
		}

		// Token: 0x0603AA8E RID: 240270 RVA: 0x007E3CBD File Offset: 0x007E1EBD
		public static TInfrastructureItemDeliveryOptionUnion FromIInfrastructureItemDeliveryRoadBuild(IInfrastructureItemDeliveryRoadBuildT _iinfrastructureitemdeliveryroadbuild)
		{
			return new TInfrastructureItemDeliveryOptionUnion
			{
				Type = TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryRoadBuild,
				Value = _iinfrastructureitemdeliveryroadbuild
			};
		}

		// Token: 0x0603AA8F RID: 240271 RVA: 0x007E3CD4 File Offset: 0x007E1ED4
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
