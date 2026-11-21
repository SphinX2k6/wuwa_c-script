using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x0200653D RID: 25917
	public struct ILevelRefData : IFlatbufferObject
	{
		// Token: 0x1700BF30 RID: 48944
		// (get) Token: 0x0602C2DA RID: 180954 RVA: 0x00604374 File Offset: 0x00602574
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2DB RID: 180955 RVA: 0x00604381 File Offset: 0x00602581
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2DC RID: 180956 RVA: 0x00604388 File Offset: 0x00602588
		public static ILevelRefData GetRootAsILevelRefData(ByteBuffer _bb)
		{
			return ILevelRefData.GetRootAsILevelRefData(_bb, default(ILevelRefData));
		}

		// Token: 0x0602C2DD RID: 180957 RVA: 0x006043A4 File Offset: 0x006025A4
		public static ILevelRefData GetRootAsILevelRefData(ByteBuffer _bb, ILevelRefData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2DE RID: 180958 RVA: 0x006043C1 File Offset: 0x006025C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2DF RID: 180959 RVA: 0x006043D0 File Offset: 0x006025D0
		public ILevelRefData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF31 RID: 48945
		// (get) Token: 0x0602C2E0 RID: 180960 RVA: 0x006043E0 File Offset: 0x006025E0
		public string LevelPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C2E1 RID: 180961 RVA: 0x00604417 File Offset: 0x00602617
		public Span<byte> GetLevelPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C2E2 RID: 180962 RVA: 0x00604426 File Offset: 0x00602626
		public byte[] GetLevelPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602C2E3 RID: 180963 RVA: 0x00604434 File Offset: 0x00602634
		public IStreamingGroup? StreamingGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IStreamingGroup?(default(IStreamingGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF32 RID: 48946
		// (get) Token: 0x0602C2E4 RID: 180964 RVA: 0x00604494 File Offset: 0x00602694
		public int StreamingGroupsLength
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

		// Token: 0x0602C2E5 RID: 180965 RVA: 0x006044BF File Offset: 0x006026BF
		public static Offset<ILevelRefData> CreateILevelRefData(FlatBufferBuilder builder, StringOffset LevelPathOffset = default(StringOffset), VectorOffset StreamingGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelRefData.AddStreamingGroups(builder, StreamingGroupsOffset);
			ILevelRefData.AddLevelPath(builder, LevelPathOffset);
			return ILevelRefData.EndILevelRefData(builder);
		}

		// Token: 0x0602C2E6 RID: 180966 RVA: 0x006044DC File Offset: 0x006026DC
		public static void StartILevelRefData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C2E7 RID: 180967 RVA: 0x006044E5 File Offset: 0x006026E5
		public static void AddLevelPath(FlatBufferBuilder builder, StringOffset levelPathOffset)
		{
			builder.AddOffset(0, levelPathOffset.Value, 0);
		}

		// Token: 0x0602C2E8 RID: 180968 RVA: 0x006044F5 File Offset: 0x006026F5
		public static void AddStreamingGroups(FlatBufferBuilder builder, VectorOffset streamingGroupsOffset)
		{
			builder.AddOffset(1, streamingGroupsOffset.Value, 0);
		}

		// Token: 0x0602C2E9 RID: 180969 RVA: 0x00604508 File Offset: 0x00602708
		public static VectorOffset CreateStreamingGroupsVector(FlatBufferBuilder builder, Offset<IStreamingGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C2EA RID: 180970 RVA: 0x00604548 File Offset: 0x00602748
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, Offset<IStreamingGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStreamingGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C2EB RID: 180971 RVA: 0x00604562 File Offset: 0x00602762
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStreamingGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStreamingGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C2EC RID: 180972 RVA: 0x00604580 File Offset: 0x00602780
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStreamingGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C2ED RID: 180973 RVA: 0x00604599 File Offset: 0x00602799
		public static void StartStreamingGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C2EE RID: 180974 RVA: 0x006045A4 File Offset: 0x006027A4
		public static Offset<ILevelRefData> EndILevelRefData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelRefData>(builder.EndTable());
		}

		// Token: 0x0602C2EF RID: 180975 RVA: 0x006045B4 File Offset: 0x006027B4
		public ILevelRefDataT UnPack()
		{
			ILevelRefDataT levelRefDataT = new ILevelRefDataT();
			this.UnPackTo(levelRefDataT);
			return levelRefDataT;
		}

		// Token: 0x0602C2F0 RID: 180976 RVA: 0x006045D0 File Offset: 0x006027D0
		public void UnPackTo(ILevelRefDataT _o)
		{
			_o.LevelPath = this.LevelPath;
			_o.StreamingGroups = new List<IStreamingGroupT>();
			for (int i = 0; i < this.StreamingGroupsLength; i++)
			{
				_o.StreamingGroups.Add((this.StreamingGroups(i) != null) ? this.StreamingGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C2F1 RID: 180977 RVA: 0x0060463C File Offset: 0x0060283C
		public static Offset<ILevelRefData> Pack(FlatBufferBuilder builder, ILevelRefDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelRefData>);
			}
			StringOffset levelPathOffset = (_o.LevelPath == null) ? default(StringOffset) : builder.CreateString(_o.LevelPath);
			VectorOffset streamingGroupsOffset = default(VectorOffset);
			if (_o.StreamingGroups != null)
			{
				Offset<IStreamingGroup>[] array = new Offset<IStreamingGroup>[_o.StreamingGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IStreamingGroup.Pack(builder, _o.StreamingGroups[i]);
				}
				streamingGroupsOffset = ILevelRefData.CreateStreamingGroupsVector(builder, array);
			}
			return ILevelRefData.CreateILevelRefData(builder, levelPathOffset, streamingGroupsOffset);
		}

		// Token: 0x04010764 RID: 67428
		private Table __p;
	}
}
