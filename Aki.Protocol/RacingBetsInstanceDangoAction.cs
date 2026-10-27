using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E61 RID: 3681
	public sealed class RacingBetsInstanceDangoAction : IMessage<RacingBetsInstanceDangoAction>, IMessage, IEquatable<RacingBetsInstanceDangoAction>, IDeepCloneable<RacingBetsInstanceDangoAction>, IBufferMessage
	{
		// Token: 0x06013C2D RID: 80941 RVA: 0x002DF6B8 File Offset: 0x002DD8B8
		[NullableContext(1)]
		public static RacingBetsInstanceDangoAction Create()
		{
			return new RacingBetsInstanceDangoAction();
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x06013C2E RID: 80942 RVA: 0x002DF6BF File Offset: 0x002DD8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoAction> Parser
		{
			get
			{
				return RacingBetsInstanceDangoAction._parser;
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x06013C2F RID: 80943 RVA: 0x002DF6C6 File Offset: 0x002DD8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x06013C30 RID: 80944 RVA: 0x002DF6C9 File Offset: 0x002DD8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoAction.Descriptor;
			}
		}

		// Token: 0x06013C31 RID: 80945 RVA: 0x002DF6D0 File Offset: 0x002DD8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction()
		{
		}

		// Token: 0x06013C32 RID: 80946 RVA: 0x002DF6E4 File Offset: 0x002DD8E4
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

		// Token: 0x06013C33 RID: 80947 RVA: 0x002DF7EC File Offset: 0x002DD9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction Clone()
		{
			return new RacingBetsInstanceDangoAction(this);
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x06013C34 RID: 80948 RVA: 0x002DF7F4 File Offset: 0x002DD9F4
		// (set) Token: 0x06013C35 RID: 80949 RVA: 0x002DF7FC File Offset: 0x002DD9FC
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

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x06013C36 RID: 80950 RVA: 0x002DF805 File Offset: 0x002DDA05
		// (set) Token: 0x06013C37 RID: 80951 RVA: 0x002DF81D File Offset: 0x002DDA1D
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

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x06013C38 RID: 80952 RVA: 0x002DF833 File Offset: 0x002DDA33
		// (set) Token: 0x06013C39 RID: 80953 RVA: 0x002DF84B File Offset: 0x002DDA4B
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

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x06013C3A RID: 80954 RVA: 0x002DF861 File Offset: 0x002DDA61
		// (set) Token: 0x06013C3B RID: 80955 RVA: 0x002DF879 File Offset: 0x002DDA79
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

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x06013C3C RID: 80956 RVA: 0x002DF88F File Offset: 0x002DDA8F
		// (set) Token: 0x06013C3D RID: 80957 RVA: 0x002DF8A7 File Offset: 0x002DDAA7
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

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x06013C3E RID: 80958 RVA: 0x002DF8BD File Offset: 0x002DDABD
		// (set) Token: 0x06013C3F RID: 80959 RVA: 0x002DF8D5 File Offset: 0x002DDAD5
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

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x06013C40 RID: 80960 RVA: 0x002DF8EB File Offset: 0x002DDAEB
		// (set) Token: 0x06013C41 RID: 80961 RVA: 0x002DF904 File Offset: 0x002DDB04
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

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06013C42 RID: 80962 RVA: 0x002DF91B File Offset: 0x002DDB1B
		// (set) Token: 0x06013C43 RID: 80963 RVA: 0x002DF934 File Offset: 0x002DDB34
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

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x06013C44 RID: 80964 RVA: 0x002DF94B File Offset: 0x002DDB4B
		// (set) Token: 0x06013C45 RID: 80965 RVA: 0x002DF953 File Offset: 0x002DDB53
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

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x06013C46 RID: 80966 RVA: 0x002DF95C File Offset: 0x002DDB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BulletScreenTimes> BulletScreenTimes
		{
			get
			{
				return this.bulletScreenTimes_;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x06013C47 RID: 80967 RVA: 0x002DF964 File Offset: 0x002DDB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoAction.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06013C48 RID: 80968 RVA: 0x002DF96C File Offset: 0x002DDB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RacingBetsInstanceDangoAction.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06013C49 RID: 80969 RVA: 0x002DF97C File Offset: 0x002DDB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoAction);
		}

		// Token: 0x06013C4A RID: 80970 RVA: 0x002DF98C File Offset: 0x002DDB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoAction other)
		{
			return other != null && (other == this || (this.ActionType == other.ActionType && object.Equals(this.Move, other.Move) && object.Equals(this.Dice, other.Dice) && object.Equals(this.Skill, other.Skill) && object.Equals(this.ChangeHigh, other.ChangeHigh) && object.Equals(this.Transmit, other.Transmit) && object.Equals(this.OrganEffect, other.OrganEffect) && object.Equals(this.BlackHoleTransmit, other.BlackHoleTransmit) && this.Index == other.Index && this.bulletScreenTimes_.Equals(other.bulletScreenTimes_) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C4B RID: 80971 RVA: 0x002DFA90 File Offset: 0x002DDC90
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

		// Token: 0x06013C4C RID: 80972 RVA: 0x002DFBA8 File Offset: 0x002DDDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C4D RID: 80973 RVA: 0x002DFBB5 File Offset: 0x002DDDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C4E RID: 80974 RVA: 0x002DFBC0 File Offset: 0x002DDDC0
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

		// Token: 0x06013C4F RID: 80975 RVA: 0x002DFCF8 File Offset: 0x002DDEF8
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

		// Token: 0x06013C50 RID: 80976 RVA: 0x002DFE14 File Offset: 0x002DE014
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

		// Token: 0x06013C51 RID: 80977 RVA: 0x002DFFBE File Offset: 0x002DE1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C52 RID: 80978 RVA: 0x002DFFC8 File Offset: 0x002DE1C8
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

		// Token: 0x040078D6 RID: 30934
		private static readonly MessageParser<RacingBetsInstanceDangoAction> _parser = new MessageParser<RacingBetsInstanceDangoAction>(() => new RacingBetsInstanceDangoAction());

		// Token: 0x040078D7 RID: 30935
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078D8 RID: 30936
		public const int ActionTypeFieldNumber = 1;

		// Token: 0x040078D9 RID: 30937
		private RacingBetsDangoActionType actionType_;

		// Token: 0x040078DA RID: 30938
		public const int MoveFieldNumber = 2;

		// Token: 0x040078DB RID: 30939
		public const int DiceFieldNumber = 3;

		// Token: 0x040078DC RID: 30940
		public const int SkillFieldNumber = 4;

		// Token: 0x040078DD RID: 30941
		public const int ChangeHighFieldNumber = 5;

		// Token: 0x040078DE RID: 30942
		public const int TransmitFieldNumber = 8;

		// Token: 0x040078DF RID: 30943
		public const int OrganEffectFieldNumber = 9;

		// Token: 0x040078E0 RID: 30944
		public const int BlackHoleTransmitFieldNumber = 10;

		// Token: 0x040078E1 RID: 30945
		public const int IndexFieldNumber = 6;

		// Token: 0x040078E2 RID: 30946
		private int index_;

		// Token: 0x040078E3 RID: 30947
		public const int BulletScreenTimesFieldNumber = 7;

		// Token: 0x040078E4 RID: 30948
		private static readonly FieldCodec<BulletScreenTimes> _repeated_bulletScreenTimes_codec = FieldCodec.ForMessage<BulletScreenTimes>(58U, Aki.Protocol.BulletScreenTimes.Parser);

		// Token: 0x040078E5 RID: 30949
		private readonly RepeatedField<BulletScreenTimes> bulletScreenTimes_ = new RepeatedField<BulletScreenTimes>();

		// Token: 0x040078E6 RID: 30950
		private object data_;

		// Token: 0x040078E7 RID: 30951
		private RacingBetsInstanceDangoAction.DataOneofCase dataCase_;

		// Token: 0x020018FB RID: 6395
		public enum DataOneofCase
		{
			// Token: 0x0400C914 RID: 51476
			None,
			// Token: 0x0400C915 RID: 51477
			Move = 2,
			// Token: 0x0400C916 RID: 51478
			Dice,
			// Token: 0x0400C917 RID: 51479
			Skill,
			// Token: 0x0400C918 RID: 51480
			ChangeHigh,
			// Token: 0x0400C919 RID: 51481
			Transmit = 8,
			// Token: 0x0400C91A RID: 51482
			OrganEffect,
			// Token: 0x0400C91B RID: 51483
			BlackHoleTransmit
		}
	}
}
