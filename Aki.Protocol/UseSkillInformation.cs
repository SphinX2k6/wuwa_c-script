using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200152E RID: 5422
	public sealed class UseSkillInformation : IMessage<UseSkillInformation>, IMessage, IEquatable<UseSkillInformation>, IDeepCloneable<UseSkillInformation>, IBufferMessage
	{
		// Token: 0x0601CB84 RID: 117636 RVA: 0x00429523 File Offset: 0x00427723
		[NullableContext(1)]
		public static UseSkillInformation Create()
		{
			return new UseSkillInformation();
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x0601CB85 RID: 117637 RVA: 0x0042952A File Offset: 0x0042772A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x0601CB86 RID: 117638 RVA: 0x0042952D File Offset: 0x0042772D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseSkillInformation.Descriptor;
			}
		}

		// Token: 0x0601CB87 RID: 117639 RVA: 0x00429534 File Offset: 0x00427734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation()
		{
		}

		// Token: 0x0601CB88 RID: 117640 RVA: 0x0042953C File Offset: 0x0042773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation(UseSkillInformation other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.skillId_ = other.skillId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.targetId_ = other.targetId_;
			this.timeStamp_ = other.timeStamp_;
			this.isSpecialSkill_ = other.isSpecialSkill_;
			this.duration_ = other.duration_;
			this.skillInterruptLevel_ = other.skillInterruptLevel_;
			this.fightState_ = other.fightState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB89 RID: 117641 RVA: 0x00429614 File Offset: 0x00427814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation Clone()
		{
			return new UseSkillInformation(this);
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x0601CB8A RID: 117642 RVA: 0x0042961C File Offset: 0x0042781C
		// (set) Token: 0x0601CB8B RID: 117643 RVA: 0x00429624 File Offset: 0x00427824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x0601CB8C RID: 117644 RVA: 0x0042962D File Offset: 0x0042782D
		// (set) Token: 0x0601CB8D RID: 117645 RVA: 0x00429635 File Offset: 0x00427835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x0601CB8E RID: 117646 RVA: 0x0042963E File Offset: 0x0042783E
		// (set) Token: 0x0601CB8F RID: 117647 RVA: 0x00429646 File Offset: 0x00427846
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

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x0601CB90 RID: 117648 RVA: 0x0042964F File Offset: 0x0042784F
		// (set) Token: 0x0601CB91 RID: 117649 RVA: 0x00429657 File Offset: 0x00427857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation MovementInformation
		{
			get
			{
				return this.movementInformation_;
			}
			set
			{
				this.movementInformation_ = value;
			}
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x0601CB92 RID: 117650 RVA: 0x00429660 File Offset: 0x00427860
		// (set) Token: 0x0601CB93 RID: 117651 RVA: 0x00429668 File Offset: 0x00427868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x0601CB94 RID: 117652 RVA: 0x00429671 File Offset: 0x00427871
		// (set) Token: 0x0601CB95 RID: 117653 RVA: 0x00429679 File Offset: 0x00427879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x0601CB96 RID: 117654 RVA: 0x00429682 File Offset: 0x00427882
		// (set) Token: 0x0601CB97 RID: 117655 RVA: 0x0042968A File Offset: 0x0042788A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x0601CB98 RID: 117656 RVA: 0x00429693 File Offset: 0x00427893
		// (set) Token: 0x0601CB99 RID: 117657 RVA: 0x0042969B File Offset: 0x0042789B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSpecialSkill
		{
			get
			{
				return this.isSpecialSkill_;
			}
			set
			{
				this.isSpecialSkill_ = value;
			}
		}

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x0601CB9A RID: 117658 RVA: 0x004296A4 File Offset: 0x004278A4
		// (set) Token: 0x0601CB9B RID: 117659 RVA: 0x004296AC File Offset: 0x004278AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x0601CB9C RID: 117660 RVA: 0x004296B5 File Offset: 0x004278B5
		// (set) Token: 0x0601CB9D RID: 117661 RVA: 0x004296BD File Offset: 0x004278BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillInterruptLevel
		{
			get
			{
				return this.skillInterruptLevel_;
			}
			set
			{
				this.skillInterruptLevel_ = value;
			}
		}

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x0601CB9E RID: 117662 RVA: 0x004296C6 File Offset: 0x004278C6
		// (set) Token: 0x0601CB9F RID: 117663 RVA: 0x004296CE File Offset: 0x004278CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x0601CBA0 RID: 117664 RVA: 0x004296D7 File Offset: 0x004278D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseSkillInformation);
		}

		// Token: 0x0601CBA1 RID: 117665 RVA: 0x004296E8 File Offset: 0x004278E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseSkillInformation other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.SkillId == other.SkillId && object.Equals(this.MovementInformation, other.MovementInformation) && object.Equals(this.Location, other.Location) && this.TargetId == other.TargetId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.IsSpecialSkill == other.IsSpecialSkill && this.Duration == other.Duration && this.SkillInterruptLevel == other.SkillInterruptLevel && this.FightState == other.FightState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBA2 RID: 117666 RVA: 0x004297DC File Offset: 0x004279DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.movementInformation_ != null)
			{
				num ^= this.MovementInformation.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this.IsSpecialSkill)
			{
				num ^= this.IsSpecialSkill.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.SkillInterruptLevel != 0)
			{
				num ^= this.SkillInterruptLevel.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBA3 RID: 117667 RVA: 0x00429913 File Offset: 0x00427B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBA4 RID: 117668 RVA: 0x00429920 File Offset: 0x00427B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBA5 RID: 117669 RVA: 0x0042992C File Offset: 0x00427B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.movementInformation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MovementInformation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TargetId);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.IsSpecialSkill)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSpecialSkill);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Duration);
			}
			if (this.SkillInterruptLevel != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkillInterruptLevel);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FightState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBA6 RID: 117670 RVA: 0x00429A88 File Offset: 0x00427C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.movementInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovementInformation);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this.IsSpecialSkill)
			{
				num += 2;
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.SkillInterruptLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillInterruptLevel);
			}
			if (this.FightState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CBA7 RID: 117671 RVA: 0x00429BA4 File Offset: 0x00427DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseSkillInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.movementInformation_ != null)
			{
				if (this.movementInformation_ == null)
				{
					this.MovementInformation = new MovementInformation();
				}
				this.MovementInformation.MergeFrom(other.MovementInformation);
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			if (other.IsSpecialSkill)
			{
				this.IsSpecialSkill = other.IsSpecialSkill;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.SkillInterruptLevel != 0)
			{
				this.SkillInterruptLevel = other.SkillInterruptLevel;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBA8 RID: 117672 RVA: 0x00429CF5 File Offset: 0x00427EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBA9 RID: 117673 RVA: 0x00429D00 File Offset: 0x00427F00
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
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							if (this.movementInformation_ == null)
							{
								this.MovementInformation = new MovementInformation();
							}
							input.ReadMessage(this.MovementInformation);
							continue;
						}
						if (num == 42U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.TargetId = input.ReadInt64();
						continue;
					}
					if (num == 61U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 64U)
					{
						this.IsSpecialSkill = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SkillInterruptLevel = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A561 RID: 42337
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A562 RID: 42338
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400A563 RID: 42339
		private CombatCommon combatCommon_;

		// Token: 0x0400A564 RID: 42340
		public const int IdFieldNumber = 2;

		// Token: 0x0400A565 RID: 42341
		private long id_;

		// Token: 0x0400A566 RID: 42342
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400A567 RID: 42343
		private long skillId_;

		// Token: 0x0400A568 RID: 42344
		public const int MovementInformationFieldNumber = 4;

		// Token: 0x0400A569 RID: 42345
		private MovementInformation movementInformation_;

		// Token: 0x0400A56A RID: 42346
		public const int LocationFieldNumber = 5;

		// Token: 0x0400A56B RID: 42347
		private Vector location_;

		// Token: 0x0400A56C RID: 42348
		public const int TargetIdFieldNumber = 6;

		// Token: 0x0400A56D RID: 42349
		private long targetId_;

		// Token: 0x0400A56E RID: 42350
		public const int TimeStampFieldNumber = 7;

		// Token: 0x0400A56F RID: 42351
		private float timeStamp_;

		// Token: 0x0400A570 RID: 42352
		public const int IsSpecialSkillFieldNumber = 8;

		// Token: 0x0400A571 RID: 42353
		private bool isSpecialSkill_;

		// Token: 0x0400A572 RID: 42354
		public const int DurationFieldNumber = 9;

		// Token: 0x0400A573 RID: 42355
		private int duration_;

		// Token: 0x0400A574 RID: 42356
		public const int SkillInterruptLevelFieldNumber = 10;

		// Token: 0x0400A575 RID: 42357
		private int skillInterruptLevel_;

		// Token: 0x0400A576 RID: 42358
		public const int FightStateFieldNumber = 11;

		// Token: 0x0400A577 RID: 42359
		private int fightState_;
	}
}
