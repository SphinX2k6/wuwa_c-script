using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005F00 RID: 24320
	public struct IStreamingGroup : IFlatbufferObject
	{
		// Token: 0x1700B5CD RID: 46541
		// (get) Token: 0x06029C5C RID: 171100 RVA: 0x005BB597 File Offset: 0x005B9797
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C5D RID: 171101 RVA: 0x005BB5A4 File Offset: 0x005B97A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C5E RID: 171102 RVA: 0x005BB5AC File Offset: 0x005B97AC
		public static IStreamingGroup GetRootAsIStreamingGroup(ByteBuffer _bb)
		{
			return IStreamingGroup.GetRootAsIStreamingGroup(_bb, default(IStreamingGroup));
		}

		// Token: 0x06029C5F RID: 171103 RVA: 0x005BB5C8 File Offset: 0x005B97C8
		public static IStreamingGroup GetRootAsIStreamingGroup(ByteBuffer _bb, IStreamingGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C60 RID: 171104 RVA: 0x005BB5E5 File Offset: 0x005B97E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C61 RID: 171105 RVA: 0x005BB5F4 File Offset: 0x005B97F4
		public IStreamingGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5CE RID: 46542
		// (get) Token: 0x06029C62 RID: 171106 RVA: 0x005BB604 File Offset: 0x005B9804
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

		// Token: 0x06029C63 RID: 171107 RVA: 0x005BB640 File Offset: 0x005B9840
		public IActorRef? RefData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5CF RID: 46543
		// (get) Token: 0x06029C64 RID: 171108 RVA: 0x005BB6A0 File Offset: 0x005B98A0
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

		// Token: 0x06029C65 RID: 171109 RVA: 0x005BB6CB File Offset: 0x005B98CB
		public static Offset<IStreamingGroup> CreateIStreamingGroup(FlatBufferBuilder builder, int EntityId = 0, VectorOffset RefDataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IStreamingGroup.AddRefData(builder, RefDataOffset);
			IStreamingGroup.AddEntityId(builder, EntityId);
			return IStreamingGroup.EndIStreamingGroup(builder);
		}

		// Token: 0x06029C66 RID: 171110 RVA: 0x005BB6E8 File Offset: 0x005B98E8
		public static void StartIStreamingGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029C67 RID: 171111 RVA: 0x005BB6F1 File Offset: 0x005B98F1
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06029C68 RID: 171112 RVA: 0x005BB6FC File Offset: 0x005B98FC
		public static void AddRefData(FlatBufferBuilder builder, VectorOffset refDataOffset)
		{
			builder.AddOffset(1, refDataOffset.Value, 0);
		}

		// Token: 0x06029C69 RID: 171113 RVA: 0x005BB70C File Offset: 0x005B990C
		public static VectorOffset CreateRefDataVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C6A RID: 171114 RVA: 0x005BB74C File Offset: 0x005B994C
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C6B RID: 171115 RVA: 0x005BB766 File Offset: 0x005B9966
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C6C RID: 171116 RVA: 0x005BB784 File Offset: 0x005B9984
		public static VectorOffset CreateRefDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C6D RID: 171117 RVA: 0x005BB79D File Offset: 0x005B999D
		public static void StartRefDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029C6E RID: 171118 RVA: 0x005BB7A8 File Offset: 0x005B99A8
		public static Offset<IStreamingGroup> EndIStreamingGroup(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingGroup>(builder.EndTable());
		}

		// Token: 0x06029C6F RID: 171119 RVA: 0x005BB7B8 File Offset: 0x005B99B8
		public IStreamingGroupT UnPack()
		{
			IStreamingGroupT streamingGroupT = new IStreamingGroupT();
			this.UnPackTo(streamingGroupT);
			return streamingGroupT;
		}

		// Token: 0x06029C70 RID: 171120 RVA: 0x005BB7D4 File Offset: 0x005B99D4
		public void UnPackTo(IStreamingGroupT _o)
		{
			_o.EntityId = this.EntityId;
			_o.RefData = new List<IActorRefT>();
			for (int i = 0; i < this.RefDataLength; i++)
			{
				_o.RefData.Add((this.RefData(i) != null) ? this.RefData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029C71 RID: 171121 RVA: 0x005BB840 File Offset: 0x005B9A40
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

		// Token: 0x0400FA05 RID: 64005
		private Table __p;
	}
}
