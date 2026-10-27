using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E1 RID: 25825
	public class IControlTrackingType_UnionUnion
	{
		// Token: 0x1700C022 RID: 49186
		// (get) Token: 0x0602CCB8 RID: 183480 RVA: 0x00627C0D File Offset: 0x00625E0D
		// (set) Token: 0x0602CCB9 RID: 183481 RVA: 0x00627C15 File Offset: 0x00625E15
		public IControlTrackingType_Union Type { get; set; }

		// Token: 0x1700C023 RID: 49187
		// (get) Token: 0x0602CCBA RID: 183482 RVA: 0x00627C1E File Offset: 0x00625E1E
		// (set) Token: 0x0602CCBB RID: 183483 RVA: 0x00627C26 File Offset: 0x00625E26
		public object Value { get; set; }

		// Token: 0x0602CCBC RID: 183484 RVA: 0x00627C2F File Offset: 0x00625E2F
		public IControlTrackingType_UnionUnion()
		{
			this.Type = IControlTrackingType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CCBD RID: 183485 RVA: 0x00627C45 File Offset: 0x00625E45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CCBE RID: 183486 RVA: 0x00627C57 File Offset: 0x00625E57
		public IControlTrackingTypeT AsIControlTrackingType()
		{
			return this.As<IControlTrackingTypeT>();
		}

		// Token: 0x0602CCBF RID: 183487 RVA: 0x00627C5F File Offset: 0x00625E5F
		public static IControlTrackingType_UnionUnion FromIControlTrackingType(IControlTrackingTypeT _icontroltrackingtype)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingType,
				Value = _icontroltrackingtype
			};
		}

		// Token: 0x0602CCC0 RID: 183488 RVA: 0x00627C74 File Offset: 0x00625E74
		public IControlTrackingSelfT AsIControlTrackingSelf()
		{
			return this.As<IControlTrackingSelfT>();
		}

		// Token: 0x0602CCC1 RID: 183489 RVA: 0x00627C7C File Offset: 0x00625E7C
		public static IControlTrackingType_UnionUnion FromIControlTrackingSelf(IControlTrackingSelfT _icontroltrackingself)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingSelf,
				Value = _icontroltrackingself
			};
		}

		// Token: 0x0602CCC2 RID: 183490 RVA: 0x00627C91 File Offset: 0x00625E91
		public IControlTrackingOtherT AsIControlTrackingOther()
		{
			return this.As<IControlTrackingOtherT>();
		}

		// Token: 0x0602CCC3 RID: 183491 RVA: 0x00627C99 File Offset: 0x00625E99
		public static IControlTrackingType_UnionUnion FromIControlTrackingOther(IControlTrackingOtherT _icontroltrackingother)
		{
			return new IControlTrackingType_UnionUnion
			{
				Type = IControlTrackingType_Union.IControlTrackingOther,
				Value = _icontroltrackingother
			};
		}

		// Token: 0x0602CCC4 RID: 183492 RVA: 0x00627CB0 File Offset: 0x00625EB0
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
