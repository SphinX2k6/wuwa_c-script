using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A2 RID: 418
	public sealed class BlackboardParam : IMessage<BlackboardParam>, IMessage, IEquatable<BlackboardParam>, IDeepCloneable<BlackboardParam>, IBufferMessage
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x0007CDE7 File Offset: 0x0007AFE7
		[NullableContext(1)]
		public static BlackboardParam Create()
		{
			return new BlackboardParam();
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x0007CDEE File Offset: 0x0007AFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackboardParam> Parser
		{
			get
			{
				return BlackboardParam._parser;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x0007CDF5 File Offset: 0x0007AFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0007CDF8 File Offset: 0x0007AFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackboardParam.Descriptor;
			}
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x0007CDFF File Offset: 0x0007AFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam()
		{
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x0007CE14 File Offset: 0x0007B014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam(BlackboardParam other) : this()
		{
			this.key_ = other.key_;
			this.type_ = other.type_;
			switch (other.ValueCase)
			{
			case BlackboardParam.ValueOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case BlackboardParam.ValueOneofCase.IntValues:
				this.IntValues = other.IntValues.Clone();
				break;
			case BlackboardParam.ValueOneofCase.LongValue:
				this.LongValue = other.LongValue;
				break;
			case BlackboardParam.ValueOneofCase.LongValues:
				this.LongValues = other.LongValues.Clone();
				break;
			case BlackboardParam.ValueOneofCase.BooleanValue:
				this.BooleanValue = other.BooleanValue;
				break;
			case BlackboardParam.ValueOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case BlackboardParam.ValueOneofCase.StringValues:
				this.StringValues = other.StringValues.Clone();
				break;
			case BlackboardParam.ValueOneofCase.FloatValue:
				this.FloatValue = other.FloatValue;
				break;
			case BlackboardParam.ValueOneofCase.FloatValues:
				this.FloatValues = other.FloatValues.Clone();
				break;
			case BlackboardParam.ValueOneofCase.VectorValue:
				this.VectorValue = other.VectorValue.Clone();
				break;
			case BlackboardParam.ValueOneofCase.VectorValues:
				this.VectorValues = other.VectorValues.Clone();
				break;
			case BlackboardParam.ValueOneofCase.RotatorValue:
				this.RotatorValue = other.RotatorValue.Clone();
				break;
			case BlackboardParam.ValueOneofCase.RotatorValues:
				this.RotatorValues = other.RotatorValues.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x0007CF83 File Offset: 0x0007B183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam Clone()
		{
			return new BlackboardParam(this);
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0007CF8B File Offset: 0x0007B18B
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0007CF93 File Offset: 0x0007B193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x0007CFA6 File Offset: 0x0007B1A6
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x0007CFAE File Offset: 0x0007B1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0007CFB7 File Offset: 0x0007B1B7
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0007CFCE File Offset: 0x0007B1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IntValue
		{
			get
			{
				if (!this.HasIntValue)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = BlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0007CFE3 File Offset: 0x0007B1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIntValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0007CFEE File Offset: 0x0007B1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIntValue()
		{
			if (this.HasIntValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0007CFFE File Offset: 0x0007B1FE
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x0007D016 File Offset: 0x0007B216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard IntValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.IntValues)
				{
					return null;
				}
				return (IntArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.IntValues);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0007D02C File Offset: 0x0007B22C
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0007D044 File Offset: 0x0007B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LongValue
		{
			get
			{
				if (!this.HasLongValue)
				{
					return 0L;
				}
				return (long)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = BlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0007D059 File Offset: 0x0007B259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLongValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x0007D064 File Offset: 0x0007B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLongValue()
		{
			if (this.HasLongValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x0007D074 File Offset: 0x0007B274
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x0007D08C File Offset: 0x0007B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard LongValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.LongValues)
				{
					return null;
				}
				return (LongArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.LongValues);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0007D0A2 File Offset: 0x0007B2A2
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0007D0B9 File Offset: 0x0007B2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BooleanValue
		{
			get
			{
				return this.HasBooleanValue && (bool)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = BlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x0007D0CE File Offset: 0x0007B2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBooleanValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0007D0D9 File Offset: 0x0007B2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBooleanValue()
		{
			if (this.HasBooleanValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x0007D0E9 File Offset: 0x0007B2E9
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x0007D104 File Offset: 0x0007B304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StringValue
		{
			get
			{
				if (!this.HasStringValue)
				{
					return "";
				}
				return (string)this.value_;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.valueCase_ = BlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x0007D11E File Offset: 0x0007B31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x0007D129 File Offset: 0x0007B329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0007D139 File Offset: 0x0007B339
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x0007D152 File Offset: 0x0007B352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringArrayBlackboard StringValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.StringValues)
				{
					return null;
				}
				return (StringArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.StringValues);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x0007D169 File Offset: 0x0007B369
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x0007D184 File Offset: 0x0007B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float FloatValue
		{
			get
			{
				if (!this.HasFloatValue)
				{
					return 0f;
				}
				return (float)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = BlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x0007D19A File Offset: 0x0007B39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloatValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0007D1A6 File Offset: 0x0007B3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloatValue()
		{
			if (this.HasFloatValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x0007D1B6 File Offset: 0x0007B3B6
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x0007D1CF File Offset: 0x0007B3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard FloatValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.FloatValues)
				{
					return null;
				}
				return (FloatArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.FloatValues);
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x0007D1E6 File Offset: 0x0007B3E6
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x0007D1FF File Offset: 0x0007B3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector VectorValue
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.VectorValue)
				{
					return null;
				}
				return (Vector)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.VectorValue);
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x0007D216 File Offset: 0x0007B416
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x0007D22F File Offset: 0x0007B42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VectorArrayBlackboard VectorValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.VectorValues)
				{
					return null;
				}
				return (VectorArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.VectorValues);
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x0007D246 File Offset: 0x0007B446
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x0007D25F File Offset: 0x0007B45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator RotatorValue
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.RotatorValue)
				{
					return null;
				}
				return (Rotator)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.RotatorValue);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0007D276 File Offset: 0x0007B476
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x0007D28F File Offset: 0x0007B48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotatorArrayBlackboard RotatorValues
		{
			get
			{
				if (this.valueCase_ != BlackboardParam.ValueOneofCase.RotatorValues)
				{
					return null;
				}
				return (RotatorArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? BlackboardParam.ValueOneofCase.None : BlackboardParam.ValueOneofCase.RotatorValues);
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x0007D2A6 File Offset: 0x0007B4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x0007D2AE File Offset: 0x0007B4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = BlackboardParam.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x0007D2BE File Offset: 0x0007B4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackboardParam);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x0007D2CC File Offset: 0x0007B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackboardParam other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && this.Type == other.Type && this.IntValue == other.IntValue && object.Equals(this.IntValues, other.IntValues) && this.LongValue == other.LongValue && object.Equals(this.LongValues, other.LongValues) && this.BooleanValue == other.BooleanValue && !(this.StringValue != other.StringValue) && object.Equals(this.StringValues, other.StringValues) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FloatValue, other.FloatValue) && object.Equals(this.FloatValues, other.FloatValues) && object.Equals(this.VectorValue, other.VectorValue) && object.Equals(this.VectorValues, other.VectorValues) && object.Equals(this.RotatorValue, other.RotatorValue) && object.Equals(this.RotatorValues, other.RotatorValues) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0007D434 File Offset: 0x0007B634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.Type != BlackboardParamType.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.HasIntValue)
			{
				num ^= this.IntValue.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.IntValues)
			{
				num ^= this.IntValues.GetHashCode();
			}
			if (this.HasLongValue)
			{
				num ^= this.LongValue.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.LongValues)
			{
				num ^= this.LongValues.GetHashCode();
			}
			if (this.HasBooleanValue)
			{
				num ^= this.BooleanValue.GetHashCode();
			}
			if (this.HasStringValue)
			{
				num ^= this.StringValue.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.StringValues)
			{
				num ^= this.StringValues.GetHashCode();
			}
			if (this.HasFloatValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FloatValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValues)
			{
				num ^= this.FloatValues.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValue)
			{
				num ^= this.VectorValue.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValues)
			{
				num ^= this.VectorValues.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValue)
			{
				num ^= this.RotatorValue.GetHashCode();
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValues)
			{
				num ^= this.RotatorValues.GetHashCode();
			}
			num ^= (int)this.valueCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0007D5D8 File Offset: 0x0007B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0007D5E5 File Offset: 0x0007B7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x0007D5F0 File Offset: 0x0007B7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			if (this.Type != BlackboardParamType.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.HasIntValue)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IntValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.IntValues)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.IntValues);
			}
			if (this.HasLongValue)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LongValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.LongValues)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LongValues);
			}
			if (this.HasBooleanValue)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.BooleanValue);
			}
			if (this.HasStringValue)
			{
				output.WriteRawTag(66);
				output.WriteString(this.StringValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.StringValues)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.StringValues);
			}
			if (this.HasFloatValue)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.FloatValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValues)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.FloatValues);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValue)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.VectorValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValues)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.VectorValues);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValue)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RotatorValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValues)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RotatorValues);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0007D7C8 File Offset: 0x0007B9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this.Type != BlackboardParamType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.HasIntValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.IntValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IntValues);
			}
			if (this.HasLongValue)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LongValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.LongValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LongValues);
			}
			if (this.HasBooleanValue)
			{
				num += 2;
			}
			if (this.HasStringValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StringValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.StringValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StringValues);
			}
			if (this.HasFloatValue)
			{
				num += 5;
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FloatValues);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VectorValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VectorValues);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotatorValue);
			}
			if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotatorValues);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x0007D954 File Offset: 0x0007BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackboardParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			if (other.Type != BlackboardParamType.None)
			{
				this.Type = other.Type;
			}
			switch (other.ValueCase)
			{
			case BlackboardParam.ValueOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case BlackboardParam.ValueOneofCase.IntValues:
				if (this.IntValues == null)
				{
					this.IntValues = new IntArrayBlackboard();
				}
				this.IntValues.MergeFrom(other.IntValues);
				break;
			case BlackboardParam.ValueOneofCase.LongValue:
				this.LongValue = other.LongValue;
				break;
			case BlackboardParam.ValueOneofCase.LongValues:
				if (this.LongValues == null)
				{
					this.LongValues = new LongArrayBlackboard();
				}
				this.LongValues.MergeFrom(other.LongValues);
				break;
			case BlackboardParam.ValueOneofCase.BooleanValue:
				this.BooleanValue = other.BooleanValue;
				break;
			case BlackboardParam.ValueOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case BlackboardParam.ValueOneofCase.StringValues:
				if (this.StringValues == null)
				{
					this.StringValues = new StringArrayBlackboard();
				}
				this.StringValues.MergeFrom(other.StringValues);
				break;
			case BlackboardParam.ValueOneofCase.FloatValue:
				this.FloatValue = other.FloatValue;
				break;
			case BlackboardParam.ValueOneofCase.FloatValues:
				if (this.FloatValues == null)
				{
					this.FloatValues = new FloatArrayBlackboard();
				}
				this.FloatValues.MergeFrom(other.FloatValues);
				break;
			case BlackboardParam.ValueOneofCase.VectorValue:
				if (this.VectorValue == null)
				{
					this.VectorValue = new Vector();
				}
				this.VectorValue.MergeFrom(other.VectorValue);
				break;
			case BlackboardParam.ValueOneofCase.VectorValues:
				if (this.VectorValues == null)
				{
					this.VectorValues = new VectorArrayBlackboard();
				}
				this.VectorValues.MergeFrom(other.VectorValues);
				break;
			case BlackboardParam.ValueOneofCase.RotatorValue:
				if (this.RotatorValue == null)
				{
					this.RotatorValue = new Rotator();
				}
				this.RotatorValue.MergeFrom(other.RotatorValue);
				break;
			case BlackboardParam.ValueOneofCase.RotatorValues:
				if (this.RotatorValues == null)
				{
					this.RotatorValues = new RotatorArrayBlackboard();
				}
				this.RotatorValues.MergeFrom(other.RotatorValues);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x0007DB80 File Offset: 0x0007BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x0007DB8C File Offset: 0x0007BD8C
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.Key = input.ReadString();
							continue;
						}
						if (num == 16U)
						{
							this.Type = (BlackboardParamType)input.ReadEnum();
							continue;
						}
						if (num == 24U)
						{
							this.IntValue = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 34U)
						{
							IntArrayBlackboard intArrayBlackboard = new IntArrayBlackboard();
							if (this.valueCase_ == BlackboardParam.ValueOneofCase.IntValues)
							{
								intArrayBlackboard.MergeFrom(this.IntValues);
							}
							input.ReadMessage(intArrayBlackboard);
							this.IntValues = intArrayBlackboard;
							continue;
						}
						if (num == 40U)
						{
							this.LongValue = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							LongArrayBlackboard longArrayBlackboard = new LongArrayBlackboard();
							if (this.valueCase_ == BlackboardParam.ValueOneofCase.LongValues)
							{
								longArrayBlackboard.MergeFrom(this.LongValues);
							}
							input.ReadMessage(longArrayBlackboard);
							this.LongValues = longArrayBlackboard;
							continue;
						}
						if (num == 56U)
						{
							this.BooleanValue = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num <= 74U)
					{
						if (num == 66U)
						{
							this.StringValue = input.ReadString();
							continue;
						}
						if (num == 74U)
						{
							StringArrayBlackboard stringArrayBlackboard = new StringArrayBlackboard();
							if (this.valueCase_ == BlackboardParam.ValueOneofCase.StringValues)
							{
								stringArrayBlackboard.MergeFrom(this.StringValues);
							}
							input.ReadMessage(stringArrayBlackboard);
							this.StringValues = stringArrayBlackboard;
							continue;
						}
					}
					else
					{
						if (num == 85U)
						{
							this.FloatValue = input.ReadFloat();
							continue;
						}
						if (num == 90U)
						{
							FloatArrayBlackboard floatArrayBlackboard = new FloatArrayBlackboard();
							if (this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValues)
							{
								floatArrayBlackboard.MergeFrom(this.FloatValues);
							}
							input.ReadMessage(floatArrayBlackboard);
							this.FloatValues = floatArrayBlackboard;
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						Vector vector = new Vector();
						if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValue)
						{
							vector.MergeFrom(this.VectorValue);
						}
						input.ReadMessage(vector);
						this.VectorValue = vector;
						continue;
					}
					if (num == 106U)
					{
						VectorArrayBlackboard vectorArrayBlackboard = new VectorArrayBlackboard();
						if (this.valueCase_ == BlackboardParam.ValueOneofCase.VectorValues)
						{
							vectorArrayBlackboard.MergeFrom(this.VectorValues);
						}
						input.ReadMessage(vectorArrayBlackboard);
						this.VectorValues = vectorArrayBlackboard;
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						Rotator rotator = new Rotator();
						if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValue)
						{
							rotator.MergeFrom(this.RotatorValue);
						}
						input.ReadMessage(rotator);
						this.RotatorValue = rotator;
						continue;
					}
					if (num == 122U)
					{
						RotatorArrayBlackboard rotatorArrayBlackboard = new RotatorArrayBlackboard();
						if (this.valueCase_ == BlackboardParam.ValueOneofCase.RotatorValues)
						{
							rotatorArrayBlackboard.MergeFrom(this.RotatorValues);
						}
						input.ReadMessage(rotatorArrayBlackboard);
						this.RotatorValues = rotatorArrayBlackboard;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002918 RID: 10520
		private static readonly MessageParser<BlackboardParam> _parser = new MessageParser<BlackboardParam>(() => new BlackboardParam());

		// Token: 0x04002919 RID: 10521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400291A RID: 10522
		public const int KeyFieldNumber = 1;

		// Token: 0x0400291B RID: 10523
		private string key_ = "";

		// Token: 0x0400291C RID: 10524
		public const int TypeFieldNumber = 2;

		// Token: 0x0400291D RID: 10525
		private BlackboardParamType type_;

		// Token: 0x0400291E RID: 10526
		public const int IntValueFieldNumber = 3;

		// Token: 0x0400291F RID: 10527
		public const int IntValuesFieldNumber = 4;

		// Token: 0x04002920 RID: 10528
		public const int LongValueFieldNumber = 5;

		// Token: 0x04002921 RID: 10529
		public const int LongValuesFieldNumber = 6;

		// Token: 0x04002922 RID: 10530
		public const int BooleanValueFieldNumber = 7;

		// Token: 0x04002923 RID: 10531
		public const int StringValueFieldNumber = 8;

		// Token: 0x04002924 RID: 10532
		public const int StringValuesFieldNumber = 9;

		// Token: 0x04002925 RID: 10533
		public const int FloatValueFieldNumber = 10;

		// Token: 0x04002926 RID: 10534
		public const int FloatValuesFieldNumber = 11;

		// Token: 0x04002927 RID: 10535
		public const int VectorValueFieldNumber = 12;

		// Token: 0x04002928 RID: 10536
		public const int VectorValuesFieldNumber = 13;

		// Token: 0x04002929 RID: 10537
		public const int RotatorValueFieldNumber = 14;

		// Token: 0x0400292A RID: 10538
		public const int RotatorValuesFieldNumber = 15;

		// Token: 0x0400292B RID: 10539
		private object value_;

		// Token: 0x0400292C RID: 10540
		private BlackboardParam.ValueOneofCase valueCase_;

		// Token: 0x020016F8 RID: 5880
		public enum ValueOneofCase
		{
			// Token: 0x0400C53A RID: 50490
			None,
			// Token: 0x0400C53B RID: 50491
			IntValue = 3,
			// Token: 0x0400C53C RID: 50492
			IntValues,
			// Token: 0x0400C53D RID: 50493
			LongValue,
			// Token: 0x0400C53E RID: 50494
			LongValues,
			// Token: 0x0400C53F RID: 50495
			BooleanValue,
			// Token: 0x0400C540 RID: 50496
			StringValue,
			// Token: 0x0400C541 RID: 50497
			StringValues,
			// Token: 0x0400C542 RID: 50498
			FloatValue,
			// Token: 0x0400C543 RID: 50499
			FloatValues,
			// Token: 0x0400C544 RID: 50500
			VectorValue,
			// Token: 0x0400C545 RID: 50501
			VectorValues,
			// Token: 0x0400C546 RID: 50502
			RotatorValue,
			// Token: 0x0400C547 RID: 50503
			RotatorValues
		}
	}
}
