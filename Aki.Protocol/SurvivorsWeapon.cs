using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F0 RID: 4848
	public sealed class SurvivorsWeapon : IMessage<SurvivorsWeapon>, IMessage, IEquatable<SurvivorsWeapon>, IDeepCloneable<SurvivorsWeapon>, IBufferMessage
	{
		// Token: 0x06019C70 RID: 105584 RVA: 0x003BF038 File Offset: 0x003BD238
		[NullableContext(1)]
		public static SurvivorsWeapon Create()
		{
			return new SurvivorsWeapon();
		}

		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x06019C71 RID: 105585 RVA: 0x003BF03F File Offset: 0x003BD23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x06019C72 RID: 105586 RVA: 0x003BF042 File Offset: 0x003BD242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeapon.Descriptor;
			}
		}

		// Token: 0x06019C73 RID: 105587 RVA: 0x003BF049 File Offset: 0x003BD249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon()
		{
		}

		// Token: 0x06019C74 RID: 105588 RVA: 0x003BF068 File Offset: 0x003BD268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon(SurvivorsWeapon other) : this()
		{
			this.level_ = other.level_;
			this.maxLevel_ = other.maxLevel_;
			this.affixs_ = other.affixs_.Clone();
			this.evolves_ = other.evolves_.Clone();
			this.killMonsterCount_ = other.killMonsterCount_;
			this.weaponBondId_ = other.weaponBondId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C75 RID: 105589 RVA: 0x003BF0DE File Offset: 0x003BD2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon Clone()
		{
			return new SurvivorsWeapon(this);
		}

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x06019C76 RID: 105590 RVA: 0x003BF0E6 File Offset: 0x003BD2E6
		// (set) Token: 0x06019C77 RID: 105591 RVA: 0x003BF0EE File Offset: 0x003BD2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x06019C78 RID: 105592 RVA: 0x003BF0F7 File Offset: 0x003BD2F7
		// (set) Token: 0x06019C79 RID: 105593 RVA: 0x003BF0FF File Offset: 0x003BD2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLevel
		{
			get
			{
				return this.maxLevel_;
			}
			set
			{
				this.maxLevel_ = value;
			}
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x06019C7A RID: 105594 RVA: 0x003BF108 File Offset: 0x003BD308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affixs
		{
			get
			{
				return this.affixs_;
			}
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x06019C7B RID: 105595 RVA: 0x003BF110 File Offset: 0x003BD310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Evolves
		{
			get
			{
				return this.evolves_;
			}
		}

		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x06019C7C RID: 105596 RVA: 0x003BF118 File Offset: 0x003BD318
		// (set) Token: 0x06019C7D RID: 105597 RVA: 0x003BF120 File Offset: 0x003BD320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillMonsterCount
		{
			get
			{
				return this.killMonsterCount_;
			}
			set
			{
				this.killMonsterCount_ = value;
			}
		}

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x06019C7E RID: 105598 RVA: 0x003BF129 File Offset: 0x003BD329
		// (set) Token: 0x06019C7F RID: 105599 RVA: 0x003BF131 File Offset: 0x003BD331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBondId
		{
			get
			{
				return this.weaponBondId_;
			}
			set
			{
				this.weaponBondId_ = value;
			}
		}

		// Token: 0x06019C80 RID: 105600 RVA: 0x003BF13A File Offset: 0x003BD33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeapon);
		}

		// Token: 0x06019C81 RID: 105601 RVA: 0x003BF148 File Offset: 0x003BD348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeapon other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MaxLevel == other.MaxLevel && this.affixs_.Equals(other.affixs_) && this.evolves_.Equals(other.evolves_) && this.KillMonsterCount == other.KillMonsterCount && this.WeaponBondId == other.WeaponBondId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C82 RID: 105602 RVA: 0x003BF1DC File Offset: 0x003BD3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MaxLevel != 0)
			{
				num ^= this.MaxLevel.GetHashCode();
			}
			num ^= this.affixs_.GetHashCode();
			num ^= this.evolves_.GetHashCode();
			if (this.KillMonsterCount != 0)
			{
				num ^= this.KillMonsterCount.GetHashCode();
			}
			if (this.WeaponBondId != 0)
			{
				num ^= this.WeaponBondId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C83 RID: 105603 RVA: 0x003BF282 File Offset: 0x003BD482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C84 RID: 105604 RVA: 0x003BF28F File Offset: 0x003BD48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C85 RID: 105605 RVA: 0x003BF298 File Offset: 0x003BD498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.MaxLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxLevel);
			}
			this.affixs_.WriteTo(ref output, SurvivorsWeapon._repeated_affixs_codec);
			this.evolves_.WriteTo(ref output, SurvivorsWeapon._repeated_evolves_codec);
			if (this.KillMonsterCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.KillMonsterCount);
			}
			if (this.WeaponBondId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponBondId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C86 RID: 105606 RVA: 0x003BF34C File Offset: 0x003BD54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.MaxLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLevel);
			}
			num += this.affixs_.CalculateSize(SurvivorsWeapon._repeated_affixs_codec);
			num += this.evolves_.CalculateSize(SurvivorsWeapon._repeated_evolves_codec);
			if (this.KillMonsterCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillMonsterCount);
			}
			if (this.WeaponBondId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBondId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C87 RID: 105607 RVA: 0x003BF3F8 File Offset: 0x003BD5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeapon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.MaxLevel != 0)
			{
				this.MaxLevel = other.MaxLevel;
			}
			this.affixs_.Add(other.affixs_);
			this.evolves_.Add(other.evolves_);
			if (other.KillMonsterCount != 0)
			{
				this.KillMonsterCount = other.KillMonsterCount;
			}
			if (other.WeaponBondId != 0)
			{
				this.WeaponBondId = other.WeaponBondId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C88 RID: 105608 RVA: 0x003BF492 File Offset: 0x003BD692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C89 RID: 105609 RVA: 0x003BF49C File Offset: 0x003BD69C
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
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.MaxLevel = input.ReadInt32();
							continue;
						}
					}
					else if (num == 24U || num == 26U)
					{
						this.affixs_.AddEntriesFrom(ref input, SurvivorsWeapon._repeated_affixs_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.evolves_.AddEntriesFrom(ref input, SurvivorsWeapon._repeated_evolves_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.KillMonsterCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.WeaponBondId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040096DC RID: 38620
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096DD RID: 38621
		public const int LevelFieldNumber = 1;

		// Token: 0x040096DE RID: 38622
		private int level_;

		// Token: 0x040096DF RID: 38623
		public const int MaxLevelFieldNumber = 2;

		// Token: 0x040096E0 RID: 38624
		private int maxLevel_;

		// Token: 0x040096E1 RID: 38625
		public const int AffixsFieldNumber = 3;

		// Token: 0x040096E2 RID: 38626
		private static readonly FieldCodec<int> _repeated_affixs_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040096E3 RID: 38627
		private readonly RepeatedField<int> affixs_ = new RepeatedField<int>();

		// Token: 0x040096E4 RID: 38628
		public const int EvolvesFieldNumber = 4;

		// Token: 0x040096E5 RID: 38629
		private static readonly FieldCodec<int> _repeated_evolves_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040096E6 RID: 38630
		private readonly RepeatedField<int> evolves_ = new RepeatedField<int>();

		// Token: 0x040096E7 RID: 38631
		public const int KillMonsterCountFieldNumber = 5;

		// Token: 0x040096E8 RID: 38632
		private int killMonsterCount_;

		// Token: 0x040096E9 RID: 38633
		public const int WeaponBondIdFieldNumber = 6;

		// Token: 0x040096EA RID: 38634
		private int weaponBondId_;
	}
}
