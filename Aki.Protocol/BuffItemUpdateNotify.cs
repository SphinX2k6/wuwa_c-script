using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000205 RID: 517
	[NetMessage(EMessageId.BuffItemUpdateNotify)]
	public sealed class BuffItemUpdateNotify : IMessage<BuffItemUpdateNotify>, IMessage, IEquatable<BuffItemUpdateNotify>, IDeepCloneable<BuffItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x0008E7A2 File Offset: 0x0008C9A2
		[NullableContext(1)]
		public static BuffItemUpdateNotify Create()
		{
			return new BuffItemUpdateNotify();
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x0008E7A9 File Offset: 0x0008C9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x0008E7AC File Offset: 0x0008C9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0008E7B3 File Offset: 0x0008C9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify()
		{
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0008E7C8 File Offset: 0x0008C9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify(BuffItemUpdateNotify other) : this()
		{
			this.buffItem_ = ((other.buffItem_ != null) ? other.buffItem_.Clone() : null);
			this.equipItemList_ = other.equipItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0008E819 File Offset: 0x0008CA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify Clone()
		{
			return new BuffItemUpdateNotify(this);
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x0008E821 File Offset: 0x0008CA21
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x0008E829 File Offset: 0x0008CA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem BuffItem
		{
			get
			{
				return this.buffItem_;
			}
			set
			{
				this.buffItem_ = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x0008E832 File Offset: 0x0008CA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipBuffItem> EquipItemList
		{
			get
			{
				return this.equipItemList_;
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0008E83A File Offset: 0x0008CA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemUpdateNotify);
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0008E848 File Offset: 0x0008CA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BuffItem, other.BuffItem) && this.equipItemList_.Equals(other.equipItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0008E89C File Offset: 0x0008CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.buffItem_ != null)
			{
				num ^= this.BuffItem.GetHashCode();
			}
			num ^= this.equipItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0008E8E6 File Offset: 0x0008CAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0008E8F3 File Offset: 0x0008CAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x0008E8FC File Offset: 0x0008CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffItem_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.BuffItem);
			}
			this.equipItemList_.WriteTo(ref output, BuffItemUpdateNotify._repeated_equipItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0008E94C File Offset: 0x0008CB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.buffItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffItem);
			}
			num += this.equipItemList_.CalculateSize(BuffItemUpdateNotify._repeated_equipItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0008E9A0 File Offset: 0x0008CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.buffItem_ != null)
			{
				if (this.buffItem_ == null)
				{
					this.BuffItem = new BuffItem();
				}
				this.BuffItem.MergeFrom(other.BuffItem);
			}
			this.equipItemList_.Add(other.equipItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x0008EA05 File Offset: 0x0008CC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0008EA10 File Offset: 0x0008CC10
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.equipItemList_.AddEntriesFrom(ref input, BuffItemUpdateNotify._repeated_equipItemList_codec);
					}
				}
				else
				{
					if (this.buffItem_ == null)
					{
						this.BuffItem = new BuffItem();
					}
					input.ReadMessage(this.BuffItem);
				}
			}
		}

		// Token: 0x04002B65 RID: 11109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B66 RID: 11110
		public const int BuffItemFieldNumber = 10;

		// Token: 0x04002B67 RID: 11111
		private BuffItem buffItem_;

		// Token: 0x04002B68 RID: 11112
		public const int EquipItemListFieldNumber = 15;

		// Token: 0x04002B69 RID: 11113
		private static readonly FieldCodec<EquipBuffItem> _repeated_equipItemList_codec = FieldCodec.ForMessage<EquipBuffItem>(122U, EquipBuffItem.Parser);

		// Token: 0x04002B6A RID: 11114
		private readonly RepeatedField<EquipBuffItem> equipItemList_ = new RepeatedField<EquipBuffItem>();
	}
}
