using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000265 RID: 613
	[NetMessage(EMessageId.ChangeStateConfirmResponse)]
	public sealed class ChangeStateConfirmResponse : IMessage<ChangeStateConfirmResponse>, IMessage, IEquatable<ChangeStateConfirmResponse>, IDeepCloneable<ChangeStateConfirmResponse>, IBufferMessage
	{
		// Token: 0x06004100 RID: 16640 RVA: 0x0009FC20 File Offset: 0x0009DE20
		[NullableContext(1)]
		public static ChangeStateConfirmResponse Create()
		{
			return new ChangeStateConfirmResponse();
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x0009FC27 File Offset: 0x0009DE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x0009FC2A File Offset: 0x0009DE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeStateConfirmResponse.Descriptor;
			}
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0009FC31 File Offset: 0x0009DE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse()
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0009FC3C File Offset: 0x0009DE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse(ChangeStateConfirmResponse other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x0009FC94 File Offset: 0x0009DE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeStateConfirmResponse Clone()
		{
			return new ChangeStateConfirmResponse(this);
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x0009FC9C File Offset: 0x0009DE9C
		// (set) Token: 0x06004107 RID: 16647 RVA: 0x0009FCA4 File Offset: 0x0009DEA4
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

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x0009FCAD File Offset: 0x0009DEAD
		// (set) Token: 0x06004109 RID: 16649 RVA: 0x0009FCB5 File Offset: 0x0009DEB5
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

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x0009FCBE File Offset: 0x0009DEBE
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x0009FCC6 File Offset: 0x0009DEC6
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

		// Token: 0x0600410C RID: 16652 RVA: 0x0009FCCF File Offset: 0x0009DECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeStateConfirmResponse);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x0009FCE0 File Offset: 0x0009DEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeStateConfirmResponse other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x0009FD40 File Offset: 0x0009DF40
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

		// Token: 0x0600410F RID: 16655 RVA: 0x0009FDAE File Offset: 0x0009DFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0009FDBB File Offset: 0x0009DFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0009FDC4 File Offset: 0x0009DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FsmId);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Error);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0009FE3C File Offset: 0x0009E03C
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

		// Token: 0x06004113 RID: 16659 RVA: 0x0009FEAC File Offset: 0x0009E0AC
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

		// Token: 0x06004114 RID: 16660 RVA: 0x0009FF28 File Offset: 0x0009E128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x0009FF34 File Offset: 0x0009E134
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
				if (num != 16U)
				{
					if (num != 98U)
					{
						if (num != 104U)
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
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
					}
				}
				else
				{
					this.FsmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DDD RID: 11741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DDE RID: 11742
		public const int FsmIdFieldNumber = 2;

		// Token: 0x04002DDF RID: 11743
		private int fsmId_;

		// Token: 0x04002DE0 RID: 11744
		public const int StateFieldNumber = 13;

		// Token: 0x04002DE1 RID: 11745
		private int state_;

		// Token: 0x04002DE2 RID: 11746
		public const int ErrorFieldNumber = 12;

		// Token: 0x04002DE3 RID: 11747
		private DErrorResult error_;
	}
}
