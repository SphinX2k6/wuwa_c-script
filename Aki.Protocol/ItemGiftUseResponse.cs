using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000843 RID: 2115
	[NetMessage(EMessageId.ItemGiftUseResponse)]
	public sealed class ItemGiftUseResponse : IMessage<ItemGiftUseResponse>, IMessage, IEquatable<ItemGiftUseResponse>, IDeepCloneable<ItemGiftUseResponse>, IBufferMessage
	{
		// Token: 0x0600BD08 RID: 48392 RVA: 0x001C1BA6 File Offset: 0x001BFDA6
		[NullableContext(1)]
		public static ItemGiftUseResponse Create()
		{
			return new ItemGiftUseResponse();
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600BD09 RID: 48393 RVA: 0x001C1BAD File Offset: 0x001BFDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600BD0A RID: 48394 RVA: 0x001C1BB0 File Offset: 0x001BFDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseResponse.Descriptor;
			}
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x001C1BB7 File Offset: 0x001BFDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse()
		{
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x001C1BCA File Offset: 0x001BFDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse(ItemGiftUseResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x001C1C00 File Offset: 0x001BFE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseResponse Clone()
		{
			return new ItemGiftUseResponse(this);
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600BD0E RID: 48398 RVA: 0x001C1C08 File Offset: 0x001BFE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x001C1C10 File Offset: 0x001BFE10
		// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x001C1C18 File Offset: 0x001BFE18
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

		// Token: 0x0600BD11 RID: 48401 RVA: 0x001C1C21 File Offset: 0x001BFE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseResponse);
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x001C1C30 File Offset: 0x001BFE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x001C1C80 File Offset: 0x001BFE80
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

		// Token: 0x0600BD14 RID: 48404 RVA: 0x001C1CD3 File Offset: 0x001BFED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x001C1CE0 File Offset: 0x001BFEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x001C1CEC File Offset: 0x001BFEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, ItemGiftUseResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x001C1D3C File Offset: 0x001BFF3C
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

		// Token: 0x0600BD18 RID: 48408 RVA: 0x001C1D90 File Offset: 0x001BFF90
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

		// Token: 0x0600BD19 RID: 48409 RVA: 0x001C1DDD File Offset: 0x001BFFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x001C1DE8 File Offset: 0x001BFFE8
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
					if (num != 112U)
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
					this.infos_.AddEntriesFrom(ref input, ItemGiftUseResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04005301 RID: 21249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005302 RID: 21250
		public const int InfosFieldNumber = 3;

		// Token: 0x04005303 RID: 21251
		private static readonly FieldCodec<AddCountItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<AddCountItemInfo>(26U, AddCountItemInfo.Parser);

		// Token: 0x04005304 RID: 21252
		private readonly RepeatedField<AddCountItemInfo> infos_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x04005305 RID: 21253
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005306 RID: 21254
		private ErrorCode errorCode_;
	}
}
