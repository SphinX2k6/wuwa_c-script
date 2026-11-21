using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006842 RID: 26690
	public class IAwakePosType_UnionUnion
	{
		// Token: 0x1700C43F RID: 50239
		// (get) Token: 0x0602D9DF RID: 186847 RVA: 0x0063DBC1 File Offset: 0x0063BDC1
		// (set) Token: 0x0602D9E0 RID: 186848 RVA: 0x0063DBC9 File Offset: 0x0063BDC9
		public IAwakePosType_Union Type { get; set; }

		// Token: 0x1700C440 RID: 50240
		// (get) Token: 0x0602D9E1 RID: 186849 RVA: 0x0063DBD2 File Offset: 0x0063BDD2
		// (set) Token: 0x0602D9E2 RID: 186850 RVA: 0x0063DBDA File Offset: 0x0063BDDA
		public object Value { get; set; }

		// Token: 0x0602D9E3 RID: 186851 RVA: 0x0063DBE3 File Offset: 0x0063BDE3
		public IAwakePosType_UnionUnion()
		{
			this.Type = IAwakePosType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D9E4 RID: 186852 RVA: 0x0063DBF9 File Offset: 0x0063BDF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D9E5 RID: 186853 RVA: 0x0063DC0B File Offset: 0x0063BE0B
		public IAwakePosTypeT AsIAwakePosType()
		{
			return this.As<IAwakePosTypeT>();
		}

		// Token: 0x0602D9E6 RID: 186854 RVA: 0x0063DC13 File Offset: 0x0063BE13
		public static IAwakePosType_UnionUnion FromIAwakePosType(IAwakePosTypeT _iawakepostype)
		{
			return new IAwakePosType_UnionUnion
			{
				Type = IAwakePosType_Union.IAwakePosType,
				Value = _iawakepostype
			};
		}

		// Token: 0x0602D9E7 RID: 186855 RVA: 0x0063DC28 File Offset: 0x0063BE28
		public IAwakeWithTransformVarT AsIAwakeWithTransformVar()
		{
			return this.As<IAwakeWithTransformVarT>();
		}

		// Token: 0x0602D9E8 RID: 186856 RVA: 0x0063DC30 File Offset: 0x0063BE30
		public static IAwakePosType_UnionUnion FromIAwakeWithTransformVar(IAwakeWithTransformVarT _iawakewithtransformvar)
		{
			return new IAwakePosType_UnionUnion
			{
				Type = IAwakePosType_Union.IAwakeWithTransformVar,
				Value = _iawakewithtransformvar
			};
		}

		// Token: 0x0602D9E9 RID: 186857 RVA: 0x0063DC48 File Offset: 0x0063BE48
		public static int Pack(FlatBufferBuilder builder, IAwakePosType_UnionUnion _o)
		{
			IAwakePosType_Union type = _o.Type;
			if (type == IAwakePosType_Union.IAwakePosType)
			{
				return IAwakePosType.Pack(builder, _o.AsIAwakePosType()).Value;
			}
			if (type != IAwakePosType_Union.IAwakeWithTransformVar)
			{
				return 0;
			}
			return IAwakeWithTransformVar.Pack(builder, _o.AsIAwakeWithTransformVar()).Value;
		}
	}
}
