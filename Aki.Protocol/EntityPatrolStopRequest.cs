using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AE RID: 1198
	[NetMessage(EMessageId.EntityPatrolStopRequest)]
	public sealed class EntityPatrolStopRequest : IMessage<EntityPatrolStopRequest>, IMessage, IEquatable<EntityPatrolStopRequest>, IDeepCloneable<EntityPatrolStopRequest>, IBufferMessage
	{
		// Token: 0x06007213 RID: 29203 RVA: 0x00117815 File Offset: 0x00115A15
		[NullableContext(1)]
		public static EntityPatrolStopRequest Create()
		{
			return new EntityPatrolStopRequest();
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06007214 RID: 29204 RVA: 0x0011781C File Offset: 0x00115A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x0011781F File Offset: 0x00115A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStopRequest.Descriptor;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00117826 File Offset: 0x00115A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest()
		{
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x0011782E File Offset: 0x00115A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest(EntityPatrolStopRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00117853 File Offset: 0x00115A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStopRequest Clone()
		{
			return new EntityPatrolStopRequest(this);
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06007219 RID: 29209 RVA: 0x0011785B File Offset: 0x00115A5B
		// (set) Token: 0x0600721A RID: 29210 RVA: 0x00117863 File Offset: 0x00115A63
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

		// Token: 0x0600721B RID: 29211 RVA: 0x0011786C File Offset: 0x00115A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStopRequest);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x0011787A File Offset: 0x00115A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStopRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x001178A8 File Offset: 0x00115AA8
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

		// Token: 0x0600721E RID: 29214 RVA: 0x001178E7 File Offset: 0x00115AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x001178F4 File Offset: 0x00115AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x001178FD File Offset: 0x00115AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00117930 File Offset: 0x00115B30
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

		// Token: 0x06007222 RID: 29218 RVA: 0x0011796E File Offset: 0x00115B6E
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

		// Token: 0x06007223 RID: 29219 RVA: 0x0011799F File Offset: 0x00115B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x001179A8 File Offset: 0x00115BA8
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003CA8 RID: 15528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA9 RID: 15529
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003CAA RID: 15530
		private long entityId_;
	}
}
