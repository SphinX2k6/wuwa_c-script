using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000667 RID: 1639
	[NetMessage(EMessageId.FsmConditionPassPush)]
	public sealed class FsmConditionPassPush : IMessage<FsmConditionPassPush>, IMessage, IEquatable<FsmConditionPassPush>, IDeepCloneable<FsmConditionPassPush>, IBufferMessage
	{
		// Token: 0x0600965D RID: 38493 RVA: 0x0016AA5D File Offset: 0x00168C5D
		[NullableContext(1)]
		public static FsmConditionPassPush Create()
		{
			return new FsmConditionPassPush();
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x0016AA64 File Offset: 0x00168C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600965F RID: 38495 RVA: 0x0016AA67 File Offset: 0x00168C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassPush.Descriptor;
			}
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x0016AA6E File Offset: 0x00168C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush()
		{
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x0016AA78 File Offset: 0x00168C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush(FsmConditionPassPush other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.fromState_ = other.fromState_;
			this.toState_ = other.toState_;
			this.conditionIndex_ = other.conditionIndex_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x0016AAD8 File Offset: 0x00168CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush Clone()
		{
			return new FsmConditionPassPush(this);
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06009663 RID: 38499 RVA: 0x0016AAE0 File Offset: 0x00168CE0
		// (set) Token: 0x06009664 RID: 38500 RVA: 0x0016AAE8 File Offset: 0x00168CE8
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

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06009665 RID: 38501 RVA: 0x0016AAF1 File Offset: 0x00168CF1
		// (set) Token: 0x06009666 RID: 38502 RVA: 0x0016AAF9 File Offset: 0x00168CF9
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

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06009667 RID: 38503 RVA: 0x0016AB02 File Offset: 0x00168D02
		// (set) Token: 0x06009668 RID: 38504 RVA: 0x0016AB0A File Offset: 0x00168D0A
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

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06009669 RID: 38505 RVA: 0x0016AB13 File Offset: 0x00168D13
		// (set) Token: 0x0600966A RID: 38506 RVA: 0x0016AB1B File Offset: 0x00168D1B
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

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x0600966B RID: 38507 RVA: 0x0016AB24 File Offset: 0x00168D24
		// (set) Token: 0x0600966C RID: 38508 RVA: 0x0016AB2C File Offset: 0x00168D2C
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

		// Token: 0x0600966D RID: 38509 RVA: 0x0016AB35 File Offset: 0x00168D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassPush);
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x0016AB44 File Offset: 0x00168D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassPush other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && this.ConditionIndex == other.ConditionIndex && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x0016ABC0 File Offset: 0x00168DC0
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

		// Token: 0x06009670 RID: 38512 RVA: 0x0016AC63 File Offset: 0x00168E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x0016AC70 File Offset: 0x00168E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x0016AC7C File Offset: 0x00168E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToState != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ToState);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FromState);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FsmId);
			}
			if (this.Value)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009673 RID: 38515 RVA: 0x0016AD28 File Offset: 0x00168F28
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

		// Token: 0x06009674 RID: 38516 RVA: 0x0016ADBC File Offset: 0x00168FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmConditionPassPush other)
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

		// Token: 0x06009675 RID: 38517 RVA: 0x0016AE48 File Offset: 0x00169048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x0016AE54 File Offset: 0x00169054
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
					if (num == 8U)
					{
						this.ToState = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.FromState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ConditionIndex = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Value = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047A7 RID: 18343
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047A8 RID: 18344
		public const int FsmIdFieldNumber = 11;

		// Token: 0x040047A9 RID: 18345
		private int fsmId_;

		// Token: 0x040047AA RID: 18346
		public const int FromStateFieldNumber = 3;

		// Token: 0x040047AB RID: 18347
		private int fromState_;

		// Token: 0x040047AC RID: 18348
		public const int ToStateFieldNumber = 1;

		// Token: 0x040047AD RID: 18349
		private int toState_;

		// Token: 0x040047AE RID: 18350
		public const int ConditionIndexFieldNumber = 10;

		// Token: 0x040047AF RID: 18351
		private int conditionIndex_;

		// Token: 0x040047B0 RID: 18352
		public const int ValueFieldNumber = 12;

		// Token: 0x040047B1 RID: 18353
		private bool value_;
	}
}
