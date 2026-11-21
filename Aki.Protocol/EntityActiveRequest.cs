using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044C RID: 1100
	[NetMessage(EMessageId.EntityActiveRequest)]
	public sealed class EntityActiveRequest : IMessage<EntityActiveRequest>, IMessage, IEquatable<EntityActiveRequest>, IDeepCloneable<EntityActiveRequest>, IBufferMessage
	{
		// Token: 0x060069A4 RID: 27044 RVA: 0x000FF8CB File Offset: 0x000FDACB
		[NullableContext(1)]
		public static EntityActiveRequest Create()
		{
			return new EntityActiveRequest();
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x000FF8D2 File Offset: 0x000FDAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x000FF8D5 File Offset: 0x000FDAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityActiveRequest.Descriptor;
			}
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x000FF8DC File Offset: 0x000FDADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest()
		{
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x000FF8E4 File Offset: 0x000FDAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest(EntityActiveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x000FF909 File Offset: 0x000FDB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest Clone()
		{
			return new EntityActiveRequest(this);
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060069AA RID: 27050 RVA: 0x000FF911 File Offset: 0x000FDB11
		// (set) Token: 0x060069AB RID: 27051 RVA: 0x000FF919 File Offset: 0x000FDB19
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

		// Token: 0x060069AC RID: 27052 RVA: 0x000FF922 File Offset: 0x000FDB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityActiveRequest);
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x000FF930 File Offset: 0x000FDB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityActiveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x000FF960 File Offset: 0x000FDB60
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

		// Token: 0x060069AF RID: 27055 RVA: 0x000FF99F File Offset: 0x000FDB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x000FF9AC File Offset: 0x000FDBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x000FF9B5 File Offset: 0x000FDBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x000FF9E8 File Offset: 0x000FDBE8
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

		// Token: 0x060069B3 RID: 27059 RVA: 0x000FFA26 File Offset: 0x000FDC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityActiveRequest other)
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

		// Token: 0x060069B4 RID: 27060 RVA: 0x000FFA57 File Offset: 0x000FDC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x000FFA60 File Offset: 0x000FDC60
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003A6F RID: 14959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A70 RID: 14960
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003A71 RID: 14961
		private long entityId_;
	}
}
