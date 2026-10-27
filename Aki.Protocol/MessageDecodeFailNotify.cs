using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D2 RID: 2514
	[NetMessage(EMessageId.MessageDecodeFailNotify)]
	public sealed class MessageDecodeFailNotify : IMessage<MessageDecodeFailNotify>, IMessage, IEquatable<MessageDecodeFailNotify>, IDeepCloneable<MessageDecodeFailNotify>, IBufferMessage
	{
		// Token: 0x0600DC77 RID: 56439 RVA: 0x00205DCA File Offset: 0x00203FCA
		[NullableContext(1)]
		public static MessageDecodeFailNotify Create()
		{
			return new MessageDecodeFailNotify();
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600DC78 RID: 56440 RVA: 0x00205DD1 File Offset: 0x00203FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x00205DD4 File Offset: 0x00203FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageDecodeFailNotify.Descriptor;
			}
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00205DDB File Offset: 0x00203FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageDecodeFailNotify()
		{
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00205DF0 File Offset: 0x00203FF0
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

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00205E44 File Offset: 0x00204044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageDecodeFailNotify Clone()
		{
			return new MessageDecodeFailNotify(this);
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x00205E4C File Offset: 0x0020404C
		// (set) Token: 0x0600DC7E RID: 56446 RVA: 0x00205E54 File Offset: 0x00204054
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

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x00205E5D File Offset: 0x0020405D
		// (set) Token: 0x0600DC80 RID: 56448 RVA: 0x00205E65 File Offset: 0x00204065
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

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0600DC81 RID: 56449 RVA: 0x00205E6E File Offset: 0x0020406E
		// (set) Token: 0x0600DC82 RID: 56450 RVA: 0x00205E76 File Offset: 0x00204076
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

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0600DC83 RID: 56451 RVA: 0x00205E89 File Offset: 0x00204089
		// (set) Token: 0x0600DC84 RID: 56452 RVA: 0x00205E91 File Offset: 0x00204091
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

		// Token: 0x0600DC85 RID: 56453 RVA: 0x00205E9A File Offset: 0x0020409A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageDecodeFailNotify);
		}

		// Token: 0x0600DC86 RID: 56454 RVA: 0x00205EA8 File Offset: 0x002040A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageDecodeFailNotify other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Conv == other.Conv && !(this.ChannelId != other.ChannelId) && this.SeqNo == other.SeqNo && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC87 RID: 56455 RVA: 0x00205F18 File Offset: 0x00204118
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

		// Token: 0x0600DC88 RID: 56456 RVA: 0x00205FAA File Offset: 0x002041AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC89 RID: 56457 RVA: 0x00205FB7 File Offset: 0x002041B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC8A RID: 56458 RVA: 0x00205FC0 File Offset: 0x002041C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this.Conv != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Conv);
			}
			if (this.SeqNo != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SeqNo);
			}
			if (this.ChannelId.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ChannelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC8B RID: 56459 RVA: 0x00206058 File Offset: 0x00204258
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

		// Token: 0x0600DC8C RID: 56460 RVA: 0x002060E4 File Offset: 0x002042E4
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

		// Token: 0x0600DC8D RID: 56461 RVA: 0x00206161 File Offset: 0x00204361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC8E RID: 56462 RVA: 0x0020616C File Offset: 0x0020436C
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
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.Conv = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.SeqNo = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.ChannelId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B53 RID: 23379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B54 RID: 23380
		public const int CodeFieldNumber = 5;

		// Token: 0x04005B55 RID: 23381
		private ErrorCode code_;

		// Token: 0x04005B56 RID: 23382
		public const int ConvFieldNumber = 9;

		// Token: 0x04005B57 RID: 23383
		private uint conv_;

		// Token: 0x04005B58 RID: 23384
		public const int ChannelIdFieldNumber = 12;

		// Token: 0x04005B59 RID: 23385
		private string channelId_ = "";

		// Token: 0x04005B5A RID: 23386
		public const int SeqNoFieldNumber = 11;

		// Token: 0x04005B5B RID: 23387
		private int seqNo_;
	}
}
