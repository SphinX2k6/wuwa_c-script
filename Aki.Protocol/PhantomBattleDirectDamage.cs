using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7D RID: 3197
	public sealed class PhantomBattleDirectDamage : IMessage<PhantomBattleDirectDamage>, IMessage, IEquatable<PhantomBattleDirectDamage>, IDeepCloneable<PhantomBattleDirectDamage>, IBufferMessage
	{
		// Token: 0x0601153A RID: 70970 RVA: 0x00289607 File Offset: 0x00287807
		[NullableContext(1)]
		public static PhantomBattleDirectDamage Create()
		{
			return new PhantomBattleDirectDamage();
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0601153B RID: 70971 RVA: 0x0028960E File Offset: 0x0028780E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0601153C RID: 70972 RVA: 0x00289611 File Offset: 0x00287811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDirectDamage.Descriptor;
			}
		}

		// Token: 0x0601153D RID: 70973 RVA: 0x00289618 File Offset: 0x00287818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage()
		{
		}

		// Token: 0x0601153E RID: 70974 RVA: 0x00289620 File Offset: 0x00287820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage(PhantomBattleDirectDamage other) : this()
		{
			this.targetIsPlayer_ = other.targetIsPlayer_;
			this.damage_ = other.damage_;
			this.cardFighterUid_ = other.cardFighterUid_;
			this.finalHp_ = other.finalHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601153F RID: 70975 RVA: 0x00289674 File Offset: 0x00287874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage Clone()
		{
			return new PhantomBattleDirectDamage(this);
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x06011540 RID: 70976 RVA: 0x0028967C File Offset: 0x0028787C
		// (set) Token: 0x06011541 RID: 70977 RVA: 0x00289684 File Offset: 0x00287884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TargetIsPlayer
		{
			get
			{
				return this.targetIsPlayer_;
			}
			set
			{
				this.targetIsPlayer_ = value;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x06011542 RID: 70978 RVA: 0x0028968D File Offset: 0x0028788D
		// (set) Token: 0x06011543 RID: 70979 RVA: 0x00289695 File Offset: 0x00287895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x06011544 RID: 70980 RVA: 0x0028969E File Offset: 0x0028789E
		// (set) Token: 0x06011545 RID: 70981 RVA: 0x002896A6 File Offset: 0x002878A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardFighterUid
		{
			get
			{
				return this.cardFighterUid_;
			}
			set
			{
				this.cardFighterUid_ = value;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x06011546 RID: 70982 RVA: 0x002896AF File Offset: 0x002878AF
		// (set) Token: 0x06011547 RID: 70983 RVA: 0x002896B7 File Offset: 0x002878B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinalHp
		{
			get
			{
				return this.finalHp_;
			}
			set
			{
				this.finalHp_ = value;
			}
		}

		// Token: 0x06011548 RID: 70984 RVA: 0x002896C0 File Offset: 0x002878C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDirectDamage);
		}

		// Token: 0x06011549 RID: 70985 RVA: 0x002896D0 File Offset: 0x002878D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDirectDamage other)
		{
			return other != null && (other == this || (this.TargetIsPlayer == other.TargetIsPlayer && this.Damage == other.Damage && this.CardFighterUid == other.CardFighterUid && this.FinalHp == other.FinalHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601154A RID: 70986 RVA: 0x0028973C File Offset: 0x0028793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetIsPlayer)
			{
				num ^= this.TargetIsPlayer.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.CardFighterUid != 0)
			{
				num ^= this.CardFighterUid.GetHashCode();
			}
			if (this.FinalHp != 0)
			{
				num ^= this.FinalHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601154B RID: 70987 RVA: 0x002897C6 File Offset: 0x002879C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601154C RID: 70988 RVA: 0x002897D3 File Offset: 0x002879D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601154D RID: 70989 RVA: 0x002897DC File Offset: 0x002879DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetIsPlayer)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.TargetIsPlayer);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Damage);
			}
			if (this.CardFighterUid != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardFighterUid);
			}
			if (this.FinalHp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FinalHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601154E RID: 70990 RVA: 0x0028986C File Offset: 0x00287A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetIsPlayer)
			{
				num += 2;
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.CardFighterUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardFighterUid);
			}
			if (this.FinalHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinalHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601154F RID: 70991 RVA: 0x002898E8 File Offset: 0x00287AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDirectDamage other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetIsPlayer)
			{
				this.TargetIsPlayer = other.TargetIsPlayer;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.CardFighterUid != 0)
			{
				this.CardFighterUid = other.CardFighterUid;
			}
			if (other.FinalHp != 0)
			{
				this.FinalHp = other.FinalHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011550 RID: 70992 RVA: 0x00289960 File Offset: 0x00287B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011551 RID: 70993 RVA: 0x0028996C File Offset: 0x00287B6C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TargetIsPlayer = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CardFighterUid = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FinalHp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D83 RID: 28035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D84 RID: 28036
		public const int TargetIsPlayerFieldNumber = 1;

		// Token: 0x04006D85 RID: 28037
		private bool targetIsPlayer_;

		// Token: 0x04006D86 RID: 28038
		public const int DamageFieldNumber = 2;

		// Token: 0x04006D87 RID: 28039
		private int damage_;

		// Token: 0x04006D88 RID: 28040
		public const int CardFighterUidFieldNumber = 3;

		// Token: 0x04006D89 RID: 28041
		private int cardFighterUid_;

		// Token: 0x04006D8A RID: 28042
		public const int FinalHpFieldNumber = 4;

		// Token: 0x04006D8B RID: 28043
		private int finalHp_;
	}
}
