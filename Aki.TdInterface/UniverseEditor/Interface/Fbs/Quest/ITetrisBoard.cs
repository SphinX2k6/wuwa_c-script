using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004610 RID: 17936
	public struct ITetrisBoard : IFlatbufferObject
	{
		// Token: 0x17007D77 RID: 32119
		// (get) Token: 0x0601A3A4 RID: 107428 RVA: 0x003BC104 File Offset: 0x003BA304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3A5 RID: 107429 RVA: 0x003BC111 File Offset: 0x003BA311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3A6 RID: 107430 RVA: 0x003BC118 File Offset: 0x003BA318
		public static ITetrisBoard GetRootAsITetrisBoard(ByteBuffer _bb)
		{
			return ITetrisBoard.GetRootAsITetrisBoard(_bb, default(ITetrisBoard));
		}

		// Token: 0x0601A3A7 RID: 107431 RVA: 0x003BC134 File Offset: 0x003BA334
		public static ITetrisBoard GetRootAsITetrisBoard(ByteBuffer _bb, ITetrisBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3A8 RID: 107432 RVA: 0x003BC151 File Offset: 0x003BA351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3A9 RID: 107433 RVA: 0x003BC160 File Offset: 0x003BA360
		public ITetrisBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A3AA RID: 107434 RVA: 0x003BC170 File Offset: 0x003BA370
		public ITetrisSingleGrid? Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITetrisSingleGrid?(default(ITetrisSingleGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007D78 RID: 32120
		// (get) Token: 0x0601A3AB RID: 107435 RVA: 0x003BC1D0 File Offset: 0x003BA3D0
		public int GridsLength
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

		// Token: 0x17007D79 RID: 32121
		// (get) Token: 0x0601A3AC RID: 107436 RVA: 0x003BC1FC File Offset: 0x003BA3FC
		public IRequiredVector2? BoardSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRequiredVector2?(default(IRequiredVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A3AD RID: 107437 RVA: 0x003BC259 File Offset: 0x003BA459
		public static Offset<ITetrisBoard> CreateITetrisBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IRequiredVector2> BoardSizeOffset = default(Offset<IRequiredVector2>))
		{
			builder.StartTable(2);
			ITetrisBoard.AddBoardSize(builder, BoardSizeOffset);
			ITetrisBoard.AddGrids(builder, GridsOffset);
			return ITetrisBoard.EndITetrisBoard(builder);
		}

		// Token: 0x0601A3AE RID: 107438 RVA: 0x003BC276 File Offset: 0x003BA476
		public static void StartITetrisBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A3AF RID: 107439 RVA: 0x003BC27F File Offset: 0x003BA47F
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x0601A3B0 RID: 107440 RVA: 0x003BC290 File Offset: 0x003BA490
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<ITetrisSingleGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A3B1 RID: 107441 RVA: 0x003BC2D0 File Offset: 0x003BA4D0
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<ITetrisSingleGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITetrisSingleGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3B2 RID: 107442 RVA: 0x003BC2EA File Offset: 0x003BA4EA
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITetrisSingleGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITetrisSingleGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3B3 RID: 107443 RVA: 0x003BC308 File Offset: 0x003BA508
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITetrisSingleGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A3B4 RID: 107444 RVA: 0x003BC321 File Offset: 0x003BA521
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A3B5 RID: 107445 RVA: 0x003BC32C File Offset: 0x003BA52C
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IRequiredVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601A3B6 RID: 107446 RVA: 0x003BC33C File Offset: 0x003BA53C
		public static Offset<ITetrisBoard> EndITetrisBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisBoard>(builder.EndTable());
		}

		// Token: 0x0601A3B7 RID: 107447 RVA: 0x003BC34C File Offset: 0x003BA54C
		public ITetrisBoardT UnPack()
		{
			ITetrisBoardT tetrisBoardT = new ITetrisBoardT();
			this.UnPackTo(tetrisBoardT);
			return tetrisBoardT;
		}

		// Token: 0x0601A3B8 RID: 107448 RVA: 0x003BC368 File Offset: 0x003BA568
		public void UnPackTo(ITetrisBoardT _o)
		{
			_o.Grids = new List<ITetrisSingleGridT>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add((this.Grids(i) != null) ? this.Grids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0601A3B9 RID: 107449 RVA: 0x003BC3F8 File Offset: 0x003BA5F8
		public static Offset<ITetrisBoard> Pack(FlatBufferBuilder builder, ITetrisBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisBoard>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				Offset<ITetrisSingleGrid>[] array = new Offset<ITetrisSingleGrid>[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITetrisSingleGrid.Pack(builder, _o.Grids[i]);
				}
				gridsOffset = ITetrisBoard.CreateGridsVector(builder, array);
			}
			Offset<IRequiredVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IRequiredVector2>) : IRequiredVector2.Pack(builder, _o.BoardSize);
			return ITetrisBoard.CreateITetrisBoard(builder, gridsOffset, boardSizeOffset);
		}

		// Token: 0x0400C805 RID: 51205
		private Table __p;
	}
}
