using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FD RID: 29949
	public class IVehicleControlType_UnionUnion
	{
		// Token: 0x1700E339 RID: 58169
		// (get) Token: 0x06036749 RID: 223049 RVA: 0x00765D09 File Offset: 0x00763F09
		// (set) Token: 0x0603674A RID: 223050 RVA: 0x00765D11 File Offset: 0x00763F11
		public IVehicleControlType_Union Type { get; set; }

		// Token: 0x1700E33A RID: 58170
		// (get) Token: 0x0603674B RID: 223051 RVA: 0x00765D1A File Offset: 0x00763F1A
		// (set) Token: 0x0603674C RID: 223052 RVA: 0x00765D22 File Offset: 0x00763F22
		public object Value { get; set; }

		// Token: 0x0603674D RID: 223053 RVA: 0x00765D2B File Offset: 0x00763F2B
		public IVehicleControlType_UnionUnion()
		{
			this.Type = IVehicleControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603674E RID: 223054 RVA: 0x00765D41 File Offset: 0x00763F41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603674F RID: 223055 RVA: 0x00765D53 File Offset: 0x00763F53
		public IVehicleControlTypeT AsIVehicleControlType()
		{
			return this.As<IVehicleControlTypeT>();
		}

		// Token: 0x06036750 RID: 223056 RVA: 0x00765D5B File Offset: 0x00763F5B
		public static IVehicleControlType_UnionUnion FromIVehicleControlType(IVehicleControlTypeT _ivehiclecontroltype)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleControlType,
				Value = _ivehiclecontroltype
			};
		}

		// Token: 0x06036751 RID: 223057 RVA: 0x00765D70 File Offset: 0x00763F70
		public IVehicleEnterPathMoveT AsIVehicleEnterPathMove()
		{
			return this.As<IVehicleEnterPathMoveT>();
		}

		// Token: 0x06036752 RID: 223058 RVA: 0x00765D78 File Offset: 0x00763F78
		public static IVehicleControlType_UnionUnion FromIVehicleEnterPathMove(IVehicleEnterPathMoveT _ivehicleenterpathmove)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleEnterPathMove,
				Value = _ivehicleenterpathmove
			};
		}

		// Token: 0x06036753 RID: 223059 RVA: 0x00765D8D File Offset: 0x00763F8D
		public IVehicleExitPathMoveT AsIVehicleExitPathMove()
		{
			return this.As<IVehicleExitPathMoveT>();
		}

		// Token: 0x06036754 RID: 223060 RVA: 0x00765D95 File Offset: 0x00763F95
		public static IVehicleControlType_UnionUnion FromIVehicleExitPathMove(IVehicleExitPathMoveT _ivehicleexitpathmove)
		{
			return new IVehicleControlType_UnionUnion
			{
				Type = IVehicleControlType_Union.IVehicleExitPathMove,
				Value = _ivehicleexitpathmove
			};
		}

		// Token: 0x06036755 RID: 223061 RVA: 0x00765DAC File Offset: 0x00763FAC
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
