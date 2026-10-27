using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000923 RID: 2339
	public sealed class LineCrossChallengeData : IMessage<LineCrossChallengeData>, IMessage, IEquatable<LineCrossChallengeData>, IDeepCloneable<LineCrossChallengeData>, IBufferMessage
	{
		// Token: 0x0600CE54 RID: 52820 RVA: 0x001E64C5 File Offset: 0x001E46C5
		[NullableContext(1)]
		public static LineCrossChallengeData Create()
		{
			return new LineCrossChallengeData();
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x001E64CC File Offset: 0x001E46CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineCrossChallengeData> Parser
		{
			get
			{
				return LineCrossChallengeData._parser;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0600CE56 RID: 52822 RVA: 0x001E64D3 File Offset: 0x001E46D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x001E64D6 File Offset: 0x001E46D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeData.Descriptor;
			}
		}

		// Token: 0x0600CE58 RID: 52824 RVA: 0x001E64DD File Offset: 0x001E46DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeData()
		{
		}

		// Token: 0x0600CE59 RID: 52825 RVA: 0x001E64E8 File Offset: 0x001E46E8
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

		// Token: 0x0600CE5A RID: 52826 RVA: 0x001E6554 File Offset: 0x001E4754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeData Clone()
		{
			return new LineCrossChallengeData(this);
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x001E655C File Offset: 0x001E475C
		// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x001E6564 File Offset: 0x001E4764
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

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0600CE5D RID: 52829 RVA: 0x001E656D File Offset: 0x001E476D
		// (set) Token: 0x0600CE5E RID: 52830 RVA: 0x001E6575 File Offset: 0x001E4775
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

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x001E657E File Offset: 0x001E477E
		// (set) Token: 0x0600CE60 RID: 52832 RVA: 0x001E6586 File Offset: 0x001E4786
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

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0600CE61 RID: 52833 RVA: 0x001E658F File Offset: 0x001E478F
		// (set) Token: 0x0600CE62 RID: 52834 RVA: 0x001E6597 File Offset: 0x001E4797
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

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600CE63 RID: 52835 RVA: 0x001E65A0 File Offset: 0x001E47A0
		// (set) Token: 0x0600CE64 RID: 52836 RVA: 0x001E65A8 File Offset: 0x001E47A8
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

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600CE65 RID: 52837 RVA: 0x001E65B1 File Offset: 0x001E47B1
		// (set) Token: 0x0600CE66 RID: 52838 RVA: 0x001E65B9 File Offset: 0x001E47B9
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

		// Token: 0x0600CE67 RID: 52839 RVA: 0x001E65C2 File Offset: 0x001E47C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeData);
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x001E65D0 File Offset: 0x001E47D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeData other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Rewarded == other.Rewarded && this.OpenTime == other.OpenTime && this.RewardId == other.RewardId && this.EntityConfigId == other.EntityConfigId && this.PreChallenged == other.PreChallenged && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x001E665C File Offset: 0x001E485C
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

		// Token: 0x0600CE6A RID: 52842 RVA: 0x001E6718 File Offset: 0x001E4918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE6B RID: 52843 RVA: 0x001E6725 File Offset: 0x001E4925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE6C RID: 52844 RVA: 0x001E6730 File Offset: 0x001E4930
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

		// Token: 0x0600CE6D RID: 52845 RVA: 0x001E67F8 File Offset: 0x001E49F8
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

		// Token: 0x0600CE6E RID: 52846 RVA: 0x001E6898 File Offset: 0x001E4A98
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

		// Token: 0x0600CE6F RID: 52847 RVA: 0x001E6938 File Offset: 0x001E4B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE70 RID: 52848 RVA: 0x001E6944 File Offset: 0x001E4B44
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

		// Token: 0x04005734 RID: 22324
		private static readonly MessageParser<LineCrossChallengeData> _parser = new MessageParser<LineCrossChallengeData>(() => new LineCrossChallengeData());

		// Token: 0x04005735 RID: 22325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005736 RID: 22326
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04005737 RID: 22327
		private int challengeId_;

		// Token: 0x04005738 RID: 22328
		public const int RewardedFieldNumber = 2;

		// Token: 0x04005739 RID: 22329
		private bool rewarded_;

		// Token: 0x0400573A RID: 22330
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x0400573B RID: 22331
		private long openTime_;

		// Token: 0x0400573C RID: 22332
		public const int RewardIdFieldNumber = 4;

		// Token: 0x0400573D RID: 22333
		private int rewardId_;

		// Token: 0x0400573E RID: 22334
		public const int EntityConfigIdFieldNumber = 5;

		// Token: 0x0400573F RID: 22335
		private int entityConfigId_;

		// Token: 0x04005740 RID: 22336
		public const int PreChallengedFieldNumber = 6;

		// Token: 0x04005741 RID: 22337
		private bool preChallenged_;
	}
}
