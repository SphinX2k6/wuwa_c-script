using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037D RID: 893
	[NetMessage(EMessageId.DangoBrawlTaskRewardResponse)]
	public sealed class DangoBrawlTaskRewardResponse : IMessage<DangoBrawlTaskRewardResponse>, IMessage, IEquatable<DangoBrawlTaskRewardResponse>, IDeepCloneable<DangoBrawlTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005888 RID: 22664 RVA: 0x000D7C9C File Offset: 0x000D5E9C
		[NullableContext(1)]
		public static DangoBrawlTaskRewardResponse Create()
		{
			return new DangoBrawlTaskRewardResponse();
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x000D7CA3 File Offset: 0x000D5EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600588A RID: 22666 RVA: 0x000D7CA6 File Offset: 0x000D5EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x000D7CAD File Offset: 0x000D5EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse()
		{
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x000D7CB5 File Offset: 0x000D5EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse(DangoBrawlTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x000D7CDA File Offset: 0x000D5EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse Clone()
		{
			return new DangoBrawlTaskRewardResponse(this);
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x000D7CE2 File Offset: 0x000D5EE2
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x000D7CEA File Offset: 0x000D5EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x000D7CF3 File Offset: 0x000D5EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskRewardResponse);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x000D7D01 File Offset: 0x000D5F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x000D7D30 File Offset: 0x000D5F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x000D7D75 File Offset: 0x000D5F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x000D7D82 File Offset: 0x000D5F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x000D7D8B File Offset: 0x000D5F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x000D7DC0 File Offset: 0x000D5FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x000D7DFE File Offset: 0x000D5FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x000D7E2F File Offset: 0x000D602F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x000D7E38 File Offset: 0x000D6038
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003518 RID: 13592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003519 RID: 13593
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x0400351A RID: 13594
		private ErrorCode errCode_;
	}
}
