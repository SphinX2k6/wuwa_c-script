using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200494D RID: 18765
	public struct ILevelBuildingGridConfig : IFlatbufferObject
	{
		// Token: 0x170082CF RID: 33487
		// (get) Token: 0x0601BDFD RID: 114173 RVA: 0x003F05C5 File Offset: 0x003EE7C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BDFE RID: 114174 RVA: 0x003F05D2 File Offset: 0x003EE7D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BDFF RID: 114175 RVA: 0x003F05DC File Offset: 0x003EE7DC
		public static ILevelBuildingGridConfig GetRootAsILevelBuildingGridConfig(ByteBuffer _bb)
		{
			return ILevelBuildingGridConfig.GetRootAsILevelBuildingGridConfig(_bb, default(ILevelBuildingGridConfig));
		}

		// Token: 0x0601BE00 RID: 114176 RVA: 0x003F05F8 File Offset: 0x003EE7F8
		public static ILevelBuildingGridConfig GetRootAsILevelBuildingGridConfig(ByteBuffer _bb, ILevelBuildingGridConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BE01 RID: 114177 RVA: 0x003F0615 File Offset: 0x003EE815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BE02 RID: 114178 RVA: 0x003F0624 File Offset: 0x003EE824
		public ILevelBuildingGridConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082D0 RID: 33488
		// (get) Token: 0x0601BE03 RID: 114179 RVA: 0x003F0634 File Offset: 0x003EE834
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

		// Token: 0x170082D1 RID: 33489
		// (get) Token: 0x0601BE04 RID: 114180 RVA: 0x003F0670 File Offset: 0x003EE870
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

		// Token: 0x0601BE05 RID: 114181 RVA: 0x003F06AC File Offset: 0x003EE8AC
		public ILevelBuildingGrid? Grids(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ILevelBuildingGrid?(default(ILevelBuildingGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082D2 RID: 33490
		// (get) Token: 0x0601BE06 RID: 114182 RVA: 0x003F070C File Offset: 0x003EE90C
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

		// Token: 0x170082D3 RID: 33491
		// (get) Token: 0x0601BE07 RID: 114183 RVA: 0x003F0738 File Offset: 0x003EE938
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

		// Token: 0x0601BE08 RID: 114184 RVA: 0x003F0775 File Offset: 0x003EE975
		public static Offset<ILevelBuildingGridConfig> CreateILevelBuildingGridConfig(FlatBufferBuilder builder, int LevelId = 0, int CellSize = 0, VectorOffset GridsOffset = default(VectorOffset), int _maxGridId = 0)
		{
			builder.StartTable(4);
			ILevelBuildingGridConfig.Add_MaxGridId(builder, _maxGridId);
			ILevelBuildingGridConfig.AddGrids(builder, GridsOffset);
			ILevelBuildingGridConfig.AddCellSize(builder, CellSize);
			ILevelBuildingGridConfig.AddLevelId(builder, LevelId);
			return ILevelBuildingGridConfig.EndILevelBuildingGridConfig(builder);
		}

		// Token: 0x0601BE09 RID: 114185 RVA: 0x003F07A1 File Offset: 0x003EE9A1
		public static void StartILevelBuildingGridConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BE0A RID: 114186 RVA: 0x003F07AA File Offset: 0x003EE9AA
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601BE0B RID: 114187 RVA: 0x003F07B5 File Offset: 0x003EE9B5
		public static void AddCellSize(FlatBufferBuilder builder, int cellSize)
		{
			builder.AddInt(1, cellSize, 0);
		}

		// Token: 0x0601BE0C RID: 114188 RVA: 0x003F07C0 File Offset: 0x003EE9C0
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(2, gridsOffset.Value, 0);
		}

		// Token: 0x0601BE0D RID: 114189 RVA: 0x003F07D0 File Offset: 0x003EE9D0
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<ILevelBuildingGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE0E RID: 114190 RVA: 0x003F0810 File Offset: 0x003EEA10
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<ILevelBuildingGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelBuildingGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE0F RID: 114191 RVA: 0x003F082A File Offset: 0x003EEA2A
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelBuildingGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelBuildingGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE10 RID: 114192 RVA: 0x003F0848 File Offset: 0x003EEA48
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelBuildingGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE11 RID: 114193 RVA: 0x003F0861 File Offset: 0x003EEA61
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE12 RID: 114194 RVA: 0x003F086C File Offset: 0x003EEA6C
		public static void Add_MaxGridId(FlatBufferBuilder builder, int _MaxGridId)
		{
			builder.AddInt(3, _MaxGridId, 0);
		}

		// Token: 0x0601BE13 RID: 114195 RVA: 0x003F0877 File Offset: 0x003EEA77
		public static Offset<ILevelBuildingGridConfig> EndILevelBuildingGridConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelBuildingGridConfig>(builder.EndTable());
		}

		// Token: 0x0601BE14 RID: 114196 RVA: 0x003F0884 File Offset: 0x003EEA84
		public ILevelBuildingGridConfigT UnPack()
		{
			ILevelBuildingGridConfigT levelBuildingGridConfigT = new ILevelBuildingGridConfigT();
			this.UnPackTo(levelBuildingGridConfigT);
			return levelBuildingGridConfigT;
		}

		// Token: 0x0601BE15 RID: 114197 RVA: 0x003F08A0 File Offset: 0x003EEAA0
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

		// Token: 0x0601BE16 RID: 114198 RVA: 0x003F0924 File Offset: 0x003EEB24
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

		// Token: 0x0400CF36 RID: 53046
		private Table __p;
	}
}
