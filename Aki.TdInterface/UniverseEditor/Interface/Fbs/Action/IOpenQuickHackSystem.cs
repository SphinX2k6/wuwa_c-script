using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738E RID: 29582
	public struct IOpenQuickHackSystem : IFlatbufferObject
	{
		// Token: 0x1700D907 RID: 55559
		// (get) Token: 0x06033A6D RID: 211565 RVA: 0x006F65D8 File Offset: 0x006F47D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A6E RID: 211566 RVA: 0x006F65E5 File Offset: 0x006F47E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A6F RID: 211567 RVA: 0x006F65EC File Offset: 0x006F47EC
		public static IOpenQuickHackSystem GetRootAsIOpenQuickHackSystem(ByteBuffer _bb)
		{
			return IOpenQuickHackSystem.GetRootAsIOpenQuickHackSystem(_bb, default(IOpenQuickHackSystem));
		}

		// Token: 0x06033A70 RID: 211568 RVA: 0x006F6608 File Offset: 0x006F4808
		public static IOpenQuickHackSystem GetRootAsIOpenQuickHackSystem(ByteBuffer _bb, IOpenQuickHackSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A71 RID: 211569 RVA: 0x006F6625 File Offset: 0x006F4825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A72 RID: 211570 RVA: 0x006F6634 File Offset: 0x006F4834
		public IOpenQuickHackSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D908 RID: 55560
		// (get) Token: 0x06033A73 RID: 211571 RVA: 0x006F6644 File Offset: 0x006F4844
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

		// Token: 0x06033A74 RID: 211572 RVA: 0x006F6680 File Offset: 0x006F4880
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D909 RID: 55561
		// (get) Token: 0x06033A75 RID: 211573 RVA: 0x006F66C0 File Offset: 0x006F48C0
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

		// Token: 0x06033A76 RID: 211574 RVA: 0x006F66EB File Offset: 0x006F48EB
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033A77 RID: 211575 RVA: 0x006F66FA File Offset: 0x006F48FA
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D90A RID: 55562
		// (get) Token: 0x06033A78 RID: 211576 RVA: 0x006F6708 File Offset: 0x006F4908
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

		// Token: 0x1700D90B RID: 55563
		// (get) Token: 0x06033A79 RID: 211577 RVA: 0x006F6768 File Offset: 0x006F4968
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

		// Token: 0x06033A7A RID: 211578 RVA: 0x006F67A5 File Offset: 0x006F49A5
		public static Offset<IOpenQuickHackSystem> CreateIOpenQuickHackSystem(FlatBufferBuilder builder, int DeviceId = 0, VectorOffset EntitiesOffset = default(VectorOffset), Offset<IOpenQuickHackCameraConfig> CameraConfigOffset = default(Offset<IOpenQuickHackCameraConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenQuickHackSystem.AddCameraConfig(builder, CameraConfigOffset);
			IOpenQuickHackSystem.AddEntities(builder, EntitiesOffset);
			IOpenQuickHackSystem.AddDeviceId(builder, DeviceId);
			IOpenQuickHackSystem.AddNullMask(builder, NullMask);
			return IOpenQuickHackSystem.EndIOpenQuickHackSystem(builder);
		}

		// Token: 0x06033A7B RID: 211579 RVA: 0x006F67D1 File Offset: 0x006F49D1
		public static void StartIOpenQuickHackSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033A7C RID: 211580 RVA: 0x006F67DA File Offset: 0x006F49DA
		public static void AddDeviceId(FlatBufferBuilder builder, int deviceId)
		{
			builder.AddInt(0, deviceId, 0);
		}

		// Token: 0x06033A7D RID: 211581 RVA: 0x006F67E5 File Offset: 0x006F49E5
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x06033A7E RID: 211582 RVA: 0x006F67F8 File Offset: 0x006F49F8
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033A7F RID: 211583 RVA: 0x006F682F File Offset: 0x006F4A2F
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A80 RID: 211584 RVA: 0x006F6849 File Offset: 0x006F4A49
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033A81 RID: 211585 RVA: 0x006F6867 File Offset: 0x006F4A67
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033A82 RID: 211586 RVA: 0x006F6880 File Offset: 0x006F4A80
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033A83 RID: 211587 RVA: 0x006F688B File Offset: 0x006F4A8B
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IOpenQuickHackCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(2, cameraConfigOffset.Value, 0);
		}

		// Token: 0x06033A84 RID: 211588 RVA: 0x006F689B File Offset: 0x006F4A9B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06033A85 RID: 211589 RVA: 0x006F68A6 File Offset: 0x006F4AA6
		public static Offset<IOpenQuickHackSystem> EndIOpenQuickHackSystem(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackSystem>(builder.EndTable());
		}

		// Token: 0x06033A86 RID: 211590 RVA: 0x006F68B4 File Offset: 0x006F4AB4
		public IOpenQuickHackSystemT UnPack()
		{
			IOpenQuickHackSystemT openQuickHackSystemT = new IOpenQuickHackSystemT();
			this.UnPackTo(openQuickHackSystemT);
			return openQuickHackSystemT;
		}

		// Token: 0x06033A87 RID: 211591 RVA: 0x006F68D0 File Offset: 0x006F4AD0
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

		// Token: 0x06033A88 RID: 211592 RVA: 0x006F6954 File Offset: 0x006F4B54
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

		// Token: 0x04012489 RID: 74889
		private Table __p;
	}
}
