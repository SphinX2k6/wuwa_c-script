using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004920 RID: 18720
	public struct IFindSunSpiritGridConfig : IFlatbufferObject
	{
		// Token: 0x17008262 RID: 33378
		// (get) Token: 0x0601BC3F RID: 113727 RVA: 0x003ECD75 File Offset: 0x003EAF75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC40 RID: 113728 RVA: 0x003ECD82 File Offset: 0x003EAF82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC41 RID: 113729 RVA: 0x003ECD8C File Offset: 0x003EAF8C
		public static IFindSunSpiritGridConfig GetRootAsIFindSunSpiritGridConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritGridConfig.GetRootAsIFindSunSpiritGridConfig(_bb, default(IFindSunSpiritGridConfig));
		}

		// Token: 0x0601BC42 RID: 113730 RVA: 0x003ECDA8 File Offset: 0x003EAFA8
		public static IFindSunSpiritGridConfig GetRootAsIFindSunSpiritGridConfig(ByteBuffer _bb, IFindSunSpiritGridConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC43 RID: 113731 RVA: 0x003ECDC5 File Offset: 0x003EAFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC44 RID: 113732 RVA: 0x003ECDD4 File Offset: 0x003EAFD4
		public IFindSunSpiritGridConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601BC45 RID: 113733 RVA: 0x003ECDE4 File Offset: 0x003EAFE4
		public TFindSunSpiritGrid GridsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TFindSunSpiritGrid.NONE;
			}
			return (TFindSunSpiritGrid)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008263 RID: 33379
		// (get) Token: 0x0601BC46 RID: 113734 RVA: 0x003ECE24 File Offset: 0x003EB024
		public int GridsTypeLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BC47 RID: 113735 RVA: 0x003ECE4F File Offset: 0x003EB04F
		public Span<TFindSunSpiritGrid> GetGridsTypeBytes()
		{
			return this.__p.__vector_as_span<TFindSunSpiritGrid>(4, 1);
		}

		// Token: 0x0601BC48 RID: 113736 RVA: 0x003ECE60 File Offset: 0x003EB060
		public TFindSunSpiritGrid[] GetGridsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TFindSunSpiritGrid[] array = new TFindSunSpiritGrid[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TFindSunSpiritGrid)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601BC49 RID: 113737 RVA: 0x003ECECC File Offset: 0x003EB0CC
		public TTable? Grids<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008264 RID: 33380
		// (get) Token: 0x0601BC4A RID: 113738 RVA: 0x003ECF14 File Offset: 0x003EB114
		public int GridsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008265 RID: 33381
		// (get) Token: 0x0601BC4B RID: 113739 RVA: 0x003ECF40 File Offset: 0x003EB140
		public IVector2? BoardSize
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BC4C RID: 113740 RVA: 0x003ECF9D File Offset: 0x003EB19D
		public static Offset<IFindSunSpiritGridConfig> CreateIFindSunSpiritGridConfig(FlatBufferBuilder builder, VectorOffset Grids_typeOffset = default(VectorOffset), VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(3);
			IFindSunSpiritGridConfig.AddBoardSize(builder, BoardSizeOffset);
			IFindSunSpiritGridConfig.AddGrids(builder, GridsOffset);
			IFindSunSpiritGridConfig.AddGridsType(builder, Grids_typeOffset);
			return IFindSunSpiritGridConfig.EndIFindSunSpiritGridConfig(builder);
		}

		// Token: 0x0601BC4D RID: 113741 RVA: 0x003ECFC1 File Offset: 0x003EB1C1
		public static void StartIFindSunSpiritGridConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BC4E RID: 113742 RVA: 0x003ECFCA File Offset: 0x003EB1CA
		public static void AddGridsType(FlatBufferBuilder builder, VectorOffset gridsTypeOffset)
		{
			builder.AddOffset(0, gridsTypeOffset.Value, 0);
		}

		// Token: 0x0601BC4F RID: 113743 RVA: 0x003ECFDC File Offset: 0x003EB1DC
		public static VectorOffset CreateGridsTypeVector(FlatBufferBuilder builder, TFindSunSpiritGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC50 RID: 113744 RVA: 0x003ED013 File Offset: 0x003EB213
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, TFindSunSpiritGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TFindSunSpiritGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC51 RID: 113745 RVA: 0x003ED02D File Offset: 0x003EB22D
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TFindSunSpiritGrid> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TFindSunSpiritGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC52 RID: 113746 RVA: 0x003ED04B File Offset: 0x003EB24B
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TFindSunSpiritGrid>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC53 RID: 113747 RVA: 0x003ED064 File Offset: 0x003EB264
		public static void StartGridsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BC54 RID: 113748 RVA: 0x003ED06F File Offset: 0x003EB26F
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(1, gridsOffset.Value, 0);
		}

		// Token: 0x0601BC55 RID: 113749 RVA: 0x003ED080 File Offset: 0x003EB280
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BC56 RID: 113750 RVA: 0x003ED0B7 File Offset: 0x003EB2B7
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC57 RID: 113751 RVA: 0x003ED0D1 File Offset: 0x003EB2D1
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BC58 RID: 113752 RVA: 0x003ED0EF File Offset: 0x003EB2EF
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BC59 RID: 113753 RVA: 0x003ED108 File Offset: 0x003EB308
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BC5A RID: 113754 RVA: 0x003ED113 File Offset: 0x003EB313
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(2, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601BC5B RID: 113755 RVA: 0x003ED123 File Offset: 0x003EB323
		public static Offset<IFindSunSpiritGridConfig> EndIFindSunSpiritGridConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridConfig>(builder.EndTable());
		}

		// Token: 0x0601BC5C RID: 113756 RVA: 0x003ED130 File Offset: 0x003EB330
		public IFindSunSpiritGridConfigT UnPack()
		{
			IFindSunSpiritGridConfigT findSunSpiritGridConfigT = new IFindSunSpiritGridConfigT();
			this.UnPackTo(findSunSpiritGridConfigT);
			return findSunSpiritGridConfigT;
		}

		// Token: 0x0601BC5D RID: 113757 RVA: 0x003ED14C File Offset: 0x003EB34C
		public void UnPackTo(IFindSunSpiritGridConfigT _o)
		{
			_o.Grids = new List<TFindSunSpiritGridUnion>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				TFindSunSpiritGridUnion tfindSunSpiritGridUnion = new TFindSunSpiritGridUnion();
				tfindSunSpiritGridUnion.Type = this.GridsType(i);
				switch (this.GridsType(i))
				{
				case TFindSunSpiritGrid.IFindSunSpiritGridBeginFloor:
					tfindSunSpiritGridUnion.Value = ((this.Grids<IFindSunSpiritGridBeginFloor>(i) != null) ? this.Grids<IFindSunSpiritGridBeginFloor>(i).Value.UnPack() : null);
					break;
				case TFindSunSpiritGrid.IFindSunSpiritGridEmpty:
					tfindSunSpiritGridUnion.Value = ((this.Grids<IFindSunSpiritGridEmpty>(i) != null) ? this.Grids<IFindSunSpiritGridEmpty>(i).Value.UnPack() : null);
					break;
				case TFindSunSpiritGrid.IFindSunSpiritGridEndFloor:
					tfindSunSpiritGridUnion.Value = ((this.Grids<IFindSunSpiritGridEndFloor>(i) != null) ? this.Grids<IFindSunSpiritGridEndFloor>(i).Value.UnPack() : null);
					break;
				case TFindSunSpiritGrid.IFindSunSpiritGridMutableFloor:
					tfindSunSpiritGridUnion.Value = ((this.Grids<IFindSunSpiritGridMutableFloor>(i) != null) ? this.Grids<IFindSunSpiritGridMutableFloor>(i).Value.UnPack() : null);
					break;
				case TFindSunSpiritGrid.IFindSunSpiritGridNormalFloor:
					tfindSunSpiritGridUnion.Value = ((this.Grids<IFindSunSpiritGridNormalFloor>(i) != null) ? this.Grids<IFindSunSpiritGridNormalFloor>(i).Value.UnPack() : null);
					break;
				}
				_o.Grids.Add(tfindSunSpiritGridUnion);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0601BC5E RID: 113758 RVA: 0x003ED308 File Offset: 0x003EB508
		public static Offset<IFindSunSpiritGridConfig> Pack(FlatBufferBuilder builder, IFindSunSpiritGridConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridConfig>);
			}
			VectorOffset grids_typeOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				TFindSunSpiritGrid[] array = new TFindSunSpiritGrid[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Grids[i].Type;
				}
				grids_typeOffset = IFindSunSpiritGridConfig.CreateGridsTypeVector(builder, array);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				int[] array2 = new int[_o.Grids.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TFindSunSpiritGridUnion.Pack(builder, _o.Grids[j]);
				}
				gridsOffset = IFindSunSpiritGridConfig.CreateGridsVector(builder, array2);
			}
			Offset<IVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.BoardSize);
			return IFindSunSpiritGridConfig.CreateIFindSunSpiritGridConfig(builder, grids_typeOffset, gridsOffset, boardSizeOffset);
		}

		// Token: 0x0400CEF9 RID: 52985
		private Table __p;
	}
}
