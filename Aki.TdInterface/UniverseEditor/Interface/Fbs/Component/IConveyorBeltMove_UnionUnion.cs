using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005037 RID: 20535
	public class IConveyorBeltMove_UnionUnion
	{
		// Token: 0x17009503 RID: 38147
		// (get) Token: 0x06020E5F RID: 134751 RVA: 0x00493091 File Offset: 0x00491291
		// (set) Token: 0x06020E60 RID: 134752 RVA: 0x00493099 File Offset: 0x00491299
		public IConveyorBeltMove_Union Type { get; set; }

		// Token: 0x17009504 RID: 38148
		// (get) Token: 0x06020E61 RID: 134753 RVA: 0x004930A2 File Offset: 0x004912A2
		// (set) Token: 0x06020E62 RID: 134754 RVA: 0x004930AA File Offset: 0x004912AA
		public object Value { get; set; }

		// Token: 0x06020E63 RID: 134755 RVA: 0x004930B3 File Offset: 0x004912B3
		public IConveyorBeltMove_UnionUnion()
		{
			this.Type = IConveyorBeltMove_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020E64 RID: 134756 RVA: 0x004930C9 File Offset: 0x004912C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020E65 RID: 134757 RVA: 0x004930DB File Offset: 0x004912DB
		public IConveyorBeltMoveT AsIConveyorBeltMove()
		{
			return this.As<IConveyorBeltMoveT>();
		}

		// Token: 0x06020E66 RID: 134758 RVA: 0x004930E3 File Offset: 0x004912E3
		public static IConveyorBeltMove_UnionUnion FromIConveyorBeltMove(IConveyorBeltMoveT _iconveyorbeltmove)
		{
			return new IConveyorBeltMove_UnionUnion
			{
				Type = IConveyorBeltMove_Union.IConveyorBeltMove,
				Value = _iconveyorbeltmove
			};
		}

		// Token: 0x06020E67 RID: 134759 RVA: 0x004930F8 File Offset: 0x004912F8
		public IFixSpeedT AsIFixSpeed()
		{
			return this.As<IFixSpeedT>();
		}

		// Token: 0x06020E68 RID: 134760 RVA: 0x00493100 File Offset: 0x00491300
		public static IConveyorBeltMove_UnionUnion FromIFixSpeed(IFixSpeedT _ifixspeed)
		{
			return new IConveyorBeltMove_UnionUnion
			{
				Type = IConveyorBeltMove_Union.IFixSpeed,
				Value = _ifixspeed
			};
		}

		// Token: 0x06020E69 RID: 134761 RVA: 0x00493118 File Offset: 0x00491318
		public static int Pack(FlatBufferBuilder builder, IConveyorBeltMove_UnionUnion _o)
		{
			IConveyorBeltMove_Union type = _o.Type;
			if (type == IConveyorBeltMove_Union.IConveyorBeltMove)
			{
				return IConveyorBeltMove.Pack(builder, _o.AsIConveyorBeltMove()).Value;
			}
			if (type != IConveyorBeltMove_Union.IFixSpeed)
			{
				return 0;
			}
			return IFixSpeed.Pack(builder, _o.AsIFixSpeed()).Value;
		}
	}
}
