using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097F RID: 2431
	[NetMessage(EMessageId.MailReadResponse)]
	public sealed class MailReadResponse : IMessage<MailReadResponse>, IMessage, IEquatable<MailReadResponse>, IDeepCloneable<MailReadResponse>, IBufferMessage
	{
		// Token: 0x0600D5CA RID: 54730 RVA: 0x001F71D9 File Offset: 0x001F53D9
		[NullableContext(1)]
		public static MailReadResponse Create()
		{
			return new MailReadResponse();
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x001F71E0 File Offset: 0x001F53E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x001F71E3 File Offset: 0x001F53E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailReadResponse.Descriptor;
			}
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x001F71EA File Offset: 0x001F53EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadResponse()
		{
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x001F7200 File Offset: 0x001F5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadResponse(MailReadResponse other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.errorCode_ = other.errorCode_;
			this.readTime_ = other.readTime_;
			this.expiryTime_ = other.expiryTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x001F7260 File Offset: 0x001F5460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadResponse Clone()
		{
			return new MailReadResponse(this);
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x001F7268 File Offset: 0x001F5468
		// (set) Token: 0x0600D5D1 RID: 54737 RVA: 0x001F7270 File Offset: 0x001F5470
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

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x001F7283 File Offset: 0x001F5483
		// (set) Token: 0x0600D5D3 RID: 54739 RVA: 0x001F728B File Offset: 0x001F548B
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

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x001F7294 File Offset: 0x001F5494
		// (set) Token: 0x0600D5D5 RID: 54741 RVA: 0x001F729C File Offset: 0x001F549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x001F72A5 File Offset: 0x001F54A5
		// (set) Token: 0x0600D5D7 RID: 54743 RVA: 0x001F72AD File Offset: 0x001F54AD
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

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x001F72B6 File Offset: 0x001F54B6
		// (set) Token: 0x0600D5D9 RID: 54745 RVA: 0x001F72BE File Offset: 0x001F54BE
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

		// Token: 0x0600D5DA RID: 54746 RVA: 0x001F72C7 File Offset: 0x001F54C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailReadResponse);
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x001F72D8 File Offset: 0x001F54D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailReadResponse other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.State == other.State && this.ErrorCode == other.ErrorCode && this.ReadTime == other.ReadTime && this.ExpiryTime == other.ExpiryTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x001F7358 File Offset: 0x001F5558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ReadTime != 0L)
			{
				num ^= this.ReadTime.GetHashCode();
			}
			if (this.ExpiryTime != 0L)
			{
				num ^= this.ExpiryTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x001F7403 File Offset: 0x001F5603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x001F7410 File Offset: 0x001F5610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x001F741C File Offset: 0x001F561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.State);
			}
			if (this.ExpiryTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.ExpiryTime);
			}
			if (this.ReadTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ReadTime);
			}
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x001F74D0 File Offset: 0x001F56D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ReadTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReadTime);
			}
			if (this.ExpiryTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpiryTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x001F7574 File Offset: 0x001F5774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ReadTime != 0L)
			{
				this.ReadTime = other.ReadTime;
			}
			if (other.ExpiryTime != 0L)
			{
				this.ExpiryTime = other.ExpiryTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x001F7605 File Offset: 0x001F5805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x001F7610 File Offset: 0x001F5810
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
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ExpiryTime = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.ReadTime = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						this.Id = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400596E RID: 22894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400596F RID: 22895
		public const int IdFieldNumber = 15;

		// Token: 0x04005970 RID: 22896
		private string id_ = "";

		// Token: 0x04005971 RID: 22897
		public const int StateFieldNumber = 8;

		// Token: 0x04005972 RID: 22898
		private int state_;

		// Token: 0x04005973 RID: 22899
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005974 RID: 22900
		private ErrorCode errorCode_;

		// Token: 0x04005975 RID: 22901
		public const int ReadTimeFieldNumber = 13;

		// Token: 0x04005976 RID: 22902
		private long readTime_;

		// Token: 0x04005977 RID: 22903
		public const int ExpiryTimeFieldNumber = 10;

		// Token: 0x04005978 RID: 22904
		private long expiryTime_;
	}
}
