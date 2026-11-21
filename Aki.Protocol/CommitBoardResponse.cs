using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BF RID: 703
	[NetMessage(EMessageId.CommitBoardResponse)]
	public sealed class CommitBoardResponse : IMessage<CommitBoardResponse>, IMessage, IEquatable<CommitBoardResponse>, IDeepCloneable<CommitBoardResponse>, IBufferMessage
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x000B2C39 File Offset: 0x000B0E39
		[NullableContext(1)]
		public static CommitBoardResponse Create()
		{
			return new CommitBoardResponse();
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x000B2C40 File Offset: 0x000B0E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x000B2C43 File Offset: 0x000B0E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardResponse.Descriptor;
			}
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x000B2C4A File Offset: 0x000B0E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse()
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x000B2C52 File Offset: 0x000B0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse(CommitBoardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x000B2C77 File Offset: 0x000B0E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardResponse Clone()
		{
			return new CommitBoardResponse(this);
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x000B2C7F File Offset: 0x000B0E7F
		// (set) Token: 0x060048C6 RID: 18630 RVA: 0x000B2C87 File Offset: 0x000B0E87
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

		// Token: 0x060048C7 RID: 18631 RVA: 0x000B2C90 File Offset: 0x000B0E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardResponse);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x000B2C9E File Offset: 0x000B0E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x000B2CCC File Offset: 0x000B0ECC
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

		// Token: 0x060048CA RID: 18634 RVA: 0x000B2D11 File Offset: 0x000B0F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x000B2D1E File Offset: 0x000B0F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x000B2D27 File Offset: 0x000B0F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x000B2D5C File Offset: 0x000B0F5C
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

		// Token: 0x060048CE RID: 18638 RVA: 0x000B2D9A File Offset: 0x000B0F9A
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

		// Token: 0x060048CF RID: 18639 RVA: 0x000B2DCB File Offset: 0x000B0FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x000B2DD4 File Offset: 0x000B0FD4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400305A RID: 12378
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400305B RID: 12379
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x0400305C RID: 12380
		private ErrorCode errCode_;
	}
}
