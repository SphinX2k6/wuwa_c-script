using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2E RID: 3118
	[NetMessage(EMessageId.PhantomBattleBvBLoadingNotify)]
	public sealed class PhantomBattleBvBLoadingNotify : IMessage<PhantomBattleBvBLoadingNotify>, IMessage, IEquatable<PhantomBattleBvBLoadingNotify>, IDeepCloneable<PhantomBattleBvBLoadingNotify>, IBufferMessage
	{
		// Token: 0x06010EDE RID: 69342 RVA: 0x0027ABF1 File Offset: 0x00278DF1
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingNotify Create()
		{
			return new PhantomBattleBvBLoadingNotify();
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x06010EDF RID: 69343 RVA: 0x0027ABF8 File Offset: 0x00278DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x06010EE0 RID: 69344 RVA: 0x0027ABFB File Offset: 0x00278DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingNotify.Descriptor;
			}
		}

		// Token: 0x06010EE1 RID: 69345 RVA: 0x0027AC02 File Offset: 0x00278E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify()
		{
		}

		// Token: 0x06010EE2 RID: 69346 RVA: 0x0027AC20 File Offset: 0x00278E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify(PhantomBattleBvBLoadingNotify other) : this()
		{
			this.npcMonsterEntityIncId_ = other.npcMonsterEntityIncId_.Clone();
			this.playerMonsterEntityIncId_ = other.playerMonsterEntityIncId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EE3 RID: 69347 RVA: 0x0027AC5B File Offset: 0x00278E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify Clone()
		{
			return new PhantomBattleBvBLoadingNotify(this);
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x06010EE4 RID: 69348 RVA: 0x0027AC63 File Offset: 0x00278E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> NpcMonsterEntityIncId
		{
			get
			{
				return this.npcMonsterEntityIncId_;
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x06010EE5 RID: 69349 RVA: 0x0027AC6B File Offset: 0x00278E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> PlayerMonsterEntityIncId
		{
			get
			{
				return this.playerMonsterEntityIncId_;
			}
		}

		// Token: 0x06010EE6 RID: 69350 RVA: 0x0027AC73 File Offset: 0x00278E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingNotify);
		}

		// Token: 0x06010EE7 RID: 69351 RVA: 0x0027AC84 File Offset: 0x00278E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingNotify other)
		{
			return other != null && (other == this || (this.NpcMonsterEntityIncId.Equals(other.NpcMonsterEntityIncId) && this.PlayerMonsterEntityIncId.Equals(other.PlayerMonsterEntityIncId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010EE8 RID: 69352 RVA: 0x0027ACD8 File Offset: 0x00278ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.NpcMonsterEntityIncId.GetHashCode();
			num ^= this.PlayerMonsterEntityIncId.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010EE9 RID: 69353 RVA: 0x0027AD1A File Offset: 0x00278F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EEA RID: 69354 RVA: 0x0027AD27 File Offset: 0x00278F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EEB RID: 69355 RVA: 0x0027AD30 File Offset: 0x00278F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerMonsterEntityIncId_.WriteTo(ref output, PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
			this.npcMonsterEntityIncId_.WriteTo(ref output, PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EEC RID: 69356 RVA: 0x0027AD68 File Offset: 0x00278F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcMonsterEntityIncId_.CalculateSize(PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
			num += this.playerMonsterEntityIncId_.CalculateSize(PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010EED RID: 69357 RVA: 0x0027ADB4 File Offset: 0x00278FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.npcMonsterEntityIncId_.MergeFrom(other.npcMonsterEntityIncId_);
			this.playerMonsterEntityIncId_.MergeFrom(other.playerMonsterEntityIncId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010EEE RID: 69358 RVA: 0x0027ADF3 File Offset: 0x00278FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EEF RID: 69359 RVA: 0x0027ADFC File Offset: 0x00278FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 66U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.npcMonsterEntityIncId_.AddEntriesFrom(ref input, PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
					}
				}
				else
				{
					this.playerMonsterEntityIncId_.AddEntriesFrom(ref input, PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
				}
			}
		}

		// Token: 0x04006BB8 RID: 27576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BB9 RID: 27577
		public const int NpcMonsterEntityIncIdFieldNumber = 15;

		// Token: 0x04006BBA RID: 27578
		private static readonly MapField<int, long>.Codec _map_npcMonsterEntityIncId_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 122U);

		// Token: 0x04006BBB RID: 27579
		private readonly MapField<int, long> npcMonsterEntityIncId_ = new MapField<int, long>();

		// Token: 0x04006BBC RID: 27580
		public const int PlayerMonsterEntityIncIdFieldNumber = 8;

		// Token: 0x04006BBD RID: 27581
		private static readonly MapField<int, long>.Codec _map_playerMonsterEntityIncId_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 66U);

		// Token: 0x04006BBE RID: 27582
		private readonly MapField<int, long> playerMonsterEntityIncId_ = new MapField<int, long>();
	}
}
