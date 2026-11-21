using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000207 RID: 519
	[NetMessage(EMessageId.BuffItemNotify)]
	public sealed class BuffItemNotify : IMessage<BuffItemNotify>, IMessage, IEquatable<BuffItemNotify>, IDeepCloneable<BuffItemNotify>, IBufferMessage
	{
		// Token: 0x06003983 RID: 14723 RVA: 0x0008FA43 File Offset: 0x0008DC43
		[NullableContext(1)]
		public static BuffItemNotify Create()
		{
			return new BuffItemNotify();
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x0008FA4A File Offset: 0x0008DC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x0008FA4D File Offset: 0x0008DC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemNotify.Descriptor;
			}
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x0008FA54 File Offset: 0x0008DC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify()
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x0008FA72 File Offset: 0x0008DC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify(BuffItemNotify other) : this()
		{
			this.itemBuffList_ = other.itemBuffList_.Clone();
			this.equipItemList_ = other.equipItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0008FAAD File Offset: 0x0008DCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify Clone()
		{
			return new BuffItemNotify(this);
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0008FAB5 File Offset: 0x0008DCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffItem> ItemBuffList
		{
			get
			{
				return this.itemBuffList_;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x0008FABD File Offset: 0x0008DCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipBuffItem> EquipItemList
		{
			get
			{
				return this.equipItemList_;
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0008FAC5 File Offset: 0x0008DCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemNotify);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x0008FAD4 File Offset: 0x0008DCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemNotify other)
		{
			return other != null && (other == this || (this.itemBuffList_.Equals(other.itemBuffList_) && this.equipItemList_.Equals(other.equipItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x0008FB28 File Offset: 0x0008DD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemBuffList_.GetHashCode();
			num ^= this.equipItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0008FB6A File Offset: 0x0008DD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0008FB77 File Offset: 0x0008DD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x0008FB80 File Offset: 0x0008DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipItemList_.WriteTo(ref output, BuffItemNotify._repeated_equipItemList_codec);
			this.itemBuffList_.WriteTo(ref output, BuffItemNotify._repeated_itemBuffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0008FBB8 File Offset: 0x0008DDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemBuffList_.CalculateSize(BuffItemNotify._repeated_itemBuffList_codec);
			num += this.equipItemList_.CalculateSize(BuffItemNotify._repeated_equipItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x0008FC04 File Offset: 0x0008DE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemBuffList_.Add(other.itemBuffList_);
			this.equipItemList_.Add(other.equipItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0008FC43 File Offset: 0x0008DE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x0008FC4C File Offset: 0x0008DE4C
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
				if (num != 66U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemBuffList_.AddEntriesFrom(ref input, BuffItemNotify._repeated_itemBuffList_codec);
					}
				}
				else
				{
					this.equipItemList_.AddEntriesFrom(ref input, BuffItemNotify._repeated_equipItemList_codec);
				}
			}
		}

		// Token: 0x04002BD2 RID: 11218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD3 RID: 11219
		public const int ItemBuffListFieldNumber = 10;

		// Token: 0x04002BD4 RID: 11220
		private static readonly FieldCodec<BuffItem> _repeated_itemBuffList_codec = FieldCodec.ForMessage<BuffItem>(82U, BuffItem.Parser);

		// Token: 0x04002BD5 RID: 11221
		private readonly RepeatedField<BuffItem> itemBuffList_ = new RepeatedField<BuffItem>();

		// Token: 0x04002BD6 RID: 11222
		public const int EquipItemListFieldNumber = 8;

		// Token: 0x04002BD7 RID: 11223
		private static readonly FieldCodec<EquipBuffItem> _repeated_equipItemList_codec = FieldCodec.ForMessage<EquipBuffItem>(66U, EquipBuffItem.Parser);

		// Token: 0x04002BD8 RID: 11224
		private readonly RepeatedField<EquipBuffItem> equipItemList_ = new RepeatedField<EquipBuffItem>();
	}
}
