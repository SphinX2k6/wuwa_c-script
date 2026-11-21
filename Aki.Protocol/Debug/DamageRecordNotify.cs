using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001710 RID: 5904
	[NetMessage(EMessageId.DamageRecordNotify)]
	public sealed class DamageRecordNotify : IMessage<DamageRecordNotify>, IMessage, IEquatable<DamageRecordNotify>, IDeepCloneable<DamageRecordNotify>, IBufferMessage
	{
		// Token: 0x0601DA44 RID: 121412 RVA: 0x0045927B File Offset: 0x0045747B
		[NullableContext(1)]
		public static DamageRecordNotify Create()
		{
			return new DamageRecordNotify();
		}

		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x0601DA45 RID: 121413 RVA: 0x00459282 File Offset: 0x00457482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064EC RID: 25836
		// (get) Token: 0x0601DA46 RID: 121414 RVA: 0x00459285 File Offset: 0x00457485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageRecordNotify.Descriptor;
			}
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x0045928C File Offset: 0x0045748C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify()
		{
		}

		// Token: 0x0601DA48 RID: 121416 RVA: 0x00459294 File Offset: 0x00457494
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

		// Token: 0x0601DA49 RID: 121417 RVA: 0x00459378 File Offset: 0x00457578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordNotify Clone()
		{
			return new DamageRecordNotify(this);
		}

		// Token: 0x170064ED RID: 25837
		// (get) Token: 0x0601DA4A RID: 121418 RVA: 0x00459380 File Offset: 0x00457580
		// (set) Token: 0x0601DA4B RID: 121419 RVA: 0x00459388 File Offset: 0x00457588
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

		// Token: 0x170064EE RID: 25838
		// (get) Token: 0x0601DA4C RID: 121420 RVA: 0x00459391 File Offset: 0x00457591
		// (set) Token: 0x0601DA4D RID: 121421 RVA: 0x00459399 File Offset: 0x00457599
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

		// Token: 0x170064EF RID: 25839
		// (get) Token: 0x0601DA4E RID: 121422 RVA: 0x004593A2 File Offset: 0x004575A2
		// (set) Token: 0x0601DA4F RID: 121423 RVA: 0x004593AA File Offset: 0x004575AA
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

		// Token: 0x170064F0 RID: 25840
		// (get) Token: 0x0601DA50 RID: 121424 RVA: 0x004593B3 File Offset: 0x004575B3
		// (set) Token: 0x0601DA51 RID: 121425 RVA: 0x004593BB File Offset: 0x004575BB
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

		// Token: 0x170064F1 RID: 25841
		// (get) Token: 0x0601DA52 RID: 121426 RVA: 0x004593C4 File Offset: 0x004575C4
		// (set) Token: 0x0601DA53 RID: 121427 RVA: 0x004593CC File Offset: 0x004575CC
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

		// Token: 0x170064F2 RID: 25842
		// (get) Token: 0x0601DA54 RID: 121428 RVA: 0x004593D5 File Offset: 0x004575D5
		// (set) Token: 0x0601DA55 RID: 121429 RVA: 0x004593DD File Offset: 0x004575DD
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

		// Token: 0x170064F3 RID: 25843
		// (get) Token: 0x0601DA56 RID: 121430 RVA: 0x004593E6 File Offset: 0x004575E6
		// (set) Token: 0x0601DA57 RID: 121431 RVA: 0x004593EE File Offset: 0x004575EE
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

		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x0601DA58 RID: 121432 RVA: 0x004593F7 File Offset: 0x004575F7
		// (set) Token: 0x0601DA59 RID: 121433 RVA: 0x004593FF File Offset: 0x004575FF
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

		// Token: 0x170064F5 RID: 25845
		// (get) Token: 0x0601DA5A RID: 121434 RVA: 0x00459408 File Offset: 0x00457608
		// (set) Token: 0x0601DA5B RID: 121435 RVA: 0x00459410 File Offset: 0x00457610
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

		// Token: 0x170064F6 RID: 25846
		// (get) Token: 0x0601DA5C RID: 121436 RVA: 0x00459419 File Offset: 0x00457619
		// (set) Token: 0x0601DA5D RID: 121437 RVA: 0x00459421 File Offset: 0x00457621
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

		// Token: 0x170064F7 RID: 25847
		// (get) Token: 0x0601DA5E RID: 121438 RVA: 0x0045942A File Offset: 0x0045762A
		// (set) Token: 0x0601DA5F RID: 121439 RVA: 0x00459432 File Offset: 0x00457632
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

		// Token: 0x170064F8 RID: 25848
		// (get) Token: 0x0601DA60 RID: 121440 RVA: 0x0045943B File Offset: 0x0045763B
		// (set) Token: 0x0601DA61 RID: 121441 RVA: 0x00459443 File Offset: 0x00457643
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

		// Token: 0x0601DA62 RID: 121442 RVA: 0x0045944C File Offset: 0x0045764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageRecordNotify);
		}

		// Token: 0x0601DA63 RID: 121443 RVA: 0x0045945C File Offset: 0x0045765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageRecordNotify other)
		{
			return other != null && (other == this || (this.TimestampMs == other.TimestampMs && this.DamageConfId == other.DamageConfId && this.DamageValue == other.DamageValue && this.SkillId == other.SkillId && this.SkillLevel == other.SkillLevel && this.BulletId == other.BulletId && this.DamageSourceType == other.DamageSourceType && this.IsCritical == other.IsCritical && object.Equals(this.Attacker, other.Attacker) && object.Equals(this.Victim, other.Victim) && object.Equals(this.DamageCalculationDetails, other.DamageCalculationDetails) && this.IsWeakness == other.IsWeakness && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DA64 RID: 121444 RVA: 0x00459554 File Offset: 0x00457754
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

		// Token: 0x0601DA65 RID: 121445 RVA: 0x004596A5 File Offset: 0x004578A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DA66 RID: 121446 RVA: 0x004596B2 File Offset: 0x004578B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DA67 RID: 121447 RVA: 0x004596BC File Offset: 0x004578BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWeakness)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsWeakness);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.DamageSourceType != DamageSourceType.FromBullet)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.DamageSourceType);
			}
			if (this.DamageValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DamageValue);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.attacker_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Attacker);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BulletId);
			}
			if (this.damageCalculationDetails_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.DamageCalculationDetails);
			}
			if (this.victim_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Victim);
			}
			if (this.DamageConfId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.DamageConfId);
			}
			if (this.TimestampMs != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TimestampMs);
			}
			if (this.IsCritical)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsCritical);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DA68 RID: 121448 RVA: 0x00459830 File Offset: 0x00457A30
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

		// Token: 0x0601DA69 RID: 121449 RVA: 0x00459960 File Offset: 0x00457B60
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

		// Token: 0x0601DA6A RID: 121450 RVA: 0x00459AC0 File Offset: 0x00457CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DA6B RID: 121451 RVA: 0x00459ACC File Offset: 0x00457CCC
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
				if (num <= 58U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.IsWeakness = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
						if (num == 32U)
						{
							this.DamageSourceType = (DamageSourceType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.DamageValue = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.SkillLevel = input.ReadInt32();
							continue;
						}
						if (num == 58U)
						{
							if (this.attacker_ == null)
							{
								this.Attacker = new DamageRecordEntity();
							}
							input.ReadMessage(this.Attacker);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 64U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
					if (num == 82U)
					{
						if (this.damageCalculationDetails_ == null)
						{
							this.DamageCalculationDetails = new DamageCalculationDetails();
						}
						input.ReadMessage(this.DamageCalculationDetails);
						continue;
					}
					if (num == 90U)
					{
						if (this.victim_ == null)
						{
							this.Victim = new DamageRecordEntity();
						}
						input.ReadMessage(this.Victim);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.DamageConfId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.TimestampMs = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.IsCritical = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C8CC RID: 51404
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8CD RID: 51405
		public const int TimestampMsFieldNumber = 13;

		// Token: 0x0400C8CE RID: 51406
		private long timestampMs_;

		// Token: 0x0400C8CF RID: 51407
		public const int DamageConfIdFieldNumber = 12;

		// Token: 0x0400C8D0 RID: 51408
		private long damageConfId_;

		// Token: 0x0400C8D1 RID: 51409
		public const int DamageValueFieldNumber = 5;

		// Token: 0x0400C8D2 RID: 51410
		private int damageValue_;

		// Token: 0x0400C8D3 RID: 51411
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400C8D4 RID: 51412
		private long skillId_;

		// Token: 0x0400C8D5 RID: 51413
		public const int SkillLevelFieldNumber = 6;

		// Token: 0x0400C8D6 RID: 51414
		private int skillLevel_;

		// Token: 0x0400C8D7 RID: 51415
		public const int BulletIdFieldNumber = 8;

		// Token: 0x0400C8D8 RID: 51416
		private long bulletId_;

		// Token: 0x0400C8D9 RID: 51417
		public const int DamageSourceTypeFieldNumber = 4;

		// Token: 0x0400C8DA RID: 51418
		private DamageSourceType damageSourceType_;

		// Token: 0x0400C8DB RID: 51419
		public const int IsCriticalFieldNumber = 15;

		// Token: 0x0400C8DC RID: 51420
		private bool isCritical_;

		// Token: 0x0400C8DD RID: 51421
		public const int AttackerFieldNumber = 7;

		// Token: 0x0400C8DE RID: 51422
		private DamageRecordEntity attacker_;

		// Token: 0x0400C8DF RID: 51423
		public const int VictimFieldNumber = 11;

		// Token: 0x0400C8E0 RID: 51424
		private DamageRecordEntity victim_;

		// Token: 0x0400C8E1 RID: 51425
		public const int DamageCalculationDetailsFieldNumber = 10;

		// Token: 0x0400C8E2 RID: 51426
		private DamageCalculationDetails damageCalculationDetails_;

		// Token: 0x0400C8E3 RID: 51427
		public const int IsWeaknessFieldNumber = 2;

		// Token: 0x0400C8E4 RID: 51428
		private bool isWeakness_;
	}
}
