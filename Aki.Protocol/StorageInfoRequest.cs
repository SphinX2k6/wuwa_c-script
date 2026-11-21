using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001307 RID: 4871
	[NetMessage(EMessageId.StorageInfoRequest)]
	public sealed class StorageInfoRequest : IMessage<StorageInfoRequest>, IMessage, IEquatable<StorageInfoRequest>, IDeepCloneable<StorageInfoRequest>, IBufferMessage
	{
		// Token: 0x06019FAC RID: 106412 RVA: 0x003C9B0D File Offset: 0x003C7D0D
		[NullableContext(1)]
		public static StorageInfoRequest Create()
		{
			return new StorageInfoRequest();
		}

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x06019FAD RID: 106413 RVA: 0x003C9B14 File Offset: 0x003C7D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x06019FAE RID: 106414 RVA: 0x003C9B17 File Offset: 0x003C7D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06019FAF RID: 106415 RVA: 0x003C9B1E File Offset: 0x003C7D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest()
		{
		}

		// Token: 0x06019FB0 RID: 106416 RVA: 0x003C9B26 File Offset: 0x003C7D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest(StorageInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FB1 RID: 106417 RVA: 0x003C9B3F File Offset: 0x003C7D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest Clone()
		{
			return new StorageInfoRequest(this);
		}

		// Token: 0x06019FB2 RID: 106418 RVA: 0x003C9B47 File Offset: 0x003C7D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoRequest);
		}

		// Token: 0x06019FB3 RID: 106419 RVA: 0x003C9B55 File Offset: 0x003C7D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019FB4 RID: 106420 RVA: 0x003C9B74 File Offset: 0x003C7D74
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

		// Token: 0x06019FB5 RID: 106421 RVA: 0x003C9B9A File Offset: 0x003C7D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FB6 RID: 106422 RVA: 0x003C9BA7 File Offset: 0x003C7DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FB7 RID: 106423 RVA: 0x003C9BB0 File Offset: 0x003C7DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FB8 RID: 106424 RVA: 0x003C9BC8 File Offset: 0x003C7DC8
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

		// Token: 0x06019FB9 RID: 106425 RVA: 0x003C9BEE File Offset: 0x003C7DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FBA RID: 106426 RVA: 0x003C9C0B File Offset: 0x003C7E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FBB RID: 106427 RVA: 0x003C9C14 File Offset: 0x003C7E14
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

		// Token: 0x04009912 RID: 39186
		private UnknownFieldSet _unknownFields;
	}
}
