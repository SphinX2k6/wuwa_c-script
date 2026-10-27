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
		// Token: 0x060011B6 RID: 4534 RVA: 0x000314AF File Offset: 0x0002F6AF
		[NullableContext(1)]
		public static AbyssLikeRecord Create()
		{
			return new AbyssLikeRecord();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000314B6 File Offset: 0x0002F6B6
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
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000314BD File Offset: 0x0002F6BD
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
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000314C0 File Offset: 0x0002F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeRecord.Descriptor;
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000314C7 File Offset: 0x0002F6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord()
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000314DA File Offset: 0x0002F6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord(AbyssLikeRecord other) : this()
		{
			this.playerId_ = other.playerId_;
			this.likedPlayerId_ = other.likedPlayerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00031510 File Offset: 0x0002F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRecord Clone()
		{
			return new AbyssLikeRecord(this);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00031518 File Offset: 0x0002F718
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x00031520 File Offset: 0x0002F720
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
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00031529 File Offset: 0x0002F729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LikedPlayerId
		{
			get
			{
				return this.likedPlayerId_;
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00031531 File Offset: 0x0002F731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeRecord);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00031540 File Offset: 0x0002F740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeRecord other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.likedPlayerId_.Equals(other.likedPlayerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00031590 File Offset: 0x0002F790
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

		// Token: 0x060011C3 RID: 4547 RVA: 0x000315DD File Offset: 0x0002F7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000315EA File Offset: 0x0002F7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000315F4 File Offset: 0x0002F7F4
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

		// Token: 0x060011C6 RID: 4550 RVA: 0x00031644 File Offset: 0x0002F844
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

		// Token: 0x060011C7 RID: 4551 RVA: 0x00031698 File Offset: 0x0002F898
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

		// Token: 0x060011C8 RID: 4552 RVA: 0x000316E5 File Offset: 0x0002F8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000316F0 File Offset: 0x0002F8F0
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

		// Token: 0x04001F9A RID: 8090
		private static readonly MessageParser<AbyssLikeRecord> _parser = new MessageParser<AbyssLikeRecord>(() => new AbyssLikeRecord());

		// Token: 0x04001F9B RID: 8091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F9C RID: 8092
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001F9D RID: 8093
		private int playerId_;

		// Token: 0x04001F9E RID: 8094
		public const int LikedPlayerIdFieldNumber = 2;

		// Token: 0x04001F9F RID: 8095
		private static readonly FieldCodec<int> _repeated_likedPlayerId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04001FA0 RID: 8096
		private readonly RepeatedField<int> likedPlayerId_ = new RepeatedField<int>();
	}
}
