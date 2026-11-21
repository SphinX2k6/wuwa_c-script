using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE3 RID: 3043
	[NetMessage(EMessageId.PayShopItemUpdateRequest)]
	public sealed class PayShopItemUpdateRequest : IMessage<PayShopItemUpdateRequest>, IMessage, IEquatable<PayShopItemUpdateRequest>, IDeepCloneable<PayShopItemUpdateRequest>, IBufferMessage
	{
		// Token: 0x06010893 RID: 67731 RVA: 0x0026C011 File Offset: 0x0026A211
		[NullableContext(1)]
		public static PayShopItemUpdateRequest Create()
		{
			return new PayShopItemUpdateRequest();
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x06010894 RID: 67732 RVA: 0x0026C018 File Offset: 0x0026A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x06010895 RID: 67733 RVA: 0x0026C01B File Offset: 0x0026A21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItemUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06010896 RID: 67734 RVA: 0x0026C022 File Offset: 0x0026A222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest()
		{
		}

		// Token: 0x06010897 RID: 67735 RVA: 0x0026C035 File Offset: 0x0026A235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest(PayShopItemUpdateRequest other) : this()
		{
			this.shopItemIds_ = other.shopItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010898 RID: 67736 RVA: 0x0026C05F File Offset: 0x0026A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest Clone()
		{
			return new PayShopItemUpdateRequest(this);
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x06010899 RID: 67737 RVA: 0x0026C067 File Offset: 0x0026A267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ShopItemIds
		{
			get
			{
				return this.shopItemIds_;
			}
		}

		// Token: 0x0601089A RID: 67738 RVA: 0x0026C06F File Offset: 0x0026A26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItemUpdateRequest);
		}

		// Token: 0x0601089B RID: 67739 RVA: 0x0026C07D File Offset: 0x0026A27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItemUpdateRequest other)
		{
			return other != null && (other == this || (this.shopItemIds_.Equals(other.shopItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601089C RID: 67740 RVA: 0x0026C0B0 File Offset: 0x0026A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shopItemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601089D RID: 67741 RVA: 0x0026C0E4 File Offset: 0x0026A2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601089E RID: 67742 RVA: 0x0026C0F1 File Offset: 0x0026A2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601089F RID: 67743 RVA: 0x0026C0FA File Offset: 0x0026A2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopItemIds_.WriteTo(ref output, PayShopItemUpdateRequest._repeated_shopItemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060108A0 RID: 67744 RVA: 0x0026C124 File Offset: 0x0026A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shopItemIds_.CalculateSize(PayShopItemUpdateRequest._repeated_shopItemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060108A1 RID: 67745 RVA: 0x0026C15D File Offset: 0x0026A35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopItemUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.shopItemIds_.Add(other.shopItemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060108A2 RID: 67746 RVA: 0x0026C18B File Offset: 0x0026A38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108A3 RID: 67747 RVA: 0x0026C194 File Offset: 0x0026A394
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shopItemIds_.AddEntriesFrom(ref input, PayShopItemUpdateRequest._repeated_shopItemIds_codec);
				}
			}
		}

		// Token: 0x04006995 RID: 27029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006996 RID: 27030
		public const int ShopItemIdsFieldNumber = 11;

		// Token: 0x04006997 RID: 27031
		private static readonly FieldCodec<int> _repeated_shopItemIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006998 RID: 27032
		private readonly RepeatedField<int> shopItemIds_ = new RepeatedField<int>();
	}
}
