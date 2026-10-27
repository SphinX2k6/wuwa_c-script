using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000263 RID: 611
	[NetMessage(EMessageId.ChangeStateResponse)]
	public sealed class ChangeStateResponse : IMessage<ChangeStateResponse>, IMessage, IEquatable<ChangeStateResponse>, IDeepCloneable<ChangeStateResponse>, IBufferMessage
	{
		// Token: 0x0600409B RID: 16539 RVA: 0x0009E966 File Offset: 0x0009CB66
		[NullableContext(1)]
		public static ChangeStateResponse Create()
		{
			return new ChangeStateResponse();
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x0009E96D File Offset: 0x0009CB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x0009E970 File Offset: 0x0009CB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateResponse.Descriptor;
			}
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0009E977 File Offset: 0x0009CB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse()
		{
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0009E980 File Offset: 0x0009CB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse(ChangeStateResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this.currentState_ = other.currentState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0009E9D8 File Offset: 0x0009CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateResponse Clone()
		{
			return new ChangeStateResponse(this);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x0009E9E8 File Offset: 0x0009CBE8
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

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x0009E9F1 File Offset: 0x0009CBF1
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x0009E9F9 File Offset: 0x0009CBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x0009EA02 File Offset: 0x0009CC02
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x0009EA0A File Offset: 0x0009CC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentState
		{
			get
			{
				return this.currentState_;
			}
			set
			{
				this.currentState_ = value;
			}
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0009EA13 File Offset: 0x0009CC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateResponse);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x0009EA24 File Offset: 0x0009CC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && object.Equals(this.Error, other.Error) && this.CurrentState == other.CurrentState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x0009EA84 File Offset: 0x0009CC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this.CurrentState != 0)
			{
				num ^= this.CurrentState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0009EAF2 File Offset: 0x0009CCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0009EAFF File Offset: 0x0009CCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0009EB08 File Offset: 0x0009CD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Error);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FsmId);
			}
			if (this.CurrentState != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurrentState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0009EB80 File Offset: 0x0009CD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this.CurrentState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x0009EBF0 File Offset: 0x0009CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			if (other.CurrentState != 0)
			{
				this.CurrentState = other.CurrentState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0009EC6C File Offset: 0x0009CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0009EC78 File Offset: 0x0009CE78
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
				if (num != 34U)
				{
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrentState = input.ReadInt32();
						}
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04002D6E RID: 11630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D6F RID: 11631
		public const int FsmIdFieldNumber = 9;

		// Token: 0x04002D70 RID: 11632
		private int fsmId_;

		// Token: 0x04002D71 RID: 11633
		public const int ErrorFieldNumber = 4;

		// Token: 0x04002D72 RID: 11634
		private DErrorResult error_;

		// Token: 0x04002D73 RID: 11635
		public const int CurrentStateFieldNumber = 11;

		// Token: 0x04002D74 RID: 11636
		private int currentState_;
	}
}
