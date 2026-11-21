using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF1 RID: 3569
	[NetMessage(EMessageId.QueryRecallItemBagResponse)]
	public sealed class QueryRecallItemBagResponse : IMessage<QueryRecallItemBagResponse>, IMessage, IEquatable<QueryRecallItemBagResponse>, IDeepCloneable<QueryRecallItemBagResponse>, IBufferMessage
	{
		// Token: 0x06013382 RID: 78722 RVA: 0x002CCE95 File Offset: 0x002CB095
		[NullableContext(1)]
		public static QueryRecallItemBagResponse Create()
		{
			return new QueryRecallItemBagResponse();
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x06013383 RID: 78723 RVA: 0x002CCE9C File Offset: 0x002CB09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06013384 RID: 78724 RVA: 0x002CCE9F File Offset: 0x002CB09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRecallItemBagResponse.Descriptor;
			}
		}

		// Token: 0x06013385 RID: 78725 RVA: 0x002CCEA6 File Offset: 0x002CB0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse()
		{
		}

		// Token: 0x06013386 RID: 78726 RVA: 0x002CCEB9 File Offset: 0x002CB0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse(QueryRecallItemBagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013387 RID: 78727 RVA: 0x002CCEEF File Offset: 0x002CB0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagResponse Clone()
		{
			return new QueryRecallItemBagResponse(this);
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x06013388 RID: 78728 RVA: 0x002CCEF7 File Offset: 0x002CB0F7
		// (set) Token: 0x06013389 RID: 78729 RVA: 0x002CCEFF File Offset: 0x002CB0FF
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

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0601338A RID: 78730 RVA: 0x002CCF08 File Offset: 0x002CB108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x0601338B RID: 78731 RVA: 0x002CCF10 File Offset: 0x002CB110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRecallItemBagResponse);
		}

		// Token: 0x0601338C RID: 78732 RVA: 0x002CCF20 File Offset: 0x002CB120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryRecallItemBagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601338D RID: 78733 RVA: 0x002CCF70 File Offset: 0x002CB170
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

		// Token: 0x0601338E RID: 78734 RVA: 0x002CCFC3 File Offset: 0x002CB1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601338F RID: 78735 RVA: 0x002CCFD0 File Offset: 0x002CB1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013390 RID: 78736 RVA: 0x002CCFDC File Offset: 0x002CB1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, QueryRecallItemBagResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013391 RID: 78737 RVA: 0x002CD02C File Offset: 0x002CB22C
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

		// Token: 0x06013392 RID: 78738 RVA: 0x002CD080 File Offset: 0x002CB280
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

		// Token: 0x06013393 RID: 78739 RVA: 0x002CD0CD File Offset: 0x002CB2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013394 RID: 78740 RVA: 0x002CD0D8 File Offset: 0x002CB2D8
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, QueryRecallItemBagResponse._repeated_items_codec);
				}
			}
		}

		// Token: 0x040076AF RID: 30383
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076B0 RID: 30384
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040076B1 RID: 30385
		private ErrorCode errorCode_;

		// Token: 0x040076B2 RID: 30386
		public const int ItemsFieldNumber = 2;

		// Token: 0x040076B3 RID: 30387
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(18U, RecallItemBagItem.Parser);

		// Token: 0x040076B4 RID: 30388
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();
	}
}
