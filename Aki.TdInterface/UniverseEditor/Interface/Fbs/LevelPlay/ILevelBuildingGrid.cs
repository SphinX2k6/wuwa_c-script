using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200494A RID: 18762
	public struct ILevelBuildingGrid : IFlatbufferObject
	{
		// Token: 0x170082C2 RID: 33474
		// (get) Token: 0x0601BDCF RID: 114127 RVA: 0x003EFE24 File Offset: 0x003EE024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x003EFE31 File Offset: 0x003EE031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x003EFE38 File Offset: 0x003EE038
		public static ILevelBuildingGrid GetRootAsILevelBuildingGrid(ByteBuffer _bb)
		{
			return ILevelBuildingGrid.GetRootAsILevelBuildingGrid(_bb, default(ILevelBuildingGrid));
		}

		// Token: 0x0601BDD2 RID: 114130 RVA: 0x003EFE54 File Offset: 0x003EE054
		public static ILevelBuildingGrid GetRootAsILevelBuildingGrid(ByteBuffer _bb, ILevelBuildingGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BDD3 RID: 114131 RVA: 0x003EFE71 File Offset: 0x003EE071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BDD4 RID: 114132 RVA: 0x003EFE80 File Offset: 0x003EE080
		public ILevelBuildingGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082C3 RID: 33475
		// (get) Token: 0x0601BDD5 RID: 114133 RVA: 0x003EFE90 File Offset: 0x003EE090
		public int Id
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

		// Token: 0x170082C4 RID: 33476
		// (get) Token: 0x0601BDD6 RID: 114134 RVA: 0x003EFECC File Offset: 0x003EE0CC
		public string Guid
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BDD7 RID: 114135 RVA: 0x003EFF03 File Offset: 0x003EE103
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BDD8 RID: 114136 RVA: 0x003EFF12 File Offset: 0x003EE112
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170082C5 RID: 33477
		// (get) Token: 0x0601BDD9 RID: 114137 RVA: 0x003EFF20 File Offset: 0x003EE120
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082C6 RID: 33478
		// (get) Token: 0x0601BDDA RID: 114138 RVA: 0x003EFF80 File Offset: 0x003EE180
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082C7 RID: 33479
		// (get) Token: 0x0601BDDB RID: 114139 RVA: 0x003EFFE0 File Offset: 0x003EE1E0
		public IVector2? Size
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BDDC RID: 114140 RVA: 0x003F0040 File Offset: 0x003EE240
		public IVector2? BlockCoords(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IVector2?(default(IVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082C8 RID: 33480
		// (get) Token: 0x0601BDDD RID: 114141 RVA: 0x003F00A4 File Offset: 0x003EE2A4
		public int BlockCoordsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BDDE RID: 114142 RVA: 0x003F00D0 File Offset: 0x003EE2D0
		public static Offset<ILevelBuildingGrid> CreateILevelBuildingGrid(FlatBufferBuilder builder, int Id = 0, StringOffset GuidOffset = default(StringOffset), Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), Offset<IVector2> SizeOffset = default(Offset<IVector2>), VectorOffset BlockCoordsOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			ILevelBuildingGrid.AddBlockCoords(builder, BlockCoordsOffset);
			ILevelBuildingGrid.AddSize(builder, SizeOffset);
			ILevelBuildingGrid.AddRotation(builder, RotationOffset);
			ILevelBuildingGrid.AddPosition(builder, PositionOffset);
			ILevelBuildingGrid.AddGuid(builder, GuidOffset);
			ILevelBuildingGrid.AddId(builder, Id);
			return ILevelBuildingGrid.EndILevelBuildingGrid(builder);
		}

		// Token: 0x0601BDDF RID: 114143 RVA: 0x003F010C File Offset: 0x003EE30C
		public static void StartILevelBuildingGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601BDE0 RID: 114144 RVA: 0x003F0115 File Offset: 0x003EE315
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BDE1 RID: 114145 RVA: 0x003F0120 File Offset: 0x003EE320
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(1, guidOffset.Value, 0);
		}

		// Token: 0x0601BDE2 RID: 114146 RVA: 0x003F0130 File Offset: 0x003EE330
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x0601BDE3 RID: 114147 RVA: 0x003F0140 File Offset: 0x003EE340
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(3, rotationOffset.Value, 0);
		}

		// Token: 0x0601BDE4 RID: 114148 RVA: 0x003F0150 File Offset: 0x003EE350
		public static void AddSize(FlatBufferBuilder builder, Offset<IVector2> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x0601BDE5 RID: 114149 RVA: 0x003F0160 File Offset: 0x003EE360
		public static void AddBlockCoords(FlatBufferBuilder builder, VectorOffset blockCoordsOffset)
		{
			builder.AddOffset(5, blockCoordsOffset.Value, 0);
		}

		// Token: 0x0601BDE6 RID: 114150 RVA: 0x003F0170 File Offset: 0x003EE370
		public static VectorOffset CreateBlockCoordsVector(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BDE7 RID: 114151 RVA: 0x003F01B0 File Offset: 0x003EE3B0
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDE8 RID: 114152 RVA: 0x003F01CA File Offset: 0x003EE3CA
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDE9 RID: 114153 RVA: 0x003F01E8 File Offset: 0x003EE3E8
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BDEA RID: 114154 RVA: 0x003F0201 File Offset: 0x003EE401
		public static void StartBlockCoordsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BDEB RID: 114155 RVA: 0x003F020C File Offset: 0x003EE40C
		public static Offset<ILevelBuildingGrid> EndILevelBuildingGrid(FlatBufferBuilder builder)
		{
			return new Offset<ILevelBuildingGrid>(builder.EndTable());
		}

		// Token: 0x0601BDEC RID: 114156 RVA: 0x003F021C File Offset: 0x003EE41C
		public ILevelBuildingGridT UnPack()
		{
			ILevelBuildingGridT levelBuildingGridT = new ILevelBuildingGridT();
			this.UnPackTo(levelBuildingGridT);
			return levelBuildingGridT;
		}

		// Token: 0x0601BDED RID: 114157 RVA: 0x003F0238 File Offset: 0x003EE438
		public void UnPackTo(ILevelBuildingGridT _o)
		{
			_o.Id = this.Id;
			_o.Guid = this.Guid;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.BlockCoords = new List<IVector2T>();
			for (int i = 0; i < this.BlockCoordsLength; i++)
			{
				_o.BlockCoords.Add((this.BlockCoords(i) != null) ? this.BlockCoords(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BDEE RID: 114158 RVA: 0x003F0344 File Offset: 0x003EE544
		public static Offset<ILevelBuildingGrid> Pack(FlatBufferBuilder builder, ILevelBuildingGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelBuildingGrid>);
			}
			StringOffset guidOffset = (_o.Guid == null) ? default(StringOffset) : builder.CreateString(_o.Guid);
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			Offset<IVector2> sizeOffset = (_o.Size == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Size);
			VectorOffset blockCoordsOffset = default(VectorOffset);
			if (_o.BlockCoords != null)
			{
				Offset<IVector2>[] array = new Offset<IVector2>[_o.BlockCoords.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVector2.Pack(builder, _o.BlockCoords[i]);
				}
				blockCoordsOffset = ILevelBuildingGrid.CreateBlockCoordsVector(builder, array);
			}
			return ILevelBuildingGrid.CreateILevelBuildingGrid(builder, _o.Id, guidOffset, positionOffset, rotationOffset, sizeOffset, blockCoordsOffset);
		}

		// Token: 0x0400CF2F RID: 53039
		private Table __p;
	}
}
