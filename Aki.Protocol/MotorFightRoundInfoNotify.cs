using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A50 RID: 2640
	[NetMessage(EMessageId.MotorFightRoundInfoNotify)]
	public sealed class MotorFightRoundInfoNotify : IMessage<MotorFightRoundInfoNotify>, IMessage, IEquatable<MotorFightRoundInfoNotify>, IDeepCloneable<MotorFightRoundInfoNotify>, IBufferMessage
	{
		// Token: 0x0600E6AD RID: 59053 RVA: 0x0021B9AE File Offset: 0x00219BAE
		[NullableContext(1)]
		public static MotorFightRoundInfoNotify Create()
		{
			return new MotorFightRoundInfoNotify();
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0021B9B5 File Offset: 0x00219BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600E6AF RID: 59055 RVA: 0x0021B9B8 File Offset: 0x00219BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x0021B9BF File Offset: 0x00219BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundInfoNotify()
		{
		}

		// Token: 0x0600E6B1 RID: 59057 RVA: 0x0021B9F4 File Offset: 0x00219BF4
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

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x0021BA98 File Offset: 0x00219C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundInfoNotify Clone()
		{
			return new MotorFightRoundInfoNotify(this);
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600E6B3 RID: 59059 RVA: 0x0021BAA0 File Offset: 0x00219CA0
		// (set) Token: 0x0600E6B4 RID: 59060 RVA: 0x0021BAA8 File Offset: 0x00219CA8
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

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x0021BAB1 File Offset: 0x00219CB1
		// (set) Token: 0x0600E6B6 RID: 59062 RVA: 0x0021BAB9 File Offset: 0x00219CB9
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

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x0021BAC2 File Offset: 0x00219CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x0021BACA File Offset: 0x00219CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundCollectionPb> Collections
		{
			get
			{
				return this.collections_;
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600E6B9 RID: 59065 RVA: 0x0021BAD2 File Offset: 0x00219CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> EnemyBuffs
		{
			get
			{
				return this.enemyBuffs_;
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x0021BADA File Offset: 0x00219CDA
		// (set) Token: 0x0600E6BB RID: 59067 RVA: 0x0021BAE2 File Offset: 0x00219CE2
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

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600E6BC RID: 59068 RVA: 0x0021BAEB File Offset: 0x00219CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BossIds
		{
			get
			{
				return this.bossIds_;
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x0021BAF3 File Offset: 0x00219CF3
		// (set) Token: 0x0600E6BE RID: 59070 RVA: 0x0021BAFB File Offset: 0x00219CFB
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

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x0021BB04 File Offset: 0x00219D04
		// (set) Token: 0x0600E6C0 RID: 59072 RVA: 0x0021BB0C File Offset: 0x00219D0C
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

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x0021BB15 File Offset: 0x00219D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundInfoNotify);
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x0021BB24 File Offset: 0x00219D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundInfoNotify other)
		{
			return other != null && (other == this || (this.PassSubLevelIndex == other.PassSubLevelIndex && this.PlayerHp == other.PlayerHp && this.buffs_.Equals(other.buffs_) && this.collections_.Equals(other.collections_) && this.enemyBuffs_.Equals(other.enemyBuffs_) && this.RefreshCollectionTimes == other.RefreshCollectionTimes && this.bossIds_.Equals(other.bossIds_) && this.GameTime == other.GameTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0021BBF4 File Offset: 0x00219DF4
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

		// Token: 0x0600E6C4 RID: 59076 RVA: 0x0021BCCF File Offset: 0x00219ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6C5 RID: 59077 RVA: 0x0021BCDC File Offset: 0x00219EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6C6 RID: 59078 RVA: 0x0021BCE8 File Offset: 0x00219EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffs_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_buffs_codec);
			this.bossIds_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_bossIds_codec);
			this.collections_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_collections_codec);
			if (this.PlayerHp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerHp);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Score);
			}
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			if (this.GameTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GameTime);
			}
			if (this.PassSubLevelIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PassSubLevelIndex);
			}
			this.enemyBuffs_.WriteTo(ref output, MotorFightRoundInfoNotify._repeated_enemyBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6C7 RID: 59079 RVA: 0x0021BDDC File Offset: 0x00219FDC
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

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x0021BEC8 File Offset: 0x0021A0C8
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

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x0021BF98 File Offset: 0x0021A198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x0021BFA4 File Offset: 0x0021A1A4
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
						if (num == 10U)
						{
							this.buffs_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_buffs_codec);
							continue;
						}
						if (num != 24U)
						{
							goto IL_65;
						}
					}
					else if (num != 26U)
					{
						if (num == 34U)
						{
							this.collections_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_collections_codec);
							continue;
						}
						if (num != 48U)
						{
							goto IL_65;
						}
						this.PlayerHp = input.ReadInt32();
						continue;
					}
					this.bossIds_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_bossIds_codec);
					continue;
				}
				if (num <= 80U)
				{
					if (num == 72U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RefreshCollectionTimes = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.GameTime = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.PassSubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.enemyBuffs_.AddEntriesFrom(ref input, MotorFightRoundInfoNotify._repeated_enemyBuffs_codec);
						continue;
					}
				}
				IL_65:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E74 RID: 24180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E75 RID: 24181
		public const int PassSubLevelIndexFieldNumber = 12;

		// Token: 0x04005E76 RID: 24182
		private int passSubLevelIndex_;

		// Token: 0x04005E77 RID: 24183
		public const int PlayerHpFieldNumber = 6;

		// Token: 0x04005E78 RID: 24184
		private int playerHp_;

		// Token: 0x04005E79 RID: 24185
		public const int BuffsFieldNumber = 1;

		// Token: 0x04005E7A RID: 24186
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_buffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(10U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005E7B RID: 24187
		private readonly RepeatedField<MotorFightRoundBuffPb> buffs_ = new RepeatedField<MotorFightRoundBuffPb>();

		// Token: 0x04005E7C RID: 24188
		public const int CollectionsFieldNumber = 4;

		// Token: 0x04005E7D RID: 24189
		private static readonly FieldCodec<MotorFightRoundCollectionPb> _repeated_collections_codec = FieldCodec.ForMessage<MotorFightRoundCollectionPb>(34U, MotorFightRoundCollectionPb.Parser);

		// Token: 0x04005E7E RID: 24190
		private readonly RepeatedField<MotorFightRoundCollectionPb> collections_ = new RepeatedField<MotorFightRoundCollectionPb>();

		// Token: 0x04005E7F RID: 24191
		public const int EnemyBuffsFieldNumber = 14;

		// Token: 0x04005E80 RID: 24192
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_enemyBuffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(114U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005E81 RID: 24193
		private readonly RepeatedField<MotorFightRoundBuffPb> enemyBuffs_ = new RepeatedField<MotorFightRoundBuffPb>();

		// Token: 0x04005E82 RID: 24194
		public const int RefreshCollectionTimesFieldNumber = 10;

		// Token: 0x04005E83 RID: 24195
		private int refreshCollectionTimes_;

		// Token: 0x04005E84 RID: 24196
		public const int BossIdsFieldNumber = 3;

		// Token: 0x04005E85 RID: 24197
		private static readonly FieldCodec<int> _repeated_bossIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005E86 RID: 24198
		private readonly RepeatedField<int> bossIds_ = new RepeatedField<int>();

		// Token: 0x04005E87 RID: 24199
		public const int GameTimeFieldNumber = 11;

		// Token: 0x04005E88 RID: 24200
		private int gameTime_;

		// Token: 0x04005E89 RID: 24201
		public const int ScoreFieldNumber = 9;

		// Token: 0x04005E8A RID: 24202
		private int score_;
	}
}
