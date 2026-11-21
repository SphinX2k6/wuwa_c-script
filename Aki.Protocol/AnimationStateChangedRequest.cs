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
		// Token: 0x0600229F RID: 8863 RVA: 0x0005C519 File Offset: 0x0005A719
		[NullableContext(1)]
		public static AnimationStateChangedRequest Create()
		{
			return new AnimationStateChangedRequest();
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0005C520 File Offset: 0x0005A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0005C523 File Offset: 0x0005A723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedRequest.Descriptor;
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x0005C52A File Offset: 0x0005A72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest()
		{
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0005C548 File Offset: 0x0005A748
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

		// Token: 0x060022A4 RID: 8868 RVA: 0x0005C5C2 File Offset: 0x0005A7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest Clone()
		{
			return new AnimationStateChangedRequest(this);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0005C5CA File Offset: 0x0005A7CA
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0005C5D2 File Offset: 0x0005A7D2
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0005C5DB File Offset: 0x0005A7DB
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0005C5E3 File Offset: 0x0005A7E3
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0005C5EC File Offset: 0x0005A7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0005C5FC File Offset: 0x0005A7FC
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0005C604 File Offset: 0x0005A804
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

		// Token: 0x060022AD RID: 8877 RVA: 0x0005C60D File Offset: 0x0005A80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedRequest);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0005C61C File Offset: 0x0005A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0005C6A4 File Offset: 0x0005A8A4
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

		// Token: 0x060022B0 RID: 8880 RVA: 0x0005C72E File Offset: 0x0005A92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0005C73B File Offset: 0x0005A93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0005C744 File Offset: 0x0005A944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ModelId);
			}
			this.states_.WriteTo(ref output, AnimationStateChangedRequest._repeated_states_codec);
			this.specialStates_.WriteTo(ref output, AnimationStateChangedRequest._repeated_specialStates_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
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

		// Token: 0x060022B3 RID: 8883 RVA: 0x0005C7DC File Offset: 0x0005A9DC
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

		// Token: 0x060022B4 RID: 8884 RVA: 0x0005C870 File Offset: 0x0005AA70
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

		// Token: 0x060022B5 RID: 8885 RVA: 0x0005C90E File Offset: 0x0005AB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0005C918 File Offset: 0x0005AB18
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
					if (num == 24U || num == 26U)
					{
						this.states_.AddEntriesFrom(ref input, AnimationStateChangedRequest._repeated_states_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedRequest._repeated_specialStates_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadInt64();
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
			}
		}

		// Token: 0x040024E1 RID: 9441
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024E2 RID: 9442
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x040024E3 RID: 9443
		private CombatCommon combatCommon_;

		// Token: 0x040024E4 RID: 9444
		public const int IdFieldNumber = 10;

		// Token: 0x040024E5 RID: 9445
		private long id_;

		// Token: 0x040024E6 RID: 9446
		public const int StatesFieldNumber = 3;

		// Token: 0x040024E7 RID: 9447
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040024E8 RID: 9448
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024E9 RID: 9449
		public const int SpecialStatesFieldNumber = 4;

		// Token: 0x040024EA RID: 9450
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040024EB RID: 9451
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024EC RID: 9452
		public const int ModelIdFieldNumber = 1;

		// Token: 0x040024ED RID: 9453
		private int modelId_;
	}
}
