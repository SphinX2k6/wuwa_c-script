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
		// Token: 0x060022E1 RID: 8929 RVA: 0x0005D0A1 File Offset: 0x0005B2A1
		[NullableContext(1)]
		public static AnimationStateInitNotify Create()
		{
			return new AnimationStateInitNotify();
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x0005D0A8 File Offset: 0x0005B2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0005D0AB File Offset: 0x0005B2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitNotify.Descriptor;
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0005D0B2 File Offset: 0x0005B2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify()
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0005D0D0 File Offset: 0x0005B2D0
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

		// Token: 0x060022E6 RID: 8934 RVA: 0x0005D156 File Offset: 0x0005B356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitNotify Clone()
		{
			return new AnimationStateInitNotify(this);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x0005D15E File Offset: 0x0005B35E
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x0005D166 File Offset: 0x0005B366
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0005D16F File Offset: 0x0005B36F
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x0005D177 File Offset: 0x0005B377
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x0005D180 File Offset: 0x0005B380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0005D188 File Offset: 0x0005B388
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0005D190 File Offset: 0x0005B390
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0005D199 File Offset: 0x0005B399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x0005D1A1 File Offset: 0x0005B3A1
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x0005D1A9 File Offset: 0x0005B3A9
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

		// Token: 0x060022F1 RID: 8945 RVA: 0x0005D1B2 File Offset: 0x0005B3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitNotify);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0005D264 File Offset: 0x0005B464
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

		// Token: 0x060022F4 RID: 8948 RVA: 0x0005D30E File Offset: 0x0005B50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0005D31B File Offset: 0x0005B51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0005D324 File Offset: 0x0005B524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.ModelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ModelId);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateInitNotify._repeated_specialStates_codec);
			this.states_.WriteTo(ref output, AnimationStateInitNotify._repeated_states_codec);
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0005D3DC File Offset: 0x0005B5DC
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

		// Token: 0x060022F8 RID: 8952 RVA: 0x0005D484 File Offset: 0x0005B684
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

		// Token: 0x060022F9 RID: 8953 RVA: 0x0005D53B File Offset: 0x0005B73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0005D544 File Offset: 0x0005B744
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
					if (num <= 32U)
					{
						if (num == 13U)
						{
							this.TimeStamp = input.ReadFloat();
							continue;
						}
						if (num == 32U)
						{
							this.ModelId = input.ReadInt32();
							continue;
						}
					}
					else if (num == 40U || num == 42U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitNotify._repeated_specialStates_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.states_.AddEntriesFrom(ref input, AnimationStateInitNotify._repeated_states_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002500 RID: 9472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002501 RID: 9473
		public const int CombatCommonFieldNumber = 12;

		// Token: 0x04002502 RID: 9474
		private CombatCommon combatCommon_;

		// Token: 0x04002503 RID: 9475
		public const int IdFieldNumber = 14;

		// Token: 0x04002504 RID: 9476
		private long id_;

		// Token: 0x04002505 RID: 9477
		public const int StatesFieldNumber = 11;

		// Token: 0x04002506 RID: 9478
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002507 RID: 9479
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x04002508 RID: 9480
		public const int TimeStampFieldNumber = 1;

		// Token: 0x04002509 RID: 9481
		private float timeStamp_;

		// Token: 0x0400250A RID: 9482
		public const int SpecialStatesFieldNumber = 5;

		// Token: 0x0400250B RID: 9483
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400250C RID: 9484
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x0400250D RID: 9485
		public const int ModelIdFieldNumber = 4;

		// Token: 0x0400250E RID: 9486
		private int modelId_;
	}
}
