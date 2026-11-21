using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083B RID: 2107
	[NetMessage(EMessageId.ItemExchangeInfoRequest)]
	public sealed class ItemExchangeInfoRequest : IMessage<ItemExchangeInfoRequest>, IMessage, IEquatable<ItemExchangeInfoRequest>, IDeepCloneable<ItemExchangeInfoRequest>, IBufferMessage
	{
		// Token: 0x0600BC6B RID: 48235 RVA: 0x001C07FA File Offset: 0x001BE9FA
		[NullableContext(1)]
		public static ItemExchangeInfoRequest Create()
		{
			return new ItemExchangeInfoRequest();
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x001C0801 File Offset: 0x001BEA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x0600BC6D RID: 48237 RVA: 0x001C0804 File Offset: 0x001BEA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x001C080B File Offset: 0x001BEA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest()
		{
		}

		// Token: 0x0600BC6F RID: 48239 RVA: 0x001C0813 File Offset: 0x001BEA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest(ItemExchangeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC70 RID: 48240 RVA: 0x001C082C File Offset: 0x001BEA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest Clone()
		{
			return new ItemExchangeInfoRequest(this);
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x001C0834 File Offset: 0x001BEA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfoRequest);
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x001C0842 File Offset: 0x001BEA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x001C0860 File Offset: 0x001BEA60
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

		// Token: 0x0600BC74 RID: 48244 RVA: 0x001C0886 File Offset: 0x001BEA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x001C0893 File Offset: 0x001BEA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x001C089C File Offset: 0x001BEA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x001C08B4 File Offset: 0x001BEAB4
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

		// Token: 0x0600BC78 RID: 48248 RVA: 0x001C08DA File Offset: 0x001BEADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x001C08F7 File Offset: 0x001BEAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC7A RID: 48250 RVA: 0x001C0900 File Offset: 0x001BEB00
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

		// Token: 0x040052D8 RID: 21208
		private UnknownFieldSet _unknownFields;
	}
}
