using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120F RID: 4623
	[NetMessage(EMessageId.ShortMessageUpdateResponse)]
	public sealed class ShortMessageUpdateResponse : IMessage<ShortMessageUpdateResponse>, IMessage, IEquatable<ShortMessageUpdateResponse>, IDeepCloneable<ShortMessageUpdateResponse>, IBufferMessage
	{
		// Token: 0x06018A3C RID: 100924 RVA: 0x0039548B File Offset: 0x0039368B
		[NullableContext(1)]
		public static ShortMessageUpdateResponse Create()
		{
			return new ShortMessageUpdateResponse();
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x06018A3D RID: 100925 RVA: 0x00395492 File Offset: 0x00393692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x06018A3E RID: 100926 RVA: 0x00395495 File Offset: 0x00393695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06018A3F RID: 100927 RVA: 0x0039549C File Offset: 0x0039369C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse()
		{
		}

		// Token: 0x06018A40 RID: 100928 RVA: 0x003954A4 File Offset: 0x003936A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse(ShortMessageUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A41 RID: 100929 RVA: 0x003954C9 File Offset: 0x003936C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse Clone()
		{
			return new ShortMessageUpdateResponse(this);
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x06018A42 RID: 100930 RVA: 0x003954D1 File Offset: 0x003936D1
		// (set) Token: 0x06018A43 RID: 100931 RVA: 0x003954D9 File Offset: 0x003936D9
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

		// Token: 0x06018A44 RID: 100932 RVA: 0x003954E2 File Offset: 0x003936E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateResponse);
		}

		// Token: 0x06018A45 RID: 100933 RVA: 0x003954F0 File Offset: 0x003936F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A46 RID: 100934 RVA: 0x00395520 File Offset: 0x00393720
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

		// Token: 0x06018A47 RID: 100935 RVA: 0x00395565 File Offset: 0x00393765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A48 RID: 100936 RVA: 0x00395572 File Offset: 0x00393772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A49 RID: 100937 RVA: 0x0039557B File Offset: 0x0039377B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A4A RID: 100938 RVA: 0x003955B0 File Offset: 0x003937B0
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

		// Token: 0x06018A4B RID: 100939 RVA: 0x003955EE File Offset: 0x003937EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateResponse other)
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

		// Token: 0x06018A4C RID: 100940 RVA: 0x0039561F File Offset: 0x0039381F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A4D RID: 100941 RVA: 0x00395628 File Offset: 0x00393828
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009193 RID: 37267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009194 RID: 37268
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x04009195 RID: 37269
		private ErrorCode errCode_;
	}
}
