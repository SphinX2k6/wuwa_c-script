using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000825 RID: 2085
	[NetMessage(EMessageId.InstFightEndPush)]
	public sealed class InstFightEndPush : IMessage<InstFightEndPush>, IMessage, IEquatable<InstFightEndPush>, IDeepCloneable<InstFightEndPush>, IBufferMessage
	{
		// Token: 0x0600BA3E RID: 47678 RVA: 0x001BB1AD File Offset: 0x001B93AD
		[NullableContext(1)]
		public static InstFightEndPush Create()
		{
			return new InstFightEndPush();
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x001BB1B4 File Offset: 0x001B93B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600BA40 RID: 47680 RVA: 0x001BB1B7 File Offset: 0x001B93B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstFightEndPush.Descriptor;
			}
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x001BB1BE File Offset: 0x001B93BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstFightEndPush()
		{
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x001BB1D4 File Offset: 0x001B93D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstFightEndPush(InstFightEndPush other) : this()
		{
			this.instId_ = other.instId_;
			this.fightId_ = other.fightId_;
			this.costTime_ = other.costTime_;
			this.accDamage_ = other.accDamage_;
			this.accShieldDamage_ = other.accShieldDamage_;
			this.accSelfDamage_ = other.accSelfDamage_;
			this.accSkillHeal_ = other.accSkillHeal_;
			this.accItemHeal_ = other.accItemHeal_;
			this.stopTimes_ = other.stopTimes_;
			this.damageMax_ = other.damageMax_;
			this.comboMax_ = other.comboMax_;
			this.accDodgaTimes_ = other.accDodgaTimes_;
			this.dodgeSuccTimes_ = other.dodgeSuccTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x001BB294 File Offset: 0x001B9494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstFightEndPush Clone()
		{
			return new InstFightEndPush(this);
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600BA44 RID: 47684 RVA: 0x001BB29C File Offset: 0x001B949C
		// (set) Token: 0x0600BA45 RID: 47685 RVA: 0x001BB2A4 File Offset: 0x001B94A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x001BB2AD File Offset: 0x001B94AD
		// (set) Token: 0x0600BA47 RID: 47687 RVA: 0x001BB2B5 File Offset: 0x001B94B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FightId
		{
			get
			{
				return this.fightId_;
			}
			set
			{
				this.fightId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600BA48 RID: 47688 RVA: 0x001BB2C8 File Offset: 0x001B94C8
		// (set) Token: 0x0600BA49 RID: 47689 RVA: 0x001BB2D0 File Offset: 0x001B94D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x001BB2D9 File Offset: 0x001B94D9
		// (set) Token: 0x0600BA4B RID: 47691 RVA: 0x001BB2E1 File Offset: 0x001B94E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccDamage
		{
			get
			{
				return this.accDamage_;
			}
			set
			{
				this.accDamage_ = value;
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600BA4C RID: 47692 RVA: 0x001BB2EA File Offset: 0x001B94EA
		// (set) Token: 0x0600BA4D RID: 47693 RVA: 0x001BB2F2 File Offset: 0x001B94F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccShieldDamage
		{
			get
			{
				return this.accShieldDamage_;
			}
			set
			{
				this.accShieldDamage_ = value;
			}
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x001BB2FB File Offset: 0x001B94FB
		// (set) Token: 0x0600BA4F RID: 47695 RVA: 0x001BB303 File Offset: 0x001B9503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccSelfDamage
		{
			get
			{
				return this.accSelfDamage_;
			}
			set
			{
				this.accSelfDamage_ = value;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x001BB30C File Offset: 0x001B950C
		// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x001BB314 File Offset: 0x001B9514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccSkillHeal
		{
			get
			{
				return this.accSkillHeal_;
			}
			set
			{
				this.accSkillHeal_ = value;
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x001BB31D File Offset: 0x001B951D
		// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x001BB325 File Offset: 0x001B9525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccItemHeal
		{
			get
			{
				return this.accItemHeal_;
			}
			set
			{
				this.accItemHeal_ = value;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x001BB32E File Offset: 0x001B952E
		// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x001BB336 File Offset: 0x001B9536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StopTimes
		{
			get
			{
				return this.stopTimes_;
			}
			set
			{
				this.stopTimes_ = value;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x001BB33F File Offset: 0x001B953F
		// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x001BB347 File Offset: 0x001B9547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DamageMax
		{
			get
			{
				return this.damageMax_;
			}
			set
			{
				this.damageMax_ = value;
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x001BB350 File Offset: 0x001B9550
		// (set) Token: 0x0600BA59 RID: 47705 RVA: 0x001BB358 File Offset: 0x001B9558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ComboMax
		{
			get
			{
				return this.comboMax_;
			}
			set
			{
				this.comboMax_ = value;
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x0600BA5A RID: 47706 RVA: 0x001BB361 File Offset: 0x001B9561
		// (set) Token: 0x0600BA5B RID: 47707 RVA: 0x001BB369 File Offset: 0x001B9569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccDodgaTimes
		{
			get
			{
				return this.accDodgaTimes_;
			}
			set
			{
				this.accDodgaTimes_ = value;
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x001BB372 File Offset: 0x001B9572
		// (set) Token: 0x0600BA5D RID: 47709 RVA: 0x001BB37A File Offset: 0x001B957A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DodgeSuccTimes
		{
			get
			{
				return this.dodgeSuccTimes_;
			}
			set
			{
				this.dodgeSuccTimes_ = value;
			}
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x001BB383 File Offset: 0x001B9583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstFightEndPush);
		}

		// Token: 0x0600BA5F RID: 47711 RVA: 0x001BB394 File Offset: 0x001B9594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstFightEndPush other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && !(this.FightId != other.FightId) && this.CostTime == other.CostTime && this.AccDamage == other.AccDamage && this.AccShieldDamage == other.AccShieldDamage && this.AccSelfDamage == other.AccSelfDamage && this.AccSkillHeal == other.AccSkillHeal && this.AccItemHeal == other.AccItemHeal && this.StopTimes == other.StopTimes && this.DamageMax == other.DamageMax && this.ComboMax == other.ComboMax && this.AccDodgaTimes == other.AccDodgaTimes && this.DodgeSuccTimes == other.DodgeSuccTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x001BB494 File Offset: 0x001B9694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.FightId.Length != 0)
			{
				num ^= this.FightId.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.AccDamage != 0L)
			{
				num ^= this.AccDamage.GetHashCode();
			}
			if (this.AccShieldDamage != 0L)
			{
				num ^= this.AccShieldDamage.GetHashCode();
			}
			if (this.AccSelfDamage != 0L)
			{
				num ^= this.AccSelfDamage.GetHashCode();
			}
			if (this.AccSkillHeal != 0L)
			{
				num ^= this.AccSkillHeal.GetHashCode();
			}
			if (this.AccItemHeal != 0L)
			{
				num ^= this.AccItemHeal.GetHashCode();
			}
			if (this.StopTimes != 0)
			{
				num ^= this.StopTimes.GetHashCode();
			}
			if (this.DamageMax != 0)
			{
				num ^= this.DamageMax.GetHashCode();
			}
			if (this.ComboMax != 0)
			{
				num ^= this.ComboMax.GetHashCode();
			}
			if (this.AccDodgaTimes != 0)
			{
				num ^= this.AccDodgaTimes.GetHashCode();
			}
			if (this.DodgeSuccTimes != 0)
			{
				num ^= this.DodgeSuccTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x001BB601 File Offset: 0x001B9801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x001BB60E File Offset: 0x001B980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x001BB618 File Offset: 0x001B9818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccSelfDamage != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.AccSelfDamage);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ComboMax);
			}
			if (this.FightId.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.FightId);
			}
			if (this.DodgeSuccTimes != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DodgeSuccTimes);
			}
			if (this.AccShieldDamage != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.AccShieldDamage);
			}
			if (this.AccSkillHeal != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AccSkillHeal);
			}
			if (this.AccItemHeal != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.AccItemHeal);
			}
			if (this.DamageMax != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DamageMax);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CostTime);
			}
			if (this.AccDodgaTimes != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AccDodgaTimes);
			}
			if (this.AccDamage != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.AccDamage);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this.StopTimes != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.StopTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x001BB7AC File Offset: 0x001B99AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.FightId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FightId);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			if (this.AccDamage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccDamage);
			}
			if (this.AccShieldDamage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccShieldDamage);
			}
			if (this.AccSelfDamage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccSelfDamage);
			}
			if (this.AccSkillHeal != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccSkillHeal);
			}
			if (this.AccItemHeal != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccItemHeal);
			}
			if (this.StopTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StopTimes);
			}
			if (this.DamageMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DamageMax);
			}
			if (this.ComboMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ComboMax);
			}
			if (this.AccDodgaTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccDodgaTimes);
			}
			if (this.DodgeSuccTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DodgeSuccTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x001BB910 File Offset: 0x001B9B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstFightEndPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.FightId.Length != 0)
			{
				this.FightId = other.FightId;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			if (other.AccDamage != 0L)
			{
				this.AccDamage = other.AccDamage;
			}
			if (other.AccShieldDamage != 0L)
			{
				this.AccShieldDamage = other.AccShieldDamage;
			}
			if (other.AccSelfDamage != 0L)
			{
				this.AccSelfDamage = other.AccSelfDamage;
			}
			if (other.AccSkillHeal != 0L)
			{
				this.AccSkillHeal = other.AccSkillHeal;
			}
			if (other.AccItemHeal != 0L)
			{
				this.AccItemHeal = other.AccItemHeal;
			}
			if (other.StopTimes != 0)
			{
				this.StopTimes = other.StopTimes;
			}
			if (other.DamageMax != 0)
			{
				this.DamageMax = other.DamageMax;
			}
			if (other.ComboMax != 0)
			{
				this.ComboMax = other.ComboMax;
			}
			if (other.AccDodgaTimes != 0)
			{
				this.AccDodgaTimes = other.AccDodgaTimes;
			}
			if (other.DodgeSuccTimes != 0)
			{
				this.DodgeSuccTimes = other.DodgeSuccTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x001BBA41 File Offset: 0x001B9C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x001BBA4C File Offset: 0x001B9C4C
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
				if (num <= 64U)
				{
					if (num <= 42U)
					{
						if (num == 16U)
						{
							this.AccSelfDamage = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.ComboMax = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.FightId = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.DodgeSuccTimes = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.AccShieldDamage = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.AccSkillHeal = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.AccItemHeal = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.DamageMax = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.CostTime = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.AccDodgaTimes = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.AccDamage = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.StopTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051B9 RID: 20921
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051BA RID: 20922
		public const int InstIdFieldNumber = 14;

		// Token: 0x040051BB RID: 20923
		private int instId_;

		// Token: 0x040051BC RID: 20924
		public const int FightIdFieldNumber = 5;

		// Token: 0x040051BD RID: 20925
		private string fightId_ = "";

		// Token: 0x040051BE RID: 20926
		public const int CostTimeFieldNumber = 11;

		// Token: 0x040051BF RID: 20927
		private int costTime_;

		// Token: 0x040051C0 RID: 20928
		public const int AccDamageFieldNumber = 13;

		// Token: 0x040051C1 RID: 20929
		private long accDamage_;

		// Token: 0x040051C2 RID: 20930
		public const int AccShieldDamageFieldNumber = 7;

		// Token: 0x040051C3 RID: 20931
		private long accShieldDamage_;

		// Token: 0x040051C4 RID: 20932
		public const int AccSelfDamageFieldNumber = 2;

		// Token: 0x040051C5 RID: 20933
		private long accSelfDamage_;

		// Token: 0x040051C6 RID: 20934
		public const int AccSkillHealFieldNumber = 8;

		// Token: 0x040051C7 RID: 20935
		private long accSkillHeal_;

		// Token: 0x040051C8 RID: 20936
		public const int AccItemHealFieldNumber = 9;

		// Token: 0x040051C9 RID: 20937
		private long accItemHeal_;

		// Token: 0x040051CA RID: 20938
		public const int StopTimesFieldNumber = 15;

		// Token: 0x040051CB RID: 20939
		private int stopTimes_;

		// Token: 0x040051CC RID: 20940
		public const int DamageMaxFieldNumber = 10;

		// Token: 0x040051CD RID: 20941
		private int damageMax_;

		// Token: 0x040051CE RID: 20942
		public const int ComboMaxFieldNumber = 3;

		// Token: 0x040051CF RID: 20943
		private int comboMax_;

		// Token: 0x040051D0 RID: 20944
		public const int AccDodgaTimesFieldNumber = 12;

		// Token: 0x040051D1 RID: 20945
		private int accDodgaTimes_;

		// Token: 0x040051D2 RID: 20946
		public const int DodgeSuccTimesFieldNumber = 6;

		// Token: 0x040051D3 RID: 20947
		private int dodgeSuccTimes_;
	}
}
