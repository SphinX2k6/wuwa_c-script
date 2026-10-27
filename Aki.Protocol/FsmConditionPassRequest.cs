using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000668 RID: 1640
	[NetMessage(EMessageId.FsmConditionPassRequest)]
	public sealed class FsmConditionPassRequest : IMessage<FsmConditionPassRequest>, IMessage, IEquatable<FsmConditionPassRequest>, IDeepCloneable<FsmConditionPassRequest>, IBufferMessage
	{
		// Token: 0x06009677 RID: 38519 RVA: 0x0016AEEE File Offset: 0x001690EE
		[NullableContext(1)]
		public static FsmConditionPassRequest Create()
		{
			return new FsmConditionPassRequest();
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06009678 RID: 38520 RVA: 0x0016AEF5 File Offset: 0x001690F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x0016AEF8 File Offset: 0x001690F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassRequest.Descriptor;
			}
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x0016AEFF File Offset: 0x001690FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest()
		{
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x0016AF08 File Offset: 0x00169108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest(FsmConditionPassRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this.conditionIndex_ = other.conditionIndex_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x0016AF68 File Offset: 0x00169168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest Clone()
		{
			return new FsmConditionPassRequest(this);
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x0016AF70 File Offset: 0x00169170
		// (set) Token: 0x0600967E RID: 38526 RVA: 0x0016AF78 File Offset: 0x00169178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600967F RID: 38527 RVA: 0x0016AF81 File Offset: 0x00169181
		// (set) Token: 0x06009680 RID: 38528 RVA: 0x0016AF89 File Offset: 0x00169189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromState
		{
			get
			{
				return this.fromState_;
			}
			set
			{
				this.fromState_ = value;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06009681 RID: 38529 RVA: 0x0016AF92 File Offset: 0x00169192
		// (set) Token: 0x06009682 RID: 38530 RVA: 0x0016AF9A File Offset: 0x0016919A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToState
		{
			get
			{
				return this.toState_;
			}
			set
			{
				this.toState_ = value;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06009683 RID: 38531 RVA: 0x0016AFA3 File Offset: 0x001691A3
		// (set) Token: 0x06009684 RID: 38532 RVA: 0x0016AFAB File Offset: 0x001691AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionIndex
		{
			get
			{
				return this.conditionIndex_;
			}
			set
			{
				this.conditionIndex_ = value;
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x0016AFB4 File Offset: 0x001691B4
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x0016AFBC File Offset: 0x001691BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x0016AFC5 File Offset: 0x001691C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassRequest);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x0016AFD4 File Offset: 0x001691D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && this.ConditionIndex == other.ConditionIndex && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x0016B050 File Offset: 0x00169250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.FromState != 0)
			{
				num ^= this.FromState.GetHashCode();
			}
			if (this.ToState != 0)
			{
				num ^= this.ToState.GetHashCode();
			}
			if (this.ConditionIndex != 0)
			{
				num ^= this.ConditionIndex.GetHashCode();
			}
			if (this.Value)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x0016B0F3 File Offset: 0x001692F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x0016B100 File Offset: 0x00169300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x0016B10C File Offset: 0x0016930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FromState != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FromState);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this.Value)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Value);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FsmId);
			}
			if (this.ToState != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ToState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x0016B1BC File Offset: 0x001693BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.FromState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromState);
			}
			if (this.ToState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToState);
			}
			if (this.ConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionIndex);
			}
			if (this.Value)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x0016B250 File Offset: 0x00169450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmConditionPassRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.FromState != 0)
			{
				this.FromState = other.FromState;
			}
			if (other.ToState != 0)
			{
				this.ToState = other.ToState;
			}
			if (other.ConditionIndex != 0)
			{
				this.ConditionIndex = other.ConditionIndex;
			}
			if (other.Value)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x0016B2DC File Offset: 0x001694DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x0016B2E8 File Offset: 0x001694E8
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.FromState = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ConditionIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Value = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ToState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047B2 RID: 18354
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047B3 RID: 18355
		public const int FsmIdFieldNumber = 11;

		// Token: 0x040047B4 RID: 18356
		private int fsmId_;

		// Token: 0x040047B5 RID: 18357
		public const int FromStateFieldNumber = 6;

		// Token: 0x040047B6 RID: 18358
		private int fromState_;

		// Token: 0x040047B7 RID: 18359
		public const int ToStateFieldNumber = 12;

		// Token: 0x040047B8 RID: 18360
		private int toState_;

		// Token: 0x040047B9 RID: 18361
		public const int ConditionIndexFieldNumber = 7;

		// Token: 0x040047BA RID: 18362
		private int conditionIndex_;

		// Token: 0x040047BB RID: 18363
		public const int ValueFieldNumber = 9;

		// Token: 0x040047BC RID: 18364
		private bool value_;
	}
}
