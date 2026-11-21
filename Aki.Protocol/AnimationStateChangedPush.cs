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
		// Token: 0x06002286 RID: 8838 RVA: 0x0005C034 File Offset: 0x0005A234
		[NullableContext(1)]
		public static AnimationStateChangedPush Create()
		{
			return new AnimationStateChangedPush();
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0005C03B File Offset: 0x0005A23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x0005C03E File Offset: 0x0005A23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedPush.Descriptor;
			}
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x0005C045 File Offset: 0x0005A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush()
		{
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0005C064 File Offset: 0x0005A264
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

		// Token: 0x0600228B RID: 8843 RVA: 0x0005C0DE File Offset: 0x0005A2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedPush Clone()
		{
			return new AnimationStateChangedPush(this);
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0005C0E6 File Offset: 0x0005A2E6
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x0005C0EE File Offset: 0x0005A2EE
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0005C0F7 File Offset: 0x0005A2F7
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x0005C0FF File Offset: 0x0005A2FF
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x0005C108 File Offset: 0x0005A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x0005C110 File Offset: 0x0005A310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x0005C118 File Offset: 0x0005A318
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x0005C120 File Offset: 0x0005A320
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

		// Token: 0x06002294 RID: 8852 RVA: 0x0005C129 File Offset: 0x0005A329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedPush);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0005C138 File Offset: 0x0005A338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0005C1C0 File Offset: 0x0005A3C0
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

		// Token: 0x06002297 RID: 8855 RVA: 0x0005C24A File Offset: 0x0005A44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0005C257 File Offset: 0x0005A457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0005C260 File Offset: 0x0005A460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.specialStates_.WriteTo(ref output, AnimationStateChangedPush._repeated_specialStates_codec);
			this.states_.WriteTo(ref output, AnimationStateChangedPush._repeated_states_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.ModelId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ModelId);
			}
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

		// Token: 0x0600229A RID: 8858 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
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

		// Token: 0x0600229B RID: 8859 RVA: 0x0005C38C File Offset: 0x0005A58C
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

		// Token: 0x0600229C RID: 8860 RVA: 0x0005C42A File Offset: 0x0005A62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0005C434 File Offset: 0x0005A634
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
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedPush._repeated_specialStates_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_63;
					}
				}
				else if (num <= 48U)
				{
					if (num == 18U)
					{
						goto IL_63;
					}
					if (num == 48U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_63:
				this.states_.AddEntriesFrom(ref input, AnimationStateChangedPush._repeated_states_codec);
			}
		}

		// Token: 0x040024D4 RID: 9428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024D5 RID: 9429
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x040024D6 RID: 9430
		private CombatCommon combatCommon_;

		// Token: 0x040024D7 RID: 9431
		public const int IdFieldNumber = 6;

		// Token: 0x040024D8 RID: 9432
		private long id_;

		// Token: 0x040024D9 RID: 9433
		public const int StatesFieldNumber = 2;

		// Token: 0x040024DA RID: 9434
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040024DB RID: 9435
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024DC RID: 9436
		public const int SpecialStatesFieldNumber = 1;

		// Token: 0x040024DD RID: 9437
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040024DE RID: 9438
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024DF RID: 9439
		public const int ModelIdFieldNumber = 9;

		// Token: 0x040024E0 RID: 9440
		private int modelId_;
	}
}
