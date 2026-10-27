using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004898 RID: 18584
	public struct IPipelineConfig : IFlatbufferObject
	{
		// Token: 0x170086C6 RID: 34502
		// (get) Token: 0x0601CFFC RID: 118780 RVA: 0x00418C84 File Offset: 0x00416E84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x00418C91 File Offset: 0x00416E91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x00418C98 File Offset: 0x00416E98
		public static IPipelineConfig GetRootAsIPipelineConfig(ByteBuffer _bb)
		{
			return IPipelineConfig.GetRootAsIPipelineConfig(_bb, default(IPipelineConfig));
		}

		// Token: 0x0601CFFF RID: 118783 RVA: 0x00418CB4 File Offset: 0x00416EB4
		public static IPipelineConfig GetRootAsIPipelineConfig(ByteBuffer _bb, IPipelineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D000 RID: 118784 RVA: 0x00418CD1 File Offset: 0x00416ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D001 RID: 118785 RVA: 0x00418CE0 File Offset: 0x00416EE0
		public IPipelineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D002 RID: 118786 RVA: 0x00418CF0 File Offset: 0x00416EF0
		public int VoxelLevels(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170086C7 RID: 34503
		// (get) Token: 0x0601D003 RID: 118787 RVA: 0x00418D30 File Offset: 0x00416F30
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

		// Token: 0x0601D004 RID: 118788 RVA: 0x00418D5B File Offset: 0x00416F5B
		public Span<int> GetVoxelLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601D005 RID: 118789 RVA: 0x00418D6A File Offset: 0x00416F6A
		public int[] GetVoxelLevelsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x170086C8 RID: 34504
		// (get) Token: 0x0601D006 RID: 118790 RVA: 0x00418D78 File Offset: 0x00416F78
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

		// Token: 0x0601D007 RID: 118791 RVA: 0x00418DB4 File Offset: 0x00416FB4
		public static Offset<IPipelineConfig> CreateIPipelineConfig(FlatBufferBuilder builder, VectorOffset VoxelLevelsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IPipelineConfig.AddVoxelLevels(builder, VoxelLevelsOffset);
			IPipelineConfig.AddNullMask(builder, NullMask);
			return IPipelineConfig.EndIPipelineConfig(builder);
		}

		// Token: 0x0601D008 RID: 118792 RVA: 0x00418DD1 File Offset: 0x00416FD1
		public static void StartIPipelineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D009 RID: 118793 RVA: 0x00418DDA File Offset: 0x00416FDA
		public static void AddVoxelLevels(FlatBufferBuilder builder, VectorOffset voxelLevelsOffset)
		{
			builder.AddOffset(0, voxelLevelsOffset.Value, 0);
		}

		// Token: 0x0601D00A RID: 118794 RVA: 0x00418DEC File Offset: 0x00416FEC
		public static VectorOffset CreateVoxelLevelsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D00B RID: 118795 RVA: 0x00418E23 File Offset: 0x00417023
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D00C RID: 118796 RVA: 0x00418E3D File Offset: 0x0041703D
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D00D RID: 118797 RVA: 0x00418E5B File Offset: 0x0041705B
		public static VectorOffset CreateVoxelLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D00E RID: 118798 RVA: 0x00418E74 File Offset: 0x00417074
		public static void StartVoxelLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D00F RID: 118799 RVA: 0x00418E7F File Offset: 0x0041707F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601D010 RID: 118800 RVA: 0x00418E8A File Offset: 0x0041708A
		public static Offset<IPipelineConfig> EndIPipelineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPipelineConfig>(builder.EndTable());
		}

		// Token: 0x0601D011 RID: 118801 RVA: 0x00418E98 File Offset: 0x00417098
		public IPipelineConfigT UnPack()
		{
			IPipelineConfigT pipelineConfigT = new IPipelineConfigT();
			this.UnPackTo(pipelineConfigT);
			return pipelineConfigT;
		}

		// Token: 0x0601D012 RID: 118802 RVA: 0x00418EB4 File Offset: 0x004170B4
		public void UnPackTo(IPipelineConfigT _o)
		{
			_o.VoxelLevels = new List<int>();
			for (int i = 0; i < this.VoxelLevelsLength; i++)
			{
				_o.VoxelLevels.Add(this.VoxelLevels(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D013 RID: 118803 RVA: 0x00418EFC File Offset: 0x004170FC
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

		// Token: 0x0400CE85 RID: 52869
		private Table __p;
	}
}
