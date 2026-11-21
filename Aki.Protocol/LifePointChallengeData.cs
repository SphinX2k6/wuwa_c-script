using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000905 RID: 2309
	public sealed class LifePointChallengeData : IMessage<LifePointChallengeData>, IMessage, IEquatable<LifePointChallengeData>, IDeepCloneable<LifePointChallengeData>, IBufferMessage
	{
		// Token: 0x0600CC28 RID: 52264 RVA: 0x001E1BF1 File Offset: 0x001DFDF1
		[NullableContext(1)]
		public static LifePointChallengeData Create()
		{
			return new LifePointChallengeData();
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600CC29 RID: 52265 RVA: 0x001E1BF8 File Offset: 0x001DFDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifePointChallengeData> Parser
		{
			get
			{
				return LifePointChallengeData._parser;
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600CC2A RID: 52266 RVA: 0x001E1BFF File Offset: 0x001DFDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600CC2B RID: 52267 RVA: 0x001E1C02 File Offset: 0x001DFE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeData.Descriptor;
			}
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x001E1C09 File Offset: 0x001DFE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeData()
		{
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x001E1C14 File Offset: 0x001DFE14
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

		// Token: 0x0600CC2E RID: 52270 RVA: 0x001E1C80 File Offset: 0x001DFE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeData Clone()
		{
			return new LifePointChallengeData(this);
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600CC2F RID: 52271 RVA: 0x001E1C88 File Offset: 0x001DFE88
		// (set) Token: 0x0600CC30 RID: 52272 RVA: 0x001E1C90 File Offset: 0x001DFE90
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

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600CC31 RID: 52273 RVA: 0x001E1C99 File Offset: 0x001DFE99
		// (set) Token: 0x0600CC32 RID: 52274 RVA: 0x001E1CA1 File Offset: 0x001DFEA1
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

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600CC33 RID: 52275 RVA: 0x001E1CAA File Offset: 0x001DFEAA
		// (set) Token: 0x0600CC34 RID: 52276 RVA: 0x001E1CB2 File Offset: 0x001DFEB2
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

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600CC35 RID: 52277 RVA: 0x001E1CBB File Offset: 0x001DFEBB
		// (set) Token: 0x0600CC36 RID: 52278 RVA: 0x001E1CC3 File Offset: 0x001DFEC3
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

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600CC37 RID: 52279 RVA: 0x001E1CCC File Offset: 0x001DFECC
		// (set) Token: 0x0600CC38 RID: 52280 RVA: 0x001E1CD4 File Offset: 0x001DFED4
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

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600CC39 RID: 52281 RVA: 0x001E1CDD File Offset: 0x001DFEDD
		// (set) Token: 0x0600CC3A RID: 52282 RVA: 0x001E1CE5 File Offset: 0x001DFEE5
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

		// Token: 0x0600CC3B RID: 52283 RVA: 0x001E1CEE File Offset: 0x001DFEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeData);
		}

		// Token: 0x0600CC3C RID: 52284 RVA: 0x001E1CFC File Offset: 0x001DFEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeData other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Rewarded == other.Rewarded && this.OpenTime == other.OpenTime && this.RewardId == other.RewardId && this.EntityConfigId == other.EntityConfigId && this.PreChallenged == other.PreChallenged && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC3D RID: 52285 RVA: 0x001E1D88 File Offset: 0x001DFF88
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

		// Token: 0x0600CC3E RID: 52286 RVA: 0x001E1E44 File Offset: 0x001E0044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC3F RID: 52287 RVA: 0x001E1E51 File Offset: 0x001E0051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC40 RID: 52288 RVA: 0x001E1E5C File Offset: 0x001E005C
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

		// Token: 0x0600CC41 RID: 52289 RVA: 0x001E1F24 File Offset: 0x001E0124
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

		// Token: 0x0600CC42 RID: 52290 RVA: 0x001E1FC4 File Offset: 0x001E01C4
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

		// Token: 0x0600CC43 RID: 52291 RVA: 0x001E2064 File Offset: 0x001E0264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x001E2070 File Offset: 0x001E0270
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

		// Token: 0x040056EE RID: 22254
		private static readonly MessageParser<LifePointChallengeData> _parser = new MessageParser<LifePointChallengeData>(() => new LifePointChallengeData());

		// Token: 0x040056EF RID: 22255
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056F0 RID: 22256
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040056F1 RID: 22257
		private int challengeId_;

		// Token: 0x040056F2 RID: 22258
		public const int RewardedFieldNumber = 2;

		// Token: 0x040056F3 RID: 22259
		private bool rewarded_;

		// Token: 0x040056F4 RID: 22260
		public const int OpenTimeFieldNumber = 3;

		// Token: 0x040056F5 RID: 22261
		private long openTime_;

		// Token: 0x040056F6 RID: 22262
		public const int RewardIdFieldNumber = 4;

		// Token: 0x040056F7 RID: 22263
		private int rewardId_;

		// Token: 0x040056F8 RID: 22264
		public const int EntityConfigIdFieldNumber = 5;

		// Token: 0x040056F9 RID: 22265
		private int entityConfigId_;

		// Token: 0x040056FA RID: 22266
		public const int PreChallengedFieldNumber = 6;

		// Token: 0x040056FB RID: 22267
		private bool preChallenged_;
	}
}
