using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B8 RID: 696
	[NetMessage(EMessageId.CommitBoardRequest)]
	public sealed class CommitBoardRequest : IMessage<CommitBoardRequest>, IMessage, IEquatable<CommitBoardRequest>, IDeepCloneable<CommitBoardRequest>, IBufferMessage
	{
		// Token: 0x060047E6 RID: 18406 RVA: 0x000B085B File Offset: 0x000AEA5B
		[NullableContext(1)]
		public static CommitBoardRequest Create()
		{
			return new CommitBoardRequest();
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x000B0862 File Offset: 0x000AEA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x000B0865 File Offset: 0x000AEA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommitBoardRequest.Descriptor;
			}
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x000B086C File Offset: 0x000AEA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest()
		{
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x000B0874 File Offset: 0x000AEA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest(CommitBoardRequest other) : this()
		{
			this.boardEntityId_ = other.boardEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x000B0899 File Offset: 0x000AEA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommitBoardRequest Clone()
		{
			return new CommitBoardRequest(this);
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x000B08A1 File Offset: 0x000AEAA1
		// (set) Token: 0x060047ED RID: 18413 RVA: 0x000B08A9 File Offset: 0x000AEAA9
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

		// Token: 0x060047EE RID: 18414 RVA: 0x000B08B2 File Offset: 0x000AEAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommitBoardRequest);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x000B08C0 File Offset: 0x000AEAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommitBoardRequest other)
		{
			return other != null && (other == this || (this.BoardEntityId == other.BoardEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x000B08F0 File Offset: 0x000AEAF0
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

		// Token: 0x060047F1 RID: 18417 RVA: 0x000B092F File Offset: 0x000AEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x000B093C File Offset: 0x000AEB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x000B0945 File Offset: 0x000AEB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoardEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BoardEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x000B0978 File Offset: 0x000AEB78
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

		// Token: 0x060047F5 RID: 18421 RVA: 0x000B09B6 File Offset: 0x000AEBB6
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

		// Token: 0x060047F6 RID: 18422 RVA: 0x000B09E7 File Offset: 0x000AEBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x000B09F0 File Offset: 0x000AEBF0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BoardEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002FC4 RID: 12228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC5 RID: 12229
		public const int BoardEntityIdFieldNumber = 4;

		// Token: 0x04002FC6 RID: 12230
		private long boardEntityId_;
	}
}
