using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026D RID: 621
	[NetMessage(EMessageId.ChannelChatHistoryNotify)]
	public sealed class ChannelChatHistoryNotify : IMessage<ChannelChatHistoryNotify>, IMessage, IEquatable<ChannelChatHistoryNotify>, IDeepCloneable<ChannelChatHistoryNotify>, IBufferMessage
	{
		// Token: 0x060041A6 RID: 16806 RVA: 0x000A137C File Offset: 0x0009F57C
		[NullableContext(1)]
		public static ChannelChatHistoryNotify Create()
		{
			return new ChannelChatHistoryNotify();
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x000A1383 File Offset: 0x0009F583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x000A1386 File Offset: 0x0009F586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatHistoryNotify.Descriptor;
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x000A138D File Offset: 0x0009F58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify()
		{
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x000A13A0 File Offset: 0x0009F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify(ChannelChatHistoryNotify other) : this()
		{
			this.channelType_ = other.channelType_;
			this.subChannelType_ = other.subChannelType_;
			this.messageInfos_ = other.messageInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x000A13ED File Offset: 0x0009F5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify Clone()
		{
			return new ChannelChatHistoryNotify(this);
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x000A13F5 File Offset: 0x0009F5F5
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x000A13FD File Offset: 0x0009F5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatChannelType ChannelType
		{
			get
			{
				return this.channelType_;
			}
			set
			{
				this.channelType_ = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x000A1406 File Offset: 0x0009F606
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x000A140E File Offset: 0x0009F60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubChatChannelType SubChannelType
		{
			get
			{
				return this.subChannelType_;
			}
			set
			{
				this.subChannelType_ = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x000A1417 File Offset: 0x0009F617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChannelChatMessageInfo> MessageInfos
		{
			get
			{
				return this.messageInfos_;
			}
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x000A141F File Offset: 0x0009F61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatHistoryNotify);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x000A1430 File Offset: 0x0009F630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatHistoryNotify other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && this.messageInfos_.Equals(other.messageInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x000A1490 File Offset: 0x0009F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChannelType != ChatChannelType.Default)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				num ^= this.SubChannelType.GetHashCode();
			}
			num ^= this.messageInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x000A1502 File Offset: 0x0009F702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x000A150F File Offset: 0x0009F70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000A1518 File Offset: 0x0009F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ChannelType);
			}
			this.messageInfos_.WriteTo(ref output, ChannelChatHistoryNotify._repeated_messageInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000A1584 File Offset: 0x0009F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChannelType != ChatChannelType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChannelType);
			}
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SubChannelType);
			}
			num += this.messageInfos_.CalculateSize(ChannelChatHistoryNotify._repeated_messageInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000A15F0 File Offset: 0x0009F7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatHistoryNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChannelType != ChatChannelType.Default)
			{
				this.ChannelType = other.ChannelType;
			}
			if (other.SubChannelType != SubChatChannelType.WorldTeam)
			{
				this.SubChannelType = other.SubChannelType;
			}
			this.messageInfos_.Add(other.messageInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000A1651 File Offset: 0x0009F851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000A165C File Offset: 0x0009F85C
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.messageInfos_.AddEntriesFrom(ref input, ChannelChatHistoryNotify._repeated_messageInfos_codec);
						}
					}
					else
					{
						this.ChannelType = (ChatChannelType)input.ReadEnum();
					}
				}
				else
				{
					this.SubChannelType = (SubChatChannelType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E0B RID: 11787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E0C RID: 11788
		public const int ChannelTypeFieldNumber = 4;

		// Token: 0x04002E0D RID: 11789
		private ChatChannelType channelType_;

		// Token: 0x04002E0E RID: 11790
		public const int SubChannelTypeFieldNumber = 2;

		// Token: 0x04002E0F RID: 11791
		private SubChatChannelType subChannelType_;

		// Token: 0x04002E10 RID: 11792
		public const int MessageInfosFieldNumber = 8;

		// Token: 0x04002E11 RID: 11793
		private static readonly FieldCodec<ChannelChatMessageInfo> _repeated_messageInfos_codec = FieldCodec.ForMessage<ChannelChatMessageInfo>(66U, ChannelChatMessageInfo.Parser);

		// Token: 0x04002E12 RID: 11794
		private readonly RepeatedField<ChannelChatMessageInfo> messageInfos_ = new RepeatedField<ChannelChatMessageInfo>();
	}
}
