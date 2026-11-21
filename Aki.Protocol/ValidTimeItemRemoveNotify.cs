using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001537 RID: 5431
	[NetMessage(EMessageId.ValidTimeItemRemoveNotify)]
	public sealed class ValidTimeItemRemoveNotify : IMessage<ValidTimeItemRemoveNotify>, IMessage, IEquatable<ValidTimeItemRemoveNotify>, IDeepCloneable<ValidTimeItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601CC52 RID: 117842 RVA: 0x0042B7D0 File Offset: 0x004299D0
		[NullableContext(1)]
		public static ValidTimeItemRemoveNotify Create()
		{
			return new ValidTimeItemRemoveNotify();
		}

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0601CC53 RID: 117843 RVA: 0x0042B7D7 File Offset: 0x004299D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x0601CC54 RID: 117844 RVA: 0x0042B7DA File Offset: 0x004299DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601CC55 RID: 117845 RVA: 0x0042B7E1 File Offset: 0x004299E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify()
		{
		}

		// Token: 0x0601CC56 RID: 117846 RVA: 0x0042B7F4 File Offset: 0x004299F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify(ValidTimeItemRemoveNotify other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC57 RID: 117847 RVA: 0x0042B81E File Offset: 0x00429A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItemRemoveNotify Clone()
		{
			return new ValidTimeItemRemoveNotify(this);
		}

		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x0601CC58 RID: 117848 RVA: 0x0042B826 File Offset: 0x00429A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RemoveValidTimeItem> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0601CC59 RID: 117849 RVA: 0x0042B82E File Offset: 0x00429A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItemRemoveNotify);
		}

		// Token: 0x0601CC5A RID: 117850 RVA: 0x0042B83C File Offset: 0x00429A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItemRemoveNotify other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC5B RID: 117851 RVA: 0x0042B870 File Offset: 0x00429A70
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

		// Token: 0x0601CC5C RID: 117852 RVA: 0x0042B8A4 File Offset: 0x00429AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC5D RID: 117853 RVA: 0x0042B8B1 File Offset: 0x00429AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC5E RID: 117854 RVA: 0x0042B8BA File Offset: 0x00429ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ValidTimeItemRemoveNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC5F RID: 117855 RVA: 0x0042B8E4 File Offset: 0x00429AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ValidTimeItemRemoveNotify._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC60 RID: 117856 RVA: 0x0042B91D File Offset: 0x00429B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC61 RID: 117857 RVA: 0x0042B94B File Offset: 0x00429B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC62 RID: 117858 RVA: 0x0042B954 File Offset: 0x00429B54
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ValidTimeItemRemoveNotify._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x0400A5AB RID: 42411
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5AC RID: 42412
		public const int ItemListFieldNumber = 10;

		// Token: 0x0400A5AD RID: 42413
		private static readonly FieldCodec<RemoveValidTimeItem> _repeated_itemList_codec = FieldCodec.ForMessage<RemoveValidTimeItem>(82U, RemoveValidTimeItem.Parser);

		// Token: 0x0400A5AE RID: 42414
		private readonly RepeatedField<RemoveValidTimeItem> itemList_ = new RepeatedField<RemoveValidTimeItem>();
	}
}
