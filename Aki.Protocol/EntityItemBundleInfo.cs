using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000487 RID: 1159
	public sealed class EntityItemBundleInfo : IMessage<EntityItemBundleInfo>, IMessage, IEquatable<EntityItemBundleInfo>, IDeepCloneable<EntityItemBundleInfo>, IBufferMessage
	{
		// Token: 0x06006F42 RID: 28482 RVA: 0x00111CDD File Offset: 0x0010FEDD
		[NullableContext(1)]
		public static EntityItemBundleInfo Create()
		{
			return new EntityItemBundleInfo();
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x00111CE4 File Offset: 0x0010FEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityItemBundleInfo> Parser
		{
			get
			{
				return EntityItemBundleInfo._parser;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06006F44 RID: 28484 RVA: 0x00111CEB File Offset: 0x0010FEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06006F45 RID: 28485 RVA: 0x00111CEE File Offset: 0x0010FEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityItemBundleInfo.Descriptor;
			}
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x00111CF5 File Offset: 0x0010FEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo()
		{
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00111CFD File Offset: 0x0010FEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo(EntityItemBundleInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00111D2E File Offset: 0x0010FF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo Clone()
		{
			return new EntityItemBundleInfo(this);
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x00111D36 File Offset: 0x0010FF36
		// (set) Token: 0x06006F4A RID: 28490 RVA: 0x00111D3E File Offset: 0x0010FF3E
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

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06006F4B RID: 28491 RVA: 0x00111D47 File Offset: 0x0010FF47
		// (set) Token: 0x06006F4C RID: 28492 RVA: 0x00111D4F File Offset: 0x0010FF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00111D58 File Offset: 0x0010FF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityItemBundleInfo);
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x00111D66 File Offset: 0x0010FF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityItemBundleInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x00111DA4 File Offset: 0x0010FFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x00111DFC File Offset: 0x0010FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x00111E09 File Offset: 0x00110009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x00111E14 File Offset: 0x00110014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x00111E6C File Offset: 0x0011006C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x00111EC4 File Offset: 0x001100C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityItemBundleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x00111F14 File Offset: 0x00110114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00111F20 File Offset: 0x00110120
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C42 RID: 15426
		private static readonly MessageParser<EntityItemBundleInfo> _parser = new MessageParser<EntityItemBundleInfo>(() => new EntityItemBundleInfo());

		// Token: 0x04003C43 RID: 15427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C44 RID: 15428
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003C45 RID: 15429
		private long entityId_;

		// Token: 0x04003C46 RID: 15430
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04003C47 RID: 15431
		private int itemId_;
	}
}
