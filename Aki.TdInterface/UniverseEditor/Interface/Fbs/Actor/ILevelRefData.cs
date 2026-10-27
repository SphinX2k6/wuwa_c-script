using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFA RID: 24314
	public struct ILevelRefData : IFlatbufferObject
	{
		// Token: 0x1700B5C5 RID: 46533
		// (get) Token: 0x06029C26 RID: 171046 RVA: 0x005BAE90 File Offset: 0x005B9090
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C27 RID: 171047 RVA: 0x005BAE9D File Offset: 0x005B909D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C28 RID: 171048 RVA: 0x005BAEA4 File Offset: 0x005B90A4
		public static ILevelRefData GetRootAsILevelRefData(ByteBuffer _bb)
		{
			return ILevelRefData.GetRootAsILevelRefData(_bb, default(ILevelRefData));
		}

		// Token: 0x06029C29 RID: 171049 RVA: 0x005BAEC0 File Offset: 0x005B90C0
		public static ILevelRefData GetRootAsILevelRefData(ByteBuffer _bb, ILevelRefData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C2A RID: 171050 RVA: 0x005BAEDD File Offset: 0x005B90DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C2B RID: 171051 RVA: 0x005BAEEC File Offset: 0x005B90EC
		public ILevelRefData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5C6 RID: 46534
		// (get) Token: 0x06029C2C RID: 171052 RVA: 0x005BAEFC File Offset: 0x005B90FC
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

		// Token: 0x06029C2D RID: 171053 RVA: 0x005BAF33 File Offset: 0x005B9133
		public Span<byte> GetLevelPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029C2E RID: 171054 RVA: 0x005BAF42 File Offset: 0x005B9142
		public byte[] GetLevelPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06029C2F RID: 171055 RVA: 0x005BAF50 File Offset: 0x005B9150
		public IStreamingGroup? StreamingGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IStreamingGroup?(default(IStreamingGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5C7 RID: 46535
		// (get) Token: 0x06029C30 RID: 171056 RVA: 0x005BAFB0 File Offset: 0x005B91B0
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

		// Token: 0x06029C31 RID: 171057 RVA: 0x005BAFDB File Offset: 0x005B91DB
		public static Offset<ILevelRefData> CreateILevelRefData(FlatBufferBuilder builder, StringOffset LevelPathOffset = default(StringOffset), VectorOffset StreamingGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelRefData.AddStreamingGroups(builder, StreamingGroupsOffset);
			ILevelRefData.AddLevelPath(builder, LevelPathOffset);
			return ILevelRefData.EndILevelRefData(builder);
		}

		// Token: 0x06029C32 RID: 171058 RVA: 0x005BAFF8 File Offset: 0x005B91F8
		public static void StartILevelRefData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029C33 RID: 171059 RVA: 0x005BB001 File Offset: 0x005B9201
		public static void AddLevelPath(FlatBufferBuilder builder, StringOffset levelPathOffset)
		{
			builder.AddOffset(0, levelPathOffset.Value, 0);
		}

		// Token: 0x06029C34 RID: 171060 RVA: 0x005BB011 File Offset: 0x005B9211
		public static void AddStreamingGroups(FlatBufferBuilder builder, VectorOffset streamingGroupsOffset)
		{
			builder.AddOffset(1, streamingGroupsOffset.Value, 0);
		}

		// Token: 0x06029C35 RID: 171061 RVA: 0x005BB024 File Offset: 0x005B9224
		public static VectorOffset CreateStreamingGroupsVector(FlatBufferBuilder builder, Offset<IStreamingGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C36 RID: 171062 RVA: 0x005BB064 File Offset: 0x005B9264
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, Offset<IStreamingGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStreamingGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C37 RID: 171063 RVA: 0x005BB07E File Offset: 0x005B927E
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStreamingGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStreamingGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C38 RID: 171064 RVA: 0x005BB09C File Offset: 0x005B929C
		public static VectorOffset CreateStreamingGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStreamingGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C39 RID: 171065 RVA: 0x005BB0B5 File Offset: 0x005B92B5
		public static void StartStreamingGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029C3A RID: 171066 RVA: 0x005BB0C0 File Offset: 0x005B92C0
		public static Offset<ILevelRefData> EndILevelRefData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelRefData>(builder.EndTable());
		}

		// Token: 0x06029C3B RID: 171067 RVA: 0x005BB0D0 File Offset: 0x005B92D0
		public ILevelRefDataT UnPack()
		{
			ILevelRefDataT levelRefDataT = new ILevelRefDataT();
			this.UnPackTo(levelRefDataT);
			return levelRefDataT;
		}

		// Token: 0x06029C3C RID: 171068 RVA: 0x005BB0EC File Offset: 0x005B92EC
		public void UnPackTo(ILevelRefDataT _o)
		{
			_o.LevelPath = this.LevelPath;
			_o.StreamingGroups = new List<IStreamingGroupT>();
			for (int i = 0; i < this.StreamingGroupsLength; i++)
			{
				_o.StreamingGroups.Add((this.StreamingGroups(i) != null) ? this.StreamingGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029C3D RID: 171069 RVA: 0x005BB158 File Offset: 0x005B9358
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

		// Token: 0x0400FA00 RID: 64000
		private Table __p;
	}
}
