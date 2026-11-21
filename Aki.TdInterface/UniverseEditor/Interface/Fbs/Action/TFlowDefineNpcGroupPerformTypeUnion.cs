using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE3 RID: 32483
	public class TFlowDefineNpcGroupPerformTypeUnion
	{
		// Token: 0x1700F265 RID: 62053
		// (get) Token: 0x0603A9CF RID: 240079 RVA: 0x007E2BE4 File Offset: 0x007E0DE4
		// (set) Token: 0x0603A9D0 RID: 240080 RVA: 0x007E2BEC File Offset: 0x007E0DEC
		public TFlowDefineNpcGroupPerformType Type { get; set; }

		// Token: 0x1700F266 RID: 62054
		// (get) Token: 0x0603A9D1 RID: 240081 RVA: 0x007E2BF5 File Offset: 0x007E0DF5
		// (set) Token: 0x0603A9D2 RID: 240082 RVA: 0x007E2BFD File Offset: 0x007E0DFD
		public object Value { get; set; }

		// Token: 0x0603A9D3 RID: 240083 RVA: 0x007E2C06 File Offset: 0x007E0E06
		public TFlowDefineNpcGroupPerformTypeUnion()
		{
			this.Type = TFlowDefineNpcGroupPerformType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9D4 RID: 240084 RVA: 0x007E2C1C File Offset: 0x007E0E1C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9D5 RID: 240085 RVA: 0x007E2C2E File Offset: 0x007E0E2E
		public IFlowDefineNpcCancelMotorcycleSharingPerformT AsIFlowDefineNpcCancelMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcCancelMotorcycleSharingPerformT>();
		}

		// Token: 0x0603A9D6 RID: 240086 RVA: 0x007E2C36 File Offset: 0x007E0E36
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcCancelMotorcycleSharingPerform(IFlowDefineNpcCancelMotorcycleSharingPerformT _iflowdefinenpccancelmotorcyclesharingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelMotorcycleSharingPerform,
				Value = _iflowdefinenpccancelmotorcyclesharingperform
			};
		}

		// Token: 0x0603A9D7 RID: 240087 RVA: 0x007E2C4B File Offset: 0x007E0E4B
		public IFlowDefineNpcCancelSupportedWalkingPerformT AsIFlowDefineNpcCancelSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcCancelSupportedWalkingPerformT>();
		}

		// Token: 0x0603A9D8 RID: 240088 RVA: 0x007E2C53 File Offset: 0x007E0E53
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcCancelSupportedWalkingPerform(IFlowDefineNpcCancelSupportedWalkingPerformT _iflowdefinenpccancelsupportedwalkingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcCancelSupportedWalkingPerform,
				Value = _iflowdefinenpccancelsupportedwalkingperform
			};
		}

		// Token: 0x0603A9D9 RID: 240089 RVA: 0x007E2C68 File Offset: 0x007E0E68
		public IFlowDefineNpcHandInHandPerformT AsIFlowDefineNpcHandInHandPerform()
		{
			return this.As<IFlowDefineNpcHandInHandPerformT>();
		}

		// Token: 0x0603A9DA RID: 240090 RVA: 0x007E2C70 File Offset: 0x007E0E70
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcHandInHandPerform(IFlowDefineNpcHandInHandPerformT _iflowdefinenpchandinhandperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcHandInHandPerform,
				Value = _iflowdefinenpchandinhandperform
			};
		}

		// Token: 0x0603A9DB RID: 240091 RVA: 0x007E2C85 File Offset: 0x007E0E85
		public IFlowDefineNpcMotorcycleSharingPerformT AsIFlowDefineNpcMotorcycleSharingPerform()
		{
			return this.As<IFlowDefineNpcMotorcycleSharingPerformT>();
		}

		// Token: 0x0603A9DC RID: 240092 RVA: 0x007E2C8D File Offset: 0x007E0E8D
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcMotorcycleSharingPerform(IFlowDefineNpcMotorcycleSharingPerformT _iflowdefinenpcmotorcyclesharingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcMotorcycleSharingPerform,
				Value = _iflowdefinenpcmotorcyclesharingperform
			};
		}

		// Token: 0x0603A9DD RID: 240093 RVA: 0x007E2CA2 File Offset: 0x007E0EA2
		public IFlowDefineNpcSupportedWalkingPerformT AsIFlowDefineNpcSupportedWalkingPerform()
		{
			return this.As<IFlowDefineNpcSupportedWalkingPerformT>();
		}

		// Token: 0x0603A9DE RID: 240094 RVA: 0x007E2CAA File Offset: 0x007E0EAA
		public static TFlowDefineNpcGroupPerformTypeUnion FromIFlowDefineNpcSupportedWalkingPerform(IFlowDefineNpcSupportedWalkingPerformT _iflowdefinenpcsupportedwalkingperform)
		{
			return new TFlowDefineNpcGroupPerformTypeUnion
			{
				Type = TFlowDefineNpcGroupPerformType.IFlowDefineNpcSupportedWalkingPerform,
				Value = _iflowdefinenpcsupportedwalkingperform
			};
		}

		// Token: 0x0603A9DF RID: 240095 RVA: 0x007E2CC0 File Offset: 0x007E0EC0
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
