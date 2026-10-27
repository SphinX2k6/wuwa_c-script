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
		// Token: 0x060022C5 RID: 8901 RVA: 0x0005CB77 File Offset: 0x0005AD77
		[NullableContext(1)]
		public static AnimationStateInitPush Create()
		{
			return new AnimationStateInitPush();
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0005CB7E File Offset: 0x0005AD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0005CB81 File Offset: 0x0005AD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitPush.Descriptor;
			}
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0005CB88 File Offset: 0x0005AD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush()
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0005CBA8 File Offset: 0x0005ADA8
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

		// Token: 0x060022CA RID: 8906 RVA: 0x0005CC22 File Offset: 0x0005AE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitPush Clone()
		{
			return new AnimationStateInitPush(this);
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0005CC2A File Offset: 0x0005AE2A
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0005CC32 File Offset: 0x0005AE32
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0005CC3B File Offset: 0x0005AE3B
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0005CC43 File Offset: 0x0005AE43
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0005CC4C File Offset: 0x0005AE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0005CC54 File Offset: 0x0005AE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0005CC5C File Offset: 0x0005AE5C
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x0005CC64 File Offset: 0x0005AE64
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

		// Token: 0x060022D3 RID: 8915 RVA: 0x0005CC6D File Offset: 0x0005AE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitPush);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0005CC7C File Offset: 0x0005AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0005CD04 File Offset: 0x0005AF04
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

		// Token: 0x060022D6 RID: 8918 RVA: 0x0005CD8E File Offset: 0x0005AF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0005CD9B File Offset: 0x0005AF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0005CDA4 File Offset: 0x0005AFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ModelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ModelId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CombatCommon);
			}
			this.states_.WriteTo(ref output, AnimationStateInitPush._repeated_states_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateInitPush._repeated_specialStates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0005CE3C File Offset: 0x0005B03C
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

		// Token: 0x060022DA RID: 8922 RVA: 0x0005CED0 File Offset: 0x0005B0D0
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

		// Token: 0x060022DB RID: 8923 RVA: 0x0005CF6E File Offset: 0x0005B16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0005CF78 File Offset: 0x0005B178
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 64U)
					{
						goto IL_80;
					}
				}
				else if (num <= 104U)
				{
					if (num == 66U)
					{
						goto IL_80;
					}
					if (num == 104U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitPush._repeated_specialStates_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_80:
				this.states_.AddEntriesFrom(ref input, AnimationStateInitPush._repeated_states_codec);
			}
		}

		// Token: 0x040024B0 RID: 9392
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024B1 RID: 9393
		public const int CombatCommonFieldNumber = 7;

		// Token: 0x040024B2 RID: 9394
		private CombatCommon combatCommon_;

		// Token: 0x040024B3 RID: 9395
		public const int IdFieldNumber = 13;

		// Token: 0x040024B4 RID: 9396
		private long id_;

		// Token: 0x040024B5 RID: 9397
		public const int StatesFieldNumber = 8;

		// Token: 0x040024B6 RID: 9398
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040024B7 RID: 9399
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024B8 RID: 9400
		public const int SpecialStatesFieldNumber = 14;

		// Token: 0x040024B9 RID: 9401
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040024BA RID: 9402
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024BB RID: 9403
		public const int ModelIdFieldNumber = 5;

		// Token: 0x040024BC RID: 9404
		private int modelId_;
	}
}
