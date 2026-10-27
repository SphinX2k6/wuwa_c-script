using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000916 RID: 2326
	public sealed class LifePointChallengeData : IMessage<LifePointChallengeData>, IMessage, IEquatable<LifePointChallengeData>, IDeepCloneable<LifePointChallengeData>, IBufferMessage
	{
		// Token: 0x0600CD44 RID: 52548 RVA: 0x001E3EC1 File Offset: 0x001E20C1
		[NullableContext(1)]
		public static LifePointChallengeData Create()
		{
			return new LifePointChallengeData();
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600CD45 RID: 52549 RVA: 0x001E3EC8 File Offset: 0x001E20C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifePointChallengeData> Parser
		{
			get
			{
				return LifePointChallengeData._parser;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x001E3ECF File Offset: 0x001E20CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600CD47 RID: 52551 RVA: 0x001E3ED2 File Offset: 0x001E20D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeData.Descriptor;
			}
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x001E3ED9 File Offset: 0x001E20D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeData()
		{
		}

		// Token: 0x0600CD49 RID: 52553 RVA: 0x001E3EE4 File Offset: 0x001E20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeData(LifePointChallengeData other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.rewarded_ = other.rewarded_;
			this.openTime_ = other.openTime_;
			this.rewardId_ = other.rewardId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.preChallenged_ = other.preChallenged_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD4A RID: 52554 RVA: 0x001E3F50 File Offset: 0x001E2150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeData Clone()
		{
			return new LifePointChallengeData(this);
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600CD4B RID: 52555 RVA: 0x001E3F58 File Offset: 0x001E2158
		// (set) Token: 0x0600CD4C RID: 52556 RVA: 0x001E3F60 File Offset: 0x001E2160
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

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600CD4D RID: 52557 RVA: 0x001E3F69 File Offset: 0x001E2169
		// (set) Token: 0x0600CD4E RID: 52558 RVA: 0x001E3F71 File Offset: 0x001E2171
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

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600CD4F RID: 52559 RVA: 0x001E3F7A File Offset: 0x001E217A
		// (set) Token: 0x0600CD50 RID: 52560 RVA: 0x001E3F82 File Offset: 0x001E2182
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

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600CD51 RID: 52561 RVA: 0x001E3F8B File Offset: 0x001E218B
		// (set) Token: 0x0600CD52 RID: 52562 RVA: 0x001E3F93 File Offset: 0x001E2193
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

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600CD53 RID: 52563 RVA: 0x001E3F9C File Offset: 0x001E219C
		// (set) Token: 0x0600CD54 RID: 52564 RVA: 0x001E3FA4 File Offset: 0x001E21A4
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

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600CD55 RID: 52565 RVA: 0x001E3FAD File Offset: 0x001E21AD
		// (set) Token: 0x0600CD56 RID: 52566 RVA: 0x001E3FB5 File Offset: 0x001E21B5
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

		// Token: 0x0600CD57 RID: 52567 RVA: 0x001E3FBE File Offset: 0x001E21BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeData);
		}

		// Token: 0x0600CD58 RID: 52568 RVA: 0x001E3FCC File Offset: 0x001E21CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeData other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Rewarded == other.Rewarded && this.OpenTime == other.OpenTime && this.RewardId == other.RewardId && this.EntityConfigId == other.EntityConfigId && this.PreChallenged == other.PreChallenged && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x001E4058 File Offset: 0x001E2258
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

		// Token: 0x0600CD5A RID: 52570 RVA: 0x001E4114 File Offset: 0x001E2314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x001E4121 File Offset: 0x001E2321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x001E412C File Offset: 0x001E232C
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

		// Token: 0x0600CD5D RID: 52573 RVA: 0x001E41F4 File Offset: 0x001E23F4
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

		// Token: 0x0600CD5E RID: 52574 RVA: 0x001E4294 File Offset: 0x001E2494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeData other)
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

		// Token: 0x0600CD5F RID: 52575 RVA: 0x001E4334 File Offset: 0x001E2534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x001E4340 File Offset: 0x001E2540
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

		// Token: 0x040056E7 RID: 22247
		private static readonly MessageParser<LifePointChallengeData> _parser = new MessageParser<LifePointChallengeData>(() => new LifePointChallengeData());

		// Token: 0x040056E8 RID: 22248
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E9 RID: 22249
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040056EA RID: 22250
		private int challengeId_;

		// Token: 0x040056EB RID: 22251
		public const int RewardedFieldNumber = 2;

		// Token: 0x040056EC RID: 22252
		private bool rewarded_;

		// Token: 0x040056ED RID: 22253
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x040056EE RID: 22254
		private long openTime_;

		// Token: 0x040056EF RID: 22255
		public const int RewardIdFieldNumber = 4;

		// Token: 0x040056F0 RID: 22256
		private int rewardId_;

		// Token: 0x040056F1 RID: 22257
		public const int EntityConfigIdFieldNumber = 5;

		// Token: 0x040056F2 RID: 22258
		private int entityConfigId_;

		// Token: 0x040056F3 RID: 22259
		public const int PreChallengedFieldNumber = 6;

		// Token: 0x040056F4 RID: 22260
		private bool preChallenged_;
	}
}
