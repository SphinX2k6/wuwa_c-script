using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004557 RID: 17751
	public struct IRollBlockBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007DEB RID: 32235
		// (get) Token: 0x0601AB79 RID: 109433 RVA: 0x003CF477 File Offset: 0x003CD677
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB7A RID: 109434 RVA: 0x003CF484 File Offset: 0x003CD684
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB7B RID: 109435 RVA: 0x003CF48C File Offset: 0x003CD68C
		public static IRollBlockBoardConfig GetRootAsIRollBlockBoardConfig(ByteBuffer _bb)
		{
			return IRollBlockBoardConfig.GetRootAsIRollBlockBoardConfig(_bb, default(IRollBlockBoardConfig));
		}

		// Token: 0x0601AB7C RID: 109436 RVA: 0x003CF4A8 File Offset: 0x003CD6A8
		public static IRollBlockBoardConfig GetRootAsIRollBlockBoardConfig(ByteBuffer _bb, IRollBlockBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB7D RID: 109437 RVA: 0x003CF4C5 File Offset: 0x003CD6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB7E RID: 109438 RVA: 0x003CF4D4 File Offset: 0x003CD6D4
		public IRollBlockBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601AB7F RID: 109439 RVA: 0x003CF4E4 File Offset: 0x003CD6E4
		public TRollBlockGrid GridsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TRollBlockGrid.NONE;
			}
			return (TRollBlockGrid)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007DEC RID: 32236
		// (get) Token: 0x0601AB80 RID: 109440 RVA: 0x003CF524 File Offset: 0x003CD724
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

		// Token: 0x0601AB81 RID: 109441 RVA: 0x003CF54F File Offset: 0x003CD74F
		public Span<TRollBlockGrid> GetGridsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockGrid>(4, 1);
		}

		// Token: 0x0601AB82 RID: 109442 RVA: 0x003CF560 File Offset: 0x003CD760
		public TRollBlockGrid[] GetGridsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TRollBlockGrid[] array = new TRollBlockGrid[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TRollBlockGrid)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601AB83 RID: 109443 RVA: 0x003CF5CC File Offset: 0x003CD7CC
		public TTable? Grids<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007DED RID: 32237
		// (get) Token: 0x0601AB84 RID: 109444 RVA: 0x003CF614 File Offset: 0x003CD814
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

		// Token: 0x17007DEE RID: 32238
		// (get) Token: 0x0601AB85 RID: 109445 RVA: 0x003CF640 File Offset: 0x003CD840
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

		// Token: 0x0601AB86 RID: 109446 RVA: 0x003CF69D File Offset: 0x003CD89D
		public static Offset<IRollBlockBoardConfig> CreateIRollBlockBoardConfig(FlatBufferBuilder builder, VectorOffset Grids_typeOffset = default(VectorOffset), VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(3);
			IRollBlockBoardConfig.AddBoardSize(builder, BoardSizeOffset);
			IRollBlockBoardConfig.AddGrids(builder, GridsOffset);
			IRollBlockBoardConfig.AddGridsType(builder, Grids_typeOffset);
			return IRollBlockBoardConfig.EndIRollBlockBoardConfig(builder);
		}

		// Token: 0x0601AB87 RID: 109447 RVA: 0x003CF6C1 File Offset: 0x003CD8C1
		public static void StartIRollBlockBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AB88 RID: 109448 RVA: 0x003CF6CA File Offset: 0x003CD8CA
		public static void AddGridsType(FlatBufferBuilder builder, VectorOffset gridsTypeOffset)
		{
			builder.AddOffset(0, gridsTypeOffset.Value, 0);
		}

		// Token: 0x0601AB89 RID: 109449 RVA: 0x003CF6DC File Offset: 0x003CD8DC
		public static VectorOffset CreateGridsTypeVector(FlatBufferBuilder builder, TRollBlockGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AB8A RID: 109450 RVA: 0x003CF713 File Offset: 0x003CD913
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB8B RID: 109451 RVA: 0x003CF72D File Offset: 0x003CD92D
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockGrid> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB8C RID: 109452 RVA: 0x003CF74B File Offset: 0x003CD94B
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockGrid>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AB8D RID: 109453 RVA: 0x003CF764 File Offset: 0x003CD964
		public static void StartGridsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601AB8E RID: 109454 RVA: 0x003CF76F File Offset: 0x003CD96F
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(1, gridsOffset.Value, 0);
		}

		// Token: 0x0601AB8F RID: 109455 RVA: 0x003CF780 File Offset: 0x003CD980
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AB90 RID: 109456 RVA: 0x003CF7B7 File Offset: 0x003CD9B7
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB91 RID: 109457 RVA: 0x003CF7D1 File Offset: 0x003CD9D1
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AB92 RID: 109458 RVA: 0x003CF7EF File Offset: 0x003CD9EF
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AB93 RID: 109459 RVA: 0x003CF808 File Offset: 0x003CDA08
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AB94 RID: 109460 RVA: 0x003CF813 File Offset: 0x003CDA13
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(2, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601AB95 RID: 109461 RVA: 0x003CF823 File Offset: 0x003CDA23
		public static Offset<IRollBlockBoardConfig> EndIRollBlockBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBoardConfig>(builder.EndTable());
		}

		// Token: 0x0601AB96 RID: 109462 RVA: 0x003CF830 File Offset: 0x003CDA30
		public IRollBlockBoardConfigT UnPack()
		{
			IRollBlockBoardConfigT rollBlockBoardConfigT = new IRollBlockBoardConfigT();
			this.UnPackTo(rollBlockBoardConfigT);
			return rollBlockBoardConfigT;
		}

		// Token: 0x0601AB97 RID: 109463 RVA: 0x003CF84C File Offset: 0x003CDA4C
		public void UnPackTo(IRollBlockBoardConfigT _o)
		{
			_o.Grids = new List<TRollBlockGridUnion>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				TRollBlockGridUnion trollBlockGridUnion = new TRollBlockGridUnion();
				trollBlockGridUnion.Type = this.GridsType(i);
				switch (this.GridsType(i))
				{
				case TRollBlockGrid.IRollBlockGridBreakTrigger:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridBreakTrigger>(i) != null) ? this.Grids<IRollBlockGridBreakTrigger>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridEmpty:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridEmpty>(i) != null) ? this.Grids<IRollBlockGridEmpty>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridFallFloor:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridFallFloor>(i) != null) ? this.Grids<IRollBlockGridFallFloor>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridFloor:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridFloor>(i) != null) ? this.Grids<IRollBlockGridFloor>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridGoal:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridGoal>(i) != null) ? this.Grids<IRollBlockGridGoal>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridJumpFloor:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridJumpFloor>(i) != null) ? this.Grids<IRollBlockGridJumpFloor>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridLaser:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridLaser>(i) != null) ? this.Grids<IRollBlockGridLaser>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridLinkGoal:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridLinkGoal>(i) != null) ? this.Grids<IRollBlockGridLinkGoal>(i).Value.UnPack() : null);
					break;
				case TRollBlockGrid.IRollBlockGridQuantum:
					trollBlockGridUnion.Value = ((this.Grids<IRollBlockGridQuantum>(i) != null) ? this.Grids<IRollBlockGridQuantum>(i).Value.UnPack() : null);
					break;
				}
				_o.Grids.Add(trollBlockGridUnion);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0601AB98 RID: 109464 RVA: 0x003CFAFC File Offset: 0x003CDCFC
		public static Offset<IRollBlockBoardConfig> Pack(FlatBufferBuilder builder, IRollBlockBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockBoardConfig>);
			}
			VectorOffset grids_typeOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				TRollBlockGrid[] array = new TRollBlockGrid[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Grids[i].Type;
				}
				grids_typeOffset = IRollBlockBoardConfig.CreateGridsTypeVector(builder, array);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				int[] array2 = new int[_o.Grids.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockGridUnion.Pack(builder, _o.Grids[j]);
				}
				gridsOffset = IRollBlockBoardConfig.CreateGridsVector(builder, array2);
			}
			Offset<IVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.BoardSize);
			return IRollBlockBoardConfig.CreateIRollBlockBoardConfig(builder, grids_typeOffset, gridsOffset, boardSizeOffset);
		}

		// Token: 0x0400C5E6 RID: 50662
		private Table __p;
	}
}
