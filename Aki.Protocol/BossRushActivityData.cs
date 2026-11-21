using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D1 RID: 465
	public sealed class BossRushActivityData : IMessage<BossRushActivityData>, IMessage, IEquatable<BossRushActivityData>, IDeepCloneable<BossRushActivityData>, IBufferMessage
	{
		// Token: 0x06003528 RID: 13608 RVA: 0x00086071 File Offset: 0x00084271
		[NullableContext(1)]
		public static BossRushActivityData Create()
		{
			return new BossRushActivityData();
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x00086078 File Offset: 0x00084278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x0008607B File Offset: 0x0008427B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushActivityData.Descriptor;
			}
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00086082 File Offset: 0x00084282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData()
		{
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x000860B8 File Offset: 0x000842B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData(BossRushActivityData other) : this()
		{
			this.bossRushLevelInfo_ = other.bossRushLevelInfo_.Clone();
			this.bossRushScoreScoreRewardInfo_ = other.bossRushScoreScoreRewardInfo_.Clone();
			this.unlockedBuffIndices_ = other.unlockedBuffIndices_.Clone();
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00086120 File Offset: 0x00084320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData Clone()
		{
			return new BossRushActivityData(this);
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x00086128 File Offset: 0x00084328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushLevelData> BossRushLevelInfo
		{
			get
			{
				return this.bossRushLevelInfo_;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x00086130 File Offset: 0x00084330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushScoreRewardData> BossRushScoreScoreRewardInfo
		{
			get
			{
				return this.bossRushScoreScoreRewardInfo_;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x00086138 File Offset: 0x00084338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedBuffIndices
		{
			get
			{
				return this.unlockedBuffIndices_;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x00086140 File Offset: 0x00084340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00086148 File Offset: 0x00084348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushActivityData);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00086158 File Offset: 0x00084358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushActivityData other)
		{
			return other != null && (other == this || (this.bossRushLevelInfo_.Equals(other.bossRushLevelInfo_) && this.bossRushScoreScoreRewardInfo_.Equals(other.bossRushScoreScoreRewardInfo_) && this.unlockedBuffIndices_.Equals(other.unlockedBuffIndices_) && this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000861D8 File Offset: 0x000843D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bossRushLevelInfo_.GetHashCode();
			num ^= this.bossRushScoreScoreRewardInfo_.GetHashCode();
			num ^= this.unlockedBuffIndices_.GetHashCode();
			num ^= this.activityTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00086236 File Offset: 0x00084436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00086243 File Offset: 0x00084443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0008624C File Offset: 0x0008444C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossRushLevelInfo_.WriteTo(ref output, BossRushActivityData._repeated_bossRushLevelInfo_codec);
			this.bossRushScoreScoreRewardInfo_.WriteTo(ref output, BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
			this.unlockedBuffIndices_.WriteTo(ref output, BossRushActivityData._repeated_unlockedBuffIndices_codec);
			this.activityTasks_.WriteTo(ref output, BossRushActivityData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000862B4 File Offset: 0x000844B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossRushLevelInfo_.CalculateSize(BossRushActivityData._repeated_bossRushLevelInfo_codec);
			num += this.bossRushScoreScoreRewardInfo_.CalculateSize(BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
			num += this.unlockedBuffIndices_.CalculateSize(BossRushActivityData._repeated_unlockedBuffIndices_codec);
			num += this.activityTasks_.CalculateSize(BossRushActivityData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00086328 File Offset: 0x00084528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.bossRushLevelInfo_.Add(other.bossRushLevelInfo_);
			this.bossRushScoreScoreRewardInfo_.Add(other.bossRushScoreScoreRewardInfo_);
			this.unlockedBuffIndices_.Add(other.unlockedBuffIndices_);
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00086394 File Offset: 0x00084594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x000863A0 File Offset: 0x000845A0
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.bossRushLevelInfo_.AddEntriesFrom(ref input, BossRushActivityData._repeated_bossRushLevelInfo_codec);
						continue;
					}
					if (num == 18U)
					{
						this.bossRushScoreScoreRewardInfo_.AddEntriesFrom(ref input, BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.unlockedBuffIndices_.AddEntriesFrom(ref input, BossRushActivityData._repeated_unlockedBuffIndices_codec);
						continue;
					}
					if (num == 34U)
					{
						this.activityTasks_.AddEntriesFrom(ref input, BossRushActivityData._repeated_activityTasks_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A8A RID: 10890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A8B RID: 10891
		public const int BossRushLevelInfoFieldNumber = 1;

		// Token: 0x04002A8C RID: 10892
		private static readonly FieldCodec<BossRushLevelData> _repeated_bossRushLevelInfo_codec = FieldCodec.ForMessage<BossRushLevelData>(10U, BossRushLevelData.Parser);

		// Token: 0x04002A8D RID: 10893
		private readonly RepeatedField<BossRushLevelData> bossRushLevelInfo_ = new RepeatedField<BossRushLevelData>();

		// Token: 0x04002A8E RID: 10894
		public const int BossRushScoreScoreRewardInfoFieldNumber = 2;

		// Token: 0x04002A8F RID: 10895
		private static readonly FieldCodec<BossRushScoreRewardData> _repeated_bossRushScoreScoreRewardInfo_codec = FieldCodec.ForMessage<BossRushScoreRewardData>(18U, BossRushScoreRewardData.Parser);

		// Token: 0x04002A90 RID: 10896
		private readonly RepeatedField<BossRushScoreRewardData> bossRushScoreScoreRewardInfo_ = new RepeatedField<BossRushScoreRewardData>();

		// Token: 0x04002A91 RID: 10897
		public const int UnlockedBuffIndicesFieldNumber = 3;

		// Token: 0x04002A92 RID: 10898
		private static readonly FieldCodec<int> _repeated_unlockedBuffIndices_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002A93 RID: 10899
		private readonly RepeatedField<int> unlockedBuffIndices_ = new RepeatedField<int>();

		// Token: 0x04002A94 RID: 10900
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x04002A95 RID: 10901
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04002A96 RID: 10902
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
