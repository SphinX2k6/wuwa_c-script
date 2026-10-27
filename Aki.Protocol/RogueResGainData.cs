using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDE RID: 4062
	public sealed class RogueResGainData : IMessage<RogueResGainData>, IMessage, IEquatable<RogueResGainData>, IDeepCloneable<RogueResGainData>, IBufferMessage
	{
		// Token: 0x06015B4D RID: 88909 RVA: 0x0032649D File Offset: 0x0032469D
		[NullableContext(1)]
		public static RogueResGainData Create()
		{
			return new RogueResGainData();
		}

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x06015B4E RID: 88910 RVA: 0x003264A4 File Offset: 0x003246A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResGainData> Parser
		{
			get
			{
				return RogueResGainData._parser;
			}
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06015B4F RID: 88911 RVA: 0x003264AB File Offset: 0x003246AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06015B50 RID: 88912 RVA: 0x003264AE File Offset: 0x003246AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainData.Descriptor;
			}
		}

		// Token: 0x06015B51 RID: 88913 RVA: 0x003264B5 File Offset: 0x003246B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData()
		{
		}

		// Token: 0x06015B52 RID: 88914 RVA: 0x003264C0 File Offset: 0x003246C0
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

		// Token: 0x06015B53 RID: 88915 RVA: 0x003265C9 File Offset: 0x003247C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData Clone()
		{
			return new RogueResGainData(this);
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x06015B54 RID: 88916 RVA: 0x003265D1 File Offset: 0x003247D1
		// (set) Token: 0x06015B55 RID: 88917 RVA: 0x003265D9 File Offset: 0x003247D9
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

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x06015B56 RID: 88918 RVA: 0x003265E2 File Offset: 0x003247E2
		// (set) Token: 0x06015B57 RID: 88919 RVA: 0x003265EA File Offset: 0x003247EA
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

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x06015B58 RID: 88920 RVA: 0x003265F3 File Offset: 0x003247F3
		// (set) Token: 0x06015B59 RID: 88921 RVA: 0x0032660B File Offset: 0x0032480B
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

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x06015B5A RID: 88922 RVA: 0x00326621 File Offset: 0x00324821
		// (set) Token: 0x06015B5B RID: 88923 RVA: 0x00326639 File Offset: 0x00324839
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

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06015B5C RID: 88924 RVA: 0x0032664F File Offset: 0x0032484F
		// (set) Token: 0x06015B5D RID: 88925 RVA: 0x00326667 File Offset: 0x00324867
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

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06015B5E RID: 88926 RVA: 0x0032667D File Offset: 0x0032487D
		// (set) Token: 0x06015B5F RID: 88927 RVA: 0x00326695 File Offset: 0x00324895
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

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06015B60 RID: 88928 RVA: 0x003266AB File Offset: 0x003248AB
		// (set) Token: 0x06015B61 RID: 88929 RVA: 0x003266C3 File Offset: 0x003248C3
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

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06015B62 RID: 88930 RVA: 0x003266D9 File Offset: 0x003248D9
		// (set) Token: 0x06015B63 RID: 88931 RVA: 0x003266F1 File Offset: 0x003248F1
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

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06015B64 RID: 88932 RVA: 0x00326707 File Offset: 0x00324907
		// (set) Token: 0x06015B65 RID: 88933 RVA: 0x0032671F File Offset: 0x0032491F
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

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06015B66 RID: 88934 RVA: 0x00326735 File Offset: 0x00324935
		// (set) Token: 0x06015B67 RID: 88935 RVA: 0x0032674D File Offset: 0x0032494D
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

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06015B68 RID: 88936 RVA: 0x00326763 File Offset: 0x00324963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainData.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06015B69 RID: 88937 RVA: 0x0032676B File Offset: 0x0032496B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueResGainData.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06015B6A RID: 88938 RVA: 0x0032677B File Offset: 0x0032497B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainData);
		}

		// Token: 0x06015B6B RID: 88939 RVA: 0x0032678C File Offset: 0x0032498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.RogueResDataType == other.RogueResDataType && object.Equals(this.RogueResToken, other.RogueResToken) && object.Equals(this.RogueResShopToken, other.RogueResShopToken) && object.Equals(this.RogueResRoleBuff, other.RogueResRoleBuff) && object.Equals(this.RogueResPhantom, other.RogueResPhantom) && object.Equals(this.RogueResMiracleCreation, other.RogueResMiracleCreation) && object.Equals(this.RogueResRole, other.RogueResRole) && object.Equals(this.RogueResEvent, other.RogueResEvent) && object.Equals(this.RogueResComplex, other.RogueResComplex) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B6C RID: 88940 RVA: 0x00326890 File Offset: 0x00324A90
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

		// Token: 0x06015B6D RID: 88941 RVA: 0x003269AF File Offset: 0x00324BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B6E RID: 88942 RVA: 0x003269BC File Offset: 0x00324BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B6F RID: 88943 RVA: 0x003269C8 File Offset: 0x00324BC8
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

		// Token: 0x06015B70 RID: 88944 RVA: 0x00326B14 File Offset: 0x00324D14
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

		// Token: 0x06015B71 RID: 88945 RVA: 0x00326C34 File Offset: 0x00324E34
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

		// Token: 0x06015B72 RID: 88946 RVA: 0x00326DF2 File Offset: 0x00324FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B73 RID: 88947 RVA: 0x00326DFC File Offset: 0x00324FFC
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

		// Token: 0x0400823D RID: 33341
		private static readonly MessageParser<RogueResGainData> _parser = new MessageParser<RogueResGainData>(() => new RogueResGainData());

		// Token: 0x0400823E RID: 33342
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400823F RID: 33343
		public const int IncIdFieldNumber = 1000;

		// Token: 0x04008240 RID: 33344
		private int incId_;

		// Token: 0x04008241 RID: 33345
		public const int RogueResDataTypeFieldNumber = 1001;

		// Token: 0x04008242 RID: 33346
		private RogueResDataType rogueResDataType_;

		// Token: 0x04008243 RID: 33347
		public const int RogueResTokenFieldNumber = 1;

		// Token: 0x04008244 RID: 33348
		public const int RogueResShopTokenFieldNumber = 2;

		// Token: 0x04008245 RID: 33349
		public const int RogueResRoleBuffFieldNumber = 3;

		// Token: 0x04008246 RID: 33350
		public const int RogueResPhantomFieldNumber = 4;

		// Token: 0x04008247 RID: 33351
		public const int RogueResMiracleCreationFieldNumber = 5;

		// Token: 0x04008248 RID: 33352
		public const int RogueResRoleFieldNumber = 6;

		// Token: 0x04008249 RID: 33353
		public const int RogueResEventFieldNumber = 7;

		// Token: 0x0400824A RID: 33354
		public const int RogueResComplexFieldNumber = 8;

		// Token: 0x0400824B RID: 33355
		private object data_;

		// Token: 0x0400824C RID: 33356
		private RogueResGainData.DataOneofCase dataCase_;

		// Token: 0x02001934 RID: 6452
		public enum DataOneofCase
		{
			// Token: 0x0400C97D RID: 51581
			None,
			// Token: 0x0400C97E RID: 51582
			RogueResToken,
			// Token: 0x0400C97F RID: 51583
			RogueResShopToken,
			// Token: 0x0400C980 RID: 51584
			RogueResRoleBuff,
			// Token: 0x0400C981 RID: 51585
			RogueResPhantom,
			// Token: 0x0400C982 RID: 51586
			RogueResMiracleCreation,
			// Token: 0x0400C983 RID: 51587
			RogueResRole,
			// Token: 0x0400C984 RID: 51588
			RogueResEvent,
			// Token: 0x0400C985 RID: 51589
			RogueResComplex
		}
	}
}
