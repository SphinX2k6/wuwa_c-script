using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EC RID: 1772
	[NetMessage(EMessageId.GiftPackPreviewResponse)]
	public sealed class GiftPackPreviewResponse : IMessage<GiftPackPreviewResponse>, IMessage, IEquatable<GiftPackPreviewResponse>, IDeepCloneable<GiftPackPreviewResponse>, IBufferMessage
	{
		// Token: 0x0600A194 RID: 41364 RVA: 0x00186FDD File Offset: 0x001851DD
		[NullableContext(1)]
		public static GiftPackPreviewResponse Create()
		{
			return new GiftPackPreviewResponse();
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x00186FE4 File Offset: 0x001851E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x00186FE7 File Offset: 0x001851E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftPackPreviewResponse.Descriptor;
			}
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x00186FEE File Offset: 0x001851EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse()
		{
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x00187001 File Offset: 0x00185201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse(GiftPackPreviewResponse other) : this()
		{
			this.phantomPreview_ = other.phantomPreview_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x0018702B File Offset: 0x0018522B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse Clone()
		{
			return new GiftPackPreviewResponse(this);
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600A19A RID: 41370 RVA: 0x00187033 File Offset: 0x00185233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, PhantomItem> PhantomPreview
		{
			get
			{
				return this.phantomPreview_;
			}
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x0018703B File Offset: 0x0018523B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftPackPreviewResponse);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x00187049 File Offset: 0x00185249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiftPackPreviewResponse other)
		{
			return other != null && (other == this || (this.PhantomPreview.Equals(other.PhantomPreview) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x0018707C File Offset: 0x0018527C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.PhantomPreview.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x001870B0 File Offset: 0x001852B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x001870BD File Offset: 0x001852BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x001870C6 File Offset: 0x001852C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomPreview_.WriteTo(ref output, GiftPackPreviewResponse._map_phantomPreview_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x001870F0 File Offset: 0x001852F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomPreview_.CalculateSize(GiftPackPreviewResponse._map_phantomPreview_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x00187129 File Offset: 0x00185329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiftPackPreviewResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomPreview_.MergeFrom(other.phantomPreview_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00187157 File Offset: 0x00185357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x00187160 File Offset: 0x00185360
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomPreview_.AddEntriesFrom(ref input, GiftPackPreviewResponse._map_phantomPreview_codec);
				}
			}
		}

		// Token: 0x04004B05 RID: 19205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B06 RID: 19206
		public const int PhantomPreviewFieldNumber = 3;

		// Token: 0x04004B07 RID: 19207
		private static readonly MapField<int, PhantomItem>.Codec _map_phantomPreview_codec = new MapField<int, PhantomItem>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<PhantomItem>(18U, PhantomItem.Parser), 26U);

		// Token: 0x04004B08 RID: 19208
		private readonly MapField<int, PhantomItem> phantomPreview_ = new MapField<int, PhantomItem>();
	}
}
