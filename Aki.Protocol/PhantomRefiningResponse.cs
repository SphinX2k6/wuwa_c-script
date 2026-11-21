using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEA RID: 3306
	[NetMessage(EMessageId.PhantomRefiningResponse)]
	public sealed class PhantomRefiningResponse : IMessage<PhantomRefiningResponse>, IMessage, IEquatable<PhantomRefiningResponse>, IDeepCloneable<PhantomRefiningResponse>, IBufferMessage
	{
		// Token: 0x06011E66 RID: 73318 RVA: 0x0029E9F1 File Offset: 0x0029CBF1
		[NullableContext(1)]
		public static PhantomRefiningResponse Create()
		{
			return new PhantomRefiningResponse();
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x06011E67 RID: 73319 RVA: 0x0029E9F8 File Offset: 0x0029CBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x06011E68 RID: 73320 RVA: 0x0029E9FB File Offset: 0x0029CBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRefiningResponse.Descriptor;
			}
		}

		// Token: 0x06011E69 RID: 73321 RVA: 0x0029EA02 File Offset: 0x0029CC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse()
		{
		}

		// Token: 0x06011E6A RID: 73322 RVA: 0x0029EA2C File Offset: 0x0029CC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse(PhantomRefiningResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this.extraItems_ = other.extraItems_.Clone();
			this.costPhantoms_ = other.costPhantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E6B RID: 73323 RVA: 0x0029EA8F File Offset: 0x0029CC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningResponse Clone()
		{
			return new PhantomRefiningResponse(this);
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x06011E6C RID: 73324 RVA: 0x0029EA97 File Offset: 0x0029CC97
		// (set) Token: 0x06011E6D RID: 73325 RVA: 0x0029EA9F File Offset: 0x0029CC9F
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

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x06011E6E RID: 73326 RVA: 0x0029EAA8 File Offset: 0x0029CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x06011E6F RID: 73327 RVA: 0x0029EAB0 File Offset: 0x0029CCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> ExtraItems
		{
			get
			{
				return this.extraItems_;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x06011E70 RID: 73328 RVA: 0x0029EAB8 File Offset: 0x0029CCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomItem> CostPhantoms
		{
			get
			{
				return this.costPhantoms_;
			}
		}

		// Token: 0x06011E71 RID: 73329 RVA: 0x0029EAC0 File Offset: 0x0029CCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRefiningResponse);
		}

		// Token: 0x06011E72 RID: 73330 RVA: 0x0029EAD0 File Offset: 0x0029CCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRefiningResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && this.extraItems_.Equals(other.extraItems_) && this.costPhantoms_.Equals(other.costPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E73 RID: 73331 RVA: 0x0029EB48 File Offset: 0x0029CD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			num ^= this.extraItems_.GetHashCode();
			num ^= this.costPhantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011E74 RID: 73332 RVA: 0x0029EBB7 File Offset: 0x0029CDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E75 RID: 73333 RVA: 0x0029EBC4 File Offset: 0x0029CDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E76 RID: 73334 RVA: 0x0029EBD0 File Offset: 0x0029CDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.items_.WriteTo(ref output, PhantomRefiningResponse._repeated_items_codec);
			this.extraItems_.WriteTo(ref output, PhantomRefiningResponse._repeated_extraItems_codec);
			this.costPhantoms_.WriteTo(ref output, PhantomRefiningResponse._repeated_costPhantoms_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E77 RID: 73335 RVA: 0x0029EC40 File Offset: 0x0029CE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(PhantomRefiningResponse._repeated_items_codec);
			num += this.extraItems_.CalculateSize(PhantomRefiningResponse._repeated_extraItems_codec);
			num += this.costPhantoms_.CalculateSize(PhantomRefiningResponse._repeated_costPhantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E78 RID: 73336 RVA: 0x0029ECB8 File Offset: 0x0029CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRefiningResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this.extraItems_.Add(other.extraItems_);
			this.costPhantoms_.Add(other.costPhantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E79 RID: 73337 RVA: 0x0029ED27 File Offset: 0x0029CF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E7A RID: 73338 RVA: 0x0029ED30 File Offset: 0x0029CF30
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
				if (num <= 50U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						this.items_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_items_codec);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.extraItems_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_extraItems_codec);
						continue;
					}
					if (num == 74U)
					{
						this.costPhantoms_.AddEntriesFrom(ref input, PhantomRefiningResponse._repeated_costPhantoms_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040070AE RID: 28846
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070AF RID: 28847
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040070B0 RID: 28848
		private ErrorCode errorCode_;

		// Token: 0x040070B1 RID: 28849
		public const int ItemsFieldNumber = 6;

		// Token: 0x040070B2 RID: 28850
		private static readonly FieldCodec<AddCountItemInfo> _repeated_items_codec = FieldCodec.ForMessage<AddCountItemInfo>(50U, AddCountItemInfo.Parser);

		// Token: 0x040070B3 RID: 28851
		private readonly RepeatedField<AddCountItemInfo> items_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x040070B4 RID: 28852
		public const int ExtraItemsFieldNumber = 7;

		// Token: 0x040070B5 RID: 28853
		private static readonly FieldCodec<AddCountItemInfo> _repeated_extraItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(58U, AddCountItemInfo.Parser);

		// Token: 0x040070B6 RID: 28854
		private readonly RepeatedField<AddCountItemInfo> extraItems_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x040070B7 RID: 28855
		public const int CostPhantomsFieldNumber = 9;

		// Token: 0x040070B8 RID: 28856
		private static readonly FieldCodec<PhantomItem> _repeated_costPhantoms_codec = FieldCodec.ForMessage<PhantomItem>(74U, PhantomItem.Parser);

		// Token: 0x040070B9 RID: 28857
		private readonly RepeatedField<PhantomItem> costPhantoms_ = new RepeatedField<PhantomItem>();
	}
}
