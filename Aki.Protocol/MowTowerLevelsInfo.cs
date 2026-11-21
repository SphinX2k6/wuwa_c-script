using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABB RID: 2747
	public sealed class MowTowerLevelsInfo : IMessage<MowTowerLevelsInfo>, IMessage, IEquatable<MowTowerLevelsInfo>, IDeepCloneable<MowTowerLevelsInfo>, IBufferMessage
	{
		// Token: 0x0600EF89 RID: 61321 RVA: 0x002305CE File Offset: 0x0022E7CE
		[NullableContext(1)]
		public static MowTowerLevelsInfo Create()
		{
			return new MowTowerLevelsInfo();
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x002305D5 File Offset: 0x0022E7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MowTowerLevelsInfo> Parser
		{
			get
			{
				return MowTowerLevelsInfo._parser;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600EF8B RID: 61323 RVA: 0x002305DC File Offset: 0x0022E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600EF8C RID: 61324 RVA: 0x002305DF File Offset: 0x0022E7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsInfo.Descriptor;
			}
		}

		// Token: 0x0600EF8D RID: 61325 RVA: 0x002305E6 File Offset: 0x0022E7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfo()
		{
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x0023061C File Offset: 0x0022E81C
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

		// Token: 0x0600EF8F RID: 61327 RVA: 0x002306C0 File Offset: 0x0022E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsInfo Clone()
		{
			return new MowTowerLevelsInfo(this);
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600EF90 RID: 61328 RVA: 0x002306C8 File Offset: 0x0022E8C8
		// (set) Token: 0x0600EF91 RID: 61329 RVA: 0x002306D0 File Offset: 0x0022E8D0
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

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x002306D9 File Offset: 0x0022E8D9
		// (set) Token: 0x0600EF93 RID: 61331 RVA: 0x002306E1 File Offset: 0x0022E8E1
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

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600EF94 RID: 61332 RVA: 0x002306EA File Offset: 0x0022E8EA
		// (set) Token: 0x0600EF95 RID: 61333 RVA: 0x002306F2 File Offset: 0x0022E8F2
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

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600EF96 RID: 61334 RVA: 0x002306FB File Offset: 0x0022E8FB
		// (set) Token: 0x0600EF97 RID: 61335 RVA: 0x00230703 File Offset: 0x0022E903
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

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600EF98 RID: 61336 RVA: 0x0023070C File Offset: 0x0022E90C
		// (set) Token: 0x0600EF99 RID: 61337 RVA: 0x00230714 File Offset: 0x0022E914
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

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x0023071D File Offset: 0x0022E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, MowTowerRewardStatus> LevelRewardStatus
		{
			get
			{
				return this.levelRewardStatus_;
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600EF9B RID: 61339 RVA: 0x00230725 File Offset: 0x0022E925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x0023072D File Offset: 0x0022E92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FirstRoleSelection
		{
			get
			{
				return this.firstRoleSelection_;
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600EF9D RID: 61341 RVA: 0x00230735 File Offset: 0x0022E935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoleSelection
		{
			get
			{
				return this.secondRoleSelection_;
			}
		}

		// Token: 0x0600EF9E RID: 61342 RVA: 0x0023073D File Offset: 0x0022E93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsInfo);
		}

		// Token: 0x0600EF9F RID: 61343 RVA: 0x0023074C File Offset: 0x0022E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsInfo other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.UnlockTime == other.UnlockTime && this.IsUnlock == other.IsUnlock && this.FirstScore == other.FirstScore && this.SecondScore == other.SecondScore && this.LevelRewardStatus.Equals(other.LevelRewardStatus) && this.buffSelection_.Equals(other.buffSelection_) && this.firstRoleSelection_.Equals(other.firstRoleSelection_) && this.secondRoleSelection_.Equals(other.secondRoleSelection_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x0023081C File Offset: 0x0022EA1C
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

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x002308F7 File Offset: 0x0022EAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFA2 RID: 61346 RVA: 0x00230904 File Offset: 0x0022EB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFA3 RID: 61347 RVA: 0x00230910 File Offset: 0x0022EB10
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

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x00230A00 File Offset: 0x0022EC00
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

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x00230AE0 File Offset: 0x0022ECE0
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

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x00230BB0 File Offset: 0x0022EDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00230BBC File Offset: 0x0022EDBC
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

		// Token: 0x0400614C RID: 24908
		private static readonly MessageParser<MowTowerLevelsInfo> _parser = new MessageParser<MowTowerLevelsInfo>(() => new MowTowerLevelsInfo());

		// Token: 0x0400614D RID: 24909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400614E RID: 24910
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x0400614F RID: 24911
		private int levelsId_;

		// Token: 0x04006150 RID: 24912
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04006151 RID: 24913
		private long unlockTime_;

		// Token: 0x04006152 RID: 24914
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04006153 RID: 24915
		private bool isUnlock_;

		// Token: 0x04006154 RID: 24916
		public const int FirstScoreFieldNumber = 4;

		// Token: 0x04006155 RID: 24917
		private int firstScore_;

		// Token: 0x04006156 RID: 24918
		public const int SecondScoreFieldNumber = 9;

		// Token: 0x04006157 RID: 24919
		private int secondScore_;

		// Token: 0x04006158 RID: 24920
		public const int LevelRewardStatusFieldNumber = 5;

		// Token: 0x04006159 RID: 24921
		private static readonly MapField<int, MowTowerRewardStatus>.Codec _map_levelRewardStatus_codec = new MapField<int, MowTowerRewardStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<MowTowerRewardStatus>(16U, (MowTowerRewardStatus x) => (int)x, (int x) => (MowTowerRewardStatus)x, MowTowerRewardStatus.CanNoReward), 42U);

		// Token: 0x0400615A RID: 24922
		private readonly MapField<int, MowTowerRewardStatus> levelRewardStatus_ = new MapField<int, MowTowerRewardStatus>();

		// Token: 0x0400615B RID: 24923
		public const int BuffSelectionFieldNumber = 6;

		// Token: 0x0400615C RID: 24924
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400615D RID: 24925
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x0400615E RID: 24926
		public const int FirstRoleSelectionFieldNumber = 7;

		// Token: 0x0400615F RID: 24927
		private static readonly FieldCodec<int> _repeated_firstRoleSelection_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006160 RID: 24928
		private readonly RepeatedField<int> firstRoleSelection_ = new RepeatedField<int>();

		// Token: 0x04006161 RID: 24929
		public const int SecondRoleSelectionFieldNumber = 8;

		// Token: 0x04006162 RID: 24930
		private static readonly FieldCodec<int> _repeated_secondRoleSelection_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006163 RID: 24931
		private readonly RepeatedField<int> secondRoleSelection_ = new RepeatedField<int>();
	}
}
