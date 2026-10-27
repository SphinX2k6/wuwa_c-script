using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000259 RID: 601
	[NetMessage(EMessageId.ChangePlayerTitleResponse)]
	public sealed class ChangePlayerTitleResponse : IMessage<ChangePlayerTitleResponse>, IMessage, IEquatable<ChangePlayerTitleResponse>, IDeepCloneable<ChangePlayerTitleResponse>, IBufferMessage
	{
		// Token: 0x06003FD1 RID: 16337 RVA: 0x0009CE25 File Offset: 0x0009B025
		[NullableContext(1)]
		public static ChangePlayerTitleResponse Create()
		{
			return new ChangePlayerTitleResponse();
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x0009CE2C File Offset: 0x0009B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x0009CE2F File Offset: 0x0009B02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerTitleResponse.Descriptor;
			}
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0009CE36 File Offset: 0x0009B036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse()
		{
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x0009CE3E File Offset: 0x0009B03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse(ChangePlayerTitleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x0009CE63 File Offset: 0x0009B063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleResponse Clone()
		{
			return new ChangePlayerTitleResponse(this);
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x0009CE6B File Offset: 0x0009B06B
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x0009CE73 File Offset: 0x0009B073
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

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0009CE7C File Offset: 0x0009B07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerTitleResponse);
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0009CE8A File Offset: 0x0009B08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerTitleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0009CEB8 File Offset: 0x0009B0B8
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

		// Token: 0x06003FDC RID: 16348 RVA: 0x0009CEFD File Offset: 0x0009B0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x0009CF0A File Offset: 0x0009B10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x0009CF13 File Offset: 0x0009B113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x0009CF44 File Offset: 0x0009B144
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

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0009CF82 File Offset: 0x0009B182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePlayerTitleResponse other)
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

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0009CFB3 File Offset: 0x0009B1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0009CFBC File Offset: 0x0009B1BC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D39 RID: 11577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3A RID: 11578
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002D3B RID: 11579
		private ErrorCode errorCode_;
	}
}
