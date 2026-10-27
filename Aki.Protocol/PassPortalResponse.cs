using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD8 RID: 3032
	[NetMessage(EMessageId.PassPortalResponse)]
	public sealed class PassPortalResponse : IMessage<PassPortalResponse>, IMessage, IEquatable<PassPortalResponse>, IDeepCloneable<PassPortalResponse>, IBufferMessage
	{
		// Token: 0x060106AD RID: 67245 RVA: 0x00264B07 File Offset: 0x00262D07
		[NullableContext(1)]
		public static PassPortalResponse Create()
		{
			return new PassPortalResponse();
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x060106AE RID: 67246 RVA: 0x00264B0E File Offset: 0x00262D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x060106AF RID: 67247 RVA: 0x00264B11 File Offset: 0x00262D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassPortalResponse.Descriptor;
			}
		}

		// Token: 0x060106B0 RID: 67248 RVA: 0x00264B18 File Offset: 0x00262D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse()
		{
		}

		// Token: 0x060106B1 RID: 67249 RVA: 0x00264B20 File Offset: 0x00262D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse(PassPortalResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106B2 RID: 67250 RVA: 0x00264B45 File Offset: 0x00262D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse Clone()
		{
			return new PassPortalResponse(this);
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x060106B3 RID: 67251 RVA: 0x00264B4D File Offset: 0x00262D4D
		// (set) Token: 0x060106B4 RID: 67252 RVA: 0x00264B55 File Offset: 0x00262D55
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

		// Token: 0x060106B5 RID: 67253 RVA: 0x00264B5E File Offset: 0x00262D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassPortalResponse);
		}

		// Token: 0x060106B6 RID: 67254 RVA: 0x00264B6C File Offset: 0x00262D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassPortalResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106B7 RID: 67255 RVA: 0x00264B9C File Offset: 0x00262D9C
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

		// Token: 0x060106B8 RID: 67256 RVA: 0x00264BE1 File Offset: 0x00262DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106B9 RID: 67257 RVA: 0x00264BEE File Offset: 0x00262DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106BA RID: 67258 RVA: 0x00264BF7 File Offset: 0x00262DF7
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

		// Token: 0x060106BB RID: 67259 RVA: 0x00264C2C File Offset: 0x00262E2C
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

		// Token: 0x060106BC RID: 67260 RVA: 0x00264C6A File Offset: 0x00262E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassPortalResponse other)
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

		// Token: 0x060106BD RID: 67261 RVA: 0x00264C9B File Offset: 0x00262E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106BE RID: 67262 RVA: 0x00264CA4 File Offset: 0x00262EA4
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

		// Token: 0x0400681D RID: 26653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400681E RID: 26654
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400681F RID: 26655
		private ErrorCode errorCode_;
	}
}
