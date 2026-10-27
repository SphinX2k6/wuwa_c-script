using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E5 RID: 17637
	public struct ILevelBuildingGridConfig : IFlatbufferObject
	{
		// Token: 0x17007C90 RID: 31888
		// (get) Token: 0x0601A62C RID: 108076 RVA: 0x003C43B9 File Offset: 0x003C25B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A62D RID: 108077 RVA: 0x003C43C6 File Offset: 0x003C25C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A62E RID: 108078 RVA: 0x003C43D0 File Offset: 0x003C25D0
		public static ILevelBuildingGridConfig GetRootAsILevelBuildingGridConfig(ByteBuffer _bb)
		{
			return ILevelBuildingGridConfig.GetRootAsILevelBuildingGridConfig(_bb, default(ILevelBuildingGridConfig));
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x003C43EC File Offset: 0x003C25EC
		public static ILevelBuildingGridConfig GetRootAsILevelBuildingGridConfig(ByteBuffer _bb, ILevelBuildingGridConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x003C4409 File Offset: 0x003C2609
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x003C4418 File Offset: 0x003C2618
		public ILevelBuildingGridConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C91 RID: 31889
		// (get) Token: 0x0601A632 RID: 108082 RVA: 0x003C4428 File Offset: 0x003C2628
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C92 RID: 31890
		// (get) Token: 0x0601A633 RID: 108083 RVA: 0x003C4464 File Offset: 0x003C2664
		public int CellSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A634 RID: 108084 RVA: 0x003C44A0 File Offset: 0x003C26A0
		public ILevelBuildingGrid? Grids(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ILevelBuildingGrid?(default(ILevelBuildingGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C93 RID: 31891
		// (get) Token: 0x0601A635 RID: 108085 RVA: 0x003C4500 File Offset: 0x003C2700
		public int GridsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007C94 RID: 31892
		// (get) Token: 0x0601A636 RID: 108086 RVA: 0x003C452C File Offset: 0x003C272C
		public int _MaxGridId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A637 RID: 108087 RVA: 0x003C4569 File Offset: 0x003C2769
		public static Offset<ILevelBuildingGridConfig> CreateILevelBuildingGridConfig(FlatBufferBuilder builder, int LevelId = 0, int CellSize = 0, VectorOffset GridsOffset = default(VectorOffset), int _maxGridId = 0)
		{
			builder.StartTable(4);
			ILevelBuildingGridConfig.Add_MaxGridId(builder, _maxGridId);
			ILevelBuildingGridConfig.AddGrids(builder, GridsOffset);
			ILevelBuildingGridConfig.AddCellSize(builder, CellSize);
			ILevelBuildingGridConfig.AddLevelId(builder, LevelId);
			return ILevelBuildingGridConfig.EndILevelBuildingGridConfig(builder);
		}

		// Token: 0x0601A638 RID: 108088 RVA: 0x003C4595 File Offset: 0x003C2795
		public static void StartILevelBuildingGridConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A639 RID: 108089 RVA: 0x003C459E File Offset: 0x003C279E
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601A63A RID: 108090 RVA: 0x003C45A9 File Offset: 0x003C27A9
		public static void AddCellSize(FlatBufferBuilder builder, int cellSize)
		{
			builder.AddInt(1, cellSize, 0);
		}

		// Token: 0x0601A63B RID: 108091 RVA: 0x003C45B4 File Offset: 0x003C27B4
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(2, gridsOffset.Value, 0);
		}

		// Token: 0x0601A63C RID: 108092 RVA: 0x003C45C4 File Offset: 0x003C27C4
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<ILevelBuildingGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A63D RID: 108093 RVA: 0x003C4604 File Offset: 0x003C2804
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<ILevelBuildingGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelBuildingGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A63E RID: 108094 RVA: 0x003C461E File Offset: 0x003C281E
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelBuildingGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelBuildingGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A63F RID: 108095 RVA: 0x003C463C File Offset: 0x003C283C
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelBuildingGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A640 RID: 108096 RVA: 0x003C4655 File Offset: 0x003C2855
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A641 RID: 108097 RVA: 0x003C4660 File Offset: 0x003C2860
		public static void Add_MaxGridId(FlatBufferBuilder builder, int _MaxGridId)
		{
			builder.AddInt(3, _MaxGridId, 0);
		}

		// Token: 0x0601A642 RID: 108098 RVA: 0x003C466B File Offset: 0x003C286B
		public static Offset<ILevelBuildingGridConfig> EndILevelBuildingGridConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelBuildingGridConfig>(builder.EndTable());
		}

		// Token: 0x0601A643 RID: 108099 RVA: 0x003C4678 File Offset: 0x003C2878
		public ILevelBuildingGridConfigT UnPack()
		{
			ILevelBuildingGridConfigT levelBuildingGridConfigT = new ILevelBuildingGridConfigT();
			this.UnPackTo(levelBuildingGridConfigT);
			return levelBuildingGridConfigT;
		}

		// Token: 0x0601A644 RID: 108100 RVA: 0x003C4694 File Offset: 0x003C2894
		public void UnPackTo(ILevelBuildingGridConfigT _o)
		{
			_o.LevelId = this.LevelId;
			_o.CellSize = this.CellSize;
			_o.Grids = new List<ILevelBuildingGridT>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add((this.Grids(i) != null) ? this.Grids(i).Value.UnPack() : null);
			}
			_o._MaxGridId = this._MaxGridId;
		}

		// Token: 0x0601A645 RID: 108101 RVA: 0x003C4718 File Offset: 0x003C2918
		public static Offset<ILevelBuildingGridConfig> Pack(FlatBufferBuilder builder, ILevelBuildingGridConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelBuildingGridConfig>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				Offset<ILevelBuildingGrid>[] array = new Offset<ILevelBuildingGrid>[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelBuildingGrid.Pack(builder, _o.Grids[i]);
				}
				gridsOffset = ILevelBuildingGridConfig.CreateGridsVector(builder, array);
			}
			return ILevelBuildingGridConfig.CreateILevelBuildingGridConfig(builder, _o.LevelId, _o.CellSize, gridsOffset, _o._MaxGridId);
		}

		// Token: 0x0400C508 RID: 50440
		private Table __p;
	}
}
