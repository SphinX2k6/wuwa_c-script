using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF8 RID: 3064
	public sealed class PbMailInfo : IMessage<PbMailInfo>, IMessage, IEquatable<PbMailInfo>, IDeepCloneable<PbMailInfo>, IBufferMessage
	{
		// Token: 0x06010A81 RID: 68225 RVA: 0x00270CA3 File Offset: 0x0026EEA3
		[NullableContext(1)]
		public static PbMailInfo Create()
		{
			return new PbMailInfo();
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x06010A82 RID: 68226 RVA: 0x00270CAA File Offset: 0x0026EEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbMailInfo> Parser
		{
			get
			{
				return PbMailInfo._parser;
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x06010A83 RID: 68227 RVA: 0x00270CB1 File Offset: 0x0026EEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x06010A84 RID: 68228 RVA: 0x00270CB4 File Offset: 0x0026EEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMailInfo.Descriptor;
			}
		}

		// Token: 0x06010A85 RID: 68229 RVA: 0x00270CBB File Offset: 0x0026EEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo()
		{
		}

		// Token: 0x06010A86 RID: 68230 RVA: 0x00270CFC File Offset: 0x0026EEFC
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

		// Token: 0x06010A87 RID: 68231 RVA: 0x00270DCD File Offset: 0x0026EFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo Clone()
		{
			return new PbMailInfo(this);
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x06010A88 RID: 68232 RVA: 0x00270DD5 File Offset: 0x0026EFD5
		// (set) Token: 0x06010A89 RID: 68233 RVA: 0x00270DDD File Offset: 0x0026EFDD
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

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x06010A8A RID: 68234 RVA: 0x00270DF0 File Offset: 0x0026EFF0
		// (set) Token: 0x06010A8B RID: 68235 RVA: 0x00270DF8 File Offset: 0x0026EFF8
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

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x06010A8C RID: 68236 RVA: 0x00270E01 File Offset: 0x0026F001
		// (set) Token: 0x06010A8D RID: 68237 RVA: 0x00270E09 File Offset: 0x0026F009
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

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x06010A8E RID: 68238 RVA: 0x00270E12 File Offset: 0x0026F012
		// (set) Token: 0x06010A8F RID: 68239 RVA: 0x00270E1A File Offset: 0x0026F01A
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

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x06010A90 RID: 68240 RVA: 0x00270E23 File Offset: 0x0026F023
		// (set) Token: 0x06010A91 RID: 68241 RVA: 0x00270E2B File Offset: 0x0026F02B
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

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x06010A92 RID: 68242 RVA: 0x00270E34 File Offset: 0x0026F034
		// (set) Token: 0x06010A93 RID: 68243 RVA: 0x00270E3C File Offset: 0x0026F03C
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

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x06010A94 RID: 68244 RVA: 0x00270E4F File Offset: 0x0026F04F
		// (set) Token: 0x06010A95 RID: 68245 RVA: 0x00270E57 File Offset: 0x0026F057
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

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x06010A96 RID: 68246 RVA: 0x00270E6A File Offset: 0x0026F06A
		// (set) Token: 0x06010A97 RID: 68247 RVA: 0x00270E72 File Offset: 0x0026F072
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

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x06010A98 RID: 68248 RVA: 0x00270E85 File Offset: 0x0026F085
		// (set) Token: 0x06010A99 RID: 68249 RVA: 0x00270E8D File Offset: 0x0026F08D
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

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x06010A9A RID: 68250 RVA: 0x00270E96 File Offset: 0x0026F096
		// (set) Token: 0x06010A9B RID: 68251 RVA: 0x00270E9E File Offset: 0x0026F09E
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

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x06010A9C RID: 68252 RVA: 0x00270EA7 File Offset: 0x0026F0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbMailAttachment> Attachments
		{
			get
			{
				return this.attachments_;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x06010A9D RID: 68253 RVA: 0x00270EAF File Offset: 0x0026F0AF
		// (set) Token: 0x06010A9E RID: 68254 RVA: 0x00270EB7 File Offset: 0x0026F0B7
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

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x06010A9F RID: 68255 RVA: 0x00270EC0 File Offset: 0x0026F0C0
		// (set) Token: 0x06010AA0 RID: 68256 RVA: 0x00270EC8 File Offset: 0x0026F0C8
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

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x06010AA1 RID: 68257 RVA: 0x00270ED1 File Offset: 0x0026F0D1
		// (set) Token: 0x06010AA2 RID: 68258 RVA: 0x00270ED9 File Offset: 0x0026F0D9
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

		// Token: 0x06010AA3 RID: 68259 RVA: 0x00270EE2 File Offset: 0x0026F0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMailInfo);
		}

		// Token: 0x06010AA4 RID: 68260 RVA: 0x00270EF0 File Offset: 0x0026F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMailInfo other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.ReceivedTime == other.ReceivedTime && this.ReadTime == other.ReadTime && this.State == other.State && this.Level == other.Level && !(this.Title != other.Title) && !(this.Content != other.Content) && !(this.Sender != other.Sender) && this.ValidTime == other.ValidTime && this.ReadValidTime == other.ReadValidTime && this.attachments_.Equals(other.attachments_) && this.ConfigId == other.ConfigId && this.ExpiryTime == other.ExpiryTime && this.IsIntervalMail == other.IsIntervalMail && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AA5 RID: 68261 RVA: 0x00271014 File Offset: 0x0026F214
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

		// Token: 0x06010AA6 RID: 68262 RVA: 0x0027119C File Offset: 0x0026F39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AA7 RID: 68263 RVA: 0x002711A9 File Offset: 0x0026F3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AA8 RID: 68264 RVA: 0x002711B4 File Offset: 0x0026F3B4
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

		// Token: 0x06010AA9 RID: 68265 RVA: 0x00271368 File Offset: 0x0026F568
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

		// Token: 0x06010AAA RID: 68266 RVA: 0x002714E4 File Offset: 0x0026F6E4
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

		// Token: 0x06010AAB RID: 68267 RVA: 0x00271635 File Offset: 0x0026F835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AAC RID: 68268 RVA: 0x00271640 File Offset: 0x0026F840
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

		// Token: 0x04006A4D RID: 27213
		private static readonly MessageParser<PbMailInfo> _parser = new MessageParser<PbMailInfo>(() => new PbMailInfo());

		// Token: 0x04006A4E RID: 27214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A4F RID: 27215
		public const int IdFieldNumber = 1;

		// Token: 0x04006A50 RID: 27216
		private string id_ = "";

		// Token: 0x04006A51 RID: 27217
		public const int ReceivedTimeFieldNumber = 2;

		// Token: 0x04006A52 RID: 27218
		private long receivedTime_;

		// Token: 0x04006A53 RID: 27219
		public const int ReadTimeFieldNumber = 3;

		// Token: 0x04006A54 RID: 27220
		private long readTime_;

		// Token: 0x04006A55 RID: 27221
		public const int StateFieldNumber = 4;

		// Token: 0x04006A56 RID: 27222
		private int state_;

		// Token: 0x04006A57 RID: 27223
		public const int LevelFieldNumber = 5;

		// Token: 0x04006A58 RID: 27224
		private MailLevel level_;

		// Token: 0x04006A59 RID: 27225
		public const int TitleFieldNumber = 6;

		// Token: 0x04006A5A RID: 27226
		private string title_ = "";

		// Token: 0x04006A5B RID: 27227
		public const int ContentFieldNumber = 7;

		// Token: 0x04006A5C RID: 27228
		private string content_ = "";

		// Token: 0x04006A5D RID: 27229
		public const int SenderFieldNumber = 8;

		// Token: 0x04006A5E RID: 27230
		private string sender_ = "";

		// Token: 0x04006A5F RID: 27231
		public const int ValidTimeFieldNumber = 9;

		// Token: 0x04006A60 RID: 27232
		private int validTime_;

		// Token: 0x04006A61 RID: 27233
		public const int ReadValidTimeFieldNumber = 10;

		// Token: 0x04006A62 RID: 27234
		private int readValidTime_;

		// Token: 0x04006A63 RID: 27235
		public const int AttachmentsFieldNumber = 11;

		// Token: 0x04006A64 RID: 27236
		private static readonly FieldCodec<PbMailAttachment> _repeated_attachments_codec = FieldCodec.ForMessage<PbMailAttachment>(90U, PbMailAttachment.Parser);

		// Token: 0x04006A65 RID: 27237
		private readonly RepeatedField<PbMailAttachment> attachments_ = new RepeatedField<PbMailAttachment>();

		// Token: 0x04006A66 RID: 27238
		public const int ConfigIdFieldNumber = 12;

		// Token: 0x04006A67 RID: 27239
		private int configId_;

		// Token: 0x04006A68 RID: 27240
		public const int ExpiryTimeFieldNumber = 13;

		// Token: 0x04006A69 RID: 27241
		private long expiryTime_;

		// Token: 0x04006A6A RID: 27242
		public const int IsIntervalMailFieldNumber = 14;

		// Token: 0x04006A6B RID: 27243
		private bool isIntervalMail_;
	}
}
