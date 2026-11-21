using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C1 RID: 2497
	[NetMessage(EMessageId.MessageDecodeFailNotify)]
	public sealed class MessageDecodeFailNotify : IMessage<MessageDecodeFailNotify>, IMessage, IEquatable<MessageDecodeFailNotify>, IDeepCloneable<MessageDecodeFailNotify>, IBufferMessage
	{
		// Token: 0x0600DB5D RID: 56157 RVA: 0x00203BDA File Offset: 0x00201DDA
		[NullableContext(1)]
		public static MessageDecodeFailNotify Create()
		{
			return new MessageDecodeFailNotify();
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600DB5E RID: 56158 RVA: 0x00203BE1 File Offset: 0x00201DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x00203BE4 File Offset: 0x00201DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageDecodeFailNotify.Descriptor;
			}
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x00203BEB File Offset: 0x00201DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageDecodeFailNotify()
		{
		}

		// Token: 0x0600DB61 RID: 56161 RVA: 0x00203C00 File Offset: 0x00201E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageDecodeFailNotify(MessageDecodeFailNotify other) : this()
		{
			this.code_ = other.code_;
			this.conv_ = other.conv_;
			this.channelId_ = other.channelId_;
			this.seqNo_ = other.seqNo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x00203C54 File Offset: 0x00201E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageDecodeFailNotify Clone()
		{
			return new MessageDecodeFailNotify(this);
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600DB63 RID: 56163 RVA: 0x00203C5C File Offset: 0x00201E5C
		// (set) Token: 0x0600DB64 RID: 56164 RVA: 0x00203C64 File Offset: 0x00201E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600DB65 RID: 56165 RVA: 0x00203C6D File Offset: 0x00201E6D
		// (set) Token: 0x0600DB66 RID: 56166 RVA: 0x00203C75 File Offset: 0x00201E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Conv
		{
			get
			{
				return this.conv_;
			}
			set
			{
				this.conv_ = value;
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600DB67 RID: 56167 RVA: 0x00203C7E File Offset: 0x00201E7E
		// (set) Token: 0x0600DB68 RID: 56168 RVA: 0x00203C86 File Offset: 0x00201E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600DB69 RID: 56169 RVA: 0x00203C99 File Offset: 0x00201E99
		// (set) Token: 0x0600DB6A RID: 56170 RVA: 0x00203CA1 File Offset: 0x00201EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeqNo
		{
			get
			{
				return this.seqNo_;
			}
			set
			{
				this.seqNo_ = value;
			}
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x00203CAA File Offset: 0x00201EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageDecodeFailNotify);
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x00203CB8 File Offset: 0x00201EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageDecodeFailNotify other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Conv == other.Conv && !(this.ChannelId != other.ChannelId) && this.SeqNo == other.SeqNo && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB6D RID: 56173 RVA: 0x00203D28 File Offset: 0x00201F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Conv != 0U)
			{
				num ^= this.Conv.GetHashCode();
			}
			if (this.ChannelId.Length != 0)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			if (this.SeqNo != 0)
			{
				num ^= this.SeqNo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB6E RID: 56174 RVA: 0x00203DBA File Offset: 0x00201FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x00203DC7 File Offset: 0x00201FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x00203DD0 File Offset: 0x00201FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Conv != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Conv);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this.ChannelId.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ChannelId);
			}
			if (this.SeqNo != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SeqNo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x00203E68 File Offset: 0x00202068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Conv != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Conv);
			}
			if (this.ChannelId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelId);
			}
			if (this.SeqNo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeqNo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x00203EF4 File Offset: 0x002020F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageDecodeFailNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Conv != 0U)
			{
				this.Conv = other.Conv;
			}
			if (other.ChannelId.Length != 0)
			{
				this.ChannelId = other.ChannelId;
			}
			if (other.SeqNo != 0)
			{
				this.SeqNo = other.SeqNo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x00203F71 File Offset: 0x00202171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x00203F7C File Offset: 0x0020217C
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.Conv = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.ChannelId = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.SeqNo = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B5C RID: 23388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B5D RID: 23389
		public const int CodeFieldNumber = 8;

		// Token: 0x04005B5E RID: 23390
		private ErrorCode code_;

		// Token: 0x04005B5F RID: 23391
		public const int ConvFieldNumber = 2;

		// Token: 0x04005B60 RID: 23392
		private uint conv_;

		// Token: 0x04005B61 RID: 23393
		public const int ChannelIdFieldNumber = 11;

		// Token: 0x04005B62 RID: 23394
		private string channelId_ = "";

		// Token: 0x04005B63 RID: 23395
		public const int SeqNoFieldNumber = 13;

		// Token: 0x04005B64 RID: 23396
		private int seqNo_;
	}
}
