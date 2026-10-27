using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A7 RID: 679
	public sealed class ClientStorageMapMapData : IMessage<ClientStorageMapMapData>, IMessage, IEquatable<ClientStorageMapMapData>, IDeepCloneable<ClientStorageMapMapData>, IBufferMessage
	{
		// Token: 0x0600467D RID: 18045 RVA: 0x000AD4D7 File Offset: 0x000AB6D7
		[NullableContext(1)]
		public static ClientStorageMapMapData Create()
		{
			return new ClientStorageMapMapData();
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x000AD4DE File Offset: 0x000AB6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x000AD4E1 File Offset: 0x000AB6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapMapData.Descriptor;
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x000AD4E8 File Offset: 0x000AB6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData()
		{
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000AD4FB File Offset: 0x000AB6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData(ClientStorageMapMapData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x000AD525 File Offset: 0x000AB725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapMapData Clone()
		{
			return new ClientStorageMapMapData(this);
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x000AD52D File Offset: 0x000AB72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ClientStorageMapData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x000AD535 File Offset: 0x000AB735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapMapData);
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x000AD543 File Offset: 0x000AB743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapMapData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x000AD578 File Offset: 0x000AB778
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

		// Token: 0x06004687 RID: 18055 RVA: 0x000AD5AC File Offset: 0x000AB7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x000AD5B9 File Offset: 0x000AB7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x000AD5C2 File Offset: 0x000AB7C2
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

		// Token: 0x0600468A RID: 18058 RVA: 0x000AD5EC File Offset: 0x000AB7EC
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

		// Token: 0x0600468B RID: 18059 RVA: 0x000AD625 File Offset: 0x000AB825
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

		// Token: 0x0600468C RID: 18060 RVA: 0x000AD653 File Offset: 0x000AB853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x000AD65C File Offset: 0x000AB85C
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

		// Token: 0x04002F56 RID: 12118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F57 RID: 12119
		public const int DataFieldNumber = 1;

		// Token: 0x04002F58 RID: 12120
		private static readonly MapField<int, ClientStorageMapData>.Codec _map_data_codec = new MapField<int, ClientStorageMapData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ClientStorageMapData>(18U, ClientStorageMapData.Parser), 10U);

		// Token: 0x04002F59 RID: 12121
		private readonly MapField<int, ClientStorageMapData> data_ = new MapField<int, ClientStorageMapData>();
	}
}
