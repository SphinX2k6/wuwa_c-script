using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AD RID: 685
	public sealed class ClientStorageMapMapData : IMessage<ClientStorageMapMapData>, IMessage, IEquatable<ClientStorageMapMapData>, IDeepCloneable<ClientStorageMapMapData>, IBufferMessage
	{
		// Token: 0x06004744 RID: 18244 RVA: 0x000AF6E7 File Offset: 0x000AD8E7
		[NullableContext(1)]
		public static ClientStorageMapMapData Create()
		{
			return new ClientStorageMapMapData();
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x000AF6EE File Offset: 0x000AD8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x000AF6F1 File Offset: 0x000AD8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapMapData.Descriptor;
			}
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x000AF6F8 File Offset: 0x000AD8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData()
		{
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x000AF70B File Offset: 0x000AD90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData(ClientStorageMapMapData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x000AF735 File Offset: 0x000AD935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData Clone()
		{
			return new ClientStorageMapMapData(this);
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x000AF73D File Offset: 0x000AD93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ClientStorageMapData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x000AF745 File Offset: 0x000AD945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapMapData);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x000AF753 File Offset: 0x000AD953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapMapData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x000AF788 File Offset: 0x000AD988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Data.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x000AF7BC File Offset: 0x000AD9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x000AF7C9 File Offset: 0x000AD9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x000AF7D2 File Offset: 0x000AD9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageMapMapData._map_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x000AF7FC File Offset: 0x000AD9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageMapMapData._map_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x000AF835 File Offset: 0x000ADA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageMapMapData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.MergeFrom(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x000AF863 File Offset: 0x000ADA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x000AF86C File Offset: 0x000ADA6C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, ClientStorageMapMapData._map_data_codec);
				}
			}
		}

		// Token: 0x04002FE9 RID: 12265
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FEA RID: 12266
		public const int DataFieldNumber = 1;

		// Token: 0x04002FEB RID: 12267
		private static readonly MapField<int, ClientStorageMapData>.Codec _map_data_codec = new MapField<int, ClientStorageMapData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ClientStorageMapData>(18U, ClientStorageMapData.Parser), 10U);

		// Token: 0x04002FEC RID: 12268
		private readonly MapField<int, ClientStorageMapData> data_ = new MapField<int, ClientStorageMapData>();
	}
}
