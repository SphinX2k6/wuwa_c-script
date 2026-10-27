using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1A RID: 3866
	[NetMessage(EMessageId.RenjuResetResponse)]
	public sealed class RenjuResetResponse : IMessage<RenjuResetResponse>, IMessage, IEquatable<RenjuResetResponse>, IDeepCloneable<RenjuResetResponse>, IBufferMessage
	{
		// Token: 0x06014B16 RID: 84758 RVA: 0x00300BB9 File Offset: 0x002FEDB9
		[NullableContext(1)]
		public static RenjuResetResponse Create()
		{
			return new RenjuResetResponse();
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x06014B17 RID: 84759 RVA: 0x00300BC0 File Offset: 0x002FEDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x06014B18 RID: 84760 RVA: 0x00300BC3 File Offset: 0x002FEDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuResetResponse.Descriptor;
			}
		}

		// Token: 0x06014B19 RID: 84761 RVA: 0x00300BCA File Offset: 0x002FEDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse()
		{
		}

		// Token: 0x06014B1A RID: 84762 RVA: 0x00300BD2 File Offset: 0x002FEDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse(RenjuResetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B1B RID: 84763 RVA: 0x00300BF7 File Offset: 0x002FEDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse Clone()
		{
			return new RenjuResetResponse(this);
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x06014B1C RID: 84764 RVA: 0x00300BFF File Offset: 0x002FEDFF
		// (set) Token: 0x06014B1D RID: 84765 RVA: 0x00300C07 File Offset: 0x002FEE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06014B1E RID: 84766 RVA: 0x00300C10 File Offset: 0x002FEE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuResetResponse);
		}

		// Token: 0x06014B1F RID: 84767 RVA: 0x00300C1E File Offset: 0x002FEE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuResetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B20 RID: 84768 RVA: 0x00300C4C File Offset: 0x002FEE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B21 RID: 84769 RVA: 0x00300C91 File Offset: 0x002FEE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B22 RID: 84770 RVA: 0x00300C9E File Offset: 0x002FEE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B23 RID: 84771 RVA: 0x00300CA7 File Offset: 0x002FEEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B24 RID: 84772 RVA: 0x00300CDC File Offset: 0x002FEEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B25 RID: 84773 RVA: 0x00300D1A File Offset: 0x002FEF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuResetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B26 RID: 84774 RVA: 0x00300D4B File Offset: 0x002FEF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B27 RID: 84775 RVA: 0x00300D54 File Offset: 0x002FEF54
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D0F RID: 32015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D10 RID: 32016
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04007D11 RID: 32017
		private ErrorCode errCode_;
	}
}
