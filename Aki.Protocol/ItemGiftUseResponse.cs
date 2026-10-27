using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000855 RID: 2133
	[NetMessage(EMessageId.ItemGiftUseResponse)]
	public sealed class ItemGiftUseResponse : IMessage<ItemGiftUseResponse>, IMessage, IEquatable<ItemGiftUseResponse>, IDeepCloneable<ItemGiftUseResponse>, IBufferMessage
	{
		// Token: 0x0600BE36 RID: 48694 RVA: 0x001C4071 File Offset: 0x001C2271
		[NullableContext(1)]
		public static ItemGiftUseResponse Create()
		{
			return new ItemGiftUseResponse();
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0600BE37 RID: 48695 RVA: 0x001C4078 File Offset: 0x001C2278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x0600BE38 RID: 48696 RVA: 0x001C407B File Offset: 0x001C227B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseResponse.Descriptor;
			}
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x001C4082 File Offset: 0x001C2282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse()
		{
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x001C4095 File Offset: 0x001C2295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse(ItemGiftUseResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x001C40CB File Offset: 0x001C22CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse Clone()
		{
			return new ItemGiftUseResponse(this);
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x001C40D3 File Offset: 0x001C22D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x001C40DB File Offset: 0x001C22DB
		// (set) Token: 0x0600BE3E RID: 48702 RVA: 0x001C40E3 File Offset: 0x001C22E3
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

		// Token: 0x0600BE3F RID: 48703 RVA: 0x001C40EC File Offset: 0x001C22EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseResponse);
		}

		// Token: 0x0600BE40 RID: 48704 RVA: 0x001C40FC File Offset: 0x001C22FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x001C414C File Offset: 0x001C234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
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

		// Token: 0x0600BE42 RID: 48706 RVA: 0x001C419F File Offset: 0x001C239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x001C41AC File Offset: 0x001C23AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x001C41B8 File Offset: 0x001C23B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infos_.WriteTo(ref output, ItemGiftUseResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x001C4208 File Offset: 0x001C2408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(ItemGiftUseResponse._repeated_infos_codec);
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

		// Token: 0x0600BE46 RID: 48710 RVA: 0x001C425C File Offset: 0x001C245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemGiftUseResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x001C42A9 File Offset: 0x001C24A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x001C42B4 File Offset: 0x001C24B4
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
				if (num != 32U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.infos_.AddEntriesFrom(ref input, ItemGiftUseResponse._repeated_infos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052FE RID: 21246
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052FF RID: 21247
		public const int InfosFieldNumber = 8;

		// Token: 0x04005300 RID: 21248
		private static readonly FieldCodec<AddCountItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<AddCountItemInfo>(66U, AddCountItemInfo.Parser);

		// Token: 0x04005301 RID: 21249
		private readonly RepeatedField<AddCountItemInfo> infos_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04005302 RID: 21250
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005303 RID: 21251
		private ErrorCode errorCode_;
	}
}
