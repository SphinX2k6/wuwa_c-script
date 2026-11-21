using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C97 RID: 23703
	public class IPasserbyNpcMoveBase_UnionUnion
	{
		// Token: 0x1700AE16 RID: 44566
		// (get) Token: 0x06027507 RID: 161031 RVA: 0x00562001 File Offset: 0x00560201
		// (set) Token: 0x06027508 RID: 161032 RVA: 0x00562009 File Offset: 0x00560209
		public IPasserbyNpcMoveBase_Union Type { get; set; }

		// Token: 0x1700AE17 RID: 44567
		// (get) Token: 0x06027509 RID: 161033 RVA: 0x00562012 File Offset: 0x00560212
		// (set) Token: 0x0602750A RID: 161034 RVA: 0x0056201A File Offset: 0x0056021A
		public object Value { get; set; }

		// Token: 0x0602750B RID: 161035 RVA: 0x00562023 File Offset: 0x00560223
		public IPasserbyNpcMoveBase_UnionUnion()
		{
			this.Type = IPasserbyNpcMoveBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602750C RID: 161036 RVA: 0x00562039 File Offset: 0x00560239
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602750D RID: 161037 RVA: 0x0056204B File Offset: 0x0056024B
		public IPasserbyNpcMoveBaseT AsIPasserbyNpcMoveBase()
		{
			return this.As<IPasserbyNpcMoveBaseT>();
		}

		// Token: 0x0602750E RID: 161038 RVA: 0x00562053 File Offset: 0x00560253
		public static IPasserbyNpcMoveBase_UnionUnion FromIPasserbyNpcMoveBase(IPasserbyNpcMoveBaseT _ipasserbynpcmovebase)
		{
			return new IPasserbyNpcMoveBase_UnionUnion
			{
				Type = IPasserbyNpcMoveBase_Union.IPasserbyNpcMoveBase,
				Value = _ipasserbynpcmovebase
			};
		}

		// Token: 0x0602750F RID: 161039 RVA: 0x00562068 File Offset: 0x00560268
		public IPasserbyNpcSplineMoveT AsIPasserbyNpcSplineMove()
		{
			return this.As<IPasserbyNpcSplineMoveT>();
		}

		// Token: 0x06027510 RID: 161040 RVA: 0x00562070 File Offset: 0x00560270
		public static IPasserbyNpcMoveBase_UnionUnion FromIPasserbyNpcSplineMove(IPasserbyNpcSplineMoveT _ipasserbynpcsplinemove)
		{
			return new IPasserbyNpcMoveBase_UnionUnion
			{
				Type = IPasserbyNpcMoveBase_Union.IPasserbyNpcSplineMove,
				Value = _ipasserbynpcsplinemove
			};
		}

		// Token: 0x06027511 RID: 161041 RVA: 0x00562085 File Offset: 0x00560285
		public IPasserbyNpcLiftMoveT AsIPasserbyNpcLiftMove()
		{
			return this.As<IPasserbyNpcLiftMoveT>();
		}

		// Token: 0x06027512 RID: 161042 RVA: 0x0056208D File Offset: 0x0056028D
		public static IPasserbyNpcMoveBase_UnionUnion FromIPasserbyNpcLiftMove(IPasserbyNpcLiftMoveT _ipasserbynpcliftmove)
		{
			return new IPasserbyNpcMoveBase_UnionUnion
			{
				Type = IPasserbyNpcMoveBase_Union.IPasserbyNpcLiftMove,
				Value = _ipasserbynpcliftmove
			};
		}

		// Token: 0x06027513 RID: 161043 RVA: 0x005620A4 File Offset: 0x005602A4
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcMoveBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPasserbyNpcMoveBase_Union.IPasserbyNpcMoveBase:
				return IPasserbyNpcMoveBase.Pack(builder, _o.AsIPasserbyNpcMoveBase()).Value;
			case IPasserbyNpcMoveBase_Union.IPasserbyNpcSplineMove:
				return IPasserbyNpcSplineMove.Pack(builder, _o.AsIPasserbyNpcSplineMove()).Value;
			case IPasserbyNpcMoveBase_Union.IPasserbyNpcLiftMove:
				return IPasserbyNpcLiftMove.Pack(builder, _o.AsIPasserbyNpcLiftMove()).Value;
			default:
				return 0;
			}
		}
	}
}
