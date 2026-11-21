using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000828 RID: 2088
	[NetMessage(EMessageId.InvalidItemRequest)]
	public sealed class InvalidItemRequest : IMessage<InvalidItemRequest>, IMessage, IEquatable<InvalidItemRequest>, IDeepCloneable<InvalidItemRequest>, IBufferMessage
	{
		// Token: 0x0600BAEC RID: 47852 RVA: 0x001BD7AA File Offset: 0x001BB9AA
		[NullableContext(1)]
		public static InvalidItemRequest Create()
		{
			return new InvalidItemRequest();
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x0600BAED RID: 47853 RVA: 0x001BD7B1 File Offset: 0x001BB9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x001BD7B4 File Offset: 0x001BB9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItemRequest.Descriptor;
			}
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x001BD7BB File Offset: 0x001BB9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest()
		{
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x001BD7C3 File Offset: 0x001BB9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest(InvalidItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x001BD7DC File Offset: 0x001BB9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItemRequest Clone()
		{
			return new InvalidItemRequest(this);
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x001BD7E4 File Offset: 0x001BB9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItemRequest);
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x001BD7F2 File Offset: 0x001BB9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x001BD810 File Offset: 0x001BBA10
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

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x001BD836 File Offset: 0x001BBA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x001BD843 File Offset: 0x001BBA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x001BD84C File Offset: 0x001BBA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x001BD864 File Offset: 0x001BBA64
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

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x001BD88A File Offset: 0x001BBA8A
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

		// Token: 0x0600BAFA RID: 47866 RVA: 0x001BD8A7 File Offset: 0x001BBAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x001BD8B0 File Offset: 0x001BBAB0
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

		// Token: 0x04005274 RID: 21108
		private UnknownFieldSet _unknownFields;
	}
}
