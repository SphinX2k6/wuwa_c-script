using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000262 RID: 610
	[NetMessage(EMessageId.ChangeStateConfirmNotify)]
	public sealed class ChangeStateConfirmNotify : IMessage<ChangeStateConfirmNotify>, IMessage, IEquatable<ChangeStateConfirmNotify>, IDeepCloneable<ChangeStateConfirmNotify>, IBufferMessage
	{
		// Token: 0x060040C4 RID: 16580 RVA: 0x0009F456 File Offset: 0x0009D656
		[NullableContext(1)]
		public static ChangeStateConfirmNotify Create()
		{
			return new ChangeStateConfirmNotify();
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x0009F45D File Offset: 0x0009D65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0009F460 File Offset: 0x0009D660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmNotify.Descriptor;
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x0009F467 File Offset: 0x0009D667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify()
		{
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0009F46F File Offset: 0x0009D66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify(ChangeStateConfirmNotify other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0009F4A0 File Offset: 0x0009D6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmNotify Clone()
		{
			return new ChangeStateConfirmNotify(this);
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x0009F4A8 File Offset: 0x0009D6A8
		// (set) Token: 0x060040CB RID: 16587 RVA: 0x0009F4B0 File Offset: 0x0009D6B0
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

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060040CC RID: 16588 RVA: 0x0009F4B9 File Offset: 0x0009D6B9
		// (set) Token: 0x060040CD RID: 16589 RVA: 0x0009F4C1 File Offset: 0x0009D6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0009F4CA File Offset: 0x0009D6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmNotify);
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x0009F4D8 File Offset: 0x0009D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmNotify other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x0009F518 File Offset: 0x0009D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x0009F570 File Offset: 0x0009D770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0009F57D File Offset: 0x0009D77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x0009F588 File Offset: 0x0009D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x0009F5E4 File Offset: 0x0009D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x0009F63C File Offset: 0x0009D83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0009F68C File Offset: 0x0009D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x0009F698 File Offset: 0x0009D898
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DCE RID: 11726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DCF RID: 11727
		public const int FsmIdFieldNumber = 9;

		// Token: 0x04002DD0 RID: 11728
		private int fsmId_;

		// Token: 0x04002DD1 RID: 11729
		public const int StateFieldNumber = 11;

		// Token: 0x04002DD2 RID: 11730
		private int state_;
	}
}
