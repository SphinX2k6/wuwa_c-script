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
		// Token: 0x0600226B RID: 8811 RVA: 0x0005BA90 File Offset: 0x00059C90
		[NullableContext(1)]
		public static AnimationStateChangedNotify Create()
		{
			return new AnimationStateChangedNotify();
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0005BA97 File Offset: 0x00059C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0005BA9A File Offset: 0x00059C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateChangedNotify.Descriptor;
			}
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0005BAA1 File Offset: 0x00059CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify()
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0005BAC0 File Offset: 0x00059CC0
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

		// Token: 0x06002270 RID: 8816 RVA: 0x0005BB46 File Offset: 0x00059D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedNotify Clone()
		{
			return new AnimationStateChangedNotify(this);
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x0005BB4E File Offset: 0x00059D4E
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x0005BB56 File Offset: 0x00059D56
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0005BB5F File Offset: 0x00059D5F
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0005BB67 File Offset: 0x00059D67
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x0005BB70 File Offset: 0x00059D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0005BB78 File Offset: 0x00059D78
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x0005BB80 File Offset: 0x00059D80
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0005BB89 File Offset: 0x00059D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0005BB91 File Offset: 0x00059D91
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0005BB99 File Offset: 0x00059D99
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

		// Token: 0x0600227B RID: 8827 RVA: 0x0005BBA2 File Offset: 0x00059DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateChangedNotify);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0005BBB0 File Offset: 0x00059DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateChangedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x0005BC54 File Offset: 0x00059E54
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

		// Token: 0x0600227E RID: 8830 RVA: 0x0005BCFE File Offset: 0x00059EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0005BD0B File Offset: 0x00059F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0005BD14 File Offset: 0x00059F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TimeStamp);
			}
			this.states_.WriteTo(ref output, AnimationStateChangedNotify._repeated_states_codec);
			this.specialStates_.WriteTo(ref output, AnimationStateChangedNotify._repeated_specialStates_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x0005BDCC File Offset: 0x00059FCC
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

		// Token: 0x06002282 RID: 8834 RVA: 0x0005BE74 File Offset: 0x0005A074
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

		// Token: 0x06002283 RID: 8835 RVA: 0x0005BF2B File Offset: 0x0005A12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0005BF34 File Offset: 0x0005A134
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
				if (num > 48U)
				{
					if (num <= 72U)
					{
						if (num == 50U)
						{
							goto IL_9A;
						}
						if (num != 72U)
						{
							goto IL_49;
						}
					}
					else if (num != 74U)
					{
						if (num != 104U)
						{
							goto IL_49;
						}
						this.ModelId = input.ReadInt32();
						continue;
					}
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateChangedNotify._repeated_specialStates_codec);
					continue;
				}
				if (num <= 24U)
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
					if (num == 24U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 48U)
					{
						goto IL_9A;
					}
				}
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_9A:
				this.states_.AddEntriesFrom(ref input, AnimationStateChangedNotify._repeated_states_codec);
			}
		}

		// Token: 0x040024C5 RID: 9413
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024C6 RID: 9414
		public const int CombatCommonFieldNumber = 2;

		// Token: 0x040024C7 RID: 9415
		private CombatCommon combatCommon_;

		// Token: 0x040024C8 RID: 9416
		public const int IdFieldNumber = 3;

		// Token: 0x040024C9 RID: 9417
		private long id_;

		// Token: 0x040024CA RID: 9418
		public const int StatesFieldNumber = 6;

		// Token: 0x040024CB RID: 9419
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040024CC RID: 9420
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024CD RID: 9421
		public const int TimeStampFieldNumber = 4;

		// Token: 0x040024CE RID: 9422
		private float timeStamp_;

		// Token: 0x040024CF RID: 9423
		public const int SpecialStatesFieldNumber = 9;

		// Token: 0x040024D0 RID: 9424
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040024D1 RID: 9425
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024D2 RID: 9426
		public const int ModelIdFieldNumber = 13;

		// Token: 0x040024D3 RID: 9427
		private int modelId_;
	}
}
