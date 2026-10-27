using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000951 RID: 2385
	public sealed class LongShanActivity : IMessage<LongShanActivity>, IMessage, IEquatable<LongShanActivity>, IDeepCloneable<LongShanActivity>, IBufferMessage
	{
		// Token: 0x0600D238 RID: 53816 RVA: 0x001EFBD2 File Offset: 0x001EDDD2
		[NullableContext(1)]
		public static LongShanActivity Create()
		{
			return new LongShanActivity();
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600D239 RID: 53817 RVA: 0x001EFBD9 File Offset: 0x001EDDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600D23A RID: 53818 RVA: 0x001EFBDC File Offset: 0x001EDDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanActivity.Descriptor;
			}
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x001EFBE3 File Offset: 0x001EDDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity()
		{
		}

		// Token: 0x0600D23C RID: 53820 RVA: 0x001EFC01 File Offset: 0x001EDE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity(LongShanActivity other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this.scoreRewardedIds_ = other.scoreRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x001EFC3C File Offset: 0x001EDE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanActivity Clone()
		{
			return new LongShanActivity(this);
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600D23E RID: 53822 RVA: 0x001EFC44 File Offset: 0x001EDE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600D23F RID: 53823 RVA: 0x001EFC4C File Offset: 0x001EDE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardedIds
		{
			get
			{
				return this.scoreRewardedIds_;
			}
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x001EFC54 File Offset: 0x001EDE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanActivity);
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x001EFC64 File Offset: 0x001EDE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanActivity other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && this.scoreRewardedIds_.Equals(other.scoreRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D242 RID: 53826 RVA: 0x001EFCB8 File Offset: 0x001EDEB8
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

		// Token: 0x0600D243 RID: 53827 RVA: 0x001EFCFA File Offset: 0x001EDEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x001EFD07 File Offset: 0x001EDF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x001EFD10 File Offset: 0x001EDF10
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

		// Token: 0x0600D246 RID: 53830 RVA: 0x001EFD48 File Offset: 0x001EDF48
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

		// Token: 0x0600D247 RID: 53831 RVA: 0x001EFD94 File Offset: 0x001EDF94
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

		// Token: 0x0600D248 RID: 53832 RVA: 0x001EFDD3 File Offset: 0x001EDFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x001EFDDC File Offset: 0x001EDFDC
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

		// Token: 0x04005874 RID: 22644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005875 RID: 22645
		public const int StagesFieldNumber = 1;

		// Token: 0x04005876 RID: 22646
		private static readonly FieldCodec<LongShanStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<LongShanStageInfo>(10U, LongShanStageInfo.Parser);

		// Token: 0x04005877 RID: 22647
		private readonly RepeatedField<LongShanStageInfo> stages_ = new RepeatedField<LongShanStageInfo>();

		// Token: 0x04005878 RID: 22648
		public const int ScoreRewardedIdsFieldNumber = 2;

		// Token: 0x04005879 RID: 22649
		private static readonly FieldCodec<int> _repeated_scoreRewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400587A RID: 22650
		private readonly RepeatedField<int> scoreRewardedIds_ = new RepeatedField<int>();
	}
}
