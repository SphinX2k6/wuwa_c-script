using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCE RID: 4046
	public sealed class RogueResGainData : IMessage<RogueResGainData>, IMessage, IEquatable<RogueResGainData>, IDeepCloneable<RogueResGainData>, IBufferMessage
	{
		// Token: 0x06015A68 RID: 88680 RVA: 0x00324DE9 File Offset: 0x00322FE9
		[NullableContext(1)]
		public static RogueResGainData Create()
		{
			return new RogueResGainData();
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x06015A69 RID: 88681 RVA: 0x00324DF0 File Offset: 0x00322FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResGainData> Parser
		{
			get
			{
				return RogueResGainData._parser;
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06015A6A RID: 88682 RVA: 0x00324DF7 File Offset: 0x00322FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06015A6B RID: 88683 RVA: 0x00324DFA File Offset: 0x00322FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainData.Descriptor;
			}
		}

		// Token: 0x06015A6C RID: 88684 RVA: 0x00324E01 File Offset: 0x00323001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData()
		{
		}

		// Token: 0x06015A6D RID: 88685 RVA: 0x00324E0C File Offset: 0x0032300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData(RogueResGainData other) : this()
		{
			this.incId_ = other.incId_;
			this.rogueResDataType_ = other.rogueResDataType_;
			switch (other.DataCase)
			{
			case RogueResGainData.DataOneofCase.RogueResToken:
				this.RogueResToken = other.RogueResToken.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResShopToken:
				this.RogueResShopToken = other.RogueResShopToken.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResRoleBuff:
				this.RogueResRoleBuff = other.RogueResRoleBuff.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResPhantom:
				this.RogueResPhantom = other.RogueResPhantom.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResMiracleCreation:
				this.RogueResMiracleCreation = other.RogueResMiracleCreation.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResRole:
				this.RogueResRole = other.RogueResRole.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResEvent:
				this.RogueResEvent = other.RogueResEvent.Clone();
				break;
			case RogueResGainData.DataOneofCase.RogueResComplex:
				this.RogueResComplex = other.RogueResComplex.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A6E RID: 88686 RVA: 0x00324F15 File Offset: 0x00323115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData Clone()
		{
			return new RogueResGainData(this);
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06015A6F RID: 88687 RVA: 0x00324F1D File Offset: 0x0032311D
		// (set) Token: 0x06015A70 RID: 88688 RVA: 0x00324F25 File Offset: 0x00323125
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

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x06015A71 RID: 88689 RVA: 0x00324F2E File Offset: 0x0032312E
		// (set) Token: 0x06015A72 RID: 88690 RVA: 0x00324F36 File Offset: 0x00323136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResDataType RogueResDataType
		{
			get
			{
				return this.rogueResDataType_;
			}
			set
			{
				this.rogueResDataType_ = value;
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x06015A73 RID: 88691 RVA: 0x00324F3F File Offset: 0x0032313F
		// (set) Token: 0x06015A74 RID: 88692 RVA: 0x00324F57 File Offset: 0x00323157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken RogueResToken
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResToken)
				{
					return null;
				}
				return (RogueResToken)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResToken);
			}
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06015A75 RID: 88693 RVA: 0x00324F6D File Offset: 0x0032316D
		// (set) Token: 0x06015A76 RID: 88694 RVA: 0x00324F85 File Offset: 0x00323185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken RogueResShopToken
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResShopToken)
				{
					return null;
				}
				return (RogueResShopToken)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResShopToken);
			}
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06015A77 RID: 88695 RVA: 0x00324F9B File Offset: 0x0032319B
		// (set) Token: 0x06015A78 RID: 88696 RVA: 0x00324FB3 File Offset: 0x003231B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBuff RogueResRoleBuff
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResRoleBuff)
				{
					return null;
				}
				return (RogueResRoleBuff)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResRoleBuff);
			}
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06015A79 RID: 88697 RVA: 0x00324FC9 File Offset: 0x003231C9
		// (set) Token: 0x06015A7A RID: 88698 RVA: 0x00324FE1 File Offset: 0x003231E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom RogueResPhantom
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResPhantom)
				{
					return null;
				}
				return (RogueResPhantom)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResPhantom);
			}
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x06015A7B RID: 88699 RVA: 0x00324FF7 File Offset: 0x003231F7
		// (set) Token: 0x06015A7C RID: 88700 RVA: 0x0032500F File Offset: 0x0032320F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMiracleCreation RogueResMiracleCreation
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResMiracleCreation)
				{
					return null;
				}
				return (RogueResMiracleCreation)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResMiracleCreation);
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x06015A7D RID: 88701 RVA: 0x00325025 File Offset: 0x00323225
		// (set) Token: 0x06015A7E RID: 88702 RVA: 0x0032503D File Offset: 0x0032323D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole RogueResRole
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResRole)
				{
					return null;
				}
				return (RogueResRole)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResRole);
			}
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x06015A7F RID: 88703 RVA: 0x00325053 File Offset: 0x00323253
		// (set) Token: 0x06015A80 RID: 88704 RVA: 0x0032506B File Offset: 0x0032326B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEvent RogueResEvent
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResEvent)
				{
					return null;
				}
				return (RogueResEvent)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResEvent);
			}
		}

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06015A81 RID: 88705 RVA: 0x00325081 File Offset: 0x00323281
		// (set) Token: 0x06015A82 RID: 88706 RVA: 0x00325099 File Offset: 0x00323299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResComplex RogueResComplex
		{
			get
			{
				if (this.dataCase_ != RogueResGainData.DataOneofCase.RogueResComplex)
				{
					return null;
				}
				return (RogueResComplex)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueResGainData.DataOneofCase.None : RogueResGainData.DataOneofCase.RogueResComplex);
			}
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06015A83 RID: 88707 RVA: 0x003250AF File Offset: 0x003232AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015A84 RID: 88708 RVA: 0x003250B7 File Offset: 0x003232B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResGainData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015A85 RID: 88709 RVA: 0x003250C7 File Offset: 0x003232C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainData);
		}

		// Token: 0x06015A86 RID: 88710 RVA: 0x003250D8 File Offset: 0x003232D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RogueResDataType == other.RogueResDataType && object.Equals(this.RogueResToken, other.RogueResToken) && object.Equals(this.RogueResShopToken, other.RogueResShopToken) && object.Equals(this.RogueResRoleBuff, other.RogueResRoleBuff) && object.Equals(this.RogueResPhantom, other.RogueResPhantom) && object.Equals(this.RogueResMiracleCreation, other.RogueResMiracleCreation) && object.Equals(this.RogueResRole, other.RogueResRole) && object.Equals(this.RogueResEvent, other.RogueResEvent) && object.Equals(this.RogueResComplex, other.RogueResComplex) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A87 RID: 88711 RVA: 0x003251DC File Offset: 0x003233DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				num ^= this.RogueResDataType.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResToken)
			{
				num ^= this.RogueResToken.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResShopToken)
			{
				num ^= this.RogueResShopToken.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRoleBuff)
			{
				num ^= this.RogueResRoleBuff.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResPhantom)
			{
				num ^= this.RogueResPhantom.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResMiracleCreation)
			{
				num ^= this.RogueResMiracleCreation.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRole)
			{
				num ^= this.RogueResRole.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResEvent)
			{
				num ^= this.RogueResEvent.GetHashCode();
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResComplex)
			{
				num ^= this.RogueResComplex.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A88 RID: 88712 RVA: 0x003252FB File Offset: 0x003234FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A89 RID: 88713 RVA: 0x00325308 File Offset: 0x00323508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A8A RID: 88714 RVA: 0x00325314 File Offset: 0x00323514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResToken)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResToken);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResShopToken)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueResShopToken);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRoleBuff)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueResRoleBuff);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResPhantom)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueResPhantom);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResMiracleCreation)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueResMiracleCreation);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRole)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueResRole);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResEvent)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueResEvent);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResComplex)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueResComplex);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(192, 62);
				output.WriteInt32(this.IncId);
			}
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				output.WriteRawTag(200, 62);
				output.WriteEnum((int)this.RogueResDataType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A8B RID: 88715 RVA: 0x00325460 File Offset: 0x00323660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.RogueResDataType != RogueResDataType.NoGain)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.RogueResDataType);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResToken)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResToken);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResShopToken)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResShopToken);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRoleBuff)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResRoleBuff);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResPhantom)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResPhantom);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResMiracleCreation)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResMiracleCreation);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRole)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResRole);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResEvent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResEvent);
			}
			if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResComplex)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResComplex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A8C RID: 88716 RVA: 0x00325580 File Offset: 0x00323780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGainData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.RogueResDataType != RogueResDataType.NoGain)
			{
				this.RogueResDataType = other.RogueResDataType;
			}
			switch (other.DataCase)
			{
			case RogueResGainData.DataOneofCase.RogueResToken:
				if (this.RogueResToken == null)
				{
					this.RogueResToken = new RogueResToken();
				}
				this.RogueResToken.MergeFrom(other.RogueResToken);
				break;
			case RogueResGainData.DataOneofCase.RogueResShopToken:
				if (this.RogueResShopToken == null)
				{
					this.RogueResShopToken = new RogueResShopToken();
				}
				this.RogueResShopToken.MergeFrom(other.RogueResShopToken);
				break;
			case RogueResGainData.DataOneofCase.RogueResRoleBuff:
				if (this.RogueResRoleBuff == null)
				{
					this.RogueResRoleBuff = new RogueResRoleBuff();
				}
				this.RogueResRoleBuff.MergeFrom(other.RogueResRoleBuff);
				break;
			case RogueResGainData.DataOneofCase.RogueResPhantom:
				if (this.RogueResPhantom == null)
				{
					this.RogueResPhantom = new RogueResPhantom();
				}
				this.RogueResPhantom.MergeFrom(other.RogueResPhantom);
				break;
			case RogueResGainData.DataOneofCase.RogueResMiracleCreation:
				if (this.RogueResMiracleCreation == null)
				{
					this.RogueResMiracleCreation = new RogueResMiracleCreation();
				}
				this.RogueResMiracleCreation.MergeFrom(other.RogueResMiracleCreation);
				break;
			case RogueResGainData.DataOneofCase.RogueResRole:
				if (this.RogueResRole == null)
				{
					this.RogueResRole = new RogueResRole();
				}
				this.RogueResRole.MergeFrom(other.RogueResRole);
				break;
			case RogueResGainData.DataOneofCase.RogueResEvent:
				if (this.RogueResEvent == null)
				{
					this.RogueResEvent = new RogueResEvent();
				}
				this.RogueResEvent.MergeFrom(other.RogueResEvent);
				break;
			case RogueResGainData.DataOneofCase.RogueResComplex:
				if (this.RogueResComplex == null)
				{
					this.RogueResComplex = new RogueResComplex();
				}
				this.RogueResComplex.MergeFrom(other.RogueResComplex);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A8D RID: 88717 RVA: 0x0032573E File Offset: 0x0032393E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A8E RID: 88718 RVA: 0x00325748 File Offset: 0x00323948
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
						if (num == 10U)
						{
							RogueResToken rogueResToken = new RogueResToken();
							if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResToken)
							{
								rogueResToken.MergeFrom(this.RogueResToken);
							}
							input.ReadMessage(rogueResToken);
							this.RogueResToken = rogueResToken;
							continue;
						}
						if (num == 18U)
						{
							RogueResShopToken rogueResShopToken = new RogueResShopToken();
							if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResShopToken)
							{
								rogueResShopToken.MergeFrom(this.RogueResShopToken);
							}
							input.ReadMessage(rogueResShopToken);
							this.RogueResShopToken = rogueResShopToken;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							RogueResRoleBuff rogueResRoleBuff = new RogueResRoleBuff();
							if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRoleBuff)
							{
								rogueResRoleBuff.MergeFrom(this.RogueResRoleBuff);
							}
							input.ReadMessage(rogueResRoleBuff);
							this.RogueResRoleBuff = rogueResRoleBuff;
							continue;
						}
						if (num == 34U)
						{
							RogueResPhantom rogueResPhantom = new RogueResPhantom();
							if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResPhantom)
							{
								rogueResPhantom.MergeFrom(this.RogueResPhantom);
							}
							input.ReadMessage(rogueResPhantom);
							this.RogueResPhantom = rogueResPhantom;
							continue;
						}
						if (num == 42U)
						{
							RogueResMiracleCreation rogueResMiracleCreation = new RogueResMiracleCreation();
							if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResMiracleCreation)
							{
								rogueResMiracleCreation.MergeFrom(this.RogueResMiracleCreation);
							}
							input.ReadMessage(rogueResMiracleCreation);
							this.RogueResMiracleCreation = rogueResMiracleCreation;
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						RogueResRole rogueResRole = new RogueResRole();
						if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResRole)
						{
							rogueResRole.MergeFrom(this.RogueResRole);
						}
						input.ReadMessage(rogueResRole);
						this.RogueResRole = rogueResRole;
						continue;
					}
					if (num == 58U)
					{
						RogueResEvent rogueResEvent = new RogueResEvent();
						if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResEvent)
						{
							rogueResEvent.MergeFrom(this.RogueResEvent);
						}
						input.ReadMessage(rogueResEvent);
						this.RogueResEvent = rogueResEvent;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						RogueResComplex rogueResComplex = new RogueResComplex();
						if (this.dataCase_ == RogueResGainData.DataOneofCase.RogueResComplex)
						{
							rogueResComplex.MergeFrom(this.RogueResComplex);
						}
						input.ReadMessage(rogueResComplex);
						this.RogueResComplex = rogueResComplex;
						continue;
					}
					if (num == 8000U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 8008U)
					{
						this.RogueResDataType = (RogueResDataType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008267 RID: 33383
		private static readonly MessageParser<RogueResGainData> _parser = new MessageParser<RogueResGainData>(() => new RogueResGainData());

		// Token: 0x04008268 RID: 33384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008269 RID: 33385
		public const int IncIdFieldNumber = 1000;

		// Token: 0x0400826A RID: 33386
		private int incId_;

		// Token: 0x0400826B RID: 33387
		public const int RogueResDataTypeFieldNumber = 1001;

		// Token: 0x0400826C RID: 33388
		private RogueResDataType rogueResDataType_;

		// Token: 0x0400826D RID: 33389
		public const int RogueResTokenFieldNumber = 1;

		// Token: 0x0400826E RID: 33390
		public const int RogueResShopTokenFieldNumber = 2;

		// Token: 0x0400826F RID: 33391
		public const int RogueResRoleBuffFieldNumber = 3;

		// Token: 0x04008270 RID: 33392
		public const int RogueResPhantomFieldNumber = 4;

		// Token: 0x04008271 RID: 33393
		public const int RogueResMiracleCreationFieldNumber = 5;

		// Token: 0x04008272 RID: 33394
		public const int RogueResRoleFieldNumber = 6;

		// Token: 0x04008273 RID: 33395
		public const int RogueResEventFieldNumber = 7;

		// Token: 0x04008274 RID: 33396
		public const int RogueResComplexFieldNumber = 8;

		// Token: 0x04008275 RID: 33397
		private object data_;

		// Token: 0x04008276 RID: 33398
		private RogueResGainData.DataOneofCase dataCase_;

		// Token: 0x020019AC RID: 6572
		public enum DataOneofCase
		{
			// Token: 0x0400CEA8 RID: 52904
			None,
			// Token: 0x0400CEA9 RID: 52905
			RogueResToken,
			// Token: 0x0400CEAA RID: 52906
			RogueResShopToken,
			// Token: 0x0400CEAB RID: 52907
			RogueResRoleBuff,
			// Token: 0x0400CEAC RID: 52908
			RogueResPhantom,
			// Token: 0x0400CEAD RID: 52909
			RogueResMiracleCreation,
			// Token: 0x0400CEAE RID: 52910
			RogueResRole,
			// Token: 0x0400CEAF RID: 52911
			RogueResEvent,
			// Token: 0x0400CEB0 RID: 52912
			RogueResComplex
		}
	}
}
