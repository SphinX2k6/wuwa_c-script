using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D25 RID: 3365
	[NetMessage(EMessageId.PhotoMemoryRequest)]
	public sealed class PhotoMemoryRequest : IMessage<PhotoMemoryRequest>, IMessage, IEquatable<PhotoMemoryRequest>, IDeepCloneable<PhotoMemoryRequest>, IBufferMessage
	{
		// Token: 0x0601230E RID: 74510 RVA: 0x002A87F4 File Offset: 0x002A69F4
		[NullableContext(1)]
		public static PhotoMemoryRequest Create()
		{
			return new PhotoMemoryRequest();
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0601230F RID: 74511 RVA: 0x002A87FB File Offset: 0x002A69FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x06012310 RID: 74512 RVA: 0x002A87FE File Offset: 0x002A69FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRequest.Descriptor;
			}
		}

		// Token: 0x06012311 RID: 74513 RVA: 0x002A8805 File Offset: 0x002A6A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest()
		{
		}

		// Token: 0x06012312 RID: 74514 RVA: 0x002A880D File Offset: 0x002A6A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest(PhotoMemoryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012313 RID: 74515 RVA: 0x002A8826 File Offset: 0x002A6A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRequest Clone()
		{
			return new PhotoMemoryRequest(this);
		}

		// Token: 0x06012314 RID: 74516 RVA: 0x002A882E File Offset: 0x002A6A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRequest);
		}

		// Token: 0x06012315 RID: 74517 RVA: 0x002A883C File Offset: 0x002A6A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012316 RID: 74518 RVA: 0x002A885C File Offset: 0x002A6A5C
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

		// Token: 0x06012317 RID: 74519 RVA: 0x002A8882 File Offset: 0x002A6A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012318 RID: 74520 RVA: 0x002A888F File Offset: 0x002A6A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012319 RID: 74521 RVA: 0x002A8898 File Offset: 0x002A6A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601231A RID: 74522 RVA: 0x002A88B0 File Offset: 0x002A6AB0
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

		// Token: 0x0601231B RID: 74523 RVA: 0x002A88D6 File Offset: 0x002A6AD6
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

		// Token: 0x0601231C RID: 74524 RVA: 0x002A88F3 File Offset: 0x002A6AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601231D RID: 74525 RVA: 0x002A88FC File Offset: 0x002A6AFC
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

		// Token: 0x040071FF RID: 29183
		private UnknownFieldSet _unknownFields;
	}
}
