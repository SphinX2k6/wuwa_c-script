using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C9 RID: 22217
	public class IPasserbyNpcMoveBase_UnionUnion
	{
		// Token: 0x1700A555 RID: 42325
		// (get) Token: 0x060251C4 RID: 152004 RVA: 0x0051FA49 File Offset: 0x0051DC49
		// (set) Token: 0x060251C5 RID: 152005 RVA: 0x0051FA51 File Offset: 0x0051DC51
		public IPasserbyNpcMoveBase_Union Type { get; set; }

		// Token: 0x1700A556 RID: 42326
		// (get) Token: 0x060251C6 RID: 152006 RVA: 0x0051FA5A File Offset: 0x0051DC5A
		// (set) Token: 0x060251C7 RID: 152007 RVA: 0x0051FA62 File Offset: 0x0051DC62
		public object Value { get; set; }

		// Token: 0x060251C8 RID: 152008 RVA: 0x0051FA6B File Offset: 0x0051DC6B
		public IPasserbyNpcMoveBase_UnionUnion()
		{
			this.Type = IPasserbyNpcMoveBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060251C9 RID: 152009 RVA: 0x0051FA81 File Offset: 0x0051DC81
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060251CA RID: 152010 RVA: 0x0051FA93 File Offset: 0x0051DC93
		public IPasserbyNpcMoveBaseT AsIPasserbyNpcMoveBase()
		{
			return this.As<IPasserbyNpcMoveBaseT>();
		}

		// Token: 0x060251CB RID: 152011 RVA: 0x0051FA9B File Offset: 0x0051DC9B
		public static IPasserbyNpcMoveBase_UnionUnion FromIPasserbyNpcMoveBase(IPasserbyNpcMoveBaseT _ipasserbynpcmovebase)
		{
			return new IPasserbyNpcMoveBase_UnionUnion
			{
				Type = IPasserbyNpcMoveBase_Union.IPasserbyNpcMoveBase,
				Value = _ipasserbynpcmovebase
			};
		}

		// Token: 0x060251CC RID: 152012 RVA: 0x0051FAB0 File Offset: 0x0051DCB0
		public IPasserbyNpcSplineMoveT AsIPasserbyNpcSplineMove()
		{
			return this.As<IPasserbyNpcSplineMoveT>();
		}

		// Token: 0x060251CD RID: 152013 RVA: 0x0051FAB8 File Offset: 0x0051DCB8
		public static IPasserbyNpcMoveBase_UnionUnion FromIPasserbyNpcSplineMove(IPasserbyNpcSplineMoveT _ipasserbynpcsplinemove)
		{
			return new IPasserbyNpcMoveBase_UnionUnion
			{
				Type = IPasserbyNpcMoveBase_Union.IPasserbyNpcSplineMove,
				Value = _ipasserbynpcsplinemove
			};
		}

		// Token: 0x060251CE RID: 152014 RVA: 0x0051FAD0 File Offset: 0x0051DCD0
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcMoveBase_UnionUnion _o)
		{
			IPasserbyNpcMoveBase_Union type = _o.Type;
			if (type == IPasserbyNpcMoveBase_Union.IPasserbyNpcMoveBase)
			{
				return IPasserbyNpcMoveBase.Pack(builder, _o.AsIPasserbyNpcMoveBase()).Value;
			}
			if (type != IPasserbyNpcMoveBase_Union.IPasserbyNpcSplineMove)
			{
				return 0;
			}
			return IPasserbyNpcSplineMove.Pack(builder, _o.AsIPasserbyNpcSplineMove()).Value;
		}
	}
}
