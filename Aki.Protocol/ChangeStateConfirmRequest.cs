using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025F RID: 607
	[NetMessage(EMessageId.ChangeStateConfirmRequest)]
	public sealed class ChangeStateConfirmRequest : IMessage<ChangeStateConfirmRequest>, IMessage, IEquatable<ChangeStateConfirmRequest>, IDeepCloneable<ChangeStateConfirmRequest>, IBufferMessage
	{
		// Token: 0x06004045 RID: 16453 RVA: 0x0009DCB7 File Offset: 0x0009BEB7
		[NullableContext(1)]
		public static ChangeStateConfirmRequest Create()
		{
			return new ChangeStateConfirmRequest();
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x0009DCBE File Offset: 0x0009BEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x0009DCC1 File Offset: 0x0009BEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmRequest.Descriptor;
			}
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x0009DCC8 File Offset: 0x0009BEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest()
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0009DCD0 File Offset: 0x0009BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest(ChangeStateConfirmRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0009DD01 File Offset: 0x0009BF01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmRequest Clone()
		{
			return new ChangeStateConfirmRequest(this);
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x0009DD09 File Offset: 0x0009BF09
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x0009DD11 File Offset: 0x0009BF11
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600404D RID: 16461 RVA: 0x0009DD1A File Offset: 0x0009BF1A
		// (set) Token: 0x0600404E RID: 16462 RVA: 0x0009DD22 File Offset: 0x0009BF22
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

		// Token: 0x0600404F RID: 16463 RVA: 0x0009DD2B File Offset: 0x0009BF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmRequest);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0009DD39 File Offset: 0x0009BF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0009DD78 File Offset: 0x0009BF78
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

		// Token: 0x06004052 RID: 16466 RVA: 0x0009DDD0 File Offset: 0x0009BFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0009DDDD File Offset: 0x0009BFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.State);
			}
			if (this.FsmId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FsmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0009DE44 File Offset: 0x0009C044
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

		// Token: 0x06004056 RID: 16470 RVA: 0x0009DE9C File Offset: 0x0009C09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmRequest other)
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

		// Token: 0x06004057 RID: 16471 RVA: 0x0009DEEC File Offset: 0x0009C0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0009DEF8 File Offset: 0x0009C0F8
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FsmId = input.ReadInt32();
					}
				}
				else
				{
					this.State = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D54 RID: 11604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D55 RID: 11605
		public const int FsmIdFieldNumber = 9;

		// Token: 0x04002D56 RID: 11606
		private int fsmId_;

		// Token: 0x04002D57 RID: 11607
		public const int StateFieldNumber = 5;

		// Token: 0x04002D58 RID: 11608
		private int state_;
	}
}
