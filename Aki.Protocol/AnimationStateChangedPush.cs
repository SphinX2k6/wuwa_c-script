using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EE RID: 238
	[NetMessage(EMessageId.AnimationStateChangedPush)]
	public sealed class AnimationStateChangedPush : IMessage<AnimationStateChangedPush>, IMessage, IEquatable<AnimationStateChangedPush>, IDeepCloneable<AnimationStateChangedPush>, IBufferMessage
	{
		// Token: 0x0600224F RID: 8783 RVA: 0x0005B564 File Offset: 0x00059764
		[NullableContext(1)]
		public static AnimationStateChangedPush Create()
		{
			return new AnimationStateChangedPush();
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0005B56B File Offset: 0x0005976B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x0005B56E File Offset: 0x0005976E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedPush.Descriptor;
			}
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0005B575 File Offset: 0x00059775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush()
		{
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0005B594 File Offset: 0x00059794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush(AnimationStateChangedPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0005B60E File Offset: 0x0005980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush Clone()
		{
			return new AnimationStateChangedPush(this);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x0005B616 File Offset: 0x00059816
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x0005B61E File Offset: 0x0005981E
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x0005B627 File Offset: 0x00059827
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x0005B62F File Offset: 0x0005982F
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x0005B638 File Offset: 0x00059838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0005B640 File Offset: 0x00059840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x0005B648 File Offset: 0x00059848
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x0005B650 File Offset: 0x00059850
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

		// Token: 0x0600225D RID: 8797 RVA: 0x0005B659 File Offset: 0x00059859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedPush);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0005B668 File Offset: 0x00059868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0005B6F0 File Offset: 0x000598F0
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

		// Token: 0x06002260 RID: 8800 RVA: 0x0005B77A File Offset: 0x0005997A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0005B787 File Offset: 0x00059987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0005B790 File Offset: 0x00059990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ModelId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateChangedPush._repeated_specialStates_codec);
			this.states_.WriteTo(ref output, AnimationStateChangedPush._repeated_states_codec);
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0005B828 File Offset: 0x00059A28
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
			num += this.states_.CalculateSize(AnimationStateChangedPush._repeated_states_codec);
			num += this.specialStates_.CalculateSize(AnimationStateChangedPush._repeated_specialStates_codec);
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

		// Token: 0x06002264 RID: 8804 RVA: 0x0005B8BC File Offset: 0x00059ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateChangedPush other)
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

		// Token: 0x06002265 RID: 8805 RVA: 0x0005B95A File Offset: 0x00059B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0005B964 File Offset: 0x00059B64
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
				if (num > 72U)
				{
					if (num <= 88U)
					{
						if (num == 74U)
						{
							goto IL_6D;
						}
						if (num != 88U)
						{
							goto IL_3D;
						}
					}
					else if (num != 90U)
					{
						if (num != 114U)
						{
							goto IL_3D;
						}
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					this.states_.AddEntriesFrom(ref input, AnimationStateChangedPush._repeated_states_codec);
					continue;
				}
				if (num == 32U)
				{
					this.ModelId = input.ReadInt32();
					continue;
				}
				if (num == 48U)
				{
					this.Id = input.ReadInt64();
					continue;
				}
				if (num == 72U)
				{
					goto IL_6D;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_6D:
				this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedPush._repeated_specialStates_codec);
			}
		}

		// Token: 0x04002475 RID: 9333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002476 RID: 9334
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x04002477 RID: 9335
		private CombatCommon combatCommon_;

		// Token: 0x04002478 RID: 9336
		public const int IdFieldNumber = 6;

		// Token: 0x04002479 RID: 9337
		private long id_;

		// Token: 0x0400247A RID: 9338
		public const int StatesFieldNumber = 11;

		// Token: 0x0400247B RID: 9339
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400247C RID: 9340
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x0400247D RID: 9341
		public const int SpecialStatesFieldNumber = 9;

		// Token: 0x0400247E RID: 9342
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400247F RID: 9343
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x04002480 RID: 9344
		public const int ModelIdFieldNumber = 4;

		// Token: 0x04002481 RID: 9345
		private int modelId_;
	}
}
