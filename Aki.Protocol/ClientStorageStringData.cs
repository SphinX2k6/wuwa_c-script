using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AF RID: 687
	public sealed class ClientStorageStringData : IMessage<ClientStorageStringData>, IMessage, IEquatable<ClientStorageStringData>, IDeepCloneable<ClientStorageStringData>, IBufferMessage
	{
		// Token: 0x06004768 RID: 18280 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
		[NullableContext(1)]
		public static ClientStorageStringData Create()
		{
			return new ClientStorageStringData();
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x000AFABF File Offset: 0x000ADCBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x000AFAC2 File Offset: 0x000ADCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageStringData.Descriptor;
			}
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x000AFAC9 File Offset: 0x000ADCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData()
		{
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x000AFADC File Offset: 0x000ADCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData(ClientStorageStringData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x000AFB01 File Offset: 0x000ADD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageStringData Clone()
		{
			return new ClientStorageStringData(this);
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x000AFB09 File Offset: 0x000ADD09
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x000AFB11 File Offset: 0x000ADD11
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

		// Token: 0x06004770 RID: 18288 RVA: 0x000AFB24 File Offset: 0x000ADD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageStringData);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x000AFB32 File Offset: 0x000ADD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageStringData other)
		{
			return other != null && (other == this || (!(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x000AFB68 File Offset: 0x000ADD68
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

		// Token: 0x06004773 RID: 18291 RVA: 0x000AFBA9 File Offset: 0x000ADDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x000AFBB6 File Offset: 0x000ADDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x000AFBBF File Offset: 0x000ADDBF
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

		// Token: 0x06004776 RID: 18294 RVA: 0x000AFBF8 File Offset: 0x000ADDF8
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

		// Token: 0x06004777 RID: 18295 RVA: 0x000AFC3B File Offset: 0x000ADE3B
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

		// Token: 0x06004778 RID: 18296 RVA: 0x000AFC71 File Offset: 0x000ADE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x000AFC7C File Offset: 0x000ADE7C
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

		// Token: 0x04002FF1 RID: 12273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF2 RID: 12274
		public const int DataFieldNumber = 1;

		// Token: 0x04002FF3 RID: 12275
		private string data_ = "";
	}
}
