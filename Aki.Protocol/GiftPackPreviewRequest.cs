using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D7 RID: 1751
	[NetMessage(EMessageId.GiftPackPreviewRequest)]
	public sealed class GiftPackPreviewRequest : IMessage<GiftPackPreviewRequest>, IMessage, IEquatable<GiftPackPreviewRequest>, IDeepCloneable<GiftPackPreviewRequest>, IBufferMessage
	{
		// Token: 0x0600A02C RID: 41004 RVA: 0x001843D0 File Offset: 0x001825D0
		[NullableContext(1)]
		public static GiftPackPreviewRequest Create()
		{
			return new GiftPackPreviewRequest();
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600A02D RID: 41005 RVA: 0x001843D7 File Offset: 0x001825D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x0600A02E RID: 41006 RVA: 0x001843DA File Offset: 0x001825DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftPackPreviewRequest.Descriptor;
			}
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x001843E1 File Offset: 0x001825E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest()
		{
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x001843E9 File Offset: 0x001825E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest(GiftPackPreviewRequest other) : this()
		{
			this.giftPackId_ = other.giftPackId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x0018440E File Offset: 0x0018260E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest Clone()
		{
			return new GiftPackPreviewRequest(this);
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600A032 RID: 41010 RVA: 0x00184416 File Offset: 0x00182616
		// (set) Token: 0x0600A033 RID: 41011 RVA: 0x0018441E File Offset: 0x0018261E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiftPackId
		{
			get
			{
				return this.giftPackId_;
			}
			set
			{
				this.giftPackId_ = value;
			}
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x00184427 File Offset: 0x00182627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftPackPreviewRequest);
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00184435 File Offset: 0x00182635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiftPackPreviewRequest other)
		{
			return other != null && (other == this || (this.GiftPackId == other.GiftPackId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00184464 File Offset: 0x00182664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiftPackId != 0)
			{
				num ^= this.GiftPackId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x001844A3 File Offset: 0x001826A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x001844B0 File Offset: 0x001826B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x001844B9 File Offset: 0x001826B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiftPackId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GiftPackId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x001844EC File Offset: 0x001826EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiftPackId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftPackId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x0018452A File Offset: 0x0018272A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiftPackPreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiftPackId != 0)
			{
				this.GiftPackId = other.GiftPackId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x0018455B File Offset: 0x0018275B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x00184564 File Offset: 0x00182764
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GiftPackId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AFB RID: 19195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFC RID: 19196
		public const int GiftPackIdFieldNumber = 5;

		// Token: 0x04004AFD RID: 19197
		private int giftPackId_;
	}
}
