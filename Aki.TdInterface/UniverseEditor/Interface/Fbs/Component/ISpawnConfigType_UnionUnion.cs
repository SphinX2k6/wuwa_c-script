using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005945 RID: 22853
	public class ISpawnConfigType_UnionUnion
	{
		// Token: 0x1700AB86 RID: 43910
		// (get) Token: 0x06026AB6 RID: 158390 RVA: 0x005534CD File Offset: 0x005516CD
		// (set) Token: 0x06026AB7 RID: 158391 RVA: 0x005534D5 File Offset: 0x005516D5
		public ISpawnConfigType_Union Type { get; set; }

		// Token: 0x1700AB87 RID: 43911
		// (get) Token: 0x06026AB8 RID: 158392 RVA: 0x005534DE File Offset: 0x005516DE
		// (set) Token: 0x06026AB9 RID: 158393 RVA: 0x005534E6 File Offset: 0x005516E6
		public object Value { get; set; }

		// Token: 0x06026ABA RID: 158394 RVA: 0x005534EF File Offset: 0x005516EF
		public ISpawnConfigType_UnionUnion()
		{
			this.Type = ISpawnConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026ABB RID: 158395 RVA: 0x00553505 File Offset: 0x00551705
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026ABC RID: 158396 RVA: 0x00553517 File Offset: 0x00551717
		public ISpawnConfigTypeT AsISpawnConfigType()
		{
			return this.As<ISpawnConfigTypeT>();
		}

		// Token: 0x06026ABD RID: 158397 RVA: 0x0055351F File Offset: 0x0055171F
		public static ISpawnConfigType_UnionUnion FromISpawnConfigType(ISpawnConfigTypeT _ispawnconfigtype)
		{
			return new ISpawnConfigType_UnionUnion
			{
				Type = ISpawnConfigType_Union.ISpawnConfigType,
				Value = _ispawnconfigtype
			};
		}

		// Token: 0x06026ABE RID: 158398 RVA: 0x00553534 File Offset: 0x00551734
		public ITemplateMatrixT AsITemplateMatrix()
		{
			return this.As<ITemplateMatrixT>();
		}

		// Token: 0x06026ABF RID: 158399 RVA: 0x0055353C File Offset: 0x0055173C
		public static ISpawnConfigType_UnionUnion FromITemplateMatrix(ITemplateMatrixT _itemplatematrix)
		{
			return new ISpawnConfigType_UnionUnion
			{
				Type = ISpawnConfigType_Union.ITemplateMatrix,
				Value = _itemplatematrix
			};
		}

		// Token: 0x06026AC0 RID: 158400 RVA: 0x00553554 File Offset: 0x00551754
		public static int Pack(FlatBufferBuilder builder, ISpawnConfigType_UnionUnion _o)
		{
			ISpawnConfigType_Union type = _o.Type;
			if (type == ISpawnConfigType_Union.ISpawnConfigType)
			{
				return ISpawnConfigType.Pack(builder, _o.AsISpawnConfigType()).Value;
			}
			if (type != ISpawnConfigType_Union.ITemplateMatrix)
			{
				return 0;
			}
			return ITemplateMatrix.Pack(builder, _o.AsITemplateMatrix()).Value;
		}
	}
}
