using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006805 RID: 26629
	public class IFlowDefineNpcGroupPerformType_UnionUnion
	{
		// Token: 0x1700C5A1 RID: 50593
		// (get) Token: 0x0602E5DE RID: 189918 RVA: 0x006541FD File Offset: 0x006523FD
		// (set) Token: 0x0602E5DF RID: 189919 RVA: 0x00654205 File Offset: 0x00652405
		public IFlowDefineNpcGroupPerformType_Union Type { get; set; }

		// Token: 0x1700C5A2 RID: 50594
		// (get) Token: 0x0602E5E0 RID: 189920 RVA: 0x0065420E File Offset: 0x0065240E
		// (set) Token: 0x0602E5E1 RID: 189921 RVA: 0x00654216 File Offset: 0x00652416
		public object Value { get; set; }

		// Token: 0x0602E5E2 RID: 189922 RVA: 0x0065421F File Offset: 0x0065241F
		public IFlowDefineNpcGroupPerformType_UnionUnion()
		{
			this.Type = IFlowDefineNpcGroupPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E5E3 RID: 189923 RVA: 0x00654235 File Offset: 0x00652435
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E5E4 RID: 189924 RVA: 0x00654247 File Offset: 0x00652447
		public IFlowDefineNpcGroupPerformTypeT AsIFlowDefineNpcGroupPerformType()
		{
			return this.As<IFlowDefineNpcGroupPerformTypeT>();
		}

		// Token: 0x0602E5E5 RID: 189925 RVA: 0x0065424F File Offset: 0x0065244F
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcGroupPerformType(IFlowDefineNpcGroupPerformTypeT _iflowdefinenpcgroupperformtype)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcGroupPerformType,
				Value = _iflowdefinenpcgroupperformtype
			};
		}

		// Token: 0x0602E5E6 RID: 189926 RVA: 0x00654264 File Offset: 0x00652464
		public IFlowDefineNpcHandInHandPerformT AsIFlowDefineNpcHandInHandPerform()
		{
			return this.As<IFlowDefineNpcHandInHandPerformT>();
		}

		// Token: 0x0602E5E7 RID: 189927 RVA: 0x0065426C File Offset: 0x0065246C
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcHandInHandPerform(IFlowDefineNpcHandInHandPerformT _iflowdefinenpchandinhandperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcHandInHandPerform,
				Value = _iflowdefinenpchandinhandperform
			};
		}

		// Token: 0x0602E5E8 RID: 189928 RVA: 0x00654281 File Offset: 0x00652481
		public IFlowDefineNpcMotorcycleSharingPerformT AsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcMotorcycleSharingPerformT>();
		}

		// Token: 0x0602E5E9 RID: 189929 RVA: 0x00654289 File Offset: 0x00652489
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcMotorcycleSharingPerform(IFlowDefineNpcMotorcycleSharingPerformT _iflowdefinenpcmotorcyclesharingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcMotorcycleSharingPerform,
				Value = _iflowdefinenpcmotorcyclesharingperform
			};
		}

		// Token: 0x0602E5EA RID: 189930 RVA: 0x0065429E File Offset: 0x0065249E
		public IFlowDefineNpcCancelMotorcycleSharingPerformT AsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcCancelMotorcycleSharingPerformT>();
		}

		// Token: 0x0602E5EB RID: 189931 RVA: 0x006542A6 File Offset: 0x006524A6
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcCancelMotorcycleSharingPerform(IFlowDefineNpcCancelMotorcycleSharingPerformT _iflowdefinenpccancelmotorcyclesharingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelMotorcycleSharingPerform,
				Value = _iflowdefinenpccancelmotorcyclesharingperform
			};
		}

		// Token: 0x0602E5EC RID: 189932 RVA: 0x006542BB File Offset: 0x006524BB
		public IFlowDefineNpcSupportedWalkingPerformT AsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcSupportedWalkingPerformT>();
		}

		// Token: 0x0602E5ED RID: 189933 RVA: 0x006542C3 File Offset: 0x006524C3
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcSupportedWalkingPerform(IFlowDefineNpcSupportedWalkingPerformT _iflowdefinenpcsupportedwalkingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcSupportedWalkingPerform,
				Value = _iflowdefinenpcsupportedwalkingperform
			};
		}

		// Token: 0x0602E5EE RID: 189934 RVA: 0x006542D8 File Offset: 0x006524D8
		public IFlowDefineNpcCancelSupportedWalkingPerformT AsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcCancelSupportedWalkingPerformT>();
		}

		// Token: 0x0602E5EF RID: 189935 RVA: 0x006542E0 File Offset: 0x006524E0
		public static IFlowDefineNpcGroupPerformType_UnionUnion FromIFlowDefineNpcCancelSupportedWalkingPerform(IFlowDefineNpcCancelSupportedWalkingPerformT _iflowdefinenpccancelsupportedwalkingperform)
		{
			return new IFlowDefineNpcGroupPerformType_UnionUnion
			{
				Type = IFlowDefineNpcGroupPerformType_Union.IFlowDefineNpcCancelSupportedWalkingPerform,
				Value = _iflowdefinenpccancelsupportedwalkingperform
			};
		}

		// Token: 0x0602E5F0 RID: 189936 RVA: 0x006542F8 File Offset: 0x006524F8
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
