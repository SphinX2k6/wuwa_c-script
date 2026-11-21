using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020A RID: 522
	[NetMessage(EMessageId.BuffItemUpdateNotify)]
	public sealed class BuffItemUpdateNotify : IMessage<BuffItemUpdateNotify>, IMessage, IEquatable<BuffItemUpdateNotify>, IDeepCloneable<BuffItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x060039C2 RID: 14786 RVA: 0x000903B2 File Offset: 0x0008E5B2
		[NullableContext(1)]
		public static BuffItemUpdateNotify Create()
		{
			return new BuffItemUpdateNotify();
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060039C3 RID: 14787 RVA: 0x000903B9 File Offset: 0x0008E5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x000903BC File Offset: 0x0008E5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x000903C3 File Offset: 0x0008E5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify()
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000903D8 File Offset: 0x0008E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify(BuffItemUpdateNotify other) : this()
		{
			this.buffItem_ = ((other.buffItem_ != null) ? other.buffItem_.Clone() : null);
			this.equipItemList_ = other.equipItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00090429 File Offset: 0x0008E629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemUpdateNotify Clone()
		{
			return new BuffItemUpdateNotify(this);
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x00090431 File Offset: 0x0008E631
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x00090439 File Offset: 0x0008E639
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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00090442 File Offset: 0x0008E642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipBuffItem> EquipItemList
		{
			get
			{
				return this.equipItemList_;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0009044A File Offset: 0x0008E64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemUpdateNotify);
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00090458 File Offset: 0x0008E658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BuffItem, other.BuffItem) && this.equipItemList_.Equals(other.equipItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x000904AC File Offset: 0x0008E6AC
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

		// Token: 0x060039CE RID: 14798 RVA: 0x000904F6 File Offset: 0x0008E6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x00090503 File Offset: 0x0008E703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x0009050C File Offset: 0x0008E70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.buffItem_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BuffItem);
			}
			this.equipItemList_.WriteTo(ref output, BuffItemUpdateNotify._repeated_equipItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0009055C File Offset: 0x0008E75C
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

		// Token: 0x060039D2 RID: 14802 RVA: 0x000905B0 File Offset: 0x0008E7B0
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

		// Token: 0x060039D3 RID: 14803 RVA: 0x00090615 File Offset: 0x0008E815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00090620 File Offset: 0x0008E820
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
				if (num != 26U)
				{
					if (num != 74U)
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

		// Token: 0x04002BE7 RID: 11239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BE8 RID: 11240
		public const int BuffItemFieldNumber = 3;

		// Token: 0x04002BE9 RID: 11241
		private BuffItem buffItem_;

		// Token: 0x04002BEA RID: 11242
		public const int EquipItemListFieldNumber = 9;

		// Token: 0x04002BEB RID: 11243
		private static readonly FieldCodec<EquipBuffItem> _repeated_equipItemList_codec = FieldCodec.ForMessage<EquipBuffItem>(74U, EquipBuffItem.Parser);

		// Token: 0x04002BEC RID: 11244
		private readonly RepeatedField<EquipBuffItem> equipItemList_ = new RepeatedField<EquipBuffItem>();
	}
}
