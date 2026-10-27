using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A9 RID: 1193
	[NetMessage(EMessageId.EntityPatrolAddTagResponse)]
	public sealed class EntityPatrolAddTagResponse : IMessage<EntityPatrolAddTagResponse>, IMessage, IEquatable<EntityPatrolAddTagResponse>, IDeepCloneable<EntityPatrolAddTagResponse>, IBufferMessage
	{
		// Token: 0x060071B5 RID: 29109 RVA: 0x00116D5C File Offset: 0x00114F5C
		[NullableContext(1)]
		public static EntityPatrolAddTagResponse Create()
		{
			return new EntityPatrolAddTagResponse();
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060071B6 RID: 29110 RVA: 0x00116D63 File Offset: 0x00114F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x00116D66 File Offset: 0x00114F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolAddTagResponse.Descriptor;
			}
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x00116D6D File Offset: 0x00114F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse()
		{
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x00116D75 File Offset: 0x00114F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse(EntityPatrolAddTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00116D9A File Offset: 0x00114F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagResponse Clone()
		{
			return new EntityPatrolAddTagResponse(this);
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x00116DA2 File Offset: 0x00114FA2
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x00116DAA File Offset: 0x00114FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x00116DB3 File Offset: 0x00114FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolAddTagResponse);
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x00116DC1 File Offset: 0x00114FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolAddTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00116DF0 File Offset: 0x00114FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x00116E35 File Offset: 0x00115035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x00116E42 File Offset: 0x00115042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00116E4B File Offset: 0x0011504B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00116E80 File Offset: 0x00115080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00116EBE File Offset: 0x001150BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolAddTagResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00116EEF File Offset: 0x001150EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00116EF8 File Offset: 0x001150F8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C95 RID: 15509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C96 RID: 15510
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04003C97 RID: 15511
		private ErrorCode errorCode_;
	}
}
