using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027A RID: 634
	public sealed class ChatContentProto : IMessage<ChatContentProto>, IMessage, IEquatable<ChatContentProto>, IDeepCloneable<ChatContentProto>, IBufferMessage
	{
		// Token: 0x06004295 RID: 17045 RVA: 0x000A3573 File Offset: 0x000A1773
		[NullableContext(1)]
		public static ChatContentProto Create()
		{
			return new ChatContentProto();
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x000A357A File Offset: 0x000A177A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatContentProto> Parser
		{
			get
			{
				return ChatContentProto._parser;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x000A3581 File Offset: 0x000A1781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x000A3584 File Offset: 0x000A1784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatContentProto.Descriptor;
			}
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x000A358B File Offset: 0x000A178B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto()
		{
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000A35C0 File Offset: 0x000A17C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto(ChatContentProto other) : this()
		{
			this.senderUID_ = other.senderUID_;
			this.chatContentType_ = other.chatContentType_;
			this.content_ = other.content_;
			this.offlineMsg_ = other.offlineMsg_;
			this.uTCTime_ = other.uTCTime_;
			this.msgId_ = other.msgId_;
			this.senderPsnAccountId_ = other.senderPsnAccountId_;
			this.senderXboxAccountId_ = other.senderXboxAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000A3644 File Offset: 0x000A1844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto Clone()
		{
			return new ChatContentProto(this);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x000A364C File Offset: 0x000A184C
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x000A3654 File Offset: 0x000A1854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SenderUID
		{
			get
			{
				return this.senderUID_;
			}
			set
			{
				this.senderUID_ = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x000A365D File Offset: 0x000A185D
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x000A3665 File Offset: 0x000A1865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentType ChatContentType
		{
			get
			{
				return this.chatContentType_;
			}
			set
			{
				this.chatContentType_ = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x000A366E File Offset: 0x000A186E
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x000A3676 File Offset: 0x000A1876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x000A3689 File Offset: 0x000A1889
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x000A3691 File Offset: 0x000A1891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OfflineMsg
		{
			get
			{
				return this.offlineMsg_;
			}
			set
			{
				this.offlineMsg_ = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x000A369A File Offset: 0x000A189A
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x000A36A2 File Offset: 0x000A18A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UTCTime
		{
			get
			{
				return this.uTCTime_;
			}
			set
			{
				this.uTCTime_ = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x000A36AB File Offset: 0x000A18AB
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x000A36B3 File Offset: 0x000A18B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MsgId
		{
			get
			{
				return this.msgId_;
			}
			set
			{
				this.msgId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x000A36C6 File Offset: 0x000A18C6
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x000A36CE File Offset: 0x000A18CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderPsnAccountId
		{
			get
			{
				return this.senderPsnAccountId_;
			}
			set
			{
				this.senderPsnAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x000A36E1 File Offset: 0x000A18E1
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x000A36E9 File Offset: 0x000A18E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderXboxAccountId
		{
			get
			{
				return this.senderXboxAccountId_;
			}
			set
			{
				this.senderXboxAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000A36FC File Offset: 0x000A18FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatContentProto);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000A370C File Offset: 0x000A190C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatContentProto other)
		{
			return other != null && (other == this || (this.SenderUID == other.SenderUID && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.OfflineMsg == other.OfflineMsg && this.UTCTime == other.UTCTime && !(this.MsgId != other.MsgId) && !(this.SenderPsnAccountId != other.SenderPsnAccountId) && !(this.SenderXboxAccountId != other.SenderXboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x000A37CC File Offset: 0x000A19CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SenderUID != 0)
			{
				num ^= this.SenderUID.GetHashCode();
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num ^= this.ChatContentType.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.OfflineMsg)
			{
				num ^= this.OfflineMsg.GetHashCode();
			}
			if (this.UTCTime != 0L)
			{
				num ^= this.UTCTime.GetHashCode();
			}
			if (this.MsgId.Length != 0)
			{
				num ^= this.MsgId.GetHashCode();
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num ^= this.SenderPsnAccountId.GetHashCode();
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				num ^= this.SenderXboxAccountId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x000A38C9 File Offset: 0x000A1AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000A38D6 File Offset: 0x000A1AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x000A38E0 File Offset: 0x000A1AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SenderUID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SenderUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Content);
			}
			if (this.OfflineMsg)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.OfflineMsg);
			}
			if (this.UTCTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UTCTime);
			}
			if (this.MsgId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MsgId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SenderPsnAccountId);
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SenderXboxAccountId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000A39F4 File Offset: 0x000A1BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SenderUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SenderUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.OfflineMsg)
			{
				num += 2;
			}
			if (this.UTCTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UTCTime);
			}
			if (this.MsgId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MsgId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderPsnAccountId);
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderXboxAccountId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x000A3AE4 File Offset: 0x000A1CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatContentProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SenderUID != 0)
			{
				this.SenderUID = other.SenderUID;
			}
			if (other.ChatContentType != ChatContentType.Text)
			{
				this.ChatContentType = other.ChatContentType;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.OfflineMsg)
			{
				this.OfflineMsg = other.OfflineMsg;
			}
			if (other.UTCTime != 0L)
			{
				this.UTCTime = other.UTCTime;
			}
			if (other.MsgId.Length != 0)
			{
				this.MsgId = other.MsgId;
			}
			if (other.SenderPsnAccountId.Length != 0)
			{
				this.SenderPsnAccountId = other.SenderPsnAccountId;
			}
			if (other.SenderXboxAccountId.Length != 0)
			{
				this.SenderXboxAccountId = other.SenderXboxAccountId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x000A3BCC File Offset: 0x000A1DCC
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.SenderUID = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ChatContentType = (ChatContentType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.Content = input.ReadString();
							continue;
						}
						if (num == 32U)
						{
							this.OfflineMsg = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.UTCTime = input.ReadInt64();
						continue;
					}
					if (num == 50U)
					{
						this.MsgId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.SenderPsnAccountId = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						this.SenderXboxAccountId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E11 RID: 11793
		private static readonly MessageParser<ChatContentProto> _parser = new MessageParser<ChatContentProto>(() => new ChatContentProto());

		// Token: 0x04002E12 RID: 11794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E13 RID: 11795
		public const int SenderUIDFieldNumber = 1;

		// Token: 0x04002E14 RID: 11796
		private int senderUID_;

		// Token: 0x04002E15 RID: 11797
		public const int ChatContentTypeFieldNumber = 2;

		// Token: 0x04002E16 RID: 11798
		private ChatContentType chatContentType_;

		// Token: 0x04002E17 RID: 11799
		public const int ContentFieldNumber = 3;

		// Token: 0x04002E18 RID: 11800
		private string content_ = "";

		// Token: 0x04002E19 RID: 11801
		public const int OfflineMsgFieldNumber = 4;

		// Token: 0x04002E1A RID: 11802
		private bool offlineMsg_;

		// Token: 0x04002E1B RID: 11803
		public const int UTCTimeFieldNumber = 5;

		// Token: 0x04002E1C RID: 11804
		private long uTCTime_;

		// Token: 0x04002E1D RID: 11805
		public const int MsgIdFieldNumber = 6;

		// Token: 0x04002E1E RID: 11806
		private string msgId_ = "";

		// Token: 0x04002E1F RID: 11807
		public const int SenderPsnAccountIdFieldNumber = 7;

		// Token: 0x04002E20 RID: 11808
		private string senderPsnAccountId_ = "";

		// Token: 0x04002E21 RID: 11809
		public const int SenderXboxAccountIdFieldNumber = 8;

		// Token: 0x04002E22 RID: 11810
		private string senderXboxAccountId_ = "";
	}
}
