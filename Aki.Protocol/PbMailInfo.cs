using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C08 RID: 3080
	public sealed class PbMailInfo : IMessage<PbMailInfo>, IMessage, IEquatable<PbMailInfo>, IDeepCloneable<PbMailInfo>, IBufferMessage
	{
		// Token: 0x06010B81 RID: 68481 RVA: 0x00272A0B File Offset: 0x00270C0B
		[NullableContext(1)]
		public static PbMailInfo Create()
		{
			return new PbMailInfo();
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x06010B82 RID: 68482 RVA: 0x00272A12 File Offset: 0x00270C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbMailInfo> Parser
		{
			get
			{
				return PbMailInfo._parser;
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x06010B83 RID: 68483 RVA: 0x00272A19 File Offset: 0x00270C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x06010B84 RID: 68484 RVA: 0x00272A1C File Offset: 0x00270C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMailInfo.Descriptor;
			}
		}

		// Token: 0x06010B85 RID: 68485 RVA: 0x00272A23 File Offset: 0x00270C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo()
		{
		}

		// Token: 0x06010B86 RID: 68486 RVA: 0x00272A64 File Offset: 0x00270C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo(PbMailInfo other) : this()
		{
			this.id_ = other.id_;
			this.receivedTime_ = other.receivedTime_;
			this.readTime_ = other.readTime_;
			this.state_ = other.state_;
			this.level_ = other.level_;
			this.title_ = other.title_;
			this.content_ = other.content_;
			this.sender_ = other.sender_;
			this.validTime_ = other.validTime_;
			this.readValidTime_ = other.readValidTime_;
			this.attachments_ = other.attachments_.Clone();
			this.configId_ = other.configId_;
			this.expiryTime_ = other.expiryTime_;
			this.isIntervalMail_ = other.isIntervalMail_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B87 RID: 68487 RVA: 0x00272B35 File Offset: 0x00270D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo Clone()
		{
			return new PbMailInfo(this);
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x06010B88 RID: 68488 RVA: 0x00272B3D File Offset: 0x00270D3D
		// (set) Token: 0x06010B89 RID: 68489 RVA: 0x00272B45 File Offset: 0x00270D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x06010B8A RID: 68490 RVA: 0x00272B58 File Offset: 0x00270D58
		// (set) Token: 0x06010B8B RID: 68491 RVA: 0x00272B60 File Offset: 0x00270D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ReceivedTime
		{
			get
			{
				return this.receivedTime_;
			}
			set
			{
				this.receivedTime_ = value;
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x06010B8C RID: 68492 RVA: 0x00272B69 File Offset: 0x00270D69
		// (set) Token: 0x06010B8D RID: 68493 RVA: 0x00272B71 File Offset: 0x00270D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ReadTime
		{
			get
			{
				return this.readTime_;
			}
			set
			{
				this.readTime_ = value;
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x06010B8E RID: 68494 RVA: 0x00272B7A File Offset: 0x00270D7A
		// (set) Token: 0x06010B8F RID: 68495 RVA: 0x00272B82 File Offset: 0x00270D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x06010B90 RID: 68496 RVA: 0x00272B8B File Offset: 0x00270D8B
		// (set) Token: 0x06010B91 RID: 68497 RVA: 0x00272B93 File Offset: 0x00270D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailLevel Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x06010B92 RID: 68498 RVA: 0x00272B9C File Offset: 0x00270D9C
		// (set) Token: 0x06010B93 RID: 68499 RVA: 0x00272BA4 File Offset: 0x00270DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Title
		{
			get
			{
				return this.title_;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x06010B94 RID: 68500 RVA: 0x00272BB7 File Offset: 0x00270DB7
		// (set) Token: 0x06010B95 RID: 68501 RVA: 0x00272BBF File Offset: 0x00270DBF
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

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x06010B96 RID: 68502 RVA: 0x00272BD2 File Offset: 0x00270DD2
		// (set) Token: 0x06010B97 RID: 68503 RVA: 0x00272BDA File Offset: 0x00270DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Sender
		{
			get
			{
				return this.sender_;
			}
			set
			{
				this.sender_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x06010B98 RID: 68504 RVA: 0x00272BED File Offset: 0x00270DED
		// (set) Token: 0x06010B99 RID: 68505 RVA: 0x00272BF5 File Offset: 0x00270DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ValidTime
		{
			get
			{
				return this.validTime_;
			}
			set
			{
				this.validTime_ = value;
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x06010B9A RID: 68506 RVA: 0x00272BFE File Offset: 0x00270DFE
		// (set) Token: 0x06010B9B RID: 68507 RVA: 0x00272C06 File Offset: 0x00270E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReadValidTime
		{
			get
			{
				return this.readValidTime_;
			}
			set
			{
				this.readValidTime_ = value;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x06010B9C RID: 68508 RVA: 0x00272C0F File Offset: 0x00270E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbMailAttachment> Attachments
		{
			get
			{
				return this.attachments_;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x06010B9D RID: 68509 RVA: 0x00272C17 File Offset: 0x00270E17
		// (set) Token: 0x06010B9E RID: 68510 RVA: 0x00272C1F File Offset: 0x00270E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x06010B9F RID: 68511 RVA: 0x00272C28 File Offset: 0x00270E28
		// (set) Token: 0x06010BA0 RID: 68512 RVA: 0x00272C30 File Offset: 0x00270E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpiryTime
		{
			get
			{
				return this.expiryTime_;
			}
			set
			{
				this.expiryTime_ = value;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x06010BA1 RID: 68513 RVA: 0x00272C39 File Offset: 0x00270E39
		// (set) Token: 0x06010BA2 RID: 68514 RVA: 0x00272C41 File Offset: 0x00270E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsIntervalMail
		{
			get
			{
				return this.isIntervalMail_;
			}
			set
			{
				this.isIntervalMail_ = value;
			}
		}

		// Token: 0x06010BA3 RID: 68515 RVA: 0x00272C4A File Offset: 0x00270E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMailInfo);
		}

		// Token: 0x06010BA4 RID: 68516 RVA: 0x00272C58 File Offset: 0x00270E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMailInfo other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.ReceivedTime == other.ReceivedTime && this.ReadTime == other.ReadTime && this.State == other.State && this.Level == other.Level && !(this.Title != other.Title) && !(this.Content != other.Content) && !(this.Sender != other.Sender) && this.ValidTime == other.ValidTime && this.ReadValidTime == other.ReadValidTime && this.attachments_.Equals(other.attachments_) && this.ConfigId == other.ConfigId && this.ExpiryTime == other.ExpiryTime && this.IsIntervalMail == other.IsIntervalMail && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BA5 RID: 68517 RVA: 0x00272D7C File Offset: 0x00270F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ReceivedTime != 0L)
			{
				num ^= this.ReceivedTime.GetHashCode();
			}
			if (this.ReadTime != 0L)
			{
				num ^= this.ReadTime.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.Level != MailLevel.None)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Title.Length != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.Sender.Length != 0)
			{
				num ^= this.Sender.GetHashCode();
			}
			if (this.ValidTime != 0)
			{
				num ^= this.ValidTime.GetHashCode();
			}
			if (this.ReadValidTime != 0)
			{
				num ^= this.ReadValidTime.GetHashCode();
			}
			num ^= this.attachments_.GetHashCode();
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ExpiryTime != 0L)
			{
				num ^= this.ExpiryTime.GetHashCode();
			}
			if (this.IsIntervalMail)
			{
				num ^= this.IsIntervalMail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010BA6 RID: 68518 RVA: 0x00272F04 File Offset: 0x00271104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BA7 RID: 68519 RVA: 0x00272F11 File Offset: 0x00271111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BA8 RID: 68520 RVA: 0x00272F1C File Offset: 0x0027111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			if (this.ReceivedTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ReceivedTime);
			}
			if (this.ReadTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ReadTime);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.State);
			}
			if (this.Level != MailLevel.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Level);
			}
			if (this.Title.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Title);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Content);
			}
			if (this.Sender.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Sender);
			}
			if (this.ValidTime != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ValidTime);
			}
			if (this.ReadValidTime != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ReadValidTime);
			}
			this.attachments_.WriteTo(ref output, PbMailInfo._repeated_attachments_codec);
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ExpiryTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ExpiryTime);
			}
			if (this.IsIntervalMail)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsIntervalMail);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BA9 RID: 68521 RVA: 0x002730D0 File Offset: 0x002712D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.ReceivedTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReceivedTime);
			}
			if (this.ReadTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReadTime);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.Level != MailLevel.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Level);
			}
			if (this.Title.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.Sender.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Sender);
			}
			if (this.ValidTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ValidTime);
			}
			if (this.ReadValidTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReadValidTime);
			}
			num += this.attachments_.CalculateSize(PbMailInfo._repeated_attachments_codec);
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ExpiryTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpiryTime);
			}
			if (this.IsIntervalMail)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010BAA RID: 68522 RVA: 0x0027324C File Offset: 0x0027144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbMailInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.ReceivedTime != 0L)
			{
				this.ReceivedTime = other.ReceivedTime;
			}
			if (other.ReadTime != 0L)
			{
				this.ReadTime = other.ReadTime;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.Level != MailLevel.None)
			{
				this.Level = other.Level;
			}
			if (other.Title.Length != 0)
			{
				this.Title = other.Title;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.Sender.Length != 0)
			{
				this.Sender = other.Sender;
			}
			if (other.ValidTime != 0)
			{
				this.ValidTime = other.ValidTime;
			}
			if (other.ReadValidTime != 0)
			{
				this.ReadValidTime = other.ReadValidTime;
			}
			this.attachments_.Add(other.attachments_);
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ExpiryTime != 0L)
			{
				this.ExpiryTime = other.ExpiryTime;
			}
			if (other.IsIntervalMail)
			{
				this.IsIntervalMail = other.IsIntervalMail;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010BAB RID: 68523 RVA: 0x0027339D File Offset: 0x0027159D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BAC RID: 68524 RVA: 0x002733A8 File Offset: 0x002715A8
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
				if (num <= 58U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.Id = input.ReadString();
							continue;
						}
						if (num == 16U)
						{
							this.ReceivedTime = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.ReadTime = input.ReadInt64();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.State = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Level = (MailLevel)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.Title = input.ReadString();
							continue;
						}
						if (num == 58U)
						{
							this.Content = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 66U)
					{
						this.Sender = input.ReadString();
						continue;
					}
					if (num == 72U)
					{
						this.ValidTime = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ReadValidTime = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 90U)
					{
						this.attachments_.AddEntriesFrom(ref input, PbMailInfo._repeated_attachments_codec);
						continue;
					}
					if (num == 96U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ExpiryTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.IsIntervalMail = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006A39 RID: 27193
		private static readonly MessageParser<PbMailInfo> _parser = new MessageParser<PbMailInfo>(() => new PbMailInfo());

		// Token: 0x04006A3A RID: 27194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A3B RID: 27195
		public const int IdFieldNumber = 1;

		// Token: 0x04006A3C RID: 27196
		private string id_ = "";

		// Token: 0x04006A3D RID: 27197
		public const int ReceivedTimeFieldNumber = 2;

		// Token: 0x04006A3E RID: 27198
		private long receivedTime_;

		// Token: 0x04006A3F RID: 27199
		public const int ReadTimeFieldNumber = 3;

		// Token: 0x04006A40 RID: 27200
		private long readTime_;

		// Token: 0x04006A41 RID: 27201
		public const int StateFieldNumber = 4;

		// Token: 0x04006A42 RID: 27202
		private int state_;

		// Token: 0x04006A43 RID: 27203
		public const int LevelFieldNumber = 5;

		// Token: 0x04006A44 RID: 27204
		private MailLevel level_;

		// Token: 0x04006A45 RID: 27205
		public const int TitleFieldNumber = 6;

		// Token: 0x04006A46 RID: 27206
		private string title_ = "";

		// Token: 0x04006A47 RID: 27207
		public const int ContentFieldNumber = 7;

		// Token: 0x04006A48 RID: 27208
		private string content_ = "";

		// Token: 0x04006A49 RID: 27209
		public const int SenderFieldNumber = 8;

		// Token: 0x04006A4A RID: 27210
		private string sender_ = "";

		// Token: 0x04006A4B RID: 27211
		public const int ValidTimeFieldNumber = 9;

		// Token: 0x04006A4C RID: 27212
		private int validTime_;

		// Token: 0x04006A4D RID: 27213
		public const int ReadValidTimeFieldNumber = 10;

		// Token: 0x04006A4E RID: 27214
		private int readValidTime_;

		// Token: 0x04006A4F RID: 27215
		public const int AttachmentsFieldNumber = 11;

		// Token: 0x04006A50 RID: 27216
		private static readonly FieldCodec<PbMailAttachment> _repeated_attachments_codec = FieldCodec.ForMessage<PbMailAttachment>(90U, PbMailAttachment.Parser);

		// Token: 0x04006A51 RID: 27217
		private readonly RepeatedField<PbMailAttachment> attachments_ = new RepeatedField<PbMailAttachment>();

		// Token: 0x04006A52 RID: 27218
		public const int ConfigIdFieldNumber = 12;

		// Token: 0x04006A53 RID: 27219
		private int configId_;

		// Token: 0x04006A54 RID: 27220
		public const int ExpiryTimeFieldNumber = 13;

		// Token: 0x04006A55 RID: 27221
		private long expiryTime_;

		// Token: 0x04006A56 RID: 27222
		public const int IsIntervalMailFieldNumber = 14;

		// Token: 0x04006A57 RID: 27223
		private bool isIntervalMail_;
	}
}
