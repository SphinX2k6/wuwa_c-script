using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FE RID: 766
	[NetMessage(EMessageId.CoopRoleRewardResponse)]
	public sealed class CoopRoleRewardResponse : IMessage<CoopRoleRewardResponse>, IMessage, IEquatable<CoopRoleRewardResponse>, IDeepCloneable<CoopRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x06004D75 RID: 19829 RVA: 0x000BC5D1 File Offset: 0x000BA7D1
		[NullableContext(1)]
		public static CoopRoleRewardResponse Create()
		{
			return new CoopRoleRewardResponse();
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004D77 RID: 19831 RVA: 0x000BC5DB File Offset: 0x000BA7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x000BC5E2 File Offset: 0x000BA7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse()
		{
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x000BC5EA File Offset: 0x000BA7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse(CoopRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x000BC60F File Offset: 0x000BA80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse Clone()
		{
			return new CoopRoleRewardResponse(this);
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06004D7B RID: 19835 RVA: 0x000BC617 File Offset: 0x000BA817
		// (set) Token: 0x06004D7C RID: 19836 RVA: 0x000BC61F File Offset: 0x000BA81F
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

		// Token: 0x06004D7D RID: 19837 RVA: 0x000BC628 File Offset: 0x000BA828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleRewardResponse);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x000BC636 File Offset: 0x000BA836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x000BC664 File Offset: 0x000BA864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x000BC6A9 File Offset: 0x000BA8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x000BC6B6 File Offset: 0x000BA8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x000BC6BF File Offset: 0x000BA8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x000BC6F4 File Offset: 0x000BA8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x000BC732 File Offset: 0x000BA932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x000BC763 File Offset: 0x000BA963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x000BC76C File Offset: 0x000BA96C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400314E RID: 12622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400314F RID: 12623
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003150 RID: 12624
		private ErrorCode errorCode_;
	}
}
