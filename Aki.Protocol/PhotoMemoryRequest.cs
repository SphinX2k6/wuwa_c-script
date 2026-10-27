using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D35 RID: 3381
	[NetMessage(EMessageId.PhotoMemoryRequest)]
	public sealed class PhotoMemoryRequest : IMessage<PhotoMemoryRequest>, IMessage, IEquatable<PhotoMemoryRequest>, IDeepCloneable<PhotoMemoryRequest>, IBufferMessage
	{
		// Token: 0x0601240A RID: 74762 RVA: 0x002AA41C File Offset: 0x002A861C
		[NullableContext(1)]
		public static PhotoMemoryRequest Create()
		{
			return new PhotoMemoryRequest();
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0601240B RID: 74763 RVA: 0x002AA423 File Offset: 0x002A8623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0601240C RID: 74764 RVA: 0x002AA426 File Offset: 0x002A8626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRequest.Descriptor;
			}
		}

		// Token: 0x0601240D RID: 74765 RVA: 0x002AA42D File Offset: 0x002A862D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest()
		{
		}

		// Token: 0x0601240E RID: 74766 RVA: 0x002AA435 File Offset: 0x002A8635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest(PhotoMemoryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601240F RID: 74767 RVA: 0x002AA44E File Offset: 0x002A864E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest Clone()
		{
			return new PhotoMemoryRequest(this);
		}

		// Token: 0x06012410 RID: 74768 RVA: 0x002AA456 File Offset: 0x002A8656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRequest);
		}

		// Token: 0x06012411 RID: 74769 RVA: 0x002AA464 File Offset: 0x002A8664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012412 RID: 74770 RVA: 0x002AA484 File Offset: 0x002A8684
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

		// Token: 0x06012413 RID: 74771 RVA: 0x002AA4AA File Offset: 0x002A86AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012414 RID: 74772 RVA: 0x002AA4B7 File Offset: 0x002A86B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012415 RID: 74773 RVA: 0x002AA4C0 File Offset: 0x002A86C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012416 RID: 74774 RVA: 0x002AA4D8 File Offset: 0x002A86D8
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

		// Token: 0x06012417 RID: 74775 RVA: 0x002AA4FE File Offset: 0x002A86FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012418 RID: 74776 RVA: 0x002AA51B File Offset: 0x002A871B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012419 RID: 74777 RVA: 0x002AA524 File Offset: 0x002A8724
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

		// Token: 0x040071E7 RID: 29159
		private UnknownFieldSet _unknownFields;
	}
}
