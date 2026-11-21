using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096E RID: 2414
	[NetMessage(EMessageId.MailReadResponse)]
	public sealed class MailReadResponse : IMessage<MailReadResponse>, IMessage, IEquatable<MailReadResponse>, IDeepCloneable<MailReadResponse>, IBufferMessage
	{
		// Token: 0x0600D4B0 RID: 54448 RVA: 0x001F4FF1 File Offset: 0x001F31F1
		[NullableContext(1)]
		public static MailReadResponse Create()
		{
			return new MailReadResponse();
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600D4B1 RID: 54449 RVA: 0x001F4FF8 File Offset: 0x001F31F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600D4B2 RID: 54450 RVA: 0x001F4FFB File Offset: 0x001F31FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailReadResponse.Descriptor;
			}
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x001F5002 File Offset: 0x001F3202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadResponse()
		{
		}

		// Token: 0x0600D4B4 RID: 54452 RVA: 0x001F5018 File Offset: 0x001F3218
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

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x001F5078 File Offset: 0x001F3278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadResponse Clone()
		{
			return new MailReadResponse(this);
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600D4B6 RID: 54454 RVA: 0x001F5080 File Offset: 0x001F3280
		// (set) Token: 0x0600D4B7 RID: 54455 RVA: 0x001F5088 File Offset: 0x001F3288
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

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600D4B8 RID: 54456 RVA: 0x001F509B File Offset: 0x001F329B
		// (set) Token: 0x0600D4B9 RID: 54457 RVA: 0x001F50A3 File Offset: 0x001F32A3
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

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x001F50AC File Offset: 0x001F32AC
		// (set) Token: 0x0600D4BB RID: 54459 RVA: 0x001F50B4 File Offset: 0x001F32B4
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

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x001F50BD File Offset: 0x001F32BD
		// (set) Token: 0x0600D4BD RID: 54461 RVA: 0x001F50C5 File Offset: 0x001F32C5
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

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x001F50CE File Offset: 0x001F32CE
		// (set) Token: 0x0600D4BF RID: 54463 RVA: 0x001F50D6 File Offset: 0x001F32D6
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

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x001F50DF File Offset: 0x001F32DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailReadResponse);
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x001F50F0 File Offset: 0x001F32F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailReadResponse other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.State == other.State && this.ErrorCode == other.ErrorCode && this.ReadTime == other.ReadTime && this.ExpiryTime == other.ExpiryTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x001F5170 File Offset: 0x001F3370
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

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x001F521B File Offset: 0x001F341B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x001F5228 File Offset: 0x001F3428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x001F5234 File Offset: 0x001F3434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExpiryTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ExpiryTime);
			}
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.State);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ReadTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ReadTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4C6 RID: 54470 RVA: 0x001F52E8 File Offset: 0x001F34E8
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

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x001F538C File Offset: 0x001F358C
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

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x001F541D File Offset: 0x001F361D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x001F5428 File Offset: 0x001F3628
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
				if (num <= 42U)
				{
					if (num == 24U)
					{
						this.ExpiryTime = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.Id = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.State = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.ReadTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005977 RID: 22903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005978 RID: 22904
		public const int IdFieldNumber = 5;

		// Token: 0x04005979 RID: 22905
		private string id_ = "";

		// Token: 0x0400597A RID: 22906
		public const int StateFieldNumber = 13;

		// Token: 0x0400597B RID: 22907
		private int state_;

		// Token: 0x0400597C RID: 22908
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400597D RID: 22909
		private ErrorCode errorCode_;

		// Token: 0x0400597E RID: 22910
		public const int ReadTimeFieldNumber = 15;

		// Token: 0x0400597F RID: 22911
		private long readTime_;

		// Token: 0x04005980 RID: 22912
		public const int ExpiryTimeFieldNumber = 3;

		// Token: 0x04005981 RID: 22913
		private long expiryTime_;
	}
}
