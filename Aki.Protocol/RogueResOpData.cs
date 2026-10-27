using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF9 RID: 4089
	public sealed class RogueResOpData : IMessage<RogueResOpData>, IMessage, IEquatable<RogueResOpData>, IDeepCloneable<RogueResOpData>, IBufferMessage
	{
		// Token: 0x06015DAC RID: 89516 RVA: 0x0032C869 File Offset: 0x0032AA69
		[NullableContext(1)]
		public static RogueResOpData Create()
		{
			return new RogueResOpData();
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06015DAD RID: 89517 RVA: 0x0032C870 File Offset: 0x0032AA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResOpData> Parser
		{
			get
			{
				return RogueResOpData._parser;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06015DAE RID: 89518 RVA: 0x0032C877 File Offset: 0x0032AA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06015DAF RID: 89519 RVA: 0x0032C87A File Offset: 0x0032AA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpData.Descriptor;
			}
		}

		// Token: 0x06015DB0 RID: 89520 RVA: 0x0032C881 File Offset: 0x0032AA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData()
		{
		}

		// Token: 0x06015DB1 RID: 89521 RVA: 0x0032C88C File Offset: 0x0032AA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData(RogueResOpData other) : this()
		{
			this.incId_ = other.incId_;
			this.rogueResOpType_ = other.rogueResOpType_;
			switch (other.DataCase)
			{
			case RogueResOpData.DataOneofCase.MoveOp:
				this.MoveOp = other.MoveOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.GridEventOp:
				this.GridEventOp = other.GridEventOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.SelectViewOp:
				this.SelectViewOp = other.SelectViewOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.ShowViewOp:
				this.ShowViewOp = other.ShowViewOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp:
				this.RogueGotoLevelPlayOp = other.RogueGotoLevelPlayOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp:
				this.RollBuffBondLinkIdOp = other.RollBuffBondLinkIdOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.FallbackView:
				this.FallbackView = other.FallbackView.Clone();
				break;
			case RogueResOpData.DataOneofCase.LightBlockByLocationOp:
				this.LightBlockByLocationOp = other.LightBlockByLocationOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.MapTeleportByLocationOp:
				this.MapTeleportByLocationOp = other.MapTeleportByLocationOp.Clone();
				break;
			case RogueResOpData.DataOneofCase.ChangeEventByPosOp:
				this.ChangeEventByPosOp = other.ChangeEventByPosOp.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DB2 RID: 89522 RVA: 0x0032C9D1 File Offset: 0x0032ABD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData Clone()
		{
			return new RogueResOpData(this);
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06015DB3 RID: 89523 RVA: 0x0032C9D9 File Offset: 0x0032ABD9
		// (set) Token: 0x06015DB4 RID: 89524 RVA: 0x0032C9E1 File Offset: 0x0032ABE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06015DB5 RID: 89525 RVA: 0x0032C9EA File Offset: 0x0032ABEA
		// (set) Token: 0x06015DB6 RID: 89526 RVA: 0x0032C9F2 File Offset: 0x0032ABF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpType RogueResOpType
		{
			get
			{
				return this.rogueResOpType_;
			}
			set
			{
				this.rogueResOpType_ = value;
			}
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x06015DB7 RID: 89527 RVA: 0x0032C9FB File Offset: 0x0032ABFB
		// (set) Token: 0x06015DB8 RID: 89528 RVA: 0x0032CA13 File Offset: 0x0032AC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp MoveOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.MoveOp)
				{
					return null;
				}
				return (MoveOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.MoveOp);
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x06015DB9 RID: 89529 RVA: 0x0032CA29 File Offset: 0x0032AC29
		// (set) Token: 0x06015DBA RID: 89530 RVA: 0x0032CA41 File Offset: 0x0032AC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridEventOp GridEventOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.GridEventOp)
				{
					return null;
				}
				return (GridEventOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.GridEventOp);
			}
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x06015DBB RID: 89531 RVA: 0x0032CA57 File Offset: 0x0032AC57
		// (set) Token: 0x06015DBC RID: 89532 RVA: 0x0032CA6F File Offset: 0x0032AC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectViewOp SelectViewOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.SelectViewOp)
				{
					return null;
				}
				return (SelectViewOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.SelectViewOp);
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x06015DBD RID: 89533 RVA: 0x0032CA85 File Offset: 0x0032AC85
		// (set) Token: 0x06015DBE RID: 89534 RVA: 0x0032CA9D File Offset: 0x0032AC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowViewOp ShowViewOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.ShowViewOp)
				{
					return null;
				}
				return (ShowViewOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.ShowViewOp);
			}
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x06015DBF RID: 89535 RVA: 0x0032CAB3 File Offset: 0x0032ACB3
		// (set) Token: 0x06015DC0 RID: 89536 RVA: 0x0032CACB File Offset: 0x0032ACCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGotoLevelPlayOp RogueGotoLevelPlayOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp)
				{
					return null;
				}
				return (RogueGotoLevelPlayOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp);
			}
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x06015DC1 RID: 89537 RVA: 0x0032CAE1 File Offset: 0x0032ACE1
		// (set) Token: 0x06015DC2 RID: 89538 RVA: 0x0032CAF9 File Offset: 0x0032ACF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBuffBondLinkIdOp RollBuffBondLinkIdOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp)
				{
					return null;
				}
				return (RollBuffBondLinkIdOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp);
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x06015DC3 RID: 89539 RVA: 0x0032CB0F File Offset: 0x0032AD0F
		// (set) Token: 0x06015DC4 RID: 89540 RVA: 0x0032CB28 File Offset: 0x0032AD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FallbackViewOp FallbackView
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.FallbackView)
				{
					return null;
				}
				return (FallbackViewOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.FallbackView);
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x06015DC5 RID: 89541 RVA: 0x0032CB3F File Offset: 0x0032AD3F
		// (set) Token: 0x06015DC6 RID: 89542 RVA: 0x0032CB58 File Offset: 0x0032AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp LightBlockByLocationOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.LightBlockByLocationOp)
				{
					return null;
				}
				return (LightBlockByLocationOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.LightBlockByLocationOp);
			}
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x06015DC7 RID: 89543 RVA: 0x0032CB6F File Offset: 0x0032AD6F
		// (set) Token: 0x06015DC8 RID: 89544 RVA: 0x0032CB88 File Offset: 0x0032AD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp MapTeleportByLocationOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.MapTeleportByLocationOp)
				{
					return null;
				}
				return (MapTeleportByLocationOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.MapTeleportByLocationOp);
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x06015DC9 RID: 89545 RVA: 0x0032CB9F File Offset: 0x0032AD9F
		// (set) Token: 0x06015DCA RID: 89546 RVA: 0x0032CBB8 File Offset: 0x0032ADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp ChangeEventByPosOp
		{
			get
			{
				if (this.dataCase_ != RogueResOpData.DataOneofCase.ChangeEventByPosOp)
				{
					return null;
				}
				return (ChangeEventByPosOp)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResOpData.DataOneofCase.None : RogueResOpData.DataOneofCase.ChangeEventByPosOp);
			}
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x06015DCB RID: 89547 RVA: 0x0032CBCF File Offset: 0x0032ADCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015DCC RID: 89548 RVA: 0x0032CBD7 File Offset: 0x0032ADD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResOpData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015DCD RID: 89549 RVA: 0x0032CBE7 File Offset: 0x0032ADE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpData);
		}

		// Token: 0x06015DCE RID: 89550 RVA: 0x0032CBF8 File Offset: 0x0032ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RogueResOpType == other.RogueResOpType && object.Equals(this.MoveOp, other.MoveOp) && object.Equals(this.GridEventOp, other.GridEventOp) && object.Equals(this.SelectViewOp, other.SelectViewOp) && object.Equals(this.ShowViewOp, other.ShowViewOp) && object.Equals(this.RogueGotoLevelPlayOp, other.RogueGotoLevelPlayOp) && object.Equals(this.RollBuffBondLinkIdOp, other.RollBuffBondLinkIdOp) && object.Equals(this.FallbackView, other.FallbackView) && object.Equals(this.LightBlockByLocationOp, other.LightBlockByLocationOp) && object.Equals(this.MapTeleportByLocationOp, other.MapTeleportByLocationOp) && object.Equals(this.ChangeEventByPosOp, other.ChangeEventByPosOp) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DCF RID: 89551 RVA: 0x0032CD24 File Offset: 0x0032AF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.RogueResOpType != RogueResOpType.Unkonw)
			{
				num ^= this.RogueResOpType.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MoveOp)
			{
				num ^= this.MoveOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.GridEventOp)
			{
				num ^= this.GridEventOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.SelectViewOp)
			{
				num ^= this.SelectViewOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ShowViewOp)
			{
				num ^= this.ShowViewOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp)
			{
				num ^= this.RogueGotoLevelPlayOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp)
			{
				num ^= this.RollBuffBondLinkIdOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.FallbackView)
			{
				num ^= this.FallbackView.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.LightBlockByLocationOp)
			{
				num ^= this.LightBlockByLocationOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MapTeleportByLocationOp)
			{
				num ^= this.MapTeleportByLocationOp.GetHashCode();
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ChangeEventByPosOp)
			{
				num ^= this.ChangeEventByPosOp.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015DD0 RID: 89552 RVA: 0x0032CE75 File Offset: 0x0032B075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DD1 RID: 89553 RVA: 0x0032CE82 File Offset: 0x0032B082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DD2 RID: 89554 RVA: 0x0032CE8C File Offset: 0x0032B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MoveOp)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MoveOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.GridEventOp)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GridEventOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.SelectViewOp)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SelectViewOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ShowViewOp)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ShowViewOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueGotoLevelPlayOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RollBuffBondLinkIdOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.FallbackView)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.FallbackView);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.LightBlockByLocationOp)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LightBlockByLocationOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MapTeleportByLocationOp)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MapTeleportByLocationOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ChangeEventByPosOp)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ChangeEventByPosOp);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(192, 62);
				output.WriteInt32(this.IncId);
			}
			if (this.RogueResOpType != RogueResOpType.Unkonw)
			{
				output.WriteRawTag(200, 62);
				output.WriteEnum((int)this.RogueResOpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DD3 RID: 89555 RVA: 0x0032D018 File Offset: 0x0032B218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.RogueResOpType != RogueResOpType.Unkonw)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.RogueResOpType);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MoveOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.GridEventOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GridEventOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.SelectViewOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectViewOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ShowViewOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShowViewOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGotoLevelPlayOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RollBuffBondLinkIdOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.FallbackView)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FallbackView);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.LightBlockByLocationOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LightBlockByLocationOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.MapTeleportByLocationOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MapTeleportByLocationOp);
			}
			if (this.dataCase_ == RogueResOpData.DataOneofCase.ChangeEventByPosOp)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChangeEventByPosOp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015DD4 RID: 89556 RVA: 0x0032D16C File Offset: 0x0032B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.RogueResOpType != RogueResOpType.Unkonw)
			{
				this.RogueResOpType = other.RogueResOpType;
			}
			switch (other.DataCase)
			{
			case RogueResOpData.DataOneofCase.MoveOp:
				if (this.MoveOp == null)
				{
					this.MoveOp = new MoveOp();
				}
				this.MoveOp.MergeFrom(other.MoveOp);
				break;
			case RogueResOpData.DataOneofCase.GridEventOp:
				if (this.GridEventOp == null)
				{
					this.GridEventOp = new GridEventOp();
				}
				this.GridEventOp.MergeFrom(other.GridEventOp);
				break;
			case RogueResOpData.DataOneofCase.SelectViewOp:
				if (this.SelectViewOp == null)
				{
					this.SelectViewOp = new SelectViewOp();
				}
				this.SelectViewOp.MergeFrom(other.SelectViewOp);
				break;
			case RogueResOpData.DataOneofCase.ShowViewOp:
				if (this.ShowViewOp == null)
				{
					this.ShowViewOp = new ShowViewOp();
				}
				this.ShowViewOp.MergeFrom(other.ShowViewOp);
				break;
			case RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp:
				if (this.RogueGotoLevelPlayOp == null)
				{
					this.RogueGotoLevelPlayOp = new RogueGotoLevelPlayOp();
				}
				this.RogueGotoLevelPlayOp.MergeFrom(other.RogueGotoLevelPlayOp);
				break;
			case RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp:
				if (this.RollBuffBondLinkIdOp == null)
				{
					this.RollBuffBondLinkIdOp = new RollBuffBondLinkIdOp();
				}
				this.RollBuffBondLinkIdOp.MergeFrom(other.RollBuffBondLinkIdOp);
				break;
			case RogueResOpData.DataOneofCase.FallbackView:
				if (this.FallbackView == null)
				{
					this.FallbackView = new FallbackViewOp();
				}
				this.FallbackView.MergeFrom(other.FallbackView);
				break;
			case RogueResOpData.DataOneofCase.LightBlockByLocationOp:
				if (this.LightBlockByLocationOp == null)
				{
					this.LightBlockByLocationOp = new LightBlockByLocationOp();
				}
				this.LightBlockByLocationOp.MergeFrom(other.LightBlockByLocationOp);
				break;
			case RogueResOpData.DataOneofCase.MapTeleportByLocationOp:
				if (this.MapTeleportByLocationOp == null)
				{
					this.MapTeleportByLocationOp = new MapTeleportByLocationOp();
				}
				this.MapTeleportByLocationOp.MergeFrom(other.MapTeleportByLocationOp);
				break;
			case RogueResOpData.DataOneofCase.ChangeEventByPosOp:
				if (this.ChangeEventByPosOp == null)
				{
					this.ChangeEventByPosOp = new ChangeEventByPosOp();
				}
				this.ChangeEventByPosOp.MergeFrom(other.ChangeEventByPosOp);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015DD5 RID: 89557 RVA: 0x0032D38C File Offset: 0x0032B58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DD6 RID: 89558 RVA: 0x0032D398 File Offset: 0x0032B598
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
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							MoveOp moveOp = new MoveOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.MoveOp)
							{
								moveOp.MergeFrom(this.MoveOp);
							}
							input.ReadMessage(moveOp);
							this.MoveOp = moveOp;
							continue;
						}
						if (num == 18U)
						{
							GridEventOp gridEventOp = new GridEventOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.GridEventOp)
							{
								gridEventOp.MergeFrom(this.GridEventOp);
							}
							input.ReadMessage(gridEventOp);
							this.GridEventOp = gridEventOp;
							continue;
						}
						if (num == 26U)
						{
							SelectViewOp selectViewOp = new SelectViewOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.SelectViewOp)
							{
								selectViewOp.MergeFrom(this.SelectViewOp);
							}
							input.ReadMessage(selectViewOp);
							this.SelectViewOp = selectViewOp;
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							ShowViewOp showViewOp = new ShowViewOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.ShowViewOp)
							{
								showViewOp.MergeFrom(this.ShowViewOp);
							}
							input.ReadMessage(showViewOp);
							this.ShowViewOp = showViewOp;
							continue;
						}
						if (num == 42U)
						{
							RogueGotoLevelPlayOp rogueGotoLevelPlayOp = new RogueGotoLevelPlayOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.RogueGotoLevelPlayOp)
							{
								rogueGotoLevelPlayOp.MergeFrom(this.RogueGotoLevelPlayOp);
							}
							input.ReadMessage(rogueGotoLevelPlayOp);
							this.RogueGotoLevelPlayOp = rogueGotoLevelPlayOp;
							continue;
						}
						if (num == 50U)
						{
							RollBuffBondLinkIdOp rollBuffBondLinkIdOp = new RollBuffBondLinkIdOp();
							if (this.dataCase_ == RogueResOpData.DataOneofCase.RollBuffBondLinkIdOp)
							{
								rollBuffBondLinkIdOp.MergeFrom(this.RollBuffBondLinkIdOp);
							}
							input.ReadMessage(rollBuffBondLinkIdOp);
							this.RollBuffBondLinkIdOp = rollBuffBondLinkIdOp;
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						FallbackViewOp fallbackViewOp = new FallbackViewOp();
						if (this.dataCase_ == RogueResOpData.DataOneofCase.FallbackView)
						{
							fallbackViewOp.MergeFrom(this.FallbackView);
						}
						input.ReadMessage(fallbackViewOp);
						this.FallbackView = fallbackViewOp;
						continue;
					}
					if (num == 82U)
					{
						LightBlockByLocationOp lightBlockByLocationOp = new LightBlockByLocationOp();
						if (this.dataCase_ == RogueResOpData.DataOneofCase.LightBlockByLocationOp)
						{
							lightBlockByLocationOp.MergeFrom(this.LightBlockByLocationOp);
						}
						input.ReadMessage(lightBlockByLocationOp);
						this.LightBlockByLocationOp = lightBlockByLocationOp;
						continue;
					}
					if (num == 90U)
					{
						MapTeleportByLocationOp mapTeleportByLocationOp = new MapTeleportByLocationOp();
						if (this.dataCase_ == RogueResOpData.DataOneofCase.MapTeleportByLocationOp)
						{
							mapTeleportByLocationOp.MergeFrom(this.MapTeleportByLocationOp);
						}
						input.ReadMessage(mapTeleportByLocationOp);
						this.MapTeleportByLocationOp = mapTeleportByLocationOp;
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						ChangeEventByPosOp changeEventByPosOp = new ChangeEventByPosOp();
						if (this.dataCase_ == RogueResOpData.DataOneofCase.ChangeEventByPosOp)
						{
							changeEventByPosOp.MergeFrom(this.ChangeEventByPosOp);
						}
						input.ReadMessage(changeEventByPosOp);
						this.ChangeEventByPosOp = changeEventByPosOp;
						continue;
					}
					if (num == 8000U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 8008U)
					{
						this.RogueResOpType = (RogueResOpType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008314 RID: 33556
		private static readonly MessageParser<RogueResOpData> _parser = new MessageParser<RogueResOpData>(() => new RogueResOpData());

		// Token: 0x04008315 RID: 33557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008316 RID: 33558
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04008317 RID: 33559
		private int incId_;

		// Token: 0x04008318 RID: 33560
		public const int RogueResOpTypeFieldNumber = 1001;

		// Token: 0x04008319 RID: 33561
		private RogueResOpType rogueResOpType_;

		// Token: 0x0400831A RID: 33562
		public const int MoveOpFieldNumber = 1;

		// Token: 0x0400831B RID: 33563
		public const int GridEventOpFieldNumber = 2;

		// Token: 0x0400831C RID: 33564
		public const int SelectViewOpFieldNumber = 3;

		// Token: 0x0400831D RID: 33565
		public const int ShowViewOpFieldNumber = 4;

		// Token: 0x0400831E RID: 33566
		public const int RogueGotoLevelPlayOpFieldNumber = 5;

		// Token: 0x0400831F RID: 33567
		public const int RollBuffBondLinkIdOpFieldNumber = 6;

		// Token: 0x04008320 RID: 33568
		public const int FallbackViewFieldNumber = 9;

		// Token: 0x04008321 RID: 33569
		public const int LightBlockByLocationOpFieldNumber = 10;

		// Token: 0x04008322 RID: 33570
		public const int MapTeleportByLocationOpFieldNumber = 11;

		// Token: 0x04008323 RID: 33571
		public const int ChangeEventByPosOpFieldNumber = 12;

		// Token: 0x04008324 RID: 33572
		private object data_;

		// Token: 0x04008325 RID: 33573
		private RogueResOpData.DataOneofCase dataCase_;

		// Token: 0x0200193A RID: 6458
		public enum DataOneofCase
		{
			// Token: 0x0400C98F RID: 51599
			None,
			// Token: 0x0400C990 RID: 51600
			MoveOp,
			// Token: 0x0400C991 RID: 51601
			GridEventOp,
			// Token: 0x0400C992 RID: 51602
			SelectViewOp,
			// Token: 0x0400C993 RID: 51603
			ShowViewOp,
			// Token: 0x0400C994 RID: 51604
			RogueGotoLevelPlayOp,
			// Token: 0x0400C995 RID: 51605
			RollBuffBondLinkIdOp,
			// Token: 0x0400C996 RID: 51606
			FallbackView = 9,
			// Token: 0x0400C997 RID: 51607
			LightBlockByLocationOp,
			// Token: 0x0400C998 RID: 51608
			MapTeleportByLocationOp,
			// Token: 0x0400C999 RID: 51609
			ChangeEventByPosOp
		}
	}
}
