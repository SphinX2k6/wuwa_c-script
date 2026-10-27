using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EF RID: 239
	[NetMessage(EMessageId.AnimationStateChangedRequest)]
	public sealed class AnimationStateChangedRequest : IMessage<AnimationStateChangedRequest>, IMessage, IEquatable<AnimationStateChangedRequest>, IDeepCloneable<AnimationStateChangedRequest>, IBufferMessage
	{
		// Token: 0x06002268 RID: 8808 RVA: 0x0005BA4A File Offset: 0x00059C4A
		[NullableContext(1)]
		public static AnimationStateChangedRequest Create()
		{
			return new AnimationStateChangedRequest();
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x0005BA51 File Offset: 0x00059C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0005BA54 File Offset: 0x00059C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedRequest.Descriptor;
			}
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0005BA5B File Offset: 0x00059C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest()
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0005BA7C File Offset: 0x00059C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest(AnimationStateChangedRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0005BAF6 File Offset: 0x00059CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest Clone()
		{
			return new AnimationStateChangedRequest(this);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x0005BAFE File Offset: 0x00059CFE
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x0005BB06 File Offset: 0x00059D06
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x0005BB0F File Offset: 0x00059D0F
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x0005BB17 File Offset: 0x00059D17
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0005BB20 File Offset: 0x00059D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0005BB28 File Offset: 0x00059D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0005BB30 File Offset: 0x00059D30
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0005BB38 File Offset: 0x00059D38
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

		// Token: 0x06002276 RID: 8822 RVA: 0x0005BB41 File Offset: 0x00059D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedRequest);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0005BB50 File Offset: 0x00059D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0005BBD8 File Offset: 0x00059DD8
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

		// Token: 0x06002279 RID: 8825 RVA: 0x0005BC62 File Offset: 0x00059E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0005BC6F File Offset: 0x00059E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0005BC78 File Offset: 0x00059E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.specialStates_.WriteTo(ref output, AnimationStateChangedRequest._repeated_specialStates_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			this.states_.WriteTo(ref output, AnimationStateChangedRequest._repeated_states_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0005BD10 File Offset: 0x00059F10
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
			num += this.states_.CalculateSize(AnimationStateChangedRequest._repeated_states_codec);
			num += this.specialStates_.CalculateSize(AnimationStateChangedRequest._repeated_specialStates_codec);
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

		// Token: 0x0600227D RID: 8829 RVA: 0x0005BDA4 File Offset: 0x00059FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateChangedRequest other)
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

		// Token: 0x0600227E RID: 8830 RVA: 0x0005BE42 File Offset: 0x0005A042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0005BE4C File Offset: 0x0005A04C
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
				if (num > 24U)
				{
					if (num <= 56U)
					{
						if (num == 34U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
						if (num != 56U)
						{
							goto IL_3C;
						}
					}
					else if (num != 58U)
					{
						if (num != 88U)
						{
							goto IL_3C;
						}
						this.ModelId = input.ReadInt32();
						continue;
					}
					this.states_.AddEntriesFrom(ref input, AnimationStateChangedRequest._repeated_states_codec);
					continue;
				}
				if (num == 8U || num == 10U)
				{
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedRequest._repeated_specialStates_codec);
					continue;
				}
				if (num == 24U)
				{
					this.Id = input.ReadInt64();
					continue;
				}
				IL_3C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002482 RID: 9346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002483 RID: 9347
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x04002484 RID: 9348
		private CombatCommon combatCommon_;

		// Token: 0x04002485 RID: 9349
		public const int IdFieldNumber = 3;

		// Token: 0x04002486 RID: 9350
		private long id_;

		// Token: 0x04002487 RID: 9351
		public const int StatesFieldNumber = 7;

		// Token: 0x04002488 RID: 9352
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002489 RID: 9353
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x0400248A RID: 9354
		public const int SpecialStatesFieldNumber = 1;

		// Token: 0x0400248B RID: 9355
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400248C RID: 9356
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x0400248D RID: 9357
		public const int ModelIdFieldNumber = 11;

		// Token: 0x0400248E RID: 9358
		private int modelId_;
	}
}
