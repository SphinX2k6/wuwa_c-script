using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D1 RID: 22993
	public struct IStreamingRtEffectRef : IFlatbufferObject
	{
		// Token: 0x1700ACC4 RID: 44228
		// (get) Token: 0x06027018 RID: 159768 RVA: 0x0055E327 File Offset: 0x0055C527
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027019 RID: 159769 RVA: 0x0055E334 File Offset: 0x0055C534
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602701A RID: 159770 RVA: 0x0055E33C File Offset: 0x0055C53C
		public static IStreamingRtEffectRef GetRootAsIStreamingRtEffectRef(ByteBuffer _bb)
		{
			return IStreamingRtEffectRef.GetRootAsIStreamingRtEffectRef(_bb, default(IStreamingRtEffectRef));
		}

		// Token: 0x0602701B RID: 159771 RVA: 0x0055E358 File Offset: 0x0055C558
		public static IStreamingRtEffectRef GetRootAsIStreamingRtEffectRef(ByteBuffer _bb, IStreamingRtEffectRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602701C RID: 159772 RVA: 0x0055E375 File Offset: 0x0055C575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602701D RID: 159773 RVA: 0x0055E384 File Offset: 0x0055C584
		public IStreamingRtEffectRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACC5 RID: 44229
		// (get) Token: 0x0602701E RID: 159774 RVA: 0x0055E394 File Offset: 0x0055C594
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

		// Token: 0x0602701F RID: 159775 RVA: 0x0055E3CB File Offset: 0x0055C5CB
		public Span<byte> GetActorRefKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027020 RID: 159776 RVA: 0x0055E3DA File Offset: 0x0055C5DA
		public byte[] GetActorRefKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06027021 RID: 159777 RVA: 0x0055E3E8 File Offset: 0x0055C5E8
		public static Offset<IStreamingRtEffectRef> CreateIStreamingRtEffectRef(FlatBufferBuilder builder, StringOffset ActorRefKeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IStreamingRtEffectRef.AddActorRefKey(builder, ActorRefKeyOffset);
			return IStreamingRtEffectRef.EndIStreamingRtEffectRef(builder);
		}

		// Token: 0x06027022 RID: 159778 RVA: 0x0055E3FE File Offset: 0x0055C5FE
		public static void StartIStreamingRtEffectRef(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027023 RID: 159779 RVA: 0x0055E407 File Offset: 0x0055C607
		public static void AddActorRefKey(FlatBufferBuilder builder, StringOffset actorRefKeyOffset)
		{
			builder.AddOffset(0, actorRefKeyOffset.Value, 0);
		}

		// Token: 0x06027024 RID: 159780 RVA: 0x0055E417 File Offset: 0x0055C617
		public static Offset<IStreamingRtEffectRef> EndIStreamingRtEffectRef(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingRtEffectRef>(builder.EndTable());
		}

		// Token: 0x06027025 RID: 159781 RVA: 0x0055E424 File Offset: 0x0055C624
		public IStreamingRtEffectRefT UnPack()
		{
			IStreamingRtEffectRefT streamingRtEffectRefT = new IStreamingRtEffectRefT();
			this.UnPackTo(streamingRtEffectRefT);
			return streamingRtEffectRefT;
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x0055E43F File Offset: 0x0055C63F
		public void UnPackTo(IStreamingRtEffectRefT _o)
		{
			_o.ActorRefKey = this.ActorRefKey;
		}

		// Token: 0x06027027 RID: 159783 RVA: 0x0055E450 File Offset: 0x0055C650
		public static Offset<IStreamingRtEffectRef> Pack(FlatBufferBuilder builder, IStreamingRtEffectRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingRtEffectRef>);
			}
			StringOffset actorRefKeyOffset = (_o.ActorRefKey == null) ? default(StringOffset) : builder.CreateString(_o.ActorRefKey);
			return IStreamingRtEffectRef.CreateIStreamingRtEffectRef(builder, actorRefKeyOffset);
		}

		// Token: 0x0400F005 RID: 61445
		private Table __p;
	}
}
