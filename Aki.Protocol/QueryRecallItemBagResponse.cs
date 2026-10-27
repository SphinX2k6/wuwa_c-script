using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E01 RID: 3585
	[NetMessage(EMessageId.QueryRecallItemBagResponse)]
	public sealed class QueryRecallItemBagResponse : IMessage<QueryRecallItemBagResponse>, IMessage, IEquatable<QueryRecallItemBagResponse>, IDeepCloneable<QueryRecallItemBagResponse>, IBufferMessage
	{
		// Token: 0x06013467 RID: 78951 RVA: 0x002CE551 File Offset: 0x002CC751
		[NullableContext(1)]
		public static QueryRecallItemBagResponse Create()
		{
			return new QueryRecallItemBagResponse();
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x06013468 RID: 78952 RVA: 0x002CE558 File Offset: 0x002CC758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x06013469 RID: 78953 RVA: 0x002CE55B File Offset: 0x002CC75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRecallItemBagResponse.Descriptor;
			}
		}

		// Token: 0x0601346A RID: 78954 RVA: 0x002CE562 File Offset: 0x002CC762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse()
		{
		}

		// Token: 0x0601346B RID: 78955 RVA: 0x002CE575 File Offset: 0x002CC775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse(QueryRecallItemBagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601346C RID: 78956 RVA: 0x002CE5AB File Offset: 0x002CC7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse Clone()
		{
			return new QueryRecallItemBagResponse(this);
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0601346D RID: 78957 RVA: 0x002CE5B3 File Offset: 0x002CC7B3
		// (set) Token: 0x0601346E RID: 78958 RVA: 0x002CE5BB File Offset: 0x002CC7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0601346F RID: 78959 RVA: 0x002CE5C4 File Offset: 0x002CC7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06013470 RID: 78960 RVA: 0x002CE5CC File Offset: 0x002CC7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRecallItemBagResponse);
		}

		// Token: 0x06013471 RID: 78961 RVA: 0x002CE5DC File Offset: 0x002CC7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryRecallItemBagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013472 RID: 78962 RVA: 0x002CE62C File Offset: 0x002CC82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013473 RID: 78963 RVA: 0x002CE67F File Offset: 0x002CC87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013474 RID: 78964 RVA: 0x002CE68C File Offset: 0x002CC88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013475 RID: 78965 RVA: 0x002CE698 File Offset: 0x002CC898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.items_.WriteTo(ref output, QueryRecallItemBagResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013476 RID: 78966 RVA: 0x002CE6E8 File Offset: 0x002CC8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(QueryRecallItemBagResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013477 RID: 78967 RVA: 0x002CE73C File Offset: 0x002CC93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryRecallItemBagResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013478 RID: 78968 RVA: 0x002CE789 File Offset: 0x002CC989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013479 RID: 78969 RVA: 0x002CE794 File Offset: 0x002CC994
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, QueryRecallItemBagResponse._repeated_items_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007685 RID: 30341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007686 RID: 30342
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007687 RID: 30343
		private ErrorCode errorCode_;

		// Token: 0x04007688 RID: 30344
		public const int ItemsFieldNumber = 7;

		// Token: 0x04007689 RID: 30345
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(58U, RecallItemBagItem.Parser);

		// Token: 0x0400768A RID: 30346
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();
	}
}
