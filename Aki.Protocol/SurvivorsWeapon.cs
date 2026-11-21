using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135F RID: 4959
	public sealed class SurvivorsWeapon : IMessage<SurvivorsWeapon>, IMessage, IEquatable<SurvivorsWeapon>, IDeepCloneable<SurvivorsWeapon>, IBufferMessage
	{
		// Token: 0x0601A6A6 RID: 108198 RVA: 0x003D9758 File Offset: 0x003D7958
		[NullableContext(1)]
		public static SurvivorsWeapon Create()
		{
			return new SurvivorsWeapon();
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x0601A6A7 RID: 108199 RVA: 0x003D975F File Offset: 0x003D795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x0601A6A8 RID: 108200 RVA: 0x003D9762 File Offset: 0x003D7962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeapon.Descriptor;
			}
		}

		// Token: 0x0601A6A9 RID: 108201 RVA: 0x003D9769 File Offset: 0x003D7969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon()
		{
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x003D9788 File Offset: 0x003D7988
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

		// Token: 0x0601A6AB RID: 108203 RVA: 0x003D97FE File Offset: 0x003D79FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon Clone()
		{
			return new SurvivorsWeapon(this);
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x0601A6AC RID: 108204 RVA: 0x003D9806 File Offset: 0x003D7A06
		// (set) Token: 0x0601A6AD RID: 108205 RVA: 0x003D980E File Offset: 0x003D7A0E
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

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x0601A6AE RID: 108206 RVA: 0x003D9817 File Offset: 0x003D7A17
		// (set) Token: 0x0601A6AF RID: 108207 RVA: 0x003D981F File Offset: 0x003D7A1F
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

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x0601A6B0 RID: 108208 RVA: 0x003D9828 File Offset: 0x003D7A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affixs
		{
			get
			{
				return this.affixs_;
			}
		}

		// Token: 0x17005975 RID: 22901
		// (get) Token: 0x0601A6B1 RID: 108209 RVA: 0x003D9830 File Offset: 0x003D7A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Evolves
		{
			get
			{
				return this.evolves_;
			}
		}

		// Token: 0x17005976 RID: 22902
		// (get) Token: 0x0601A6B2 RID: 108210 RVA: 0x003D9838 File Offset: 0x003D7A38
		// (set) Token: 0x0601A6B3 RID: 108211 RVA: 0x003D9840 File Offset: 0x003D7A40
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

		// Token: 0x17005977 RID: 22903
		// (get) Token: 0x0601A6B4 RID: 108212 RVA: 0x003D9849 File Offset: 0x003D7A49
		// (set) Token: 0x0601A6B5 RID: 108213 RVA: 0x003D9851 File Offset: 0x003D7A51
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

		// Token: 0x0601A6B6 RID: 108214 RVA: 0x003D985A File Offset: 0x003D7A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeapon);
		}

		// Token: 0x0601A6B7 RID: 108215 RVA: 0x003D9868 File Offset: 0x003D7A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeapon other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MaxLevel == other.MaxLevel && this.affixs_.Equals(other.affixs_) && this.evolves_.Equals(other.evolves_) && this.KillMonsterCount == other.KillMonsterCount && this.WeaponBondId == other.WeaponBondId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6B8 RID: 108216 RVA: 0x003D98FC File Offset: 0x003D7AFC
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

		// Token: 0x0601A6B9 RID: 108217 RVA: 0x003D99A2 File Offset: 0x003D7BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6BA RID: 108218 RVA: 0x003D99AF File Offset: 0x003D7BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6BB RID: 108219 RVA: 0x003D99B8 File Offset: 0x003D7BB8
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

		// Token: 0x0601A6BC RID: 108220 RVA: 0x003D9A6C File Offset: 0x003D7C6C
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

		// Token: 0x0601A6BD RID: 108221 RVA: 0x003D9B18 File Offset: 0x003D7D18
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

		// Token: 0x0601A6BE RID: 108222 RVA: 0x003D9BB2 File Offset: 0x003D7DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6BF RID: 108223 RVA: 0x003D9BBC File Offset: 0x003D7DBC
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

		// Token: 0x04009B06 RID: 39686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B07 RID: 39687
		public const int LevelFieldNumber = 1;

		// Token: 0x04009B08 RID: 39688
		private int level_;

		// Token: 0x04009B09 RID: 39689
		public const int MaxLevelFieldNumber = 2;

		// Token: 0x04009B0A RID: 39690
		private int maxLevel_;

		// Token: 0x04009B0B RID: 39691
		public const int AffixsFieldNumber = 3;

		// Token: 0x04009B0C RID: 39692
		private static readonly FieldCodec<int> _repeated_affixs_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009B0D RID: 39693
		private readonly RepeatedField<int> affixs_ = new RepeatedField<int>();

		// Token: 0x04009B0E RID: 39694
		public const int EvolvesFieldNumber = 4;

		// Token: 0x04009B0F RID: 39695
		private static readonly FieldCodec<int> _repeated_evolves_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009B10 RID: 39696
		private readonly RepeatedField<int> evolves_ = new RepeatedField<int>();

		// Token: 0x04009B11 RID: 39697
		public const int KillMonsterCountFieldNumber = 5;

		// Token: 0x04009B12 RID: 39698
		private int killMonsterCount_;

		// Token: 0x04009B13 RID: 39699
		public const int WeaponBondIdFieldNumber = 6;

		// Token: 0x04009B14 RID: 39700
		private int weaponBondId_;
	}
}
