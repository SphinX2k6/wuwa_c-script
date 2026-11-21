using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B2 RID: 5298
	public sealed class TrapDefenseResultInfo : IMessage<TrapDefenseResultInfo>, IMessage, IEquatable<TrapDefenseResultInfo>, IDeepCloneable<TrapDefenseResultInfo>, IBufferMessage
	{
		// Token: 0x0601C1C1 RID: 115137 RVA: 0x004146DF File Offset: 0x004128DF
		[NullableContext(1)]
		public static TrapDefenseResultInfo Create()
		{
			return new TrapDefenseResultInfo();
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x0601C1C2 RID: 115138 RVA: 0x004146E6 File Offset: 0x004128E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x0601C1C3 RID: 115139 RVA: 0x004146E9 File Offset: 0x004128E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseResultInfo.Descriptor;
			}
		}

		// Token: 0x0601C1C4 RID: 115140 RVA: 0x004146F0 File Offset: 0x004128F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo()
		{
		}

		// Token: 0x0601C1C5 RID: 115141 RVA: 0x00414750 File Offset: 0x00412950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo(TrapDefenseResultInfo other) : this()
		{
			this.target_ = other.target_.Clone();
			this.success_ = other.success_;
			this.unlockBuilding_ = other.unlockBuilding_.Clone();
			this.unlockAuxiliary_ = other.unlockAuxiliary_.Clone();
			this.rewardItems_ = other.rewardItems_.Clone();
			this.unlockBds_ = other.unlockBds_.Clone();
			this.rewardLevelUpPoint_ = other.rewardLevelUpPoint_;
			this.quit_ = other.quit_;
			this.preTarget_ = other.preTarget_.Clone();
			this.finalTarget_ = other.finalTarget_.Clone();
			this.wave_ = other.wave_;
			this.health_ = other.health_;
			this.challengeId_ = other.challengeId_;
			this.maxWave_ = other.maxWave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1C6 RID: 115142 RVA: 0x0041483F File Offset: 0x00412A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo Clone()
		{
			return new TrapDefenseResultInfo(this);
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x0601C1C7 RID: 115143 RVA: 0x00414847 File Offset: 0x00412A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x0601C1C8 RID: 115144 RVA: 0x0041484F File Offset: 0x00412A4F
		// (set) Token: 0x0601C1C9 RID: 115145 RVA: 0x00414857 File Offset: 0x00412A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x0601C1CA RID: 115146 RVA: 0x00414860 File Offset: 0x00412A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuilding
		{
			get
			{
				return this.unlockBuilding_;
			}
		}

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x0601C1CB RID: 115147 RVA: 0x00414868 File Offset: 0x00412A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockAuxiliary
		{
			get
			{
				return this.unlockAuxiliary_;
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x0601C1CC RID: 115148 RVA: 0x00414870 File Offset: 0x00412A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x0601C1CD RID: 115149 RVA: 0x00414878 File Offset: 0x00412A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x0601C1CE RID: 115150 RVA: 0x00414880 File Offset: 0x00412A80
		// (set) Token: 0x0601C1CF RID: 115151 RVA: 0x00414888 File Offset: 0x00412A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardLevelUpPoint
		{
			get
			{
				return this.rewardLevelUpPoint_;
			}
			set
			{
				this.rewardLevelUpPoint_ = value;
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x0601C1D0 RID: 115152 RVA: 0x00414891 File Offset: 0x00412A91
		// (set) Token: 0x0601C1D1 RID: 115153 RVA: 0x00414899 File Offset: 0x00412A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Quit
		{
			get
			{
				return this.quit_;
			}
			set
			{
				this.quit_ = value;
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x0601C1D2 RID: 115154 RVA: 0x004148A2 File Offset: 0x00412AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreTarget
		{
			get
			{
				return this.preTarget_;
			}
		}

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x0601C1D3 RID: 115155 RVA: 0x004148AA File Offset: 0x00412AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinalTarget
		{
			get
			{
				return this.finalTarget_;
			}
		}

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x0601C1D4 RID: 115156 RVA: 0x004148B2 File Offset: 0x00412AB2
		// (set) Token: 0x0601C1D5 RID: 115157 RVA: 0x004148BA File Offset: 0x00412ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x0601C1D6 RID: 115158 RVA: 0x004148C3 File Offset: 0x00412AC3
		// (set) Token: 0x0601C1D7 RID: 115159 RVA: 0x004148CB File Offset: 0x00412ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Health
		{
			get
			{
				return this.health_;
			}
			set
			{
				this.health_ = value;
			}
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x0601C1D8 RID: 115160 RVA: 0x004148D4 File Offset: 0x00412AD4
		// (set) Token: 0x0601C1D9 RID: 115161 RVA: 0x004148DC File Offset: 0x00412ADC
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

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x0601C1DA RID: 115162 RVA: 0x004148E5 File Offset: 0x00412AE5
		// (set) Token: 0x0601C1DB RID: 115163 RVA: 0x004148ED File Offset: 0x00412AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxWave
		{
			get
			{
				return this.maxWave_;
			}
			set
			{
				this.maxWave_ = value;
			}
		}

		// Token: 0x0601C1DC RID: 115164 RVA: 0x004148F6 File Offset: 0x00412AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseResultInfo);
		}

		// Token: 0x0601C1DD RID: 115165 RVA: 0x00414904 File Offset: 0x00412B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseResultInfo other)
		{
			return other != null && (other == this || (this.target_.Equals(other.target_) && this.Success == other.Success && this.unlockBuilding_.Equals(other.unlockBuilding_) && this.unlockAuxiliary_.Equals(other.unlockAuxiliary_) && this.rewardItems_.Equals(other.rewardItems_) && this.unlockBds_.Equals(other.unlockBds_) && this.RewardLevelUpPoint == other.RewardLevelUpPoint && this.Quit == other.Quit && this.preTarget_.Equals(other.preTarget_) && this.finalTarget_.Equals(other.finalTarget_) && this.Wave == other.Wave && this.Health == other.Health && this.ChallengeId == other.ChallengeId && this.MaxWave == other.MaxWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x00414A30 File Offset: 0x00412C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.target_.GetHashCode();
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			num ^= this.unlockBuilding_.GetHashCode();
			num ^= this.unlockAuxiliary_.GetHashCode();
			num ^= this.rewardItems_.GetHashCode();
			num ^= this.unlockBds_.GetHashCode();
			if (this.RewardLevelUpPoint != 0)
			{
				num ^= this.RewardLevelUpPoint.GetHashCode();
			}
			if (this.Quit)
			{
				num ^= this.Quit.GetHashCode();
			}
			num ^= this.preTarget_.GetHashCode();
			num ^= this.finalTarget_.GetHashCode();
			if (this.Wave != 0)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.Health != 0)
			{
				num ^= this.Health.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.MaxWave != 0)
			{
				num ^= this.MaxWave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x00414B67 File Offset: 0x00412D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1E0 RID: 115168 RVA: 0x00414B74 File Offset: 0x00412D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1E1 RID: 115169 RVA: 0x00414B80 File Offset: 0x00412D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.target_.WriteTo(ref output, TrapDefenseResultInfo._repeated_target_codec);
			if (this.Success)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Success);
			}
			this.unlockBuilding_.WriteTo(ref output, TrapDefenseResultInfo._repeated_unlockBuilding_codec);
			this.unlockAuxiliary_.WriteTo(ref output, TrapDefenseResultInfo._repeated_unlockAuxiliary_codec);
			this.rewardItems_.WriteTo(ref output, TrapDefenseResultInfo._repeated_rewardItems_codec);
			this.unlockBds_.WriteTo(ref output, TrapDefenseResultInfo._repeated_unlockBds_codec);
			if (this.Quit)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Quit);
			}
			if (this.RewardLevelUpPoint != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RewardLevelUpPoint);
			}
			this.preTarget_.WriteTo(ref output, TrapDefenseResultInfo._repeated_preTarget_codec);
			this.finalTarget_.WriteTo(ref output, TrapDefenseResultInfo._repeated_finalTarget_codec);
			if (this.Wave != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Wave);
			}
			if (this.Health != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Health);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.MaxWave != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MaxWave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1E2 RID: 115170 RVA: 0x00414CDC File Offset: 0x00412EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.target_.CalculateSize(TrapDefenseResultInfo._repeated_target_codec);
			if (this.Success)
			{
				num += 2;
			}
			num += this.unlockBuilding_.CalculateSize(TrapDefenseResultInfo._repeated_unlockBuilding_codec);
			num += this.unlockAuxiliary_.CalculateSize(TrapDefenseResultInfo._repeated_unlockAuxiliary_codec);
			num += this.rewardItems_.CalculateSize(TrapDefenseResultInfo._repeated_rewardItems_codec);
			num += this.unlockBds_.CalculateSize(TrapDefenseResultInfo._repeated_unlockBds_codec);
			if (this.RewardLevelUpPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardLevelUpPoint);
			}
			if (this.Quit)
			{
				num += 2;
			}
			num += this.preTarget_.CalculateSize(TrapDefenseResultInfo._repeated_preTarget_codec);
			num += this.finalTarget_.CalculateSize(TrapDefenseResultInfo._repeated_finalTarget_codec);
			if (this.Wave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Wave);
			}
			if (this.Health != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Health);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.MaxWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxWave);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1E3 RID: 115171 RVA: 0x00414E18 File Offset: 0x00413018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.target_.Add(other.target_);
			if (other.Success)
			{
				this.Success = other.Success;
			}
			this.unlockBuilding_.Add(other.unlockBuilding_);
			this.unlockAuxiliary_.Add(other.unlockAuxiliary_);
			this.rewardItems_.Add(other.rewardItems_);
			this.unlockBds_.Add(other.unlockBds_);
			if (other.RewardLevelUpPoint != 0)
			{
				this.RewardLevelUpPoint = other.RewardLevelUpPoint;
			}
			if (other.Quit)
			{
				this.Quit = other.Quit;
			}
			this.preTarget_.Add(other.preTarget_);
			this.finalTarget_.Add(other.finalTarget_);
			if (other.Wave != 0)
			{
				this.Wave = other.Wave;
			}
			if (other.Health != 0)
			{
				this.Health = other.Health;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.MaxWave != 0)
			{
				this.MaxWave = other.MaxWave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1E4 RID: 115172 RVA: 0x00414F43 File Offset: 0x00413143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1E5 RID: 115173 RVA: 0x00414F4C File Offset: 0x0041314C
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
				if (num > 50U)
				{
					if (num <= 80U)
					{
						if (num <= 64U)
						{
							if (num == 56U)
							{
								this.Quit = input.ReadBool();
								continue;
							}
							if (num != 64U)
							{
								goto IL_E2;
							}
							this.RewardLevelUpPoint = input.ReadInt32();
							continue;
						}
						else
						{
							if (num == 72U || num == 74U)
							{
								this.preTarget_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_preTarget_codec);
								continue;
							}
							if (num != 80U)
							{
								goto IL_E2;
							}
						}
					}
					else if (num <= 88U)
					{
						if (num != 82U)
						{
							if (num != 88U)
							{
								goto IL_E2;
							}
							this.Wave = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.Health = input.ReadInt32();
							continue;
						}
						if (num == 104U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num != 112U)
						{
							goto IL_E2;
						}
						this.MaxWave = input.ReadInt32();
						continue;
					}
					this.finalTarget_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_finalTarget_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.target_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_target_codec);
							continue;
						}
					}
					else
					{
						if (num == 16U)
						{
							this.Success = input.ReadBool();
							continue;
						}
						if (num == 24U || num == 26U)
						{
							this.unlockBuilding_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_unlockBuilding_codec);
							continue;
						}
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.unlockAuxiliary_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_unlockAuxiliary_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_rewardItems_codec);
						continue;
					}
					if (num == 48U || num == 50U)
					{
						this.unlockBds_.AddEntriesFrom(ref input, TrapDefenseResultInfo._repeated_unlockBds_codec);
						continue;
					}
				}
				IL_E2:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A29D RID: 41629
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A29E RID: 41630
		public const int TargetFieldNumber = 1;

		// Token: 0x0400A29F RID: 41631
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A2A0 RID: 41632
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();

		// Token: 0x0400A2A1 RID: 41633
		public const int SuccessFieldNumber = 2;

		// Token: 0x0400A2A2 RID: 41634
		private bool success_;

		// Token: 0x0400A2A3 RID: 41635
		public const int UnlockBuildingFieldNumber = 3;

		// Token: 0x0400A2A4 RID: 41636
		private static readonly FieldCodec<int> _repeated_unlockBuilding_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A2A5 RID: 41637
		private readonly RepeatedField<int> unlockBuilding_ = new RepeatedField<int>();

		// Token: 0x0400A2A6 RID: 41638
		public const int UnlockAuxiliaryFieldNumber = 4;

		// Token: 0x0400A2A7 RID: 41639
		private static readonly FieldCodec<int> _repeated_unlockAuxiliary_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400A2A8 RID: 41640
		private readonly RepeatedField<int> unlockAuxiliary_ = new RepeatedField<int>();

		// Token: 0x0400A2A9 RID: 41641
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x0400A2AA RID: 41642
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(42U, RewardItem.Parser);

		// Token: 0x0400A2AB RID: 41643
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();

		// Token: 0x0400A2AC RID: 41644
		public const int UnlockBdsFieldNumber = 6;

		// Token: 0x0400A2AD RID: 41645
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400A2AE RID: 41646
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();

		// Token: 0x0400A2AF RID: 41647
		public const int RewardLevelUpPointFieldNumber = 8;

		// Token: 0x0400A2B0 RID: 41648
		private int rewardLevelUpPoint_;

		// Token: 0x0400A2B1 RID: 41649
		public const int QuitFieldNumber = 7;

		// Token: 0x0400A2B2 RID: 41650
		private bool quit_;

		// Token: 0x0400A2B3 RID: 41651
		public const int PreTargetFieldNumber = 9;

		// Token: 0x0400A2B4 RID: 41652
		private static readonly FieldCodec<int> _repeated_preTarget_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A2B5 RID: 41653
		private readonly RepeatedField<int> preTarget_ = new RepeatedField<int>();

		// Token: 0x0400A2B6 RID: 41654
		public const int FinalTargetFieldNumber = 10;

		// Token: 0x0400A2B7 RID: 41655
		private static readonly FieldCodec<int> _repeated_finalTarget_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A2B8 RID: 41656
		private readonly RepeatedField<int> finalTarget_ = new RepeatedField<int>();

		// Token: 0x0400A2B9 RID: 41657
		public const int WaveFieldNumber = 11;

		// Token: 0x0400A2BA RID: 41658
		private int wave_;

		// Token: 0x0400A2BB RID: 41659
		public const int HealthFieldNumber = 12;

		// Token: 0x0400A2BC RID: 41660
		private int health_;

		// Token: 0x0400A2BD RID: 41661
		public const int ChallengeIdFieldNumber = 13;

		// Token: 0x0400A2BE RID: 41662
		private int challengeId_;

		// Token: 0x0400A2BF RID: 41663
		public const int MaxWaveFieldNumber = 14;

		// Token: 0x0400A2C0 RID: 41664
		private int maxWave_;
	}
}
