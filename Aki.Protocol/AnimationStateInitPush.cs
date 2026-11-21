using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F3 RID: 243
	[NetMessage(EMessageId.AnimationStateInitPush)]
	public sealed class AnimationStateInitPush : IMessage<AnimationStateInitPush>, IMessage, IEquatable<AnimationStateInitPush>, IDeepCloneable<AnimationStateInitPush>, IBufferMessage
	{
		// Token: 0x060022FC RID: 8956 RVA: 0x0005D644 File Offset: 0x0005B844
		[NullableContext(1)]
		public static AnimationStateInitPush Create()
		{
			return new AnimationStateInitPush();
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0005D64B File Offset: 0x0005B84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x0005D64E File Offset: 0x0005B84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitPush.Descriptor;
			}
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0005D655 File Offset: 0x0005B855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush()
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0005D674 File Offset: 0x0005B874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush(AnimationStateInitPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0005D6EE File Offset: 0x0005B8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush Clone()
		{
			return new AnimationStateInitPush(this);
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x0005D6F6 File Offset: 0x0005B8F6
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x0005D6FE File Offset: 0x0005B8FE
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x0005D707 File Offset: 0x0005B907
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x0005D70F File Offset: 0x0005B90F
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0005D718 File Offset: 0x0005B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0005D720 File Offset: 0x0005B920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0005D728 File Offset: 0x0005B928
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x0005D730 File Offset: 0x0005B930
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

		// Token: 0x0600230A RID: 8970 RVA: 0x0005D739 File Offset: 0x0005B939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitPush);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0005D748 File Offset: 0x0005B948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x0005D7D0 File Offset: 0x0005B9D0
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

		// Token: 0x0600230D RID: 8973 RVA: 0x0005D85A File Offset: 0x0005BA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0005D867 File Offset: 0x0005BA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0005D870 File Offset: 0x0005BA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CombatCommon);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateInitPush._repeated_specialStates_codec);
			this.states_.WriteTo(ref output, AnimationStateInitPush._repeated_states_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this.ModelId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0005D908 File Offset: 0x0005BB08
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
			num += this.states_.CalculateSize(AnimationStateInitPush._repeated_states_codec);
			num += this.specialStates_.CalculateSize(AnimationStateInitPush._repeated_specialStates_codec);
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

		// Token: 0x06002311 RID: 8977 RVA: 0x0005D99C File Offset: 0x0005BB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateInitPush other)
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
			this.specialStates_.Add(other.specialStates_);
			if (other.ModelId != 0)
			{
				this.ModelId = other.ModelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0005DA3A File Offset: 0x0005BC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0005DA44 File Offset: 0x0005BC44
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
				if (num <= 34U)
				{
					if (num == 18U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitPush._repeated_specialStates_codec);
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.states_.AddEntriesFrom(ref input, AnimationStateInitPush._repeated_states_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400250F RID: 9487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002510 RID: 9488
		public const int CombatCommonFieldNumber = 2;

		// Token: 0x04002511 RID: 9489
		private CombatCommon combatCommon_;

		// Token: 0x04002512 RID: 9490
		public const int IdFieldNumber = 9;

		// Token: 0x04002513 RID: 9491
		private long id_;

		// Token: 0x04002514 RID: 9492
		public const int StatesFieldNumber = 7;

		// Token: 0x04002515 RID: 9493
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002516 RID: 9494
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x04002517 RID: 9495
		public const int SpecialStatesFieldNumber = 4;

		// Token: 0x04002518 RID: 9496
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002519 RID: 9497
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x0400251A RID: 9498
		public const int ModelIdFieldNumber = 15;

		// Token: 0x0400251B RID: 9499
		private int modelId_;
	}
}
