using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1D RID: 3357
	[NetMessage(EMessageId.PhotoFightSettleRequest)]
	public sealed class PhotoFightSettleRequest : IMessage<PhotoFightSettleRequest>, IMessage, IEquatable<PhotoFightSettleRequest>, IDeepCloneable<PhotoFightSettleRequest>, IBufferMessage
	{
		// Token: 0x06012273 RID: 74355 RVA: 0x002A7530 File Offset: 0x002A5730
		[NullableContext(1)]
		public static PhotoFightSettleRequest Create()
		{
			return new PhotoFightSettleRequest();
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x06012274 RID: 74356 RVA: 0x002A7537 File Offset: 0x002A5737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x06012275 RID: 74357 RVA: 0x002A753A File Offset: 0x002A573A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightSettleRequest.Descriptor;
			}
		}

		// Token: 0x06012276 RID: 74358 RVA: 0x002A7541 File Offset: 0x002A5741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest()
		{
		}

		// Token: 0x06012277 RID: 74359 RVA: 0x002A7549 File Offset: 0x002A5749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest(PhotoFightSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012278 RID: 74360 RVA: 0x002A7562 File Offset: 0x002A5762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightSettleRequest Clone()
		{
			return new PhotoFightSettleRequest(this);
		}

		// Token: 0x06012279 RID: 74361 RVA: 0x002A756A File Offset: 0x002A576A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightSettleRequest);
		}

		// Token: 0x0601227A RID: 74362 RVA: 0x002A7578 File Offset: 0x002A5778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601227B RID: 74363 RVA: 0x002A7598 File Offset: 0x002A5798
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

		// Token: 0x0601227C RID: 74364 RVA: 0x002A75BE File Offset: 0x002A57BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601227D RID: 74365 RVA: 0x002A75CB File Offset: 0x002A57CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601227E RID: 74366 RVA: 0x002A75D4 File Offset: 0x002A57D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601227F RID: 74367 RVA: 0x002A75EC File Offset: 0x002A57EC
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

		// Token: 0x06012280 RID: 74368 RVA: 0x002A7612 File Offset: 0x002A5812
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

		// Token: 0x06012281 RID: 74369 RVA: 0x002A762F File Offset: 0x002A582F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012282 RID: 74370 RVA: 0x002A7638 File Offset: 0x002A5838
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

		// Token: 0x040071DA RID: 29146
		private UnknownFieldSet _unknownFields;
	}
}
