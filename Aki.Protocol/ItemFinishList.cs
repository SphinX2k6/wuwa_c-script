using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000851 RID: 2129
	public sealed class ItemFinishList : IMessage<ItemFinishList>, IMessage, IEquatable<ItemFinishList>, IDeepCloneable<ItemFinishList>, IBufferMessage
	{
		// Token: 0x0600BDE5 RID: 48613 RVA: 0x001C35D3 File Offset: 0x001C17D3
		[NullableContext(1)]
		public static ItemFinishList Create()
		{
			return new ItemFinishList();
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600BDE6 RID: 48614 RVA: 0x001C35DA File Offset: 0x001C17DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemFinishList> Parser
		{
			get
			{
				return ItemFinishList._parser;
			}
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x0600BDE7 RID: 48615 RVA: 0x001C35E1 File Offset: 0x001C17E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x0600BDE8 RID: 48616 RVA: 0x001C35E4 File Offset: 0x001C17E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemFinishList.Descriptor;
			}
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x001C35EB File Offset: 0x001C17EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList()
		{
		}

		// Token: 0x0600BDEA RID: 48618 RVA: 0x001C35FE File Offset: 0x001C17FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList(ItemFinishList other) : this()
		{
			this.conditionIdList_ = other.conditionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x001C3628 File Offset: 0x001C1828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList Clone()
		{
			return new ItemFinishList(this);
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x0600BDEC RID: 48620 RVA: 0x001C3630 File Offset: 0x001C1830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionIdList
		{
			get
			{
				return this.conditionIdList_;
			}
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x001C3638 File Offset: 0x001C1838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemFinishList);
		}

		// Token: 0x0600BDEE RID: 48622 RVA: 0x001C3646 File Offset: 0x001C1846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemFinishList other)
		{
			return other != null && (other == this || (this.conditionIdList_.Equals(other.conditionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDEF RID: 48623 RVA: 0x001C367C File Offset: 0x001C187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x001C36B0 File Offset: 0x001C18B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x001C36BD File Offset: 0x001C18BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDF2 RID: 48626 RVA: 0x001C36C6 File Offset: 0x001C18C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionIdList_.WriteTo(ref output, ItemFinishList._repeated_conditionIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDF3 RID: 48627 RVA: 0x001C36F0 File Offset: 0x001C18F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionIdList_.CalculateSize(ItemFinishList._repeated_conditionIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BDF4 RID: 48628 RVA: 0x001C3729 File Offset: 0x001C1929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemFinishList other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionIdList_.Add(other.conditionIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x001C3757 File Offset: 0x001C1957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x001C3760 File Offset: 0x001C1960
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionIdList_.AddEntriesFrom(ref input, ItemFinishList._repeated_conditionIdList_codec);
				}
			}
		}

		// Token: 0x040052E6 RID: 21222
		private static readonly MessageParser<ItemFinishList> _parser = new MessageParser<ItemFinishList>(() => new ItemFinishList());

		// Token: 0x040052E7 RID: 21223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052E8 RID: 21224
		public const int ConditionIdListFieldNumber = 1;

		// Token: 0x040052E9 RID: 21225
		private static readonly FieldCodec<int> _repeated_conditionIdList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040052EA RID: 21226
		private readonly RepeatedField<int> conditionIdList_ = new RepeatedField<int>();
	}
}
