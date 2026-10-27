using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000313 RID: 787
	[NetMessage(EMessageId.CreateBulletResponse)]
	public sealed class CreateBulletResponse : IMessage<CreateBulletResponse>, IMessage, IEquatable<CreateBulletResponse>, IDeepCloneable<CreateBulletResponse>, IBufferMessage
	{
		// Token: 0x06004F77 RID: 20343 RVA: 0x000C1FAF File Offset: 0x000C01AF
		[NullableContext(1)]
		public static CreateBulletResponse Create()
		{
			return new CreateBulletResponse();
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x000C1FB6 File Offset: 0x000C01B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x000C1FB9 File Offset: 0x000C01B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletResponse.Descriptor;
			}
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x000C1FC0 File Offset: 0x000C01C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse()
		{
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x000C1FC8 File Offset: 0x000C01C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse(CreateBulletResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x000C1FED File Offset: 0x000C01ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletResponse Clone()
		{
			return new CreateBulletResponse(this);
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x000C1FF5 File Offset: 0x000C01F5
		// (set) Token: 0x06004F7E RID: 20350 RVA: 0x000C1FFD File Offset: 0x000C01FD
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

		// Token: 0x06004F7F RID: 20351 RVA: 0x000C2006 File Offset: 0x000C0206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletResponse);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x000C2014 File Offset: 0x000C0214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x000C2044 File Offset: 0x000C0244
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

		// Token: 0x06004F82 RID: 20354 RVA: 0x000C2089 File Offset: 0x000C0289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x000C2096 File Offset: 0x000C0296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x000C209F File Offset: 0x000C029F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x000C20D4 File Offset: 0x000C02D4
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

		// Token: 0x06004F86 RID: 20358 RVA: 0x000C2112 File Offset: 0x000C0312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateBulletResponse other)
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

		// Token: 0x06004F87 RID: 20359 RVA: 0x000C2143 File Offset: 0x000C0343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x000C214C File Offset: 0x000C034C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400321A RID: 12826
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400321B RID: 12827
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400321C RID: 12828
		private ErrorCode errorCode_;
	}
}
