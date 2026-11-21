using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B7 RID: 1975
	[NetMessage(EMessageId.IllustratedRedDotResponse)]
	public sealed class IllustratedRedDotResponse : IMessage<IllustratedRedDotResponse>, IMessage, IEquatable<IllustratedRedDotResponse>, IDeepCloneable<IllustratedRedDotResponse>, IBufferMessage
	{
		// Token: 0x0600B214 RID: 45588 RVA: 0x001AAC2E File Offset: 0x001A8E2E
		[NullableContext(1)]
		public static IllustratedRedDotResponse Create()
		{
			return new IllustratedRedDotResponse();
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600B215 RID: 45589 RVA: 0x001AAC35 File Offset: 0x001A8E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x001AAC38 File Offset: 0x001A8E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedRedDotResponse.Descriptor;
			}
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x001AAC3F File Offset: 0x001A8E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse()
		{
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x001AAC52 File Offset: 0x001A8E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse(IllustratedRedDotResponse other) : this()
		{
			this.redDotList_ = other.redDotList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x001AAC7C File Offset: 0x001A8E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotResponse Clone()
		{
			return new IllustratedRedDotResponse(this);
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x001AAC84 File Offset: 0x001A8E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedType> RedDotList
		{
			get
			{
				return this.redDotList_;
			}
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x001AAC8C File Offset: 0x001A8E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedRedDotResponse);
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x001AAC9A File Offset: 0x001A8E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedRedDotResponse other)
		{
			return other != null && (other == this || (this.redDotList_.Equals(other.redDotList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x001AACD0 File Offset: 0x001A8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.redDotList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x001AAD04 File Offset: 0x001A8F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x001AAD11 File Offset: 0x001A8F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x001AAD1A File Offset: 0x001A8F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.redDotList_.WriteTo(ref output, IllustratedRedDotResponse._repeated_redDotList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x001AAD44 File Offset: 0x001A8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.redDotList_.CalculateSize(IllustratedRedDotResponse._repeated_redDotList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x001AAD7D File Offset: 0x001A8F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedRedDotResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.redDotList_.Add(other.redDotList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x001AADAB File Offset: 0x001A8FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x001AADB4 File Offset: 0x001A8FB4
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.redDotList_.AddEntriesFrom(ref input, IllustratedRedDotResponse._repeated_redDotList_codec);
				}
			}
		}

		// Token: 0x04005005 RID: 20485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005006 RID: 20486
		public const int RedDotListFieldNumber = 10;

		// Token: 0x04005007 RID: 20487
		private static readonly FieldCodec<IllustratedType> _repeated_redDotList_codec = FieldCodec.ForEnum<IllustratedType>(82U, (IllustratedType x) => (int)x, (int x) => (IllustratedType)x);

		// Token: 0x04005008 RID: 20488
		private readonly RepeatedField<IllustratedType> redDotList_ = new RepeatedField<IllustratedType>();
	}
}
