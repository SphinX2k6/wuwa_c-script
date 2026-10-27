using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120C RID: 4620
	[NetMessage(EMessageId.ShortMessageShowChangeResponse)]
	public sealed class ShortMessageShowChangeResponse : IMessage<ShortMessageShowChangeResponse>, IMessage, IEquatable<ShortMessageShowChangeResponse>, IDeepCloneable<ShortMessageShowChangeResponse>, IBufferMessage
	{
		// Token: 0x060189FE RID: 100862 RVA: 0x00394B5F File Offset: 0x00392D5F
		[NullableContext(1)]
		public static ShortMessageShowChangeResponse Create()
		{
			return new ShortMessageShowChangeResponse();
		}

		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x060189FF RID: 100863 RVA: 0x00394B66 File Offset: 0x00392D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x06018A00 RID: 100864 RVA: 0x00394B69 File Offset: 0x00392D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageShowChangeResponse.Descriptor;
			}
		}

		// Token: 0x06018A01 RID: 100865 RVA: 0x00394B70 File Offset: 0x00392D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse()
		{
		}

		// Token: 0x06018A02 RID: 100866 RVA: 0x00394B78 File Offset: 0x00392D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse(ShortMessageShowChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A03 RID: 100867 RVA: 0x00394B9D File Offset: 0x00392D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeResponse Clone()
		{
			return new ShortMessageShowChangeResponse(this);
		}

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x06018A04 RID: 100868 RVA: 0x00394BA5 File Offset: 0x00392DA5
		// (set) Token: 0x06018A05 RID: 100869 RVA: 0x00394BAD File Offset: 0x00392DAD
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

		// Token: 0x06018A06 RID: 100870 RVA: 0x00394BB6 File Offset: 0x00392DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageShowChangeResponse);
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x00394BC4 File Offset: 0x00392DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageShowChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x00394BF4 File Offset: 0x00392DF4
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

		// Token: 0x06018A09 RID: 100873 RVA: 0x00394C39 File Offset: 0x00392E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A0A RID: 100874 RVA: 0x00394C46 File Offset: 0x00392E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A0B RID: 100875 RVA: 0x00394C4F File Offset: 0x00392E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A0C RID: 100876 RVA: 0x00394C84 File Offset: 0x00392E84
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

		// Token: 0x06018A0D RID: 100877 RVA: 0x00394CC2 File Offset: 0x00392EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageShowChangeResponse other)
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

		// Token: 0x06018A0E RID: 100878 RVA: 0x00394CF3 File Offset: 0x00392EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A0F RID: 100879 RVA: 0x00394CFC File Offset: 0x00392EFC
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400917D RID: 37245
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400917E RID: 37246
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400917F RID: 37247
		private ErrorCode errCode_;
	}
}
