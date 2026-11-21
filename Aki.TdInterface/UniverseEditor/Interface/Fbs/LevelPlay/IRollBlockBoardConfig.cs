using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BF RID: 18879
	public struct IRollBlockBoardConfig : IFlatbufferObject
	{
		// Token: 0x1700842C RID: 33836
		// (get) Token: 0x0601C34E RID: 115534 RVA: 0x003FB713 File Offset: 0x003F9913
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C34F RID: 115535 RVA: 0x003FB720 File Offset: 0x003F9920
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C350 RID: 115536 RVA: 0x003FB728 File Offset: 0x003F9928
		public static IRollBlockBoardConfig GetRootAsIRollBlockBoardConfig(ByteBuffer _bb)
		{
			return IRollBlockBoardConfig.GetRootAsIRollBlockBoardConfig(_bb, default(IRollBlockBoardConfig));
		}

		// Token: 0x0601C351 RID: 115537 RVA: 0x003FB744 File Offset: 0x003F9944
		public static IRollBlockBoardConfig GetRootAsIRollBlockBoardConfig(ByteBuffer _bb, IRollBlockBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C352 RID: 115538 RVA: 0x003FB761 File Offset: 0x003F9961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C353 RID: 115539 RVA: 0x003FB770 File Offset: 0x003F9970
		public IRollBlockBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C354 RID: 115540 RVA: 0x003FB780 File Offset: 0x003F9980
		public TRollBlockGrid GridsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TRollBlockGrid.NONE;
			}
			return (TRollBlockGrid)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700842D RID: 33837
		// (get) Token: 0x0601C355 RID: 115541 RVA: 0x003FB7C0 File Offset: 0x003F99C0
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

		// Token: 0x0601C356 RID: 115542 RVA: 0x003FB7EB File Offset: 0x003F99EB
		public Span<TRollBlockGrid> GetGridsTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockGrid>(4, 1);
		}

		// Token: 0x0601C357 RID: 115543 RVA: 0x003FB7FC File Offset: 0x003F99FC
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

		// Token: 0x0601C358 RID: 115544 RVA: 0x003FB868 File Offset: 0x003F9A68
		public TTable? Grids<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700842E RID: 33838
		// (get) Token: 0x0601C359 RID: 115545 RVA: 0x003FB8B0 File Offset: 0x003F9AB0
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

		// Token: 0x1700842F RID: 33839
		// (get) Token: 0x0601C35A RID: 115546 RVA: 0x003FB8DC File Offset: 0x003F9ADC
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

		// Token: 0x0601C35B RID: 115547 RVA: 0x003FB939 File Offset: 0x003F9B39
		public static Offset<IRollBlockBoardConfig> CreateIRollBlockBoardConfig(FlatBufferBuilder builder, VectorOffset Grids_typeOffset = default(VectorOffset), VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(3);
			IRollBlockBoardConfig.AddBoardSize(builder, BoardSizeOffset);
			IRollBlockBoardConfig.AddGrids(builder, GridsOffset);
			IRollBlockBoardConfig.AddGridsType(builder, Grids_typeOffset);
			return IRollBlockBoardConfig.EndIRollBlockBoardConfig(builder);
		}

		// Token: 0x0601C35C RID: 115548 RVA: 0x003FB95D File Offset: 0x003F9B5D
		public static void StartIRollBlockBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C35D RID: 115549 RVA: 0x003FB966 File Offset: 0x003F9B66
		public static void AddGridsType(FlatBufferBuilder builder, VectorOffset gridsTypeOffset)
		{
			builder.AddOffset(0, gridsTypeOffset.Value, 0);
		}

		// Token: 0x0601C35E RID: 115550 RVA: 0x003FB978 File Offset: 0x003F9B78
		public static VectorOffset CreateGridsTypeVector(FlatBufferBuilder builder, TRollBlockGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C35F RID: 115551 RVA: 0x003FB9AF File Offset: 0x003F9BAF
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, TRollBlockGrid[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C360 RID: 115552 RVA: 0x003FB9C9 File Offset: 0x003F9BC9
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockGrid> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockGrid>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C361 RID: 115553 RVA: 0x003FB9E7 File Offset: 0x003F9BE7
		public static VectorOffset CreateGridsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockGrid>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C362 RID: 115554 RVA: 0x003FBA00 File Offset: 0x003F9C00
		public static void StartGridsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C363 RID: 115555 RVA: 0x003FBA0B File Offset: 0x003F9C0B
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(1, gridsOffset.Value, 0);
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x003FBA1C File Offset: 0x003F9C1C
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C365 RID: 115557 RVA: 0x003FBA53 File Offset: 0x003F9C53
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C366 RID: 115558 RVA: 0x003FBA6D File Offset: 0x003F9C6D
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C367 RID: 115559 RVA: 0x003FBA8B File Offset: 0x003F9C8B
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C368 RID: 115560 RVA: 0x003FBAA4 File Offset: 0x003F9CA4
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C369 RID: 115561 RVA: 0x003FBAAF File Offset: 0x003F9CAF
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(2, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601C36A RID: 115562 RVA: 0x003FBABF File Offset: 0x003F9CBF
		public static Offset<IRollBlockBoardConfig> EndIRollBlockBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBoardConfig>(builder.EndTable());
		}

		// Token: 0x0601C36B RID: 115563 RVA: 0x003FBACC File Offset: 0x003F9CCC
		public IRollBlockBoardConfigT UnPack()
		{
			IRollBlockBoardConfigT rollBlockBoardConfigT = new IRollBlockBoardConfigT();
			this.UnPackTo(rollBlockBoardConfigT);
			return rollBlockBoardConfigT;
		}

		// Token: 0x0601C36C RID: 115564 RVA: 0x003FBAE8 File Offset: 0x003F9CE8
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

		// Token: 0x0601C36D RID: 115565 RVA: 0x003FBD98 File Offset: 0x003F9F98
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

		// Token: 0x0400D015 RID: 53269
		private Table __p;
	}
}
