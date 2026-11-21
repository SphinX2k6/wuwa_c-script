using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D8 RID: 1752
	[NetMessage(EMessageId.GiftPackPreviewResponse)]
	public sealed class GiftPackPreviewResponse : IMessage<GiftPackPreviewResponse>, IMessage, IEquatable<GiftPackPreviewResponse>, IDeepCloneable<GiftPackPreviewResponse>, IBufferMessage
	{
		// Token: 0x0600A03E RID: 41022 RVA: 0x001845A9 File Offset: 0x001827A9
		[NullableContext(1)]
		public static GiftPackPreviewResponse Create()
		{
			return new GiftPackPreviewResponse();
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x001845B0 File Offset: 0x001827B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600A040 RID: 41024 RVA: 0x001845B3 File Offset: 0x001827B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftPackPreviewResponse.Descriptor;
			}
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x001845BA File Offset: 0x001827BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse()
		{
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x001845CD File Offset: 0x001827CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse(GiftPackPreviewResponse other) : this()
		{
			this.phantomPreview_ = other.phantomPreview_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x001845F7 File Offset: 0x001827F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewResponse Clone()
		{
			return new GiftPackPreviewResponse(this);
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x001845FF File Offset: 0x001827FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, PhantomItem> PhantomPreview
		{
			get
			{
				return this.phantomPreview_;
			}
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x00184607 File Offset: 0x00182807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftPackPreviewResponse);
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x00184615 File Offset: 0x00182815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiftPackPreviewResponse other)
		{
			return other != null && (other == this || (this.PhantomPreview.Equals(other.PhantomPreview) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x00184648 File Offset: 0x00182848
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

		// Token: 0x0600A048 RID: 41032 RVA: 0x0018467C File Offset: 0x0018287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x00184689 File Offset: 0x00182889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x00184692 File Offset: 0x00182892
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

		// Token: 0x0600A04B RID: 41035 RVA: 0x001846BC File Offset: 0x001828BC
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

		// Token: 0x0600A04C RID: 41036 RVA: 0x001846F5 File Offset: 0x001828F5
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

		// Token: 0x0600A04D RID: 41037 RVA: 0x00184723 File Offset: 0x00182923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x0018472C File Offset: 0x0018292C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomPreview_.AddEntriesFrom(ref input, GiftPackPreviewResponse._map_phantomPreview_codec);
				}
			}
		}

		// Token: 0x04004AFE RID: 19198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFF RID: 19199
		public const int PhantomPreviewFieldNumber = 6;

		// Token: 0x04004B00 RID: 19200
		private static readonly MapField<int, PhantomItem>.Codec _map_phantomPreview_codec = new MapField<int, PhantomItem>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<PhantomItem>(18U, PhantomItem.Parser), 50U);

		// Token: 0x04004B01 RID: 19201
		private readonly MapField<int, PhantomItem> phantomPreview_ = new MapField<int, PhantomItem>();
	}
}
