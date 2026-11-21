using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000654 RID: 1620
	[NetMessage(EMessageId.FsmConditionPassRequest)]
	public sealed class FsmConditionPassRequest : IMessage<FsmConditionPassRequest>, IMessage, IEquatable<FsmConditionPassRequest>, IDeepCloneable<FsmConditionPassRequest>, IBufferMessage
	{
		// Token: 0x06009521 RID: 38177 RVA: 0x001684C7 File Offset: 0x001666C7
		[NullableContext(1)]
		public static FsmConditionPassRequest Create()
		{
			return new FsmConditionPassRequest();
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06009522 RID: 38178 RVA: 0x001684CE File Offset: 0x001666CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x001684D1 File Offset: 0x001666D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassRequest.Descriptor;
			}
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x001684D8 File Offset: 0x001666D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest()
		{
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x001684E0 File Offset: 0x001666E0
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

		// Token: 0x06009526 RID: 38182 RVA: 0x00168540 File Offset: 0x00166740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassRequest Clone()
		{
			return new FsmConditionPassRequest(this);
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06009527 RID: 38183 RVA: 0x00168548 File Offset: 0x00166748
		// (set) Token: 0x06009528 RID: 38184 RVA: 0x00168550 File Offset: 0x00166750
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

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06009529 RID: 38185 RVA: 0x00168559 File Offset: 0x00166759
		// (set) Token: 0x0600952A RID: 38186 RVA: 0x00168561 File Offset: 0x00166761
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

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600952B RID: 38187 RVA: 0x0016856A File Offset: 0x0016676A
		// (set) Token: 0x0600952C RID: 38188 RVA: 0x00168572 File Offset: 0x00166772
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

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x0600952D RID: 38189 RVA: 0x0016857B File Offset: 0x0016677B
		// (set) Token: 0x0600952E RID: 38190 RVA: 0x00168583 File Offset: 0x00166783
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x0600952F RID: 38191 RVA: 0x0016858C File Offset: 0x0016678C
		// (set) Token: 0x06009530 RID: 38192 RVA: 0x00168594 File Offset: 0x00166794
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

		// Token: 0x06009531 RID: 38193 RVA: 0x0016859D File Offset: 0x0016679D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassRequest);
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x001685AC File Offset: 0x001667AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && this.ConditionIndex == other.ConditionIndex && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x00168628 File Offset: 0x00166828
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

		// Token: 0x06009534 RID: 38196 RVA: 0x001686CB File Offset: 0x001668CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x001686D8 File Offset: 0x001668D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x001686E4 File Offset: 0x001668E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FsmId);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this.Value)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Value);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FromState);
			}
			if (this.ToState != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ToState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x00168794 File Offset: 0x00166994
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

		// Token: 0x06009538 RID: 38200 RVA: 0x00168828 File Offset: 0x00166A28
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

		// Token: 0x06009539 RID: 38201 RVA: 0x001688B4 File Offset: 0x00166AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x001688C0 File Offset: 0x00166AC0
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ConditionIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Value = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.FromState = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ToState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047AB RID: 18347
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047AC RID: 18348
		public const int FsmIdFieldNumber = 3;

		// Token: 0x040047AD RID: 18349
		private int fsmId_;

		// Token: 0x040047AE RID: 18350
		public const int FromStateFieldNumber = 10;

		// Token: 0x040047AF RID: 18351
		private int fromState_;

		// Token: 0x040047B0 RID: 18352
		public const int ToStateFieldNumber = 15;

		// Token: 0x040047B1 RID: 18353
		private int toState_;

		// Token: 0x040047B2 RID: 18354
		public const int ConditionIndexFieldNumber = 6;

		// Token: 0x040047B3 RID: 18355
		private int conditionIndex_;

		// Token: 0x040047B4 RID: 18356
		public const int ValueFieldNumber = 7;

		// Token: 0x040047B5 RID: 18357
		private bool value_;
	}
}
