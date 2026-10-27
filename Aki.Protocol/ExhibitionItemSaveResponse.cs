using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EA RID: 1258
	[NetMessage(EMessageId.ExhibitionItemSaveResponse)]
	public sealed class ExhibitionItemSaveResponse : IMessage<ExhibitionItemSaveResponse>, IMessage, IEquatable<ExhibitionItemSaveResponse>, IDeepCloneable<ExhibitionItemSaveResponse>, IBufferMessage
	{
		// Token: 0x06007713 RID: 30483 RVA: 0x00122D81 File Offset: 0x00120F81
		[NullableContext(1)]
		public static ExhibitionItemSaveResponse Create()
		{
			return new ExhibitionItemSaveResponse();
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00122D88 File Offset: 0x00120F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06007715 RID: 30485 RVA: 0x00122D8B File Offset: 0x00120F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionItemSaveResponse.Descriptor;
			}
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00122D92 File Offset: 0x00120F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse()
		{
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00122D9A File Offset: 0x00120F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse(ExhibitionItemSaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00122DBF File Offset: 0x00120FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveResponse Clone()
		{
			return new ExhibitionItemSaveResponse(this);
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06007719 RID: 30489 RVA: 0x00122DC7 File Offset: 0x00120FC7
		// (set) Token: 0x0600771A RID: 30490 RVA: 0x00122DCF File Offset: 0x00120FCF
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

		// Token: 0x0600771B RID: 30491 RVA: 0x00122DD8 File Offset: 0x00120FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionItemSaveResponse);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00122DE6 File Offset: 0x00120FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionItemSaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00122E14 File Offset: 0x00121014
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

		// Token: 0x0600771E RID: 30494 RVA: 0x00122E59 File Offset: 0x00121059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00122E66 File Offset: 0x00121066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00122E6F File Offset: 0x0012106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00122EA4 File Offset: 0x001210A4
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

		// Token: 0x06007722 RID: 30498 RVA: 0x00122EE2 File Offset: 0x001210E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExhibitionItemSaveResponse other)
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

		// Token: 0x06007723 RID: 30499 RVA: 0x00122F13 File Offset: 0x00121113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00122F1C File Offset: 0x0012111C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E1F RID: 15903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E20 RID: 15904
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04003E21 RID: 15905
		private ErrorCode errCode_;
	}
}
