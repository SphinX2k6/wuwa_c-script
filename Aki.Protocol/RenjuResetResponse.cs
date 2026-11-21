using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0A RID: 3850
	[NetMessage(EMessageId.RenjuResetResponse)]
	public sealed class RenjuResetResponse : IMessage<RenjuResetResponse>, IMessage, IEquatable<RenjuResetResponse>, IDeepCloneable<RenjuResetResponse>, IBufferMessage
	{
		// Token: 0x06014A31 RID: 84529 RVA: 0x002FF4FD File Offset: 0x002FD6FD
		[NullableContext(1)]
		public static RenjuResetResponse Create()
		{
			return new RenjuResetResponse();
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x06014A32 RID: 84530 RVA: 0x002FF504 File Offset: 0x002FD704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x06014A33 RID: 84531 RVA: 0x002FF507 File Offset: 0x002FD707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuResetResponse.Descriptor;
			}
		}

		// Token: 0x06014A34 RID: 84532 RVA: 0x002FF50E File Offset: 0x002FD70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse()
		{
		}

		// Token: 0x06014A35 RID: 84533 RVA: 0x002FF516 File Offset: 0x002FD716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse(RenjuResetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A36 RID: 84534 RVA: 0x002FF53B File Offset: 0x002FD73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuResetResponse Clone()
		{
			return new RenjuResetResponse(this);
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x06014A37 RID: 84535 RVA: 0x002FF543 File Offset: 0x002FD743
		// (set) Token: 0x06014A38 RID: 84536 RVA: 0x002FF54B File Offset: 0x002FD74B
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

		// Token: 0x06014A39 RID: 84537 RVA: 0x002FF554 File Offset: 0x002FD754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuResetResponse);
		}

		// Token: 0x06014A3A RID: 84538 RVA: 0x002FF562 File Offset: 0x002FD762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuResetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A3B RID: 84539 RVA: 0x002FF590 File Offset: 0x002FD790
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

		// Token: 0x06014A3C RID: 84540 RVA: 0x002FF5D5 File Offset: 0x002FD7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A3D RID: 84541 RVA: 0x002FF5E2 File Offset: 0x002FD7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A3E RID: 84542 RVA: 0x002FF5EB File Offset: 0x002FD7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A3F RID: 84543 RVA: 0x002FF620 File Offset: 0x002FD820
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

		// Token: 0x06014A40 RID: 84544 RVA: 0x002FF65E File Offset: 0x002FD85E
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

		// Token: 0x06014A41 RID: 84545 RVA: 0x002FF68F File Offset: 0x002FD88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A42 RID: 84546 RVA: 0x002FF698 File Offset: 0x002FD898
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D39 RID: 32057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D3A RID: 32058
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04007D3B RID: 32059
		private ErrorCode errCode_;
	}
}
