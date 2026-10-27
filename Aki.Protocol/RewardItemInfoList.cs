using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F35 RID: 3893
	public sealed class RewardItemInfoList : IMessage<RewardItemInfoList>, IMessage, IEquatable<RewardItemInfoList>, IDeepCloneable<RewardItemInfoList>, IBufferMessage
	{
		// Token: 0x06014D56 RID: 85334 RVA: 0x00305D24 File Offset: 0x00303F24
		[NullableContext(1)]
		public static RewardItemInfoList Create()
		{
			return new RewardItemInfoList();
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x06014D57 RID: 85335 RVA: 0x00305D2B File Offset: 0x00303F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemInfoList> Parser
		{
			get
			{
				return RewardItemInfoList._parser;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x06014D58 RID: 85336 RVA: 0x00305D32 File Offset: 0x00303F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x06014D59 RID: 85337 RVA: 0x00305D35 File Offset: 0x00303F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemInfoList.Descriptor;
			}
		}

		// Token: 0x06014D5A RID: 85338 RVA: 0x00305D3C File Offset: 0x00303F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList()
		{
		}

		// Token: 0x06014D5B RID: 85339 RVA: 0x00305D4F File Offset: 0x00303F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList(RewardItemInfoList other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D5C RID: 85340 RVA: 0x00305D79 File Offset: 0x00303F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList Clone()
		{
			return new RewardItemInfoList(this);
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x06014D5D RID: 85341 RVA: 0x00305D81 File Offset: 0x00303F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06014D5E RID: 85342 RVA: 0x00305D89 File Offset: 0x00303F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemInfoList);
		}

		// Token: 0x06014D5F RID: 85343 RVA: 0x00305D97 File Offset: 0x00303F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemInfoList other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D60 RID: 85344 RVA: 0x00305DCC File Offset: 0x00303FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D61 RID: 85345 RVA: 0x00305E00 File Offset: 0x00304000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D62 RID: 85346 RVA: 0x00305E0D File Offset: 0x0030400D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D63 RID: 85347 RVA: 0x00305E16 File Offset: 0x00304016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, RewardItemInfoList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D64 RID: 85348 RVA: 0x00305E40 File Offset: 0x00304040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(RewardItemInfoList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D65 RID: 85349 RVA: 0x00305E79 File Offset: 0x00304079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItemInfoList other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D66 RID: 85350 RVA: 0x00305EA7 File Offset: 0x003040A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D67 RID: 85351 RVA: 0x00305EB0 File Offset: 0x003040B0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, RewardItemInfoList._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x04007DB9 RID: 32185
		private static readonly MessageParser<RewardItemInfoList> _parser = new MessageParser<RewardItemInfoList>(() => new RewardItemInfoList());

		// Token: 0x04007DBA RID: 32186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DBB RID: 32187
		public const int ItemListFieldNumber = 1;

		// Token: 0x04007DBC RID: 32188
		private static readonly FieldCodec<RewardItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<RewardItemInfo>(10U, RewardItemInfo.Parser);

		// Token: 0x04007DBD RID: 32189
		private readonly RepeatedField<RewardItemInfo> itemList_ = new RepeatedField<RewardItemInfo>();
	}
}
