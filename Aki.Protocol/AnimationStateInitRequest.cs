using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F4 RID: 244
	[NetMessage(EMessageId.AnimationStateInitRequest)]
	public sealed class AnimationStateInitRequest : IMessage<AnimationStateInitRequest>, IMessage, IEquatable<AnimationStateInitRequest>, IDeepCloneable<AnimationStateInitRequest>, IBufferMessage
	{
		// Token: 0x060022DE RID: 8926 RVA: 0x0005D05E File Offset: 0x0005B25E
		[NullableContext(1)]
		public static AnimationStateInitRequest Create()
		{
			return new AnimationStateInitRequest();
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x0005D065 File Offset: 0x0005B265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x0005D068 File Offset: 0x0005B268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitRequest.Descriptor;
			}
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0005D06F File Offset: 0x0005B26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest()
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0005D090 File Offset: 0x0005B290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest(AnimationStateInitRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.id_ = other.id_;
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0005D10A File Offset: 0x0005B30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest Clone()
		{
			return new AnimationStateInitRequest(this);
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x0005D112 File Offset: 0x0005B312
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x0005D11A File Offset: 0x0005B31A
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0005D123 File Offset: 0x0005B323
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0005D12B File Offset: 0x0005B32B
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0005D134 File Offset: 0x0005B334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0005D13C File Offset: 0x0005B33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0005D144 File Offset: 0x0005B344
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0005D14C File Offset: 0x0005B34C
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

		// Token: 0x060022EC RID: 8940 RVA: 0x0005D155 File Offset: 0x0005B355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitRequest);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0005D164 File Offset: 0x0005B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0005D1EC File Offset: 0x0005B3EC
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

		// Token: 0x060022EF RID: 8943 RVA: 0x0005D276 File Offset: 0x0005B476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0005D283 File Offset: 0x0005B483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0005D28C File Offset: 0x0005B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.specialStates_.WriteTo(ref output, AnimationStateInitRequest._repeated_specialStates_codec);
			this.states_.WriteTo(ref output, AnimationStateInitRequest._repeated_states_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ModelId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0005D324 File Offset: 0x0005B524
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
			num += this.states_.CalculateSize(AnimationStateInitRequest._repeated_states_codec);
			num += this.specialStates_.CalculateSize(AnimationStateInitRequest._repeated_specialStates_codec);
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

		// Token: 0x060022F3 RID: 8947 RVA: 0x0005D3B8 File Offset: 0x0005B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateInitRequest other)
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

		// Token: 0x060022F4 RID: 8948 RVA: 0x0005D456 File Offset: 0x0005B656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0005D460 File Offset: 0x0005B660
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
				if (num <= 24U)
				{
					if (num == 8U || num == 10U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitRequest._repeated_specialStates_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_63;
					}
				}
				else if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_63;
					}
					if (num == 32U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 122U)
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
				this.states_.AddEntriesFrom(ref input, AnimationStateInitRequest._repeated_states_codec);
			}
		}

		// Token: 0x040024BD RID: 9405
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024BE RID: 9406
		public const int CombatCommonFieldNumber = 15;

		// Token: 0x040024BF RID: 9407
		private CombatCommon combatCommon_;

		// Token: 0x040024C0 RID: 9408
		public const int IdFieldNumber = 8;

		// Token: 0x040024C1 RID: 9409
		private long id_;

		// Token: 0x040024C2 RID: 9410
		public const int StatesFieldNumber = 3;

		// Token: 0x040024C3 RID: 9411
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040024C4 RID: 9412
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024C5 RID: 9413
		public const int SpecialStatesFieldNumber = 1;

		// Token: 0x040024C6 RID: 9414
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040024C7 RID: 9415
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024C8 RID: 9416
		public const int ModelIdFieldNumber = 4;

		// Token: 0x040024C9 RID: 9417
		private int modelId_;
	}
}
