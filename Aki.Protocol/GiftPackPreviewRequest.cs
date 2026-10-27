using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EB RID: 1771
	[NetMessage(EMessageId.GiftPackPreviewRequest)]
	public sealed class GiftPackPreviewRequest : IMessage<GiftPackPreviewRequest>, IMessage, IEquatable<GiftPackPreviewRequest>, IDeepCloneable<GiftPackPreviewRequest>, IBufferMessage
	{
		// Token: 0x0600A182 RID: 41346 RVA: 0x00186E04 File Offset: 0x00185004
		[NullableContext(1)]
		public static GiftPackPreviewRequest Create()
		{
			return new GiftPackPreviewRequest();
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600A183 RID: 41347 RVA: 0x00186E0B File Offset: 0x0018500B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x00186E0E File Offset: 0x0018500E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftPackPreviewRequest.Descriptor;
			}
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x00186E15 File Offset: 0x00185015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest()
		{
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x00186E1D File Offset: 0x0018501D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest(GiftPackPreviewRequest other) : this()
		{
			this.giftPackId_ = other.giftPackId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x00186E42 File Offset: 0x00185042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiftPackPreviewRequest Clone()
		{
			return new GiftPackPreviewRequest(this);
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x00186E4A File Offset: 0x0018504A
		// (set) Token: 0x0600A189 RID: 41353 RVA: 0x00186E52 File Offset: 0x00185052
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

		// Token: 0x0600A18A RID: 41354 RVA: 0x00186E5B File Offset: 0x0018505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftPackPreviewRequest);
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x00186E69 File Offset: 0x00185069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiftPackPreviewRequest other)
		{
			return other != null && (other == this || (this.GiftPackId == other.GiftPackId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x00186E98 File Offset: 0x00185098
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

		// Token: 0x0600A18D RID: 41357 RVA: 0x00186ED7 File Offset: 0x001850D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x00186EE4 File Offset: 0x001850E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x00186EED File Offset: 0x001850ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiftPackId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.GiftPackId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x00186F20 File Offset: 0x00185120
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

		// Token: 0x0600A191 RID: 41361 RVA: 0x00186F5E File Offset: 0x0018515E
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

		// Token: 0x0600A192 RID: 41362 RVA: 0x00186F8F File Offset: 0x0018518F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x00186F98 File Offset: 0x00185198
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GiftPackId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B02 RID: 19202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B03 RID: 19203
		public const int GiftPackIdFieldNumber = 12;

		// Token: 0x04004B04 RID: 19204
		private int giftPackId_;
	}
}
