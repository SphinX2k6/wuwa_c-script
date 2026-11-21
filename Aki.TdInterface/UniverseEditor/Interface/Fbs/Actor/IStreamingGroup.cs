using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006543 RID: 25923
	public struct IStreamingGroup : IFlatbufferObject
	{
		// Token: 0x1700BF38 RID: 48952
		// (get) Token: 0x0602C310 RID: 181008 RVA: 0x00604A7B File Offset: 0x00602C7B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C311 RID: 181009 RVA: 0x00604A88 File Offset: 0x00602C88
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C312 RID: 181010 RVA: 0x00604A90 File Offset: 0x00602C90
		public static IStreamingGroup GetRootAsIStreamingGroup(ByteBuffer _bb)
		{
			return IStreamingGroup.GetRootAsIStreamingGroup(_bb, default(IStreamingGroup));
		}

		// Token: 0x0602C313 RID: 181011 RVA: 0x00604AAC File Offset: 0x00602CAC
		public static IStreamingGroup GetRootAsIStreamingGroup(ByteBuffer _bb, IStreamingGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C314 RID: 181012 RVA: 0x00604AC9 File Offset: 0x00602CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C315 RID: 181013 RVA: 0x00604AD8 File Offset: 0x00602CD8
		public IStreamingGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF39 RID: 48953
		// (get) Token: 0x0602C316 RID: 181014 RVA: 0x00604AE8 File Offset: 0x00602CE8
		public int EntityId
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

		// Token: 0x0602C317 RID: 181015 RVA: 0x00604B24 File Offset: 0x00602D24
		public IActorRef? RefData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF3A RID: 48954
		// (get) Token: 0x0602C318 RID: 181016 RVA: 0x00604B84 File Offset: 0x00602D84
		public int RefDataLength
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

		// Token: 0x0602C319 RID: 181017 RVA: 0x00604BAF File Offset: 0x00602DAF
		public static Offset<IStreamingGroup> CreateIStreamingGroup(FlatBufferBuilder builder, int EntityId = 0, VectorOffset RefDataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IStreamingGroup.AddRefData(builder, RefDataOffset);
			IStreamingGroup.AddEntityId(builder, EntityId);
			return IStreamingGroup.EndIStreamingGroup(builder);
		}

		// Token: 0x0602C31A RID: 181018 RVA: 0x00604BCC File Offset: 0x00602DCC
		public static void StartIStreamingGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C31B RID: 181019 RVA: 0x00604BD5 File Offset: 0x00602DD5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602C31C RID: 181020 RVA: 0x00604BE0 File Offset: 0x00602DE0
		public static void AddRefData(FlatBufferBuilder builder, VectorOffset refDataOffset)
		{
			builder.AddOffset(1, refDataOffset.Value, 0);
		}

		// Token: 0x0602C31D RID: 181021 RVA: 0x00604BF0 File Offset: 0x00602DF0
		public static VectorOffset CreateRefDataVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C31E RID: 181022 RVA: 0x00604C30 File Offset: 0x00602E30
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C31F RID: 181023 RVA: 0x00604C4A File Offset: 0x00602E4A
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C320 RID: 181024 RVA: 0x00604C68 File Offset: 0x00602E68
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C321 RID: 181025 RVA: 0x00604C81 File Offset: 0x00602E81
		public static void StartRefDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C322 RID: 181026 RVA: 0x00604C8C File Offset: 0x00602E8C
		public static Offset<IStreamingGroup> EndIStreamingGroup(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingGroup>(builder.EndTable());
		}

		// Token: 0x0602C323 RID: 181027 RVA: 0x00604C9C File Offset: 0x00602E9C
		public IStreamingGroupT UnPack()
		{
			IStreamingGroupT streamingGroupT = new IStreamingGroupT();
			this.UnPackTo(streamingGroupT);
			return streamingGroupT;
		}

		// Token: 0x0602C324 RID: 181028 RVA: 0x00604CB8 File Offset: 0x00602EB8
		public void UnPackTo(IStreamingGroupT _o)
		{
			_o.EntityId = this.EntityId;
			_o.RefData = new List<IActorRefT>();
			for (int i = 0; i < this.RefDataLength; i++)
			{
				_o.RefData.Add((this.RefData(i) != null) ? this.RefData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C325 RID: 181029 RVA: 0x00604D24 File Offset: 0x00602F24
		public static Offset<IStreamingGroup> Pack(FlatBufferBuilder builder, IStreamingGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingGroup>);
			}
			VectorOffset refDataOffset = default(VectorOffset);
			if (_o.RefData != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.RefData.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.RefData[i]);
				}
				refDataOffset = IStreamingGroup.CreateRefDataVector(builder, array);
			}
			return IStreamingGroup.CreateIStreamingGroup(builder, _o.EntityId, refDataOffset);
		}

		// Token: 0x04010769 RID: 67433
		private Table __p;
	}
}
