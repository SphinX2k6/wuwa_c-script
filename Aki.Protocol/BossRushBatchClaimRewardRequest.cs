using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CE RID: 462
	[NetMessage(EMessageId.BossRushBatchClaimRewardRequest)]
	public sealed class BossRushBatchClaimRewardRequest : IMessage<BossRushBatchClaimRewardRequest>, IMessage, IEquatable<BossRushBatchClaimRewardRequest>, IDeepCloneable<BossRushBatchClaimRewardRequest>, IBufferMessage
	{
		// Token: 0x060034B0 RID: 13488 RVA: 0x00084D1C File Offset: 0x00082F1C
		[NullableContext(1)]
		public static BossRushBatchClaimRewardRequest Create()
		{
			return new BossRushBatchClaimRewardRequest();
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x00084D23 File Offset: 0x00082F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00084D26 File Offset: 0x00082F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBatchClaimRewardRequest.Descriptor;
			}
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00084D2D File Offset: 0x00082F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest()
		{
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00084D40 File Offset: 0x00082F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest(BossRushBatchClaimRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskRewardIds_ = other.taskRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00084D76 File Offset: 0x00082F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest Clone()
		{
			return new BossRushBatchClaimRewardRequest(this);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x00084D7E File Offset: 0x00082F7E
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x00084D86 File Offset: 0x00082F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x00084D8F File Offset: 0x00082F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskRewardIds
		{
			get
			{
				return this.taskRewardIds_;
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00084D97 File Offset: 0x00082F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBatchClaimRewardRequest);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00084DA8 File Offset: 0x00082FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBatchClaimRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskRewardIds_.Equals(other.taskRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00084DF8 File Offset: 0x00082FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00084E45 File Offset: 0x00083045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00084E52 File Offset: 0x00083052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00084E5C File Offset: 0x0008305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.taskRewardIds_.WriteTo(ref output, BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00084EAC File Offset: 0x000830AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskRewardIds_.CalculateSize(BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00084F00 File Offset: 0x00083100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBatchClaimRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskRewardIds_.Add(other.taskRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00084F4D File Offset: 0x0008314D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00084F58 File Offset: 0x00083158
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
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskRewardIds_.AddEntriesFrom(ref input, BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A1C RID: 10780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A1D RID: 10781
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04002A1E RID: 10782
		private int activityId_;

		// Token: 0x04002A1F RID: 10783
		public const int TaskRewardIdsFieldNumber = 14;

		// Token: 0x04002A20 RID: 10784
		private static readonly FieldCodec<int> _repeated_taskRewardIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04002A21 RID: 10785
		private readonly RepeatedField<int> taskRewardIds_ = new RepeatedField<int>();
	}
}
