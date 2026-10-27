using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BA RID: 698
	[NetMessage(EMessageId.CommitBoardSuccessNotify)]
	public sealed class CommitBoardSuccessNotify : IMessage<CommitBoardSuccessNotify>, IMessage, IEquatable<CommitBoardSuccessNotify>, IDeepCloneable<CommitBoardSuccessNotify>, IBufferMessage
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x000B0C15 File Offset: 0x000AEE15
		[NullableContext(1)]
		public static CommitBoardSuccessNotify Create()
		{
			return new CommitBoardSuccessNotify();
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x000B0C1C File Offset: 0x000AEE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x000B0C1F File Offset: 0x000AEE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardSuccessNotify.Descriptor;
			}
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x000B0C26 File Offset: 0x000AEE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify()
		{
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x000B0C2E File Offset: 0x000AEE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify(CommitBoardSuccessNotify other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x000B0C53 File Offset: 0x000AEE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardSuccessNotify Clone()
		{
			return new CommitBoardSuccessNotify(this);
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x000B0C5B File Offset: 0x000AEE5B
		// (set) Token: 0x06004811 RID: 18449 RVA: 0x000B0C63 File Offset: 0x000AEE63
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

		// Token: 0x06004812 RID: 18450 RVA: 0x000B0C6C File Offset: 0x000AEE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardSuccessNotify);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x000B0C7A File Offset: 0x000AEE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardSuccessNotify other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x000B0CA8 File Offset: 0x000AEEA8
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

		// Token: 0x06004815 RID: 18453 RVA: 0x000B0CE7 File Offset: 0x000AEEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x000B0CF4 File Offset: 0x000AEEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x000B0CFD File Offset: 0x000AEEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x000B0D30 File Offset: 0x000AEF30
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

		// Token: 0x06004819 RID: 18457 RVA: 0x000B0D6E File Offset: 0x000AEF6E
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

		// Token: 0x0600481A RID: 18458 RVA: 0x000B0D9F File Offset: 0x000AEF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x000B0DA8 File Offset: 0x000AEFA8
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
					this.BoardEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002FCA RID: 12234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FCB RID: 12235
		public const int BoardEntityIdFieldNumber = 3;

		// Token: 0x04002FCC RID: 12236
		private long boardEntityId_;
	}
}
