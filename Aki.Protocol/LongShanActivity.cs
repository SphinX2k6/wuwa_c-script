using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000940 RID: 2368
	public sealed class LongShanActivity : IMessage<LongShanActivity>, IMessage, IEquatable<LongShanActivity>, IDeepCloneable<LongShanActivity>, IBufferMessage
	{
		// Token: 0x0600D11E RID: 53534 RVA: 0x001ED9EA File Offset: 0x001EBBEA
		[NullableContext(1)]
		public static LongShanActivity Create()
		{
			return new LongShanActivity();
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600D11F RID: 53535 RVA: 0x001ED9F1 File Offset: 0x001EBBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600D120 RID: 53536 RVA: 0x001ED9F4 File Offset: 0x001EBBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanActivity.Descriptor;
			}
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x001ED9FB File Offset: 0x001EBBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity()
		{
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x001EDA19 File Offset: 0x001EBC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity(LongShanActivity other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this.scoreRewardedIds_ = other.scoreRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x001EDA54 File Offset: 0x001EBC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity Clone()
		{
			return new LongShanActivity(this);
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600D124 RID: 53540 RVA: 0x001EDA5C File Offset: 0x001EBC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600D125 RID: 53541 RVA: 0x001EDA64 File Offset: 0x001EBC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardedIds
		{
			get
			{
				return this.scoreRewardedIds_;
			}
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x001EDA6C File Offset: 0x001EBC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanActivity);
		}

		// Token: 0x0600D127 RID: 53543 RVA: 0x001EDA7C File Offset: 0x001EBC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanActivity other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && this.scoreRewardedIds_.Equals(other.scoreRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D128 RID: 53544 RVA: 0x001EDAD0 File Offset: 0x001EBCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stages_.GetHashCode();
			num ^= this.scoreRewardedIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D129 RID: 53545 RVA: 0x001EDB12 File Offset: 0x001EBD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D12A RID: 53546 RVA: 0x001EDB1F File Offset: 0x001EBD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D12B RID: 53547 RVA: 0x001EDB28 File Offset: 0x001EBD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stages_.WriteTo(ref output, LongShanActivity._repeated_stages_codec);
			this.scoreRewardedIds_.WriteTo(ref output, LongShanActivity._repeated_scoreRewardedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x001EDB60 File Offset: 0x001EBD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stages_.CalculateSize(LongShanActivity._repeated_stages_codec);
			num += this.scoreRewardedIds_.CalculateSize(LongShanActivity._repeated_scoreRewardedIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x001EDBAC File Offset: 0x001EBDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.stages_.Add(other.stages_);
			this.scoreRewardedIds_.Add(other.scoreRewardedIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D12E RID: 53550 RVA: 0x001EDBEB File Offset: 0x001EBDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D12F RID: 53551 RVA: 0x001EDBF4 File Offset: 0x001EBDF4
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
				if (num != 10U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scoreRewardedIds_.AddEntriesFrom(ref input, LongShanActivity._repeated_scoreRewardedIds_codec);
					}
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, LongShanActivity._repeated_stages_codec);
				}
			}
		}

		// Token: 0x0400587D RID: 22653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400587E RID: 22654
		public const int StagesFieldNumber = 1;

		// Token: 0x0400587F RID: 22655
		private static readonly FieldCodec<LongShanStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<LongShanStageInfo>(10U, LongShanStageInfo.Parser);

		// Token: 0x04005880 RID: 22656
		private readonly RepeatedField<LongShanStageInfo> stages_ = new RepeatedField<LongShanStageInfo>();

		// Token: 0x04005881 RID: 22657
		public const int ScoreRewardedIdsFieldNumber = 2;

		// Token: 0x04005882 RID: 22658
		private static readonly FieldCodec<int> _repeated_scoreRewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005883 RID: 22659
		private readonly RepeatedField<int> scoreRewardedIds_ = new RepeatedField<int>();
	}
}
