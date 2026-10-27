using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BD RID: 701
	[NetMessage(EMessageId.CommonOrganResetTimeResponse)]
	public sealed class CommonOrganResetTimeResponse : IMessage<CommonOrganResetTimeResponse>, IMessage, IEquatable<CommonOrganResetTimeResponse>, IDeepCloneable<CommonOrganResetTimeResponse>, IBufferMessage
	{
		// Token: 0x06004842 RID: 18498 RVA: 0x000B125D File Offset: 0x000AF45D
		[NullableContext(1)]
		public static CommonOrganResetTimeResponse Create()
		{
			return new CommonOrganResetTimeResponse();
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x000B1264 File Offset: 0x000AF464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x000B1267 File Offset: 0x000AF467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganResetTimeResponse.Descriptor;
			}
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x000B126E File Offset: 0x000AF46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse()
		{
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x000B1276 File Offset: 0x000AF476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse(CommonOrganResetTimeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.resetTime_ = other.resetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x000B12B3 File Offset: 0x000AF4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganResetTimeResponse Clone()
		{
			return new CommonOrganResetTimeResponse(this);
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x000B12BB File Offset: 0x000AF4BB
		// (set) Token: 0x06004849 RID: 18505 RVA: 0x000B12C3 File Offset: 0x000AF4C3
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x000B12CC File Offset: 0x000AF4CC
		// (set) Token: 0x0600484B RID: 18507 RVA: 0x000B12D4 File Offset: 0x000AF4D4
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x000B12DD File Offset: 0x000AF4DD
		// (set) Token: 0x0600484D RID: 18509 RVA: 0x000B12E5 File Offset: 0x000AF4E5
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

		// Token: 0x0600484E RID: 18510 RVA: 0x000B12EE File Offset: 0x000AF4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganResetTimeResponse);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x000B12FC File Offset: 0x000AF4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganResetTimeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.ResetTime == other.ResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x000B1358 File Offset: 0x000AF558
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

		// Token: 0x06004851 RID: 18513 RVA: 0x000B13CF File Offset: 0x000AF5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000B13DC File Offset: 0x000AF5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000B13E8 File Offset: 0x000AF5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.ResetTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ResetTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x000B1460 File Offset: 0x000AF660
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

		// Token: 0x06004855 RID: 18517 RVA: 0x000B14D0 File Offset: 0x000AF6D0
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

		// Token: 0x06004856 RID: 18518 RVA: 0x000B1534 File Offset: 0x000AF734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x000B1540 File Offset: 0x000AF740
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.ResetTime = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002FD5 RID: 12245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD6 RID: 12246
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002FD7 RID: 12247
		private ErrorCode errorCode_;

		// Token: 0x04002FD8 RID: 12248
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04002FD9 RID: 12249
		private long entityId_;

		// Token: 0x04002FDA RID: 12250
		public const int ResetTimeFieldNumber = 11;

		// Token: 0x04002FDB RID: 12251
		private int resetTime_;
	}
}
