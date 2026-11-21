using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000497 RID: 1175
	[NetMessage(EMessageId.EntityPatrolStopRequest)]
	public sealed class EntityPatrolStopRequest : IMessage<EntityPatrolStopRequest>, IMessage, IEquatable<EntityPatrolStopRequest>, IDeepCloneable<EntityPatrolStopRequest>, IBufferMessage
	{
		// Token: 0x06007085 RID: 28805 RVA: 0x001147A5 File Offset: 0x001129A5
		[NullableContext(1)]
		public static EntityPatrolStopRequest Create()
		{
			return new EntityPatrolStopRequest();
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06007086 RID: 28806 RVA: 0x001147AC File Offset: 0x001129AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x001147AF File Offset: 0x001129AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStopRequest.Descriptor;
			}
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x001147B6 File Offset: 0x001129B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest()
		{
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x001147BE File Offset: 0x001129BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest(EntityPatrolStopRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x001147E3 File Offset: 0x001129E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest Clone()
		{
			return new EntityPatrolStopRequest(this);
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x0600708B RID: 28811 RVA: 0x001147EB File Offset: 0x001129EB
		// (set) Token: 0x0600708C RID: 28812 RVA: 0x001147F3 File Offset: 0x001129F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x001147FC File Offset: 0x001129FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStopRequest);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x0011480A File Offset: 0x00112A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStopRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x00114838 File Offset: 0x00112A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00114877 File Offset: 0x00112A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x00114884 File Offset: 0x00112A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x0011488D File Offset: 0x00112A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x001148C0 File Offset: 0x00112AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x001148FE File Offset: 0x00112AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStopRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0011492F File Offset: 0x00112B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00114938 File Offset: 0x00112B38
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C96 RID: 15510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C97 RID: 15511
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003C98 RID: 15512
		private long entityId_;
	}
}
