using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DD RID: 1245
	[NetMessage(EMessageId.ExploreActivityTaskRewardRequest)]
	public sealed class ExploreActivityTaskRewardRequest : IMessage<ExploreActivityTaskRewardRequest>, IMessage, IEquatable<ExploreActivityTaskRewardRequest>, IDeepCloneable<ExploreActivityTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600763C RID: 30268 RVA: 0x001210A7 File Offset: 0x0011F2A7
		[NullableContext(1)]
		public static ExploreActivityTaskRewardRequest Create()
		{
			return new ExploreActivityTaskRewardRequest();
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x0600763D RID: 30269 RVA: 0x001210AE File Offset: 0x0011F2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x001210B1 File Offset: 0x0011F2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x001210B8 File Offset: 0x0011F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest()
		{
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x001210C0 File Offset: 0x0011F2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest(ExploreActivityTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x001210E5 File Offset: 0x0011F2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest Clone()
		{
			return new ExploreActivityTaskRewardRequest(this);
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x001210ED File Offset: 0x0011F2ED
		// (set) Token: 0x06007643 RID: 30275 RVA: 0x001210F5 File Offset: 0x0011F2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x001210FE File Offset: 0x0011F2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskRewardRequest);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x0012110C File Offset: 0x0011F30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x0012113C File Offset: 0x0011F33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x0012117B File Offset: 0x0011F37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00121188 File Offset: 0x0011F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00121191 File Offset: 0x0011F391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x001211C4 File Offset: 0x0011F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00121202 File Offset: 0x0011F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreActivityTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00121233 File Offset: 0x0011F433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x0012123C File Offset: 0x0011F43C
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
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E30 RID: 15920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E31 RID: 15921
		public const int TaskIdFieldNumber = 8;

		// Token: 0x04003E32 RID: 15922
		private int taskId_;
	}
}
