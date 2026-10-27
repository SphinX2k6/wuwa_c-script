using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C2 RID: 5314
	[NetMessage(EMessageId.ValidTimeItemRequest)]
	public sealed class ValidTimeItemRequest : IMessage<ValidTimeItemRequest>, IMessage, IEquatable<ValidTimeItemRequest>, IDeepCloneable<ValidTimeItemRequest>, IBufferMessage
	{
		// Token: 0x0601C19D RID: 115101 RVA: 0x0040FEF5 File Offset: 0x0040E0F5
		[NullableContext(1)]
		public static ValidTimeItemRequest Create()
		{
			return new ValidTimeItemRequest();
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x0601C19E RID: 115102 RVA: 0x0040FEFC File Offset: 0x0040E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x0601C19F RID: 115103 RVA: 0x0040FEFF File Offset: 0x0040E0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemRequest.Descriptor;
			}
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x0040FF06 File Offset: 0x0040E106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest()
		{
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x0040FF0E File Offset: 0x0040E10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest(ValidTimeItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x0040FF27 File Offset: 0x0040E127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRequest Clone()
		{
			return new ValidTimeItemRequest(this);
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x0040FF2F File Offset: 0x0040E12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemRequest);
		}

		// Token: 0x0601C1A4 RID: 115108 RVA: 0x0040FF3D File Offset: 0x0040E13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x0040FF5C File Offset: 0x0040E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1A6 RID: 115110 RVA: 0x0040FF82 File Offset: 0x0040E182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x0040FF8F File Offset: 0x0040E18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1A8 RID: 115112 RVA: 0x0040FF98 File Offset: 0x0040E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1A9 RID: 115113 RVA: 0x0040FFB0 File Offset: 0x0040E1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1AA RID: 115114 RVA: 0x0040FFD6 File Offset: 0x0040E1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1AB RID: 115115 RVA: 0x0040FFF3 File Offset: 0x0040E1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1AC RID: 115116 RVA: 0x0040FFFC File Offset: 0x0040E1FC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A156 RID: 41302
		private UnknownFieldSet _unknownFields;
	}
}
