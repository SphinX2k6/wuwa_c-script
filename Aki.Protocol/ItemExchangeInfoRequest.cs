using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084D RID: 2125
	[NetMessage(EMessageId.ItemExchangeInfoRequest)]
	public sealed class ItemExchangeInfoRequest : IMessage<ItemExchangeInfoRequest>, IMessage, IEquatable<ItemExchangeInfoRequest>, IDeepCloneable<ItemExchangeInfoRequest>, IBufferMessage
	{
		// Token: 0x0600BD99 RID: 48537 RVA: 0x001C2CCE File Offset: 0x001C0ECE
		[NullableContext(1)]
		public static ItemExchangeInfoRequest Create()
		{
			return new ItemExchangeInfoRequest();
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600BD9A RID: 48538 RVA: 0x001C2CD5 File Offset: 0x001C0ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x001C2CD8 File Offset: 0x001C0ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x001C2CDF File Offset: 0x001C0EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest()
		{
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x001C2CE7 File Offset: 0x001C0EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest(ItemExchangeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x001C2D00 File Offset: 0x001C0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoRequest Clone()
		{
			return new ItemExchangeInfoRequest(this);
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x001C2D08 File Offset: 0x001C0F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfoRequest);
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x001C2D16 File Offset: 0x001C0F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x001C2D34 File Offset: 0x001C0F34
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

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x001C2D5A File Offset: 0x001C0F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x001C2D67 File Offset: 0x001C0F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x001C2D70 File Offset: 0x001C0F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x001C2D88 File Offset: 0x001C0F88
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

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x001C2DAE File Offset: 0x001C0FAE
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

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x001C2DCB File Offset: 0x001C0FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x001C2DD4 File Offset: 0x001C0FD4
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

		// Token: 0x040052D5 RID: 21205
		private UnknownFieldSet _unknownFields;
	}
}
