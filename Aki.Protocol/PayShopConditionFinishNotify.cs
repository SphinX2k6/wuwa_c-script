using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDA RID: 3034
	[NetMessage(EMessageId.PayShopConditionFinishNotify)]
	public sealed class PayShopConditionFinishNotify : IMessage<PayShopConditionFinishNotify>, IMessage, IEquatable<PayShopConditionFinishNotify>, IDeepCloneable<PayShopConditionFinishNotify>, IBufferMessage
	{
		// Token: 0x06010772 RID: 67442 RVA: 0x00267FCB File Offset: 0x002661CB
		[NullableContext(1)]
		public static PayShopConditionFinishNotify Create()
		{
			return new PayShopConditionFinishNotify();
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x06010773 RID: 67443 RVA: 0x00267FD2 File Offset: 0x002661D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x06010774 RID: 67444 RVA: 0x00267FD5 File Offset: 0x002661D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopConditionFinishNotify.Descriptor;
			}
		}

		// Token: 0x06010775 RID: 67445 RVA: 0x00267FDC File Offset: 0x002661DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify()
		{
		}

		// Token: 0x06010776 RID: 67446 RVA: 0x00267FEF File Offset: 0x002661EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify(PayShopConditionFinishNotify other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010777 RID: 67447 RVA: 0x00268019 File Offset: 0x00266219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify Clone()
		{
			return new PayShopConditionFinishNotify(this);
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x06010778 RID: 67448 RVA: 0x00268021 File Offset: 0x00266221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06010779 RID: 67449 RVA: 0x00268029 File Offset: 0x00266229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopConditionFinishNotify);
		}

		// Token: 0x0601077A RID: 67450 RVA: 0x00268037 File Offset: 0x00266237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopConditionFinishNotify other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601077B RID: 67451 RVA: 0x0026806C File Offset: 0x0026626C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601077C RID: 67452 RVA: 0x002680A0 File Offset: 0x002662A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601077D RID: 67453 RVA: 0x002680AD File Offset: 0x002662AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601077E RID: 67454 RVA: 0x002680B6 File Offset: 0x002662B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, PayShopConditionFinishNotify._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601077F RID: 67455 RVA: 0x002680E0 File Offset: 0x002662E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(PayShopConditionFinishNotify._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010780 RID: 67456 RVA: 0x00268119 File Offset: 0x00266319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopConditionFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010781 RID: 67457 RVA: 0x00268147 File Offset: 0x00266347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010782 RID: 67458 RVA: 0x00268150 File Offset: 0x00266350
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, PayShopConditionFinishNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x040068EC RID: 26860
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068ED RID: 26861
		public const int ItemsFieldNumber = 5;

		// Token: 0x040068EE RID: 26862
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(42U, PayShopItem.Parser);

		// Token: 0x040068EF RID: 26863
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();
	}
}
