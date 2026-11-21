using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000028 RID: 40
	public sealed class AbyssLikeRecord : IMessage<AbyssLikeRecord>, IMessage, IEquatable<AbyssLikeRecord>, IDeepCloneable<AbyssLikeRecord>, IBufferMessage
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x00031A63 File Offset: 0x0002FC63
		[NullableContext(1)]
		public static AbyssLikeRecord Create()
		{
			return new AbyssLikeRecord();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00031A6A File Offset: 0x0002FC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssLikeRecord> Parser
		{
			get
			{
				return AbyssLikeRecord._parser;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00031A71 File Offset: 0x0002FC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00031A74 File Offset: 0x0002FC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeRecord.Descriptor;
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00031A7B File Offset: 0x0002FC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord()
		{
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00031A8E File Offset: 0x0002FC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord(AbyssLikeRecord other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likedPlayerId_ = other.likedPlayerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00031AC4 File Offset: 0x0002FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord Clone()
		{
			return new AbyssLikeRecord(this);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00031ACC File Offset: 0x0002FCCC
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00031ADD File Offset: 0x0002FCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LikedPlayerId
		{
			get
			{
				return this.likedPlayerId_;
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00031AE5 File Offset: 0x0002FCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeRecord);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00031AF4 File Offset: 0x0002FCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeRecord other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.likedPlayerId_.Equals(other.likedPlayerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00031B44 File Offset: 0x0002FD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.likedPlayerId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00031B91 File Offset: 0x0002FD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00031B9E File Offset: 0x0002FD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.likedPlayerId_.WriteTo(ref output, AbyssLikeRecord._repeated_likedPlayerId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.likedPlayerId_.CalculateSize(AbyssLikeRecord._repeated_likedPlayerId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00031C4C File Offset: 0x0002FE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.likedPlayerId_.Add(other.likedPlayerId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00031C99 File Offset: 0x0002FE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00031CA4 File Offset: 0x0002FEA4
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.likedPlayerId_.AddEntriesFrom(ref input, AbyssLikeRecord._repeated_likedPlayerId_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FF0 RID: 8176
		private static readonly MessageParser<AbyssLikeRecord> _parser = new MessageParser<AbyssLikeRecord>(() => new AbyssLikeRecord());

		// Token: 0x04001FF1 RID: 8177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF2 RID: 8178
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001FF3 RID: 8179
		private int playerId_;

		// Token: 0x04001FF4 RID: 8180
		public const int LikedPlayerIdFieldNumber = 2;

		// Token: 0x04001FF5 RID: 8181
		private static readonly FieldCodec<int> _repeated_likedPlayerId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04001FF6 RID: 8182
		private readonly RepeatedField<int> likedPlayerId_ = new RepeatedField<int>();
	}
}
