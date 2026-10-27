using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A9 RID: 681
	public sealed class ClientStorageStringData : IMessage<ClientStorageStringData>, IMessage, IEquatable<ClientStorageStringData>, IDeepCloneable<ClientStorageStringData>, IBufferMessage
	{
		// Token: 0x060046A1 RID: 18081 RVA: 0x000AD8A8 File Offset: 0x000ABAA8
		[NullableContext(1)]
		public static ClientStorageStringData Create()
		{
			return new ClientStorageStringData();
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x000AD8AF File Offset: 0x000ABAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x000AD8B2 File Offset: 0x000ABAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageStringData.Descriptor;
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x000AD8B9 File Offset: 0x000ABAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData()
		{
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000AD8CC File Offset: 0x000ABACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData(ClientStorageStringData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x000AD8F1 File Offset: 0x000ABAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData Clone()
		{
			return new ClientStorageStringData(this);
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x000AD8F9 File Offset: 0x000ABAF9
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x000AD901 File Offset: 0x000ABB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x000AD914 File Offset: 0x000ABB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageStringData);
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x000AD922 File Offset: 0x000ABB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageStringData other)
		{
			return other != null && (other == this || (!(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x000AD958 File Offset: 0x000ABB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data.Length != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x000AD999 File Offset: 0x000ABB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x000AD9A6 File Offset: 0x000ABBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x000AD9AF File Offset: 0x000ABBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x000AD9E8 File Offset: 0x000ABBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x000ADA2B File Offset: 0x000ABC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageStringData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data.Length != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x000ADA61 File Offset: 0x000ABC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x000ADA6C File Offset: 0x000ABC6C
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
					this.Data = input.ReadString();
				}
			}
		}

		// Token: 0x04002F5E RID: 12126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F5F RID: 12127
		public const int DataFieldNumber = 1;

		// Token: 0x04002F60 RID: 12128
		private string data_ = "";
	}
}
