using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000195 RID: 405
	[NetMessage(EMessageId.BeControlledThrowResponse)]
	public sealed class BeControlledThrowResponse : IMessage<BeControlledThrowResponse>, IMessage, IEquatable<BeControlledThrowResponse>, IDeepCloneable<BeControlledThrowResponse>, IBufferMessage
	{
		// Token: 0x06003060 RID: 12384 RVA: 0x0007BCCB File Offset: 0x00079ECB
		[NullableContext(1)]
		public static BeControlledThrowResponse Create()
		{
			return new BeControlledThrowResponse();
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x0007BCD2 File Offset: 0x00079ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x0007BCD5 File Offset: 0x00079ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledThrowResponse.Descriptor;
			}
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0007BCDC File Offset: 0x00079EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse()
		{
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0007BCE4 File Offset: 0x00079EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse(BeControlledThrowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0007BD09 File Offset: 0x00079F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowResponse Clone()
		{
			return new BeControlledThrowResponse(this);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x0007BD11 File Offset: 0x00079F11
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x0007BD19 File Offset: 0x00079F19
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

		// Token: 0x06003068 RID: 12392 RVA: 0x0007BD22 File Offset: 0x00079F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledThrowResponse);
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0007BD30 File Offset: 0x00079F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledThrowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0007BD60 File Offset: 0x00079F60
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

		// Token: 0x0600306B RID: 12395 RVA: 0x0007BDA5 File Offset: 0x00079FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0007BDB2 File Offset: 0x00079FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0007BDBB File Offset: 0x00079FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0007BDF0 File Offset: 0x00079FF0
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

		// Token: 0x0600306F RID: 12399 RVA: 0x0007BE2E File Offset: 0x0007A02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledThrowResponse other)
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

		// Token: 0x06003070 RID: 12400 RVA: 0x0007BE5F File Offset: 0x0007A05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0007BE68 File Offset: 0x0007A068
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002944 RID: 10564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002945 RID: 10565
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002946 RID: 10566
		private ErrorCode errorCode_;
	}
}
