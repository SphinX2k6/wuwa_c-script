using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000260 RID: 608
	[NetMessage(EMessageId.ChangeStateConfirmResponse)]
	public sealed class ChangeStateConfirmResponse : IMessage<ChangeStateConfirmResponse>, IMessage, IEquatable<ChangeStateConfirmResponse>, IDeepCloneable<ChangeStateConfirmResponse>, IBufferMessage
	{
		// Token: 0x06004059 RID: 16473 RVA: 0x0009DF50 File Offset: 0x0009C150
		[NullableContext(1)]
		public static ChangeStateConfirmResponse Create()
		{
			return new ChangeStateConfirmResponse();
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600405A RID: 16474 RVA: 0x0009DF57 File Offset: 0x0009C157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x0009DF5A File Offset: 0x0009C15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmResponse.Descriptor;
			}
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0009DF61 File Offset: 0x0009C161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse()
		{
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0009DF6C File Offset: 0x0009C16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse(ChangeStateConfirmResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0009DFC4 File Offset: 0x0009C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse Clone()
		{
			return new ChangeStateConfirmResponse(this);
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x0009DFCC File Offset: 0x0009C1CC
		// (set) Token: 0x06004060 RID: 16480 RVA: 0x0009DFD4 File Offset: 0x0009C1D4
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

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x0009DFDD File Offset: 0x0009C1DD
		// (set) Token: 0x06004062 RID: 16482 RVA: 0x0009DFE5 File Offset: 0x0009C1E5
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

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x0009DFEE File Offset: 0x0009C1EE
		// (set) Token: 0x06004064 RID: 16484 RVA: 0x0009DFF6 File Offset: 0x0009C1F6
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

		// Token: 0x06004065 RID: 16485 RVA: 0x0009DFFF File Offset: 0x0009C1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmResponse);
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0009E010 File Offset: 0x0009C210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0009E070 File Offset: 0x0009C270
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
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0009E0DE File Offset: 0x0009C2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0009E0EB File Offset: 0x0009C2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0009E168 File Offset: 0x0009C368
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
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeStateConfirmResponse other)
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
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x0009E254 File Offset: 0x0009C454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0009E260 File Offset: 0x0009C460
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04002D59 RID: 11609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D5A RID: 11610
		public const int FsmIdFieldNumber = 1;

		// Token: 0x04002D5B RID: 11611
		private int fsmId_;

		// Token: 0x04002D5C RID: 11612
		public const int StateFieldNumber = 2;

		// Token: 0x04002D5D RID: 11613
		private int state_;

		// Token: 0x04002D5E RID: 11614
		public const int ErrorFieldNumber = 4;

		// Token: 0x04002D5F RID: 11615
		private DErrorResult error_;
	}
}
