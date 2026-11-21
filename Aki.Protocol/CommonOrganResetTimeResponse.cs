using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C3 RID: 707
	[NetMessage(EMessageId.CommonOrganResetTimeResponse)]
	public sealed class CommonOrganResetTimeResponse : IMessage<CommonOrganResetTimeResponse>, IMessage, IEquatable<CommonOrganResetTimeResponse>, IDeepCloneable<CommonOrganResetTimeResponse>, IBufferMessage
	{
		// Token: 0x06004909 RID: 18697 RVA: 0x000B3465 File Offset: 0x000B1665
		[NullableContext(1)]
		public static CommonOrganResetTimeResponse Create()
		{
			return new CommonOrganResetTimeResponse();
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x000B346C File Offset: 0x000B166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x000B346F File Offset: 0x000B166F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganResetTimeResponse.Descriptor;
			}
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x000B3476 File Offset: 0x000B1676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse()
		{
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x000B347E File Offset: 0x000B167E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse(CommonOrganResetTimeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.resetTime_ = other.resetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x000B34BB File Offset: 0x000B16BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse Clone()
		{
			return new CommonOrganResetTimeResponse(this);
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x000B34C3 File Offset: 0x000B16C3
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x000B34CB File Offset: 0x000B16CB
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x000B34D4 File Offset: 0x000B16D4
		// (set) Token: 0x06004912 RID: 18706 RVA: 0x000B34DC File Offset: 0x000B16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x000B34E5 File Offset: 0x000B16E5
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x000B34ED File Offset: 0x000B16ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetTime
		{
			get
			{
				return this.resetTime_;
			}
			set
			{
				this.resetTime_ = value;
			}
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x000B34F6 File Offset: 0x000B16F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganResetTimeResponse);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x000B3504 File Offset: 0x000B1704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganResetTimeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.ResetTime == other.ResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x000B3560 File Offset: 0x000B1760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ResetTime != 0)
			{
				num ^= this.ResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x000B35D7 File Offset: 0x000B17D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x000B35E4 File Offset: 0x000B17E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x000B35F0 File Offset: 0x000B17F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ResetTime != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ResetTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x000B3668 File Offset: 0x000B1868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ResetTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x000B36D8 File Offset: 0x000B18D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonOrganResetTimeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ResetTime != 0)
			{
				this.ResetTime = other.ResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x000B373C File Offset: 0x000B193C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x000B3748 File Offset: 0x000B1948
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
					if (num != 72U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResetTime = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003068 RID: 12392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003069 RID: 12393
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400306A RID: 12394
		private ErrorCode errorCode_;

		// Token: 0x0400306B RID: 12395
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400306C RID: 12396
		private long entityId_;

		// Token: 0x0400306D RID: 12397
		public const int ResetTimeFieldNumber = 15;

		// Token: 0x0400306E RID: 12398
		private int resetTime_;
	}
}
