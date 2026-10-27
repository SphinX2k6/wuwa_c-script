using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C27 RID: 27687
	public struct IOpenQuickHackSystem : IFlatbufferObject
	{
		// Token: 0x1700CDEC RID: 52716
		// (get) Token: 0x06030B19 RID: 199449 RVA: 0x0069C2DC File Offset: 0x0069A4DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B1A RID: 199450 RVA: 0x0069C2E9 File Offset: 0x0069A4E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B1B RID: 199451 RVA: 0x0069C2F0 File Offset: 0x0069A4F0
		public static IOpenQuickHackSystem GetRootAsIOpenQuickHackSystem(ByteBuffer _bb)
		{
			return IOpenQuickHackSystem.GetRootAsIOpenQuickHackSystem(_bb, default(IOpenQuickHackSystem));
		}

		// Token: 0x06030B1C RID: 199452 RVA: 0x0069C30C File Offset: 0x0069A50C
		public static IOpenQuickHackSystem GetRootAsIOpenQuickHackSystem(ByteBuffer _bb, IOpenQuickHackSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B1D RID: 199453 RVA: 0x0069C329 File Offset: 0x0069A529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B1E RID: 199454 RVA: 0x0069C338 File Offset: 0x0069A538
		public IOpenQuickHackSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDED RID: 52717
		// (get) Token: 0x06030B1F RID: 199455 RVA: 0x0069C348 File Offset: 0x0069A548
		public int DeviceId
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

		// Token: 0x06030B20 RID: 199456 RVA: 0x0069C384 File Offset: 0x0069A584
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CDEE RID: 52718
		// (get) Token: 0x06030B21 RID: 199457 RVA: 0x0069C3C4 File Offset: 0x0069A5C4
		public int EntitiesLength
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

		// Token: 0x06030B22 RID: 199458 RVA: 0x0069C3EF File Offset: 0x0069A5EF
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06030B23 RID: 199459 RVA: 0x0069C3FE File Offset: 0x0069A5FE
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CDEF RID: 52719
		// (get) Token: 0x06030B24 RID: 199460 RVA: 0x0069C40C File Offset: 0x0069A60C
		public IOpenQuickHackCameraConfig? CameraConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IOpenQuickHackCameraConfig?(default(IOpenQuickHackCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CDF0 RID: 52720
		// (get) Token: 0x06030B25 RID: 199461 RVA: 0x0069C46C File Offset: 0x0069A66C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030B26 RID: 199462 RVA: 0x0069C4A9 File Offset: 0x0069A6A9
		public static Offset<IOpenQuickHackSystem> CreateIOpenQuickHackSystem(FlatBufferBuilder builder, int DeviceId = 0, VectorOffset EntitiesOffset = default(VectorOffset), Offset<IOpenQuickHackCameraConfig> CameraConfigOffset = default(Offset<IOpenQuickHackCameraConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenQuickHackSystem.AddCameraConfig(builder, CameraConfigOffset);
			IOpenQuickHackSystem.AddEntities(builder, EntitiesOffset);
			IOpenQuickHackSystem.AddDeviceId(builder, DeviceId);
			IOpenQuickHackSystem.AddNullMask(builder, NullMask);
			return IOpenQuickHackSystem.EndIOpenQuickHackSystem(builder);
		}

		// Token: 0x06030B27 RID: 199463 RVA: 0x0069C4D5 File Offset: 0x0069A6D5
		public static void StartIOpenQuickHackSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030B28 RID: 199464 RVA: 0x0069C4DE File Offset: 0x0069A6DE
		public static void AddDeviceId(FlatBufferBuilder builder, int deviceId)
		{
			builder.AddInt(0, deviceId, 0);
		}

		// Token: 0x06030B29 RID: 199465 RVA: 0x0069C4E9 File Offset: 0x0069A6E9
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x06030B2A RID: 199466 RVA: 0x0069C4FC File Offset: 0x0069A6FC
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030B2B RID: 199467 RVA: 0x0069C533 File Offset: 0x0069A733
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030B2C RID: 199468 RVA: 0x0069C54D File Offset: 0x0069A74D
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030B2D RID: 199469 RVA: 0x0069C56B File Offset: 0x0069A76B
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030B2E RID: 199470 RVA: 0x0069C584 File Offset: 0x0069A784
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030B2F RID: 199471 RVA: 0x0069C58F File Offset: 0x0069A78F
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IOpenQuickHackCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(2, cameraConfigOffset.Value, 0);
		}

		// Token: 0x06030B30 RID: 199472 RVA: 0x0069C59F File Offset: 0x0069A79F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030B31 RID: 199473 RVA: 0x0069C5AA File Offset: 0x0069A7AA
		public static Offset<IOpenQuickHackSystem> EndIOpenQuickHackSystem(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackSystem>(builder.EndTable());
		}

		// Token: 0x06030B32 RID: 199474 RVA: 0x0069C5B8 File Offset: 0x0069A7B8
		public IOpenQuickHackSystemT UnPack()
		{
			IOpenQuickHackSystemT openQuickHackSystemT = new IOpenQuickHackSystemT();
			this.UnPackTo(openQuickHackSystemT);
			return openQuickHackSystemT;
		}

		// Token: 0x06030B33 RID: 199475 RVA: 0x0069C5D4 File Offset: 0x0069A7D4
		public void UnPackTo(IOpenQuickHackSystemT _o)
		{
			_o.DeviceId = this.DeviceId;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030B34 RID: 199476 RVA: 0x0069C658 File Offset: 0x0069A858
		public static Offset<IOpenQuickHackSystem> Pack(FlatBufferBuilder builder, IOpenQuickHackSystemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQuickHackSystem>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IOpenQuickHackSystem.CreateEntitiesVector(builder, data);
			}
			Offset<IOpenQuickHackCameraConfig> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<IOpenQuickHackCameraConfig>) : IOpenQuickHackCameraConfig.Pack(builder, _o.CameraConfig);
			return IOpenQuickHackSystem.CreateIOpenQuickHackSystem(builder, _o.DeviceId, entitiesOffset, cameraConfigOffset, _o.NullMask);
		}

		// Token: 0x04011532 RID: 70962
		private Table __p;
	}
}
