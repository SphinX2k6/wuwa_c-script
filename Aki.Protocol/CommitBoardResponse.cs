using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B9 RID: 697
	[NetMessage(EMessageId.CommitBoardResponse)]
	public sealed class CommitBoardResponse : IMessage<CommitBoardResponse>, IMessage, IEquatable<CommitBoardResponse>, IDeepCloneable<CommitBoardResponse>, IBufferMessage
	{
		// Token: 0x060047F8 RID: 18424 RVA: 0x000B0A35 File Offset: 0x000AEC35
		[NullableContext(1)]
		public static CommitBoardResponse Create()
		{
			return new CommitBoardResponse();
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x000B0A3C File Offset: 0x000AEC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x000B0A3F File Offset: 0x000AEC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardResponse.Descriptor;
			}
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x000B0A46 File Offset: 0x000AEC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse()
		{
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x000B0A4E File Offset: 0x000AEC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse(CommitBoardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000B0A73 File Offset: 0x000AEC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse Clone()
		{
			return new CommitBoardResponse(this);
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x000B0A7B File Offset: 0x000AEC7B
		// (set) Token: 0x060047FF RID: 18431 RVA: 0x000B0A83 File Offset: 0x000AEC83
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

		// Token: 0x06004800 RID: 18432 RVA: 0x000B0A8C File Offset: 0x000AEC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardResponse);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000B0A9A File Offset: 0x000AEC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x000B0AC8 File Offset: 0x000AECC8
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

		// Token: 0x06004803 RID: 18435 RVA: 0x000B0B0D File Offset: 0x000AED0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x000B0B1A File Offset: 0x000AED1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x000B0B23 File Offset: 0x000AED23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x000B0B58 File Offset: 0x000AED58
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

		// Token: 0x06004807 RID: 18439 RVA: 0x000B0B96 File Offset: 0x000AED96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommitBoardResponse other)
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

		// Token: 0x06004808 RID: 18440 RVA: 0x000B0BC7 File Offset: 0x000AEDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x000B0BD0 File Offset: 0x000AEDD0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002FC7 RID: 12231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC8 RID: 12232
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04002FC9 RID: 12233
		private ErrorCode errCode_;
	}
}
