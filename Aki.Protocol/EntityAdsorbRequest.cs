using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000451 RID: 1105
	[NetMessage(EMessageId.EntityAdsorbRequest)]
	public sealed class EntityAdsorbRequest : IMessage<EntityAdsorbRequest>, IMessage, IEquatable<EntityAdsorbRequest>, IDeepCloneable<EntityAdsorbRequest>, IBufferMessage
	{
		// Token: 0x06006A14 RID: 27156 RVA: 0x00100AE8 File Offset: 0x000FECE8
		[NullableContext(1)]
		public static EntityAdsorbRequest Create()
		{
			return new EntityAdsorbRequest();
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x00100AEF File Offset: 0x000FECEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06006A16 RID: 27158 RVA: 0x00100AF2 File Offset: 0x000FECF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAdsorbRequest.Descriptor;
			}
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x00100AF9 File Offset: 0x000FECF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest()
		{
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x00100B01 File Offset: 0x000FED01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest(EntityAdsorbRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00100B26 File Offset: 0x000FED26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAdsorbRequest Clone()
		{
			return new EntityAdsorbRequest(this);
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x00100B2E File Offset: 0x000FED2E
		// (set) Token: 0x06006A1B RID: 27163 RVA: 0x00100B36 File Offset: 0x000FED36
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

		// Token: 0x06006A1C RID: 27164 RVA: 0x00100B3F File Offset: 0x000FED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAdsorbRequest);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00100B4D File Offset: 0x000FED4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAdsorbRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00100B7C File Offset: 0x000FED7C
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

		// Token: 0x06006A1F RID: 27167 RVA: 0x00100BBB File Offset: 0x000FEDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00100BC8 File Offset: 0x000FEDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x00100BD1 File Offset: 0x000FEDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00100C04 File Offset: 0x000FEE04
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

		// Token: 0x06006A23 RID: 27171 RVA: 0x00100C42 File Offset: 0x000FEE42
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

		// Token: 0x06006A24 RID: 27172 RVA: 0x00100C73 File Offset: 0x000FEE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x00100C7C File Offset: 0x000FEE7C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003A96 RID: 14998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A97 RID: 14999
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003A98 RID: 15000
		private int entityId_;
	}
}
