using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE9 RID: 4073
	public sealed class RogueResOpData : IMessage<RogueResOpData>, IMessage, IEquatable<RogueResOpData>, IDeepCloneable<RogueResOpData>, IBufferMessage
	{
		// Token: 0x06015CC7 RID: 89287 RVA: 0x0032B1A5 File Offset: 0x003293A5
		[NullableContext(1)]
		public static RogueResOpData Create()
		{
			return new RogueResOpData();
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06015CC8 RID: 89288 RVA: 0x0032B1AC File Offset: 0x003293AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResOpData> Parser
		{
			get
			{
				return RogueResOpData._parser;
			}
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x06015CC9 RID: 89289 RVA: 0x0032B1B3 File Offset: 0x003293B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x06015CCA RID: 89290 RVA: 0x0032B1B6 File Offset: 0x003293B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpData.Descriptor;
			}
		}

		// Token: 0x06015CCB RID: 89291 RVA: 0x0032B1BD File Offset: 0x003293BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData()
		{
		}

		// Token: 0x06015CCC RID: 89292 RVA: 0x0032B1C8 File Offset: 0x003293C8
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

		// Token: 0x06015CCD RID: 89293 RVA: 0x0032B30D File Offset: 0x0032950D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData Clone()
		{
			return new RogueResOpData(this);
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x06015CCE RID: 89294 RVA: 0x0032B315 File Offset: 0x00329515
		// (set) Token: 0x06015CCF RID: 89295 RVA: 0x0032B31D File Offset: 0x0032951D
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

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06015CD0 RID: 89296 RVA: 0x0032B326 File Offset: 0x00329526
		// (set) Token: 0x06015CD1 RID: 89297 RVA: 0x0032B32E File Offset: 0x0032952E
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

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06015CD2 RID: 89298 RVA: 0x0032B337 File Offset: 0x00329537
		// (set) Token: 0x06015CD3 RID: 89299 RVA: 0x0032B34F File Offset: 0x0032954F
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

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06015CD4 RID: 89300 RVA: 0x0032B365 File Offset: 0x00329565
		// (set) Token: 0x06015CD5 RID: 89301 RVA: 0x0032B37D File Offset: 0x0032957D
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

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06015CD6 RID: 89302 RVA: 0x0032B393 File Offset: 0x00329593
		// (set) Token: 0x06015CD7 RID: 89303 RVA: 0x0032B3AB File Offset: 0x003295AB
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

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06015CD8 RID: 89304 RVA: 0x0032B3C1 File Offset: 0x003295C1
		// (set) Token: 0x06015CD9 RID: 89305 RVA: 0x0032B3D9 File Offset: 0x003295D9
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

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06015CDA RID: 89306 RVA: 0x0032B3EF File Offset: 0x003295EF
		// (set) Token: 0x06015CDB RID: 89307 RVA: 0x0032B407 File Offset: 0x00329607
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

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06015CDC RID: 89308 RVA: 0x0032B41D File Offset: 0x0032961D
		// (set) Token: 0x06015CDD RID: 89309 RVA: 0x0032B435 File Offset: 0x00329635
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

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x06015CDE RID: 89310 RVA: 0x0032B44B File Offset: 0x0032964B
		// (set) Token: 0x06015CDF RID: 89311 RVA: 0x0032B464 File Offset: 0x00329664
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

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x06015CE0 RID: 89312 RVA: 0x0032B47B File Offset: 0x0032967B
		// (set) Token: 0x06015CE1 RID: 89313 RVA: 0x0032B494 File Offset: 0x00329694
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

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x06015CE2 RID: 89314 RVA: 0x0032B4AB File Offset: 0x003296AB
		// (set) Token: 0x06015CE3 RID: 89315 RVA: 0x0032B4C4 File Offset: 0x003296C4
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

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06015CE4 RID: 89316 RVA: 0x0032B4DB File Offset: 0x003296DB
		// (set) Token: 0x06015CE5 RID: 89317 RVA: 0x0032B4F4 File Offset: 0x003296F4
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

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06015CE6 RID: 89318 RVA: 0x0032B50B File Offset: 0x0032970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015CE7 RID: 89319 RVA: 0x0032B513 File Offset: 0x00329713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResOpData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015CE8 RID: 89320 RVA: 0x0032B523 File Offset: 0x00329723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpData);
		}

		// Token: 0x06015CE9 RID: 89321 RVA: 0x0032B534 File Offset: 0x00329734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RogueResOpType == other.RogueResOpType && object.Equals(this.MoveOp, other.MoveOp) && object.Equals(this.GridEventOp, other.GridEventOp) && object.Equals(this.SelectViewOp, other.SelectViewOp) && object.Equals(this.ShowViewOp, other.ShowViewOp) && object.Equals(this.RogueGotoLevelPlayOp, other.RogueGotoLevelPlayOp) && object.Equals(this.RollBuffBondLinkIdOp, other.RollBuffBondLinkIdOp) && object.Equals(this.FallbackView, other.FallbackView) && object.Equals(this.LightBlockByLocationOp, other.LightBlockByLocationOp) && object.Equals(this.MapTeleportByLocationOp, other.MapTeleportByLocationOp) && object.Equals(this.ChangeEventByPosOp, other.ChangeEventByPosOp) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CEA RID: 89322 RVA: 0x0032B660 File Offset: 0x00329860
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

		// Token: 0x06015CEB RID: 89323 RVA: 0x0032B7B1 File Offset: 0x003299B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CEC RID: 89324 RVA: 0x0032B7BE File Offset: 0x003299BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CED RID: 89325 RVA: 0x0032B7C8 File Offset: 0x003299C8
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

		// Token: 0x06015CEE RID: 89326 RVA: 0x0032B954 File Offset: 0x00329B54
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

		// Token: 0x06015CEF RID: 89327 RVA: 0x0032BAA8 File Offset: 0x00329CA8
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

		// Token: 0x06015CF0 RID: 89328 RVA: 0x0032BCC8 File Offset: 0x00329EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CF1 RID: 89329 RVA: 0x0032BCD4 File Offset: 0x00329ED4
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

		// Token: 0x0400833E RID: 33598
		private static readonly MessageParser<RogueResOpData> _parser = new MessageParser<RogueResOpData>(() => new RogueResOpData());

		// Token: 0x0400833F RID: 33599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008340 RID: 33600
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04008341 RID: 33601
		private int incId_;

		// Token: 0x04008342 RID: 33602
		public const int RogueResOpTypeFieldNumber = 1001;

		// Token: 0x04008343 RID: 33603
		private RogueResOpType rogueResOpType_;

		// Token: 0x04008344 RID: 33604
		public const int MoveOpFieldNumber = 1;

		// Token: 0x04008345 RID: 33605
		public const int GridEventOpFieldNumber = 2;

		// Token: 0x04008346 RID: 33606
		public const int SelectViewOpFieldNumber = 3;

		// Token: 0x04008347 RID: 33607
		public const int ShowViewOpFieldNumber = 4;

		// Token: 0x04008348 RID: 33608
		public const int RogueGotoLevelPlayOpFieldNumber = 5;

		// Token: 0x04008349 RID: 33609
		public const int RollBuffBondLinkIdOpFieldNumber = 6;

		// Token: 0x0400834A RID: 33610
		public const int FallbackViewFieldNumber = 9;

		// Token: 0x0400834B RID: 33611
		public const int LightBlockByLocationOpFieldNumber = 10;

		// Token: 0x0400834C RID: 33612
		public const int MapTeleportByLocationOpFieldNumber = 11;

		// Token: 0x0400834D RID: 33613
		public const int ChangeEventByPosOpFieldNumber = 12;

		// Token: 0x0400834E RID: 33614
		private object data_;

		// Token: 0x0400834F RID: 33615
		private RogueResOpData.DataOneofCase dataCase_;

		// Token: 0x020019B2 RID: 6578
		public enum DataOneofCase
		{
			// Token: 0x0400CEBA RID: 52922
			None,
			// Token: 0x0400CEBB RID: 52923
			MoveOp,
			// Token: 0x0400CEBC RID: 52924
			GridEventOp,
			// Token: 0x0400CEBD RID: 52925
			SelectViewOp,
			// Token: 0x0400CEBE RID: 52926
			ShowViewOp,
			// Token: 0x0400CEBF RID: 52927
			RogueGotoLevelPlayOp,
			// Token: 0x0400CEC0 RID: 52928
			RollBuffBondLinkIdOp,
			// Token: 0x0400CEC1 RID: 52929
			FallbackView = 9,
			// Token: 0x0400CEC2 RID: 52930
			LightBlockByLocationOp,
			// Token: 0x0400CEC3 RID: 52931
			MapTeleportByLocationOp,
			// Token: 0x0400CEC4 RID: 52932
			ChangeEventByPosOp
		}
	}
}
