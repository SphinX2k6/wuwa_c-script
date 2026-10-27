using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000368 RID: 872
	[NetMessage(EMessageId.DangoBrawlScoreRewardRequest)]
	public sealed class DangoBrawlScoreRewardRequest : IMessage<DangoBrawlScoreRewardRequest>, IMessage, IEquatable<DangoBrawlScoreRewardRequest>, IDeepCloneable<DangoBrawlScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x060056E6 RID: 22246 RVA: 0x000D4640 File Offset: 0x000D2840
		[NullableContext(1)]
		public static DangoBrawlScoreRewardRequest Create()
		{
			return new DangoBrawlScoreRewardRequest();
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x000D4647 File Offset: 0x000D2847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060056E8 RID: 22248 RVA: 0x000D464A File Offset: 0x000D284A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x000D4651 File Offset: 0x000D2851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest()
		{
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x000D4664 File Offset: 0x000D2864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest(DangoBrawlScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x000D469A File Offset: 0x000D289A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardRequest Clone()
		{
			return new DangoBrawlScoreRewardRequest(this);
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x000D46A2 File Offset: 0x000D28A2
		// (set) Token: 0x060056ED RID: 22253 RVA: 0x000D46AA File Offset: 0x000D28AA
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060056EE RID: 22254 RVA: 0x000D46B3 File Offset: 0x000D28B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x000D46BB File Offset: 0x000D28BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlScoreRewardRequest);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x000D46CC File Offset: 0x000D28CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x000D471C File Offset: 0x000D291C
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

		// Token: 0x060056F2 RID: 22258 RVA: 0x000D4769 File Offset: 0x000D2969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x000D4776 File Offset: 0x000D2976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x000D4780 File Offset: 0x000D2980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.scoreIds_.WriteTo(ref output, DangoBrawlScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x000D47D0 File Offset: 0x000D29D0
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

		// Token: 0x060056F6 RID: 22262 RVA: 0x000D4824 File Offset: 0x000D2A24
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

		// Token: 0x060056F7 RID: 22263 RVA: 0x000D4871 File Offset: 0x000D2A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x000D487C File Offset: 0x000D2A7C
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
				if (num != 48U)
				{
					if (num != 88U && num != 90U)
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

		// Token: 0x040034AA RID: 13482
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034AB RID: 13483
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040034AC RID: 13484
		private int activityId_;

		// Token: 0x040034AD RID: 13485
		public const int ScoreIdsFieldNumber = 11;

		// Token: 0x040034AE RID: 13486
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040034AF RID: 13487
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
