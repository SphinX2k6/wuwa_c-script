using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B9 RID: 1465
	public sealed class FloroRanchPlayShopBuyCardGroup : IMessage<FloroRanchPlayShopBuyCardGroup>, IMessage, IEquatable<FloroRanchPlayShopBuyCardGroup>, IDeepCloneable<FloroRanchPlayShopBuyCardGroup>, IBufferMessage
	{
		// Token: 0x060087F4 RID: 34804 RVA: 0x0014878C File Offset: 0x0014698C
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyCardGroup Create()
		{
			return new FloroRanchPlayShopBuyCardGroup();
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x00148793 File Offset: 0x00146993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x00148796 File Offset: 0x00146996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyCardGroup.Descriptor;
			}
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x0014879D File Offset: 0x0014699D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup()
		{
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x001487B0 File Offset: 0x001469B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup(FloroRanchPlayShopBuyCardGroup other) : this()
		{
			this.cardIds_ = other.cardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x001487DA File Offset: 0x001469DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup Clone()
		{
			return new FloroRanchPlayShopBuyCardGroup(this);
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x001487E2 File Offset: 0x001469E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x001487EA File Offset: 0x001469EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyCardGroup);
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x001487F8 File Offset: 0x001469F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyCardGroup other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x0014882C File Offset: 0x00146A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00148860 File Offset: 0x00146A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x0014886D File Offset: 0x00146A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x00148876 File Offset: 0x00146A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardIds_.WriteTo(ref output, FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x001488A0 File Offset: 0x00146AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardIds_.CalculateSize(FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x001488D9 File Offset: 0x00146AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyCardGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.cardIds_.Add(other.cardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00148907 File Offset: 0x00146B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00148910 File Offset: 0x00146B10
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
					this.cardIds_.AddEntriesFrom(ref input, FloroRanchPlayShopBuyCardGroup._repeated_cardIds_codec);
				}
			}
		}

		// Token: 0x04004383 RID: 17283
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004384 RID: 17284
		public const int CardIdsFieldNumber = 1;

		// Token: 0x04004385 RID: 17285
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004386 RID: 17286
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();
	}
}
