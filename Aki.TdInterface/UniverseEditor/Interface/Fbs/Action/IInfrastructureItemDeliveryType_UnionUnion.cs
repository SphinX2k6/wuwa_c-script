using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007014 RID: 28692
	public class IInfrastructureItemDeliveryType_UnionUnion
	{
		// Token: 0x1700D216 RID: 53782
		// (get) Token: 0x06031B64 RID: 203620 RVA: 0x006BB3FD File Offset: 0x006B95FD
		// (set) Token: 0x06031B65 RID: 203621 RVA: 0x006BB405 File Offset: 0x006B9605
		public IInfrastructureItemDeliveryType_Union Type { get; set; }

		// Token: 0x1700D217 RID: 53783
		// (get) Token: 0x06031B66 RID: 203622 RVA: 0x006BB40E File Offset: 0x006B960E
		// (set) Token: 0x06031B67 RID: 203623 RVA: 0x006BB416 File Offset: 0x006B9616
		public object Value { get; set; }

		// Token: 0x06031B68 RID: 203624 RVA: 0x006BB41F File Offset: 0x006B961F
		public IInfrastructureItemDeliveryType_UnionUnion()
		{
			this.Type = IInfrastructureItemDeliveryType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031B69 RID: 203625 RVA: 0x006BB435 File Offset: 0x006B9635
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031B6A RID: 203626 RVA: 0x006BB447 File Offset: 0x006B9647
		public IInfrastructureItemDeliveryTypeT AsIInfrastructureItemDeliveryType()
		{
			return this.As<IInfrastructureItemDeliveryTypeT>();
		}

		// Token: 0x06031B6B RID: 203627 RVA: 0x006BB44F File Offset: 0x006B964F
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryType(IInfrastructureItemDeliveryTypeT _iinfrastructureitemdeliverytype)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryType,
				Value = _iinfrastructureitemdeliverytype
			};
		}

		// Token: 0x06031B6C RID: 203628 RVA: 0x006BB464 File Offset: 0x006B9664
		public IInfrastructureItemDeliveryObservatoryT AsIInfrastructureItemDeliveryObservatory()
		{
			return this.As<IInfrastructureItemDeliveryObservatoryT>();
		}

		// Token: 0x06031B6D RID: 203629 RVA: 0x006BB46C File Offset: 0x006B966C
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryObservatory(IInfrastructureItemDeliveryObservatoryT _iinfrastructureitemdeliveryobservatory)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryObservatory,
				Value = _iinfrastructureitemdeliveryobservatory
			};
		}

		// Token: 0x06031B6E RID: 203630 RVA: 0x006BB481 File Offset: 0x006B9681
		public IInfrastructureItemDeliveryRoadBuildT AsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.As<IInfrastructureItemDeliveryRoadBuildT>();
		}

		// Token: 0x06031B6F RID: 203631 RVA: 0x006BB489 File Offset: 0x006B9689
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryRoadBuild(IInfrastructureItemDeliveryRoadBuildT _iinfrastructureitemdeliveryroadbuild)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryRoadBuild,
				Value = _iinfrastructureitemdeliveryroadbuild
			};
		}

		// Token: 0x06031B70 RID: 203632 RVA: 0x006BB4A0 File Offset: 0x006B96A0
		public static int Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryType:
				return IInfrastructureItemDeliveryType.Pack(builder, _o.AsIInfrastructureItemDeliveryType()).Value;
			case IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryObservatory:
				return IInfrastructureItemDeliveryObservatory.Pack(builder, _o.AsIInfrastructureItemDeliveryObservatory()).Value;
			case IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryRoadBuild:
				return IInfrastructureItemDeliveryRoadBuild.Pack(builder, _o.AsIInfrastructureItemDeliveryRoadBuild()).Value;
			default:
				return 0;
			}
		}
	}
}
