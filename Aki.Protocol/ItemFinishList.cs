using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083F RID: 2111
	public sealed class ItemFinishList : IMessage<ItemFinishList>, IMessage, IEquatable<ItemFinishList>, IDeepCloneable<ItemFinishList>, IBufferMessage
	{
		// Token: 0x0600BCB7 RID: 48311 RVA: 0x001C10FF File Offset: 0x001BF2FF
		[NullableContext(1)]
		public static ItemFinishList Create()
		{
			return new ItemFinishList();
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0600BCB8 RID: 48312 RVA: 0x001C1106 File Offset: 0x001BF306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemFinishList> Parser
		{
			get
			{
				return ItemFinishList._parser;
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0600BCB9 RID: 48313 RVA: 0x001C110D File Offset: 0x001BF30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x0600BCBA RID: 48314 RVA: 0x001C1110 File Offset: 0x001BF310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemFinishList.Descriptor;
			}
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x001C1117 File Offset: 0x001BF317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList()
		{
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x001C112A File Offset: 0x001BF32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList(ItemFinishList other) : this()
		{
			this.conditionIdList_ = other.conditionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x001C1154 File Offset: 0x001BF354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemFinishList Clone()
		{
			return new ItemFinishList(this);
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x001C115C File Offset: 0x001BF35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionIdList
		{
			get
			{
				return this.conditionIdList_;
			}
		}

		// Token: 0x0600BCBF RID: 48319 RVA: 0x001C1164 File Offset: 0x001BF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemFinishList);
		}

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x001C1172 File Offset: 0x001BF372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemFinishList other)
		{
			return other != null && (other == this || (this.conditionIdList_.Equals(other.conditionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCC1 RID: 48321 RVA: 0x001C11A8 File Offset: 0x001BF3A8
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

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x001C11DC File Offset: 0x001BF3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x001C11E9 File Offset: 0x001BF3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x001C11F2 File Offset: 0x001BF3F2
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

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x001C121C File Offset: 0x001BF41C
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

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x001C1255 File Offset: 0x001BF455
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

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x001C1283 File Offset: 0x001BF483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x001C128C File Offset: 0x001BF48C
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

		// Token: 0x040052E9 RID: 21225
		private static readonly MessageParser<ItemFinishList> _parser = new MessageParser<ItemFinishList>(() => new ItemFinishList());

		// Token: 0x040052EA RID: 21226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052EB RID: 21227
		public const int ConditionIdListFieldNumber = 1;

		// Token: 0x040052EC RID: 21228
		private static readonly FieldCodec<int> _repeated_conditionIdList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040052ED RID: 21229
		private readonly RepeatedField<int> conditionIdList_ = new RepeatedField<int>();
	}
}
