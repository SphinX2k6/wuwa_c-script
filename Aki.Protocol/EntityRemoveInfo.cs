using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A3 RID: 1187
	public sealed class EntityRemoveInfo : IMessage<EntityRemoveInfo>, IMessage, IEquatable<EntityRemoveInfo>, IDeepCloneable<EntityRemoveInfo>, IBufferMessage
	{
		// Token: 0x060071A0 RID: 29088 RVA: 0x0011765C File Offset: 0x0011585C
		[NullableContext(1)]
		public static EntityRemoveInfo Create()
		{
			return new EntityRemoveInfo();
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x00117663 File Offset: 0x00115863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityRemoveInfo> Parser
		{
			get
			{
				return EntityRemoveInfo._parser;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x0011766A File Offset: 0x0011586A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x0011766D File Offset: 0x0011586D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveInfo.Descriptor;
			}
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x00117674 File Offset: 0x00115874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo()
		{
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x0011767C File Offset: 0x0011587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo(EntityRemoveInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x001176AD File Offset: 0x001158AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveInfo Clone()
		{
			return new EntityRemoveInfo(this);
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x001176B5 File Offset: 0x001158B5
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x001176BD File Offset: 0x001158BD
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

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x001176C6 File Offset: 0x001158C6
		// (set) Token: 0x060071AA RID: 29098 RVA: 0x001176CE File Offset: 0x001158CE
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

		// Token: 0x060071AB RID: 29099 RVA: 0x001176D7 File Offset: 0x001158D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveInfo);
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x001176E5 File Offset: 0x001158E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x00117724 File Offset: 0x00115924
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

		// Token: 0x060071AE RID: 29102 RVA: 0x00117782 File Offset: 0x00115982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x0011778F File Offset: 0x0011598F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x00117798 File Offset: 0x00115998
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

		// Token: 0x060071B1 RID: 29105 RVA: 0x001177F0 File Offset: 0x001159F0
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

		// Token: 0x060071B2 RID: 29106 RVA: 0x00117848 File Offset: 0x00115A48
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

		// Token: 0x060071B3 RID: 29107 RVA: 0x00117898 File Offset: 0x00115A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x001178A4 File Offset: 0x00115AA4
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

		// Token: 0x04003CFF RID: 15615
		private static readonly MessageParser<EntityRemoveInfo> _parser = new MessageParser<EntityRemoveInfo>(() => new EntityRemoveInfo());

		// Token: 0x04003D00 RID: 15616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D01 RID: 15617
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D02 RID: 15618
		private long entityId_;

		// Token: 0x04003D03 RID: 15619
		public const int TypeFieldNumber = 2;

		// Token: 0x04003D04 RID: 15620
		private ERemoveEntityType type_;
	}
}
