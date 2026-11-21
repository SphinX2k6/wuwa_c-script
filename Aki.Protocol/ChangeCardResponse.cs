using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024B RID: 587
	[NetMessage(EMessageId.ChangeCardResponse)]
	public sealed class ChangeCardResponse : IMessage<ChangeCardResponse>, IMessage, IEquatable<ChangeCardResponse>, IDeepCloneable<ChangeCardResponse>, IBufferMessage
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x0009B9CD File Offset: 0x00099BCD
		[NullableContext(1)]
		public static ChangeCardResponse Create()
		{
			return new ChangeCardResponse();
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x0009B9D4 File Offset: 0x00099BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x0009B9D7 File Offset: 0x00099BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeCardResponse.Descriptor;
			}
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0009B9DE File Offset: 0x00099BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse()
		{
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x0009B9E6 File Offset: 0x00099BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse(ChangeCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x0009BA0B File Offset: 0x00099C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse Clone()
		{
			return new ChangeCardResponse(this);
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0009BA13 File Offset: 0x00099C13
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x0009BA1B File Offset: 0x00099C1B
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

		// Token: 0x06003F04 RID: 16132 RVA: 0x0009BA24 File Offset: 0x00099C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeCardResponse);
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x0009BA32 File Offset: 0x00099C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0009BA60 File Offset: 0x00099C60
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

		// Token: 0x06003F07 RID: 16135 RVA: 0x0009BAA5 File Offset: 0x00099CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0009BAB2 File Offset: 0x00099CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0009BABB File Offset: 0x00099CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0009BAF0 File Offset: 0x00099CF0
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

		// Token: 0x06003F0B RID: 16139 RVA: 0x0009BB2E File Offset: 0x00099D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeCardResponse other)
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

		// Token: 0x06003F0C RID: 16140 RVA: 0x0009BB5F File Offset: 0x00099D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0009BB68 File Offset: 0x00099D68
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D5C RID: 11612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D5D RID: 11613
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002D5E RID: 11614
		private ErrorCode errorCode_;
	}
}
