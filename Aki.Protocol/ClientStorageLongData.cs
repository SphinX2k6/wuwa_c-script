using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AA RID: 682
	public sealed class ClientStorageLongData : IMessage<ClientStorageLongData>, IMessage, IEquatable<ClientStorageLongData>, IDeepCloneable<ClientStorageLongData>, IBufferMessage
	{
		// Token: 0x0600470D RID: 18189 RVA: 0x000AF112 File Offset: 0x000AD312
		[NullableContext(1)]
		public static ClientStorageLongData Create()
		{
			return new ClientStorageLongData();
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x000AF119 File Offset: 0x000AD319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x000AF11C File Offset: 0x000AD31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageLongData.Descriptor;
			}
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x000AF123 File Offset: 0x000AD323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData()
		{
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000AF12B File Offset: 0x000AD32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData(ClientStorageLongData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000AF150 File Offset: 0x000AD350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData Clone()
		{
			return new ClientStorageLongData(this);
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x000AF158 File Offset: 0x000AD358
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x000AF160 File Offset: 0x000AD360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Data
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

		// Token: 0x06004715 RID: 18197 RVA: 0x000AF169 File Offset: 0x000AD369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageLongData);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x000AF177 File Offset: 0x000AD377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageLongData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x000AF1A8 File Offset: 0x000AD3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data != 0L)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x000AF1E7 File Offset: 0x000AD3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x000AF1F4 File Offset: 0x000AD3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x000AF1FD File Offset: 0x000AD3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x000AF230 File Offset: 0x000AD430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x000AF26E File Offset: 0x000AD46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageLongData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data != 0L)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x000AF29F File Offset: 0x000AD49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000AF2A8 File Offset: 0x000AD4A8
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
					this.Data = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002FDD RID: 12253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FDE RID: 12254
		public const int DataFieldNumber = 1;

		// Token: 0x04002FDF RID: 12255
		private long data_;
	}
}
