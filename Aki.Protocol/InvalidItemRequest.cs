using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083C RID: 2108
	[NetMessage(EMessageId.InvalidItemRequest)]
	public sealed class InvalidItemRequest : IMessage<InvalidItemRequest>, IMessage, IEquatable<InvalidItemRequest>, IDeepCloneable<InvalidItemRequest>, IBufferMessage
	{
		// Token: 0x0600BC42 RID: 48194 RVA: 0x001C01E6 File Offset: 0x001BE3E6
		[NullableContext(1)]
		public static InvalidItemRequest Create()
		{
			return new InvalidItemRequest();
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x0600BC43 RID: 48195 RVA: 0x001C01ED File Offset: 0x001BE3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x001C01F0 File Offset: 0x001BE3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItemRequest.Descriptor;
			}
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x001C01F7 File Offset: 0x001BE3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest()
		{
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x001C01FF File Offset: 0x001BE3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest(InvalidItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x001C0218 File Offset: 0x001BE418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest Clone()
		{
			return new InvalidItemRequest(this);
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x001C0220 File Offset: 0x001BE420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItemRequest);
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x001C022E File Offset: 0x001BE42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x001C024C File Offset: 0x001BE44C
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

		// Token: 0x0600BC4B RID: 48203 RVA: 0x001C0272 File Offset: 0x001BE472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x001C027F File Offset: 0x001BE47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x001C0288 File Offset: 0x001BE488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x001C02A0 File Offset: 0x001BE4A0
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

		// Token: 0x0600BC4F RID: 48207 RVA: 0x001C02C6 File Offset: 0x001BE4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvalidItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x001C02E3 File Offset: 0x001BE4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x001C02EC File Offset: 0x001BE4EC
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

		// Token: 0x0400527B RID: 21115
		private UnknownFieldSet _unknownFields;
	}
}
