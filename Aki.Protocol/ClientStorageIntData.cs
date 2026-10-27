using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A2 RID: 674
	public sealed class ClientStorageIntData : IMessage<ClientStorageIntData>, IMessage, IEquatable<ClientStorageIntData>, IDeepCloneable<ClientStorageIntData>, IBufferMessage
	{
		// Token: 0x06004621 RID: 17953 RVA: 0x000ACB26 File Offset: 0x000AAD26
		[NullableContext(1)]
		public static ClientStorageIntData Create()
		{
			return new ClientStorageIntData();
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x000ACB2D File Offset: 0x000AAD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x000ACB30 File Offset: 0x000AAD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageIntData.Descriptor;
			}
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x000ACB37 File Offset: 0x000AAD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData()
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x000ACB3F File Offset: 0x000AAD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData(ClientStorageIntData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000ACB64 File Offset: 0x000AAD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData Clone()
		{
			return new ClientStorageIntData(this);
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x000ACB6C File Offset: 0x000AAD6C
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x000ACB74 File Offset: 0x000AAD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Data
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

		// Token: 0x06004629 RID: 17961 RVA: 0x000ACB7D File Offset: 0x000AAD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageIntData);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x000ACB8B File Offset: 0x000AAD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageIntData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x000ACBBC File Offset: 0x000AADBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x000ACBFB File Offset: 0x000AADFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x000ACC08 File Offset: 0x000AAE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x000ACC11 File Offset: 0x000AAE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000ACC44 File Offset: 0x000AAE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x000ACC82 File Offset: 0x000AAE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageIntData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x000ACCB3 File Offset: 0x000AAEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x000ACCBC File Offset: 0x000AAEBC
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
					this.Data = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F42 RID: 12098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F43 RID: 12099
		public const int DataFieldNumber = 1;

		// Token: 0x04002F44 RID: 12100
		private int data_;
	}
}
