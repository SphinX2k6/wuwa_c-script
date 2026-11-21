using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F08 RID: 3848
	[NetMessage(EMessageId.RenjuExitMatchedActionResponse)]
	public sealed class RenjuExitMatchedActionResponse : IMessage<RenjuExitMatchedActionResponse>, IMessage, IEquatable<RenjuExitMatchedActionResponse>, IDeepCloneable<RenjuExitMatchedActionResponse>, IBufferMessage
	{
		// Token: 0x06014A0D RID: 84493 RVA: 0x002FF145 File Offset: 0x002FD345
		[NullableContext(1)]
		public static RenjuExitMatchedActionResponse Create()
		{
			return new RenjuExitMatchedActionResponse();
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x06014A0E RID: 84494 RVA: 0x002FF14C File Offset: 0x002FD34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x06014A0F RID: 84495 RVA: 0x002FF14F File Offset: 0x002FD34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuExitMatchedActionResponse.Descriptor;
			}
		}

		// Token: 0x06014A10 RID: 84496 RVA: 0x002FF156 File Offset: 0x002FD356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse()
		{
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x002FF15E File Offset: 0x002FD35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse(RenjuExitMatchedActionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A12 RID: 84498 RVA: 0x002FF183 File Offset: 0x002FD383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse Clone()
		{
			return new RenjuExitMatchedActionResponse(this);
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x06014A13 RID: 84499 RVA: 0x002FF18B File Offset: 0x002FD38B
		// (set) Token: 0x06014A14 RID: 84500 RVA: 0x002FF193 File Offset: 0x002FD393
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

		// Token: 0x06014A15 RID: 84501 RVA: 0x002FF19C File Offset: 0x002FD39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuExitMatchedActionResponse);
		}

		// Token: 0x06014A16 RID: 84502 RVA: 0x002FF1AA File Offset: 0x002FD3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuExitMatchedActionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A17 RID: 84503 RVA: 0x002FF1D8 File Offset: 0x002FD3D8
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

		// Token: 0x06014A18 RID: 84504 RVA: 0x002FF21D File Offset: 0x002FD41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A19 RID: 84505 RVA: 0x002FF22A File Offset: 0x002FD42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A1A RID: 84506 RVA: 0x002FF233 File Offset: 0x002FD433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A1B RID: 84507 RVA: 0x002FF268 File Offset: 0x002FD468
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

		// Token: 0x06014A1C RID: 84508 RVA: 0x002FF2A6 File Offset: 0x002FD4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuExitMatchedActionResponse other)
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

		// Token: 0x06014A1D RID: 84509 RVA: 0x002FF2D7 File Offset: 0x002FD4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A1E RID: 84510 RVA: 0x002FF2E0 File Offset: 0x002FD4E0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D33 RID: 32051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D34 RID: 32052
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x04007D35 RID: 32053
		private ErrorCode errCode_;
	}
}
