using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000ED RID: 237
	[NetMessage(EMessageId.AnimationStateChangedNotify)]
	public sealed class AnimationStateChangedNotify : IMessage<AnimationStateChangedNotify>, IMessage, IEquatable<AnimationStateChangedNotify>, IDeepCloneable<AnimationStateChangedNotify>, IBufferMessage
	{
		// Token: 0x06002234 RID: 8756 RVA: 0x0005AFC1 File Offset: 0x000591C1
		[NullableContext(1)]
		public static AnimationStateChangedNotify Create()
		{
			return new AnimationStateChangedNotify();
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x0005AFC8 File Offset: 0x000591C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0005AFCB File Offset: 0x000591CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedNotify.Descriptor;
			}
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0005AFD2 File Offset: 0x000591D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify()
		{
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0005AFF0 File Offset: 0x000591F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify(AnimationStateChangedNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.timeStamp_ = other.timeStamp_;
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0005B076 File Offset: 0x00059276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify Clone()
		{
			return new AnimationStateChangedNotify(this);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0005B07E File Offset: 0x0005927E
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x0005B086 File Offset: 0x00059286
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0005B08F File Offset: 0x0005928F
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0005B097 File Offset: 0x00059297
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0005B0A0 File Offset: 0x000592A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0005B0A8 File Offset: 0x000592A8
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x0005B0B0 File Offset: 0x000592B0
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x0005B0B9 File Offset: 0x000592B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0005B0C1 File Offset: 0x000592C1
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x0005B0C9 File Offset: 0x000592C9
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

		// Token: 0x06002244 RID: 8772 RVA: 0x0005B0D2 File Offset: 0x000592D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedNotify);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0005B0E0 File Offset: 0x000592E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0005B184 File Offset: 0x00059384
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

		// Token: 0x06002247 RID: 8775 RVA: 0x0005B22E File Offset: 0x0005942E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0005B23B File Offset: 0x0005943B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0005B244 File Offset: 0x00059444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateChangedNotify._repeated_specialStates_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.TimeStamp);
			}
			this.states_.WriteTo(ref output, AnimationStateChangedNotify._repeated_states_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0005B2FC File Offset: 0x000594FC
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
			num += this.states_.CalculateSize(AnimationStateChangedNotify._repeated_states_codec);
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			num += this.specialStates_.CalculateSize(AnimationStateChangedNotify._repeated_specialStates_codec);
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

		// Token: 0x0600224B RID: 8779 RVA: 0x0005B3A4 File Offset: 0x000595A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateChangedNotify other)
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

		// Token: 0x0600224C RID: 8780 RVA: 0x0005B45B File Offset: 0x0005965B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0005B464 File Offset: 0x00059664
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
				if (num <= 72U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
						if (num != 16U)
						{
							goto IL_49;
						}
					}
					else if (num != 18U)
					{
						if (num != 72U)
						{
							goto IL_49;
						}
						this.Id = input.ReadInt64();
						continue;
					}
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedNotify._repeated_specialStates_codec);
					continue;
				}
				if (num <= 96U)
				{
					if (num == 85U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num != 96U)
					{
						goto IL_49;
					}
				}
				else if (num != 98U)
				{
					if (num != 112U)
					{
						goto IL_49;
					}
					this.ModelId = input.ReadInt32();
					continue;
				}
				this.states_.AddEntriesFrom(ref input, AnimationStateChangedNotify._repeated_states_codec);
				continue;
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002466 RID: 9318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002467 RID: 9319
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x04002468 RID: 9320
		private CombatCommon combatCommon_;

		// Token: 0x04002469 RID: 9321
		public const int IdFieldNumber = 9;

		// Token: 0x0400246A RID: 9322
		private long id_;

		// Token: 0x0400246B RID: 9323
		public const int StatesFieldNumber = 12;

		// Token: 0x0400246C RID: 9324
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400246D RID: 9325
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x0400246E RID: 9326
		public const int TimeStampFieldNumber = 10;

		// Token: 0x0400246F RID: 9327
		private float timeStamp_;

		// Token: 0x04002470 RID: 9328
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x04002471 RID: 9329
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002472 RID: 9330
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x04002473 RID: 9331
		public const int ModelIdFieldNumber = 14;

		// Token: 0x04002474 RID: 9332
		private int modelId_;
	}
}
