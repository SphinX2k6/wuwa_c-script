using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF4 RID: 3060
	[NetMessage(EMessageId.PayShopItemUpdateResponse)]
	public sealed class PayShopItemUpdateResponse : IMessage<PayShopItemUpdateResponse>, IMessage, IEquatable<PayShopItemUpdateResponse>, IDeepCloneable<PayShopItemUpdateResponse>, IBufferMessage
	{
		// Token: 0x060109A5 RID: 68005 RVA: 0x0026DF59 File Offset: 0x0026C159
		[NullableContext(1)]
		public static PayShopItemUpdateResponse Create()
		{
			return new PayShopItemUpdateResponse();
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x060109A6 RID: 68006 RVA: 0x0026DF60 File Offset: 0x0026C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x060109A7 RID: 68007 RVA: 0x0026DF63 File Offset: 0x0026C163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItemUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060109A8 RID: 68008 RVA: 0x0026DF6A File Offset: 0x0026C16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse()
		{
		}

		// Token: 0x060109A9 RID: 68009 RVA: 0x0026DF7D File Offset: 0x0026C17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse(PayShopItemUpdateResponse other) : this()
		{
			this.items_ = other.items_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109AA RID: 68010 RVA: 0x0026DFB3 File Offset: 0x0026C1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemUpdateResponse Clone()
		{
			return new PayShopItemUpdateResponse(this);
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x060109AB RID: 68011 RVA: 0x0026DFBB File Offset: 0x0026C1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x060109AC RID: 68012 RVA: 0x0026DFC3 File Offset: 0x0026C1C3
		// (set) Token: 0x060109AD RID: 68013 RVA: 0x0026DFCB File Offset: 0x0026C1CB
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

		// Token: 0x060109AE RID: 68014 RVA: 0x0026DFD4 File Offset: 0x0026C1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItemUpdateResponse);
		}

		// Token: 0x060109AF RID: 68015 RVA: 0x0026DFE4 File Offset: 0x0026C1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItemUpdateResponse other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109B0 RID: 68016 RVA: 0x0026E034 File Offset: 0x0026C234
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

		// Token: 0x060109B1 RID: 68017 RVA: 0x0026E087 File Offset: 0x0026C287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109B2 RID: 68018 RVA: 0x0026E094 File Offset: 0x0026C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109B3 RID: 68019 RVA: 0x0026E0A0 File Offset: 0x0026C2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, PayShopItemUpdateResponse._repeated_items_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060109B4 RID: 68020 RVA: 0x0026E0F0 File Offset: 0x0026C2F0
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

		// Token: 0x060109B5 RID: 68021 RVA: 0x0026E144 File Offset: 0x0026C344
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

		// Token: 0x060109B6 RID: 68022 RVA: 0x0026E191 File Offset: 0x0026C391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109B7 RID: 68023 RVA: 0x0026E19C File Offset: 0x0026C39C
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
				if (num != 50U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, PayShopItemUpdateResponse._repeated_items_codec);
				}
			}
		}

		// Token: 0x04006985 RID: 27013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006986 RID: 27014
		public const int ItemsFieldNumber = 6;

		// Token: 0x04006987 RID: 27015
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(50U, PayShopItem.Parser);

		// Token: 0x04006988 RID: 27016
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();

		// Token: 0x04006989 RID: 27017
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400698A RID: 27018
		private ErrorCode errorCode_;
	}
}
