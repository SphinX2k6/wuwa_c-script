using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001694 RID: 5780
	[NetMessage(EMessageId.DamageRecordNotify)]
	public sealed class DamageRecordNotify : IMessage<DamageRecordNotify>, IMessage, IEquatable<DamageRecordNotify>, IDeepCloneable<DamageRecordNotify>, IBufferMessage
	{
		// Token: 0x0601CF75 RID: 118645 RVA: 0x0043D53F File Offset: 0x0043B73F
		[NullableContext(1)]
		public static DamageRecordNotify Create()
		{
			return new DamageRecordNotify();
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x0601CF76 RID: 118646 RVA: 0x0043D546 File Offset: 0x0043B746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x0601CF77 RID: 118647 RVA: 0x0043D549 File Offset: 0x0043B749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageRecordNotify.Descriptor;
			}
		}

		// Token: 0x0601CF78 RID: 118648 RVA: 0x0043D550 File Offset: 0x0043B750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify()
		{
		}

		// Token: 0x0601CF79 RID: 118649 RVA: 0x0043D558 File Offset: 0x0043B758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify(DamageRecordNotify other) : this()
		{
			this.timestampMs_ = other.timestampMs_;
			this.damageConfId_ = other.damageConfId_;
			this.damageValue_ = other.damageValue_;
			this.skillId_ = other.skillId_;
			this.skillLevel_ = other.skillLevel_;
			this.bulletId_ = other.bulletId_;
			this.damageSourceType_ = other.damageSourceType_;
			this.isCritical_ = other.isCritical_;
			this.attacker_ = ((other.attacker_ != null) ? other.attacker_.Clone() : null);
			this.victim_ = ((other.victim_ != null) ? other.victim_.Clone() : null);
			this.damageCalculationDetails_ = ((other.damageCalculationDetails_ != null) ? other.damageCalculationDetails_.Clone() : null);
			this.isWeakness_ = other.isWeakness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF7A RID: 118650 RVA: 0x0043D63C File Offset: 0x0043B83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify Clone()
		{
			return new DamageRecordNotify(this);
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x0601CF7B RID: 118651 RVA: 0x0043D644 File Offset: 0x0043B844
		// (set) Token: 0x0601CF7C RID: 118652 RVA: 0x0043D64C File Offset: 0x0043B84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimestampMs
		{
			get
			{
				return this.timestampMs_;
			}
			set
			{
				this.timestampMs_ = value;
			}
		}

		// Token: 0x17006249 RID: 25161
		// (get) Token: 0x0601CF7D RID: 118653 RVA: 0x0043D655 File Offset: 0x0043B855
		// (set) Token: 0x0601CF7E RID: 118654 RVA: 0x0043D65D File Offset: 0x0043B85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DamageConfId
		{
			get
			{
				return this.damageConfId_;
			}
			set
			{
				this.damageConfId_ = value;
			}
		}

		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x0601CF7F RID: 118655 RVA: 0x0043D666 File Offset: 0x0043B866
		// (set) Token: 0x0601CF80 RID: 118656 RVA: 0x0043D66E File Offset: 0x0043B86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DamageValue
		{
			get
			{
				return this.damageValue_;
			}
			set
			{
				this.damageValue_ = value;
			}
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x0601CF81 RID: 118657 RVA: 0x0043D677 File Offset: 0x0043B877
		// (set) Token: 0x0601CF82 RID: 118658 RVA: 0x0043D67F File Offset: 0x0043B87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x0601CF83 RID: 118659 RVA: 0x0043D688 File Offset: 0x0043B888
		// (set) Token: 0x0601CF84 RID: 118660 RVA: 0x0043D690 File Offset: 0x0043B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillLevel
		{
			get
			{
				return this.skillLevel_;
			}
			set
			{
				this.skillLevel_ = value;
			}
		}

		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x0601CF85 RID: 118661 RVA: 0x0043D699 File Offset: 0x0043B899
		// (set) Token: 0x0601CF86 RID: 118662 RVA: 0x0043D6A1 File Offset: 0x0043B8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x0601CF87 RID: 118663 RVA: 0x0043D6AA File Offset: 0x0043B8AA
		// (set) Token: 0x0601CF88 RID: 118664 RVA: 0x0043D6B2 File Offset: 0x0043B8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageSourceType DamageSourceType
		{
			get
			{
				return this.damageSourceType_;
			}
			set
			{
				this.damageSourceType_ = value;
			}
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x0601CF89 RID: 118665 RVA: 0x0043D6BB File Offset: 0x0043B8BB
		// (set) Token: 0x0601CF8A RID: 118666 RVA: 0x0043D6C3 File Offset: 0x0043B8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCritical
		{
			get
			{
				return this.isCritical_;
			}
			set
			{
				this.isCritical_ = value;
			}
		}

		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x0601CF8B RID: 118667 RVA: 0x0043D6CC File Offset: 0x0043B8CC
		// (set) Token: 0x0601CF8C RID: 118668 RVA: 0x0043D6D4 File Offset: 0x0043B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity Attacker
		{
			get
			{
				return this.attacker_;
			}
			set
			{
				this.attacker_ = value;
			}
		}

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x0601CF8D RID: 118669 RVA: 0x0043D6DD File Offset: 0x0043B8DD
		// (set) Token: 0x0601CF8E RID: 118670 RVA: 0x0043D6E5 File Offset: 0x0043B8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity Victim
		{
			get
			{
				return this.victim_;
			}
			set
			{
				this.victim_ = value;
			}
		}

		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x0601CF8F RID: 118671 RVA: 0x0043D6EE File Offset: 0x0043B8EE
		// (set) Token: 0x0601CF90 RID: 118672 RVA: 0x0043D6F6 File Offset: 0x0043B8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails DamageCalculationDetails
		{
			get
			{
				return this.damageCalculationDetails_;
			}
			set
			{
				this.damageCalculationDetails_ = value;
			}
		}

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x0601CF91 RID: 118673 RVA: 0x0043D6FF File Offset: 0x0043B8FF
		// (set) Token: 0x0601CF92 RID: 118674 RVA: 0x0043D707 File Offset: 0x0043B907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWeakness
		{
			get
			{
				return this.isWeakness_;
			}
			set
			{
				this.isWeakness_ = value;
			}
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x0043D710 File Offset: 0x0043B910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageRecordNotify);
		}

		// Token: 0x0601CF94 RID: 118676 RVA: 0x0043D720 File Offset: 0x0043B920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageRecordNotify other)
		{
			return other != null && (other == this || (this.TimestampMs == other.TimestampMs && this.DamageConfId == other.DamageConfId && this.DamageValue == other.DamageValue && this.SkillId == other.SkillId && this.SkillLevel == other.SkillLevel && this.BulletId == other.BulletId && this.DamageSourceType == other.DamageSourceType && this.IsCritical == other.IsCritical && object.Equals(this.Attacker, other.Attacker) && object.Equals(this.Victim, other.Victim) && object.Equals(this.DamageCalculationDetails, other.DamageCalculationDetails) && this.IsWeakness == other.IsWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF95 RID: 118677 RVA: 0x0043D818 File Offset: 0x0043BA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimestampMs != 0L)
			{
				num ^= this.TimestampMs.GetHashCode();
			}
			if (this.DamageConfId != 0L)
			{
				num ^= this.DamageConfId.GetHashCode();
			}
			if (this.DamageValue != 0)
			{
				num ^= this.DamageValue.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SkillLevel != 0)
			{
				num ^= this.SkillLevel.GetHashCode();
			}
			if (this.BulletId != 0L)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this.DamageSourceType != DamageSourceType.FromBullet)
			{
				num ^= this.DamageSourceType.GetHashCode();
			}
			if (this.IsCritical)
			{
				num ^= this.IsCritical.GetHashCode();
			}
			if (this.attacker_ != null)
			{
				num ^= this.Attacker.GetHashCode();
			}
			if (this.victim_ != null)
			{
				num ^= this.Victim.GetHashCode();
			}
			if (this.damageCalculationDetails_ != null)
			{
				num ^= this.DamageCalculationDetails.GetHashCode();
			}
			if (this.IsWeakness)
			{
				num ^= this.IsWeakness.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF96 RID: 118678 RVA: 0x0043D969 File Offset: 0x0043BB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF97 RID: 118679 RVA: 0x0043D976 File Offset: 0x0043BB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF98 RID: 118680 RVA: 0x0043D980 File Offset: 0x0043BB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.damageCalculationDetails_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DamageCalculationDetails);
			}
			if (this.IsWeakness)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsWeakness);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.DamageValue != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DamageValue);
			}
			if (this.IsCritical)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsCritical);
			}
			if (this.TimestampMs != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.TimestampMs);
			}
			if (this.victim_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Victim);
			}
			if (this.DamageSourceType != DamageSourceType.FromBullet)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.DamageSourceType);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BulletId);
			}
			if (this.attacker_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Attacker);
			}
			if (this.DamageConfId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.DamageConfId);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF99 RID: 118681 RVA: 0x0043DAF4 File Offset: 0x0043BCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimestampMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimestampMs);
			}
			if (this.DamageConfId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DamageConfId);
			}
			if (this.DamageValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DamageValue);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.SkillLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLevel);
			}
			if (this.BulletId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this.DamageSourceType != DamageSourceType.FromBullet)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DamageSourceType);
			}
			if (this.IsCritical)
			{
				num += 2;
			}
			if (this.attacker_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Attacker);
			}
			if (this.victim_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Victim);
			}
			if (this.damageCalculationDetails_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageCalculationDetails);
			}
			if (this.IsWeakness)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF9A RID: 118682 RVA: 0x0043DC24 File Offset: 0x0043BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimestampMs != 0L)
			{
				this.TimestampMs = other.TimestampMs;
			}
			if (other.DamageConfId != 0L)
			{
				this.DamageConfId = other.DamageConfId;
			}
			if (other.DamageValue != 0)
			{
				this.DamageValue = other.DamageValue;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SkillLevel != 0)
			{
				this.SkillLevel = other.SkillLevel;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			if (other.DamageSourceType != DamageSourceType.FromBullet)
			{
				this.DamageSourceType = other.DamageSourceType;
			}
			if (other.IsCritical)
			{
				this.IsCritical = other.IsCritical;
			}
			if (other.attacker_ != null)
			{
				if (this.attacker_ == null)
				{
					this.Attacker = new DamageRecordEntity();
				}
				this.Attacker.MergeFrom(other.Attacker);
			}
			if (other.victim_ != null)
			{
				if (this.victim_ == null)
				{
					this.Victim = new DamageRecordEntity();
				}
				this.Victim.MergeFrom(other.Victim);
			}
			if (other.damageCalculationDetails_ != null)
			{
				if (this.damageCalculationDetails_ == null)
				{
					this.DamageCalculationDetails = new DamageCalculationDetails();
				}
				this.DamageCalculationDetails.MergeFrom(other.DamageCalculationDetails);
			}
			if (other.IsWeakness)
			{
				this.IsWeakness = other.IsWeakness;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF9B RID: 118683 RVA: 0x0043DD84 File Offset: 0x0043BF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF9C RID: 118684 RVA: 0x0043DD90 File Offset: 0x0043BF90
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
				if (num <= 72U)
				{
					if (num <= 32U)
					{
						if (num == 18U)
						{
							if (this.damageCalculationDetails_ == null)
							{
								this.DamageCalculationDetails = new DamageCalculationDetails();
							}
							input.ReadMessage(this.DamageCalculationDetails);
							continue;
						}
						if (num == 24U)
						{
							this.IsWeakness = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.SkillLevel = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.DamageValue = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.IsCritical = input.ReadBool();
							continue;
						}
						if (num == 72U)
						{
							this.TimestampMs = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 82U)
					{
						if (this.victim_ == null)
						{
							this.Victim = new DamageRecordEntity();
						}
						input.ReadMessage(this.Victim);
						continue;
					}
					if (num == 88U)
					{
						this.DamageSourceType = (DamageSourceType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.attacker_ == null)
						{
							this.Attacker = new DamageRecordEntity();
						}
						input.ReadMessage(this.Attacker);
						continue;
					}
					if (num == 112U)
					{
						this.DamageConfId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C39D RID: 50077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C39E RID: 50078
		public const int TimestampMsFieldNumber = 9;

		// Token: 0x0400C39F RID: 50079
		private long timestampMs_;

		// Token: 0x0400C3A0 RID: 50080
		public const int DamageConfIdFieldNumber = 14;

		// Token: 0x0400C3A1 RID: 50081
		private long damageConfId_;

		// Token: 0x0400C3A2 RID: 50082
		public const int DamageValueFieldNumber = 7;

		// Token: 0x0400C3A3 RID: 50083
		private int damageValue_;

		// Token: 0x0400C3A4 RID: 50084
		public const int SkillIdFieldNumber = 15;

		// Token: 0x0400C3A5 RID: 50085
		private long skillId_;

		// Token: 0x0400C3A6 RID: 50086
		public const int SkillLevelFieldNumber = 4;

		// Token: 0x0400C3A7 RID: 50087
		private int skillLevel_;

		// Token: 0x0400C3A8 RID: 50088
		public const int BulletIdFieldNumber = 12;

		// Token: 0x0400C3A9 RID: 50089
		private long bulletId_;

		// Token: 0x0400C3AA RID: 50090
		public const int DamageSourceTypeFieldNumber = 11;

		// Token: 0x0400C3AB RID: 50091
		private DamageSourceType damageSourceType_;

		// Token: 0x0400C3AC RID: 50092
		public const int IsCriticalFieldNumber = 8;

		// Token: 0x0400C3AD RID: 50093
		private bool isCritical_;

		// Token: 0x0400C3AE RID: 50094
		public const int AttackerFieldNumber = 13;

		// Token: 0x0400C3AF RID: 50095
		private DamageRecordEntity attacker_;

		// Token: 0x0400C3B0 RID: 50096
		public const int VictimFieldNumber = 10;

		// Token: 0x0400C3B1 RID: 50097
		private DamageRecordEntity victim_;

		// Token: 0x0400C3B2 RID: 50098
		public const int DamageCalculationDetailsFieldNumber = 2;

		// Token: 0x0400C3B3 RID: 50099
		private DamageCalculationDetails damageCalculationDetails_;

		// Token: 0x0400C3B4 RID: 50100
		public const int IsWeaknessFieldNumber = 3;

		// Token: 0x0400C3B5 RID: 50101
		private bool isWeakness_;
	}
}
