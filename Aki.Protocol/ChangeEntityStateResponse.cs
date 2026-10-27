using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024D RID: 589
	[NetMessage(EMessageId.ChangeEntityStateResponse)]
	public sealed class ChangeEntityStateResponse : IMessage<ChangeEntityStateResponse>, IMessage, IEquatable<ChangeEntityStateResponse>, IDeepCloneable<ChangeEntityStateResponse>, IBufferMessage
	{
		// Token: 0x06003EE5 RID: 16101 RVA: 0x0009B084 File Offset: 0x00099284
		[NullableContext(1)]
		public static ChangeEntityStateResponse Create()
		{
			return new ChangeEntityStateResponse();
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x0009B08B File Offset: 0x0009928B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x0009B08E File Offset: 0x0009928E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityStateResponse.Descriptor;
			}
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x0009B095 File Offset: 0x00099295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse()
		{
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x0009B09D File Offset: 0x0009929D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse(ChangeEntityStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0009B0C2 File Offset: 0x000992C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse Clone()
		{
			return new ChangeEntityStateResponse(this);
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x0009B0CA File Offset: 0x000992CA
		// (set) Token: 0x06003EEC RID: 16108 RVA: 0x0009B0D2 File Offset: 0x000992D2
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

		// Token: 0x06003EED RID: 16109 RVA: 0x0009B0DB File Offset: 0x000992DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityStateResponse);
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0009B0E9 File Offset: 0x000992E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0009B118 File Offset: 0x00099318
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

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0009B15D File Offset: 0x0009935D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0009B16A File Offset: 0x0009936A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0009B173 File Offset: 0x00099373
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

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0009B1A8 File Offset: 0x000993A8
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

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0009B1E6 File Offset: 0x000993E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityStateResponse other)
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

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0009B217 File Offset: 0x00099417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0009B220 File Offset: 0x00099420
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

		// Token: 0x04002CFF RID: 11519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D00 RID: 11520
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002D01 RID: 11521
		private ErrorCode errorCode_;
	}
}
