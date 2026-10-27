using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A6 RID: 678
	public sealed class ClientStorageMapListData : IMessage<ClientStorageMapListData>, IMessage, IEquatable<ClientStorageMapListData>, IDeepCloneable<ClientStorageMapListData>, IBufferMessage
	{
		// Token: 0x0600466B RID: 18027 RVA: 0x000AD2E9 File Offset: 0x000AB4E9
		[NullableContext(1)]
		public static ClientStorageMapListData Create()
		{
			return new ClientStorageMapListData();
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000AD2F0 File Offset: 0x000AB4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000AD2F3 File Offset: 0x000AB4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageMapListData.Descriptor;
			}
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x000AD2FA File Offset: 0x000AB4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData()
		{
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x000AD30D File Offset: 0x000AB50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData(ClientStorageMapListData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x000AD337 File Offset: 0x000AB537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageMapListData Clone()
		{
			return new ClientStorageMapListData(this);
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x000AD33F File Offset: 0x000AB53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ClientStorageListData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x000AD347 File Offset: 0x000AB547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageMapListData);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x000AD355 File Offset: 0x000AB555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageMapListData other)
		{
			return other != null && (other == this || (this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x000AD388 File Offset: 0x000AB588
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

		// Token: 0x06004675 RID: 18037 RVA: 0x000AD3BC File Offset: 0x000AB5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x000AD3C9 File Offset: 0x000AB5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x000AD3D2 File Offset: 0x000AB5D2
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

		// Token: 0x06004678 RID: 18040 RVA: 0x000AD3FC File Offset: 0x000AB5FC
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

		// Token: 0x06004679 RID: 18041 RVA: 0x000AD435 File Offset: 0x000AB635
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

		// Token: 0x0600467A RID: 18042 RVA: 0x000AD463 File Offset: 0x000AB663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x000AD46C File Offset: 0x000AB66C
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

		// Token: 0x04002F52 RID: 12114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F53 RID: 12115
		public const int DataFieldNumber = 1;

		// Token: 0x04002F54 RID: 12116
		private static readonly MapField<int, ClientStorageListData>.Codec _map_data_codec = new MapField<int, ClientStorageListData>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ClientStorageListData>(18U, ClientStorageListData.Parser), 10U);

		// Token: 0x04002F55 RID: 12117
		private readonly MapField<int, ClientStorageListData> data_ = new MapField<int, ClientStorageListData>();
	}
}
