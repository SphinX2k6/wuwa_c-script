using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B8 RID: 17592
	public struct IFindSunSpiritGridConfig : IFlatbufferObject
	{
		// Token: 0x17007C23 RID: 31779
		// (get) Token: 0x0601A46E RID: 107630 RVA: 0x003C0B69 File Offset: 0x003BED69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A46F RID: 107631 RVA: 0x003C0B76 File Offset: 0x003BED76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x003C0B80 File Offset: 0x003BED80
		public static IFindSunSpiritGridConfig GetRootAsIFindSunSpiritGridConfig(ByteBuffer _bb)
		{
			return IFindSunSpiritGridConfig.GetRootAsIFindSunSpiritGridConfig(_bb, default(IFindSunSpiritGridConfig));
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x003C0B9C File Offset: 0x003BED9C
		public static IFindSunSpiritGridConfig GetRootAsIFindSunSpiritGridConfig(ByteBuffer _bb, IFindSunSpiritGridConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x003C0BB9 File Offset: 0x003BEDB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x003C0BC8 File Offset: 0x003BEDC8
		public IFindSunSpiritGridConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A474 RID: 107636 RVA: 0x003C0BD8 File Offset: 0x003BEDD8
		public TFindSunSpiritGrid GridsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TFindSunSpiritGrid.NONE;
			}
			return (TFindSunSpiritGrid)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007C24 RID: 31780
		// (get) Token: 0x0601A475 RID: 107637 RVA: 0x003C0C18 File Offset: 0x003BEE18
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

		// Token: 0x0601A476 RID: 107638 RVA: 0x003C0C43 File Offset: 0x003BEE43
		public Span<TFindSunSpiritGrid> GetGridsTypeBytes()
		{
			return this.__p.__vector_as_span<TFindSunSpiritGrid>(4, 1);
		}

		// Token: 0x0601A477 RID: 107639 RVA: 0x003C0C54 File Offset: 0x003BEE54
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

		// Token: 0x0601A478 RID: 107640 RVA: 0x003C0CC0 File Offset: 0x003BEEC0
		public TTable? Grids<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007C25 RID: 31781
		// (get) Token: 0x0601A479 RID: 107641 RVA: 0x003C0D08 File Offset: 0x003BEF08
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

		// Token: 0x17007C26 RID: 31782
		// (get) Token: 0x0601A47A RID: 107642 RVA: 0x003C0D34 File Offset: 0x003BEF34
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

		// Token: 0x0601A47B RID: 107643 RVA: 0x003C0D91 File Offset: 0x003BEF91
		public static Offset<IFindSunSpiritGridConfig> CreateIFindSunSpiritGridConfig(FlatBufferBuilder builder, VectorOffset Grids_typeOffset = default(VectorOffset), VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(3);
			IFindSunSpiritGridConfig.AddBoardSize(builder, BoardSizeOffset);
			IFindSunSpiritGridConfig.AddGrids(builder, GridsOffset);
			IFindSunSpiritGridConfig.AddGridsType(builder, Grids_typeOffset);
			return IFindSunSpiritGridConfig.EndIFindSunSpiritGridConfig(builder);
		}

		// Token: 0x0601A47C RID: 107644 RVA: 0x003C0DB5 File Offset: 0x003BEFB5
		public static void StartIFindSunSpiritGridConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A47D RID: 107645 RVA: 0x003C0DBE File Offset: 0x003BEFBE
		public static void AddGridsType(FlatBufferBuilder builder, VectorOffset gridsTypeOffset)
		{
			builder.AddOffset(0, gridsTypeOffset.Value, 0);
		}

		// Token: 0x0601A47E RID: 107646 RVA: 0x003C0DD0 File Offset: 0x003BEFD0
		public static VectorOffset CreateGridsTypeVector(FlatBufferBuilder builder, TFindSunSpiritGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A47F RID: 107647 RVA: 0x003C0E07 File Offset: 0x003BF007
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, TFindSunSpiritGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TFindSunSpiritGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A480 RID: 107648 RVA: 0x003C0E21 File Offset: 0x003BF021
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TFindSunSpiritGrid> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TFindSunSpiritGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A481 RID: 107649 RVA: 0x003C0E3F File Offset: 0x003BF03F
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TFindSunSpiritGrid>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A482 RID: 107650 RVA: 0x003C0E58 File Offset: 0x003BF058
		public static void StartGridsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A483 RID: 107651 RVA: 0x003C0E63 File Offset: 0x003BF063
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(1, gridsOffset.Value, 0);
		}

		// Token: 0x0601A484 RID: 107652 RVA: 0x003C0E74 File Offset: 0x003BF074
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A485 RID: 107653 RVA: 0x003C0EAB File Offset: 0x003BF0AB
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A486 RID: 107654 RVA: 0x003C0EC5 File Offset: 0x003BF0C5
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A487 RID: 107655 RVA: 0x003C0EE3 File Offset: 0x003BF0E3
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A488 RID: 107656 RVA: 0x003C0EFC File Offset: 0x003BF0FC
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A489 RID: 107657 RVA: 0x003C0F07 File Offset: 0x003BF107
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(2, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601A48A RID: 107658 RVA: 0x003C0F17 File Offset: 0x003BF117
		public static Offset<IFindSunSpiritGridConfig> EndIFindSunSpiritGridConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridConfig>(builder.EndTable());
		}

		// Token: 0x0601A48B RID: 107659 RVA: 0x003C0F24 File Offset: 0x003BF124
		public IFindSunSpiritGridConfigT UnPack()
		{
			IFindSunSpiritGridConfigT findSunSpiritGridConfigT = new IFindSunSpiritGridConfigT();
			this.UnPackTo(findSunSpiritGridConfigT);
			return findSunSpiritGridConfigT;
		}

		// Token: 0x0601A48C RID: 107660 RVA: 0x003C0F40 File Offset: 0x003BF140
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

		// Token: 0x0601A48D RID: 107661 RVA: 0x003C10FC File Offset: 0x003BF2FC
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

		// Token: 0x0400C4CB RID: 50379
		private Table __p;
	}
}
