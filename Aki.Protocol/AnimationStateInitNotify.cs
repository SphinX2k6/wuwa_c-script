using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F2 RID: 242
	[NetMessage(EMessageId.AnimationStateInitNotify)]
	public sealed class AnimationStateInitNotify : IMessage<AnimationStateInitNotify>, IMessage, IEquatable<AnimationStateInitNotify>, IDeepCloneable<AnimationStateInitNotify>, IBufferMessage
	{
		// Token: 0x060022AA RID: 8874 RVA: 0x0005C5D5 File Offset: 0x0005A7D5
		[NullableContext(1)]
		public static AnimationStateInitNotify Create()
		{
			return new AnimationStateInitNotify();
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0005C5DF File Offset: 0x0005A7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitNotify.Descriptor;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0005C5E6 File Offset: 0x0005A7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify()
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0005C604 File Offset: 0x0005A804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify(AnimationStateInitNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.timeStamp_ = other.timeStamp_;
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0005C68A File Offset: 0x0005A88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify Clone()
		{
			return new AnimationStateInitNotify(this);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0005C692 File Offset: 0x0005A892
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0005C69A File Offset: 0x0005A89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0005C6A3 File Offset: 0x0005A8A3
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0005C6AB File Offset: 0x0005A8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0005C6B4 File Offset: 0x0005A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0005C6C4 File Offset: 0x0005A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0005C6CD File Offset: 0x0005A8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0005C6D5 File Offset: 0x0005A8D5
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0005C6DD File Offset: 0x0005A8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModelId
		{
			get
			{
				return this.modelId_;
			}
			set
			{
				this.modelId_ = value;
			}
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0005C6E6 File Offset: 0x0005A8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitNotify);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0005C6F4 File Offset: 0x0005A8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0005C798 File Offset: 0x0005A998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.states_.GetHashCode();
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			num ^= this.specialStates_.GetHashCode();
			if (this.ModelId != 0)
			{
				num ^= this.ModelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0005C842 File Offset: 0x0005AA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0005C84F File Offset: 0x0005AA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0005C858 File Offset: 0x0005AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.states_.WriteTo(ref output, AnimationStateInitNotify._repeated_states_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ModelId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateInitNotify._repeated_specialStates_codec);
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.TimeStamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0005C910 File Offset: 0x0005AB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.states_.CalculateSize(AnimationStateInitNotify._repeated_states_codec);
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			num += this.specialStates_.CalculateSize(AnimationStateInitNotify._repeated_specialStates_codec);
			if (this.ModelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0005C9B8 File Offset: 0x0005ABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.states_.Add(other.states_);
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			this.specialStates_.Add(other.specialStates_);
			if (other.ModelId != 0)
			{
				this.ModelId = other.ModelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0005CA6F File Offset: 0x0005AC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0005CA78 File Offset: 0x0005AC78
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
				if (num > 50U)
				{
					if (num <= 96U)
					{
						if (num == 64U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num != 96U)
						{
							goto IL_48;
						}
					}
					else if (num != 98U)
					{
						if (num != 125U)
						{
							goto IL_48;
						}
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitNotify._repeated_specialStates_codec);
					continue;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.states_.AddEntriesFrom(ref input, AnimationStateInitNotify._repeated_states_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				IL_48:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024A1 RID: 9377
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024A2 RID: 9378
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x040024A3 RID: 9379
		private CombatCommon combatCommon_;

		// Token: 0x040024A4 RID: 9380
		public const int IdFieldNumber = 8;

		// Token: 0x040024A5 RID: 9381
		private long id_;

		// Token: 0x040024A6 RID: 9382
		public const int StatesFieldNumber = 1;

		// Token: 0x040024A7 RID: 9383
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040024A8 RID: 9384
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024A9 RID: 9385
		public const int TimeStampFieldNumber = 15;

		// Token: 0x040024AA RID: 9386
		private float timeStamp_;

		// Token: 0x040024AB RID: 9387
		public const int SpecialStatesFieldNumber = 12;

		// Token: 0x040024AC RID: 9388
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040024AD RID: 9389
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024AE RID: 9390
		public const int ModelIdFieldNumber = 4;

		// Token: 0x040024AF RID: 9391
		private int modelId_;
	}
}
