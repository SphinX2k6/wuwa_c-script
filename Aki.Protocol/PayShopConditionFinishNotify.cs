using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEA RID: 3050
	[NetMessage(EMessageId.PayShopConditionFinishNotify)]
	public sealed class PayShopConditionFinishNotify : IMessage<PayShopConditionFinishNotify>, IMessage, IEquatable<PayShopConditionFinishNotify>, IDeepCloneable<PayShopConditionFinishNotify>, IBufferMessage
	{
		// Token: 0x06010876 RID: 67702 RVA: 0x00269E8F File Offset: 0x0026808F
		[NullableContext(1)]
		public static PayShopConditionFinishNotify Create()
		{
			return new PayShopConditionFinishNotify();
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x06010877 RID: 67703 RVA: 0x00269E96 File Offset: 0x00268096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x06010878 RID: 67704 RVA: 0x00269E99 File Offset: 0x00268099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopConditionFinishNotify.Descriptor;
			}
		}

		// Token: 0x06010879 RID: 67705 RVA: 0x00269EA0 File Offset: 0x002680A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify()
		{
		}

		// Token: 0x0601087A RID: 67706 RVA: 0x00269EB3 File Offset: 0x002680B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify(PayShopConditionFinishNotify other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601087B RID: 67707 RVA: 0x00269EDD File Offset: 0x002680DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopConditionFinishNotify Clone()
		{
			return new PayShopConditionFinishNotify(this);
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0601087C RID: 67708 RVA: 0x00269EE5 File Offset: 0x002680E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x0601087D RID: 67709 RVA: 0x00269EED File Offset: 0x002680ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopConditionFinishNotify);
		}

		// Token: 0x0601087E RID: 67710 RVA: 0x00269EFB File Offset: 0x002680FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopConditionFinishNotify other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601087F RID: 67711 RVA: 0x00269F30 File Offset: 0x00268130
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

		// Token: 0x06010880 RID: 67712 RVA: 0x00269F64 File Offset: 0x00268164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010881 RID: 67713 RVA: 0x00269F71 File Offset: 0x00268171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010882 RID: 67714 RVA: 0x00269F7A File Offset: 0x0026817A
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

		// Token: 0x06010883 RID: 67715 RVA: 0x00269FA4 File Offset: 0x002681A4
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

		// Token: 0x06010884 RID: 67716 RVA: 0x00269FDD File Offset: 0x002681DD
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

		// Token: 0x06010885 RID: 67717 RVA: 0x0026A00B File Offset: 0x0026820B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010886 RID: 67718 RVA: 0x0026A014 File Offset: 0x00268214
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, PayShopConditionFinishNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x040068DC RID: 26844
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068DD RID: 26845
		public const int ItemsFieldNumber = 3;

		// Token: 0x040068DE RID: 26846
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(26U, PayShopItem.Parser);

		// Token: 0x040068DF RID: 26847
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();
	}
}
