using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000542 RID: 1346
	[NetMessage(EMessageId.FishingActivityLimitRewardRequest)]
	public sealed class FishingActivityLimitRewardRequest : IMessage<FishingActivityLimitRewardRequest>, IMessage, IEquatable<FishingActivityLimitRewardRequest>, IDeepCloneable<FishingActivityLimitRewardRequest>, IBufferMessage
	{
		// Token: 0x06007E06 RID: 32262 RVA: 0x00131501 File Offset: 0x0012F701
		[NullableContext(1)]
		public static FishingActivityLimitRewardRequest Create()
		{
			return new FishingActivityLimitRewardRequest();
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x00131508 File Offset: 0x0012F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06007E08 RID: 32264 RVA: 0x0013150B File Offset: 0x0012F70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x00131512 File Offset: 0x0012F712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest()
		{
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x0013151A File Offset: 0x0012F71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest(FishingActivityLimitRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0013153F File Offset: 0x0012F73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardRequest Clone()
		{
			return new FishingActivityLimitRewardRequest(this);
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06007E0C RID: 32268 RVA: 0x00131547 File Offset: 0x0012F747
		// (set) Token: 0x06007E0D RID: 32269 RVA: 0x0013154F File Offset: 0x0012F74F
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

		// Token: 0x06007E0E RID: 32270 RVA: 0x00131558 File Offset: 0x0012F758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitRewardRequest);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x00131566 File Offset: 0x0012F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x00131594 File Offset: 0x0012F794
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

		// Token: 0x06007E11 RID: 32273 RVA: 0x001315D3 File Offset: 0x0012F7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x001315E0 File Offset: 0x0012F7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x001315E9 File Offset: 0x0012F7E9
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

		// Token: 0x06007E14 RID: 32276 RVA: 0x0013161C File Offset: 0x0012F81C
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

		// Token: 0x06007E15 RID: 32277 RVA: 0x0013165A File Offset: 0x0012F85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityLimitRewardRequest other)
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

		// Token: 0x06007E16 RID: 32278 RVA: 0x0013168B File Offset: 0x0012F88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x00131694 File Offset: 0x0012F894
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

		// Token: 0x04004003 RID: 16387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004004 RID: 16388
		public const int TaskIdFieldNumber = 14;

		// Token: 0x04004005 RID: 16389
		private int taskId_;
	}
}
