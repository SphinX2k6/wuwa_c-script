using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A8 RID: 680
	public sealed class ClientStorageSetData : IMessage<ClientStorageSetData>, IMessage, IEquatable<ClientStorageSetData>, IDeepCloneable<ClientStorageSetData>, IBufferMessage
	{
		// Token: 0x0600468F RID: 18063 RVA: 0x000AD6C7 File Offset: 0x000AB8C7
		[NullableContext(1)]
		public static ClientStorageSetData Create()
		{
			return new ClientStorageSetData();
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x000AD6CE File Offset: 0x000AB8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x000AD6D1 File Offset: 0x000AB8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageSetData.Descriptor;
			}
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x000AD6D8 File Offset: 0x000AB8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData()
		{
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x000AD6EB File Offset: 0x000AB8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData(ClientStorageSetData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x000AD715 File Offset: 0x000AB915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageSetData Clone()
		{
			return new ClientStorageSetData(this);
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06004695 RID: 18069 RVA: 0x000AD71D File Offset: 0x000AB91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x000AD725 File Offset: 0x000AB925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageSetData);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000AD733 File Offset: 0x000AB933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageSetData other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x000AD768 File Offset: 0x000AB968
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

		// Token: 0x06004699 RID: 18073 RVA: 0x000AD79C File Offset: 0x000AB99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x000AD7A9 File Offset: 0x000AB9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x000AD7B2 File Offset: 0x000AB9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ClientStorageSetData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x000AD7DC File Offset: 0x000AB9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ClientStorageSetData._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000AD815 File Offset: 0x000ABA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageSetData other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x000AD843 File Offset: 0x000ABA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x000AD84C File Offset: 0x000ABA4C
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
					this.data_.AddEntriesFrom(ref input, ClientStorageSetData._repeated_data_codec);
				}
			}
		}

		// Token: 0x04002F5A RID: 12122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F5B RID: 12123
		public const int DataFieldNumber = 1;

		// Token: 0x04002F5C RID: 12124
		private static readonly FieldCodec<int> _repeated_data_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002F5D RID: 12125
		private readonly RepeatedField<int> data_ = new RepeatedField<int>();
	}
}
