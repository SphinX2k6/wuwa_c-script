using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000468 RID: 1128
	[NetMessage(EMessageId.EntityAdsorbRequest)]
	public sealed class EntityAdsorbRequest : IMessage<EntityAdsorbRequest>, IMessage, IEquatable<EntityAdsorbRequest>, IDeepCloneable<EntityAdsorbRequest>, IBufferMessage
	{
		// Token: 0x06006BA2 RID: 27554 RVA: 0x00103B57 File Offset: 0x00101D57
		[NullableContext(1)]
		public static EntityAdsorbRequest Create()
		{
			return new EntityAdsorbRequest();
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x00103B5E File Offset: 0x00101D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x00103B61 File Offset: 0x00101D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAdsorbRequest.Descriptor;
			}
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x00103B68 File Offset: 0x00101D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest()
		{
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00103B70 File Offset: 0x00101D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest(EntityAdsorbRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00103B95 File Offset: 0x00101D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest Clone()
		{
			return new EntityAdsorbRequest(this);
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x00103B9D File Offset: 0x00101D9D
		// (set) Token: 0x06006BA9 RID: 27561 RVA: 0x00103BA5 File Offset: 0x00101DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x06006BAA RID: 27562 RVA: 0x00103BAE File Offset: 0x00101DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAdsorbRequest);
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00103BBC File Offset: 0x00101DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAdsorbRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00103BEC File Offset: 0x00101DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00103C2B File Offset: 0x00101E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00103C38 File Offset: 0x00101E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00103C41 File Offset: 0x00101E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00103C74 File Offset: 0x00101E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00103CB2 File Offset: 0x00101EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAdsorbRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00103CE3 File Offset: 0x00101EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00103CEC File Offset: 0x00101EEC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003AA8 RID: 15016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AA9 RID: 15017
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003AAA RID: 15018
		private int entityId_;
	}
}
