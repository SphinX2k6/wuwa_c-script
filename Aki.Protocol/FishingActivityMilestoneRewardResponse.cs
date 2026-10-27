using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000548 RID: 1352
	[NetMessage(EMessageId.FishingActivityMilestoneRewardResponse)]
	public sealed class FishingActivityMilestoneRewardResponse : IMessage<FishingActivityMilestoneRewardResponse>, IMessage, IEquatable<FishingActivityMilestoneRewardResponse>, IDeepCloneable<FishingActivityMilestoneRewardResponse>, IBufferMessage
	{
		// Token: 0x06007E74 RID: 32372 RVA: 0x00132124 File Offset: 0x00130324
		[NullableContext(1)]
		public static FishingActivityMilestoneRewardResponse Create()
		{
			return new FishingActivityMilestoneRewardResponse();
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06007E75 RID: 32373 RVA: 0x0013212B File Offset: 0x0013032B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x0013212E File Offset: 0x0013032E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00132135 File Offset: 0x00130335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse()
		{
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x0013213D File Offset: 0x0013033D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse(FishingActivityMilestoneRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x00132162 File Offset: 0x00130362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse Clone()
		{
			return new FishingActivityMilestoneRewardResponse(this);
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x0013216A File Offset: 0x0013036A
		// (set) Token: 0x06007E7B RID: 32379 RVA: 0x00132172 File Offset: 0x00130372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0013217B File Offset: 0x0013037B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneRewardResponse);
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x00132189 File Offset: 0x00130389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x001321B8 File Offset: 0x001303B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x001321FD File Offset: 0x001303FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0013220A File Offset: 0x0013040A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x00132213 File Offset: 0x00130413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x00132248 File Offset: 0x00130448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x00132286 File Offset: 0x00130486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityMilestoneRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x001322B7 File Offset: 0x001304B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x001322C0 File Offset: 0x001304C0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400401A RID: 16410
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400401B RID: 16411
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400401C RID: 16412
		private ErrorCode errorCode_;
	}
}
