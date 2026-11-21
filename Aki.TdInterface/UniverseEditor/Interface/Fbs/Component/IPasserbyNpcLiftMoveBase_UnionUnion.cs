using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8E RID: 23694
	public class IPasserbyNpcLiftMoveBase_UnionUnion
	{
		// Token: 0x1700AE0C RID: 44556
		// (get) Token: 0x060274D3 RID: 160979 RVA: 0x00561B01 File Offset: 0x0055FD01
		// (set) Token: 0x060274D4 RID: 160980 RVA: 0x00561B09 File Offset: 0x0055FD09
		public IPasserbyNpcLiftMoveBase_Union Type { get; set; }

		// Token: 0x1700AE0D RID: 44557
		// (get) Token: 0x060274D5 RID: 160981 RVA: 0x00561B12 File Offset: 0x0055FD12
		// (set) Token: 0x060274D6 RID: 160982 RVA: 0x00561B1A File Offset: 0x0055FD1A
		public object Value { get; set; }

		// Token: 0x060274D7 RID: 160983 RVA: 0x00561B23 File Offset: 0x0055FD23
		public IPasserbyNpcLiftMoveBase_UnionUnion()
		{
			this.Type = IPasserbyNpcLiftMoveBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060274D8 RID: 160984 RVA: 0x00561B39 File Offset: 0x0055FD39
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060274D9 RID: 160985 RVA: 0x00561B4B File Offset: 0x0055FD4B
		public IPasserbyNpcLiftMoveBaseT AsIPasserbyNpcLiftMoveBase()
		{
			return this.As<IPasserbyNpcLiftMoveBaseT>();
		}

		// Token: 0x060274DA RID: 160986 RVA: 0x00561B53 File Offset: 0x0055FD53
		public static IPasserbyNpcLiftMoveBase_UnionUnion FromIPasserbyNpcLiftMoveBase(IPasserbyNpcLiftMoveBaseT _ipasserbynpcliftmovebase)
		{
			return new IPasserbyNpcLiftMoveBase_UnionUnion
			{
				Type = IPasserbyNpcLiftMoveBase_Union.IPasserbyNpcLiftMoveBase,
				Value = _ipasserbynpcliftmovebase
			};
		}

		// Token: 0x060274DB RID: 160987 RVA: 0x00561B68 File Offset: 0x0055FD68
		public IPasserbyNpcRideLiftLeaveOnArrivalMoveT AsIPasserbyNpcRideLiftLeaveOnArrivalMove()
		{
			return this.As<IPasserbyNpcRideLiftLeaveOnArrivalMoveT>();
		}

		// Token: 0x060274DC RID: 160988 RVA: 0x00561B70 File Offset: 0x0055FD70
		public static IPasserbyNpcLiftMoveBase_UnionUnion FromIPasserbyNpcRideLiftLeaveOnArrivalMove(IPasserbyNpcRideLiftLeaveOnArrivalMoveT _ipasserbynpcrideliftleaveonarrivalmove)
		{
			return new IPasserbyNpcLiftMoveBase_UnionUnion
			{
				Type = IPasserbyNpcLiftMoveBase_Union.IPasserbyNpcRideLiftLeaveOnArrivalMove,
				Value = _ipasserbynpcrideliftleaveonarrivalmove
			};
		}

		// Token: 0x060274DD RID: 160989 RVA: 0x00561B88 File Offset: 0x0055FD88
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcLiftMoveBase_UnionUnion _o)
		{
			IPasserbyNpcLiftMoveBase_Union type = _o.Type;
			if (type == IPasserbyNpcLiftMoveBase_Union.IPasserbyNpcLiftMoveBase)
			{
				return IPasserbyNpcLiftMoveBase.Pack(builder, _o.AsIPasserbyNpcLiftMoveBase()).Value;
			}
			if (type != IPasserbyNpcLiftMoveBase_Union.IPasserbyNpcRideLiftLeaveOnArrivalMove)
			{
				return 0;
			}
			return IPasserbyNpcRideLiftLeaveOnArrivalMove.Pack(builder, _o.AsIPasserbyNpcRideLiftLeaveOnArrivalMove()).Value;
		}
	}
}
