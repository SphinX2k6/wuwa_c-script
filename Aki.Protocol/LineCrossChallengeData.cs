using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000912 RID: 2322
	public sealed class LineCrossChallengeData : IMessage<LineCrossChallengeData>, IMessage, IEquatable<LineCrossChallengeData>, IDeepCloneable<LineCrossChallengeData>, IBufferMessage
	{
		// Token: 0x0600CD38 RID: 52536 RVA: 0x001E41F5 File Offset: 0x001E23F5
		[NullableContext(1)]
		public static LineCrossChallengeData Create()
		{
			return new LineCrossChallengeData();
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600CD39 RID: 52537 RVA: 0x001E41FC File Offset: 0x001E23FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineCrossChallengeData> Parser
		{
			get
			{
				return LineCrossChallengeData._parser;
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x001E4203 File Offset: 0x001E2403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600CD3B RID: 52539 RVA: 0x001E4206 File Offset: 0x001E2406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeData.Descriptor;
			}
		}

		// Token: 0x0600CD3C RID: 52540 RVA: 0x001E420D File Offset: 0x001E240D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeData()
		{
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x001E4218 File Offset: 0x001E2418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeData(LineCrossChallengeData other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.rewarded_ = other.rewarded_;
			this.openTime_ = other.openTime_;
			this.rewardId_ = other.rewardId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.preChallenged_ = other.preChallenged_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x001E4284 File Offset: 0x001E2484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeData Clone()
		{
			return new LineCrossChallengeData(this);
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600CD3F RID: 52543 RVA: 0x001E428C File Offset: 0x001E248C
		// (set) Token: 0x0600CD40 RID: 52544 RVA: 0x001E4294 File Offset: 0x001E2494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600CD41 RID: 52545 RVA: 0x001E429D File Offset: 0x001E249D
		// (set) Token: 0x0600CD42 RID: 52546 RVA: 0x001E42A5 File Offset: 0x001E24A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600CD43 RID: 52547 RVA: 0x001E42AE File Offset: 0x001E24AE
		// (set) Token: 0x0600CD44 RID: 52548 RVA: 0x001E42B6 File Offset: 0x001E24B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600CD45 RID: 52549 RVA: 0x001E42BF File Offset: 0x001E24BF
		// (set) Token: 0x0600CD46 RID: 52550 RVA: 0x001E42C7 File Offset: 0x001E24C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600CD47 RID: 52551 RVA: 0x001E42D0 File Offset: 0x001E24D0
		// (set) Token: 0x0600CD48 RID: 52552 RVA: 0x001E42D8 File Offset: 0x001E24D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600CD49 RID: 52553 RVA: 0x001E42E1 File Offset: 0x001E24E1
		// (set) Token: 0x0600CD4A RID: 52554 RVA: 0x001E42E9 File Offset: 0x001E24E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PreChallenged
		{
			get
			{
				return this.preChallenged_;
			}
			set
			{
				this.preChallenged_ = value;
			}
		}

		// Token: 0x0600CD4B RID: 52555 RVA: 0x001E42F2 File Offset: 0x001E24F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeData);
		}

		// Token: 0x0600CD4C RID: 52556 RVA: 0x001E4300 File Offset: 0x001E2500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeData other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Rewarded == other.Rewarded && this.OpenTime == other.OpenTime && this.RewardId == other.RewardId && this.EntityConfigId == other.EntityConfigId && this.PreChallenged == other.PreChallenged && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x001E438C File Offset: 0x001E258C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.PreChallenged)
			{
				num ^= this.PreChallenged.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x001E4448 File Offset: 0x001E2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x001E4455 File Offset: 0x001E2655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD50 RID: 52560 RVA: 0x001E4460 File Offset: 0x001E2660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Rewarded);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.OpenTime);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RewardId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.PreChallenged)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.PreChallenged);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD51 RID: 52561 RVA: 0x001E4528 File Offset: 0x001E2728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.PreChallenged)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD52 RID: 52562 RVA: 0x001E45C8 File Offset: 0x001E27C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossChallengeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.PreChallenged)
			{
				this.PreChallenged = other.PreChallenged;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD53 RID: 52563 RVA: 0x001E4668 File Offset: 0x001E2868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD54 RID: 52564 RVA: 0x001E4674 File Offset: 0x001E2874
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.RewardId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PreChallenged = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400573B RID: 22331
		private static readonly MessageParser<LineCrossChallengeData> _parser = new MessageParser<LineCrossChallengeData>(() => new LineCrossChallengeData());

		// Token: 0x0400573C RID: 22332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400573D RID: 22333
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400573E RID: 22334
		private int challengeId_;

		// Token: 0x0400573F RID: 22335
		public const int RewardedFieldNumber = 2;

		// Token: 0x04005740 RID: 22336
		private bool rewarded_;

		// Token: 0x04005741 RID: 22337
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x04005742 RID: 22338
		private long openTime_;

		// Token: 0x04005743 RID: 22339
		public const int RewardIdFieldNumber = 4;

		// Token: 0x04005744 RID: 22340
		private int rewardId_;

		// Token: 0x04005745 RID: 22341
		public const int EntityConfigIdFieldNumber = 5;

		// Token: 0x04005746 RID: 22342
		private int entityConfigId_;

		// Token: 0x04005747 RID: 22343
		public const int PreChallengedFieldNumber = 6;

		// Token: 0x04005748 RID: 22344
		private bool preChallenged_;
	}
}
