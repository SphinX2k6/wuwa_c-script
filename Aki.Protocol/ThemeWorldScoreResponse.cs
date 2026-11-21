using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D0 RID: 5072
	[NetMessage(EMessageId.ThemeWorldScoreResponse)]
	public sealed class ThemeWorldScoreResponse : IMessage<ThemeWorldScoreResponse>, IMessage, IEquatable<ThemeWorldScoreResponse>, IDeepCloneable<ThemeWorldScoreResponse>, IBufferMessage
	{
		// Token: 0x0601AFDA RID: 110554 RVA: 0x003EE5B9 File Offset: 0x003EC7B9
		[NullableContext(1)]
		public static ThemeWorldScoreResponse Create()
		{
			return new ThemeWorldScoreResponse();
		}

		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x0601AFDB RID: 110555 RVA: 0x003EE5C0 File Offset: 0x003EC7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x0601AFDC RID: 110556 RVA: 0x003EE5C3 File Offset: 0x003EC7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeWorldScoreResponse.Descriptor;
			}
		}

		// Token: 0x0601AFDD RID: 110557 RVA: 0x003EE5CA File Offset: 0x003EC7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse()
		{
		}

		// Token: 0x0601AFDE RID: 110558 RVA: 0x003EE5D2 File Offset: 0x003EC7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse(ThemeWorldScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFDF RID: 110559 RVA: 0x003EE5F7 File Offset: 0x003EC7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreResponse Clone()
		{
			return new ThemeWorldScoreResponse(this);
		}

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x0601AFE0 RID: 110560 RVA: 0x003EE5FF File Offset: 0x003EC7FF
		// (set) Token: 0x0601AFE1 RID: 110561 RVA: 0x003EE607 File Offset: 0x003EC807
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

		// Token: 0x0601AFE2 RID: 110562 RVA: 0x003EE610 File Offset: 0x003EC810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeWorldScoreResponse);
		}

		// Token: 0x0601AFE3 RID: 110563 RVA: 0x003EE61E File Offset: 0x003EC81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeWorldScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFE4 RID: 110564 RVA: 0x003EE64C File Offset: 0x003EC84C
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

		// Token: 0x0601AFE5 RID: 110565 RVA: 0x003EE691 File Offset: 0x003EC891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFE6 RID: 110566 RVA: 0x003EE69E File Offset: 0x003EC89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFE7 RID: 110567 RVA: 0x003EE6A7 File Offset: 0x003EC8A7
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

		// Token: 0x0601AFE8 RID: 110568 RVA: 0x003EE6DC File Offset: 0x003EC8DC
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

		// Token: 0x0601AFE9 RID: 110569 RVA: 0x003EE71A File Offset: 0x003EC91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeWorldScoreResponse other)
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

		// Token: 0x0601AFEA RID: 110570 RVA: 0x003EE74B File Offset: 0x003EC94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFEB RID: 110571 RVA: 0x003EE754 File Offset: 0x003EC954
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

		// Token: 0x04009DC7 RID: 40391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DC8 RID: 40392
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009DC9 RID: 40393
		private ErrorCode errorCode_;
	}
}
