using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A6 RID: 678
	public sealed class ClientStorageBoolData : IMessage<ClientStorageBoolData>, IMessage, IEquatable<ClientStorageBoolData>, IDeepCloneable<ClientStorageBoolData>, IBufferMessage
	{
		// Token: 0x060046AE RID: 18094 RVA: 0x000ADF58 File Offset: 0x000AC158
		[NullableContext(1)]
		public static ClientStorageBoolData Create()
		{
			return new ClientStorageBoolData();
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x000ADF5F File Offset: 0x000AC15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x000ADF62 File Offset: 0x000AC162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageBoolData.Descriptor;
			}
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x000ADF69 File Offset: 0x000AC169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData()
		{
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x000ADF71 File Offset: 0x000AC171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData(ClientStorageBoolData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x000ADF96 File Offset: 0x000AC196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData Clone()
		{
			return new ClientStorageBoolData(this);
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000ADF9E File Offset: 0x000AC19E
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x000ADFA6 File Offset: 0x000AC1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x000ADFAF File Offset: 0x000AC1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageBoolData);
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x000ADFBD File Offset: 0x000AC1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageBoolData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x000ADFEC File Offset: 0x000AC1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x000AE02B File Offset: 0x000AC22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x000AE038 File Offset: 0x000AC238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x000AE041 File Offset: 0x000AC241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x000AE074 File Offset: 0x000AC274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x000AE0A6 File Offset: 0x000AC2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageBoolData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x000AE0D7 File Offset: 0x000AC2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x000AE0E0 File Offset: 0x000AC2E0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadBool();
				}
			}
		}

		// Token: 0x04002FC3 RID: 12227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC4 RID: 12228
		public const int DataFieldNumber = 1;

		// Token: 0x04002FC5 RID: 12229
		private bool data_;
	}
}
