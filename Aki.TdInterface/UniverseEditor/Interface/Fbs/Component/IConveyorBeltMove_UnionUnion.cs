using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005596 RID: 21910
	public class IConveyorBeltMove_UnionUnion
	{
		// Token: 0x17009CE4 RID: 40164
		// (get) Token: 0x06022D7F RID: 142719 RVA: 0x004CCAE1 File Offset: 0x004CACE1
		// (set) Token: 0x06022D80 RID: 142720 RVA: 0x004CCAE9 File Offset: 0x004CACE9
		public IConveyorBeltMove_Union Type { get; set; }

		// Token: 0x17009CE5 RID: 40165
		// (get) Token: 0x06022D81 RID: 142721 RVA: 0x004CCAF2 File Offset: 0x004CACF2
		// (set) Token: 0x06022D82 RID: 142722 RVA: 0x004CCAFA File Offset: 0x004CACFA
		public object Value { get; set; }

		// Token: 0x06022D83 RID: 142723 RVA: 0x004CCB03 File Offset: 0x004CAD03
		public IConveyorBeltMove_UnionUnion()
		{
			this.Type = IConveyorBeltMove_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022D84 RID: 142724 RVA: 0x004CCB19 File Offset: 0x004CAD19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022D85 RID: 142725 RVA: 0x004CCB2B File Offset: 0x004CAD2B
		public IConveyorBeltMoveT AsIConveyorBeltMove()
		{
			return this.As<IConveyorBeltMoveT>();
		}

		// Token: 0x06022D86 RID: 142726 RVA: 0x004CCB33 File Offset: 0x004CAD33
		public static IConveyorBeltMove_UnionUnion FromIConveyorBeltMove(IConveyorBeltMoveT _iconveyorbeltmove)
		{
			return new IConveyorBeltMove_UnionUnion
			{
				Type = IConveyorBeltMove_Union.IConveyorBeltMove,
				Value = _iconveyorbeltmove
			};
		}

		// Token: 0x06022D87 RID: 142727 RVA: 0x004CCB48 File Offset: 0x004CAD48
		public IFixSpeedT AsIFixSpeed()
		{
			return this.As<IFixSpeedT>();
		}

		// Token: 0x06022D88 RID: 142728 RVA: 0x004CCB50 File Offset: 0x004CAD50
		public static IConveyorBeltMove_UnionUnion FromIFixSpeed(IFixSpeedT _ifixspeed)
		{
			return new IConveyorBeltMove_UnionUnion
			{
				Type = IConveyorBeltMove_Union.IFixSpeed,
				Value = _ifixspeed
			};
		}

		// Token: 0x06022D89 RID: 142729 RVA: 0x004CCB68 File Offset: 0x004CAD68
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
