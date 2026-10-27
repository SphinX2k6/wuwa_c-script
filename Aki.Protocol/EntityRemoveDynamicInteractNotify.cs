using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B9 RID: 1209
	[NetMessage(EMessageId.EntityRemoveDynamicInteractNotify)]
	public sealed class EntityRemoveDynamicInteractNotify : IMessage<EntityRemoveDynamicInteractNotify>, IMessage, IEquatable<EntityRemoveDynamicInteractNotify>, IDeepCloneable<EntityRemoveDynamicInteractNotify>, IBufferMessage
	{
		// Token: 0x0600731C RID: 29468 RVA: 0x0011A4B0 File Offset: 0x001186B0
		[NullableContext(1)]
		public static EntityRemoveDynamicInteractNotify Create()
		{
			return new EntityRemoveDynamicInteractNotify();
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x0011A4B7 File Offset: 0x001186B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x0011A4BA File Offset: 0x001186BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveDynamicInteractNotify.Descriptor;
			}
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0011A4C1 File Offset: 0x001186C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify()
		{
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x0011A4D4 File Offset: 0x001186D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify(EntityRemoveDynamicInteractNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x0011A505 File Offset: 0x00118705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify Clone()
		{
			return new EntityRemoveDynamicInteractNotify(this);
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06007322 RID: 29474 RVA: 0x0011A50D File Offset: 0x0011870D
		// (set) Token: 0x06007323 RID: 29475 RVA: 0x0011A515 File Offset: 0x00118715
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

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06007324 RID: 29476 RVA: 0x0011A51E File Offset: 0x0011871E
		// (set) Token: 0x06007325 RID: 29477 RVA: 0x0011A526 File Offset: 0x00118726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x0011A539 File Offset: 0x00118739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveDynamicInteractNotify);
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x0011A548 File Offset: 0x00118748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveDynamicInteractNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x0011A598 File Offset: 0x00118798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x0011A5F2 File Offset: 0x001187F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x0011A5FF File Offset: 0x001187FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x0011A608 File Offset: 0x00118808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.OptionGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x0011A668 File Offset: 0x00118868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x0011A6C4 File Offset: 0x001188C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRemoveDynamicInteractNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x0011A719 File Offset: 0x00118919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x0011A724 File Offset: 0x00118924
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OptionGuid = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D0E RID: 15630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D0F RID: 15631
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003D10 RID: 15632
		private long entityId_;

		// Token: 0x04003D11 RID: 15633
		public const int OptionGuidFieldNumber = 11;

		// Token: 0x04003D12 RID: 15634
		private string optionGuid_ = "";
	}
}
