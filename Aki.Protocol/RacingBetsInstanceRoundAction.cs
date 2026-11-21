using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E54 RID: 3668
	public sealed class RacingBetsInstanceRoundAction : IMessage<RacingBetsInstanceRoundAction>, IMessage, IEquatable<RacingBetsInstanceRoundAction>, IDeepCloneable<RacingBetsInstanceRoundAction>, IBufferMessage
	{
		// Token: 0x06013BA2 RID: 80802 RVA: 0x002DF381 File Offset: 0x002DD581
		[NullableContext(1)]
		public static RacingBetsInstanceRoundAction Create()
		{
			return new RacingBetsInstanceRoundAction();
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x06013BA3 RID: 80803 RVA: 0x002DF388 File Offset: 0x002DD588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceRoundAction> Parser
		{
			get
			{
				return RacingBetsInstanceRoundAction._parser;
			}
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x06013BA4 RID: 80804 RVA: 0x002DF38F File Offset: 0x002DD58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x06013BA5 RID: 80805 RVA: 0x002DF392 File Offset: 0x002DD592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceRoundAction.Descriptor;
			}
		}

		// Token: 0x06013BA6 RID: 80806 RVA: 0x002DF399 File Offset: 0x002DD599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction()
		{
		}

		// Token: 0x06013BA7 RID: 80807 RVA: 0x002DF3AC File Offset: 0x002DD5AC
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

		// Token: 0x06013BA8 RID: 80808 RVA: 0x002DF54C File Offset: 0x002DD74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction Clone()
		{
			return new RacingBetsInstanceRoundAction(this);
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x06013BA9 RID: 80809 RVA: 0x002DF554 File Offset: 0x002DD754
		// (set) Token: 0x06013BAA RID: 80810 RVA: 0x002DF55C File Offset: 0x002DD75C
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

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x06013BAB RID: 80811 RVA: 0x002DF565 File Offset: 0x002DD765
		// (set) Token: 0x06013BAC RID: 80812 RVA: 0x002DF56D File Offset: 0x002DD76D
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

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x06013BAD RID: 80813 RVA: 0x002DF576 File Offset: 0x002DD776
		// (set) Token: 0x06013BAE RID: 80814 RVA: 0x002DF58E File Offset: 0x002DD78E
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

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x06013BAF RID: 80815 RVA: 0x002DF5A4 File Offset: 0x002DD7A4
		// (set) Token: 0x06013BB0 RID: 80816 RVA: 0x002DF5BC File Offset: 0x002DD7BC
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

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x06013BB1 RID: 80817 RVA: 0x002DF5D2 File Offset: 0x002DD7D2
		// (set) Token: 0x06013BB2 RID: 80818 RVA: 0x002DF5EA File Offset: 0x002DD7EA
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

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x06013BB3 RID: 80819 RVA: 0x002DF600 File Offset: 0x002DD800
		// (set) Token: 0x06013BB4 RID: 80820 RVA: 0x002DF618 File Offset: 0x002DD818
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

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x06013BB5 RID: 80821 RVA: 0x002DF62E File Offset: 0x002DD82E
		// (set) Token: 0x06013BB6 RID: 80822 RVA: 0x002DF646 File Offset: 0x002DD846
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

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x06013BB7 RID: 80823 RVA: 0x002DF65C File Offset: 0x002DD85C
		// (set) Token: 0x06013BB8 RID: 80824 RVA: 0x002DF674 File Offset: 0x002DD874
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

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x06013BB9 RID: 80825 RVA: 0x002DF68A File Offset: 0x002DD88A
		// (set) Token: 0x06013BBA RID: 80826 RVA: 0x002DF6A3 File Offset: 0x002DD8A3
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

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x06013BBB RID: 80827 RVA: 0x002DF6BA File Offset: 0x002DD8BA
		// (set) Token: 0x06013BBC RID: 80828 RVA: 0x002DF6D3 File Offset: 0x002DD8D3
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

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x06013BBD RID: 80829 RVA: 0x002DF6EA File Offset: 0x002DD8EA
		// (set) Token: 0x06013BBE RID: 80830 RVA: 0x002DF703 File Offset: 0x002DD903
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

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x06013BBF RID: 80831 RVA: 0x002DF71A File Offset: 0x002DD91A
		// (set) Token: 0x06013BC0 RID: 80832 RVA: 0x002DF733 File Offset: 0x002DD933
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

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x06013BC1 RID: 80833 RVA: 0x002DF74A File Offset: 0x002DD94A
		// (set) Token: 0x06013BC2 RID: 80834 RVA: 0x002DF763 File Offset: 0x002DD963
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

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x06013BC3 RID: 80835 RVA: 0x002DF77A File Offset: 0x002DD97A
		// (set) Token: 0x06013BC4 RID: 80836 RVA: 0x002DF793 File Offset: 0x002DD993
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

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x06013BC5 RID: 80837 RVA: 0x002DF7AA File Offset: 0x002DD9AA
		// (set) Token: 0x06013BC6 RID: 80838 RVA: 0x002DF7C3 File Offset: 0x002DD9C3
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

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x06013BC7 RID: 80839 RVA: 0x002DF7DA File Offset: 0x002DD9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BulletScreenTimes> BulletScreenTimes
		{
			get
			{
				return this.bulletScreenTimes_;
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x06013BC8 RID: 80840 RVA: 0x002DF7E2 File Offset: 0x002DD9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceRoundAction.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06013BC9 RID: 80841 RVA: 0x002DF7EA File Offset: 0x002DD9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RacingBetsInstanceRoundAction.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06013BCA RID: 80842 RVA: 0x002DF7FA File Offset: 0x002DD9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceRoundAction);
		}

		// Token: 0x06013BCB RID: 80843 RVA: 0x002DF808 File Offset: 0x002DDA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceRoundAction other)
		{
			return other != null && (other == this || (this.ActionIndex == other.ActionIndex && this.ActionType == other.ActionType && object.Equals(this.DungeonStart, other.DungeonStart) && object.Equals(this.RoundStart, other.RoundStart) && object.Equals(this.DangoStart, other.DangoStart) && object.Equals(this.DiceInfo, other.DiceInfo) && object.Equals(this.Move, other.Move) && object.Equals(this.Skill, other.Skill) && object.Equals(this.ChangeHigh, other.ChangeHigh) && object.Equals(this.CameraMove, other.CameraMove) && object.Equals(this.Destination, other.Destination) && object.Equals(this.UpdateRank, other.UpdateRank) && object.Equals(this.Transmit, other.Transmit) && object.Equals(this.OrganEffect, other.OrganEffect) && object.Equals(this.BlackHoleTransmit, other.BlackHoleTransmit) && this.bulletScreenTimes_.Equals(other.bulletScreenTimes_) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BCC RID: 80844 RVA: 0x002DF988 File Offset: 0x002DDB88
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

		// Token: 0x06013BCD RID: 80845 RVA: 0x002DFB2F File Offset: 0x002DDD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BCE RID: 80846 RVA: 0x002DFB3C File Offset: 0x002DDD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BCF RID: 80847 RVA: 0x002DFB48 File Offset: 0x002DDD48
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

		// Token: 0x06013BD0 RID: 80848 RVA: 0x002DFD38 File Offset: 0x002DDF38
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

		// Token: 0x06013BD1 RID: 80849 RVA: 0x002DFEF0 File Offset: 0x002DE0F0
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

		// Token: 0x06013BD2 RID: 80850 RVA: 0x002E01A4 File Offset: 0x002DE3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BD3 RID: 80851 RVA: 0x002E01B0 File Offset: 0x002DE3B0
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

		// Token: 0x04007927 RID: 31015
		private static readonly MessageParser<RacingBetsInstanceRoundAction> _parser = new MessageParser<RacingBetsInstanceRoundAction>(() => new RacingBetsInstanceRoundAction());

		// Token: 0x04007928 RID: 31016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007929 RID: 31017
		public const int ActionIndexFieldNumber = 1;

		// Token: 0x0400792A RID: 31018
		private int actionIndex_;

		// Token: 0x0400792B RID: 31019
		public const int ActionTypeFieldNumber = 2;

		// Token: 0x0400792C RID: 31020
		private RacingBetsRoundActionType actionType_;

		// Token: 0x0400792D RID: 31021
		public const int DungeonStartFieldNumber = 3;

		// Token: 0x0400792E RID: 31022
		public const int RoundStartFieldNumber = 4;

		// Token: 0x0400792F RID: 31023
		public const int DangoStartFieldNumber = 5;

		// Token: 0x04007930 RID: 31024
		public const int DiceInfoFieldNumber = 6;

		// Token: 0x04007931 RID: 31025
		public const int MoveFieldNumber = 7;

		// Token: 0x04007932 RID: 31026
		public const int SkillFieldNumber = 8;

		// Token: 0x04007933 RID: 31027
		public const int ChangeHighFieldNumber = 9;

		// Token: 0x04007934 RID: 31028
		public const int CameraMoveFieldNumber = 10;

		// Token: 0x04007935 RID: 31029
		public const int DestinationFieldNumber = 11;

		// Token: 0x04007936 RID: 31030
		public const int UpdateRankFieldNumber = 12;

		// Token: 0x04007937 RID: 31031
		public const int TransmitFieldNumber = 14;

		// Token: 0x04007938 RID: 31032
		public const int OrganEffectFieldNumber = 15;

		// Token: 0x04007939 RID: 31033
		public const int BlackHoleTransmitFieldNumber = 16;

		// Token: 0x0400793A RID: 31034
		public const int BulletScreenTimesFieldNumber = 13;

		// Token: 0x0400793B RID: 31035
		private static readonly FieldCodec<BulletScreenTimes> _repeated_bulletScreenTimes_codec = FieldCodec.ForMessage<BulletScreenTimes>(106U, Aki.Protocol.BulletScreenTimes.Parser);

		// Token: 0x0400793C RID: 31036
		private readonly RepeatedField<BulletScreenTimes> bulletScreenTimes_ = new RepeatedField<BulletScreenTimes>();

		// Token: 0x0400793D RID: 31037
		private object data_;

		// Token: 0x0400793E RID: 31038
		private RacingBetsInstanceRoundAction.DataOneofCase dataCase_;

		// Token: 0x02001977 RID: 6519
		public enum DataOneofCase
		{
			// Token: 0x0400CE4B RID: 52811
			None,
			// Token: 0x0400CE4C RID: 52812
			DungeonStart = 3,
			// Token: 0x0400CE4D RID: 52813
			RoundStart,
			// Token: 0x0400CE4E RID: 52814
			DangoStart,
			// Token: 0x0400CE4F RID: 52815
			DiceInfo,
			// Token: 0x0400CE50 RID: 52816
			Move,
			// Token: 0x0400CE51 RID: 52817
			Skill,
			// Token: 0x0400CE52 RID: 52818
			ChangeHigh,
			// Token: 0x0400CE53 RID: 52819
			CameraMove,
			// Token: 0x0400CE54 RID: 52820
			Destination,
			// Token: 0x0400CE55 RID: 52821
			UpdateRank,
			// Token: 0x0400CE56 RID: 52822
			Transmit = 14,
			// Token: 0x0400CE57 RID: 52823
			OrganEffect,
			// Token: 0x0400CE58 RID: 52824
			BlackHoleTransmit
		}
	}
}
