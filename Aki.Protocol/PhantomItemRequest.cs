using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE0 RID: 3296
	[NetMessage(EMessageId.PhantomItemRequest)]
	public sealed class PhantomItemRequest : IMessage<PhantomItemRequest>, IMessage, IEquatable<PhantomItemRequest>, IDeepCloneable<PhantomItemRequest>, IBufferMessage
	{
		// Token: 0x06011D5C RID: 73052 RVA: 0x0029C061 File Offset: 0x0029A261
		[NullableContext(1)]
		public static PhantomItemRequest Create()
		{
			return new PhantomItemRequest();
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x06011D5D RID: 73053 RVA: 0x0029C068 File Offset: 0x0029A268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x06011D5E RID: 73054 RVA: 0x0029C06B File Offset: 0x0029A26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemRequest.Descriptor;
			}
		}

		// Token: 0x06011D5F RID: 73055 RVA: 0x0029C072 File Offset: 0x0029A272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest()
		{
		}

		// Token: 0x06011D60 RID: 73056 RVA: 0x0029C07A File Offset: 0x0029A27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest(PhantomItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D61 RID: 73057 RVA: 0x0029C093 File Offset: 0x0029A293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest Clone()
		{
			return new PhantomItemRequest(this);
		}

		// Token: 0x06011D62 RID: 73058 RVA: 0x0029C09B File Offset: 0x0029A29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemRequest);
		}

		// Token: 0x06011D63 RID: 73059 RVA: 0x0029C0A9 File Offset: 0x0029A2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011D64 RID: 73060 RVA: 0x0029C0C8 File Offset: 0x0029A2C8
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

		// Token: 0x06011D65 RID: 73061 RVA: 0x0029C0EE File Offset: 0x0029A2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D66 RID: 73062 RVA: 0x0029C0FB File Offset: 0x0029A2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D67 RID: 73063 RVA: 0x0029C104 File Offset: 0x0029A304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D68 RID: 73064 RVA: 0x0029C11C File Offset: 0x0029A31C
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

		// Token: 0x06011D69 RID: 73065 RVA: 0x0029C142 File Offset: 0x0029A342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D6A RID: 73066 RVA: 0x0029C15F File Offset: 0x0029A35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D6B RID: 73067 RVA: 0x0029C168 File Offset: 0x0029A368
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

		// Token: 0x04006FFE RID: 28670
		private UnknownFieldSet _unknownFields;
	}
}
