using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F3 RID: 1267
	[NetMessage(EMessageId.ExploreActivityTaskRewardRequest)]
	public sealed class ExploreActivityTaskRewardRequest : IMessage<ExploreActivityTaskRewardRequest>, IMessage, IEquatable<ExploreActivityTaskRewardRequest>, IDeepCloneable<ExploreActivityTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060077B8 RID: 30648 RVA: 0x00123F33 File Offset: 0x00122133
		[NullableContext(1)]
		public static ExploreActivityTaskRewardRequest Create()
		{
			return new ExploreActivityTaskRewardRequest();
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x00123F3A File Offset: 0x0012213A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x060077BA RID: 30650 RVA: 0x00123F3D File Offset: 0x0012213D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x00123F44 File Offset: 0x00122144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest()
		{
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x00123F4C File Offset: 0x0012214C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest(ExploreActivityTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00123F71 File Offset: 0x00122171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardRequest Clone()
		{
			return new ExploreActivityTaskRewardRequest(this);
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x00123F79 File Offset: 0x00122179
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x00123F81 File Offset: 0x00122181
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

		// Token: 0x060077C0 RID: 30656 RVA: 0x00123F8A File Offset: 0x0012218A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskRewardRequest);
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00123F98 File Offset: 0x00122198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00123FC8 File Offset: 0x001221C8
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

		// Token: 0x060077C3 RID: 30659 RVA: 0x00124007 File Offset: 0x00122207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00124014 File Offset: 0x00122214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0012401D File Offset: 0x0012221D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00124050 File Offset: 0x00122250
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

		// Token: 0x060077C7 RID: 30663 RVA: 0x0012408E File Offset: 0x0012228E
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

		// Token: 0x060077C8 RID: 30664 RVA: 0x001240BF File Offset: 0x001222BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x001240C8 File Offset: 0x001222C8
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
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E3F RID: 15935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E40 RID: 15936
		public const int TaskIdFieldNumber = 14;

		// Token: 0x04003E41 RID: 15937
		private int taskId_;
	}
}
