using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EA RID: 1002
	[NetMessage(EMessageId.DollGarbInsertCoinRequest)]
	public sealed class DollGarbInsertCoinRequest : IMessage<DollGarbInsertCoinRequest>, IMessage, IEquatable<DollGarbInsertCoinRequest>, IDeepCloneable<DollGarbInsertCoinRequest>, IBufferMessage
	{
		// Token: 0x0600613B RID: 24891 RVA: 0x000EAC5C File Offset: 0x000E8E5C
		[NullableContext(1)]
		public static DollGarbInsertCoinRequest Create()
		{
			return new DollGarbInsertCoinRequest();
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600613C RID: 24892 RVA: 0x000EAC63 File Offset: 0x000E8E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x000EAC66 File Offset: 0x000E8E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbInsertCoinRequest.Descriptor;
			}
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x000EAC6D File Offset: 0x000E8E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest()
		{
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x000EAC75 File Offset: 0x000E8E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest(DollGarbInsertCoinRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x000EAC9A File Offset: 0x000E8E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinRequest Clone()
		{
			return new DollGarbInsertCoinRequest(this);
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x000EACA2 File Offset: 0x000E8EA2
		// (set) Token: 0x06006142 RID: 24898 RVA: 0x000EACAA File Offset: 0x000E8EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x000EACB3 File Offset: 0x000E8EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbInsertCoinRequest);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x000EACC1 File Offset: 0x000E8EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbInsertCoinRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x000EACF0 File Offset: 0x000E8EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x000EAD2F File Offset: 0x000E8F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x000EAD3C File Offset: 0x000E8F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x000EAD45 File Offset: 0x000E8F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x000EAD78 File Offset: 0x000E8F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x000EADB6 File Offset: 0x000E8FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbInsertCoinRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x000EADE7 File Offset: 0x000E8FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x000EADF0 File Offset: 0x000E8FF0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003794 RID: 14228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003795 RID: 14229
		public const int EntityIncIdFieldNumber = 3;

		// Token: 0x04003796 RID: 14230
		private long entityIncId_;
	}
}
