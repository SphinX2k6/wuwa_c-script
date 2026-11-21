using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A6 RID: 422
	public sealed class BlackboardParam : IMessage<BlackboardParam>, IMessage, IEquatable<BlackboardParam>, IDeepCloneable<BlackboardParam>, IBufferMessage
	{
		// Token: 0x060031AC RID: 12716 RVA: 0x0007E54F File Offset: 0x0007C74F
		[NullableContext(1)]
		public static BlackboardParam Create()
		{
			return new BlackboardParam();
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x0007E556 File Offset: 0x0007C756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackboardParam> Parser
		{
			get
			{
				return BlackboardParam._parser;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0007E55D File Offset: 0x0007C75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x0007E560 File Offset: 0x0007C760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackboardParam.Descriptor;
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0007E567 File Offset: 0x0007C767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam()
		{
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x0007E57C File Offset: 0x0007C77C
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

		// Token: 0x060031B2 RID: 12722 RVA: 0x0007E6EB File Offset: 0x0007C8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam Clone()
		{
			return new BlackboardParam(this);
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x0007E6F3 File Offset: 0x0007C8F3
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x0007E6FB File Offset: 0x0007C8FB
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

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x0007E70E File Offset: 0x0007C90E
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x0007E716 File Offset: 0x0007C916
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

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x0007E71F File Offset: 0x0007C91F
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x0007E736 File Offset: 0x0007C936
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

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x0007E74B File Offset: 0x0007C94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIntValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0007E756 File Offset: 0x0007C956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIntValue()
		{
			if (this.HasIntValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0007E766 File Offset: 0x0007C966
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x0007E77E File Offset: 0x0007C97E
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x0007E794 File Offset: 0x0007C994
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x0007E7AC File Offset: 0x0007C9AC
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x0007E7C1 File Offset: 0x0007C9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLongValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0007E7CC File Offset: 0x0007C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLongValue()
		{
			if (this.HasLongValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0007E7DC File Offset: 0x0007C9DC
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0007E80A File Offset: 0x0007CA0A
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0007E821 File Offset: 0x0007CA21
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

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x0007E836 File Offset: 0x0007CA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBooleanValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0007E841 File Offset: 0x0007CA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBooleanValue()
		{
			if (this.HasBooleanValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x0007E851 File Offset: 0x0007CA51
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x0007E86C File Offset: 0x0007CA6C
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

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x0007E886 File Offset: 0x0007CA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0007E891 File Offset: 0x0007CA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x0007E8A1 File Offset: 0x0007CAA1
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x0007E8BA File Offset: 0x0007CABA
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

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0007E8D1 File Offset: 0x0007CAD1
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x0007E8EC File Offset: 0x0007CAEC
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x0007E902 File Offset: 0x0007CB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloatValue
		{
			get
			{
				return this.valueCase_ == BlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0007E90E File Offset: 0x0007CB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloatValue()
		{
			if (this.HasFloatValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x0007E91E File Offset: 0x0007CB1E
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x0007E937 File Offset: 0x0007CB37
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x0007E94E File Offset: 0x0007CB4E
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x0007E967 File Offset: 0x0007CB67
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

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x0007E97E File Offset: 0x0007CB7E
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x0007E997 File Offset: 0x0007CB97
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

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x0007E9AE File Offset: 0x0007CBAE
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0007E9C7 File Offset: 0x0007CBC7
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

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x0007E9DE File Offset: 0x0007CBDE
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x0007E9F7 File Offset: 0x0007CBF7
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

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x0007EA0E File Offset: 0x0007CC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParam.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0007EA16 File Offset: 0x0007CC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = BlackboardParam.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0007EA26 File Offset: 0x0007CC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackboardParam);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0007EA34 File Offset: 0x0007CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackboardParam other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && this.Type == other.Type && this.IntValue == other.IntValue && object.Equals(this.IntValues, other.IntValues) && this.LongValue == other.LongValue && object.Equals(this.LongValues, other.LongValues) && this.BooleanValue == other.BooleanValue && !(this.StringValue != other.StringValue) && object.Equals(this.StringValues, other.StringValues) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FloatValue, other.FloatValue) && object.Equals(this.FloatValues, other.FloatValues) && object.Equals(this.VectorValue, other.VectorValue) && object.Equals(this.VectorValues, other.VectorValues) && object.Equals(this.RotatorValue, other.RotatorValue) && object.Equals(this.RotatorValues, other.RotatorValues) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0007EB9C File Offset: 0x0007CD9C
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

		// Token: 0x060031E0 RID: 12768 RVA: 0x0007ED40 File Offset: 0x0007CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0007ED4D File Offset: 0x0007CF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x0007ED58 File Offset: 0x0007CF58
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

		// Token: 0x060031E3 RID: 12771 RVA: 0x0007EF30 File Offset: 0x0007D130
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

		// Token: 0x060031E4 RID: 12772 RVA: 0x0007F0BC File Offset: 0x0007D2BC
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

		// Token: 0x060031E5 RID: 12773 RVA: 0x0007F2E8 File Offset: 0x0007D4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x0007F2F4 File Offset: 0x0007D4F4
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

		// Token: 0x04002993 RID: 10643
		private static readonly MessageParser<BlackboardParam> _parser = new MessageParser<BlackboardParam>(() => new BlackboardParam());

		// Token: 0x04002994 RID: 10644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002995 RID: 10645
		public const int KeyFieldNumber = 1;

		// Token: 0x04002996 RID: 10646
		private string key_ = "";

		// Token: 0x04002997 RID: 10647
		public const int TypeFieldNumber = 2;

		// Token: 0x04002998 RID: 10648
		private BlackboardParamType type_;

		// Token: 0x04002999 RID: 10649
		public const int IntValueFieldNumber = 3;

		// Token: 0x0400299A RID: 10650
		public const int IntValuesFieldNumber = 4;

		// Token: 0x0400299B RID: 10651
		public const int LongValueFieldNumber = 5;

		// Token: 0x0400299C RID: 10652
		public const int LongValuesFieldNumber = 6;

		// Token: 0x0400299D RID: 10653
		public const int BooleanValueFieldNumber = 7;

		// Token: 0x0400299E RID: 10654
		public const int StringValueFieldNumber = 8;

		// Token: 0x0400299F RID: 10655
		public const int StringValuesFieldNumber = 9;

		// Token: 0x040029A0 RID: 10656
		public const int FloatValueFieldNumber = 10;

		// Token: 0x040029A1 RID: 10657
		public const int FloatValuesFieldNumber = 11;

		// Token: 0x040029A2 RID: 10658
		public const int VectorValueFieldNumber = 12;

		// Token: 0x040029A3 RID: 10659
		public const int VectorValuesFieldNumber = 13;

		// Token: 0x040029A4 RID: 10660
		public const int RotatorValueFieldNumber = 14;

		// Token: 0x040029A5 RID: 10661
		public const int RotatorValuesFieldNumber = 15;

		// Token: 0x040029A6 RID: 10662
		private object value_;

		// Token: 0x040029A7 RID: 10663
		private BlackboardParam.ValueOneofCase valueCase_;

		// Token: 0x02001774 RID: 6004
		public enum ValueOneofCase
		{
			// Token: 0x0400CA6B RID: 51819
			None,
			// Token: 0x0400CA6C RID: 51820
			IntValue = 3,
			// Token: 0x0400CA6D RID: 51821
			IntValues,
			// Token: 0x0400CA6E RID: 51822
			LongValue,
			// Token: 0x0400CA6F RID: 51823
			LongValues,
			// Token: 0x0400CA70 RID: 51824
			BooleanValue,
			// Token: 0x0400CA71 RID: 51825
			StringValue,
			// Token: 0x0400CA72 RID: 51826
			StringValues,
			// Token: 0x0400CA73 RID: 51827
			FloatValue,
			// Token: 0x0400CA74 RID: 51828
			FloatValues,
			// Token: 0x0400CA75 RID: 51829
			VectorValue,
			// Token: 0x0400CA76 RID: 51830
			VectorValues,
			// Token: 0x0400CA77 RID: 51831
			RotatorValue,
			// Token: 0x0400CA78 RID: 51832
			RotatorValues
		}
	}
}
