using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E51 RID: 3665
	public sealed class RacingBetsInstanceDangoAction : IMessage<RacingBetsInstanceDangoAction>, IMessage, IEquatable<RacingBetsInstanceDangoAction>, IDeepCloneable<RacingBetsInstanceDangoAction>, IBufferMessage
	{
		// Token: 0x06013B48 RID: 80712 RVA: 0x002DDFFC File Offset: 0x002DC1FC
		[NullableContext(1)]
		public static RacingBetsInstanceDangoAction Create()
		{
			return new RacingBetsInstanceDangoAction();
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06013B49 RID: 80713 RVA: 0x002DE003 File Offset: 0x002DC203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoAction> Parser
		{
			get
			{
				return RacingBetsInstanceDangoAction._parser;
			}
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06013B4A RID: 80714 RVA: 0x002DE00A File Offset: 0x002DC20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06013B4B RID: 80715 RVA: 0x002DE00D File Offset: 0x002DC20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoAction.Descriptor;
			}
		}

		// Token: 0x06013B4C RID: 80716 RVA: 0x002DE014 File Offset: 0x002DC214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction()
		{
		}

		// Token: 0x06013B4D RID: 80717 RVA: 0x002DE028 File Offset: 0x002DC228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction(RacingBetsInstanceDangoAction other) : this()
		{
			this.actionType_ = other.actionType_;
			this.index_ = other.index_;
			this.bulletScreenTimes_ = other.bulletScreenTimes_.Clone();
			switch (other.DataCase)
			{
			case RacingBetsInstanceDangoAction.DataOneofCase.Move:
				this.Move = other.Move.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Dice:
				this.Dice = other.Dice.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Skill:
				this.Skill = other.Skill.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh:
				this.ChangeHigh = other.ChangeHigh.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Transmit:
				this.Transmit = other.Transmit.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect:
				this.OrganEffect = other.OrganEffect.Clone();
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit:
				this.BlackHoleTransmit = other.BlackHoleTransmit.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B4E RID: 80718 RVA: 0x002DE130 File Offset: 0x002DC330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction Clone()
		{
			return new RacingBetsInstanceDangoAction(this);
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06013B4F RID: 80719 RVA: 0x002DE138 File Offset: 0x002DC338
		// (set) Token: 0x06013B50 RID: 80720 RVA: 0x002DE140 File Offset: 0x002DC340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionType ActionType
		{
			get
			{
				return this.actionType_;
			}
			set
			{
				this.actionType_ = value;
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06013B51 RID: 80721 RVA: 0x002DE149 File Offset: 0x002DC349
		// (set) Token: 0x06013B52 RID: 80722 RVA: 0x002DE161 File Offset: 0x002DC361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove Move
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.Move)
				{
					return null;
				}
				return (RacingBetsDangoActionMove)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.Move);
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06013B53 RID: 80723 RVA: 0x002DE177 File Offset: 0x002DC377
		// (set) Token: 0x06013B54 RID: 80724 RVA: 0x002DE18F File Offset: 0x002DC38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice Dice
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.Dice)
				{
					return null;
				}
				return (RacingBetsDangoActionDice)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.Dice);
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x06013B55 RID: 80725 RVA: 0x002DE1A5 File Offset: 0x002DC3A5
		// (set) Token: 0x06013B56 RID: 80726 RVA: 0x002DE1BD File Offset: 0x002DC3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill Skill
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.Skill)
				{
					return null;
				}
				return (RacingBetsDangoActionSkill)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.Skill);
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x06013B57 RID: 80727 RVA: 0x002DE1D3 File Offset: 0x002DC3D3
		// (set) Token: 0x06013B58 RID: 80728 RVA: 0x002DE1EB File Offset: 0x002DC3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh ChangeHigh
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh)
				{
					return null;
				}
				return (RacingBetsDangoActionChangeHigh)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh);
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x06013B59 RID: 80729 RVA: 0x002DE201 File Offset: 0x002DC401
		// (set) Token: 0x06013B5A RID: 80730 RVA: 0x002DE219 File Offset: 0x002DC419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit Transmit
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.Transmit)
				{
					return null;
				}
				return (RacingBetsDangoActionTransmit)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.Transmit);
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x06013B5B RID: 80731 RVA: 0x002DE22F File Offset: 0x002DC42F
		// (set) Token: 0x06013B5C RID: 80732 RVA: 0x002DE248 File Offset: 0x002DC448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect OrganEffect
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect)
				{
					return null;
				}
				return (RacingBetsOrganEffect)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect);
			}
		}

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x06013B5D RID: 80733 RVA: 0x002DE25F File Offset: 0x002DC45F
		// (set) Token: 0x06013B5E RID: 80734 RVA: 0x002DE278 File Offset: 0x002DC478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit BlackHoleTransmit
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit)
				{
					return null;
				}
				return (RacingBetsDangoActionBlackHoleTransmit)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceDangoAction.DataOneofCase.None : RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit);
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x06013B5F RID: 80735 RVA: 0x002DE28F File Offset: 0x002DC48F
		// (set) Token: 0x06013B60 RID: 80736 RVA: 0x002DE297 File Offset: 0x002DC497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x06013B61 RID: 80737 RVA: 0x002DE2A0 File Offset: 0x002DC4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BulletScreenTimes> BulletScreenTimes
		{
			get
			{
				return this.bulletScreenTimes_;
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x06013B62 RID: 80738 RVA: 0x002DE2A8 File Offset: 0x002DC4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06013B63 RID: 80739 RVA: 0x002DE2B0 File Offset: 0x002DC4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RacingBetsInstanceDangoAction.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06013B64 RID: 80740 RVA: 0x002DE2C0 File Offset: 0x002DC4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoAction);
		}

		// Token: 0x06013B65 RID: 80741 RVA: 0x002DE2D0 File Offset: 0x002DC4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoAction other)
		{
			return other != null && (other == this || (this.ActionType == other.ActionType && object.Equals(this.Move, other.Move) && object.Equals(this.Dice, other.Dice) && object.Equals(this.Skill, other.Skill) && object.Equals(this.ChangeHigh, other.ChangeHigh) && object.Equals(this.Transmit, other.Transmit) && object.Equals(this.OrganEffect, other.OrganEffect) && object.Equals(this.BlackHoleTransmit, other.BlackHoleTransmit) && this.Index == other.Index && this.bulletScreenTimes_.Equals(other.bulletScreenTimes_) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B66 RID: 80742 RVA: 0x002DE3D4 File Offset: 0x002DC5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionType != RacingBetsDangoActionType.Move)
			{
				num ^= this.ActionType.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Move)
			{
				num ^= this.Move.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Dice)
			{
				num ^= this.Dice.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Skill)
			{
				num ^= this.Skill.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh)
			{
				num ^= this.ChangeHigh.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Transmit)
			{
				num ^= this.Transmit.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect)
			{
				num ^= this.OrganEffect.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit)
			{
				num ^= this.BlackHoleTransmit.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.bulletScreenTimes_.GetHashCode();
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B67 RID: 80743 RVA: 0x002DE4EC File Offset: 0x002DC6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B68 RID: 80744 RVA: 0x002DE4F9 File Offset: 0x002DC6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B69 RID: 80745 RVA: 0x002DE504 File Offset: 0x002DC704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionType != RacingBetsDangoActionType.Move)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ActionType);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Move)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Move);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Dice)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Dice);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Skill)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Skill);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ChangeHigh);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			this.bulletScreenTimes_.WriteTo(ref output, RacingBetsInstanceDangoAction._repeated_bulletScreenTimes_codec);
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Transmit)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Transmit);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.OrganEffect);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.BlackHoleTransmit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B6A RID: 80746 RVA: 0x002DE63C File Offset: 0x002DC83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionType != RacingBetsDangoActionType.Move)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActionType);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Move)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Move);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Dice)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Dice);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Skill)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Skill);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangeHigh);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Transmit)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transmit);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OrganEffect);
			}
			if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackHoleTransmit);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.bulletScreenTimes_.CalculateSize(RacingBetsInstanceDangoAction._repeated_bulletScreenTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B6B RID: 80747 RVA: 0x002DE758 File Offset: 0x002DC958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsInstanceDangoAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionType != RacingBetsDangoActionType.Move)
			{
				this.ActionType = other.ActionType;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.bulletScreenTimes_.Add(other.bulletScreenTimes_);
			switch (other.DataCase)
			{
			case RacingBetsInstanceDangoAction.DataOneofCase.Move:
				if (this.Move == null)
				{
					this.Move = new RacingBetsDangoActionMove();
				}
				this.Move.MergeFrom(other.Move);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Dice:
				if (this.Dice == null)
				{
					this.Dice = new RacingBetsDangoActionDice();
				}
				this.Dice.MergeFrom(other.Dice);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Skill:
				if (this.Skill == null)
				{
					this.Skill = new RacingBetsDangoActionSkill();
				}
				this.Skill.MergeFrom(other.Skill);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh:
				if (this.ChangeHigh == null)
				{
					this.ChangeHigh = new RacingBetsDangoActionChangeHigh();
				}
				this.ChangeHigh.MergeFrom(other.ChangeHigh);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.Transmit:
				if (this.Transmit == null)
				{
					this.Transmit = new RacingBetsDangoActionTransmit();
				}
				this.Transmit.MergeFrom(other.Transmit);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect:
				if (this.OrganEffect == null)
				{
					this.OrganEffect = new RacingBetsOrganEffect();
				}
				this.OrganEffect.MergeFrom(other.OrganEffect);
				break;
			case RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit:
				if (this.BlackHoleTransmit == null)
				{
					this.BlackHoleTransmit = new RacingBetsDangoActionBlackHoleTransmit();
				}
				this.BlackHoleTransmit.MergeFrom(other.BlackHoleTransmit);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B6C RID: 80748 RVA: 0x002DE902 File Offset: 0x002DCB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B6D RID: 80749 RVA: 0x002DE90C File Offset: 0x002DCB0C
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
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.ActionType = (RacingBetsDangoActionType)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							RacingBetsDangoActionMove racingBetsDangoActionMove = new RacingBetsDangoActionMove();
							if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Move)
							{
								racingBetsDangoActionMove.MergeFrom(this.Move);
							}
							input.ReadMessage(racingBetsDangoActionMove);
							this.Move = racingBetsDangoActionMove;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							RacingBetsDangoActionDice racingBetsDangoActionDice = new RacingBetsDangoActionDice();
							if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Dice)
							{
								racingBetsDangoActionDice.MergeFrom(this.Dice);
							}
							input.ReadMessage(racingBetsDangoActionDice);
							this.Dice = racingBetsDangoActionDice;
							continue;
						}
						if (num == 34U)
						{
							RacingBetsDangoActionSkill racingBetsDangoActionSkill = new RacingBetsDangoActionSkill();
							if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Skill)
							{
								racingBetsDangoActionSkill.MergeFrom(this.Skill);
							}
							input.ReadMessage(racingBetsDangoActionSkill);
							this.Skill = racingBetsDangoActionSkill;
							continue;
						}
						if (num == 42U)
						{
							RacingBetsDangoActionChangeHigh racingBetsDangoActionChangeHigh = new RacingBetsDangoActionChangeHigh();
							if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.ChangeHigh)
							{
								racingBetsDangoActionChangeHigh.MergeFrom(this.ChangeHigh);
							}
							input.ReadMessage(racingBetsDangoActionChangeHigh);
							this.ChangeHigh = racingBetsDangoActionChangeHigh;
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.bulletScreenTimes_.AddEntriesFrom(ref input, RacingBetsInstanceDangoAction._repeated_bulletScreenTimes_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						RacingBetsDangoActionTransmit racingBetsDangoActionTransmit = new RacingBetsDangoActionTransmit();
						if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.Transmit)
						{
							racingBetsDangoActionTransmit.MergeFrom(this.Transmit);
						}
						input.ReadMessage(racingBetsDangoActionTransmit);
						this.Transmit = racingBetsDangoActionTransmit;
						continue;
					}
					if (num == 74U)
					{
						RacingBetsOrganEffect racingBetsOrganEffect = new RacingBetsOrganEffect();
						if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.OrganEffect)
						{
							racingBetsOrganEffect.MergeFrom(this.OrganEffect);
						}
						input.ReadMessage(racingBetsOrganEffect);
						this.OrganEffect = racingBetsOrganEffect;
						continue;
					}
					if (num == 82U)
					{
						RacingBetsDangoActionBlackHoleTransmit racingBetsDangoActionBlackHoleTransmit = new RacingBetsDangoActionBlackHoleTransmit();
						if (this.dataCase_ == RacingBetsInstanceDangoAction.DataOneofCase.BlackHoleTransmit)
						{
							racingBetsDangoActionBlackHoleTransmit.MergeFrom(this.BlackHoleTransmit);
						}
						input.ReadMessage(racingBetsDangoActionBlackHoleTransmit);
						this.BlackHoleTransmit = racingBetsDangoActionBlackHoleTransmit;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007900 RID: 30976
		private static readonly MessageParser<RacingBetsInstanceDangoAction> _parser = new MessageParser<RacingBetsInstanceDangoAction>(() => new RacingBetsInstanceDangoAction());

		// Token: 0x04007901 RID: 30977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007902 RID: 30978
		public const int ActionTypeFieldNumber = 1;

		// Token: 0x04007903 RID: 30979
		private RacingBetsDangoActionType actionType_;

		// Token: 0x04007904 RID: 30980
		public const int MoveFieldNumber = 2;

		// Token: 0x04007905 RID: 30981
		public const int DiceFieldNumber = 3;

		// Token: 0x04007906 RID: 30982
		public const int SkillFieldNumber = 4;

		// Token: 0x04007907 RID: 30983
		public const int ChangeHighFieldNumber = 5;

		// Token: 0x04007908 RID: 30984
		public const int TransmitFieldNumber = 8;

		// Token: 0x04007909 RID: 30985
		public const int OrganEffectFieldNumber = 9;

		// Token: 0x0400790A RID: 30986
		public const int BlackHoleTransmitFieldNumber = 10;

		// Token: 0x0400790B RID: 30987
		public const int IndexFieldNumber = 6;

		// Token: 0x0400790C RID: 30988
		private int index_;

		// Token: 0x0400790D RID: 30989
		public const int BulletScreenTimesFieldNumber = 7;

		// Token: 0x0400790E RID: 30990
		private static readonly FieldCodec<BulletScreenTimes> _repeated_bulletScreenTimes_codec = FieldCodec.ForMessage<BulletScreenTimes>(58U, Aki.Protocol.BulletScreenTimes.Parser);

		// Token: 0x0400790F RID: 30991
		private readonly RepeatedField<BulletScreenTimes> bulletScreenTimes_ = new RepeatedField<BulletScreenTimes>();

		// Token: 0x04007910 RID: 30992
		private object data_;

		// Token: 0x04007911 RID: 30993
		private RacingBetsInstanceDangoAction.DataOneofCase dataCase_;

		// Token: 0x02001973 RID: 6515
		public enum DataOneofCase
		{
			// Token: 0x0400CE3F RID: 52799
			None,
			// Token: 0x0400CE40 RID: 52800
			Move = 2,
			// Token: 0x0400CE41 RID: 52801
			Dice,
			// Token: 0x0400CE42 RID: 52802
			Skill,
			// Token: 0x0400CE43 RID: 52803
			ChangeHigh,
			// Token: 0x0400CE44 RID: 52804
			Transmit = 8,
			// Token: 0x0400CE45 RID: 52805
			OrganEffect,
			// Token: 0x0400CE46 RID: 52806
			BlackHoleTransmit
		}
	}
}
