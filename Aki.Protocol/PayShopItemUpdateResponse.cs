using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE4 RID: 3044
	[NetMessage(EMessageId.PayShopItemUpdateResponse)]
	public sealed class PayShopItemUpdateResponse : IMessage<PayShopItemUpdateResponse>, IMessage, IEquatable<PayShopItemUpdateResponse>, IDeepCloneable<PayShopItemUpdateResponse>, IBufferMessage
	{
		// Token: 0x060108A5 RID: 67749 RVA: 0x0026C1F1 File Offset: 0x0026A3F1
		[NullableContext(1)]
		public static PayShopItemUpdateResponse Create()
		{
			return new PayShopItemUpdateResponse();
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x060108A6 RID: 67750 RVA: 0x0026C1F8 File Offset: 0x0026A3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x060108A7 RID: 67751 RVA: 0x0026C1FB File Offset: 0x0026A3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItemUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060108A8 RID: 67752 RVA: 0x0026C202 File Offset: 0x0026A402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse()
		{
		}

		// Token: 0x060108A9 RID: 67753 RVA: 0x0026C215 File Offset: 0x0026A415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse(PayShopItemUpdateResponse other) : this()
		{
			this.items_ = other.items_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060108AA RID: 67754 RVA: 0x0026C24B File Offset: 0x0026A44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse Clone()
		{
			return new PayShopItemUpdateResponse(this);
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x060108AB RID: 67755 RVA: 0x0026C253 File Offset: 0x0026A453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x060108AC RID: 67756 RVA: 0x0026C25B File Offset: 0x0026A45B
		// (set) Token: 0x060108AD RID: 67757 RVA: 0x0026C263 File Offset: 0x0026A463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060108AE RID: 67758 RVA: 0x0026C26C File Offset: 0x0026A46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItemUpdateResponse);
		}

		// Token: 0x060108AF RID: 67759 RVA: 0x0026C27C File Offset: 0x0026A47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItemUpdateResponse other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108B0 RID: 67760 RVA: 0x0026C2CC File Offset: 0x0026A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060108B1 RID: 67761 RVA: 0x0026C31F File Offset: 0x0026A51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108B2 RID: 67762 RVA: 0x0026C32C File Offset: 0x0026A52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108B3 RID: 67763 RVA: 0x0026C338 File Offset: 0x0026A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.items_.WriteTo(ref output, PayShopItemUpdateResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060108B4 RID: 67764 RVA: 0x0026C388 File Offset: 0x0026A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(PayShopItemUpdateResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060108B5 RID: 67765 RVA: 0x0026C3DC File Offset: 0x0026A5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopItemUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060108B6 RID: 67766 RVA: 0x0026C429 File Offset: 0x0026A629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108B7 RID: 67767 RVA: 0x0026C434 File Offset: 0x0026A634
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, PayShopItemUpdateResponse._repeated_items_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006999 RID: 27033
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400699A RID: 27034
		public const int ItemsFieldNumber = 9;

		// Token: 0x0400699B RID: 27035
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(74U, PayShopItem.Parser);

		// Token: 0x0400699C RID: 27036
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();

		// Token: 0x0400699D RID: 27037
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400699E RID: 27038
		private ErrorCode errorCode_;
	}
}
