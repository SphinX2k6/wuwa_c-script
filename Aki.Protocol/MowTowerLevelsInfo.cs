using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACC RID: 2764
	public sealed class MowTowerLevelsInfo : IMessage<MowTowerLevelsInfo>, IMessage, IEquatable<MowTowerLevelsInfo>, IDeepCloneable<MowTowerLevelsInfo>, IBufferMessage
	{
		// Token: 0x0600F0A3 RID: 61603 RVA: 0x002327DF File Offset: 0x002309DF
		[NullableContext(1)]
		public static MowTowerLevelsInfo Create()
		{
			return new MowTowerLevelsInfo();
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600F0A4 RID: 61604 RVA: 0x002327E6 File Offset: 0x002309E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MowTowerLevelsInfo> Parser
		{
			get
			{
				return MowTowerLevelsInfo._parser;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600F0A5 RID: 61605 RVA: 0x002327ED File Offset: 0x002309ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600F0A6 RID: 61606 RVA: 0x002327F0 File Offset: 0x002309F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsInfo.Descriptor;
			}
		}

		// Token: 0x0600F0A7 RID: 61607 RVA: 0x002327F7 File Offset: 0x002309F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfo()
		{
		}

		// Token: 0x0600F0A8 RID: 61608 RVA: 0x0023282C File Offset: 0x00230A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfo(MowTowerLevelsInfo other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.unlockTime_ = other.unlockTime_;
			this.isUnlock_ = other.isUnlock_;
			this.firstScore_ = other.firstScore_;
			this.secondScore_ = other.secondScore_;
			this.levelRewardStatus_ = other.levelRewardStatus_.Clone();
			this.buffSelection_ = other.buffSelection_.Clone();
			this.firstRoleSelection_ = other.firstRoleSelection_.Clone();
			this.secondRoleSelection_ = other.secondRoleSelection_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0A9 RID: 61609 RVA: 0x002328D0 File Offset: 0x00230AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfo Clone()
		{
			return new MowTowerLevelsInfo(this);
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600F0AA RID: 61610 RVA: 0x002328D8 File Offset: 0x00230AD8
		// (set) Token: 0x0600F0AB RID: 61611 RVA: 0x002328E0 File Offset: 0x00230AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600F0AC RID: 61612 RVA: 0x002328E9 File Offset: 0x00230AE9
		// (set) Token: 0x0600F0AD RID: 61613 RVA: 0x002328F1 File Offset: 0x00230AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x002328FA File Offset: 0x00230AFA
		// (set) Token: 0x0600F0AF RID: 61615 RVA: 0x00232902 File Offset: 0x00230B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x0023290B File Offset: 0x00230B0B
		// (set) Token: 0x0600F0B1 RID: 61617 RVA: 0x00232913 File Offset: 0x00230B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstScore
		{
			get
			{
				return this.firstScore_;
			}
			set
			{
				this.firstScore_ = value;
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600F0B2 RID: 61618 RVA: 0x0023291C File Offset: 0x00230B1C
		// (set) Token: 0x0600F0B3 RID: 61619 RVA: 0x00232924 File Offset: 0x00230B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondScore
		{
			get
			{
				return this.secondScore_;
			}
			set
			{
				this.secondScore_ = value;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600F0B4 RID: 61620 RVA: 0x0023292D File Offset: 0x00230B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, MowTowerRewardStatus> LevelRewardStatus
		{
			get
			{
				return this.levelRewardStatus_;
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600F0B5 RID: 61621 RVA: 0x00232935 File Offset: 0x00230B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600F0B6 RID: 61622 RVA: 0x0023293D File Offset: 0x00230B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FirstRoleSelection
		{
			get
			{
				return this.firstRoleSelection_;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600F0B7 RID: 61623 RVA: 0x00232945 File Offset: 0x00230B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoleSelection
		{
			get
			{
				return this.secondRoleSelection_;
			}
		}

		// Token: 0x0600F0B8 RID: 61624 RVA: 0x0023294D File Offset: 0x00230B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsInfo);
		}

		// Token: 0x0600F0B9 RID: 61625 RVA: 0x0023295C File Offset: 0x00230B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsInfo other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.UnlockTime == other.UnlockTime && this.IsUnlock == other.IsUnlock && this.FirstScore == other.FirstScore && this.SecondScore == other.SecondScore && this.LevelRewardStatus.Equals(other.LevelRewardStatus) && this.buffSelection_.Equals(other.buffSelection_) && this.firstRoleSelection_.Equals(other.firstRoleSelection_) && this.secondRoleSelection_.Equals(other.secondRoleSelection_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0BA RID: 61626 RVA: 0x00232A2C File Offset: 0x00230C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.FirstScore != 0)
			{
				num ^= this.FirstScore.GetHashCode();
			}
			if (this.SecondScore != 0)
			{
				num ^= this.SecondScore.GetHashCode();
			}
			num ^= this.LevelRewardStatus.GetHashCode();
			num ^= this.buffSelection_.GetHashCode();
			num ^= this.firstRoleSelection_.GetHashCode();
			num ^= this.secondRoleSelection_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0BB RID: 61627 RVA: 0x00232B07 File Offset: 0x00230D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0BC RID: 61628 RVA: 0x00232B14 File Offset: 0x00230D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00232B20 File Offset: 0x00230D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlock);
			}
			if (this.FirstScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FirstScore);
			}
			this.levelRewardStatus_.WriteTo(ref output, MowTowerLevelsInfo._map_levelRewardStatus_codec);
			this.buffSelection_.WriteTo(ref output, MowTowerLevelsInfo._repeated_buffSelection_codec);
			this.firstRoleSelection_.WriteTo(ref output, MowTowerLevelsInfo._repeated_firstRoleSelection_codec);
			this.secondRoleSelection_.WriteTo(ref output, MowTowerLevelsInfo._repeated_secondRoleSelection_codec);
			if (this.SecondScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SecondScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F0BE RID: 61630 RVA: 0x00232C10 File Offset: 0x00230E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.FirstScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstScore);
			}
			if (this.SecondScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondScore);
			}
			num += this.levelRewardStatus_.CalculateSize(MowTowerLevelsInfo._map_levelRewardStatus_codec);
			num += this.buffSelection_.CalculateSize(MowTowerLevelsInfo._repeated_buffSelection_codec);
			num += this.firstRoleSelection_.CalculateSize(MowTowerLevelsInfo._repeated_firstRoleSelection_codec);
			num += this.secondRoleSelection_.CalculateSize(MowTowerLevelsInfo._repeated_secondRoleSelection_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0BF RID: 61631 RVA: 0x00232CF0 File Offset: 0x00230EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.FirstScore != 0)
			{
				this.FirstScore = other.FirstScore;
			}
			if (other.SecondScore != 0)
			{
				this.SecondScore = other.SecondScore;
			}
			this.levelRewardStatus_.MergeFrom(other.levelRewardStatus_);
			this.buffSelection_.Add(other.buffSelection_);
			this.firstRoleSelection_.Add(other.firstRoleSelection_);
			this.secondRoleSelection_.Add(other.secondRoleSelection_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0C0 RID: 61632 RVA: 0x00232DC0 File Offset: 0x00230FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0C1 RID: 61633 RVA: 0x00232DCC File Offset: 0x00230FCC
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.LevelsId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.UnlockTime = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.IsUnlock = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.FirstScore = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.levelRewardStatus_.AddEntriesFrom(ref input, MowTowerLevelsInfo._map_levelRewardStatus_codec);
							continue;
						}
						if (num == 48U)
						{
							goto IL_E2;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						goto IL_E2;
					}
					if (num == 56U || num == 58U)
					{
						this.firstRoleSelection_.AddEntriesFrom(ref input, MowTowerLevelsInfo._repeated_firstRoleSelection_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.secondRoleSelection_.AddEntriesFrom(ref input, MowTowerLevelsInfo._repeated_secondRoleSelection_codec);
						continue;
					}
					if (num == 72U)
					{
						this.SecondScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_E2:
				this.buffSelection_.AddEntriesFrom(ref input, MowTowerLevelsInfo._repeated_buffSelection_codec);
			}
		}

		// Token: 0x04006143 RID: 24899
		private static readonly MessageParser<MowTowerLevelsInfo> _parser = new MessageParser<MowTowerLevelsInfo>(() => new MowTowerLevelsInfo());

		// Token: 0x04006144 RID: 24900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006145 RID: 24901
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04006146 RID: 24902
		private int levelsId_;

		// Token: 0x04006147 RID: 24903
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04006148 RID: 24904
		private long unlockTime_;

		// Token: 0x04006149 RID: 24905
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x0400614A RID: 24906
		private bool isUnlock_;

		// Token: 0x0400614B RID: 24907
		public const int FirstScoreFieldNumber = 4;

		// Token: 0x0400614C RID: 24908
		private int firstScore_;

		// Token: 0x0400614D RID: 24909
		public const int SecondScoreFieldNumber = 9;

		// Token: 0x0400614E RID: 24910
		private int secondScore_;

		// Token: 0x0400614F RID: 24911
		public const int LevelRewardStatusFieldNumber = 5;

		// Token: 0x04006150 RID: 24912
		private static readonly MapField<int, MowTowerRewardStatus>.Codec _map_levelRewardStatus_codec = new MapField<int, MowTowerRewardStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<MowTowerRewardStatus>(16U, (MowTowerRewardStatus x) => (int)x, (int x) => (MowTowerRewardStatus)x, MowTowerRewardStatus.CanNoReward), 42U);

		// Token: 0x04006151 RID: 24913
		private readonly MapField<int, MowTowerRewardStatus> levelRewardStatus_ = new MapField<int, MowTowerRewardStatus>();

		// Token: 0x04006152 RID: 24914
		public const int BuffSelectionFieldNumber = 6;

		// Token: 0x04006153 RID: 24915
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006154 RID: 24916
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x04006155 RID: 24917
		public const int FirstRoleSelectionFieldNumber = 7;

		// Token: 0x04006156 RID: 24918
		private static readonly FieldCodec<int> _repeated_firstRoleSelection_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006157 RID: 24919
		private readonly RepeatedField<int> firstRoleSelection_ = new RepeatedField<int>();

		// Token: 0x04006158 RID: 24920
		public const int SecondRoleSelectionFieldNumber = 8;

		// Token: 0x04006159 RID: 24921
		private static readonly FieldCodec<int> _repeated_secondRoleSelection_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400615A RID: 24922
		private readonly RepeatedField<int> secondRoleSelection_ = new RepeatedField<int>();
	}
}
