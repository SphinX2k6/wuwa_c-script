using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072A RID: 1834
	[NetMessage(EMessageId.HardnessModeChangedResponse)]
	public sealed class HardnessModeChangedResponse : IMessage<HardnessModeChangedResponse>, IMessage, IEquatable<HardnessModeChangedResponse>, IDeepCloneable<HardnessModeChangedResponse>, IBufferMessage
	{
		// Token: 0x0600A6B3 RID: 42675 RVA: 0x00191C58 File Offset: 0x0018FE58
		[NullableContext(1)]
		public static HardnessModeChangedResponse Create()
		{
			return new HardnessModeChangedResponse();
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x00191C5F File Offset: 0x0018FE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x0600A6B5 RID: 42677 RVA: 0x00191C62 File Offset: 0x0018FE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedResponse.Descriptor;
			}
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x00191C69 File Offset: 0x0018FE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse()
		{
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x00191C71 File Offset: 0x0018FE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse(HardnessModeChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x00191C96 File Offset: 0x0018FE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedResponse Clone()
		{
			return new HardnessModeChangedResponse(this);
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600A6B9 RID: 42681 RVA: 0x00191C9E File Offset: 0x0018FE9E
		// (set) Token: 0x0600A6BA RID: 42682 RVA: 0x00191CA6 File Offset: 0x0018FEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x00191CAF File Offset: 0x0018FEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedResponse);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x00191CBD File Offset: 0x0018FEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x00191CEC File Offset: 0x0018FEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x00191D31 File Offset: 0x0018FF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x00191D3E File Offset: 0x0018FF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x00191D47 File Offset: 0x0018FF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x00191D7C File Offset: 0x0018FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x00191DBA File Offset: 0x0018FFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HardnessModeChangedResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x00191DEB File Offset: 0x0018FFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x00191DF4 File Offset: 0x0018FFF4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CB3 RID: 19635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CB4 RID: 19636
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004CB5 RID: 19637
		private ErrorCode errorCode_;
	}
}
