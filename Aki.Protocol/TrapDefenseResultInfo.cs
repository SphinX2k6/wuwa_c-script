using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143F RID: 5183
	public sealed class TrapDefenseResultInfo : IMessage<TrapDefenseResultInfo>, IMessage, IEquatable<TrapDefenseResultInfo>, IDeepCloneable<TrapDefenseResultInfo>, IBufferMessage
	{
		// Token: 0x0601B736 RID: 112438 RVA: 0x003F940B File Offset: 0x003F760B
		[NullableContext(1)]
		public static TrapDefenseResultInfo Create()
		{
			return new TrapDefenseResultInfo();
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x0601B737 RID: 112439 RVA: 0x003F9412 File Offset: 0x003F7612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x0601B738 RID: 112440 RVA: 0x003F9415 File Offset: 0x003F7615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseResultInfo.Descriptor;
			}
		}

		// Token: 0x0601B739 RID: 112441 RVA: 0x003F941C File Offset: 0x003F761C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo()
		{
		}

		// Token: 0x0601B73A RID: 112442 RVA: 0x003F947C File Offset: 0x003F767C
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

		// Token: 0x0601B73B RID: 112443 RVA: 0x003F956B File Offset: 0x003F776B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo Clone()
		{
			return new TrapDefenseResultInfo(this);
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x0601B73C RID: 112444 RVA: 0x003F9573 File Offset: 0x003F7773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x0601B73D RID: 112445 RVA: 0x003F957B File Offset: 0x003F777B
		// (set) Token: 0x0601B73E RID: 112446 RVA: 0x003F9583 File Offset: 0x003F7783
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

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x0601B73F RID: 112447 RVA: 0x003F958C File Offset: 0x003F778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuilding
		{
			get
			{
				return this.unlockBuilding_;
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x0601B740 RID: 112448 RVA: 0x003F9594 File Offset: 0x003F7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockAuxiliary
		{
			get
			{
				return this.unlockAuxiliary_;
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x0601B741 RID: 112449 RVA: 0x003F959C File Offset: 0x003F779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x0601B742 RID: 112450 RVA: 0x003F95A4 File Offset: 0x003F77A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x0601B743 RID: 112451 RVA: 0x003F95AC File Offset: 0x003F77AC
		// (set) Token: 0x0601B744 RID: 112452 RVA: 0x003F95B4 File Offset: 0x003F77B4
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

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x0601B745 RID: 112453 RVA: 0x003F95BD File Offset: 0x003F77BD
		// (set) Token: 0x0601B746 RID: 112454 RVA: 0x003F95C5 File Offset: 0x003F77C5
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

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x0601B747 RID: 112455 RVA: 0x003F95CE File Offset: 0x003F77CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreTarget
		{
			get
			{
				return this.preTarget_;
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x0601B748 RID: 112456 RVA: 0x003F95D6 File Offset: 0x003F77D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinalTarget
		{
			get
			{
				return this.finalTarget_;
			}
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x0601B749 RID: 112457 RVA: 0x003F95DE File Offset: 0x003F77DE
		// (set) Token: 0x0601B74A RID: 112458 RVA: 0x003F95E6 File Offset: 0x003F77E6
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

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x0601B74B RID: 112459 RVA: 0x003F95EF File Offset: 0x003F77EF
		// (set) Token: 0x0601B74C RID: 112460 RVA: 0x003F95F7 File Offset: 0x003F77F7
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

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x0601B74D RID: 112461 RVA: 0x003F9600 File Offset: 0x003F7800
		// (set) Token: 0x0601B74E RID: 112462 RVA: 0x003F9608 File Offset: 0x003F7808
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

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x0601B74F RID: 112463 RVA: 0x003F9611 File Offset: 0x003F7811
		// (set) Token: 0x0601B750 RID: 112464 RVA: 0x003F9619 File Offset: 0x003F7819
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

		// Token: 0x0601B751 RID: 112465 RVA: 0x003F9622 File Offset: 0x003F7822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseResultInfo);
		}

		// Token: 0x0601B752 RID: 112466 RVA: 0x003F9630 File Offset: 0x003F7830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseResultInfo other)
		{
			return other != null && (other == this || (this.target_.Equals(other.target_) && this.Success == other.Success && this.unlockBuilding_.Equals(other.unlockBuilding_) && this.unlockAuxiliary_.Equals(other.unlockAuxiliary_) && this.rewardItems_.Equals(other.rewardItems_) && this.unlockBds_.Equals(other.unlockBds_) && this.RewardLevelUpPoint == other.RewardLevelUpPoint && this.Quit == other.Quit && this.preTarget_.Equals(other.preTarget_) && this.finalTarget_.Equals(other.finalTarget_) && this.Wave == other.Wave && this.Health == other.Health && this.ChallengeId == other.ChallengeId && this.MaxWave == other.MaxWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B753 RID: 112467 RVA: 0x003F975C File Offset: 0x003F795C
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

		// Token: 0x0601B754 RID: 112468 RVA: 0x003F9893 File Offset: 0x003F7A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B755 RID: 112469 RVA: 0x003F98A0 File Offset: 0x003F7AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B756 RID: 112470 RVA: 0x003F98AC File Offset: 0x003F7AAC
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

		// Token: 0x0601B757 RID: 112471 RVA: 0x003F9A08 File Offset: 0x003F7C08
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

		// Token: 0x0601B758 RID: 112472 RVA: 0x003F9B44 File Offset: 0x003F7D44
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

		// Token: 0x0601B759 RID: 112473 RVA: 0x003F9C6F File Offset: 0x003F7E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B75A RID: 112474 RVA: 0x003F9C78 File Offset: 0x003F7E78
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

		// Token: 0x04009E56 RID: 40534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E57 RID: 40535
		public const int TargetFieldNumber = 1;

		// Token: 0x04009E58 RID: 40536
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009E59 RID: 40537
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();

		// Token: 0x04009E5A RID: 40538
		public const int SuccessFieldNumber = 2;

		// Token: 0x04009E5B RID: 40539
		private bool success_;

		// Token: 0x04009E5C RID: 40540
		public const int UnlockBuildingFieldNumber = 3;

		// Token: 0x04009E5D RID: 40541
		private static readonly FieldCodec<int> _repeated_unlockBuilding_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009E5E RID: 40542
		private readonly RepeatedField<int> unlockBuilding_ = new RepeatedField<int>();

		// Token: 0x04009E5F RID: 40543
		public const int UnlockAuxiliaryFieldNumber = 4;

		// Token: 0x04009E60 RID: 40544
		private static readonly FieldCodec<int> _repeated_unlockAuxiliary_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009E61 RID: 40545
		private readonly RepeatedField<int> unlockAuxiliary_ = new RepeatedField<int>();

		// Token: 0x04009E62 RID: 40546
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x04009E63 RID: 40547
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(42U, RewardItem.Parser);

		// Token: 0x04009E64 RID: 40548
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();

		// Token: 0x04009E65 RID: 40549
		public const int UnlockBdsFieldNumber = 6;

		// Token: 0x04009E66 RID: 40550
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04009E67 RID: 40551
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();

		// Token: 0x04009E68 RID: 40552
		public const int RewardLevelUpPointFieldNumber = 8;

		// Token: 0x04009E69 RID: 40553
		private int rewardLevelUpPoint_;

		// Token: 0x04009E6A RID: 40554
		public const int QuitFieldNumber = 7;

		// Token: 0x04009E6B RID: 40555
		private bool quit_;

		// Token: 0x04009E6C RID: 40556
		public const int PreTargetFieldNumber = 9;

		// Token: 0x04009E6D RID: 40557
		private static readonly FieldCodec<int> _repeated_preTarget_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009E6E RID: 40558
		private readonly RepeatedField<int> preTarget_ = new RepeatedField<int>();

		// Token: 0x04009E6F RID: 40559
		public const int FinalTargetFieldNumber = 10;

		// Token: 0x04009E70 RID: 40560
		private static readonly FieldCodec<int> _repeated_finalTarget_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009E71 RID: 40561
		private readonly RepeatedField<int> finalTarget_ = new RepeatedField<int>();

		// Token: 0x04009E72 RID: 40562
		public const int WaveFieldNumber = 11;

		// Token: 0x04009E73 RID: 40563
		private int wave_;

		// Token: 0x04009E74 RID: 40564
		public const int HealthFieldNumber = 12;

		// Token: 0x04009E75 RID: 40565
		private int health_;

		// Token: 0x04009E76 RID: 40566
		public const int ChallengeIdFieldNumber = 13;

		// Token: 0x04009E77 RID: 40567
		private int challengeId_;

		// Token: 0x04009E78 RID: 40568
		public const int MaxWaveFieldNumber = 14;

		// Token: 0x04009E79 RID: 40569
		private int maxWave_;
	}
}
