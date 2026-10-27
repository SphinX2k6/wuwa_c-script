using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E64 RID: 3684
	public sealed class RacingBetsInstanceRoundAction : IMessage<RacingBetsInstanceRoundAction>, IMessage, IEquatable<RacingBetsInstanceRoundAction>, IDeepCloneable<RacingBetsInstanceRoundAction>, IBufferMessage
	{
		// Token: 0x06013C87 RID: 81031 RVA: 0x002E0A3D File Offset: 0x002DEC3D
		[NullableContext(1)]
		public static RacingBetsInstanceRoundAction Create()
		{
			return new RacingBetsInstanceRoundAction();
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x06013C88 RID: 81032 RVA: 0x002E0A44 File Offset: 0x002DEC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceRoundAction> Parser
		{
			get
			{
				return RacingBetsInstanceRoundAction._parser;
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x06013C89 RID: 81033 RVA: 0x002E0A4B File Offset: 0x002DEC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x06013C8A RID: 81034 RVA: 0x002E0A4E File Offset: 0x002DEC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceRoundAction.Descriptor;
			}
		}

		// Token: 0x06013C8B RID: 81035 RVA: 0x002E0A55 File Offset: 0x002DEC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction()
		{
		}

		// Token: 0x06013C8C RID: 81036 RVA: 0x002E0A68 File Offset: 0x002DEC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction(RacingBetsInstanceRoundAction other) : this()
		{
			this.actionIndex_ = other.actionIndex_;
			this.actionType_ = other.actionType_;
			this.bulletScreenTimes_ = other.bulletScreenTimes_.Clone();
			switch (other.DataCase)
			{
			case RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart:
				this.DungeonStart = other.DungeonStart.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.RoundStart:
				this.RoundStart = other.RoundStart.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.DangoStart:
				this.DangoStart = other.DangoStart.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo:
				this.DiceInfo = other.DiceInfo.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Move:
				this.Move = other.Move.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Skill:
				this.Skill = other.Skill.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh:
				this.ChangeHigh = other.ChangeHigh.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.CameraMove:
				this.CameraMove = other.CameraMove.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Destination:
				this.Destination = other.Destination.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank:
				this.UpdateRank = other.UpdateRank.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Transmit:
				this.Transmit = other.Transmit.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect:
				this.OrganEffect = other.OrganEffect.Clone();
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit:
				this.BlackHoleTransmit = other.BlackHoleTransmit.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C8D RID: 81037 RVA: 0x002E0C08 File Offset: 0x002DEE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction Clone()
		{
			return new RacingBetsInstanceRoundAction(this);
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x06013C8E RID: 81038 RVA: 0x002E0C10 File Offset: 0x002DEE10
		// (set) Token: 0x06013C8F RID: 81039 RVA: 0x002E0C18 File Offset: 0x002DEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionIndex
		{
			get
			{
				return this.actionIndex_;
			}
			set
			{
				this.actionIndex_ = value;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x06013C90 RID: 81040 RVA: 0x002E0C21 File Offset: 0x002DEE21
		// (set) Token: 0x06013C91 RID: 81041 RVA: 0x002E0C29 File Offset: 0x002DEE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundActionType ActionType
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

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x06013C92 RID: 81042 RVA: 0x002E0C32 File Offset: 0x002DEE32
		// (set) Token: 0x06013C93 RID: 81043 RVA: 0x002E0C4A File Offset: 0x002DEE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart DungeonStart
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart)
				{
					return null;
				}
				return (RacingBetsDungeonStart)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart);
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x06013C94 RID: 81044 RVA: 0x002E0C60 File Offset: 0x002DEE60
		// (set) Token: 0x06013C95 RID: 81045 RVA: 0x002E0C78 File Offset: 0x002DEE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart RoundStart
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.RoundStart)
				{
					return null;
				}
				return (RacingBetsRoundStart)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.RoundStart);
			}
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x06013C96 RID: 81046 RVA: 0x002E0C8E File Offset: 0x002DEE8E
		// (set) Token: 0x06013C97 RID: 81047 RVA: 0x002E0CA6 File Offset: 0x002DEEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart DangoStart
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.DangoStart)
				{
					return null;
				}
				return (RacingBetsDangoRoundStart)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.DangoStart);
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x06013C98 RID: 81048 RVA: 0x002E0CBC File Offset: 0x002DEEBC
		// (set) Token: 0x06013C99 RID: 81049 RVA: 0x002E0CD4 File Offset: 0x002DEED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo DiceInfo
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo)
				{
					return null;
				}
				return (RacingBetsDiceInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo);
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x06013C9A RID: 81050 RVA: 0x002E0CEA File Offset: 0x002DEEEA
		// (set) Token: 0x06013C9B RID: 81051 RVA: 0x002E0D02 File Offset: 0x002DEF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionMove Move
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.Move)
				{
					return null;
				}
				return (RacingBetsDangoActionMove)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.Move);
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x06013C9C RID: 81052 RVA: 0x002E0D18 File Offset: 0x002DEF18
		// (set) Token: 0x06013C9D RID: 81053 RVA: 0x002E0D30 File Offset: 0x002DEF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill Skill
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.Skill)
				{
					return null;
				}
				return (RacingBetsDangoActionSkill)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.Skill);
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x06013C9E RID: 81054 RVA: 0x002E0D46 File Offset: 0x002DEF46
		// (set) Token: 0x06013C9F RID: 81055 RVA: 0x002E0D5F File Offset: 0x002DEF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh ChangeHigh
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh)
				{
					return null;
				}
				return (RacingBetsDangoActionChangeHigh)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh);
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x06013CA0 RID: 81056 RVA: 0x002E0D76 File Offset: 0x002DEF76
		// (set) Token: 0x06013CA1 RID: 81057 RVA: 0x002E0D8F File Offset: 0x002DEF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove CameraMove
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.CameraMove)
				{
					return null;
				}
				return (RacingBetsDangoCameraMove)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.CameraMove);
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x06013CA2 RID: 81058 RVA: 0x002E0DA6 File Offset: 0x002DEFA6
		// (set) Token: 0x06013CA3 RID: 81059 RVA: 0x002E0DBF File Offset: 0x002DEFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDestination Destination
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.Destination)
				{
					return null;
				}
				return (RacingBetsDestination)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.Destination);
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x06013CA4 RID: 81060 RVA: 0x002E0DD6 File Offset: 0x002DEFD6
		// (set) Token: 0x06013CA5 RID: 81061 RVA: 0x002E0DEF File Offset: 0x002DEFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank UpdateRank
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank)
				{
					return null;
				}
				return (RacingBetsUpdateRank)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank);
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x06013CA6 RID: 81062 RVA: 0x002E0E06 File Offset: 0x002DF006
		// (set) Token: 0x06013CA7 RID: 81063 RVA: 0x002E0E1F File Offset: 0x002DF01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit Transmit
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.Transmit)
				{
					return null;
				}
				return (RacingBetsDangoActionTransmit)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.Transmit);
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x06013CA8 RID: 81064 RVA: 0x002E0E36 File Offset: 0x002DF036
		// (set) Token: 0x06013CA9 RID: 81065 RVA: 0x002E0E4F File Offset: 0x002DF04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect OrganEffect
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect)
				{
					return null;
				}
				return (RacingBetsOrganEffect)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect);
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x06013CAA RID: 81066 RVA: 0x002E0E66 File Offset: 0x002DF066
		// (set) Token: 0x06013CAB RID: 81067 RVA: 0x002E0E7F File Offset: 0x002DF07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit BlackHoleTransmit
		{
			get
			{
				if (this.dataCase_ != RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit)
				{
					return null;
				}
				return (RacingBetsDangoActionBlackHoleTransmit)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RacingBetsInstanceRoundAction.DataOneofCase.None : RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit);
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x06013CAC RID: 81068 RVA: 0x002E0E96 File Offset: 0x002DF096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BulletScreenTimes> BulletScreenTimes
		{
			get
			{
				return this.bulletScreenTimes_;
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x06013CAD RID: 81069 RVA: 0x002E0E9E File Offset: 0x002DF09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06013CAE RID: 81070 RVA: 0x002E0EA6 File Offset: 0x002DF0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RacingBetsInstanceRoundAction.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06013CAF RID: 81071 RVA: 0x002E0EB6 File Offset: 0x002DF0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceRoundAction);
		}

		// Token: 0x06013CB0 RID: 81072 RVA: 0x002E0EC4 File Offset: 0x002DF0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceRoundAction other)
		{
			return other != null && (other == this || (this.ActionIndex == other.ActionIndex && this.ActionType == other.ActionType && object.Equals(this.DungeonStart, other.DungeonStart) && object.Equals(this.RoundStart, other.RoundStart) && object.Equals(this.DangoStart, other.DangoStart) && object.Equals(this.DiceInfo, other.DiceInfo) && object.Equals(this.Move, other.Move) && object.Equals(this.Skill, other.Skill) && object.Equals(this.ChangeHigh, other.ChangeHigh) && object.Equals(this.CameraMove, other.CameraMove) && object.Equals(this.Destination, other.Destination) && object.Equals(this.UpdateRank, other.UpdateRank) && object.Equals(this.Transmit, other.Transmit) && object.Equals(this.OrganEffect, other.OrganEffect) && object.Equals(this.BlackHoleTransmit, other.BlackHoleTransmit) && this.bulletScreenTimes_.Equals(other.bulletScreenTimes_) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CB1 RID: 81073 RVA: 0x002E1044 File Offset: 0x002DF244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionIndex != 0)
			{
				num ^= this.ActionIndex.GetHashCode();
			}
			if (this.ActionType != RacingBetsRoundActionType.MatchStart)
			{
				num ^= this.ActionType.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart)
			{
				num ^= this.DungeonStart.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.RoundStart)
			{
				num ^= this.RoundStart.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DangoStart)
			{
				num ^= this.DangoStart.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo)
			{
				num ^= this.DiceInfo.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Move)
			{
				num ^= this.Move.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Skill)
			{
				num ^= this.Skill.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh)
			{
				num ^= this.ChangeHigh.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.CameraMove)
			{
				num ^= this.CameraMove.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Destination)
			{
				num ^= this.Destination.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank)
			{
				num ^= this.UpdateRank.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Transmit)
			{
				num ^= this.Transmit.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect)
			{
				num ^= this.OrganEffect.GetHashCode();
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit)
			{
				num ^= this.BlackHoleTransmit.GetHashCode();
			}
			num ^= this.bulletScreenTimes_.GetHashCode();
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CB2 RID: 81074 RVA: 0x002E11EB File Offset: 0x002DF3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CB3 RID: 81075 RVA: 0x002E11F8 File Offset: 0x002DF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CB4 RID: 81076 RVA: 0x002E1204 File Offset: 0x002DF404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActionIndex);
			}
			if (this.ActionType != RacingBetsRoundActionType.MatchStart)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ActionType);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DungeonStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.RoundStart)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RoundStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DangoStart)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DangoStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.DiceInfo);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Move)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Move);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Skill)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Skill);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ChangeHigh);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.CameraMove)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CameraMove);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Destination)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Destination);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UpdateRank);
			}
			this.bulletScreenTimes_.WriteTo(ref output, RacingBetsInstanceRoundAction._repeated_bulletScreenTimes_codec);
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Transmit)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Transmit);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.OrganEffect);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.BlackHoleTransmit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CB5 RID: 81077 RVA: 0x002E13F4 File Offset: 0x002DF5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionIndex);
			}
			if (this.ActionType != RacingBetsRoundActionType.MatchStart)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActionType);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DungeonStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.RoundStart)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoundStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DangoStart)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DangoStart);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DiceInfo);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Move)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Move);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Skill)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Skill);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangeHigh);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.CameraMove)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraMove);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Destination)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Destination);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateRank);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Transmit)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transmit);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OrganEffect);
			}
			if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BlackHoleTransmit);
			}
			num += this.bulletScreenTimes_.CalculateSize(RacingBetsInstanceRoundAction._repeated_bulletScreenTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013CB6 RID: 81078 RVA: 0x002E15AC File Offset: 0x002DF7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsInstanceRoundAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionIndex != 0)
			{
				this.ActionIndex = other.ActionIndex;
			}
			if (other.ActionType != RacingBetsRoundActionType.MatchStart)
			{
				this.ActionType = other.ActionType;
			}
			this.bulletScreenTimes_.Add(other.bulletScreenTimes_);
			switch (other.DataCase)
			{
			case RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart:
				if (this.DungeonStart == null)
				{
					this.DungeonStart = new RacingBetsDungeonStart();
				}
				this.DungeonStart.MergeFrom(other.DungeonStart);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.RoundStart:
				if (this.RoundStart == null)
				{
					this.RoundStart = new RacingBetsRoundStart();
				}
				this.RoundStart.MergeFrom(other.RoundStart);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.DangoStart:
				if (this.DangoStart == null)
				{
					this.DangoStart = new RacingBetsDangoRoundStart();
				}
				this.DangoStart.MergeFrom(other.DangoStart);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo:
				if (this.DiceInfo == null)
				{
					this.DiceInfo = new RacingBetsDiceInfo();
				}
				this.DiceInfo.MergeFrom(other.DiceInfo);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Move:
				if (this.Move == null)
				{
					this.Move = new RacingBetsDangoActionMove();
				}
				this.Move.MergeFrom(other.Move);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Skill:
				if (this.Skill == null)
				{
					this.Skill = new RacingBetsDangoActionSkill();
				}
				this.Skill.MergeFrom(other.Skill);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh:
				if (this.ChangeHigh == null)
				{
					this.ChangeHigh = new RacingBetsDangoActionChangeHigh();
				}
				this.ChangeHigh.MergeFrom(other.ChangeHigh);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.CameraMove:
				if (this.CameraMove == null)
				{
					this.CameraMove = new RacingBetsDangoCameraMove();
				}
				this.CameraMove.MergeFrom(other.CameraMove);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Destination:
				if (this.Destination == null)
				{
					this.Destination = new RacingBetsDestination();
				}
				this.Destination.MergeFrom(other.Destination);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank:
				if (this.UpdateRank == null)
				{
					this.UpdateRank = new RacingBetsUpdateRank();
				}
				this.UpdateRank.MergeFrom(other.UpdateRank);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.Transmit:
				if (this.Transmit == null)
				{
					this.Transmit = new RacingBetsDangoActionTransmit();
				}
				this.Transmit.MergeFrom(other.Transmit);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect:
				if (this.OrganEffect == null)
				{
					this.OrganEffect = new RacingBetsOrganEffect();
				}
				this.OrganEffect.MergeFrom(other.OrganEffect);
				break;
			case RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit:
				if (this.BlackHoleTransmit == null)
				{
					this.BlackHoleTransmit = new RacingBetsDangoActionBlackHoleTransmit();
				}
				this.BlackHoleTransmit.MergeFrom(other.BlackHoleTransmit);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CB7 RID: 81079 RVA: 0x002E1860 File Offset: 0x002DFA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CB8 RID: 81080 RVA: 0x002E186C File Offset: 0x002DFA6C
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
				if (num <= 66U)
				{
					if (num <= 34U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.ActionIndex = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.ActionType = (RacingBetsRoundActionType)input.ReadEnum();
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								RacingBetsDungeonStart racingBetsDungeonStart = new RacingBetsDungeonStart();
								if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DungeonStart)
								{
									racingBetsDungeonStart.MergeFrom(this.DungeonStart);
								}
								input.ReadMessage(racingBetsDungeonStart);
								this.DungeonStart = racingBetsDungeonStart;
								continue;
							}
							if (num == 34U)
							{
								RacingBetsRoundStart racingBetsRoundStart = new RacingBetsRoundStart();
								if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.RoundStart)
								{
									racingBetsRoundStart.MergeFrom(this.RoundStart);
								}
								input.ReadMessage(racingBetsRoundStart);
								this.RoundStart = racingBetsRoundStart;
								continue;
							}
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							RacingBetsDangoRoundStart racingBetsDangoRoundStart = new RacingBetsDangoRoundStart();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DangoStart)
							{
								racingBetsDangoRoundStart.MergeFrom(this.DangoStart);
							}
							input.ReadMessage(racingBetsDangoRoundStart);
							this.DangoStart = racingBetsDangoRoundStart;
							continue;
						}
						if (num == 50U)
						{
							RacingBetsDiceInfo racingBetsDiceInfo = new RacingBetsDiceInfo();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.DiceInfo)
							{
								racingBetsDiceInfo.MergeFrom(this.DiceInfo);
							}
							input.ReadMessage(racingBetsDiceInfo);
							this.DiceInfo = racingBetsDiceInfo;
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							RacingBetsDangoActionMove racingBetsDangoActionMove = new RacingBetsDangoActionMove();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Move)
							{
								racingBetsDangoActionMove.MergeFrom(this.Move);
							}
							input.ReadMessage(racingBetsDangoActionMove);
							this.Move = racingBetsDangoActionMove;
							continue;
						}
						if (num == 66U)
						{
							RacingBetsDangoActionSkill racingBetsDangoActionSkill = new RacingBetsDangoActionSkill();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Skill)
							{
								racingBetsDangoActionSkill.MergeFrom(this.Skill);
							}
							input.ReadMessage(racingBetsDangoActionSkill);
							this.Skill = racingBetsDangoActionSkill;
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 82U)
					{
						if (num == 74U)
						{
							RacingBetsDangoActionChangeHigh racingBetsDangoActionChangeHigh = new RacingBetsDangoActionChangeHigh();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.ChangeHigh)
							{
								racingBetsDangoActionChangeHigh.MergeFrom(this.ChangeHigh);
							}
							input.ReadMessage(racingBetsDangoActionChangeHigh);
							this.ChangeHigh = racingBetsDangoActionChangeHigh;
							continue;
						}
						if (num == 82U)
						{
							RacingBetsDangoCameraMove racingBetsDangoCameraMove = new RacingBetsDangoCameraMove();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.CameraMove)
							{
								racingBetsDangoCameraMove.MergeFrom(this.CameraMove);
							}
							input.ReadMessage(racingBetsDangoCameraMove);
							this.CameraMove = racingBetsDangoCameraMove;
							continue;
						}
					}
					else
					{
						if (num == 90U)
						{
							RacingBetsDestination racingBetsDestination = new RacingBetsDestination();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Destination)
							{
								racingBetsDestination.MergeFrom(this.Destination);
							}
							input.ReadMessage(racingBetsDestination);
							this.Destination = racingBetsDestination;
							continue;
						}
						if (num == 98U)
						{
							RacingBetsUpdateRank racingBetsUpdateRank = new RacingBetsUpdateRank();
							if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.UpdateRank)
							{
								racingBetsUpdateRank.MergeFrom(this.UpdateRank);
							}
							input.ReadMessage(racingBetsUpdateRank);
							this.UpdateRank = racingBetsUpdateRank;
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 106U)
					{
						this.bulletScreenTimes_.AddEntriesFrom(ref input, RacingBetsInstanceRoundAction._repeated_bulletScreenTimes_codec);
						continue;
					}
					if (num == 114U)
					{
						RacingBetsDangoActionTransmit racingBetsDangoActionTransmit = new RacingBetsDangoActionTransmit();
						if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.Transmit)
						{
							racingBetsDangoActionTransmit.MergeFrom(this.Transmit);
						}
						input.ReadMessage(racingBetsDangoActionTransmit);
						this.Transmit = racingBetsDangoActionTransmit;
						continue;
					}
				}
				else
				{
					if (num == 122U)
					{
						RacingBetsOrganEffect racingBetsOrganEffect = new RacingBetsOrganEffect();
						if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.OrganEffect)
						{
							racingBetsOrganEffect.MergeFrom(this.OrganEffect);
						}
						input.ReadMessage(racingBetsOrganEffect);
						this.OrganEffect = racingBetsOrganEffect;
						continue;
					}
					if (num == 130U)
					{
						RacingBetsDangoActionBlackHoleTransmit racingBetsDangoActionBlackHoleTransmit = new RacingBetsDangoActionBlackHoleTransmit();
						if (this.dataCase_ == RacingBetsInstanceRoundAction.DataOneofCase.BlackHoleTransmit)
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

		// Token: 0x040078FD RID: 30973
		private static readonly MessageParser<RacingBetsInstanceRoundAction> _parser = new MessageParser<RacingBetsInstanceRoundAction>(() => new RacingBetsInstanceRoundAction());

		// Token: 0x040078FE RID: 30974
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078FF RID: 30975
		public const int ActionIndexFieldNumber = 1;

		// Token: 0x04007900 RID: 30976
		private int actionIndex_;

		// Token: 0x04007901 RID: 30977
		public const int ActionTypeFieldNumber = 2;

		// Token: 0x04007902 RID: 30978
		private RacingBetsRoundActionType actionType_;

		// Token: 0x04007903 RID: 30979
		public const int DungeonStartFieldNumber = 3;

		// Token: 0x04007904 RID: 30980
		public const int RoundStartFieldNumber = 4;

		// Token: 0x04007905 RID: 30981
		public const int DangoStartFieldNumber = 5;

		// Token: 0x04007906 RID: 30982
		public const int DiceInfoFieldNumber = 6;

		// Token: 0x04007907 RID: 30983
		public const int MoveFieldNumber = 7;

		// Token: 0x04007908 RID: 30984
		public const int SkillFieldNumber = 8;

		// Token: 0x04007909 RID: 30985
		public const int ChangeHighFieldNumber = 9;

		// Token: 0x0400790A RID: 30986
		public const int CameraMoveFieldNumber = 10;

		// Token: 0x0400790B RID: 30987
		public const int DestinationFieldNumber = 11;

		// Token: 0x0400790C RID: 30988
		public const int UpdateRankFieldNumber = 12;

		// Token: 0x0400790D RID: 30989
		public const int TransmitFieldNumber = 14;

		// Token: 0x0400790E RID: 30990
		public const int OrganEffectFieldNumber = 15;

		// Token: 0x0400790F RID: 30991
		public const int BlackHoleTransmitFieldNumber = 16;

		// Token: 0x04007910 RID: 30992
		public const int BulletScreenTimesFieldNumber = 13;

		// Token: 0x04007911 RID: 30993
		private static readonly FieldCodec<BulletScreenTimes> _repeated_bulletScreenTimes_codec = FieldCodec.ForMessage<BulletScreenTimes>(106U, Aki.Protocol.BulletScreenTimes.Parser);

		// Token: 0x04007912 RID: 30994
		private readonly RepeatedField<BulletScreenTimes> bulletScreenTimes_ = new RepeatedField<BulletScreenTimes>();

		// Token: 0x04007913 RID: 30995
		private object data_;

		// Token: 0x04007914 RID: 30996
		private RacingBetsInstanceRoundAction.DataOneofCase dataCase_;

		// Token: 0x020018FF RID: 6399
		public enum DataOneofCase
		{
			// Token: 0x0400C920 RID: 51488
			None,
			// Token: 0x0400C921 RID: 51489
			DungeonStart = 3,
			// Token: 0x0400C922 RID: 51490
			RoundStart,
			// Token: 0x0400C923 RID: 51491
			DangoStart,
			// Token: 0x0400C924 RID: 51492
			DiceInfo,
			// Token: 0x0400C925 RID: 51493
			Move,
			// Token: 0x0400C926 RID: 51494
			Skill,
			// Token: 0x0400C927 RID: 51495
			ChangeHigh,
			// Token: 0x0400C928 RID: 51496
			CameraMove,
			// Token: 0x0400C929 RID: 51497
			Destination,
			// Token: 0x0400C92A RID: 51498
			UpdateRank,
			// Token: 0x0400C92B RID: 51499
			Transmit = 14,
			// Token: 0x0400C92C RID: 51500
			OrganEffect,
			// Token: 0x0400C92D RID: 51501
			BlackHoleTransmit
		}
	}
}
