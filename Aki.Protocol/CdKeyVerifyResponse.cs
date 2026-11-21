using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000246 RID: 582
	[NetMessage(EMessageId.CdKeyVerifyResponse)]
	public sealed class CdKeyVerifyResponse : IMessage<CdKeyVerifyResponse>, IMessage, IEquatable<CdKeyVerifyResponse>, IDeepCloneable<CdKeyVerifyResponse>, IBufferMessage
	{
		// Token: 0x06003EA0 RID: 16032 RVA: 0x0009AFCD File Offset: 0x000991CD
		[NullableContext(1)]
		public static CdKeyVerifyResponse Create()
		{
			return new CdKeyVerifyResponse();
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x0009AFD4 File Offset: 0x000991D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x0009AFD7 File Offset: 0x000991D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CdKeyVerifyResponse.Descriptor;
			}
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0009AFDE File Offset: 0x000991DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse()
		{
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0009AFE6 File Offset: 0x000991E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse(CdKeyVerifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0009B00B File Offset: 0x0009920B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse Clone()
		{
			return new CdKeyVerifyResponse(this);
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x0009B013 File Offset: 0x00099213
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x0009B01B File Offset: 0x0009921B
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

		// Token: 0x06003EA8 RID: 16040 RVA: 0x0009B024 File Offset: 0x00099224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CdKeyVerifyResponse);
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0009B032 File Offset: 0x00099232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CdKeyVerifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0009B060 File Offset: 0x00099260
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

		// Token: 0x06003EAB RID: 16043 RVA: 0x0009B0A5 File Offset: 0x000992A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0009B0B2 File Offset: 0x000992B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x0009B0BB File Offset: 0x000992BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x0009B0F0 File Offset: 0x000992F0
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

		// Token: 0x06003EAF RID: 16047 RVA: 0x0009B12E File Offset: 0x0009932E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CdKeyVerifyResponse other)
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

		// Token: 0x06003EB0 RID: 16048 RVA: 0x0009B15F File Offset: 0x0009935F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0009B168 File Offset: 0x00099368
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D4B RID: 11595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D4C RID: 11596
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002D4D RID: 11597
		private ErrorCode errorCode_;
	}
}
