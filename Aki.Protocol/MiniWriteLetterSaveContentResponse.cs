using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D9 RID: 2521
	[NetMessage(EMessageId.MiniWriteLetterSaveContentResponse)]
	public sealed class MiniWriteLetterSaveContentResponse : IMessage<MiniWriteLetterSaveContentResponse>, IMessage, IEquatable<MiniWriteLetterSaveContentResponse>, IDeepCloneable<MiniWriteLetterSaveContentResponse>, IBufferMessage
	{
		// Token: 0x0600DD04 RID: 56580 RVA: 0x00206FA1 File Offset: 0x002051A1
		[NullableContext(1)]
		public static MiniWriteLetterSaveContentResponse Create()
		{
			return new MiniWriteLetterSaveContentResponse();
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600DD05 RID: 56581 RVA: 0x00206FA8 File Offset: 0x002051A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x00206FAB File Offset: 0x002051AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniWriteLetterSaveContentResponse.Descriptor;
			}
		}

		// Token: 0x0600DD07 RID: 56583 RVA: 0x00206FB2 File Offset: 0x002051B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse()
		{
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x00206FBA File Offset: 0x002051BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse(MiniWriteLetterSaveContentResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x00206FDF File Offset: 0x002051DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniWriteLetterSaveContentResponse Clone()
		{
			return new MiniWriteLetterSaveContentResponse(this);
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x00206FE7 File Offset: 0x002051E7
		// (set) Token: 0x0600DD0B RID: 56587 RVA: 0x00206FEF File Offset: 0x002051EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600DD0C RID: 56588 RVA: 0x00206FF8 File Offset: 0x002051F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniWriteLetterSaveContentResponse);
		}

		// Token: 0x0600DD0D RID: 56589 RVA: 0x00207006 File Offset: 0x00205206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniWriteLetterSaveContentResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD0E RID: 56590 RVA: 0x00207034 File Offset: 0x00205234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD0F RID: 56591 RVA: 0x00207079 File Offset: 0x00205279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD10 RID: 56592 RVA: 0x00207086 File Offset: 0x00205286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD11 RID: 56593 RVA: 0x0020708F File Offset: 0x0020528F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD12 RID: 56594 RVA: 0x002070C4 File Offset: 0x002052C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD13 RID: 56595 RVA: 0x00207102 File Offset: 0x00205302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniWriteLetterSaveContentResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x00207133 File Offset: 0x00205333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD15 RID: 56597 RVA: 0x0020713C File Offset: 0x0020533C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B79 RID: 23417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B7A RID: 23418
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04005B7B RID: 23419
		private ErrorCode errorId_;
	}
}
