using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006961 RID: 26977
	public class IInfrastructureItemDeliveryType_UnionUnion
	{
		// Token: 0x1700C813 RID: 51219
		// (get) Token: 0x0602F194 RID: 192916 RVA: 0x0066AF15 File Offset: 0x00669115
		// (set) Token: 0x0602F195 RID: 192917 RVA: 0x0066AF1D File Offset: 0x0066911D
		public IInfrastructureItemDeliveryType_Union Type { get; set; }

		// Token: 0x1700C814 RID: 51220
		// (get) Token: 0x0602F196 RID: 192918 RVA: 0x0066AF26 File Offset: 0x00669126
		// (set) Token: 0x0602F197 RID: 192919 RVA: 0x0066AF2E File Offset: 0x0066912E
		public object Value { get; set; }

		// Token: 0x0602F198 RID: 192920 RVA: 0x0066AF37 File Offset: 0x00669137
		public IInfrastructureItemDeliveryType_UnionUnion()
		{
			this.Type = IInfrastructureItemDeliveryType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F199 RID: 192921 RVA: 0x0066AF4D File Offset: 0x0066914D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F19A RID: 192922 RVA: 0x0066AF5F File Offset: 0x0066915F
		public IInfrastructureItemDeliveryTypeT AsIInfrastructureItemDeliveryType()
		{
			return this.As<IInfrastructureItemDeliveryTypeT>();
		}

		// Token: 0x0602F19B RID: 192923 RVA: 0x0066AF67 File Offset: 0x00669167
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryType(IInfrastructureItemDeliveryTypeT _iinfrastructureitemdeliverytype)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryType,
				Value = _iinfrastructureitemdeliverytype
			};
		}

		// Token: 0x0602F19C RID: 192924 RVA: 0x0066AF7C File Offset: 0x0066917C
		public IInfrastructureItemDeliveryObservatoryT AsIInfrastructureItemDeliveryObservatory()
		{
			return this.As<IInfrastructureItemDeliveryObservatoryT>();
		}

		// Token: 0x0602F19D RID: 192925 RVA: 0x0066AF84 File Offset: 0x00669184
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryObservatory(IInfrastructureItemDeliveryObservatoryT _iinfrastructureitemdeliveryobservatory)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryObservatory,
				Value = _iinfrastructureitemdeliveryobservatory
			};
		}

		// Token: 0x0602F19E RID: 192926 RVA: 0x0066AF99 File Offset: 0x00669199
		public IInfrastructureItemDeliveryRoadBuildT AsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.As<IInfrastructureItemDeliveryRoadBuildT>();
		}

		// Token: 0x0602F19F RID: 192927 RVA: 0x0066AFA1 File Offset: 0x006691A1
		public static IInfrastructureItemDeliveryType_UnionUnion FromIInfrastructureItemDeliveryRoadBuild(IInfrastructureItemDeliveryRoadBuildT _iinfrastructureitemdeliveryroadbuild)
		{
			return new IInfrastructureItemDeliveryType_UnionUnion
			{
				Type = IInfrastructureItemDeliveryType_Union.IInfrastructureItemDeliveryRoadBuild,
				Value = _iinfrastructureitemdeliveryroadbuild
			};
		}

		// Token: 0x0602F1A0 RID: 192928 RVA: 0x0066AFB8 File Offset: 0x006691B8
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
