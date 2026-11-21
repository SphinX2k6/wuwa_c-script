using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AB RID: 683
	public sealed class ClientStorageMapData : IMessage<ClientStorageMapData>, IMessage, IEquatable<ClientStorageMapData>, IDeepCloneable<ClientStorageMapData>, IBufferMessage
	{
		// Token: 0x0600471F RID: 18207 RVA: 0x000AF2EC File Offset: 0x000AD4EC
		[NullableContext(1)]
		public static ClientStorageMapData Create()
		{
			return new ClientStorageMapData();
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x000AF2F3 File Offset: 0x000AD4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageMapData> Parser
		{
			get
			{
				return ClientStorageMapData._parser;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x000AF2FA File Offset: 0x000AD4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x000AF2FD File Offset: 0x000AD4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapData.Descriptor;
			}
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x000AF304 File Offset: 0x000AD504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData()
		{
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x000AF317 File Offset: 0x000AD517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData(ClientStorageMapData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x000AF341 File Offset: 0x000AD541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapData Clone()
		{
			return new ClientStorageMapData(this);
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x000AF349 File Offset: 0x000AD549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x000AF351 File Offset: 0x000AD551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapData);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x000AF35F File Offset: 0x000AD55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x000AF394 File Offset: 0x000AD594
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

		// Token: 0x0600472A RID: 18218 RVA: 0x000AF3C8 File Offset: 0x000AD5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x000AF3D5 File Offset: 0x000AD5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x000AF3DE File Offset: 0x000AD5DE
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

		// Token: 0x0600472D RID: 18221 RVA: 0x000AF408 File Offset: 0x000AD608
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

		// Token: 0x0600472E RID: 18222 RVA: 0x000AF441 File Offset: 0x000AD641
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

		// Token: 0x0600472F RID: 18223 RVA: 0x000AF46F File Offset: 0x000AD66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x000AF478 File Offset: 0x000AD678
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

		// Token: 0x04002FE0 RID: 12256
		private static readonly MessageParser<ClientStorageMapData> _parser = new MessageParser<ClientStorageMapData>(() => new ClientStorageMapData());

		// Token: 0x04002FE1 RID: 12257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE2 RID: 12258
		public const int DataFieldNumber = 1;

		// Token: 0x04002FE3 RID: 12259
		private static readonly MapField<int, int>.Codec _map_data_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04002FE4 RID: 12260
		private readonly MapField<int, int> data_ = new MapField<int, int>();
	}
}
