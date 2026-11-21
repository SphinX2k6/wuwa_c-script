using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF3 RID: 31987
	public class IVehicleControlType_UnionUnion
	{
		// Token: 0x1700EF63 RID: 61283
		// (get) Token: 0x06039B5E RID: 236382 RVA: 0x007C8F59 File Offset: 0x007C7159
		// (set) Token: 0x06039B5F RID: 236383 RVA: 0x007C8F61 File Offset: 0x007C7161
		public IVehicleControlType_Union Type { get; set; }

		// Token: 0x1700EF64 RID: 61284
		// (get) Token: 0x06039B60 RID: 236384 RVA: 0x007C8F6A File Offset: 0x007C716A
		// (set) Token: 0x06039B61 RID: 236385 RVA: 0x007C8F72 File Offset: 0x007C7172
		public object Value { get; set; }

		// Token: 0x06039B62 RID: 236386 RVA: 0x007C8F7B File Offset: 0x007C717B
		public IVehicleControlType_UnionUnion()
		{
			this.Type = IVehicleControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039B63 RID: 236387 RVA: 0x007C8F91 File Offset: 0x007C7191
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039B64 RID: 236388 RVA: 0x007C8FA3 File Offset: 0x007C71A3
		public IVehicleControlTypeT AsIVehicleControlType()
		{
			return this.As<IVehicleControlTypeT>();
		}

		// Token: 0x06039B65 RID: 236389 RVA: 0x007C8FAB File Offset: 0x007C71AB
		public static IVehicleControlType_UnionUnion FromIVehicleControlType(IVehicleControlTypeT _ivehiclecontroltype)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleControlType,
				Value = _ivehiclecontroltype
			};
		}

		// Token: 0x06039B66 RID: 236390 RVA: 0x007C8FC0 File Offset: 0x007C71C0
		public IVehicleEnterPathMoveT AsIVehicleEnterPathMove()
		{
			return this.As<IVehicleEnterPathMoveT>();
		}

		// Token: 0x06039B67 RID: 236391 RVA: 0x007C8FC8 File Offset: 0x007C71C8
		public static IVehicleControlType_UnionUnion FromIVehicleEnterPathMove(IVehicleEnterPathMoveT _ivehicleenterpathmove)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleEnterPathMove,
				Value = _ivehicleenterpathmove
			};
		}

		// Token: 0x06039B68 RID: 236392 RVA: 0x007C8FDD File Offset: 0x007C71DD
		public IVehicleExitPathMoveT AsIVehicleExitPathMove()
		{
			return this.As<IVehicleExitPathMoveT>();
		}

		// Token: 0x06039B69 RID: 236393 RVA: 0x007C8FE5 File Offset: 0x007C71E5
		public static IVehicleControlType_UnionUnion FromIVehicleExitPathMove(IVehicleExitPathMoveT _ivehicleexitpathmove)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleExitPathMove,
				Value = _ivehicleexitpathmove
			};
		}

		// Token: 0x06039B6A RID: 236394 RVA: 0x007C8FFC File Offset: 0x007C71FC
		public static int Pack(FlatBufferBuilder builder, IVehicleControlType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVehicleControlType_Union.IVehicleControlType:
				return IVehicleControlType.Pack(builder, _o.AsIVehicleControlType()).Value;
			case IVehicleControlType_Union.IVehicleEnterPathMove:
				return IVehicleEnterPathMove.Pack(builder, _o.AsIVehicleEnterPathMove()).Value;
			case IVehicleControlType_Union.IVehicleExitPathMove:
				return IVehicleExitPathMove.Pack(builder, _o.AsIVehicleExitPathMove()).Value;
			default:
				return 0;
			}
		}
	}
}
