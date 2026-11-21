using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FDE RID: 24542
	public struct IStreamingRtEffectRef : IFlatbufferObject
	{
		// Token: 0x1700B5FC RID: 46588
		// (get) Token: 0x06029590 RID: 169360 RVA: 0x005A52EB File Offset: 0x005A34EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029591 RID: 169361 RVA: 0x005A52F8 File Offset: 0x005A34F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029592 RID: 169362 RVA: 0x005A5300 File Offset: 0x005A3500
		public static IStreamingRtEffectRef GetRootAsIStreamingRtEffectRef(ByteBuffer _bb)
		{
			return IStreamingRtEffectRef.GetRootAsIStreamingRtEffectRef(_bb, default(IStreamingRtEffectRef));
		}

		// Token: 0x06029593 RID: 169363 RVA: 0x005A531C File Offset: 0x005A351C
		public static IStreamingRtEffectRef GetRootAsIStreamingRtEffectRef(ByteBuffer _bb, IStreamingRtEffectRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029594 RID: 169364 RVA: 0x005A5339 File Offset: 0x005A3539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029595 RID: 169365 RVA: 0x005A5348 File Offset: 0x005A3548
		public IStreamingRtEffectRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5FD RID: 46589
		// (get) Token: 0x06029596 RID: 169366 RVA: 0x005A5358 File Offset: 0x005A3558
		public string ActorRefKey
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

		// Token: 0x06029597 RID: 169367 RVA: 0x005A538F File Offset: 0x005A358F
		public Span<byte> GetActorRefKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029598 RID: 169368 RVA: 0x005A539E File Offset: 0x005A359E
		public byte[] GetActorRefKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06029599 RID: 169369 RVA: 0x005A53AC File Offset: 0x005A35AC
		public static Offset<IStreamingRtEffectRef> CreateIStreamingRtEffectRef(FlatBufferBuilder builder, StringOffset ActorRefKeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IStreamingRtEffectRef.AddActorRefKey(builder, ActorRefKeyOffset);
			return IStreamingRtEffectRef.EndIStreamingRtEffectRef(builder);
		}

		// Token: 0x0602959A RID: 169370 RVA: 0x005A53C2 File Offset: 0x005A35C2
		public static void StartIStreamingRtEffectRef(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602959B RID: 169371 RVA: 0x005A53CB File Offset: 0x005A35CB
		public static void AddActorRefKey(FlatBufferBuilder builder, StringOffset actorRefKeyOffset)
		{
			builder.AddOffset(0, actorRefKeyOffset.Value, 0);
		}

		// Token: 0x0602959C RID: 169372 RVA: 0x005A53DB File Offset: 0x005A35DB
		public static Offset<IStreamingRtEffectRef> EndIStreamingRtEffectRef(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingRtEffectRef>(builder.EndTable());
		}

		// Token: 0x0602959D RID: 169373 RVA: 0x005A53E8 File Offset: 0x005A35E8
		public IStreamingRtEffectRefT UnPack()
		{
			IStreamingRtEffectRefT streamingRtEffectRefT = new IStreamingRtEffectRefT();
			this.UnPackTo(streamingRtEffectRefT);
			return streamingRtEffectRefT;
		}

		// Token: 0x0602959E RID: 169374 RVA: 0x005A5403 File Offset: 0x005A3603
		public void UnPackTo(IStreamingRtEffectRefT _o)
		{
			_o.ActorRefKey = this.ActorRefKey;
		}

		// Token: 0x0602959F RID: 169375 RVA: 0x005A5414 File Offset: 0x005A3614
		public static Offset<IStreamingRtEffectRef> Pack(FlatBufferBuilder builder, IStreamingRtEffectRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingRtEffectRef>);
			}
			StringOffset actorRefKeyOffset = (_o.ActorRefKey == null) ? default(StringOffset) : builder.CreateString(_o.ActorRefKey);
			return IStreamingRtEffectRef.CreateIStreamingRtEffectRef(builder, actorRefKeyOffset);
		}

		// Token: 0x0400FCFC RID: 64764
		private Table __p;
	}
}
