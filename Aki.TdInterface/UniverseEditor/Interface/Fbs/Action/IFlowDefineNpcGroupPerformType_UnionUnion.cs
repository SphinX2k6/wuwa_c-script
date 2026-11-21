using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E85 RID: 28293
	public class IFlowDefineNpcGroupPerformType_UnionUnion
	{
		// Token: 0x1700CF57 RID: 53079
		// (get) Token: 0x06030E24 RID: 200228 RVA: 0x006A1941 File Offset: 0x0069FB41
		// (set) Token: 0x06030E25 RID: 200229 RVA: 0x006A1949 File Offset: 0x0069FB49
		public IFlowDefineNpcGroupPerformType_Union Type { get; set; }

		// Token: 0x1700CF58 RID: 53080
		// (get) Token: 0x06030E26 RID: 200230 RVA: 0x006A1952 File Offset: 0x0069FB52
		// (set) Token: 0x06030E27 RID: 200231 RVA: 0x006A195A File Offset: 0x0069FB5A
		public object Value { get; set; }

		// Token: 0x06030E28 RID: 200232 RVA: 0x006A1963 File Offset: 0x0069FB63
		public IFlowDefineNpcGroupPerformType_UnionUnion()
		{
			this.Type = IFlowDefineNpcGroupPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030E29 RID: 200233 RVA: 0x006A1979 File Offset: 0x0069FB79
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030E2A RID: 200234 RVA: 0x006A198B File Offset: 0x0069FB8B
		public IFlowDefineNpcGroupPerformTypeT AsIFlowDefineNpcGroupPerformType()
		{
			return this.As<IFlowDefineNpcGroupPerformTypeT>();
		}

		// Token: 0x06030E2B RID: 200235 RVA: 0x006A1993 File Offset: 0x0069FB93
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcGroupPerformType(IFlowDefineNpcGroupPerformTypeT _iflowdefinenpcgroupperformtype)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcGroupPerformType,
				Value = _iflowdefinenpcgroupperformtype
			};
		}

		// Token: 0x06030E2C RID: 200236 RVA: 0x006A19A8 File Offset: 0x0069FBA8
		public IFlowDefineNpcHandInHandPerformT AsIFlowDefineNpcHandInHandPerform()
		{
			return this.As<IFlowDefineNpcHandInHandPerformT>();
		}

		// Token: 0x06030E2D RID: 200237 RVA: 0x006A19B0 File Offset: 0x0069FBB0
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcHandInHandPerform(IFlowDefineNpcHandInHandPerformT _iflowdefinenpchandinhandperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcHandInHandPerform,
				Value = _iflowdefinenpchandinhandperform
			};
		}

		// Token: 0x06030E2E RID: 200238 RVA: 0x006A19C5 File Offset: 0x0069FBC5
		public IFlowDefineNpcMotorcycleSharingPerformT AsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcMotorcycleSharingPerformT>();
		}

		// Token: 0x06030E2F RID: 200239 RVA: 0x006A19CD File Offset: 0x0069FBCD
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcMotorcycleSharingPerform(IFlowDefineNpcMotorcycleSharingPerformT _iflowdefinenpcmotorcyclesharingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcMotorcycleSharingPerform,
				Value = _iflowdefinenpcmotorcyclesharingperform
			};
		}

		// Token: 0x06030E30 RID: 200240 RVA: 0x006A19E2 File Offset: 0x0069FBE2
		public IFlowDefineNpcCancelMotorcycleSharingPerformT AsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcCancelMotorcycleSharingPerformT>();
		}

		// Token: 0x06030E31 RID: 200241 RVA: 0x006A19EA File Offset: 0x0069FBEA
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcCancelMotorcycleSharingPerform(IFlowDefineNpcCancelMotorcycleSharingPerformT _iflowdefinenpccancelmotorcyclesharingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelMotorcycleSharingPerform,
				Value = _iflowdefinenpccancelmotorcyclesharingperform
			};
		}

		// Token: 0x06030E32 RID: 200242 RVA: 0x006A19FF File Offset: 0x0069FBFF
		public IFlowDefineNpcSupportedWalkingPerformT AsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcSupportedWalkingPerformT>();
		}

		// Token: 0x06030E33 RID: 200243 RVA: 0x006A1A07 File Offset: 0x0069FC07
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcSupportedWalkingPerform(IFlowDefineNpcSupportedWalkingPerformT _iflowdefinenpcsupportedwalkingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcSupportedWalkingPerform,
				Value = _iflowdefinenpcsupportedwalkingperform
			};
		}

		// Token: 0x06030E34 RID: 200244 RVA: 0x006A1A1C File Offset: 0x0069FC1C
		public IFlowDefineNpcCancelSupportedWalkingPerformT AsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcCancelSupportedWalkingPerformT>();
		}

		// Token: 0x06030E35 RID: 200245 RVA: 0x006A1A24 File Offset: 0x0069FC24
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcCancelSupportedWalkingPerform(IFlowDefineNpcCancelSupportedWalkingPerformT _iflowdefinenpccancelsupportedwalkingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelSupportedWalkingPerform,
				Value = _iflowdefinenpccancelsupportedwalkingperform
			};
		}

		// Token: 0x06030E36 RID: 200246 RVA: 0x006A1A3C File Offset: 0x0069FC3C
		public static int Pack(FlatBufferBuilder builder, IFlowDefineNpcGroupPerformType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcGroupPerformType:
				return IFlowDefineNpcGroupPerformType.Pack(builder, _o.AsIFlowDefineNpcGroupPerformType()).Value;
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcHandInHandPerform:
				return IFlowDefineNpcHandInHandPerform.Pack(builder, _o.AsIFlowDefineNpcHandInHandPerform()).Value;
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcMotorcycleSharingPerform:
				return IFlowDefineNpcMotorcycleSharingPerform.Pack(builder, _o.AsIFlowDefineNpcMotorcycleSharingPerform()).Value;
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelMotorcycleSharingPerform:
				return IFlowDefineNpcCancelMotorcycleSharingPerform.Pack(builder, _o.AsIFlowDefineNpcCancelMotorcycleSharingPerform()).Value;
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcSupportedWalkingPerform:
				return IFlowDefineNpcSupportedWalkingPerform.Pack(builder, _o.AsIFlowDefineNpcSupportedWalkingPerform()).Value;
			case IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelSupportedWalkingPerform:
				return IFlowDefineNpcCancelSupportedWalkingPerform.Pack(builder, _o.AsIFlowDefineNpcCancelSupportedWalkingPerform()).Value;
			default:
				return 0;
			}
		}
	}
}
