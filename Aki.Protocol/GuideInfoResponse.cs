using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000727 RID: 1831
	[NetMessage(EMessageId.GuideInfoResponse)]
	public sealed class GuideInfoResponse : IMessage<GuideInfoResponse>, IMessage, IEquatable<GuideInfoResponse>, IDeepCloneable<GuideInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A64A RID: 42570 RVA: 0x00190E66 File Offset: 0x0018F066
		[NullableContext(1)]
		public static GuideInfoResponse Create()
		{
			return new GuideInfoResponse();
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600A64B RID: 42571 RVA: 0x00190E6D File Offset: 0x0018F06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x00190E70 File Offset: 0x0018F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x00190E77 File Offset: 0x0018F077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse()
		{
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x00190E8A File Offset: 0x0018F08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse(GuideInfoResponse other) : this()
		{
			this.guideGroupFinishList_ = other.guideGroupFinishList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x00190EB4 File Offset: 0x0018F0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideInfoResponse Clone()
		{
			return new GuideInfoResponse(this);
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x00190EBC File Offset: 0x0018F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GuideGroupFinishList
		{
			get
			{
				return this.guideGroupFinishList_;
			}
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x00190EC4 File Offset: 0x0018F0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideInfoResponse);
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x00190ED2 File Offset: 0x0018F0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideInfoResponse other)
		{
			return other != null && (other == this || (this.guideGroupFinishList_.Equals(other.guideGroupFinishList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x00190F08 File Offset: 0x0018F108
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

		// Token: 0x0600A654 RID: 42580 RVA: 0x00190F3C File Offset: 0x0018F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x00190F49 File Offset: 0x0018F149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x00190F52 File Offset: 0x0018F152
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

		// Token: 0x0600A657 RID: 42583 RVA: 0x00190F7C File Offset: 0x0018F17C
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

		// Token: 0x0600A658 RID: 42584 RVA: 0x00190FB5 File Offset: 0x0018F1B5
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

		// Token: 0x0600A659 RID: 42585 RVA: 0x00190FE3 File Offset: 0x0018F1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x00190FEC File Offset: 0x0018F1EC
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.guideGroupFinishList_.AddEntriesFrom(ref input, GuideInfoResponse._repeated_guideGroupFinishList_codec);
				}
			}
		}

		// Token: 0x04004C4E RID: 19534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C4F RID: 19535
		public const int GuideGroupFinishListFieldNumber = 7;

		// Token: 0x04004C50 RID: 19536
		private static readonly FieldCodec<int> _repeated_guideGroupFinishList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004C51 RID: 19537
		private readonly RepeatedField<int> guideGroupFinishList_ = new RepeatedField<int>();
	}
}
