using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001162 RID: 4450
	public sealed class SceneItemBlackboardParam : IMessage<SceneItemBlackboardParam>, IMessage, IEquatable<SceneItemBlackboardParam>, IDeepCloneable<SceneItemBlackboardParam>, IBufferMessage
	{
		// Token: 0x06017B8F RID: 97167 RVA: 0x00371FDF File Offset: 0x003701DF
		[NullableContext(1)]
		public static SceneItemBlackboardParam Create()
		{
			return new SceneItemBlackboardParam();
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x06017B90 RID: 97168 RVA: 0x00371FE6 File Offset: 0x003701E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneItemBlackboardParam> Parser
		{
			get
			{
				return SceneItemBlackboardParam._parser;
			}
		}

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x06017B91 RID: 97169 RVA: 0x00371FED File Offset: 0x003701ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x06017B92 RID: 97170 RVA: 0x00371FF0 File Offset: 0x003701F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemBlackboardParam.Descriptor;
			}
		}

		// Token: 0x06017B93 RID: 97171 RVA: 0x00371FF7 File Offset: 0x003701F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam()
		{
		}

		// Token: 0x06017B94 RID: 97172 RVA: 0x00372000 File Offset: 0x00370200
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

		// Token: 0x06017B95 RID: 97173 RVA: 0x00372119 File Offset: 0x00370319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam Clone()
		{
			return new SceneItemBlackboardParam(this);
		}

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x06017B96 RID: 97174 RVA: 0x00372121 File Offset: 0x00370321
		// (set) Token: 0x06017B97 RID: 97175 RVA: 0x00372129 File Offset: 0x00370329
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

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x06017B98 RID: 97176 RVA: 0x00372132 File Offset: 0x00370332
		// (set) Token: 0x06017B99 RID: 97177 RVA: 0x00372149 File Offset: 0x00370349
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

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x06017B9A RID: 97178 RVA: 0x0037215E File Offset: 0x0037035E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIntValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.IntValue;
			}
		}

		// Token: 0x06017B9B RID: 97179 RVA: 0x00372169 File Offset: 0x00370369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIntValue()
		{
			if (this.HasIntValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x06017B9C RID: 97180 RVA: 0x00372179 File Offset: 0x00370379
		// (set) Token: 0x06017B9D RID: 97181 RVA: 0x00372191 File Offset: 0x00370391
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

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x06017B9E RID: 97182 RVA: 0x003721A7 File Offset: 0x003703A7
		// (set) Token: 0x06017B9F RID: 97183 RVA: 0x003721BF File Offset: 0x003703BF
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

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x06017BA0 RID: 97184 RVA: 0x003721D4 File Offset: 0x003703D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLongValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.LongValue;
			}
		}

		// Token: 0x06017BA1 RID: 97185 RVA: 0x003721DF File Offset: 0x003703DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLongValue()
		{
			if (this.HasLongValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06017BA2 RID: 97186 RVA: 0x003721EF File Offset: 0x003703EF
		// (set) Token: 0x06017BA3 RID: 97187 RVA: 0x00372207 File Offset: 0x00370407
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

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06017BA4 RID: 97188 RVA: 0x0037221D File Offset: 0x0037041D
		// (set) Token: 0x06017BA5 RID: 97189 RVA: 0x00372234 File Offset: 0x00370434
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

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06017BA6 RID: 97190 RVA: 0x00372249 File Offset: 0x00370449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBooleanValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.BooleanValue;
			}
		}

		// Token: 0x06017BA7 RID: 97191 RVA: 0x00372254 File Offset: 0x00370454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBooleanValue()
		{
			if (this.HasBooleanValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06017BA8 RID: 97192 RVA: 0x00372264 File Offset: 0x00370464
		// (set) Token: 0x06017BA9 RID: 97193 RVA: 0x0037227F File Offset: 0x0037047F
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

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x06017BAA RID: 97194 RVA: 0x00372299 File Offset: 0x00370499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.StringValue;
			}
		}

		// Token: 0x06017BAB RID: 97195 RVA: 0x003722A4 File Offset: 0x003704A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue()
		{
			if (this.HasStringValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06017BAC RID: 97196 RVA: 0x003722B4 File Offset: 0x003704B4
		// (set) Token: 0x06017BAD RID: 97197 RVA: 0x003722CF File Offset: 0x003704CF
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

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06017BAE RID: 97198 RVA: 0x003722E5 File Offset: 0x003704E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloatValue
		{
			get
			{
				return this.valueCase_ == SceneItemBlackboardParam.ValueOneofCase.FloatValue;
			}
		}

		// Token: 0x06017BAF RID: 97199 RVA: 0x003722F1 File Offset: 0x003704F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloatValue()
		{
			if (this.HasFloatValue)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06017BB0 RID: 97200 RVA: 0x00372301 File Offset: 0x00370501
		// (set) Token: 0x06017BB1 RID: 97201 RVA: 0x0037231A File Offset: 0x0037051A
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

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06017BB2 RID: 97202 RVA: 0x00372331 File Offset: 0x00370531
		// (set) Token: 0x06017BB3 RID: 97203 RVA: 0x0037234A File Offset: 0x0037054A
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

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06017BB4 RID: 97204 RVA: 0x00372361 File Offset: 0x00370561
		// (set) Token: 0x06017BB5 RID: 97205 RVA: 0x0037237A File Offset: 0x0037057A
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

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06017BB6 RID: 97206 RVA: 0x00372391 File Offset: 0x00370591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemBlackboardParam.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x06017BB7 RID: 97207 RVA: 0x00372399 File Offset: 0x00370599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = SceneItemBlackboardParam.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x06017BB8 RID: 97208 RVA: 0x003723A9 File Offset: 0x003705A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemBlackboardParam);
		}

		// Token: 0x06017BB9 RID: 97209 RVA: 0x003723B8 File Offset: 0x003705B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemBlackboardParam other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.IntValue == other.IntValue && object.Equals(this.IntValues, other.IntValues) && this.LongValue == other.LongValue && object.Equals(this.LongValues, other.LongValues) && this.BooleanValue == other.BooleanValue && !(this.StringValue != other.StringValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FloatValue, other.FloatValue) && object.Equals(this.FloatValues, other.FloatValues) && object.Equals(this.VectorValue, other.VectorValue) && object.Equals(this.RotatorValue, other.RotatorValue) && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BBA RID: 97210 RVA: 0x003724CC File Offset: 0x003706CC
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

		// Token: 0x06017BBB RID: 97211 RVA: 0x0037260D File Offset: 0x0037080D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BBC RID: 97212 RVA: 0x0037261A File Offset: 0x0037081A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BBD RID: 97213 RVA: 0x00372624 File Offset: 0x00370824
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

		// Token: 0x06017BBE RID: 97214 RVA: 0x00372780 File Offset: 0x00370980
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

		// Token: 0x06017BBF RID: 97215 RVA: 0x003728A0 File Offset: 0x00370AA0
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

		// Token: 0x06017BC0 RID: 97216 RVA: 0x00372A2D File Offset: 0x00370C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BC1 RID: 97217 RVA: 0x00372A38 File Offset: 0x00370C38
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

		// Token: 0x04008CD7 RID: 36055
		private static readonly MessageParser<SceneItemBlackboardParam> _parser = new MessageParser<SceneItemBlackboardParam>(() => new SceneItemBlackboardParam());

		// Token: 0x04008CD8 RID: 36056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CD9 RID: 36057
		public const int KeyFieldNumber = 1;

		// Token: 0x04008CDA RID: 36058
		private SceneItemBBKey key_;

		// Token: 0x04008CDB RID: 36059
		public const int IntValueFieldNumber = 3;

		// Token: 0x04008CDC RID: 36060
		public const int IntValuesFieldNumber = 4;

		// Token: 0x04008CDD RID: 36061
		public const int LongValueFieldNumber = 5;

		// Token: 0x04008CDE RID: 36062
		public const int LongValuesFieldNumber = 6;

		// Token: 0x04008CDF RID: 36063
		public const int BooleanValueFieldNumber = 7;

		// Token: 0x04008CE0 RID: 36064
		public const int StringValueFieldNumber = 8;

		// Token: 0x04008CE1 RID: 36065
		public const int FloatValueFieldNumber = 10;

		// Token: 0x04008CE2 RID: 36066
		public const int FloatValuesFieldNumber = 11;

		// Token: 0x04008CE3 RID: 36067
		public const int VectorValueFieldNumber = 12;

		// Token: 0x04008CE4 RID: 36068
		public const int RotatorValueFieldNumber = 13;

		// Token: 0x04008CE5 RID: 36069
		private object value_;

		// Token: 0x04008CE6 RID: 36070
		private SceneItemBlackboardParam.ValueOneofCase valueCase_;

		// Token: 0x02001976 RID: 6518
		public enum ValueOneofCase
		{
			// Token: 0x0400C9DE RID: 51678
			None,
			// Token: 0x0400C9DF RID: 51679
			IntValue = 3,
			// Token: 0x0400C9E0 RID: 51680
			IntValues,
			// Token: 0x0400C9E1 RID: 51681
			LongValue,
			// Token: 0x0400C9E2 RID: 51682
			LongValues,
			// Token: 0x0400C9E3 RID: 51683
			BooleanValue,
			// Token: 0x0400C9E4 RID: 51684
			StringValue,
			// Token: 0x0400C9E5 RID: 51685
			FloatValue = 10,
			// Token: 0x0400C9E6 RID: 51686
			FloatValues,
			// Token: 0x0400C9E7 RID: 51687
			VectorValue,
			// Token: 0x0400C9E8 RID: 51688
			RotatorValue
		}
	}
}
