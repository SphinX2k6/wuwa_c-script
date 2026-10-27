using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E2 RID: 17634
	public struct ILevelBuildingGrid : IFlatbufferObject
	{
		// Token: 0x17007C83 RID: 31875
		// (get) Token: 0x0601A5FE RID: 108030 RVA: 0x003C3C18 File Offset: 0x003C1E18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5FF RID: 108031 RVA: 0x003C3C25 File Offset: 0x003C1E25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A600 RID: 108032 RVA: 0x003C3C2C File Offset: 0x003C1E2C
		public static ILevelBuildingGrid GetRootAsILevelBuildingGrid(ByteBuffer _bb)
		{
			return ILevelBuildingGrid.GetRootAsILevelBuildingGrid(_bb, default(ILevelBuildingGrid));
		}

		// Token: 0x0601A601 RID: 108033 RVA: 0x003C3C48 File Offset: 0x003C1E48
		public static ILevelBuildingGrid GetRootAsILevelBuildingGrid(ByteBuffer _bb, ILevelBuildingGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A602 RID: 108034 RVA: 0x003C3C65 File Offset: 0x003C1E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A603 RID: 108035 RVA: 0x003C3C74 File Offset: 0x003C1E74
		public ILevelBuildingGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C84 RID: 31876
		// (get) Token: 0x0601A604 RID: 108036 RVA: 0x003C3C84 File Offset: 0x003C1E84
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

		// Token: 0x17007C85 RID: 31877
		// (get) Token: 0x0601A605 RID: 108037 RVA: 0x003C3CC0 File Offset: 0x003C1EC0
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

		// Token: 0x0601A606 RID: 108038 RVA: 0x003C3CF7 File Offset: 0x003C1EF7
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A607 RID: 108039 RVA: 0x003C3D06 File Offset: 0x003C1F06
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007C86 RID: 31878
		// (get) Token: 0x0601A608 RID: 108040 RVA: 0x003C3D14 File Offset: 0x003C1F14
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

		// Token: 0x17007C87 RID: 31879
		// (get) Token: 0x0601A609 RID: 108041 RVA: 0x003C3D74 File Offset: 0x003C1F74
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

		// Token: 0x17007C88 RID: 31880
		// (get) Token: 0x0601A60A RID: 108042 RVA: 0x003C3DD4 File Offset: 0x003C1FD4
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

		// Token: 0x0601A60B RID: 108043 RVA: 0x003C3E34 File Offset: 0x003C2034
		public IVector2? BlockCoords(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IVector2?(default(IVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007C89 RID: 31881
		// (get) Token: 0x0601A60C RID: 108044 RVA: 0x003C3E98 File Offset: 0x003C2098
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

		// Token: 0x0601A60D RID: 108045 RVA: 0x003C3EC4 File Offset: 0x003C20C4
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

		// Token: 0x0601A60E RID: 108046 RVA: 0x003C3F00 File Offset: 0x003C2100
		public static void StartILevelBuildingGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A60F RID: 108047 RVA: 0x003C3F09 File Offset: 0x003C2109
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A610 RID: 108048 RVA: 0x003C3F14 File Offset: 0x003C2114
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(1, guidOffset.Value, 0);
		}

		// Token: 0x0601A611 RID: 108049 RVA: 0x003C3F24 File Offset: 0x003C2124
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x0601A612 RID: 108050 RVA: 0x003C3F34 File Offset: 0x003C2134
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(3, rotationOffset.Value, 0);
		}

		// Token: 0x0601A613 RID: 108051 RVA: 0x003C3F44 File Offset: 0x003C2144
		public static void AddSize(FlatBufferBuilder builder, Offset<IVector2> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x0601A614 RID: 108052 RVA: 0x003C3F54 File Offset: 0x003C2154
		public static void AddBlockCoords(FlatBufferBuilder builder, VectorOffset blockCoordsOffset)
		{
			builder.AddOffset(5, blockCoordsOffset.Value, 0);
		}

		// Token: 0x0601A615 RID: 108053 RVA: 0x003C3F64 File Offset: 0x003C2164
		public static VectorOffset CreateBlockCoordsVector(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A616 RID: 108054 RVA: 0x003C3FA4 File Offset: 0x003C21A4
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, Offset<IVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A617 RID: 108055 RVA: 0x003C3FBE File Offset: 0x003C21BE
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A618 RID: 108056 RVA: 0x003C3FDC File Offset: 0x003C21DC
		public static VectorOffset CreateBlockCoordsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A619 RID: 108057 RVA: 0x003C3FF5 File Offset: 0x003C21F5
		public static void StartBlockCoordsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A61A RID: 108058 RVA: 0x003C4000 File Offset: 0x003C2200
		public static Offset<ILevelBuildingGrid> EndILevelBuildingGrid(FlatBufferBuilder builder)
		{
			return new Offset<ILevelBuildingGrid>(builder.EndTable());
		}

		// Token: 0x0601A61B RID: 108059 RVA: 0x003C4010 File Offset: 0x003C2210
		public ILevelBuildingGridT UnPack()
		{
			ILevelBuildingGridT levelBuildingGridT = new ILevelBuildingGridT();
			this.UnPackTo(levelBuildingGridT);
			return levelBuildingGridT;
		}

		// Token: 0x0601A61C RID: 108060 RVA: 0x003C402C File Offset: 0x003C222C
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

		// Token: 0x0601A61D RID: 108061 RVA: 0x003C4138 File Offset: 0x003C2338
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

		// Token: 0x0400C501 RID: 50433
		private Table __p;
	}
}
