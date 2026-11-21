using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AC RID: 684
	public sealed class ClientStorageMapListData : IMessage<ClientStorageMapListData>, IMessage, IEquatable<ClientStorageMapListData>, IDeepCloneable<ClientStorageMapListData>, IBufferMessage
	{
		// Token: 0x06004732 RID: 18226 RVA: 0x000AF4F9 File Offset: 0x000AD6F9
		[NullableContext(1)]
		public static ClientStorageMapListData Create()
		{
			return new ClientStorageMapListData();
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x000AF500 File Offset: 0x000AD700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x000AF503 File Offset: 0x000AD703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapListData.Descriptor;
			}
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x000AF50A File Offset: 0x000AD70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData()
		{
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x000AF51D File Offset: 0x000AD71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData(ClientStorageMapListData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x000AF547 File Offset: 0x000AD747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData Clone()
		{
			return new ClientStorageMapListData(this);
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x000AF54F File Offset: 0x000AD74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ClientStorageListData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x000AF557 File Offset: 0x000AD757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapListData);
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x000AF565 File Offset: 0x000AD765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapListData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000AF598 File Offset: 0x000AD798
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

		// Token: 0x0600473C RID: 18236 RVA: 0x000AF5CC File Offset: 0x000AD7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x000AF5D9 File Offset: 0x000AD7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x000AF5E2 File Offset: 0x000AD7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageMapListData._map_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x000AF60C File Offset: 0x000AD80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageMapListData._map_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x000AF645 File Offset: 0x000AD845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageMapListData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.MergeFrom(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x000AF673 File Offset: 0x000AD873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x000AF67C File Offset: 0x000AD87C
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
					this.data_.AddEntriesFrom(ref input, ClientStorageMapListData._map_data_codec);
				}
			}
		}

		// Token: 0x04002FE5 RID: 12261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE6 RID: 12262
		public const int DataFieldNumber = 1;

		// Token: 0x04002FE7 RID: 12263
		private static readonly MapField<int, ClientStorageListData>.Codec _map_data_codec = new MapField<int, ClientStorageListData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ClientStorageListData>(18U, ClientStorageListData.Parser), 10U);

		// Token: 0x04002FE8 RID: 12264
		private readonly MapField<int, ClientStorageListData> data_ = new MapField<int, ClientStorageListData>();
	}
}
