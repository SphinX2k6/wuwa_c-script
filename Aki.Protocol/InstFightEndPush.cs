using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000811 RID: 2065
	[NetMessage(EMessageId.InstFightEndPush)]
	public sealed class InstFightEndPush : IMessage<InstFightEndPush>, IMessage, IEquatable<InstFightEndPush>, IDeepCloneable<InstFightEndPush>, IBufferMessage
	{
		// Token: 0x0600B8E8 RID: 47336 RVA: 0x001B8770 File Offset: 0x001B6970
		[NullableContext(1)]
		public static InstFightEndPush Create()
		{
			return new InstFightEndPush();
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x0600B8E9 RID: 47337 RVA: 0x001B8777 File Offset: 0x001B6977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x0600B8EA RID: 47338 RVA: 0x001B877A File Offset: 0x001B697A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstFightEndPush.Descriptor;
			}
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x001B8781 File Offset: 0x001B6981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstFightEndPush()
		{
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x001B8794 File Offset: 0x001B6994
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

		// Token: 0x0600B8ED RID: 47341 RVA: 0x001B8854 File Offset: 0x001B6A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstFightEndPush Clone()
		{
			return new InstFightEndPush(this);
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x001B885C File Offset: 0x001B6A5C
		// (set) Token: 0x0600B8EF RID: 47343 RVA: 0x001B8864 File Offset: 0x001B6A64
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

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x001B886D File Offset: 0x001B6A6D
		// (set) Token: 0x0600B8F1 RID: 47345 RVA: 0x001B8875 File Offset: 0x001B6A75
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

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x001B8888 File Offset: 0x001B6A88
		// (set) Token: 0x0600B8F3 RID: 47347 RVA: 0x001B8890 File Offset: 0x001B6A90
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

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x001B8899 File Offset: 0x001B6A99
		// (set) Token: 0x0600B8F5 RID: 47349 RVA: 0x001B88A1 File Offset: 0x001B6AA1
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

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x001B88AA File Offset: 0x001B6AAA
		// (set) Token: 0x0600B8F7 RID: 47351 RVA: 0x001B88B2 File Offset: 0x001B6AB2
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

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x001B88BB File Offset: 0x001B6ABB
		// (set) Token: 0x0600B8F9 RID: 47353 RVA: 0x001B88C3 File Offset: 0x001B6AC3
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

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x001B88CC File Offset: 0x001B6ACC
		// (set) Token: 0x0600B8FB RID: 47355 RVA: 0x001B88D4 File Offset: 0x001B6AD4
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

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x001B88DD File Offset: 0x001B6ADD
		// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x001B88E5 File Offset: 0x001B6AE5
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

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x001B88EE File Offset: 0x001B6AEE
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x001B88F6 File Offset: 0x001B6AF6
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

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x001B88FF File Offset: 0x001B6AFF
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x001B8907 File Offset: 0x001B6B07
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

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x001B8910 File Offset: 0x001B6B10
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x001B8918 File Offset: 0x001B6B18
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

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x0600B904 RID: 47364 RVA: 0x001B8921 File Offset: 0x001B6B21
		// (set) Token: 0x0600B905 RID: 47365 RVA: 0x001B8929 File Offset: 0x001B6B29
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

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x001B8932 File Offset: 0x001B6B32
		// (set) Token: 0x0600B907 RID: 47367 RVA: 0x001B893A File Offset: 0x001B6B3A
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

		// Token: 0x0600B908 RID: 47368 RVA: 0x001B8943 File Offset: 0x001B6B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstFightEndPush);
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x001B8954 File Offset: 0x001B6B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstFightEndPush other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && !(this.FightId != other.FightId) && this.CostTime == other.CostTime && this.AccDamage == other.AccDamage && this.AccShieldDamage == other.AccShieldDamage && this.AccSelfDamage == other.AccSelfDamage && this.AccSkillHeal == other.AccSkillHeal && this.AccItemHeal == other.AccItemHeal && this.StopTimes == other.StopTimes && this.DamageMax == other.DamageMax && this.ComboMax == other.ComboMax && this.AccDodgaTimes == other.AccDodgaTimes && this.DodgeSuccTimes == other.DodgeSuccTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x001B8A54 File Offset: 0x001B6C54
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

		// Token: 0x0600B90B RID: 47371 RVA: 0x001B8BC1 File Offset: 0x001B6DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x001B8BCE File Offset: 0x001B6DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x001B8BD8 File Offset: 0x001B6DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccShieldDamage != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.AccShieldDamage);
			}
			if (this.DodgeSuccTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DodgeSuccTimes);
			}
			if (this.AccDamage != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.AccDamage);
			}
			if (this.DamageMax != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DamageMax);
			}
			if (this.FightId.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.FightId);
			}
			if (this.StopTimes != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.StopTimes);
			}
			if (this.AccSelfDamage != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.AccSelfDamage);
			}
			if (this.AccSkillHeal != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.AccSkillHeal);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ComboMax);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CostTime);
			}
			if (this.AccDodgaTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.AccDodgaTimes);
			}
			if (this.AccItemHeal != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.AccItemHeal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x001B8D6C File Offset: 0x001B6F6C
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

		// Token: 0x0600B90F RID: 47375 RVA: 0x001B8ED0 File Offset: 0x001B70D0
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

		// Token: 0x0600B910 RID: 47376 RVA: 0x001B9001 File Offset: 0x001B7201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x001B900C File Offset: 0x001B720C
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
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.AccShieldDamage = input.ReadInt64();
							continue;
						}
						if (num == 16U)
						{
							this.DodgeSuccTimes = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.AccDamage = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.DamageMax = input.ReadInt32();
							continue;
						}
						if (num == 58U)
						{
							this.FightId = input.ReadString();
							continue;
						}
						if (num == 64U)
						{
							this.StopTimes = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.AccSelfDamage = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.AccSkillHeal = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.ComboMax = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CostTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.AccDodgaTimes = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.AccItemHeal = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051B2 RID: 20914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051B3 RID: 20915
		public const int InstIdFieldNumber = 11;

		// Token: 0x040051B4 RID: 20916
		private int instId_;

		// Token: 0x040051B5 RID: 20917
		public const int FightIdFieldNumber = 7;

		// Token: 0x040051B6 RID: 20918
		private string fightId_ = "";

		// Token: 0x040051B7 RID: 20919
		public const int CostTimeFieldNumber = 13;

		// Token: 0x040051B8 RID: 20920
		private int costTime_;

		// Token: 0x040051B9 RID: 20921
		public const int AccDamageFieldNumber = 3;

		// Token: 0x040051BA RID: 20922
		private long accDamage_;

		// Token: 0x040051BB RID: 20923
		public const int AccShieldDamageFieldNumber = 1;

		// Token: 0x040051BC RID: 20924
		private long accShieldDamage_;

		// Token: 0x040051BD RID: 20925
		public const int AccSelfDamageFieldNumber = 9;

		// Token: 0x040051BE RID: 20926
		private long accSelfDamage_;

		// Token: 0x040051BF RID: 20927
		public const int AccSkillHealFieldNumber = 10;

		// Token: 0x040051C0 RID: 20928
		private long accSkillHeal_;

		// Token: 0x040051C1 RID: 20929
		public const int AccItemHealFieldNumber = 15;

		// Token: 0x040051C2 RID: 20930
		private long accItemHeal_;

		// Token: 0x040051C3 RID: 20931
		public const int StopTimesFieldNumber = 8;

		// Token: 0x040051C4 RID: 20932
		private int stopTimes_;

		// Token: 0x040051C5 RID: 20933
		public const int DamageMaxFieldNumber = 5;

		// Token: 0x040051C6 RID: 20934
		private int damageMax_;

		// Token: 0x040051C7 RID: 20935
		public const int ComboMaxFieldNumber = 12;

		// Token: 0x040051C8 RID: 20936
		private int comboMax_;

		// Token: 0x040051C9 RID: 20937
		public const int AccDodgaTimesFieldNumber = 14;

		// Token: 0x040051CA RID: 20938
		private int accDodgaTimes_;

		// Token: 0x040051CB RID: 20939
		public const int DodgeSuccTimesFieldNumber = 2;

		// Token: 0x040051CC RID: 20940
		private int dodgeSuccTimes_;
	}
}
