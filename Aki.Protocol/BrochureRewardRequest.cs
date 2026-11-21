using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E8 RID: 488
	[NetMessage(EMessageId.BrochureRewardRequest)]
	public sealed class BrochureRewardRequest : IMessage<BrochureRewardRequest>, IMessage, IEquatable<BrochureRewardRequest>, IDeepCloneable<BrochureRewardRequest>, IBufferMessage
	{
		// Token: 0x060036F8 RID: 14072 RVA: 0x0008A015 File Offset: 0x00088215
		[NullableContext(1)]
		public static BrochureRewardRequest Create()
		{
			return new BrochureRewardRequest();
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x0008A01C File Offset: 0x0008821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x0008A01F File Offset: 0x0008821F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BrochureRewardRequest.Descriptor;
			}
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x0008A026 File Offset: 0x00088226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest()
		{
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x0008A03C File Offset: 0x0008823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest(BrochureRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.brochureId_ = other.brochureId_;
			this.bookItems_ = other.bookItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x0008A089 File Offset: 0x00088289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardRequest Clone()
		{
			return new BrochureRewardRequest(this);
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0008A091 File Offset: 0x00088291
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x0008A099 File Offset: 0x00088299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x0008A0A2 File Offset: 0x000882A2
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x0008A0AA File Offset: 0x000882AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BrochureId
		{
			get
			{
				return this.brochureId_;
			}
			set
			{
				this.brochureId_ = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x0008A0B3 File Offset: 0x000882B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BookItems
		{
			get
			{
				return this.bookItems_;
			}
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x0008A0BB File Offset: 0x000882BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BrochureRewardRequest);
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x0008A0CC File Offset: 0x000882CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BrochureRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BrochureId == other.BrochureId && this.bookItems_.Equals(other.bookItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x0008A12C File Offset: 0x0008832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BrochureId != 0)
			{
				num ^= this.BrochureId.GetHashCode();
			}
			num ^= this.bookItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0008A192 File Offset: 0x00088392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0008A19F File Offset: 0x0008839F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0008A1A8 File Offset: 0x000883A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BrochureId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BrochureId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			this.bookItems_.WriteTo(ref output, BrochureRewardRequest._repeated_bookItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x0008A214 File Offset: 0x00088414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BrochureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BrochureId);
			}
			num += this.bookItems_.CalculateSize(BrochureRewardRequest._repeated_bookItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x0008A280 File Offset: 0x00088480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BrochureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BrochureId != 0)
			{
				this.BrochureId = other.BrochureId;
			}
			this.bookItems_.Add(other.bookItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x0008A2E1 File Offset: 0x000884E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0008A2EC File Offset: 0x000884EC
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
				if (num <= 88U)
				{
					if (num == 24U)
					{
						this.BrochureId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.bookItems_.AddEntriesFrom(ref input, BrochureRewardRequest._repeated_bookItems_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B1A RID: 11034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B1B RID: 11035
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04002B1C RID: 11036
		private int activityId_;

		// Token: 0x04002B1D RID: 11037
		public const int BrochureIdFieldNumber = 3;

		// Token: 0x04002B1E RID: 11038
		private int brochureId_;

		// Token: 0x04002B1F RID: 11039
		public const int BookItemsFieldNumber = 13;

		// Token: 0x04002B20 RID: 11040
		private static readonly FieldCodec<int> _repeated_bookItems_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04002B21 RID: 11041
		private readonly RepeatedField<int> bookItems_ = new RepeatedField<int>();
	}
}
