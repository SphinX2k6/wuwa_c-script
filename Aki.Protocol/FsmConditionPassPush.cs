using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000653 RID: 1619
	[NetMessage(EMessageId.FsmConditionPassPush)]
	public sealed class FsmConditionPassPush : IMessage<FsmConditionPassPush>, IMessage, IEquatable<FsmConditionPassPush>, IDeepCloneable<FsmConditionPassPush>, IBufferMessage
	{
		// Token: 0x06009507 RID: 38151 RVA: 0x00168031 File Offset: 0x00166231
		[NullableContext(1)]
		public static FsmConditionPassPush Create()
		{
			return new FsmConditionPassPush();
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06009508 RID: 38152 RVA: 0x00168038 File Offset: 0x00166238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06009509 RID: 38153 RVA: 0x0016803B File Offset: 0x0016623B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmConditionPassPush.Descriptor;
			}
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x00168042 File Offset: 0x00166242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush()
		{
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x0016804C File Offset: 0x0016624C
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

		// Token: 0x0600950C RID: 38156 RVA: 0x001680AC File Offset: 0x001662AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmConditionPassPush Clone()
		{
			return new FsmConditionPassPush(this);
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x0600950D RID: 38157 RVA: 0x001680B4 File Offset: 0x001662B4
		// (set) Token: 0x0600950E RID: 38158 RVA: 0x001680BC File Offset: 0x001662BC
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

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x0600950F RID: 38159 RVA: 0x001680C5 File Offset: 0x001662C5
		// (set) Token: 0x06009510 RID: 38160 RVA: 0x001680CD File Offset: 0x001662CD
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

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x001680D6 File Offset: 0x001662D6
		// (set) Token: 0x06009512 RID: 38162 RVA: 0x001680DE File Offset: 0x001662DE
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

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06009513 RID: 38163 RVA: 0x001680E7 File Offset: 0x001662E7
		// (set) Token: 0x06009514 RID: 38164 RVA: 0x001680EF File Offset: 0x001662EF
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

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06009515 RID: 38165 RVA: 0x001680F8 File Offset: 0x001662F8
		// (set) Token: 0x06009516 RID: 38166 RVA: 0x00168100 File Offset: 0x00166300
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

		// Token: 0x06009517 RID: 38167 RVA: 0x00168109 File Offset: 0x00166309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmConditionPassPush);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00168118 File Offset: 0x00166318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmConditionPassPush other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.FromState == other.FromState && this.ToState == other.ToState && this.ConditionIndex == other.ConditionIndex && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00168194 File Offset: 0x00166394
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

		// Token: 0x0600951A RID: 38170 RVA: 0x00168237 File Offset: 0x00166437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00168244 File Offset: 0x00166444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x00168250 File Offset: 0x00166450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Value)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Value);
			}
			if (this.FromState != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FromState);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FsmId);
			}
			if (this.ToState != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ToState);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x00168300 File Offset: 0x00166500
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

		// Token: 0x0600951E RID: 38174 RVA: 0x00168394 File Offset: 0x00166594
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

		// Token: 0x0600951F RID: 38175 RVA: 0x00168420 File Offset: 0x00166620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x0016842C File Offset: 0x0016662C
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
				if (num <= 96U)
				{
					if (num == 16U)
					{
						this.Value = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.FromState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ToState = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ConditionIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047A0 RID: 18336
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047A1 RID: 18337
		public const int FsmIdFieldNumber = 13;

		// Token: 0x040047A2 RID: 18338
		private int fsmId_;

		// Token: 0x040047A3 RID: 18339
		public const int FromStateFieldNumber = 12;

		// Token: 0x040047A4 RID: 18340
		private int fromState_;

		// Token: 0x040047A5 RID: 18341
		public const int ToStateFieldNumber = 14;

		// Token: 0x040047A6 RID: 18342
		private int toState_;

		// Token: 0x040047A7 RID: 18343
		public const int ConditionIndexFieldNumber = 15;

		// Token: 0x040047A8 RID: 18344
		private int conditionIndex_;

		// Token: 0x040047A9 RID: 18345
		public const int ValueFieldNumber = 2;

		// Token: 0x040047AA RID: 18346
		private bool value_;
	}
}
