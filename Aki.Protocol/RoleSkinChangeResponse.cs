using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BB RID: 4283
	[NetMessage(EMessageId.RoleSkinChangeResponse)]
	public sealed class RoleSkinChangeResponse : IMessage<RoleSkinChangeResponse>, IMessage, IEquatable<RoleSkinChangeResponse>, IDeepCloneable<RoleSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06016DD3 RID: 93651 RVA: 0x00352457 File Offset: 0x00350657
		[NullableContext(1)]
		public static RoleSkinChangeResponse Create()
		{
			return new RoleSkinChangeResponse();
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x06016DD4 RID: 93652 RVA: 0x0035245E File Offset: 0x0035065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x06016DD5 RID: 93653 RVA: 0x00352461 File Offset: 0x00350661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06016DD6 RID: 93654 RVA: 0x00352468 File Offset: 0x00350668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse()
		{
		}

		// Token: 0x06016DD7 RID: 93655 RVA: 0x00352470 File Offset: 0x00350670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse(RoleSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DD8 RID: 93656 RVA: 0x00352495 File Offset: 0x00350695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse Clone()
		{
			return new RoleSkinChangeResponse(this);
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x06016DD9 RID: 93657 RVA: 0x0035249D File Offset: 0x0035069D
		// (set) Token: 0x06016DDA RID: 93658 RVA: 0x003524A5 File Offset: 0x003506A5
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

		// Token: 0x06016DDB RID: 93659 RVA: 0x003524AE File Offset: 0x003506AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeResponse);
		}

		// Token: 0x06016DDC RID: 93660 RVA: 0x003524BC File Offset: 0x003506BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DDD RID: 93661 RVA: 0x003524EC File Offset: 0x003506EC
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

		// Token: 0x06016DDE RID: 93662 RVA: 0x00352531 File Offset: 0x00350731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DDF RID: 93663 RVA: 0x0035253E File Offset: 0x0035073E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DE0 RID: 93664 RVA: 0x00352547 File Offset: 0x00350747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DE1 RID: 93665 RVA: 0x0035257C File Offset: 0x0035077C
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

		// Token: 0x06016DE2 RID: 93666 RVA: 0x003525BA File Offset: 0x003507BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinChangeResponse other)
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

		// Token: 0x06016DE3 RID: 93667 RVA: 0x003525EB File Offset: 0x003507EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x003525F4 File Offset: 0x003507F4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008863 RID: 34915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008864 RID: 34916
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008865 RID: 34917
		private ErrorCode errorCode_;
	}
}
