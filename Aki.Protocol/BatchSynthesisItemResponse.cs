using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000161 RID: 353
	[NetMessage(EMessageId.BatchSynthesisItemResponse)]
	public sealed class BatchSynthesisItemResponse : IMessage<BatchSynthesisItemResponse>, IMessage, IEquatable<BatchSynthesisItemResponse>, IDeepCloneable<BatchSynthesisItemResponse>, IBufferMessage
	{
		// Token: 0x06002C2F RID: 11311 RVA: 0x000731A5 File Offset: 0x000713A5
		[NullableContext(1)]
		public static BatchSynthesisItemResponse Create()
		{
			return new BatchSynthesisItemResponse();
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000731AC File Offset: 0x000713AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000731AF File Offset: 0x000713AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSynthesisItemResponse.Descriptor;
			}
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000731B6 File Offset: 0x000713B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse()
		{
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000731C9 File Offset: 0x000713C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse(BatchSynthesisItemResponse other) : this()
		{
			this.code_ = other.code_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000731FF File Offset: 0x000713FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemResponse Clone()
		{
			return new BatchSynthesisItemResponse(this);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x00073207 File Offset: 0x00071407
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x0007320F File Offset: 0x0007140F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x00073218 File Offset: 0x00071418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00073220 File Offset: 0x00071420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSynthesisItemResponse);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00073230 File Offset: 0x00071430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchSynthesisItemResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Items.Equals(other.Items) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00073280 File Offset: 0x00071480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.Items.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000732D3 File Offset: 0x000714D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000732E0 File Offset: 0x000714E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000732EC File Offset: 0x000714EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			this.items_.WriteTo(ref output, BatchSynthesisItemResponse._map_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0007333C File Offset: 0x0007153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.items_.CalculateSize(BatchSynthesisItemResponse._map_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00073390 File Offset: 0x00071590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchSynthesisItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.items_.MergeFrom(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000733DD File Offset: 0x000715DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000733E8 File Offset: 0x000715E8
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
				if (num != 16U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, BatchSynthesisItemResponse._map_items_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027E9 RID: 10217
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027EA RID: 10218
		public const int CodeFieldNumber = 2;

		// Token: 0x040027EB RID: 10219
		private ErrorCode code_;

		// Token: 0x040027EC RID: 10220
		public const int ItemsFieldNumber = 6;

		// Token: 0x040027ED RID: 10221
		private static readonly MapField<int, int>.Codec _map_items_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x040027EE RID: 10222
		private readonly MapField<int, int> items_ = new MapField<int, int>();
	}
}
