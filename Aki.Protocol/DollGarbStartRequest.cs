using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D5 RID: 981
	[NetMessage(EMessageId.DollGarbStartRequest)]
	public sealed class DollGarbStartRequest : IMessage<DollGarbStartRequest>, IMessage, IEquatable<DollGarbStartRequest>, IDeepCloneable<DollGarbStartRequest>, IBufferMessage
	{
		// Token: 0x06005FCF RID: 24527 RVA: 0x000E7E95 File Offset: 0x000E6095
		[NullableContext(1)]
		public static DollGarbStartRequest Create()
		{
			return new DollGarbStartRequest();
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06005FD0 RID: 24528 RVA: 0x000E7E9C File Offset: 0x000E609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005FD1 RID: 24529 RVA: 0x000E7E9F File Offset: 0x000E609F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbStartRequest.Descriptor;
			}
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x000E7EA6 File Offset: 0x000E60A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest()
		{
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x000E7EAE File Offset: 0x000E60AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest(DollGarbStartRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x000E7ED3 File Offset: 0x000E60D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartRequest Clone()
		{
			return new DollGarbStartRequest(this);
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06005FD5 RID: 24533 RVA: 0x000E7EDB File Offset: 0x000E60DB
		// (set) Token: 0x06005FD6 RID: 24534 RVA: 0x000E7EE3 File Offset: 0x000E60E3
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

		// Token: 0x06005FD7 RID: 24535 RVA: 0x000E7EEC File Offset: 0x000E60EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbStartRequest);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x000E7EFA File Offset: 0x000E60FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbStartRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x000E7F28 File Offset: 0x000E6128
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

		// Token: 0x06005FDA RID: 24538 RVA: 0x000E7F67 File Offset: 0x000E6167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x000E7F74 File Offset: 0x000E6174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x000E7F7D File Offset: 0x000E617D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x000E7FB0 File Offset: 0x000E61B0
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

		// Token: 0x06005FDE RID: 24542 RVA: 0x000E7FEE File Offset: 0x000E61EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbStartRequest other)
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

		// Token: 0x06005FDF RID: 24543 RVA: 0x000E801F File Offset: 0x000E621F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x000E8028 File Offset: 0x000E6228
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003787 RID: 14215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003788 RID: 14216
		public const int EntityIncIdFieldNumber = 5;

		// Token: 0x04003789 RID: 14217
		private long entityIncId_;
	}
}
