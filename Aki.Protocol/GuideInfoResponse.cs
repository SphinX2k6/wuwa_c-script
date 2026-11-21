using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000713 RID: 1811
	[NetMessage(EMessageId.GuideInfoResponse)]
	public sealed class GuideInfoResponse : IMessage<GuideInfoResponse>, IMessage, IEquatable<GuideInfoResponse>, IDeepCloneable<GuideInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A4F4 RID: 42228 RVA: 0x0018E432 File Offset: 0x0018C632
		[NullableContext(1)]
		public static GuideInfoResponse Create()
		{
			return new GuideInfoResponse();
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x0018E439 File Offset: 0x0018C639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600A4F6 RID: 42230 RVA: 0x0018E43C File Offset: 0x0018C63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x0018E443 File Offset: 0x0018C643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse()
		{
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x0018E456 File Offset: 0x0018C656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse(GuideInfoResponse other) : this()
		{
			this.guideGroupFinishList_ = other.guideGroupFinishList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x0018E480 File Offset: 0x0018C680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse Clone()
		{
			return new GuideInfoResponse(this);
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x0018E488 File Offset: 0x0018C688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GuideGroupFinishList
		{
			get
			{
				return this.guideGroupFinishList_;
			}
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x0018E490 File Offset: 0x0018C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideInfoResponse);
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x0018E49E File Offset: 0x0018C69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideInfoResponse other)
		{
			return other != null && (other == this || (this.guideGroupFinishList_.Equals(other.guideGroupFinishList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x0018E4D4 File Offset: 0x0018C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.guideGroupFinishList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x0018E508 File Offset: 0x0018C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x0018E515 File Offset: 0x0018C715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x0018E51E File Offset: 0x0018C71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.guideGroupFinishList_.WriteTo(ref output, GuideInfoResponse._repeated_guideGroupFinishList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x0018E548 File Offset: 0x0018C748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.guideGroupFinishList_.CalculateSize(GuideInfoResponse._repeated_guideGroupFinishList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x0018E581 File Offset: 0x0018C781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.guideGroupFinishList_.Add(other.guideGroupFinishList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x0018E5AF File Offset: 0x0018C7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x0018E5B8 File Offset: 0x0018C7B8
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.guideGroupFinishList_.AddEntriesFrom(ref input, GuideInfoResponse._repeated_guideGroupFinishList_codec);
				}
			}
		}

		// Token: 0x04004C47 RID: 19527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C48 RID: 19528
		public const int GuideGroupFinishListFieldNumber = 12;

		// Token: 0x04004C49 RID: 19529
		private static readonly FieldCodec<int> _repeated_guideGroupFinishList_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004C4A RID: 19530
		private readonly RepeatedField<int> guideGroupFinishList_ = new RepeatedField<int>();
	}
}
