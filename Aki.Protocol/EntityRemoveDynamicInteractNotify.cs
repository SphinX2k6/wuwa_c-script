using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A2 RID: 1186
	[NetMessage(EMessageId.EntityRemoveDynamicInteractNotify)]
	public sealed class EntityRemoveDynamicInteractNotify : IMessage<EntityRemoveDynamicInteractNotify>, IMessage, IEquatable<EntityRemoveDynamicInteractNotify>, IDeepCloneable<EntityRemoveDynamicInteractNotify>, IBufferMessage
	{
		// Token: 0x0600718C RID: 29068 RVA: 0x00117390 File Offset: 0x00115590
		[NullableContext(1)]
		public static EntityRemoveDynamicInteractNotify Create()
		{
			return new EntityRemoveDynamicInteractNotify();
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x0600718D RID: 29069 RVA: 0x00117397 File Offset: 0x00115597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x0011739A File Offset: 0x0011559A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveDynamicInteractNotify.Descriptor;
			}
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x001173A1 File Offset: 0x001155A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify()
		{
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x001173B4 File Offset: 0x001155B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify(EntityRemoveDynamicInteractNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x001173E5 File Offset: 0x001155E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveDynamicInteractNotify Clone()
		{
			return new EntityRemoveDynamicInteractNotify(this);
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x001173ED File Offset: 0x001155ED
		// (set) Token: 0x06007193 RID: 29075 RVA: 0x001173F5 File Offset: 0x001155F5
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

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06007194 RID: 29076 RVA: 0x001173FE File Offset: 0x001155FE
		// (set) Token: 0x06007195 RID: 29077 RVA: 0x00117406 File Offset: 0x00115606
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

		// Token: 0x06007196 RID: 29078 RVA: 0x00117419 File Offset: 0x00115619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveDynamicInteractNotify);
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x00117428 File Offset: 0x00115628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveDynamicInteractNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x00117478 File Offset: 0x00115678
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

		// Token: 0x06007199 RID: 29081 RVA: 0x001174D2 File Offset: 0x001156D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x001174DF File Offset: 0x001156DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x001174E8 File Offset: 0x001156E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.OptionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00117548 File Offset: 0x00115748
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

		// Token: 0x0600719D RID: 29085 RVA: 0x001175A4 File Offset: 0x001157A4
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

		// Token: 0x0600719E RID: 29086 RVA: 0x001175F9 File Offset: 0x001157F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x00117604 File Offset: 0x00115804
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
				if (num != 90U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.OptionGuid = input.ReadString();
				}
			}
		}

		// Token: 0x04003CFA RID: 15610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CFB RID: 15611
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003CFC RID: 15612
		private long entityId_;

		// Token: 0x04003CFD RID: 15613
		public const int OptionGuidFieldNumber = 11;

		// Token: 0x04003CFE RID: 15614
		private string optionGuid_ = "";
	}
}
