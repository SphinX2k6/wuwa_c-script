using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000370 RID: 880
	[NetMessage(EMessageId.DangoBrawlScoreRewardRequest)]
	public sealed class DangoBrawlScoreRewardRequest : IMessage<DangoBrawlScoreRewardRequest>, IMessage, IEquatable<DangoBrawlScoreRewardRequest>, IDeepCloneable<DangoBrawlScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x060057D3 RID: 22483 RVA: 0x000D6CC8 File Offset: 0x000D4EC8
		[NullableContext(1)]
		public static DangoBrawlScoreRewardRequest Create()
		{
			return new DangoBrawlScoreRewardRequest();
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x000D6CCF File Offset: 0x000D4ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060057D5 RID: 22485 RVA: 0x000D6CD2 File Offset: 0x000D4ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x000D6CD9 File Offset: 0x000D4ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest()
		{
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x000D6CEC File Offset: 0x000D4EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest(DangoBrawlScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x000D6D22 File Offset: 0x000D4F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest Clone()
		{
			return new DangoBrawlScoreRewardRequest(this);
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060057D9 RID: 22489 RVA: 0x000D6D2A File Offset: 0x000D4F2A
		// (set) Token: 0x060057DA RID: 22490 RVA: 0x000D6D32 File Offset: 0x000D4F32
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

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060057DB RID: 22491 RVA: 0x000D6D3B File Offset: 0x000D4F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x000D6D43 File Offset: 0x000D4F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlScoreRewardRequest);
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x000D6D54 File Offset: 0x000D4F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x000D6DA4 File Offset: 0x000D4FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.scoreIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x000D6DF1 File Offset: 0x000D4FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x000D6DFE File Offset: 0x000D4FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x000D6E08 File Offset: 0x000D5008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.scoreIds_.WriteTo(ref output, DangoBrawlScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x000D6E58 File Offset: 0x000D5058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.scoreIds_.CalculateSize(DangoBrawlScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x000D6EAC File Offset: 0x000D50AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.scoreIds_.Add(other.scoreIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x000D6EF9 File Offset: 0x000D50F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x000D6F04 File Offset: 0x000D5104
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
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scoreIds_.AddEntriesFrom(ref input, DangoBrawlScoreRewardRequest._repeated_scoreIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003546 RID: 13638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003547 RID: 13639
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04003548 RID: 13640
		private int activityId_;

		// Token: 0x04003549 RID: 13641
		public const int ScoreIdsFieldNumber = 12;

		// Token: 0x0400354A RID: 13642
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400354B RID: 13643
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
