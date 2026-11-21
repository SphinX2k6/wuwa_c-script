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
		// Token: 0x06002315 RID: 8981 RVA: 0x0005DB2A File Offset: 0x0005BD2A
		[NullableContext(1)]
		public static AnimationStateInitRequest Create()
		{
			return new AnimationStateInitRequest();
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x0005DB31 File Offset: 0x0005BD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0005DB34 File Offset: 0x0005BD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitRequest.Descriptor;
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0005DB3B File Offset: 0x0005BD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest()
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0005DB5C File Offset: 0x0005BD5C
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

		// Token: 0x0600231A RID: 8986 RVA: 0x0005DBD6 File Offset: 0x0005BDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitRequest Clone()
		{
			return new AnimationStateInitRequest(this);
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0005DBDE File Offset: 0x0005BDDE
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x0005DBE6 File Offset: 0x0005BDE6
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

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x0005DBEF File Offset: 0x0005BDEF
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x0005DBF7 File Offset: 0x0005BDF7
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x0005DC00 File Offset: 0x0005BE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0005DC08 File Offset: 0x0005BE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0005DC10 File Offset: 0x0005BE10
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x0005DC18 File Offset: 0x0005BE18
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

		// Token: 0x06002323 RID: 8995 RVA: 0x0005DC21 File Offset: 0x0005BE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitRequest);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0005DC30 File Offset: 0x0005BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.Id == other.Id && this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
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

		// Token: 0x06002326 RID: 8998 RVA: 0x0005DD42 File Offset: 0x0005BF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0005DD4F File Offset: 0x0005BF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x0005DD58 File Offset: 0x0005BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			this.specialStates_.WriteTo(ref output, AnimationStateInitRequest._repeated_specialStates_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ModelId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			this.states_.WriteTo(ref output, AnimationStateInitRequest._repeated_states_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x0005DDF0 File Offset: 0x0005BFF0
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

		// Token: 0x0600232A RID: 9002 RVA: 0x0005DE84 File Offset: 0x0005C084
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

		// Token: 0x0600232B RID: 9003 RVA: 0x0005DF22 File Offset: 0x0005C122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0005DF2C File Offset: 0x0005C12C
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
				if (num <= 18U)
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
					if (num == 16U || num == 18U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimationStateInitRequest._repeated_specialStates_codec);
						continue;
					}
				}
				else if (num <= 112U)
				{
					if (num == 40U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.states_.AddEntriesFrom(ref input, AnimationStateInitRequest._repeated_states_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400251C RID: 9500
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400251D RID: 9501
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400251E RID: 9502
		private CombatCommon combatCommon_;

		// Token: 0x0400251F RID: 9503
		public const int IdFieldNumber = 14;

		// Token: 0x04002520 RID: 9504
		private long id_;

		// Token: 0x04002521 RID: 9505
		public const int StatesFieldNumber = 15;

		// Token: 0x04002522 RID: 9506
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04002523 RID: 9507
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x04002524 RID: 9508
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x04002525 RID: 9509
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002526 RID: 9510
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x04002527 RID: 9511
		public const int ModelIdFieldNumber = 5;

		// Token: 0x04002528 RID: 9512
		private int modelId_;
	}
}
