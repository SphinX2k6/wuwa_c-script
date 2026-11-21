using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4C RID: 27468
	public class IControlTrackingType_UnionUnion
	{
		// Token: 0x1700C9AF RID: 51631
		// (get) Token: 0x0602F43C RID: 193596 RVA: 0x00673D35 File Offset: 0x00671F35
		// (set) Token: 0x0602F43D RID: 193597 RVA: 0x00673D3D File Offset: 0x00671F3D
		public IControlTrackingType_Union Type { get; set; }

		// Token: 0x1700C9B0 RID: 51632
		// (get) Token: 0x0602F43E RID: 193598 RVA: 0x00673D46 File Offset: 0x00671F46
		// (set) Token: 0x0602F43F RID: 193599 RVA: 0x00673D4E File Offset: 0x00671F4E
		public object Value { get; set; }

		// Token: 0x0602F440 RID: 193600 RVA: 0x00673D57 File Offset: 0x00671F57
		public IControlTrackingType_UnionUnion()
		{
			this.Type = IControlTrackingType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F441 RID: 193601 RVA: 0x00673D6D File Offset: 0x00671F6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F442 RID: 193602 RVA: 0x00673D7F File Offset: 0x00671F7F
		public IControlTrackingTypeT AsIControlTrackingType()
		{
			return this.As<IControlTrackingTypeT>();
		}

		// Token: 0x0602F443 RID: 193603 RVA: 0x00673D87 File Offset: 0x00671F87
		public static IControlTrackingType_UnionUnion FromIControlTrackingType(IControlTrackingTypeT _icontroltrackingtype)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingType,
				Value = _icontroltrackingtype
			};
		}

		// Token: 0x0602F444 RID: 193604 RVA: 0x00673D9C File Offset: 0x00671F9C
		public IControlTrackingSelfT AsIControlTrackingSelf()
		{
			return this.As<IControlTrackingSelfT>();
		}

		// Token: 0x0602F445 RID: 193605 RVA: 0x00673DA4 File Offset: 0x00671FA4
		public static IControlTrackingType_UnionUnion FromIControlTrackingSelf(IControlTrackingSelfT _icontroltrackingself)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingSelf,
				Value = _icontroltrackingself
			};
		}

		// Token: 0x0602F446 RID: 193606 RVA: 0x00673DB9 File Offset: 0x00671FB9
		public IControlTrackingOtherT AsIControlTrackingOther()
		{
			return this.As<IControlTrackingOtherT>();
		}

		// Token: 0x0602F447 RID: 193607 RVA: 0x00673DC1 File Offset: 0x00671FC1
		public static IControlTrackingType_UnionUnion FromIControlTrackingOther(IControlTrackingOtherT _icontroltrackingother)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingOther,
				Value = _icontroltrackingother
			};
		}

		// Token: 0x0602F448 RID: 193608 RVA: 0x00673DD8 File Offset: 0x00671FD8
		public static int Pack(FlatBufferBuilder builder, IControlTrackingType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IControlTrackingType_Union.IControlTrackingType:
				return IControlTrackingType.Pack(builder, _o.AsIControlTrackingType()).Value;
			case IControlTrackingType_Union.IControlTrackingSelf:
				return IControlTrackingSelf.Pack(builder, _o.AsIControlTrackingSelf()).Value;
			case IControlTrackingType_Union.IControlTrackingOther:
				return IControlTrackingOther.Pack(builder, _o.AsIControlTrackingOther()).Value;
			default:
				return 0;
			}
		}
	}
}
