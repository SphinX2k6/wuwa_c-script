using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2D RID: 3373
	[NetMessage(EMessageId.PhotoFightSettleRequest)]
	public sealed class PhotoFightSettleRequest : IMessage<PhotoFightSettleRequest>, IMessage, IEquatable<PhotoFightSettleRequest>, IDeepCloneable<PhotoFightSettleRequest>, IBufferMessage
	{
		// Token: 0x0601236F RID: 74607 RVA: 0x002A9155 File Offset: 0x002A7355
		[NullableContext(1)]
		public static PhotoFightSettleRequest Create()
		{
			return new PhotoFightSettleRequest();
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x06012370 RID: 74608 RVA: 0x002A915C File Offset: 0x002A735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x06012371 RID: 74609 RVA: 0x002A915F File Offset: 0x002A735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightSettleRequest.Descriptor;
			}
		}

		// Token: 0x06012372 RID: 74610 RVA: 0x002A9166 File Offset: 0x002A7366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest()
		{
		}

		// Token: 0x06012373 RID: 74611 RVA: 0x002A916E File Offset: 0x002A736E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest(PhotoFightSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012374 RID: 74612 RVA: 0x002A9187 File Offset: 0x002A7387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest Clone()
		{
			return new PhotoFightSettleRequest(this);
		}

		// Token: 0x06012375 RID: 74613 RVA: 0x002A918F File Offset: 0x002A738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightSettleRequest);
		}

		// Token: 0x06012376 RID: 74614 RVA: 0x002A919D File Offset: 0x002A739D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012377 RID: 74615 RVA: 0x002A91BC File Offset: 0x002A73BC
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

		// Token: 0x06012378 RID: 74616 RVA: 0x002A91E2 File Offset: 0x002A73E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012379 RID: 74617 RVA: 0x002A91EF File Offset: 0x002A73EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601237A RID: 74618 RVA: 0x002A91F8 File Offset: 0x002A73F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601237B RID: 74619 RVA: 0x002A9210 File Offset: 0x002A7410
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

		// Token: 0x0601237C RID: 74620 RVA: 0x002A9236 File Offset: 0x002A7436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601237D RID: 74621 RVA: 0x002A9253 File Offset: 0x002A7453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601237E RID: 74622 RVA: 0x002A925C File Offset: 0x002A745C
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

		// Token: 0x040071C2 RID: 29122
		private UnknownFieldSet _unknownFields;
	}
}
