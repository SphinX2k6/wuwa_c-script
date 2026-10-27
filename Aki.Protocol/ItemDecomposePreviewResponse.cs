using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000845 RID: 2117
	[NetMessage(EMessageId.ItemDecomposePreviewResponse)]
	public sealed class ItemDecomposePreviewResponse : IMessage<ItemDecomposePreviewResponse>, IMessage, IEquatable<ItemDecomposePreviewResponse>, IDeepCloneable<ItemDecomposePreviewResponse>, IBufferMessage
	{
		// Token: 0x0600BCF6 RID: 48374 RVA: 0x001C185D File Offset: 0x001BFA5D
		[NullableContext(1)]
		public static ItemDecomposePreviewResponse Create()
		{
			return new ItemDecomposePreviewResponse();
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x0600BCF7 RID: 48375 RVA: 0x001C1864 File Offset: 0x001BFA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x001C1867 File Offset: 0x001BFA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposePreviewResponse.Descriptor;
			}
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x001C186E File Offset: 0x001BFA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse()
		{
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x001C1881 File Offset: 0x001BFA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse(ItemDecomposePreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x001C18B7 File Offset: 0x001BFAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewResponse Clone()
		{
			return new ItemDecomposePreviewResponse(this);
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600BCFC RID: 48380 RVA: 0x001C18BF File Offset: 0x001BFABF
		// (set) Token: 0x0600BCFD RID: 48381 RVA: 0x001C18C7 File Offset: 0x001BFAC7
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

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600BCFE RID: 48382 RVA: 0x001C18D0 File Offset: 0x001BFAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x001C18D8 File Offset: 0x001BFAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposePreviewResponse);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x001C18E8 File Offset: 0x001BFAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposePreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x001C1938 File Offset: 0x001BFB38
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

		// Token: 0x0600BD02 RID: 48386 RVA: 0x001C198B File Offset: 0x001BFB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x001C1998 File Offset: 0x001BFB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x001C19A4 File Offset: 0x001BFBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, ItemDecomposePreviewResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x001C19F4 File Offset: 0x001BFBF4
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

		// Token: 0x0600BD06 RID: 48390 RVA: 0x001C1A48 File Offset: 0x001BFC48
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

		// Token: 0x0600BD07 RID: 48391 RVA: 0x001C1A95 File Offset: 0x001BFC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x001C1AA0 File Offset: 0x001BFCA0
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
				if (num != 106U)
				{
					if (num != 120U)
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

		// Token: 0x040052A9 RID: 21161
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052AA RID: 21162
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040052AB RID: 21163
		private ErrorCode errorCode_;

		// Token: 0x040052AC RID: 21164
		public const int ItemMapFieldNumber = 13;

		// Token: 0x040052AD RID: 21165
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040052AE RID: 21166
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
