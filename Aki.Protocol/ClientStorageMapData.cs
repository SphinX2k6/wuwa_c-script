using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A5 RID: 677
	public sealed class ClientStorageMapData : IMessage<ClientStorageMapData>, IMessage, IEquatable<ClientStorageMapData>, IDeepCloneable<ClientStorageMapData>, IBufferMessage
	{
		// Token: 0x06004658 RID: 18008 RVA: 0x000AD0DC File Offset: 0x000AB2DC
		[NullableContext(1)]
		public static ClientStorageMapData Create()
		{
			return new ClientStorageMapData();
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x000AD0E3 File Offset: 0x000AB2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageMapData> Parser
		{
			get
			{
				return ClientStorageMapData._parser;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x000AD0EA File Offset: 0x000AB2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x000AD0ED File Offset: 0x000AB2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapData.Descriptor;
			}
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x000AD0F4 File Offset: 0x000AB2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData()
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x000AD107 File Offset: 0x000AB307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData(ClientStorageMapData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x000AD131 File Offset: 0x000AB331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData Clone()
		{
			return new ClientStorageMapData(this);
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x000AD139 File Offset: 0x000AB339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x000AD141 File Offset: 0x000AB341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapData);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x000AD14F File Offset: 0x000AB34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000AD184 File Offset: 0x000AB384
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

		// Token: 0x06004663 RID: 18019 RVA: 0x000AD1B8 File Offset: 0x000AB3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x000AD1C5 File Offset: 0x000AB3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x000AD1CE File Offset: 0x000AB3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageMapData._map_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x000AD1F8 File Offset: 0x000AB3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageMapData._map_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x000AD231 File Offset: 0x000AB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageMapData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.MergeFrom(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x000AD25F File Offset: 0x000AB45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x000AD268 File Offset: 0x000AB468
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
					this.data_.AddEntriesFrom(ref input, ClientStorageMapData._map_data_codec);
				}
			}
		}

		// Token: 0x04002F4D RID: 12109
		private static readonly MessageParser<ClientStorageMapData> _parser = new MessageParser<ClientStorageMapData>(() => new ClientStorageMapData());

		// Token: 0x04002F4E RID: 12110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F4F RID: 12111
		public const int DataFieldNumber = 1;

		// Token: 0x04002F50 RID: 12112
		private static readonly MapField<int, int>.Codec _map_data_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04002F51 RID: 12113
		private readonly MapField<int, int> data_ = new MapField<int, int>();
	}
}
