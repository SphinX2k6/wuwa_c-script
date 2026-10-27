using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D5 RID: 30421
	public class TFlowDefineNpcGroupPerformTypeUnion
	{
		// Token: 0x1700E627 RID: 58919
		// (get) Token: 0x0603751A RID: 226586 RVA: 0x0077E8D0 File Offset: 0x0077CAD0
		// (set) Token: 0x0603751B RID: 226587 RVA: 0x0077E8D8 File Offset: 0x0077CAD8
		public TFlowDefineNpcGroupPerformType Type { get; set; }

		// Token: 0x1700E628 RID: 58920
		// (get) Token: 0x0603751C RID: 226588 RVA: 0x0077E8E1 File Offset: 0x0077CAE1
		// (set) Token: 0x0603751D RID: 226589 RVA: 0x0077E8E9 File Offset: 0x0077CAE9
		public object Value { get; set; }

		// Token: 0x0603751E RID: 226590 RVA: 0x0077E8F2 File Offset: 0x0077CAF2
		public TFlowDefineNpcGroupPerformTypeUnion()
		{
			this.Type = TFlowDefineNpcGroupPerformType.NONE;
			this.Value = null;
		}

		// Token: 0x0603751F RID: 226591 RVA: 0x0077E908 File Offset: 0x0077CB08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037520 RID: 226592 RVA: 0x0077E91A File Offset: 0x0077CB1A
		public IFlowDefineNpcCancelMotorcycleSharingPerformT AsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcCancelMotorcycleSharingPerformT>();
		}

		// Token: 0x06037521 RID: 226593 RVA: 0x0077E922 File Offset: 0x0077CB22
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcCancelMotorcycleSharingPerform(IFlowDefineNpcCancelMotorcycleSharingPerformT _iflowdefinenpccancelmotorcyclesharingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelMotorcycleSharingPerform,
				Value = _iflowdefinenpccancelmotorcyclesharingperform
			};
		}

		// Token: 0x06037522 RID: 226594 RVA: 0x0077E937 File Offset: 0x0077CB37
		public IFlowDefineNpcCancelSupportedWalkingPerformT AsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcCancelSupportedWalkingPerformT>();
		}

		// Token: 0x06037523 RID: 226595 RVA: 0x0077E93F File Offset: 0x0077CB3F
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcCancelSupportedWalkingPerform(IFlowDefineNpcCancelSupportedWalkingPerformT _iflowdefinenpccancelsupportedwalkingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelSupportedWalkingPerform,
				Value = _iflowdefinenpccancelsupportedwalkingperform
			};
		}

		// Token: 0x06037524 RID: 226596 RVA: 0x0077E954 File Offset: 0x0077CB54
		public IFlowDefineNpcHandInHandPerformT AsIFlowDefineNpcHandInHandPerform()
		{
			return this.As<IFlowDefineNpcHandInHandPerformT>();
		}

		// Token: 0x06037525 RID: 226597 RVA: 0x0077E95C File Offset: 0x0077CB5C
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcHandInHandPerform(IFlowDefineNpcHandInHandPerformT _iflowdefinenpchandinhandperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcHandInHandPerform,
				Value = _iflowdefinenpchandinhandperform
			};
		}

		// Token: 0x06037526 RID: 226598 RVA: 0x0077E971 File Offset: 0x0077CB71
		public IFlowDefineNpcMotorcycleSharingPerformT AsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcMotorcycleSharingPerformT>();
		}

		// Token: 0x06037527 RID: 226599 RVA: 0x0077E979 File Offset: 0x0077CB79
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcMotorcycleSharingPerform(IFlowDefineNpcMotorcycleSharingPerformT _iflowdefinenpcmotorcyclesharingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcMotorcycleSharingPerform,
				Value = _iflowdefinenpcmotorcyclesharingperform
			};
		}

		// Token: 0x06037528 RID: 226600 RVA: 0x0077E98E File Offset: 0x0077CB8E
		public IFlowDefineNpcSupportedWalkingPerformT AsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcSupportedWalkingPerformT>();
		}

		// Token: 0x06037529 RID: 226601 RVA: 0x0077E996 File Offset: 0x0077CB96
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcSupportedWalkingPerform(IFlowDefineNpcSupportedWalkingPerformT _iflowdefinenpcsupportedwalkingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcSupportedWalkingPerform,
				Value = _iflowdefinenpcsupportedwalkingperform
			};
		}

		// Token: 0x0603752A RID: 226602 RVA: 0x0077E9AC File Offset: 0x0077CBAC
		public static int Pack(FlatBufferBuilder builder, TFlowDefineNpcGroupPerformTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelMotorcycleSharingPerform:
				return IFlowDefineNpcCancelMotorcycleSharingPerform.Pack(builder, _o.AsIFlowDefineNpcCancelMotorcycleSharingPerform()).Value;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelSupportedWalkingPerform:
				return IFlowDefineNpcCancelSupportedWalkingPerform.Pack(builder, _o.AsIFlowDefineNpcCancelSupportedWalkingPerform()).Value;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcHandInHandPerform:
				return IFlowDefineNpcHandInHandPerform.Pack(builder, _o.AsIFlowDefineNpcHandInHandPerform()).Value;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcMotorcycleSharingPerform:
				return IFlowDefineNpcMotorcycleSharingPerform.Pack(builder, _o.AsIFlowDefineNpcMotorcycleSharingPerform()).Value;
			case TFlowDefineNpcGroupPerformType.IFlowDefineNpcSupportedWalkingPerform:
				return IFlowDefineNpcSupportedWalkingPerform.Pack(builder, _o.AsIFlowDefineNpcSupportedWalkingPerform()).Value;
			default:
				return 0;
			}
		}
	}
}
