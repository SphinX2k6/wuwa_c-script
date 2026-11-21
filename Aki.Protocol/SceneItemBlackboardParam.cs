using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119C RID: 4508
	public sealed class SceneItemBlackboardParam : IMessage<SceneItemBlackboardParam>, IMessage, IEquatable<SceneItemBlackboardParam>, IDeepCloneable<SceneItemBlackboardParam>, IBufferMessage
	{
		// Token: 0x06018130 RID: 98608 RVA: 0x0038132F File Offset: 0x0037F52F
		[NullableContext(1)]
		public static SceneItemBlackboardParam Create()
		{
			return new SceneItemBlackboardParam();
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x06018131 RID: 98609 RVA: 0x00381336 File Offset: 0x0037F536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneItemBlackboardParam> Parser
		{
			get
			{
				return SceneItemBlackboardParam._parser;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x06018132 RID: 98610 RVA: 0x0038133D File Offset: 0x0037F53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x06018133 RID: 98611 RVA: 0x00381340 File Offset: 0x0037F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemBlackboardParam.Descriptor;
			}
		}

		// Token: 0x06018134 RID: 98612 RVA: 0x00381347 File Offset: 0x0037F547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam()
		{
		}

		// Token: 0x06018135 RID: 98613 RVA: 0x00381350 File Offset: 0x0037F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam(SceneItemBlackboardParam other) : this()
		{
			this.key_ = other.key_;
			switch (other.ValueCase)
			{
			case SceneItemBlackboardParam.ValueOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.IntValues:
				this.IntValues = other.IntValues.Clone();
				break;
			case SceneItemBlackboardParam.ValueOneofCase.LongValue:
				this.LongValue = other.LongValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.LongValues:
				this.LongValues = other.LongValues.Clone();
				break;
			case SceneItemBlackboardParam.ValueOneofCase.BooleanValue:
				this.BooleanValue = other.BooleanValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.FloatValue:
				this.FloatValue = other.FloatValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.FloatValues:
				this.FloatValues = other.FloatValues.Clone();
				break;
			case SceneItemBlackboardParam.ValueOneofCase.VectorValue:
				this.VectorValue = other.VectorValue.Clone();
				break;
			case SceneItemBlackboardParam.ValueOneofCase.RotatorValue:
				this.RotatorValue = other.RotatorValue.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018136 RID: 98614 RVA: 0x00381469 File Offset: 0x0037F669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam Clone()
		{
			return new SceneItemBlackboardParam(this);
		}

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x06018137 RID: 98615 RVA: 0x00381471 File Offset: 0x0037F671
		// (set) Token: 0x06018138 RID: 98616 RVA: 0x00381479 File Offset: 0x0037F679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBBKey Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x06018139 RID: 98617 RVA: 0x00381482 File Offset: 0x0037F682
		// (set) Token: 0x0601813A RID: 98618 RVA: 0x00381499 File Offset: 0x0037F699
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
				this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x0601813B RID: 98619 RVA: 0x003814AE File Offset: 0x0037F6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIntValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x0601813C RID: 98620 RVA: 0x003814B9 File Offset: 0x0037F6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIntValue()
		{
			if (this.HasIntValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x0601813D RID: 98621 RVA: 0x003814C9 File Offset: 0x0037F6C9
		// (set) Token: 0x0601813E RID: 98622 RVA: 0x003814E1 File Offset: 0x0037F6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntArrayBlackboard IntValues
		{
			get
			{
				if (this.valueCase_ != SceneItemBlackboardParam.ValueOneofCase.IntValues)
				{
					return null;
				}
				return (IntArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? SceneItemBlackboardParam.ValueOneofCase.None : SceneItemBlackboardParam.ValueOneofCase.IntValues);
			}
		}

		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x0601813F RID: 98623 RVA: 0x003814F7 File Offset: 0x0037F6F7
		// (set) Token: 0x06018140 RID: 98624 RVA: 0x0038150F File Offset: 0x0037F70F
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
				this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x06018141 RID: 98625 RVA: 0x00381524 File Offset: 0x0037F724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLongValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x06018142 RID: 98626 RVA: 0x0038152F File Offset: 0x0037F72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLongValue()
		{
			if (this.HasLongValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x06018143 RID: 98627 RVA: 0x0038153F File Offset: 0x0037F73F
		// (set) Token: 0x06018144 RID: 98628 RVA: 0x00381557 File Offset: 0x0037F757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongArrayBlackboard LongValues
		{
			get
			{
				if (this.valueCase_ != SceneItemBlackboardParam.ValueOneofCase.LongValues)
				{
					return null;
				}
				return (LongArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? SceneItemBlackboardParam.ValueOneofCase.None : SceneItemBlackboardParam.ValueOneofCase.LongValues);
			}
		}

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x06018145 RID: 98629 RVA: 0x0038156D File Offset: 0x0037F76D
		// (set) Token: 0x06018146 RID: 98630 RVA: 0x00381584 File Offset: 0x0037F784
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
				this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x06018147 RID: 98631 RVA: 0x00381599 File Offset: 0x0037F799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBooleanValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x06018148 RID: 98632 RVA: 0x003815A4 File Offset: 0x0037F7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBooleanValue()
		{
			if (this.HasBooleanValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x06018149 RID: 98633 RVA: 0x003815B4 File Offset: 0x0037F7B4
		// (set) Token: 0x0601814A RID: 98634 RVA: 0x003815CF File Offset: 0x0037F7CF
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
				this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x0601814B RID: 98635 RVA: 0x003815E9 File Offset: 0x0037F7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x0601814C RID: 98636 RVA: 0x003815F4 File Offset: 0x0037F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x0601814D RID: 98637 RVA: 0x00381604 File Offset: 0x0037F804
		// (set) Token: 0x0601814E RID: 98638 RVA: 0x0038161F File Offset: 0x0037F81F
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
				this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x0601814F RID: 98639 RVA: 0x00381635 File Offset: 0x0037F835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloatValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x06018150 RID: 98640 RVA: 0x00381641 File Offset: 0x0037F841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloatValue()
		{
			if (this.HasFloatValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x06018151 RID: 98641 RVA: 0x00381651 File Offset: 0x0037F851
		// (set) Token: 0x06018152 RID: 98642 RVA: 0x0038166A File Offset: 0x0037F86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatArrayBlackboard FloatValues
		{
			get
			{
				if (this.valueCase_ != SceneItemBlackboardParam.ValueOneofCase.FloatValues)
				{
					return null;
				}
				return (FloatArrayBlackboard)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? SceneItemBlackboardParam.ValueOneofCase.None : SceneItemBlackboardParam.ValueOneofCase.FloatValues);
			}
		}

		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x06018153 RID: 98643 RVA: 0x00381681 File Offset: 0x0037F881
		// (set) Token: 0x06018154 RID: 98644 RVA: 0x0038169A File Offset: 0x0037F89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector VectorValue
		{
			get
			{
				if (this.valueCase_ != SceneItemBlackboardParam.ValueOneofCase.VectorValue)
				{
					return null;
				}
				return (Vector)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? SceneItemBlackboardParam.ValueOneofCase.None : SceneItemBlackboardParam.ValueOneofCase.VectorValue);
			}
		}

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x06018155 RID: 98645 RVA: 0x003816B1 File Offset: 0x0037F8B1
		// (set) Token: 0x06018156 RID: 98646 RVA: 0x003816CA File Offset: 0x0037F8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator RotatorValue
		{
			get
			{
				if (this.valueCase_ != SceneItemBlackboardParam.ValueOneofCase.RotatorValue)
				{
					return null;
				}
				return (Rotator)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? SceneItemBlackboardParam.ValueOneofCase.None : SceneItemBlackboardParam.ValueOneofCase.RotatorValue);
			}
		}

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x06018157 RID: 98647 RVA: 0x003816E1 File Offset: 0x0037F8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x06018158 RID: 98648 RVA: 0x003816E9 File Offset: 0x0037F8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x06018159 RID: 98649 RVA: 0x003816F9 File Offset: 0x0037F8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemBlackboardParam);
		}

		// Token: 0x0601815A RID: 98650 RVA: 0x00381708 File Offset: 0x0037F908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemBlackboardParam other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.IntValue == other.IntValue && object.Equals(this.IntValues, other.IntValues) && this.LongValue == other.LongValue && object.Equals(this.LongValues, other.LongValues) && this.BooleanValue == other.BooleanValue && !(this.StringValue != other.StringValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FloatValue, other.FloatValue) && object.Equals(this.FloatValues, other.FloatValues) && object.Equals(this.VectorValue, other.VectorValue) && object.Equals(this.RotatorValue, other.RotatorValue) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601815B RID: 98651 RVA: 0x0038181C File Offset: 0x0037FA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != SceneItemBBKey.ManipulatableState)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.HasIntValue)
			{
				num ^= this.IntValue.GetHashCode();
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValues)
			{
				num ^= this.IntValues.GetHashCode();
			}
			if (this.HasLongValue)
			{
				num ^= this.LongValue.GetHashCode();
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValues)
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
			if (this.HasFloatValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FloatValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValues)
			{
				num ^= this.FloatValues.GetHashCode();
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.VectorValue)
			{
				num ^= this.VectorValue.GetHashCode();
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.RotatorValue)
			{
				num ^= this.RotatorValue.GetHashCode();
			}
			num ^= (int)this.valueCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601815C RID: 98652 RVA: 0x0038195D File Offset: 0x0037FB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601815D RID: 98653 RVA: 0x0038196A File Offset: 0x0037FB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601815E RID: 98654 RVA: 0x00381974 File Offset: 0x0037FB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != SceneItemBBKey.ManipulatableState)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Key);
			}
			if (this.HasIntValue)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IntValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValues)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.IntValues);
			}
			if (this.HasLongValue)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LongValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValues)
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
			if (this.HasFloatValue)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.FloatValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValues)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.FloatValues);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.VectorValue)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.VectorValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.RotatorValue)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RotatorValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601815F RID: 98655 RVA: 0x00381AD0 File Offset: 0x0037FCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != SceneItemBBKey.ManipulatableState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Key);
			}
			if (this.HasIntValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IntValues);
			}
			if (this.HasLongValue)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LongValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValues)
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
			if (this.HasFloatValue)
			{
				num += 5;
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValues)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FloatValues);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.VectorValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VectorValue);
			}
			if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.RotatorValue)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotatorValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018160 RID: 98656 RVA: 0x00381BF0 File Offset: 0x0037FDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemBlackboardParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != SceneItemBBKey.ManipulatableState)
			{
				this.Key = other.Key;
			}
			switch (other.ValueCase)
			{
			case SceneItemBlackboardParam.ValueOneofCase.IntValue:
				this.IntValue = other.IntValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.IntValues:
				if (this.IntValues == null)
				{
					this.IntValues = new IntArrayBlackboard();
				}
				this.IntValues.MergeFrom(other.IntValues);
				break;
			case SceneItemBlackboardParam.ValueOneofCase.LongValue:
				this.LongValue = other.LongValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.LongValues:
				if (this.LongValues == null)
				{
					this.LongValues = new LongArrayBlackboard();
				}
				this.LongValues.MergeFrom(other.LongValues);
				break;
			case SceneItemBlackboardParam.ValueOneofCase.BooleanValue:
				this.BooleanValue = other.BooleanValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.StringValue:
				this.StringValue = other.StringValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.FloatValue:
				this.FloatValue = other.FloatValue;
				break;
			case SceneItemBlackboardParam.ValueOneofCase.FloatValues:
				if (this.FloatValues == null)
				{
					this.FloatValues = new FloatArrayBlackboard();
				}
				this.FloatValues.MergeFrom(other.FloatValues);
				break;
			case SceneItemBlackboardParam.ValueOneofCase.VectorValue:
				if (this.VectorValue == null)
				{
					this.VectorValue = new Vector();
				}
				this.VectorValue.MergeFrom(other.VectorValue);
				break;
			case SceneItemBlackboardParam.ValueOneofCase.RotatorValue:
				if (this.RotatorValue == null)
				{
					this.RotatorValue = new Rotator();
				}
				this.RotatorValue.MergeFrom(other.RotatorValue);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018161 RID: 98657 RVA: 0x00381D7D File Offset: 0x0037FF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018162 RID: 98658 RVA: 0x00381D88 File Offset: 0x0037FF88
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
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Key = (SceneItemBBKey)input.ReadEnum();
							continue;
						}
						if (num == 24U)
						{
							this.IntValue = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							IntArrayBlackboard intArrayBlackboard = new IntArrayBlackboard();
							if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValues)
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
						if (num == 50U)
						{
							LongArrayBlackboard longArrayBlackboard = new LongArrayBlackboard();
							if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValues)
							{
								longArrayBlackboard.MergeFrom(this.LongValues);
							}
							input.ReadMessage(longArrayBlackboard);
							this.LongValues = longArrayBlackboard;
							continue;
						}
					}
				}
				else if (num <= 85U)
				{
					if (num == 56U)
					{
						this.BooleanValue = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.StringValue = input.ReadString();
						continue;
					}
					if (num == 85U)
					{
						this.FloatValue = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						FloatArrayBlackboard floatArrayBlackboard = new FloatArrayBlackboard();
						if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValues)
						{
							floatArrayBlackboard.MergeFrom(this.FloatValues);
						}
						input.ReadMessage(floatArrayBlackboard);
						this.FloatValues = floatArrayBlackboard;
						continue;
					}
					if (num == 98U)
					{
						Vector vector = new Vector();
						if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.VectorValue)
						{
							vector.MergeFrom(this.VectorValue);
						}
						input.ReadMessage(vector);
						this.VectorValue = vector;
						continue;
					}
					if (num == 106U)
					{
						Rotator rotator = new Rotator();
						if (this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.RotatorValue)
						{
							rotator.MergeFrom(this.RotatorValue);
						}
						input.ReadMessage(rotator);
						this.RotatorValue = rotator;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F6A RID: 36714
		private static readonly MessageParser<SceneItemBlackboardParam> _parser = new MessageParser<SceneItemBlackboardParam>(() => new SceneItemBlackboardParam());

		// Token: 0x04008F6B RID: 36715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F6C RID: 36716
		public const int KeyFieldNumber = 1;

		// Token: 0x04008F6D RID: 36717
		private SceneItemBBKey key_;

		// Token: 0x04008F6E RID: 36718
		public const int IntValueFieldNumber = 3;

		// Token: 0x04008F6F RID: 36719
		public const int IntValuesFieldNumber = 4;

		// Token: 0x04008F70 RID: 36720
		public const int LongValueFieldNumber = 5;

		// Token: 0x04008F71 RID: 36721
		public const int LongValuesFieldNumber = 6;

		// Token: 0x04008F72 RID: 36722
		public const int BooleanValueFieldNumber = 7;

		// Token: 0x04008F73 RID: 36723
		public const int StringValueFieldNumber = 8;

		// Token: 0x04008F74 RID: 36724
		public const int FloatValueFieldNumber = 10;

		// Token: 0x04008F75 RID: 36725
		public const int FloatValuesFieldNumber = 11;

		// Token: 0x04008F76 RID: 36726
		public const int VectorValueFieldNumber = 12;

		// Token: 0x04008F77 RID: 36727
		public const int RotatorValueFieldNumber = 13;

		// Token: 0x04008F78 RID: 36728
		private object value_;

		// Token: 0x04008F79 RID: 36729
		private SceneItemBlackboardParam.ValueOneofCase valueCase_;

		// Token: 0x02001A02 RID: 6658
		public enum ValueOneofCase
		{
			// Token: 0x0400CF29 RID: 53033
			None,
			// Token: 0x0400CF2A RID: 53034
			IntValue = 3,
			// Token: 0x0400CF2B RID: 53035
			IntValues,
			// Token: 0x0400CF2C RID: 53036
			LongValue,
			// Token: 0x0400CF2D RID: 53037
			LongValues,
			// Token: 0x0400CF2E RID: 53038
			BooleanValue,
			// Token: 0x0400CF2F RID: 53039
			StringValue,
			// Token: 0x0400CF30 RID: 53040
			FloatValue = 10,
			// Token: 0x0400CF31 RID: 53041
			FloatValues,
			// Token: 0x0400CF32 RID: 53042
			VectorValue,
			// Token: 0x0400CF33 RID: 53043
			RotatorValue
		}
	}
}
