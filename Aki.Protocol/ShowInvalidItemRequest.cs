using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124C RID: 4684
	[NetMessage(EMessageId.ShowInvalidItemRequest)]
	public sealed class ShowInvalidItemRequest : IMessage<ShowInvalidItemRequest>, IMessage, IEquatable<ShowInvalidItemRequest>, IDeepCloneable<ShowInvalidItemRequest>, IBufferMessage
	{
		// Token: 0x06019028 RID: 102440 RVA: 0x003A5515 File Offset: 0x003A3715
		[NullableContext(1)]
		public static ShowInvalidItemRequest Create()
		{
			return new ShowInvalidItemRequest();
		}

		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x06019029 RID: 102441 RVA: 0x003A551C File Offset: 0x003A371C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x0601902A RID: 102442 RVA: 0x003A551F File Offset: 0x003A371F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowInvalidItemRequest.Descriptor;
			}
		}

		// Token: 0x0601902B RID: 102443 RVA: 0x003A5526 File Offset: 0x003A3726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest()
		{
		}

		// Token: 0x0601902C RID: 102444 RVA: 0x003A552E File Offset: 0x003A372E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest(ShowInvalidItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601902D RID: 102445 RVA: 0x003A5547 File Offset: 0x003A3747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowInvalidItemRequest Clone()
		{
			return new ShowInvalidItemRequest(this);
		}

		// Token: 0x0601902E RID: 102446 RVA: 0x003A554F File Offset: 0x003A374F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowInvalidItemRequest);
		}

		// Token: 0x0601902F RID: 102447 RVA: 0x003A555D File Offset: 0x003A375D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowInvalidItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019030 RID: 102448 RVA: 0x003A557C File Offset: 0x003A377C
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

		// Token: 0x06019031 RID: 102449 RVA: 0x003A55A2 File Offset: 0x003A37A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019032 RID: 102450 RVA: 0x003A55AF File Offset: 0x003A37AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019033 RID: 102451 RVA: 0x003A55B8 File Offset: 0x003A37B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019034 RID: 102452 RVA: 0x003A55D0 File Offset: 0x003A37D0
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

		// Token: 0x06019035 RID: 102453 RVA: 0x003A55F6 File Offset: 0x003A37F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowInvalidItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019036 RID: 102454 RVA: 0x003A5613 File Offset: 0x003A3813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019037 RID: 102455 RVA: 0x003A561C File Offset: 0x003A381C
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

		// Token: 0x04009447 RID: 37959
		private UnknownFieldSet _unknownFields;
	}
}
