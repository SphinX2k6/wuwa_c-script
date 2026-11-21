using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A9 RID: 681
	public sealed class ClientStorageListData : IMessage<ClientStorageListData>, IMessage, IEquatable<ClientStorageListData>, IDeepCloneable<ClientStorageListData>, IBufferMessage
	{
		// Token: 0x060046FA RID: 18170 RVA: 0x000AEF10 File Offset: 0x000AD110
		[NullableContext(1)]
		public static ClientStorageListData Create()
		{
			return new ClientStorageListData();
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x000AEF17 File Offset: 0x000AD117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageListData> Parser
		{
			get
			{
				return ClientStorageListData._parser;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x000AEF1E File Offset: 0x000AD11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x000AEF21 File Offset: 0x000AD121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageListData.Descriptor;
			}
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x000AEF28 File Offset: 0x000AD128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData()
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x000AEF3B File Offset: 0x000AD13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData(ClientStorageListData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x000AEF65 File Offset: 0x000AD165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData Clone()
		{
			return new ClientStorageListData(this);
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x000AEF6D File Offset: 0x000AD16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x000AEF75 File Offset: 0x000AD175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageListData);
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000AEF83 File Offset: 0x000AD183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageListData other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x000AEFB8 File Offset: 0x000AD1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000AEFEC File Offset: 0x000AD1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x000AEFF9 File Offset: 0x000AD1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000AF002 File Offset: 0x000AD202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageListData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000AF02C File Offset: 0x000AD22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageListData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x000AF065 File Offset: 0x000AD265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageListData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x000AF093 File Offset: 0x000AD293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x000AF09C File Offset: 0x000AD29C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, ClientStorageListData._repeated_data_codec);
				}
			}
		}

		// Token: 0x04002FD8 RID: 12248
		private static readonly MessageParser<ClientStorageListData> _parser = new MessageParser<ClientStorageListData>(() => new ClientStorageListData());

		// Token: 0x04002FD9 RID: 12249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FDA RID: 12250
		public const int DataFieldNumber = 1;

		// Token: 0x04002FDB RID: 12251
		private static readonly FieldCodec<int> _repeated_data_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002FDC RID: 12252
		private readonly RepeatedField<int> data_ = new RepeatedField<int>();
	}
}
