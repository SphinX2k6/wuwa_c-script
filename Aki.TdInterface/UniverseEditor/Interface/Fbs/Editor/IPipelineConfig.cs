using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CFD RID: 19709
	public struct IPipelineConfig : IFlatbufferObject
	{
		// Token: 0x17008D0E RID: 36110
		// (get) Token: 0x0601E7E9 RID: 124905 RVA: 0x00445420 File Offset: 0x00443620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7EA RID: 124906 RVA: 0x0044542D File Offset: 0x0044362D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7EB RID: 124907 RVA: 0x00445434 File Offset: 0x00443634
		public static IPipelineConfig GetRootAsIPipelineConfig(ByteBuffer _bb)
		{
			return IPipelineConfig.GetRootAsIPipelineConfig(_bb, default(IPipelineConfig));
		}

		// Token: 0x0601E7EC RID: 124908 RVA: 0x00445450 File Offset: 0x00443650
		public static IPipelineConfig GetRootAsIPipelineConfig(ByteBuffer _bb, IPipelineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7ED RID: 124909 RVA: 0x0044546D File Offset: 0x0044366D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7EE RID: 124910 RVA: 0x0044547C File Offset: 0x0044367C
		public IPipelineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601E7EF RID: 124911 RVA: 0x0044548C File Offset: 0x0044368C
		public int VoxelLevels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D0F RID: 36111
		// (get) Token: 0x0601E7F0 RID: 124912 RVA: 0x004454CC File Offset: 0x004436CC
		public int VoxelLevelsLength
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

		// Token: 0x0601E7F1 RID: 124913 RVA: 0x004454F7 File Offset: 0x004436F7
		public Span<int> GetVoxelLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601E7F2 RID: 124914 RVA: 0x00445506 File Offset: 0x00443706
		public int[] GetVoxelLevelsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x17008D10 RID: 36112
		// (get) Token: 0x0601E7F3 RID: 124915 RVA: 0x00445514 File Offset: 0x00443714
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E7F4 RID: 124916 RVA: 0x00445550 File Offset: 0x00443750
		public static Offset<IPipelineConfig> CreateIPipelineConfig(FlatBufferBuilder builder, VectorOffset VoxelLevelsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IPipelineConfig.AddVoxelLevels(builder, VoxelLevelsOffset);
			IPipelineConfig.AddNullMask(builder, NullMask);
			return IPipelineConfig.EndIPipelineConfig(builder);
		}

		// Token: 0x0601E7F5 RID: 124917 RVA: 0x0044556D File Offset: 0x0044376D
		public static void StartIPipelineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E7F6 RID: 124918 RVA: 0x00445576 File Offset: 0x00443776
		public static void AddVoxelLevels(FlatBufferBuilder builder, VectorOffset voxelLevelsOffset)
		{
			builder.AddOffset(0, voxelLevelsOffset.Value, 0);
		}

		// Token: 0x0601E7F7 RID: 124919 RVA: 0x00445588 File Offset: 0x00443788
		public static VectorOffset CreateVoxelLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E7F8 RID: 124920 RVA: 0x004455BF File Offset: 0x004437BF
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E7F9 RID: 124921 RVA: 0x004455D9 File Offset: 0x004437D9
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E7FA RID: 124922 RVA: 0x004455F7 File Offset: 0x004437F7
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E7FB RID: 124923 RVA: 0x00445610 File Offset: 0x00443810
		public static void StartVoxelLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E7FC RID: 124924 RVA: 0x0044561B File Offset: 0x0044381B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601E7FD RID: 124925 RVA: 0x00445626 File Offset: 0x00443826
		public static Offset<IPipelineConfig> EndIPipelineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPipelineConfig>(builder.EndTable());
		}

		// Token: 0x0601E7FE RID: 124926 RVA: 0x00445634 File Offset: 0x00443834
		public IPipelineConfigT UnPack()
		{
			IPipelineConfigT pipelineConfigT = new IPipelineConfigT();
			this.UnPackTo(pipelineConfigT);
			return pipelineConfigT;
		}

		// Token: 0x0601E7FF RID: 124927 RVA: 0x00445650 File Offset: 0x00443850
		public void UnPackTo(IPipelineConfigT _o)
		{
			_o.VoxelLevels = new List<int>();
			for (int i = 0; i < this.VoxelLevelsLength; i++)
			{
				_o.VoxelLevels.Add(this.VoxelLevels(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E800 RID: 124928 RVA: 0x00445698 File Offset: 0x00443898
		public static Offset<IPipelineConfig> Pack(FlatBufferBuilder builder, IPipelineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPipelineConfig>);
			}
			VectorOffset voxelLevelsOffset = default(VectorOffset);
			if (_o.VoxelLevels != null)
			{
				int[] data = _o.VoxelLevels.ToArray();
				voxelLevelsOffset = IPipelineConfig.CreateVoxelLevelsVector(builder, data);
			}
			return IPipelineConfig.CreateIPipelineConfig(builder, voxelLevelsOffset, _o.NullMask);
		}

		// Token: 0x0400D8BE RID: 55486
		private Table __p;
	}
}
