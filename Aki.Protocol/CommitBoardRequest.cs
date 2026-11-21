using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BE RID: 702
	[NetMessage(EMessageId.CommitBoardRequest)]
	public sealed class CommitBoardRequest : IMessage<CommitBoardRequest>, IMessage, IEquatable<CommitBoardRequest>, IDeepCloneable<CommitBoardRequest>, IBufferMessage
	{
		// Token: 0x060048AD RID: 18605 RVA: 0x000B2A5F File Offset: 0x000B0C5F
		[NullableContext(1)]
		public static CommitBoardRequest Create()
		{
			return new CommitBoardRequest();
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x000B2A66 File Offset: 0x000B0C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060048AF RID: 18607 RVA: 0x000B2A69 File Offset: 0x000B0C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardRequest.Descriptor;
			}
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x000B2A70 File Offset: 0x000B0C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest()
		{
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x000B2A78 File Offset: 0x000B0C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest(CommitBoardRequest other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x000B2A9D File Offset: 0x000B0C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest Clone()
		{
			return new CommitBoardRequest(this);
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x000B2AA5 File Offset: 0x000B0CA5
		// (set) Token: 0x060048B4 RID: 18612 RVA: 0x000B2AAD File Offset: 0x000B0CAD
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

		// Token: 0x060048B5 RID: 18613 RVA: 0x000B2AB6 File Offset: 0x000B0CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardRequest);
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x000B2AC4 File Offset: 0x000B0CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardRequest other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x000B2AF4 File Offset: 0x000B0CF4
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

		// Token: 0x060048B8 RID: 18616 RVA: 0x000B2B33 File Offset: 0x000B0D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x000B2B40 File Offset: 0x000B0D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x000B2B49 File Offset: 0x000B0D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x000B2B7C File Offset: 0x000B0D7C
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

		// Token: 0x060048BC RID: 18620 RVA: 0x000B2BBA File Offset: 0x000B0DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommitBoardRequest other)
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

		// Token: 0x060048BD RID: 18621 RVA: 0x000B2BEB File Offset: 0x000B0DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x000B2BF4 File Offset: 0x000B0DF4
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
					this.BoardEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003057 RID: 12375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003058 RID: 12376
		public const int BoardEntityIdFieldNumber = 2;

		// Token: 0x04003059 RID: 12377
		private long boardEntityId_;
	}
}
