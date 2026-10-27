using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BA RID: 1210
	public sealed class EntityRemoveInfo : IMessage<EntityRemoveInfo>, IMessage, IEquatable<EntityRemoveInfo>, IDeepCloneable<EntityRemoveInfo>, IBufferMessage
	{
		// Token: 0x06007330 RID: 29488 RVA: 0x0011A77C File Offset: 0x0011897C
		[NullableContext(1)]
		public static EntityRemoveInfo Create()
		{
			return new EntityRemoveInfo();
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06007331 RID: 29489 RVA: 0x0011A783 File Offset: 0x00118983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityRemoveInfo> Parser
		{
			get
			{
				return EntityRemoveInfo._parser;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x0011A78A File Offset: 0x0011898A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x0011A78D File Offset: 0x0011898D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveInfo.Descriptor;
			}
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x0011A794 File Offset: 0x00118994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo()
		{
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x0011A79C File Offset: 0x0011899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo(EntityRemoveInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x0011A7CD File Offset: 0x001189CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo Clone()
		{
			return new EntityRemoveInfo(this);
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x0011A7D5 File Offset: 0x001189D5
		// (set) Token: 0x06007338 RID: 29496 RVA: 0x0011A7DD File Offset: 0x001189DD
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

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x0011A7E6 File Offset: 0x001189E6
		// (set) Token: 0x0600733A RID: 29498 RVA: 0x0011A7EE File Offset: 0x001189EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ERemoveEntityType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x0011A7F7 File Offset: 0x001189F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveInfo);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0011A805 File Offset: 0x00118A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0011A844 File Offset: 0x00118A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Type != ERemoveEntityType.RemoveTypeForce)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x0011A8A2 File Offset: 0x00118AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0011A8AF File Offset: 0x00118AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x0011A8B8 File Offset: 0x00118AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Type != ERemoveEntityType.RemoveTypeForce)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x0011A910 File Offset: 0x00118B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Type != ERemoveEntityType.RemoveTypeForce)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x0011A968 File Offset: 0x00118B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRemoveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Type != ERemoveEntityType.RemoveTypeForce)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x0011A9B8 File Offset: 0x00118BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x0011A9C4 File Offset: 0x00118BC4
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
						this.Type = (ERemoveEntityType)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D13 RID: 15635
		private static readonly MessageParser<EntityRemoveInfo> _parser = new MessageParser<EntityRemoveInfo>(() => new EntityRemoveInfo());

		// Token: 0x04003D14 RID: 15636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D15 RID: 15637
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D16 RID: 15638
		private long entityId_;

		// Token: 0x04003D17 RID: 15639
		public const int TypeFieldNumber = 2;

		// Token: 0x04003D18 RID: 15640
		private ERemoveEntityType type_;
	}
}
