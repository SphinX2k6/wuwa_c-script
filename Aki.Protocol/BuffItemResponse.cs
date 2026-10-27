using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000204 RID: 516
	[NetMessage(EMessageId.BuffItemResponse)]
	public sealed class BuffItemResponse : IMessage<BuffItemResponse>, IMessage, IEquatable<BuffItemResponse>, IDeepCloneable<BuffItemResponse>, IBufferMessage
	{
		// Token: 0x06003907 RID: 14599 RVA: 0x0008E40B File Offset: 0x0008C60B
		[NullableContext(1)]
		public static BuffItemResponse Create()
		{
			return new BuffItemResponse();
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x0008E412 File Offset: 0x0008C612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x0008E415 File Offset: 0x0008C615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemResponse.Descriptor;
			}
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0008E41C File Offset: 0x0008C61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse()
		{
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0008E424 File Offset: 0x0008C624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse(BuffItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buffItemInfo_ = ((other.buffItemInfo_ != null) ? other.buffItemInfo_.Clone() : null);
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0008E47C File Offset: 0x0008C67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemResponse Clone()
		{
			return new BuffItemResponse(this);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0008E484 File Offset: 0x0008C684
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x0008E48C File Offset: 0x0008C68C
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x0008E495 File Offset: 0x0008C695
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x0008E49D File Offset: 0x0008C69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem BuffItemInfo
		{
			get
			{
				return this.buffItemInfo_;
			}
			set
			{
				this.buffItemInfo_ = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0008E4A6 File Offset: 0x0008C6A6
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x0008E4AE File Offset: 0x0008C6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x0008E4B7 File Offset: 0x0008C6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemResponse);
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0008E4C8 File Offset: 0x0008C6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.BuffItemInfo, other.BuffItemInfo) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0008E528 File Offset: 0x0008C728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.buffItemInfo_ != null)
			{
				num ^= this.BuffItemInfo.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x0008E59C File Offset: 0x0008C79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0008E5A9 File Offset: 0x0008C7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0008E5B4 File Offset: 0x0008C7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffItemInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BuffItemInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0008E62C File Offset: 0x0008C82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.buffItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffItemInfo);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0008E69C File Offset: 0x0008C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.buffItemInfo_ != null)
			{
				if (this.buffItemInfo_ == null)
				{
					this.BuffItemInfo = new BuffItem();
				}
				this.BuffItemInfo.MergeFrom(other.BuffItemInfo);
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0008E718 File Offset: 0x0008C918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x0008E724 File Offset: 0x0008C924
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.buffItemInfo_ == null)
					{
						this.BuffItemInfo = new BuffItem();
					}
					input.ReadMessage(this.BuffItemInfo);
				}
			}
		}

		// Token: 0x04002B5E RID: 11102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B5F RID: 11103
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002B60 RID: 11104
		private ErrorCode errorCode_;

		// Token: 0x04002B61 RID: 11105
		public const int BuffItemInfoFieldNumber = 1;

		// Token: 0x04002B62 RID: 11106
		private BuffItem buffItemInfo_;

		// Token: 0x04002B63 RID: 11107
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04002B64 RID: 11108
		private int roleId_;
	}
}
