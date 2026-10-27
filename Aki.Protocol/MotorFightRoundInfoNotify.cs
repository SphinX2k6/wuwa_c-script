using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A61 RID: 2657
	[NetMessage(EMessageId.MotorFightRoundInfoNotify)]
	public sealed class MotorFightRoundInfoNotify : IMessage<MotorFightRoundInfoNotify>, IMessage, IEquatable<MotorFightRoundInfoNotify>, IDeepCloneable<MotorFightRoundInfoNotify>, IBufferMessage
	{
		// Token: 0x0600E7C7 RID: 59335 RVA: 0x0021DBA2 File Offset: 0x0021BDA2
		[NullableContext(1)]
		public static MotorFightRoundInfoNotify Create()
		{
			return new MotorFightRoundInfoNotify();
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600E7C8 RID: 59336 RVA: 0x0021DBA9 File Offset: 0x0021BDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600E7C9 RID: 59337 RVA: 0x0021DBAC File Offset: 0x0021BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600E7CA RID: 59338 RVA: 0x0021DBB3 File Offset: 0x0021BDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundInfoNotify()
		{
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x0021DBE8 File Offset: 0x0021BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundInfoNotify(MotorFightRoundInfoNotify other) : this()
		{
			this.passSubLevelIndex_ = other.passSubLevelIndex_;
			this.playerHp_ = other.playerHp_;
			this.buffs_ = other.buffs_.Clone();
			this.collections_ = other.collections_.Clone();
			this.enemyBuffs_ = other.enemyBuffs_.Clone();
			this.refreshCollectionTimes_ = other.refreshCollectionTimes_;
			this.bossIds_ = other.bossIds_.Clone();
			this.gameTime_ = other.gameTime_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x0021DC8C File Offset: 0x0021BE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundInfoNotify Clone()
		{
			return new MotorFightRoundInfoNotify(this);
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600E7CD RID: 59341 RVA: 0x0021DC94 File Offset: 0x0021BE94
		// (set) Token: 0x0600E7CE RID: 59342 RVA: 0x0021DC9C File Offset: 0x0021BE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassSubLevelIndex
		{
			get
			{
				return this.passSubLevelIndex_;
			}
			set
			{
				this.passSubLevelIndex_ = value;
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600E7CF RID: 59343 RVA: 0x0021DCA5 File Offset: 0x0021BEA5
		// (set) Token: 0x0600E7D0 RID: 59344 RVA: 0x0021DCAD File Offset: 0x0021BEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerHp
		{
			get
			{
				return this.playerHp_;
			}
			set
			{
				this.playerHp_ = value;
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600E7D1 RID: 59345 RVA: 0x0021DCB6 File Offset: 0x0021BEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600E7D2 RID: 59346 RVA: 0x0021DCBE File Offset: 0x0021BEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundCollectionPb> Collections
		{
			get
			{
				return this.collections_;
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x0021DCC6 File Offset: 0x0021BEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> EnemyBuffs
		{
			get
			{
				return this.enemyBuffs_;
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600E7D4 RID: 59348 RVA: 0x0021DCCE File Offset: 0x0021BECE
		// (set) Token: 0x0600E7D5 RID: 59349 RVA: 0x0021DCD6 File Offset: 0x0021BED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCollectionTimes
		{
			get
			{
				return this.refreshCollectionTimes_;
			}
			set
			{
				this.refreshCollectionTimes_ = value;
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600E7D6 RID: 59350 RVA: 0x0021DCDF File Offset: 0x0021BEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BossIds
		{
			get
			{
				return this.bossIds_;
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600E7D7 RID: 59351 RVA: 0x0021DCE7 File Offset: 0x0021BEE7
		// (set) Token: 0x0600E7D8 RID: 59352 RVA: 0x0021DCEF File Offset: 0x0021BEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GameTime
		{
			get
			{
				return this.gameTime_;
			}
			set
			{
				this.gameTime_ = value;
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x0021DCF8 File Offset: 0x0021BEF8
		// (set) Token: 0x0600E7DA RID: 59354 RVA: 0x0021DD00 File Offset: 0x0021BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x0021DD09 File Offset: 0x0021BF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundInfoNotify);
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x0021DD18 File Offset: 0x0021BF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundInfoNotify other)
		{
			return other != null && (other == this || (this.PassSubLevelIndex == other.PassSubLevelIndex && this.PlayerHp == other.PlayerHp && this.buffs_.Equals(other.buffs_) && this.collections_.Equals(other.collections_) && this.enemyBuffs_.Equals(other.enemyBuffs_) && this.RefreshCollectionTimes == other.RefreshCollectionTimes && this.bossIds_.Equals(other.bossIds_) && this.GameTime == other.GameTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x0021DDE8 File Offset: 0x0021BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PassSubLevelIndex != 0)
			{
				num ^= this.PassSubLevelIndex.GetHashCode();
			}
			if (this.PlayerHp != 0)
			{
				num ^= this.PlayerHp.GetHashCode();
			}
			num ^= this.buffs_.GetHashCode();
			num ^= this.collections_.GetHashCode();
			num ^= this.enemyBuffs_.GetHashCode();
			if (this.RefreshCollectionTimes != 0)
			{
				num ^= this.RefreshCollectionTimes.GetHashCode();
			}
			num ^= this.bossIds_.GetHashCode();
			if (this.GameTime != 0)
			{
				num ^= this.GameTime.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x0021DEC3 File Offset: 0x0021C0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x0021DED0 File Offset: 0x0021C0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x0021DEDC File Offset: 0x0021C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enemyBuffs_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_enemyBuffs_codec);
			this.buffs_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_buffs_codec);
			if (this.GameTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GameTime);
			}
			this.bossIds_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_bossIds_codec);
			this.collections_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_collections_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Score);
			}
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			if (this.PassSubLevelIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PassSubLevelIndex);
			}
			if (this.PlayerHp != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x0021DFD0 File Offset: 0x0021C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PassSubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassSubLevelIndex);
			}
			if (this.PlayerHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerHp);
			}
			num += this.buffs_.CalculateSize(MotorFightRoundInfoNotify._repeated_buffs_codec);
			num += this.collections_.CalculateSize(MotorFightRoundInfoNotify._repeated_collections_codec);
			num += this.enemyBuffs_.CalculateSize(MotorFightRoundInfoNotify._repeated_enemyBuffs_codec);
			if (this.RefreshCollectionTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCollectionTimes);
			}
			num += this.bossIds_.CalculateSize(MotorFightRoundInfoNotify._repeated_bossIds_codec);
			if (this.GameTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameTime);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x0021E0BC File Offset: 0x0021C2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoundInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PassSubLevelIndex != 0)
			{
				this.PassSubLevelIndex = other.PassSubLevelIndex;
			}
			if (other.PlayerHp != 0)
			{
				this.PlayerHp = other.PlayerHp;
			}
			this.buffs_.Add(other.buffs_);
			this.collections_.Add(other.collections_);
			this.enemyBuffs_.Add(other.enemyBuffs_);
			if (other.RefreshCollectionTimes != 0)
			{
				this.RefreshCollectionTimes = other.RefreshCollectionTimes;
			}
			this.bossIds_.Add(other.bossIds_);
			if (other.GameTime != 0)
			{
				this.GameTime = other.GameTime;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7E3 RID: 59363 RVA: 0x0021E18C File Offset: 0x0021C38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x0021E198 File Offset: 0x0021C398
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
				if (num <= 66U)
				{
					if (num <= 26U)
					{
						if (num == 18U)
						{
							this.enemyBuffs_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_enemyBuffs_codec);
							continue;
						}
						if (num == 26U)
						{
							this.buffs_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_buffs_codec);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.GameTime = input.ReadInt32();
							continue;
						}
						if (num == 64U || num == 66U)
						{
							this.bossIds_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_bossIds_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 74U)
					{
						this.collections_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_collections_codec);
						continue;
					}
					if (num == 88U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.RefreshCollectionTimes = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PassSubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PlayerHp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E6B RID: 24171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E6C RID: 24172
		public const int PassSubLevelIndexFieldNumber = 13;

		// Token: 0x04005E6D RID: 24173
		private int passSubLevelIndex_;

		// Token: 0x04005E6E RID: 24174
		public const int PlayerHpFieldNumber = 15;

		// Token: 0x04005E6F RID: 24175
		private int playerHp_;

		// Token: 0x04005E70 RID: 24176
		public const int BuffsFieldNumber = 3;

		// Token: 0x04005E71 RID: 24177
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_buffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(26U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005E72 RID: 24178
		private readonly RepeatedField<MotorFightRoundBuffPb> buffs_ = new RepeatedField<MotorFightRoundBuffPb>();

		// Token: 0x04005E73 RID: 24179
		public const int CollectionsFieldNumber = 9;

		// Token: 0x04005E74 RID: 24180
		private static readonly FieldCodec<MotorFightRoundCollectionPb> _repeated_collections_codec = FieldCodec.ForMessage<MotorFightRoundCollectionPb>(74U, MotorFightRoundCollectionPb.Parser);

		// Token: 0x04005E75 RID: 24181
		private readonly RepeatedField<MotorFightRoundCollectionPb> collections_ = new RepeatedField<MotorFightRoundCollectionPb>();

		// Token: 0x04005E76 RID: 24182
		public const int EnemyBuffsFieldNumber = 2;

		// Token: 0x04005E77 RID: 24183
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_enemyBuffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(18U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005E78 RID: 24184
		private readonly RepeatedField<MotorFightRoundBuffPb> enemyBuffs_ = new RepeatedField<MotorFightRoundBuffPb>();

		// Token: 0x04005E79 RID: 24185
		public const int RefreshCollectionTimesFieldNumber = 12;

		// Token: 0x04005E7A RID: 24186
		private int refreshCollectionTimes_;

		// Token: 0x04005E7B RID: 24187
		public const int BossIdsFieldNumber = 8;

		// Token: 0x04005E7C RID: 24188
		private static readonly FieldCodec<int> _repeated_bossIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005E7D RID: 24189
		private readonly RepeatedField<int> bossIds_ = new RepeatedField<int>();

		// Token: 0x04005E7E RID: 24190
		public const int GameTimeFieldNumber = 4;

		// Token: 0x04005E7F RID: 24191
		private int gameTime_;

		// Token: 0x04005E80 RID: 24192
		public const int ScoreFieldNumber = 11;

		// Token: 0x04005E81 RID: 24193
		private int score_;
	}
}
