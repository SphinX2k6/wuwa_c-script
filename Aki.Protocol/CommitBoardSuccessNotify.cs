using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C0 RID: 704
	[NetMessage(EMessageId.CommitBoardSuccessNotify)]
	public sealed class CommitBoardSuccessNotify : IMessage<CommitBoardSuccessNotify>, IMessage, IEquatable<CommitBoardSuccessNotify>, IDeepCloneable<CommitBoardSuccessNotify>, IBufferMessage
	{
		// Token: 0x060048D1 RID: 18641 RVA: 0x000B2E19 File Offset: 0x000B1019
		[NullableContext(1)]
		public static CommitBoardSuccessNotify Create()
		{
			return new CommitBoardSuccessNotify();
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x000B2E20 File Offset: 0x000B1020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x000B2E23 File Offset: 0x000B1023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardSuccessNotify.Descriptor;
			}
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x000B2E2A File Offset: 0x000B102A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify()
		{
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x000B2E32 File Offset: 0x000B1032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify(CommitBoardSuccessNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x000B2E57 File Offset: 0x000B1057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify Clone()
		{
			return new CommitBoardSuccessNotify(this);
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x000B2E5F File Offset: 0x000B105F
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x000B2E67 File Offset: 0x000B1067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardEntityId
		{
			get
			{
				return this.boardEntityId_;
			}
			set
			{
				this.boardEntityId_ = value;
			}
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x000B2E70 File Offset: 0x000B1070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardSuccessNotify);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x000B2E7E File Offset: 0x000B107E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardSuccessNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x000B2EAC File Offset: 0x000B10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoardEntityId != 0L)
			{
				num ^= this.BoardEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x000B2EEB File Offset: 0x000B10EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x000B2EF8 File Offset: 0x000B10F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x000B2F01 File Offset: 0x000B1101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x000B2F34 File Offset: 0x000B1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoardEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x000B2F72 File Offset: 0x000B1172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommitBoardSuccessNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoardEntityId != 0L)
			{
				this.BoardEntityId = other.BoardEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x000B2FA3 File Offset: 0x000B11A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x000B2FAC File Offset: 0x000B11AC
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
					this.BoardEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400305D RID: 12381
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400305E RID: 12382
		public const int BoardEntityIdFieldNumber = 8;

		// Token: 0x0400305F RID: 12383
		private long boardEntityId_;
	}
}
