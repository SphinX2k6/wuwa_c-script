using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A3 RID: 675
	public sealed class ClientStorageListData : IMessage<ClientStorageListData>, IMessage, IEquatable<ClientStorageListData>, IDeepCloneable<ClientStorageListData>, IBufferMessage
	{
		// Token: 0x06004633 RID: 17971 RVA: 0x000ACD00 File Offset: 0x000AAF00
		[NullableContext(1)]
		public static ClientStorageListData Create()
		{
			return new ClientStorageListData();
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x000ACD07 File Offset: 0x000AAF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientStorageListData> Parser
		{
			get
			{
				return ClientStorageListData._parser;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x000ACD0E File Offset: 0x000AAF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06004636 RID: 17974 RVA: 0x000ACD11 File Offset: 0x000AAF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageListData.Descriptor;
			}
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x000ACD18 File Offset: 0x000AAF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData()
		{
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x000ACD2B File Offset: 0x000AAF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData(ClientStorageListData other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x000ACD55 File Offset: 0x000AAF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageListData Clone()
		{
			return new ClientStorageListData(this);
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x000ACD5D File Offset: 0x000AAF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000ACD65 File Offset: 0x000AAF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageListData);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x000ACD73 File Offset: 0x000AAF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageListData other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000ACDA8 File Offset: 0x000AAFA8
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

		// Token: 0x0600463E RID: 17982 RVA: 0x000ACDDC File Offset: 0x000AAFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x000ACDE9 File Offset: 0x000AAFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x000ACDF2 File Offset: 0x000AAFF2
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

		// Token: 0x06004641 RID: 17985 RVA: 0x000ACE1C File Offset: 0x000AB01C
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

		// Token: 0x06004642 RID: 17986 RVA: 0x000ACE55 File Offset: 0x000AB055
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

		// Token: 0x06004643 RID: 17987 RVA: 0x000ACE83 File Offset: 0x000AB083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x000ACE8C File Offset: 0x000AB08C
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

		// Token: 0x04002F45 RID: 12101
		private static readonly MessageParser<ClientStorageListData> _parser = new MessageParser<ClientStorageListData>(() => new ClientStorageListData());

		// Token: 0x04002F46 RID: 12102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F47 RID: 12103
		public const int DataFieldNumber = 1;

		// Token: 0x04002F48 RID: 12104
		private static readonly FieldCodec<int> _repeated_data_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002F49 RID: 12105
		private readonly RepeatedField<int> data_ = new RepeatedField<int>();
	}
}
