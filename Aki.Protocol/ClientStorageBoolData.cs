using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A0 RID: 672
	public sealed class ClientStorageBoolData : IMessage<ClientStorageBoolData>, IMessage, IEquatable<ClientStorageBoolData>, IDeepCloneable<ClientStorageBoolData>, IBufferMessage
	{
		// Token: 0x060045E7 RID: 17895 RVA: 0x000ABD48 File Offset: 0x000A9F48
		[NullableContext(1)]
		public static ClientStorageBoolData Create()
		{
			return new ClientStorageBoolData();
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x000ABD4F File Offset: 0x000A9F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x000ABD52 File Offset: 0x000A9F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageBoolData.Descriptor;
			}
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x000ABD59 File Offset: 0x000A9F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData()
		{
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000ABD61 File Offset: 0x000A9F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData(ClientStorageBoolData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x000ABD86 File Offset: 0x000A9F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageBoolData Clone()
		{
			return new ClientStorageBoolData(this);
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x000ABD8E File Offset: 0x000A9F8E
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x000ABD96 File Offset: 0x000A9F96
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

		// Token: 0x060045EF RID: 17903 RVA: 0x000ABD9F File Offset: 0x000A9F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageBoolData);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x000ABDAD File Offset: 0x000A9FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageBoolData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x000ABDDC File Offset: 0x000A9FDC
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

		// Token: 0x060045F2 RID: 17906 RVA: 0x000ABE1B File Offset: 0x000AA01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x000ABE28 File Offset: 0x000AA028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x000ABE31 File Offset: 0x000AA031
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

		// Token: 0x060045F5 RID: 17909 RVA: 0x000ABE64 File Offset: 0x000AA064
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

		// Token: 0x060045F6 RID: 17910 RVA: 0x000ABE96 File Offset: 0x000AA096
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

		// Token: 0x060045F7 RID: 17911 RVA: 0x000ABEC7 File Offset: 0x000AA0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x000ABED0 File Offset: 0x000AA0D0
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

		// Token: 0x04002F30 RID: 12080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F31 RID: 12081
		public const int DataFieldNumber = 1;

		// Token: 0x04002F32 RID: 12082
		private bool data_;
	}
}
