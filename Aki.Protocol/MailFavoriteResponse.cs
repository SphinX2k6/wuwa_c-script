using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097A RID: 2426
	[NetMessage(EMessageId.MailFavoriteResponse)]
	public sealed class MailFavoriteResponse : IMessage<MailFavoriteResponse>, IMessage, IEquatable<MailFavoriteResponse>, IDeepCloneable<MailFavoriteResponse>, IBufferMessage
	{
		// Token: 0x0600D568 RID: 54632 RVA: 0x001F652C File Offset: 0x001F472C
		[NullableContext(1)]
		public static MailFavoriteResponse Create()
		{
			return new MailFavoriteResponse();
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600D569 RID: 54633 RVA: 0x001F6533 File Offset: 0x001F4733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600D56A RID: 54634 RVA: 0x001F6536 File Offset: 0x001F4736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailFavoriteResponse.Descriptor;
			}
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x001F653D File Offset: 0x001F473D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse()
		{
		}

		// Token: 0x0600D56C RID: 54636 RVA: 0x001F6550 File Offset: 0x001F4750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse(MailFavoriteResponse other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.errorCode_ = other.errorCode_;
			this.expiryTime_ = other.expiryTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D56D RID: 54637 RVA: 0x001F65A4 File Offset: 0x001F47A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse Clone()
		{
			return new MailFavoriteResponse(this);
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x001F65AC File Offset: 0x001F47AC
		// (set) Token: 0x0600D56F RID: 54639 RVA: 0x001F65B4 File Offset: 0x001F47B4
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

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600D570 RID: 54640 RVA: 0x001F65C7 File Offset: 0x001F47C7
		// (set) Token: 0x0600D571 RID: 54641 RVA: 0x001F65CF File Offset: 0x001F47CF
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

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600D572 RID: 54642 RVA: 0x001F65D8 File Offset: 0x001F47D8
		// (set) Token: 0x0600D573 RID: 54643 RVA: 0x001F65E0 File Offset: 0x001F47E0
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

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600D574 RID: 54644 RVA: 0x001F65E9 File Offset: 0x001F47E9
		// (set) Token: 0x0600D575 RID: 54645 RVA: 0x001F65F1 File Offset: 0x001F47F1
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

		// Token: 0x0600D576 RID: 54646 RVA: 0x001F65FA File Offset: 0x001F47FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailFavoriteResponse);
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x001F6608 File Offset: 0x001F4808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailFavoriteResponse other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.State == other.State && this.ErrorCode == other.ErrorCode && this.ExpiryTime == other.ExpiryTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x001F6678 File Offset: 0x001F4878
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

		// Token: 0x0600D579 RID: 54649 RVA: 0x001F670A File Offset: 0x001F490A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D57A RID: 54650 RVA: 0x001F6717 File Offset: 0x001F4917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x001F6720 File Offset: 0x001F4920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.State);
			}
			if (this.ExpiryTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.ExpiryTime);
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

		// Token: 0x0600D57C RID: 54652 RVA: 0x001F67B8 File Offset: 0x001F49B8
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

		// Token: 0x0600D57D RID: 54653 RVA: 0x001F6844 File Offset: 0x001F4A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailFavoriteResponse other)
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
			if (other.ExpiryTime != 0L)
			{
				this.ExpiryTime = other.ExpiryTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x001F68C1 File Offset: 0x001F4AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x001F68CC File Offset: 0x001F4ACC
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
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ExpiryTime = input.ReadInt64();
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

		// Token: 0x04005954 RID: 22868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005955 RID: 22869
		public const int IdFieldNumber = 15;

		// Token: 0x04005956 RID: 22870
		private string id_ = "";

		// Token: 0x04005957 RID: 22871
		public const int StateFieldNumber = 4;

		// Token: 0x04005958 RID: 22872
		private int state_;

		// Token: 0x04005959 RID: 22873
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400595A RID: 22874
		private ErrorCode errorCode_;

		// Token: 0x0400595B RID: 22875
		public const int ExpiryTimeFieldNumber = 8;

		// Token: 0x0400595C RID: 22876
		private long expiryTime_;
	}
}
