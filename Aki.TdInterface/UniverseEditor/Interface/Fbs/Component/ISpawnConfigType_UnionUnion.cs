using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F52 RID: 24402
	public class ISpawnConfigType_UnionUnion
	{
		// Token: 0x1700B4BA RID: 46266
		// (get) Token: 0x06029020 RID: 167968 RVA: 0x0059A139 File Offset: 0x00598339
		// (set) Token: 0x06029021 RID: 167969 RVA: 0x0059A141 File Offset: 0x00598341
		public ISpawnConfigType_Union Type { get; set; }

		// Token: 0x1700B4BB RID: 46267
		// (get) Token: 0x06029022 RID: 167970 RVA: 0x0059A14A File Offset: 0x0059834A
		// (set) Token: 0x06029023 RID: 167971 RVA: 0x0059A152 File Offset: 0x00598352
		public object Value { get; set; }

		// Token: 0x06029024 RID: 167972 RVA: 0x0059A15B File Offset: 0x0059835B
		public ISpawnConfigType_UnionUnion()
		{
			this.Type = ISpawnConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029025 RID: 167973 RVA: 0x0059A171 File Offset: 0x00598371
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029026 RID: 167974 RVA: 0x0059A183 File Offset: 0x00598383
		public ISpawnConfigTypeT AsISpawnConfigType()
		{
			return this.As<ISpawnConfigTypeT>();
		}

		// Token: 0x06029027 RID: 167975 RVA: 0x0059A18B File Offset: 0x0059838B
		public static ISpawnConfigType_UnionUnion FromISpawnConfigType(ISpawnConfigTypeT _ispawnconfigtype)
		{
			return new ISpawnConfigType_UnionUnion
			{
				Type = ISpawnConfigType_Union.ISpawnConfigType,
				Value = _ispawnconfigtype
			};
		}

		// Token: 0x06029028 RID: 167976 RVA: 0x0059A1A0 File Offset: 0x005983A0
		public ITemplateMatrixT AsITemplateMatrix()
		{
			return this.As<ITemplateMatrixT>();
		}

		// Token: 0x06029029 RID: 167977 RVA: 0x0059A1A8 File Offset: 0x005983A8
		public static ISpawnConfigType_UnionUnion FromITemplateMatrix(ITemplateMatrixT _itemplatematrix)
		{
			return new ISpawnConfigType_UnionUnion
			{
				Type = ISpawnConfigType_Union.ITemplateMatrix,
				Value = _itemplatematrix
			};
		}

		// Token: 0x0602902A RID: 167978 RVA: 0x0059A1C0 File Offset: 0x005983C0
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
