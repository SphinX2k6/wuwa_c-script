using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF3 RID: 3059
	[NetMessage(EMessageId.PayShopItemUpdateRequest)]
	public sealed class PayShopItemUpdateRequest : IMessage<PayShopItemUpdateRequest>, IMessage, IEquatable<PayShopItemUpdateRequest>, IDeepCloneable<PayShopItemUpdateRequest>, IBufferMessage
	{
		// Token: 0x06010993 RID: 67987 RVA: 0x0026DD79 File Offset: 0x0026BF79
		[NullableContext(1)]
		public static PayShopItemUpdateRequest Create()
		{
			return new PayShopItemUpdateRequest();
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x06010994 RID: 67988 RVA: 0x0026DD80 File Offset: 0x0026BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x06010995 RID: 67989 RVA: 0x0026DD83 File Offset: 0x0026BF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItemUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06010996 RID: 67990 RVA: 0x0026DD8A File Offset: 0x0026BF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest()
		{
		}

		// Token: 0x06010997 RID: 67991 RVA: 0x0026DD9D File Offset: 0x0026BF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest(PayShopItemUpdateRequest other) : this()
		{
			this.shopItemIds_ = other.shopItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010998 RID: 67992 RVA: 0x0026DDC7 File Offset: 0x0026BFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateRequest Clone()
		{
			return new PayShopItemUpdateRequest(this);
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x06010999 RID: 67993 RVA: 0x0026DDCF File Offset: 0x0026BFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ShopItemIds
		{
			get
			{
				return this.shopItemIds_;
			}
		}

		// Token: 0x0601099A RID: 67994 RVA: 0x0026DDD7 File Offset: 0x0026BFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItemUpdateRequest);
		}

		// Token: 0x0601099B RID: 67995 RVA: 0x0026DDE5 File Offset: 0x0026BFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItemUpdateRequest other)
		{
			return other != null && (other == this || (this.shopItemIds_.Equals(other.shopItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601099C RID: 67996 RVA: 0x0026DE18 File Offset: 0x0026C018
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

		// Token: 0x0601099D RID: 67997 RVA: 0x0026DE4C File Offset: 0x0026C04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601099E RID: 67998 RVA: 0x0026DE59 File Offset: 0x0026C059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601099F RID: 67999 RVA: 0x0026DE62 File Offset: 0x0026C062
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

		// Token: 0x060109A0 RID: 68000 RVA: 0x0026DE8C File Offset: 0x0026C08C
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

		// Token: 0x060109A1 RID: 68001 RVA: 0x0026DEC5 File Offset: 0x0026C0C5
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

		// Token: 0x060109A2 RID: 68002 RVA: 0x0026DEF3 File Offset: 0x0026C0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109A3 RID: 68003 RVA: 0x0026DEFC File Offset: 0x0026C0FC
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shopItemIds_.AddEntriesFrom(ref input, PayShopItemUpdateRequest._repeated_shopItemIds_codec);
				}
			}
		}

		// Token: 0x04006981 RID: 27009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006982 RID: 27010
		public const int ShopItemIdsFieldNumber = 9;

		// Token: 0x04006983 RID: 27011
		private static readonly FieldCodec<int> _repeated_shopItemIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006984 RID: 27012
		private readonly RepeatedField<int> shopItemIds_ = new RepeatedField<int>();
	}
}
