using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046C RID: 1132
	[NetMessage(EMessageId.EntityBattleInfoRequest)]
	public sealed class EntityBattleInfoRequest : IMessage<EntityBattleInfoRequest>, IMessage, IEquatable<EntityBattleInfoRequest>, IDeepCloneable<EntityBattleInfoRequest>, IBufferMessage
	{
		// Token: 0x06006BFC RID: 27644 RVA: 0x00104958 File Offset: 0x00102B58
		[NullableContext(1)]
		public static EntityBattleInfoRequest Create()
		{
			return new EntityBattleInfoRequest();
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x0010495F File Offset: 0x00102B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x00104962 File Offset: 0x00102B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleInfoRequest.Descriptor;
			}
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00104969 File Offset: 0x00102B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest()
		{
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00104971 File Offset: 0x00102B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest(EntityBattleInfoRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00104996 File Offset: 0x00102B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoRequest Clone()
		{
			return new EntityBattleInfoRequest(this);
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06006C02 RID: 27650 RVA: 0x0010499E File Offset: 0x00102B9E
		// (set) Token: 0x06006C03 RID: 27651 RVA: 0x001049A6 File Offset: 0x00102BA6
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

		// Token: 0x06006C04 RID: 27652 RVA: 0x001049AF File Offset: 0x00102BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleInfoRequest);
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x001049BD File Offset: 0x00102BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleInfoRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001049EC File Offset: 0x00102BEC
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

		// Token: 0x06006C07 RID: 27655 RVA: 0x00104A2B File Offset: 0x00102C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x00104A38 File Offset: 0x00102C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00104A41 File Offset: 0x00102C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00104A74 File Offset: 0x00102C74
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

		// Token: 0x06006C0B RID: 27659 RVA: 0x00104AB2 File Offset: 0x00102CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBattleInfoRequest other)
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

		// Token: 0x06006C0C RID: 27660 RVA: 0x00104AE3 File Offset: 0x00102CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00104AEC File Offset: 0x00102CEC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003AC2 RID: 15042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AC3 RID: 15043
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003AC4 RID: 15044
		private long entityId_;
	}
}
