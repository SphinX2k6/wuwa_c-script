using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000832 RID: 2098
	[NetMessage(EMessageId.ItemDecomposePreviewResponse)]
	public sealed class ItemDecomposePreviewResponse : IMessage<ItemDecomposePreviewResponse>, IMessage, IEquatable<ItemDecomposePreviewResponse>, IDeepCloneable<ItemDecomposePreviewResponse>, IBufferMessage
	{
		// Token: 0x0600BBB2 RID: 48050 RVA: 0x001BF04D File Offset: 0x001BD24D
		[NullableContext(1)]
		public static ItemDecomposePreviewResponse Create()
		{
			return new ItemDecomposePreviewResponse();
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x0600BBB3 RID: 48051 RVA: 0x001BF054 File Offset: 0x001BD254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x001BF057 File Offset: 0x001BD257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposePreviewResponse.Descriptor;
			}
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x001BF05E File Offset: 0x001BD25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse()
		{
		}

		// Token: 0x0600BBB6 RID: 48054 RVA: 0x001BF071 File Offset: 0x001BD271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse(ItemDecomposePreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x001BF0A7 File Offset: 0x001BD2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse Clone()
		{
			return new ItemDecomposePreviewResponse(this);
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x001BF0AF File Offset: 0x001BD2AF
		// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x001BF0B7 File Offset: 0x001BD2B7
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

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x001BF0C0 File Offset: 0x001BD2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x001BF0C8 File Offset: 0x001BD2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposePreviewResponse);
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x001BF0D8 File Offset: 0x001BD2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposePreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x001BF128 File Offset: 0x001BD328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x001BF17B File Offset: 0x001BD37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x001BF188 File Offset: 0x001BD388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x001BF194 File Offset: 0x001BD394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, ItemDecomposePreviewResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x001BF1E4 File Offset: 0x001BD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(ItemDecomposePreviewResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x001BF238 File Offset: 0x001BD438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposePreviewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x001BF285 File Offset: 0x001BD485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x001BF290 File Offset: 0x001BD490
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
					if (num != 32U)
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
					this.itemMap_.AddEntriesFrom(ref input, ItemDecomposePreviewResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040052A5 RID: 21157
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052A6 RID: 21158
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040052A7 RID: 21159
		private ErrorCode errorCode_;

		// Token: 0x040052A8 RID: 21160
		public const int ItemMapFieldNumber = 3;

		// Token: 0x040052A9 RID: 21161
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040052AA RID: 21162
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
