using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000190 RID: 400
	[NetMessage(EMessageId.BeControlledResponse)]
	public sealed class BeControlledResponse : IMessage<BeControlledResponse>, IMessage, IEquatable<BeControlledResponse>, IDeepCloneable<BeControlledResponse>, IBufferMessage
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x0007AFF4 File Offset: 0x000791F4
		[NullableContext(1)]
		public static BeControlledResponse Create()
		{
			return new BeControlledResponse();
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x0007AFFB File Offset: 0x000791FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002FFE RID: 12286 RVA: 0x0007AFFE File Offset: 0x000791FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledResponse.Descriptor;
			}
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0007B005 File Offset: 0x00079205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse()
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0007B00D File Offset: 0x0007920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse(BeControlledResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x0007B032 File Offset: 0x00079232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse Clone()
		{
			return new BeControlledResponse(this);
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x0007B03A File Offset: 0x0007923A
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x0007B042 File Offset: 0x00079242
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

		// Token: 0x06003004 RID: 12292 RVA: 0x0007B04B File Offset: 0x0007924B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledResponse);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0007B059 File Offset: 0x00079259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0007B088 File Offset: 0x00079288
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

		// Token: 0x06003007 RID: 12295 RVA: 0x0007B0CD File Offset: 0x000792CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0007B0DA File Offset: 0x000792DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0007B0E3 File Offset: 0x000792E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0007B118 File Offset: 0x00079318
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

		// Token: 0x0600300B RID: 12299 RVA: 0x0007B156 File Offset: 0x00079356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledResponse other)
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

		// Token: 0x0600300C RID: 12300 RVA: 0x0007B187 File Offset: 0x00079387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0007B190 File Offset: 0x00079390
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400292B RID: 10539
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400292C RID: 10540
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400292D RID: 10541
		private ErrorCode errorCode_;
	}
}
